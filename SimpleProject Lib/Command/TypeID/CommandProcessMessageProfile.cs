using System;
using SimpleProject.Mess;

namespace SimpleProject.Comm
{
    using TypeID = Byte;

    class CommandProcessMessageProfile : ICommandProcessMessage
    {
        byte ITypeID.Type
        {
            get
            {
                return (TypeID)HelperTypeID.Profile;
            }
        }

        void ICommandProcessMessage.Do(IParameters parameters, IMessage message)
        {
            IParametersSceneMenuMessages p = parameters as IParametersSceneMenuMessages;
            p.Get().Set((MessageProfile)message);
        }
    }
}
