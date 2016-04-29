using SimpleProject.Mess;
using SimpleProject.Sce;

namespace SimpleProject.Comm
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
