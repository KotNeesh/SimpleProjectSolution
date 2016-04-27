﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace SimpleProject
{
    public class ButtonSign : MonoBehaviour
    {
        public Text TextButton;

        public void SetState(MessageAccount.StateType state)
        {
            if (state == MessageAccount.StateType.SignIn)
            {
                TextButton.text = "SignIn";
            }
            else if (state == MessageAccount.StateType.SignUp)
            {
                TextButton.text = "SignUp";
            }
            else if (state == MessageAccount.StateType.SignOut)
            {
                TextButton.text = "SignOut";
            }
            else if (state == MessageAccount.StateType.ChangePassword)
            {
                TextButton.text = "Change";
            }
        }
    }
}