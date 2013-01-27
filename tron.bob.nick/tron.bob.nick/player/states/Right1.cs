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
    public class Right1 : DrawPlayer
    {
        private Player1 player;

        public Right1(Player1 player) : base(player)
        {
            this.player = player;
            this.initialize();
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

            this.player.Position += new Vector2(this.player.Speed, 0f);
            this.player.TailList.Add(new Tail(this.player.Game, this.player.Position + new Vector2(-8, 0), Color.Yellow));
            if (Input.DetectKeyUp(Keys.D))
            {
                this.player.State = new Idle1(player, "Right");
            }
            if (Input.DpasDetectPress(player.Index, Buttons.DPadUp))
            {
                this.player.State = new Up1(player);
            }
            if (Input.DpasDetectPress(player.Index, Buttons.DPadDown))
            {
                this.player.State = new Down1(player);
            }
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
