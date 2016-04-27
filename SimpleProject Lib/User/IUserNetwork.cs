using System.Collections.Generic;
using System.Net.Sockets;

namespace SimpleProject
{
    public interface IUserNetwork
    {
        TcpClient Socket { get; set; }
        Queue<Packet> PacketsSend { get; }
        Packet PacketReceive { get; }
    }
}
