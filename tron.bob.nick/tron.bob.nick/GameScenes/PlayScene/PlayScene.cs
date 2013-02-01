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
    public class PlayScene : IGameState
    {
        //fields
        private TronGame game;
        private Level state;
        private List<Player1> player = new List<Player1>();
        private Grid grid;


        public List<Player1> Players
        {
            get { return this.player; }
        }
        //constructor
        public PlayScene(TronGame game)
        {
            this.game = game;

            this.state = new Level(this.game);
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

            this.state.update(gameTime);
        }

        //Draw
        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.Gray);
            this.state.draw(gameTime);
        }
    }
}
