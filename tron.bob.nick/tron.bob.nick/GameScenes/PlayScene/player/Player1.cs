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
        private PlayerIndex index;
        private Color colorPlayer;
        private Vector2 lastPos, startpos;
        private Up1 up;
        private Down1 down;
        private int id;
        private Left1 left;
        private Right1 right;
        private bool isDead = false;

        public bool IsDead
        {
            get { return this.isDead; }
            set { this.isDead = value; }
        }
        public Vector2 StartPos
        {
            get { return this.startpos; }
        }
        public Up1 Up
        {
            get { return this.up; }
            set { this.up = value; }
        }
        public int ID
        {
            get { return this.id; }
        }
        public Down1 Down
        {
            get { return this.down; }
            set { this.down = value; }
        }
        public Left1 Left
        {
            get { return this.left; }
            set { this.left = value; }
        }
        public Right1 Right
        {
            get { return this.right; }
            set { this.right = value; }
        }
        public Vector2 LastPos
        {
            get { return this.lastPos; }
            set { this.lastPos = value; }
        }
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
        
        public float Speed
        {
            get { return this.speed; }
        }

        public Player1(TronGame game, Vector2 position, float speed,Color colorPlayer,PlayerIndex index,int id)
        {
            this.game = game;
            this.id = id;
            
            this.position = position;
            this.startpos = position;
            this.speed = speed;
            this.colorPlayer = colorPlayer;
            this.index = index;
            this.initialize();
            
           
        }
        public void initialize()
        {
            tailList.Clear();
            this.lastPos.X = position.X;
            this.lastPos.Y = position.Y;
            this.texture = this.game.Content.Load<Texture2D>(@"IngameAssets/Player/player");
            this.rectangle = new Rectangle((int)this.position.X, (int)this.position.Y, texture.Width, texture.Height);
            this.isDead = false;
            this.up = new Up1(this);
            this.down = new Down1(this);
            this.left = new Left1(this);
            this.right = new Right1(this);
            if (id == 1)
            {
                this.state = Right;
            }
            else
                if (id == 2)
                {
                    this.state = left;
                }
                else
                    if (id == 3)
                    {
                        this.state = Right;
                    }
                    else
                        if (id == 4)
                        {
                            this.state = left;
                        }
            this.LoadContent();
        }

        //loadcontent
        public void LoadContent()
        {

        }

        public void Update(GameTime gameTime)
        {
            PlayerManager.Player = this;
            PlayerManager.DetectCollisionTails();
            PlayerManager.DetectCollisionOwnTail();
            this.state.Update(gameTime);
            switch (this.state.ToString())
            {
                case "tron.bob.nick.Up1":
                    
                    if (position != lastPos)
                    {
                        
                        this.tailList.Add( new Tail(this.game, this.lastPos, Color.Red));
                        this.lastPos = new Vector2(this.position.X, this.position.Y + texture.Height);
                        
                    }
                    break;
                case "tron.bob.nick.Down1":
                    
                    if (position != lastPos)
                    {
                        
                        this.tailList.Add( new Tail(this.game, this.lastPos, Color.Red));
                        this.lastPos = new Vector2(this.position.X, this.position.Y - texture.Height);
                    }
                    break;
                case "tron.bob.nick.Left1":
                    
                    if (position  != lastPos)
                    {
                        
                        this.tailList.Add( new Tail(this.game, this.lastPos, Color.Red));
                        this.lastPos = new Vector2(this.position.X + texture.Width, this.position.Y);
       
                    }
                    break;
                case "tron.bob.nick.Right1":
                    
                    if (position  != lastPos)
                    {
                        
                        this.tailList.Add(new Tail(this.game,this.lastPos,Color.Red));
                        this.lastPos = new Vector2(this.position.X - texture.Width, this.position.Y);
                        
                    }
                    break;
                case "tron.bob.nick.Idle1":
                    
                    break;
            }

            this.lastPos = position;
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
