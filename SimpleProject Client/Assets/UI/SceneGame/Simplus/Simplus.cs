using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SimpleProject.Sce
{
    public class Simplus
    {
        
        private GUISimplus _GUI;
        public Simplus(GameController controller, Texture2D texture, Vector2 pos)
        {
            _GUI = new GUISimplus(this, controller, texture, pos);
        }
        public bool IsFocus()
        {
            return _GUI.IsContains();
        }
        public void Draw()
        {
            _GUI.Draw();
        }
        public Vector2 Pos
        {
            get
            {
                return _GUI.Pos;
            }
        }
    }
}
