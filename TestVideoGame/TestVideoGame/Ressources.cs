using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TestVideoGame
{
    class Ressources
    {
        //Champs statique
        public static Texture2D Player;

        //Initialisation
        public static void LoadContent(ContentManager Content)
        {
            Player = Content.Load<Texture2D>("/sprite/char/static");
        }
    }
}
