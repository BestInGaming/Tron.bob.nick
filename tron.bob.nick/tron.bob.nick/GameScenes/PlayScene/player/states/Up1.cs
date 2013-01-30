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
    public class Up1 : DrawPlayer
    {
        private Player1 player;
        private Vector2 startPos;

        public Up1(Player1 player) : base(player)
        {
            this.player = player;
            this.startPos = this.player.Position;
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

            this.player.Position += new Vector2(0, -this.player.Speed);
            if (Input.DpasDetectPress(player.Index, Buttons.DPadLeft) || Input.RthumbStickMoveLeft(player.Index))
            {

                float modulo = (this.player.Position.Y >= 0) ?
                                this.player.Position.Y % 16 :
                                16 + this.player.Position.Y;
                if (modulo <= this.player.Speed)
                {
                    int geheelAantalmalen16 = (int)this.player.Position.Y / 16;
                    this.player.Position = (this.player.Position.Y >= 0) ?
                                              new Vector2(this.player.Position.X, geheelAantalmalen16 * 16) :
                                              new Vector2(this.player.Position.X, (geheelAantalmalen16 - 1) * 16);
                }
                    this.player.State = this.player.Left;
   
                }






                if (Input.DpasDetectPress(player.Index, Buttons.DPadRight) || Input.RthumbStickMoveRight(player.Index))
                {
                    float modulo = (this.player.Position.Y >= 0) ?
                                this.player.Position.Y % 16 :
                                16 + this.player.Position.Y;

                    if (modulo <= this.player.Speed)
                    {
                        int geheelAantalmalen16 = (int)this.player.Position.Y / 16;
                        this.player.Position = (this.player.Position.Y >= 0) ?
                                                  new Vector2(this.player.Position.X, geheelAantalmalen16 * 16) :
                                                  new Vector2(this.player.Position.X, (geheelAantalmalen16 - 1) * 16);
                        this.player.State = this.player.Right;
                    
                    }
                }
                
            
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
