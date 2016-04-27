using System.Collections.Generic;
using System.Net.Sockets;

namespace SimpleProject
{
    public class UserNetwork : IUserNetwork
    {
        public TcpClient Socket { get; set; }
        public Queue<Packet> PacketsSend { get; }
        public Packet PacketReceive { get; }

        public UserNetwork(TcpClient client = null)
        {
            PacketsSend = new Queue<Packet>();
            PacketReceive = new Packet();
            if (client == null)
            {
                Socket = new TcpClient();
            }
            else
            {
                Socket = client;
            }
        }
            
    }
}
