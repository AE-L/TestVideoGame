using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;

namespace TestVideoGame
{

	public class Game1 : Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;

		public Game1 ()
		{
			graphics = new GraphicsDeviceManager (this);
			Content.RootDirectory = "Content";
		}


		protected override void Initialize ()
		{

            
			base.Initialize ();
		}

		protected override void LoadContent ()
		{

			spriteBatch = new SpriteBatch (GraphicsDevice);

		}

        protected override void UnloadContent()
        {
            Content.Unload();
        }

        protected override void Update (GameTime gameTime)
		{
			base.Update (gameTime);
		}

		protected override void Draw (GameTime gameTime)
		{
			graphics.GraphicsDevice.Clear (Color.BurlyWood);
            

            
			base.Draw (gameTime);
		}
	}
}

