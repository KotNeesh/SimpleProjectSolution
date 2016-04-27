namespace SimpleProject
{
    public interface IMessagesManagerNetwork
    {
        void Set(IMessage message);
        IMessage Get();
    }
}
