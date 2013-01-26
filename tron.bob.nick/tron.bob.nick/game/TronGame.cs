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
        private List<Player1> player = new List<Player1>();

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
            graphics.PreferredBackBufferWidth = 1980;
            graphics.PreferredBackBufferHeight = 1020;
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
            this.player.Add(new Player1(this,Vector2.Zero,7.5f);

            
        }

        protected override void UnloadContent()
        {
            
        }


        protected override void Update(GameTime gameTime)
        {
            foreach (Player1 player in this.player)
            {
                player.Update(gameTime);
            }

            Input.update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            this.spriteBatch.Begin();
            this.grid.draw(gameTime);
            foreach (Player1 player in this.player)
            {
                this.player.Draw(gameTime);
            }
            this.spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
