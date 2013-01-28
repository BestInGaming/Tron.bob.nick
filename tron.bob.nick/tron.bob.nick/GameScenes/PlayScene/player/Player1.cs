﻿using System;
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
        private PlayerIndex index;
        private Vector2 startposition;
        private Color colorPlayer;
        public Texture2D Texture
        {
            get { return this.texture; }
        }
        public PlayerIndex Index
        {
            get { return this.index; }
        }
        public Color ColorPlayer
        {
            get { return this.colorPlayer; }
            set { this.colorPlayer = value; }
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
        public Vector2 StartPosition
        {
            get { return this.startposition; }
            set { this.startposition = value; }
        }
        
        public float Speed
        {
            get { return this.speed; }
        }

        public Player1(TronGame game, Vector2 position, float speed,Color colorPlayer,PlayerIndex index)
        {
            this.game = game;
            this.position = position;
            this.startposition = position;
            this.texture = this.game.Content.Load<Texture2D>(@"IngameAssets/Player/player");
            this.rectangle = new Rectangle((int)this.position.X, (int)this.position.Y, texture.Width, texture.Height);           
            this.speed = speed;
            this.colorPlayer = colorPlayer;
            this.index = index;
            this.state = new Right1(this) ;
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
            PlayerManager.Player = this;
            PlayerManager.DetectCollisionOwnTail();
            foreach (Tail tail in this.TailList)
            {
                tail.Update(gameTime);

               
            }
        }
        public void Draw(GameTime gameTime)
        {
            

            foreach (Tail tail in this.TailList)
            {
                tail.Draw(gameTime);
            }
            this.state.Draw(gameTime);
        }
    }
}
