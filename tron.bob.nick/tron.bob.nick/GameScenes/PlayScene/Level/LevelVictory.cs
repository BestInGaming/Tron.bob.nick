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
    public class LevelVictory : ILevel
    {
        private Level level;
        private Image overlay,backGround;
        private int pauseTime = 1;
        private float timer = 0;
        private Rectangle rectangle;
        private int index = -1;
        private string removeType;

        public string RemoveType
        {
            get { return this.removeType; }
            set { this.removeType = value; }
        }

        public int Index
        {
            set { this.index = value; }
        }

        public LevelVictory(Level level)
        {
            this.level = level;
            
        }
        public void Update(GameTime gameTime)
        {

            
        }

        public void Draw(GameTime gameTime)
        {
 
        }
    }
}