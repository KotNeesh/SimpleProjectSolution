using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleProject
{
    public class CommandSendMessageNetwork : ICommand
    {
        IMessage _message;
        public CommandSendMessageNetwork(IMessage message)
        {
            _message = message;
        }

        void ICommand.Do(IParameters parameters)
        {
            IParametersMessagesManagerScenario p = parameters as IParametersMessagesManagerScenario;
            p.Get().Set(_message);
        }
    }
}
