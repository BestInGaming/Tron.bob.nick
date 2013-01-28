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
    class Grid
    {
        private Texture2D texture1px;
        private int gridSize = 16;
        private int width = 1920, height = 1080;
        private TronGame game;

        public Grid(TronGame game)
        {
            this.game = game;
            texture1px = new Texture2D(game.Graphics.GraphicsDevice, 1, 1);
            texture1px.SetData(new Color[] { Color.White });
        }
        public void draw(GameTime gameTime)
        {
             int cols = 180;
             int rows = 120;
             int centerX = 0;
             int centerY = 0;

            for (float x = -cols; x < cols; x++)
            {
                Rectangle rectangle = new Rectangle((int)(centerX + x * gridSize), 0, 1, height);
                this.game.SpriteBatch.Draw(texture1px, rectangle, Color.LightBlue);
            }
            for (float y = -rows; y < rows; y++)
            {
                Rectangle rectangle = new Rectangle(0, (int)(centerY + y * gridSize), width, 1);
                this.game.SpriteBatch.Draw(texture1px, rectangle, Color.LightBlue);
            }
        }

    }
}
