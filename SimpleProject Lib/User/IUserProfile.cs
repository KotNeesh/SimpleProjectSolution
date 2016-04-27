using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleProject
{
    public interface IUserProfile
    {
        String Nick { get; set; }
        bool IsSignIn { get; }
    }
}
