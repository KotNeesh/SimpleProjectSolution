using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleProject
{
    public interface ICommandProcessMessage : ITypeID
    {
        void Do(IParameters parameters, IMessage message);
    }
}
