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
    public class LevelPlay : ILevel
    {
        private Level level;

        public LevelPlay(Level level)
        {
            this.level = level;
        }
        public void Update(GameTime gameTime)
        {
            if (Input.DetectKeydown(Keys.Escape))
            {
                this.level.LevelState = this.level.LevelPaused;
            }
            if (this.level.Explorer != null)
            {
                this.level.Explorer.Update(gameTime);
            }
            /*MovingBlockManager.Explorer = this.level.Explorer;
            foreach (MovingBlock block in this.level.MovingBlocks)
            {
                block.Update(gameTime, this.level.Explorer);
            }*/
        }

        public void Draw(GameTime gameTime)
        {
        }
    }
}
