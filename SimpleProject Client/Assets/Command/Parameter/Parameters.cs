using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleProject
{
    class Parameters : IParameters,
        IParametersSceneMenuMessages,
        IParametersMessagesManagerScenario
    {
        MessagesManager _messagesManager;
        SceneMenu _scene;
        public Parameters(MessagesManager messagesManager, SceneMenu scene)
        {
            _messagesManager = messagesManager;
            _scene = scene;
        }

        

        ISceneMenuMessages IParametersSceneMenuMessages.Get()
        {
            return _scene;
        }

        IMessagesManagerScenario IParametersMessagesManagerScenario.Get()
        {
            return _messagesManager;
        }
    }
}
