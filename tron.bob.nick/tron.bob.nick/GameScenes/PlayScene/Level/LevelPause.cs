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
    public class LevelPause : ILevel
    {
        private Level level;
        private Image overlay;
    

       

     

        public LevelPause(Level level)
        {
            this.level = level;
            this.overlay = new Image(this.level.Game, Vector2.Zero, @"InGameAssets/overlay/NextGame");
        }
        public void Update(GameTime gameTime)
        {
            if (Input.EdgeDetectKeyDown(Keys.Space))
            {
                foreach (Player1 p in this.level.Players)
                {
                    p.Position = p.StartPos;
                    p.initialize();
                    this.level.LevelState = level.levelplay;
                }
            }
        }


        public void Draw(GameTime gameTime)
        {
            this.overlay.Draw(gameTime);
        }
    }
}
