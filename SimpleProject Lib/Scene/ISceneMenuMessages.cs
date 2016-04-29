using SimpleProject.Mess;

namespace SimpleProject.Sce
{
    public interface ISceneMenuMessages
    {
        void Set(MessageChat message);
        void Set(MessageAccount message);
        void Set(MessageProfile message);
    }
}
