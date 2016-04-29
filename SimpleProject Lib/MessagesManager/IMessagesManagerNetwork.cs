namespace SimpleProject.Mess
{
    public interface IMessagesManagerNetwork
    {
        void Set(IMessage message);
        IMessage Get();
    }
}
