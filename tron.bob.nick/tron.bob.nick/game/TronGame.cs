using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace tron.bob.nick
{

    public class TronGame : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Grid grid;
        private Player1 player;

        public SpriteBatch SpriteBatch
        {
            get { return this.spriteBatch; }
        }
        public GraphicsDeviceManager Graphics
        {
            get { return this.graphics; }
        }

        public TronGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 600;
            Window.Title  = "{TRON}";
            graphics.ApplyChanges();
        }

       
        protected override void Initialize()
        {

            base.Initialize();
        }


        protected override void LoadContent()
        {
         
            spriteBatch = new SpriteBatch(GraphicsDevice);
            this.grid = new Grid(this);
            this.player = new Player1(this, new Vector2(16, 16), 5f);

            
        }

        protected override void UnloadContent()
        {
            
        }


        protected override void Update(GameTime gameTime)
        {

            player.Update(gameTime);

            Input.update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            this.spriteBatch.Begin();
            this.grid.draw(gameTime);
            this.player.Draw(gameTime);
            this.spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
