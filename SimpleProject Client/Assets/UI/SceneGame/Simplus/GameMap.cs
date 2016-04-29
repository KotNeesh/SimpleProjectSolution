using UnityEngine;

namespace SimpleProject.Sce
{
    public class GameMap
    {
        Simplus _simplus;
        public GameMap(GameController controller)
        {
            Texture2D texture = Resources.Load<Texture2D>("TextureSimpluses");
            _simplus = new Simplus(controller, texture, new Vector2(300, 150));
        }
        public Simplus FindFocusSimplus()
        {
            if (_simplus.IsFocus())
            {
                return _simplus;
            }
            else return null;
        }
        public void Draw()
        {
            _simplus.Draw();
        }
    }
}
