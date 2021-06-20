using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSniffer.BaseClass
{
    public class PacketBuilder
    {
        public Packet Build(byte[] buffer, Socket socket)
        {
            Packet packet;
            if (socket.AddressFamily == AddressFamily.InterNetwork)
                packet = new Packet(buffer);
            else
                packet = new Packet(buffer, true);

            return packet;
        }
    }
}
