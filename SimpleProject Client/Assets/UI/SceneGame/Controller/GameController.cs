using UnityEngine;

namespace SimpleProject.Sce
{
    public class LinkInfo
    {
        public Simplus Source;
        public Simplus Destination;
        public Simplus Focus;
        public bool IsReady
        {
            get
            {
                bool b1 = Source != null;
                bool b2 = Destination != null;
                return b1 && b2;
            }
        }
        public void Update(HelperMouseState state)
        {
            if (state == HelperMouseState.Down)
            {
                Source = Focus;
            }
            else if (state == HelperMouseState.Up)
            {
                if (Focus == null ||  Focus == Source || Source == null)
                {
                    Source = null;
                }
                else
                {
                    Destination = Focus;
                }
                
            }
        }
    }
    public class ShearsInfo
    {
        public Vector2 Source;
        public Vector2 Destination;
    }

    public class GameController
    {
        LinkInfo _link = new LinkInfo();
        ShearsInfo _shears = new ShearsInfo();
        MouseInfo _mouse = new MouseInfo();
        
        public LinkInfo GetLink()
        {
            return _link;
        }
        public ShearsInfo GetShears()
        {
            return _shears;
        }
        public MouseInfo GetMouse()
        {
            return _mouse;
        }
        public void SetMouse(Vector2 pos, bool isPressed)
        {
            _mouse.Pos = pos;
            _mouse.State.Set(isPressed);
        }
    }
}
