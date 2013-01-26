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

        public Idle1(Player1 player,string direction1) : base(player)
        {
            this.player = player;
            this.initialize();
            this.startpos = this.player.Position;
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
                    if (this.startpos.X > this.player.Position.X - 16)
                    {
                        this.player.TailList.Add(new Tail(this.player.Game, this.player.Position + new Vector2(-16,0), Color.Yellow));
                        this.startpos = this.player.Position;
                    }
                    break;
                case "Left": this.player.Position += new Vector2(-this.player.Speed, 0);
                    if (this.startpos.X < this.player.Position.X + 16)
                    {
                        this.player.TailList.Add(new Tail(this.player.Game, this.player.Position + new Vector2(16,0), Color.Yellow));
                        this.startpos = this.player.Position;
                    }
                    break;
                case "Up": this.player.Position += new Vector2(0, -this.player.Speed);
                    if (this.startpos.Y > this.player.Position.Y -16)
                    {
                        this.player.TailList.Add(new Tail(this.player.Game, this.player.Position + new Vector2(0,16), Color.Yellow));
                        this.startpos = this.player.Position;
                    }
                    break;
                case "Down": this.player.Position += new Vector2(0, this.player.Speed);
                    if (this.startpos.Y < this.player.Position.Y + 16)
                    {
                        this.player.TailList.Add(new Tail(this.player.Game, this.player.Position + new Vector2(0, -16), Color.Yellow));
                        this.startpos = this.player.Position;
                    }
                    break;
                
            }
            if (Input.EdgeDetectKeyDown(Keys.W)|| Input.DpasDetectPress(player.Index,Buttons.DPadUp))
            {
                this.player.State = new Up1(player);
            }
            if (Input.EdgeDetectKeyDown(Keys.S) || Input.DpasDetectPress(player.Index, Buttons.DPadDown))
            {
                this.player.State = new Down1(player);
            }
            if (Input.EdgeDetectKeyDown(Keys.A) || Input.DpasDetectPress(player.Index, Buttons.DPadLeft))
            {
                this.player.State = new Left1(player);
            }
            if (Input.EdgeDetectKeyDown(Keys.D) || Input.DpasDetectPress(player.Index, Buttons.DPadRight))
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
