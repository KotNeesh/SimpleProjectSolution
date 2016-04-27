using System;
using UnityEngine;
using System.Collections.Generic;
namespace SimpleProject
{
    public class SceneMenu : MonoBehaviour, ISceneMenuMessages
    {
        public GUIAccount Account;
        public GUISign Sign;
        public GUIChat Chat;
        public GUIProfile Profile;
        private IScenario _scenario = new Scenario();

        private bool _isSignIn = false;
        public IScenario GetScenario()
        {
            return _scenario;
        }

        public void SetStateSignIn(bool isSignIn)
        {
            _isSignIn = isSignIn;
            Account.SetStateSignIn(_isSignIn);
            Chat.SetStateSignIn(_isSignIn);
            Profile.SetStateSignIn(_isSignIn);
        }
        public void Start()
        {
            SetStateSignIn(false);
        }
        public void Update()
        {
        }

        void ISceneMenuMessages.Set(MessageChat message)
        {
            Chat.Set(message);
        }

        void ISceneMenuMessages.Set(MessageAccount message)
        {
            Sign.Set(message);
        }

        void ISceneMenuMessages.Set(MessageProfile message)
        {
            Profile.Set(message);
        }
    }
}
