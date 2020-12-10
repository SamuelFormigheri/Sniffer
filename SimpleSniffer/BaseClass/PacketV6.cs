using System;
using System.Net;

namespace SimpleSniffer.BaseClass
{
    public class PacketV6
    {

        public byte ipVersion;

        public byte ipTrafficClass;

        public uint ipFlow;

        public ushort ipPayloadLength;

        public byte ipNextHeader;

        public byte ipHopLimit;

        public IPAddress ipSourceAddress;

        public IPAddress ipDestinationAddress;

        public int Ipv6HeaderLength = 40;



        /// <summary>

        /// Simple constructor for the IPv6 header that initializes the fields to zero.

        /// </summary>

        public PacketV6()
        {
            ipVersion = 6;
            ipTrafficClass = 0;
            ipFlow = 0;
            ipPayloadLength = 0;
            ipNextHeader = 0;
            ipHopLimit = 32;
            ipSourceAddress = IPAddress.IPv6Any;
            ipDestinationAddress = IPAddress.IPv6Any;
        }

        /// <summary>
        /// Gets and sets the flow value for the packet. Byte order conversion
        /// is required for this field.
        /// </summary>
        public uint Flow
        {
            get { return (uint)IPAddress.NetworkToHostOrder((int)ipFlow); }
            set { ipFlow = (uint)IPAddress.HostToNetworkOrder((int)value); }
        }

        /// <summary>
        /// This routine creates an instance of the Ipv6Header class from a byte
        /// array that is a received IGMP packet. This is useful when a packet
        /// is received from the network and the header object needs to be
        /// constructed from those values.
        /// </summary>
        /// <param name="ipv6Packet">Byte array containing the binary IPv6 header</param>
        /// <returns>Returns the Ipv6Header object created from the byte array</returns>
        public PacketV6 Create(byte[] ipv6Packet)
        {

            PacketV6 ipv6Header = new PacketV6();

            if (ipv6Packet.Length < ipv6Header.Ipv6HeaderLength)
                return null;

            byte[] addressBytes = new byte[16];
            uint tempVal, tempVal2;

            tempVal = ipv6Packet[0];
            tempVal = (tempVal >> 4) & 0xF;
            ipv6Header.ipVersion = (byte)tempVal;

            tempVal = ipv6Packet[0];
            tempVal = (tempVal & 0xF) >> 4;
            ipv6Header.ipTrafficClass = (byte)(tempVal | (uint)((ipv6Packet[1] >> 4) & 0xF));

            tempVal2 = ipv6Packet[1];
            tempVal2 = (tempVal2 & 0xF) << 16;
            tempVal = ipv6Packet[2];
            tempVal = tempVal << 8;
            ipv6Header.ipFlow = tempVal2 | tempVal | ipv6Packet[3];

            ipv6Header.ipNextHeader = ipv6Packet[4];
            ipv6Header.ipHopLimit = ipv6Packet[5];

            Array.Copy(ipv6Packet, 6, addressBytes, 0, 16);
            ipv6Header.ipSourceAddress = new IPAddress(addressBytes);

            Array.Copy(ipv6Packet, 24, addressBytes, 0, 16);
            ipv6Header.ipDestinationAddress = new IPAddress(addressBytes);

            return ipv6Header;

        }

        /// <summary>

        /// Packages up the IPv6 header and the given payload into a byte array

        /// suitable for sending on a socket.

        /// </summary>

        /// <param name="payLoad">Data encapsulated by the IPv6 header</param>

        /// <returns>Byte array of the IPv6 packet and payload</returns>

        public byte[] GetProtocolPacketBytes(byte[] payLoad)
        {

            byte[] byteValue, ipv6Packet;
            int offset = 0;

            ipv6Packet = new byte[Ipv6HeaderLength + payLoad.Length];
            ipv6Packet[offset++] = (byte)((ipVersion << 4) | ((ipTrafficClass >> 4) & 0xF));

            ipv6Packet[offset++] = (byte)((uint)((ipTrafficClass << 4) & 0xF0) | (uint)((Flow >> 16) & 0xF));
            ipv6Packet[offset++] = (byte)((Flow >> 8) & 0xFF);
            ipv6Packet[offset++] = (byte)(Flow & 0xFF);

            byteValue = BitConverter.GetBytes(ipPayloadLength);

            Array.Copy(byteValue, 0, ipv6Packet, offset, byteValue.Length);
            offset += byteValue.Length;

            ipv6Packet[offset++] = (byte)ipNextHeader;
            ipv6Packet[offset++] = (byte)ipHopLimit;

            byteValue = ipSourceAddress.GetAddressBytes();

            Array.Copy(byteValue, 0, ipv6Packet, offset, byteValue.Length);
            offset += byteValue.Length;

            byteValue = ipDestinationAddress.GetAddressBytes();
            Array.Copy(byteValue, 0, ipv6Packet, offset, byteValue.Length);

            offset += byteValue.Length;
            Array.Copy(payLoad, 0, ipv6Packet, offset, payLoad.Length);

            return ipv6Packet;

        }
    }
}