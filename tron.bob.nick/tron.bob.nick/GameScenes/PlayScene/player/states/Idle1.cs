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
    public class Idle1 : DrawPlayer
    {
        private Player1 player;
        private Vector2 startpos;
        private string direction1;

        public Idle1(Player1 player) : base(player)
        {
            this.player = player;
            this.initialize();
            this.startpos = this.player.Position;
 
            
        }

        public void initialize()
        {
            
            this.LoadContent();

        }

        //loadcontent
        public void LoadContent()
        {
        }
        public override void Update(GameTime gameTime)
        {
           
          
            
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
