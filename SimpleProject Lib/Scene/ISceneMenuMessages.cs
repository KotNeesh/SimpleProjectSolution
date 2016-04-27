using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleProject
{
    public interface ISceneMenuMessages
    {
        void Set(MessageChat message);
        void Set(MessageAccount message);
        void Set(MessageProfile message);
    }
}
