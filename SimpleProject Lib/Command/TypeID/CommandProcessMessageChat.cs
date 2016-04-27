using System;

namespace SimpleProject
{
    using TypeID = Byte;
    class CommandProcessMessageChat : ICommandProcessMessage
    {
        byte ITypeID.Type
        {
            get
            {
                return (TypeID)HelperTypeID.Chat;
            }
        }

        void ICommandProcessMessage.Do(IParameters parameters, IMessage message)
        {
            IParametersSceneMenuMessages p = parameters as IParametersSceneMenuMessages;
            p.Get().Set((MessageChat)message);
        }
    }
}
