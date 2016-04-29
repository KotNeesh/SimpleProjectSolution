using System.Collections.Generic;
using System.Threading;
using SimpleProject.Sys;

namespace SimpleProject.Comm
{
    public class ScenarioMachine : StateMachine
    {
        IParameters _parameters;
        List<IScenario> _scenarios;
        public ScenarioMachine(IParameters parameters)
        {
            _parameters = parameters;
            _scenarios = new List<IScenario>();
        }
        public void AddScenario(IScenario scenario)
        {
            _scenarios.Add(scenario);
        }
        protected override bool Init()
        {
            return true;
        }
        protected override void Deinit()
        {
            _scenarios = null;
        }

        protected override bool DoAnytghing()
        {
            foreach(IScenario s in _scenarios)
            {
                while (true)
                {
                    ICommand c = s.Get();
                    if (c == null) break;
                    c.Do(_parameters);
                }
            }
            Thread.Sleep(100);
            return true;
        }
    }
}
