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
    public class LevelPaused : ILevel
    {
        private Level level;

      
        public LevelPaused(Level level)
        {
            this.level = level; 
        }
        public void Update(GameTime gameTime)
        {
            if (Input.EdgeDetectKeyDown(Keys.Enter))
            {
                this.level.LevelState = this.level.levelplay;
            }
            if (Input.EdgeDetectKeyDown(Keys.Escape))
            {
                this.level.Game.GameState = new StartScene(this.level.Game);
            }
        }

        public void Draw(GameTime gameTime)
        {
        }
    }
}
