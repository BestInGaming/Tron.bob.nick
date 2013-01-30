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
            
            this.grid = new Grid(this.game);
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
            PlayerManager.Level = this;
         this.player.Add(new Player1(this.game, new Vector2(16, 16), 8, Color.LightGreen, PlayerIndex.One,1));
         this.player.Add(new Player1(this.game, new Vector2(128, 128), 2, Color.Blue, PlayerIndex.Two,2));

        }

        //update
        public void Update(GameTime gameTime)
        {
            if (Input.EdgeDetectKeyDown(Keys.Escape))
            {
                this.game.GameState = new StartScene(this.game);
            }
           
            foreach (Player1 player in this.player)
            {
                player.Update(gameTime);
            }
        }

        //Draw
        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.Gray);
            this.grid.draw(gameTime);
            foreach (Player1 player in this.player)
            {
                player.Draw(gameTime);
            }
        }
    }
}
