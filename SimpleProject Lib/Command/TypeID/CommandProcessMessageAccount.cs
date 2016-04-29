using System;
using SimpleProject.Mess;

namespace SimpleProject.Comm
{
    using TypeID = Byte;
    class CommandProcessMessageAccount : ICommandProcessMessage
    {
        byte ITypeID.Type
        {
            get
            {
                return (TypeID)HelperTypeID.Account;
            }
        }

        void ICommandProcessMessage.Do(IParameters parameters, IMessage message)
        {
            IParametersSceneMenuMessages p = parameters as IParametersSceneMenuMessages;
            p.Get().Set((MessageAccount)message);
        }
    }
}
