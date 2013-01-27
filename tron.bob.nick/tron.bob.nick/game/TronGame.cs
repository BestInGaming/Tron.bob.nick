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
        //fields
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private IGameState gameState;   

        //properties
        public IGameState GameState
        {
            get { return this.gameState; }
            set { this.gameState = value; }
        }
        public SpriteBatch SpriteBatch
        {
            get { return this.spriteBatch; }
        }
        public GraphicsDeviceManager Graphics
        {
            get { return this.graphics; }
        }


        //constructor
        public TronGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 1980;
            graphics.PreferredBackBufferHeight = 1020;
            Window.Title  = "{TRON}";
            graphics.ApplyChanges();
        }

       
        //Initialize
        protected override void Initialize()
        {

            base.Initialize();
        }

        //LoadContent
        protected override void LoadContent()
        {
         
            spriteBatch = new SpriteBatch(GraphicsDevice);
            this.gameState = new StartScene(this);

            
        }

        protected override void UnloadContent()
        {
            
        }


        //Update
        protected override void Update(GameTime gameTime)
        {       
            this.gameState.Update(gameTime);
            Input.update();
            base.Update(gameTime);
        }


        //Draw
        protected override void Draw(GameTime gameTime)
        {
            this.spriteBatch.Begin();
            this.gameState.Draw(gameTime);
            this.spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
