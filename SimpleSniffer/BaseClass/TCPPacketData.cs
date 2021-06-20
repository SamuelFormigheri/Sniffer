using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSniffer.BaseClass
{
    public class TCPPacketData
    {

        public struct Option
        {
            public int OptionCode { get; set; }
            public int OptionLenght { get; set; }
            public byte[] OptionData { get; set; }
            public string OptionDataString { get; set; }
            public string OptionDescription { get; set; }
        }


        public string SourcePort { get; set; }
        public string DestinyPort { get; set; }
        public uint SEQNumber { get; set; }
        public uint ACKNumber { get; set; }
        public int Offset { get; set; }
        public int Window { get; set; }


        #region Flags

        public bool[] FlagsArray { get; set; }

        public bool NS { get; set; }
        public bool CWR { get; set; }
        public bool ECE { get; set; }

        public bool URG { get; set; }
        public bool ACK { get; set; }
        public bool PSH { get; set; }
        public bool RST { get; set; }
        public bool SYN { get; set; }
        public bool FIN { get; set; }

        #endregion

        public bool[] ReservedBits { get; set; }

        public string IPVersion { get; set; }
        public int Checksum { get; set; }
        public int UrgentPointer { get; set; }
        public int TCPHeaderLenght { get; private set; }
        public List<Option> Options { get; private set; }
        public byte[] DataContent { get; private set; }

        //https://stackoverflow.com/questions/12691038/c-bits-bytes-how-do-i-retrieve-bit-values-from-a-byte
        //https://www.lifewire.com/tcp-headers-and-udp-headers-explained-817970
        public TCPPacketData(Packet packet, byte[] raw, bool isIPV6)
        {
            var headLenght = (raw[0] & 0x0F) * 4;

            this.IPVersion = isIPV6 ? "IPV6" : "IPV4";
            this.SourcePort = packet.Src_PORT;
            this.DestinyPort = packet.Des_PORT;

            var seqArray = new ArrayList(raw).GetRange(headLenght + 4, 4).OfType<byte>().ToArray();
            this.SEQNumber = BitConverter.ToUInt32(seqArray, 0);

            var ackArray = new ArrayList(raw).GetRange(headLenght + 8, 4).OfType<byte>().ToArray();
            this.ACKNumber = BitConverter.ToUInt32(ackArray, 0);

            var byte96 = raw[headLenght + 12];
            var byte96boolean = new BitArray(new byte[] { byte96 });
            var offset = byte96 >> 4;
            this.Offset = Convert.ToInt32(offset);
            this.ReservedBits = new bool[] { byte96boolean[3], byte96boolean[2], byte96boolean[1] };

            var byte97 = raw[headLenght + 13];
            var byte97Boolean = new BitArray(new byte[] { byte97 });
            this.NS = byte96boolean[0];
            this.CWR = byte97Boolean[7];
            this.ECE = byte97Boolean[6];
            this.URG = byte97Boolean[5];
            this.ACK = byte97Boolean[4];
            this.PSH = byte97Boolean[3];
            this.RST = byte97Boolean[2];
            this.SYN = byte97Boolean[1];
            this.FIN = byte97Boolean[0];
            this.FlagsArray = new bool[] { NS, CWR, ECE, URG, ACK, PSH, RST, SYN, FIN };


            var windowArray = new ArrayList(raw).GetRange(headLenght + 14, 2).OfType<byte>().ToArray();
            var windowSize = windowArray[0] * 256 + windowArray[1];
            this.Window = windowSize;

            var checksumArray = new ArrayList(raw).GetRange(headLenght + 16, 2).OfType<byte>().ToArray();
            this.Checksum = checksumArray[0] * 256 + checksumArray[1];



            var urgentPtArray = new ArrayList(raw).GetRange(headLenght + 18, 2).OfType<byte>().ToArray();
            this.UrgentPointer = urgentPtArray[0] * 256 + urgentPtArray[1];


            this.TCPHeaderLenght = Offset * 4;

            var hasOptions = TCPHeaderLenght > 20;
            if (hasOptions)
            {
                var optionsBytes = new ArrayList(raw).GetRange(headLenght + 20, TCPHeaderLenght - 20).OfType<byte>().ToArray();
                this.Options = GetOptions(optionsBytes);
            }

            var finalBytes = new ArrayList(raw).GetRange(headLenght + TCPHeaderLenght, raw.Length - (headLenght + TCPHeaderLenght)).OfType<byte>().ToArray();
            this.DataContent = finalBytes;
        }

        private List<Option> GetOptions(byte[] optionsBytes)
        {
            var options = new List<Option>();
            var lenght = optionsBytes.Length;
            var i = 0;
            while (i < lenght)
            {
                var opt = new Option();
                opt.OptionCode = optionsBytes[i];
                i++;
                if (opt.OptionCode == 0)
                {
                    opt.OptionDescription = "Fim da Lista de Opções";
                    options.Add(opt);
                    continue;
                }

                if (opt.OptionCode == 1)
                {
                    opt.OptionDescription = "Sem Operação";
                    options.Add(opt);
                    continue;
                }


                opt.OptionLenght = optionsBytes[i];
                i++;
                var optionData = new ArrayList(optionsBytes).GetRange(i, opt.OptionLenght - 2).OfType<byte>().ToArray();
                i += opt.OptionLenght - 2;
                opt.OptionData = optionData;

                switch (opt.OptionCode)
                {
                    case 2:
                        opt.OptionDescription = "Tamanho máximo de segmento";
                        opt.OptionDataString = BitConverter.ToUInt16(opt.OptionData, 0).ToString();
                        break;
                    case 3:
                        opt.OptionDescription = "Escala da Janela";
                        opt.OptionDataString = BitConverter.ToUInt16(opt.OptionData, 0).ToString();
                        break;
                    case 4:
                        opt.OptionDescription = "Confirmação seletiva (SACK) permitida";
                        break;
                    case 5:
                        opt.OptionDescription = "Confirmação Seletiva (SACK)";
                        opt.OptionDataString = string.Empty;
                        for (int j = 0; j < opt.OptionData.Length; j += 8)
                        {
                            var arrayB5 = new ArrayList(opt.OptionData).GetRange(j, 4).OfType<byte>().ToArray();
                            var arrayE5 = new ArrayList(opt.OptionData).GetRange(j + 4, 4).OfType<byte>().ToArray();
                            var valueB5 = BitConverter.ToUInt32(arrayB5, 0);
                            var valueE5 = BitConverter.ToUInt32(arrayE5, 0);
                            opt.OptionDataString += $"| {valueB5}, {valueE5} |";
                        }
                        break;
                    case 8:
                        opt.OptionDescription = "Timestamp e eco do timestamp anterior";
                        var arrayT8 = new ArrayList(opt.OptionData).GetRange(0, 4).OfType<byte>().ToArray();
                        var valueT8 = BitConverter.ToUInt32(arrayT8, 0);
                        var arrayE8 = new ArrayList(opt.OptionData).GetRange(4, 4).OfType<byte>().ToArray();
                        var valueE8 = BitConverter.ToUInt32(arrayE8, 0);
                        opt.OptionDataString += $"| {valueT8}, {valueE8} |";
                        break;
                    default:
                        opt.OptionDescription = "Opção obsoleta, ou não usada/padronizada";
                        break;
                }
                options.Add(opt);

            }

            return options;
        }
    }
}
