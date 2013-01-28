using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Storage;
namespace tron.bob.nick
{
    public class Level
    {
        //fields
        private TronGame game;
        private List<Player1> players = new List<Player1>();
        private LevelPause levelPause;
        private Grid grid;
        private LevelPlay levelPlay;
        private LevelGameOver levelGameOver;
        private LevelOpenDoor levelOpenDoor;
        private LevelNextLevel levelNextLevel;
        private LevelVictory levelVictory;
        private LevelPaused levelPaused;
        private ILevel levelState;

        public List<Player1> Players
        {
            get { return this.players; }
        }

        public LevelVictory LevelVictory
        {
            get { return this.levelVictory; }
        }
        public LevelGameOver LevelGameOver
        {
            get { return this.levelGameOver; }
        }
        public LevelNextLevel LevelNextLevel
        {
            get { return this.levelNextLevel; }
        }
        public LevelPaused LevelPaused
        {
            get { return this.levelPaused; }
        }
        public TronGame Game
        {
            get { return this.game; }
        }
        public ILevel LevelState
        {
            set { this.levelState = value; }
            get { return this.levelState; }
        }
        public LevelPause levelpause
        {
            get { return this.levelPause; }
            set { this.levelPause = value; }
        }
        public LevelPlay levelplay
        {
            get { return this.levelPlay; }
            set { this.levelPlay = value; }
        }




        //construction
        public Level(TronGame game)
        {
            this.game = game;
            this.levelPlay = new LevelPlay(this);
            this.levelPause = new LevelPause(this);
            this.levelOpenDoor = new LevelOpenDoor(this);
            this.levelGameOver = new LevelGameOver(this);
            this.levelNextLevel = new LevelNextLevel(this);
            this.levelVictory = new LevelVictory(this);
            this.levelPaused = new LevelPaused(this);
            this.levelState = new LevelPlay(this);
            this.players.Add(new Player1(this.game,new Vector2(16,32),7.5f,Color.Orange,PlayerIndex.One));
            this.grid = new Grid(this.game);
        }





        public void update(GameTime gameTime)
        {
            PlayerManager.Level = this;
            this.levelState.Update(gameTime);
        }
        public void draw(GameTime gameTime)
        {
            this.grid.draw(gameTime);
            foreach (Player1 player in this.players)
            {
                player.Draw(gameTime);
            }
            this.levelState.Draw(gameTime);

        }
    }
}
