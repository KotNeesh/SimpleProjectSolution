using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace SimpleProject
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


 

