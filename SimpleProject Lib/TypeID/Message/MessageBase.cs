using System.Collections.Generic;
using SimpleProject.Use;

namespace SimpleProject.Mess
{
    public abstract class MessageBase : IMessage
    {
        public abstract byte Type { get; }
        public List<IUserNetwork> Users;
        protected MessageBase()
        {
            Users = new List<IUserNetwork>();
        }

        
    }
}


 

