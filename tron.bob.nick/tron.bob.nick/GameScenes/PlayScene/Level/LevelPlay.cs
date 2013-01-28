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
            if (Input.DetectKeydown(Keys.Escape)|| Input.DpasDetectPress(PlayerIndex.One,Buttons.Start))
            {
                this.level.Game.GameState = new StartScene(level.Game);
            }
            foreach (Player1 player in this.level.Players)
            {
                player.Update(gameTime);
            }
          
        }

        public void Draw(GameTime gameTime)
        {
            
        }
    }
}
