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
    public class PlayScene : IGameState
    {
        //fields
        private TronGame game;
        private Player1 player;
        private Level level;
        private Grid grid;
        //constructor
        public PlayScene(TronGame game)
        {
            this.game = game;
            this.player = new Player1(this.game, new Vector2(32, 32), 7.5f, Color.Red, PlayerIndex.One);
            this.level = new Level(this.game);
            this.grid = new Grid(this.game);
            this.Initialize();
        }


        //Initialize
        public void Initialize()
        {
            this.LoadContent();
        }

        //loadContent
        public void LoadContent()
        {

        }

        //update
        public void Update(GameTime gameTime)
        {
            if (Input.EdgeDetectKeyDown(Keys.Escape))
            {
                this.game.GameState = new StartScene(this.game);
            }
        
            this.level.update(gameTime);
        }

        //Draw
        public void Draw(GameTime gameTime)
        {
            this.game.GraphicsDevice.Clear(Color.Gray);
            this.level.draw(gameTime);
            
        }
    }
}
