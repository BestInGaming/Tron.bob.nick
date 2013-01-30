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
        private static Player1 player;
        private static PlayScene level;
        
        public static Player1 Player
        {
            set { player = value; }
        }
        public static PlayScene Level
        {
            set { level = value; }
        }

        public static void DetectCollisionOwnTail()
        {
            foreach (Tail tail in player.TailList)
            {
                if (player.Rectangle.Intersects(tail.Rectangle))
                {
                    player.Game.Exit();
                }
                
            }
        }

        public static void DetectCollisionTails()
        {
            for (int i = 0; i < level.Players.Count; i++)
            {
                for (int j = 0; j < player.TailList.Count; j++)
                {
                    
                    
                    
                    if(level.Players[i].Rectangle.Intersects(player.TailList[j].Rectangle))
                    {
                        player.Game.Exit();
                    }

                }
            }
        }


                    

                

            



    }
    }
