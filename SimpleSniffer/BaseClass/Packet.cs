using System;
using System.Net;
using System.Text;

namespace SimpleSniffer.BaseClass
{
    public class Packet
    {
        private const int LineCount = 30;

        /// <summary>
        /// use enumeration to identify the protocol type;
        /// </summary>
        enum ProtocolType
        {
            ICMP = 1,
            IGMP = 2,
            GGP = 3,
            IP = 4,
            TCP = 6,
            PUP = 12,
            IDP = 22,
            UDP = 17,
            ND = 77,
            OTHERS = -1
        }

        /// <summary>
        /// the original packet sniffed in the underlying layer;
        /// </summary>
        private byte[] raw_Packet;

        /// <summary>
        /// the sniffed time;
        /// </summary>
        private DateTime dateTime;

        /// <summary>
        /// protocol type of the packet;
        /// </summary>
        private ProtocolType protocolType;
        private int protocolTypeCode;

        private IPAddress src_IPAddress;

        private IPAddress des_IPAddress;

        private int src_Port;

        private int des_Port;

        private bool isIPV6;

        private int totalLength;

        private int headLength;

        //just for test
        public int HeadLength
        {
            get
            {
                return headLength;
            }
        }


        /// <summary>
        /// using the raw and current system time to initialize the packet;
        /// </summary>
        /// <param name="raw"></param>
        /// <param name="time"></param>
        public Packet(byte[] raw)
        {
            ///all the following exceptions should be caught when invoking this constructor;
            if (raw == null)
                throw new ArgumentNullException();

            ///when the orginal length is less than 20, it must be wrong;
            if (raw.Length < 20)
                throw new ArgumentException();
            raw_Packet = raw;
            dateTime = DateTime.Now;///the time sniffed the packet;

            ///get the headlength in the packet;
            headLength = (raw[0] & 0x0F) * 4;
            if ((raw[0] & 0x0F) < 5)
                throw new ArgumentException(); // header is wrong for the length is incorrect;

            ///the actual length is the same with the header length indicator?
            if ((raw[2] * 256 + raw[3]) != raw.Length)
                throw new ArgumentException(); // length is incorrect;

            ///get the type of the packet;
            if (Enum.IsDefined(typeof(ProtocolType), (int)raw[9]))
                protocolType = (ProtocolType)raw[9];
            else
            {
                System.Windows.Forms.MessageBox.Show($"{(int)raw[9]}");
                protocolType = ProtocolType.OTHERS;
            }

            src_IPAddress = new IPAddress(BitConverter.ToUInt32(raw, 12));
            des_IPAddress = new IPAddress(BitConverter.ToUInt32(raw, 16));
            totalLength = raw[2] * 256 + raw[3];

            ///handle the TCP OR UDP in particular method;
            if (protocolType == ProtocolType.TCP || protocolType == ProtocolType.UDP)
            {
                src_Port = raw[headLength] * 256 + raw[headLength + 1];
                des_Port = raw[headLength + 2] * 256 + raw[headLength + 3];
                if (protocolType == ProtocolType.TCP)
                {
                    headLength += 20;
                }
                else if (protocolType == ProtocolType.UDP)
                {
                    headLength += 8;
                }
            }
            else
            {
                src_Port = -1;
                des_Port = -1;
            }

        }

        private static System.Collections.Generic.List<int> otherprotocols = new System.Collections.Generic.List<int>();

        /// <summary>
        /// using the raw and current system time to initialize the packet;
        /// </summary>
        /// <param name="raw"></param>
        /// <param name="time"></param>
        public Packet(byte[] raw, bool isIpv6)
        {
            ///all the following exceptions should be caught when invoking this constructor;
            if (raw == null)
                throw new ArgumentNullException();

            ///when the orginal length is less than the header lenght of ipv6 = 40, it must be wrong;
            if (raw.Length < 40)
                throw new ArgumentException();

            PacketV6 ipv6Data = new PacketV6();
            ipv6Data = ipv6Data.Create(raw);
            this.isIPV6 = isIpv6;

            raw_Packet = raw;
            dateTime = DateTime.Now;
            headLength = ipv6Data.Ipv6HeaderLength;
            src_IPAddress = ipv6Data.ipSourceAddress;
            des_IPAddress = ipv6Data.ipDestinationAddress;
            totalLength = ipv6Data.ipPayloadLength;

            //Baseado na tabela no site da cisco https://www.cisco.com/en/US/technologies/tk648/tk872/technologies_white_paper0900aecd8054d37d.html
            switch (ipv6Data.ipNextHeader)
            {
                case 6:
                    protocolType = ProtocolType.TCP;
                    break;
                case 17:
                    protocolType = ProtocolType.UDP;
                    break;
                case 58:
                    protocolType = ProtocolType.ICMP;
                    break;
                default:
                    protocolType = ProtocolType.OTHERS;
                    if (!otherprotocols.Contains(ipv6Data.ipNextHeader))
                        otherprotocols.Add(ipv6Data.ipNextHeader);
                    break;
            }

        }


        public TCPPacketData GetTCPPacketData()
        {
            if (this.protocolType != ProtocolType.TCP)
                return null;

            var tcpData = new TCPPacketData(this, raw_Packet, isIPV6);

            return tcpData;
        }


        /// <summary>
        /// the accessible source IP address;
        /// </summary>
        public string Src_IP
        {
            get
            {
                return src_IPAddress.ToString();
                //return "127.0.0.1";
            }
        }

        /// <summary>
        /// the accessible source PORT;
        /// </summary>
        public string Src_PORT
        {
            get
            {
                if (src_Port != -1)
                    return src_Port.ToString();
                else
                    return "";
            }
        }

        /// <summary>
        /// the accessible destination IP address;
        /// </summary>
        public string Des_IP
        {
            get
            {
                return des_IPAddress.ToString();
            }
        }

        /// <summary>
        /// the accessible destination PORT;
        /// </summary>
        public string Des_PORT
        {
            get
            {
                if (des_Port != -1)
                    return des_Port.ToString();
                else
                    return "";
            }
        }

        /// <summary>
        /// the type of the packet;
        /// </summary>
        public string Type
        {
            get
            {
                return protocolType.ToString();
            }
        }

        /// <summary>
        /// the total length of the packet;
        /// </summary>
        public int TotalLength
        {
            get
            {
                return totalLength;
            }
        }

        /// <summary>
        /// the visibly formatted time;
        /// </summary>
        public string Time
        {
            get
            {
                return dateTime.ToLongTimeString();
            }
        }

        /// <summary>
        /// return the hexdecimal format of the packet ignoring the headers in the underlying layers;
        /// </summary>
        /// <returns></returns>
        public string getHexString()
        {
            StringBuilder sb = new StringBuilder(raw_Packet.Length);
            for (int i = headLength; i < TotalLength; i += LineCount)
            {
                for (int j = i; j < TotalLength && j < i + LineCount; j++)
                {
                    sb.Append(raw_Packet[j].ToString("X2") + " ");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }

        /// <summary>
        /// return the character format of the packet ignoring the headers in the underlying layers;
        /// </summary>
        /// <returns></returns>
        public string getCharString()
        {

            StringBuilder sb = new StringBuilder();

            for (int i = this.HeadLength; i < TotalLength; i += LineCount)
            {
                for (int j = i; j < TotalLength && j < i + LineCount; j++)
                {
                    if (raw_Packet[j] > 31 && raw_Packet[j] < 128)
                        sb.Append((char)raw_Packet[j]);
                    else
                        sb.Append(".");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}