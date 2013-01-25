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
   public class Tail
    {
       private Vector2 position;
       private Rectangle rectangle;
       private Texture2D text;
       private TronGame game;
       private Color color;
       public Vector2 Position
       {
           set { this.position = value;
           }
       }
       public Tail(TronGame game, Vector2 position,Color color)
       {
           this.game = game;
           this.position = position;
           this.color = color;
           this.text = this.game.Content.Load<Texture2D>(@"InGameAssets/Player/player");
           this.rectangle = new Rectangle((int)this.position.X, (int)this.position.Y, text.Width, text.Height);

       }
       public void Update(GameTime gameTime)
       {
           rectangle.X = (int)this.position.X;
           rectangle.Y = (int)this.position.Y;
       }

       public void Draw(GameTime gameTime)
       {
           this.game.SpriteBatch.Draw(text, rectangle, this.color);
       }
    }
}
