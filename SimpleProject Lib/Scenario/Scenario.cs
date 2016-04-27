using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleProject
{
    public class Scenario : IScenario
    {
        private Queue<ICommand> _commands;
        public Scenario()
        {
            _commands = new Queue<ICommand>();
        }
        public ICommand Get()
        {
            ICommand c;
            lock (_commands)
            {
                if (_commands.Count == 0) c = null;
                else c = _commands.Dequeue();
            }
            return c;
        }

        public void Set(ICommand command)
        {
            lock (_commands)
            {
                _commands.Enqueue(command);
            }
        }
    }
}
