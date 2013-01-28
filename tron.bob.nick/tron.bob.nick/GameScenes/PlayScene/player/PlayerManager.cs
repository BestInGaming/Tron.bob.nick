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
    public class PlayerManager
    {
        private static Level level;
        private static Player1 player;

        public static Level Level
        {
            set { level = value; }
        }
        public static Player1 Player
        {
            set { player = value; }
        }

        public static void DetectCollisionOwnTail()
        {
            foreach (Tail tail in player.TailList)
            {
                if (player.Rectangle.Intersects(tail.Rectangle))
                {
                   
                }
                
            }
        }



    }
    }
