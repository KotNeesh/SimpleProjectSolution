using UnityEngine;

namespace SimpleProject
{
    public class SceneGame : MonoBehaviour
    {
        private IScenario _scenario = new Scenario();

        public IScenario GetScenario()
        {
            return _scenario;
        }
    }
}
