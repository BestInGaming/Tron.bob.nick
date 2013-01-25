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
        private string direction1;

        public Idle1(Player1 player,string direction1) : base(player)
        {
            this.player = player;
            this.initialize();
            this.direction1 = direction1;
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
            switch (this.direction1)
            {
                case "Right": this.player.Position += new Vector2(this.player.Speed, 0);
                    break;
                case "Left": this.player.Position += new Vector2(-this.player.Speed, 0);
                    break;
                case "Up": this.player.Position += new Vector2(0, -this.player.Speed);
                    break;
                case "Down": this.player.Position += new Vector2(0, this.player.Speed);
                    break;
            }
            if (Input.EdgeDetectKeyDown(Keys.W))
            {
                this.player.State = new Up1(player);
            }
            if (Input.EdgeDetectKeyDown(Keys.S))
            {
                this.player.State = new Down1(player);
            }
            if (Input.EdgeDetectKeyDown(Keys.A))
            {
                this.player.State = new Left1(player);
            }
            if (Input.EdgeDetectKeyDown(Keys.D))
            {
                this.player.State = new Right1(player);
            }
            
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
