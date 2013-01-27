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
    public class StartScene : IGameState
    {
        //fields
        private Image background;
        private TronGame game;
        private MenuStartScene menu;


        //constructor
        public StartScene(TronGame game)
        {
            this.game = game;
           // this.background = new Image(game, Vector2.Zero, "TitleScherm\\Background");
            this.menu = new MenuStartScene(game);

        }

        //Initialize
        public void Initialize()
        {

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
                this.game.Exit();
            }
            this.menu.Update(gameTime);
        }
        //draw
        public void Draw(GameTime gameTime)
        {
           // this.background.Draw(gameTime);
            this.menu.Draw(gameTime);
        }
    }
}
