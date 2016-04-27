using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleProject
{
    public class UserProfile : IUserProfile
    {

        public String Nick { get; set; }
        public bool IsSignIn
        {
            get
            {
                return Nick != string.Empty;
            }
        }
    }
}
