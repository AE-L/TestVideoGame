using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Threading.Tasks;

namespace TestVideoGame
{
    class MainGame
    {
        //Champs
        Rectangle Player;

        //Constructeur
        public MainGame()
        {
            Player = new Rectangle(0, 0, 40, 48);
        }

        //Méthodes

        //Update et Draw
        public void Update(MouseState mouse,KeyboardState keyboard)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Ressources.Player, Player, Color.White);
        }
    }
}
