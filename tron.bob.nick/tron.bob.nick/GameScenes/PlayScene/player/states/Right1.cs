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
            if (Input.DpasDetectPress(player.Index, Buttons.DPadUp) || Input.RthumbStickMoveUp(player.Index))
            {
                 float modulo = (this.player.Position.X >= 0) ? this.player.Position.X % 16 : 16 + this.player.Position.X % 16;
                if (modulo >= (16f - this.player.Speed))
                {
                    int geheelAantalmalen16 = (int)this.player.Position.X / 16;
                    this.player.Position = (this.player.Position.X >= 0) ? new Vector2((geheelAantalmalen16 + 1) * 16, this.player.Position.Y) :
                                                                                new Vector2(geheelAantalmalen16 * 16, this.player.Position.Y);
                }
               
                this.player.State = this.player.Up;
                
            }






            if (Input.DpasDetectPress(player.Index, Buttons.DPadDown) || Input.RthumbStickMoveDown(player.Index))
            {
                float modulo = (this.player.Position.X >= 0) ? this.player.Position.X % 16 : 16 + this.player.Position.X % 16;
                if (modulo >= (16f - this.player.Speed))
                {
                    int geheelAantalmalen16 = (int)this.player.Position.X / 16;
                    this.player.Position = (this.player.Position.X >= 0) ? new Vector2((geheelAantalmalen16 + 1) * 16, this.player.Position.Y) :
                                                                                new Vector2(geheelAantalmalen16 * 16, this.player.Position.Y);
                }
                this.player.State = this.player.Down;
            }
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
