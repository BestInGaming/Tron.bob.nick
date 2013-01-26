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
   public class Player1 : IDrawPlayer
    {
        private Texture2D texture;

        private TronGame game;
        private Rectangle rectangle;
        private Vector2 position;
        private float speed;
        private List<Tail> tailList = new List<Tail>();
        DrawPlayer state;
        public Texture2D Texture
        {
            get { return this.texture; }
        }

        public Rectangle Rectangle
        {
            get { return this.rectangle; }
        }
        public TronGame Game
        {
            get {  return this.game ; }
        }
        public DrawPlayer State
        {
            set {  this.state = value ; }
        }
        public List<Tail> TailList
        {
            get { return this.tailList; }
            set { this.tailList = value; }
        }
        public Vector2 Position
        {
            get { return this.position; }
            set { this.position = value;
            this.rectangle.X = (int)this.position.X;
            this.rectangle.Y = (int)this.position.Y;
            }
            
        }
        public float Speed
        {
            get { return this.speed; }
        }

        public Player1(TronGame game, Vector2 position, float speed)
        {
            this.game = game;
            this.position = position;
            this.texture = this.game.Content.Load<Texture2D>(@"IngameAssets/Player/player");
            this.rectangle = new Rectangle((int)this.position.X, (int)this.position.Y, texture.Width, texture.Height);           
            this.speed = speed;
            this.state = new Idle1(this,"Right");
        }
        public void initialize()
        {
            this.LoadContent();
        }

        //loadcontent
        public void LoadContent()
        {

        }

        public void Update(GameTime gameTime)
        {
            this.state.Update(gameTime);
            foreach (Tail tail in this.TailList)
            {
                tail.Update(gameTime);
            }
        }
        public void Draw(GameTime gameTime)
        {
            this.state.Draw(gameTime);

            foreach (Tail tail in this.TailList)
            {
                tail.Draw(gameTime);
            }
        }
    }
}
