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
    public abstract class DrawPlayer
    {
        //Field
        private IDrawPlayer drawPlayer;
        //Constructor
        public DrawPlayer(IDrawPlayer DrawPlayer)
        {
            this.drawPlayer = DrawPlayer;
        }
        public virtual void Update(GameTime gameTime)
        {
        }

        public virtual void Draw(GameTime gameTime)
        {
            this.drawPlayer.Game.SpriteBatch.Draw(this.drawPlayer.Texture,
                                              this.drawPlayer.Rectangle,
                                              Color.Red);
        }
    }
}