
using System;

namespace SimpleProject
{
    
    class Program
    {
        static void Main(string[] args)
        {
            MessageAccount m = new MessageAccount(MessageAccount.StateType.SignUp);
            Server server = new Server();
            server.Start();
        }
    }
}
