using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleProject
{
    public class MessageContainer : IMessageContainer
    {
        private IMessage _message;
        public bool IsEmpty
        {
            get
            {
                return _message == null;
            }
        }
        public IMessage Get()
        {

            IMessage m;
            lock (this)
            {
                m = _message;
                _message = null;
            }
            return m;
            
        }
        public void Set(IMessage message)
        {
            lock (this)
            {
                _message = message;
            }
        }
    }
}
