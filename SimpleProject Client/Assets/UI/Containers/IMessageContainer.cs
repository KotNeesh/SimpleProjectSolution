using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleProject
{
    public interface IMessageContainer
    {
        IMessage Get();
        void Set(IMessage message);
        bool IsEmpty { get; }
    }
}
