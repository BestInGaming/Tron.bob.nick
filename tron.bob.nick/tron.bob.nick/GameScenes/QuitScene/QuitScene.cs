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
    public class QuitScene : IGameState
    {
        //fields
        private TronGame game;


        //constructor
        public QuitScene(TronGame game)
        {
            this.game = game;
            this.Initialize();
        }


        //Initialize
        public void Initialize()
        {
            this.LoadContent();
        }

        //loadContent
        public void LoadContent()
        {

        }

        //update
        public void Update(GameTime gameTime)
        {
            if (Input.EdgeDetectKeyDown(Keys.Escape))
            {
                this.game.GameState = new StartScene(this.game);
            }

            this.game.Exit();
        }

        //Draw
        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.LavenderBlush);
        }
    }
}
