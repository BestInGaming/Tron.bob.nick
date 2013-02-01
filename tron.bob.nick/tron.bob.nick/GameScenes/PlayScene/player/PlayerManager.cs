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
        private static Level level;

        public static Player1 Player
        {
            set { player = value; }
        }
        public static Level Level
        {
            set { level = value; }
        }

        public static void DetectCollisionOwnTail()
        {
            foreach (Player1 p in level.Players)
            {
                foreach (Tail t in p.TailList)
                {
                    if (p.Rectangle.Intersects(t.Rectangle))
                    {
                        p.State = new Idle1(player);
                    }
                }

            }
        }

        public static void DetectCollisionTails()
        {
            foreach (Player1 p in level.Players)
            {
                switch (p.ID)
                {
                    case 1:
                        foreach (Tail t in player.TailList)
                        {
                            if (p.Rectangle.Intersects(t.Rectangle) && p.IsDead == false)
                            {
                                Score.P2++;
                                Score.P3++;
                                Score.P4++;
                                p.IsDead = true;
                                p.State = new Idle1(p);

                            }
                        }

                        break;
                    case 2:
                        foreach (Tail t in player.TailList)
                        {
                            if (p.Rectangle.Intersects(t.Rectangle) && p.IsDead == false)
                            {
                                Score.P1++;
                                Score.P3++;
                                Score.P4++;
                                p.IsDead = true;
                                p.State = new Idle1(p);
                            }
                        }
                        break;
                    case 3:
                        foreach (Tail t in player.TailList)
                        {
                            if (p.Rectangle.Intersects(t.Rectangle) && p.IsDead == false)
                            {
                                Score.P1++;
                                Score.P2++;
                                Score.P4++;
                                p.IsDead = true;
                                p.State = new Idle1(p);
                            }
                        }
                        break;
                    case 4:
                        foreach (Tail t in player.TailList)
                        {
                            if (p.Rectangle.Intersects(t.Rectangle) && p.IsDead == false)
                            {
                                Score.P1++;
                                Score.P2++;
                                Score.P3++;
                                p.IsDead = true;
                                p.State = new Idle1(p);
                            }
                        }
                        break;
                }
            }
        }
        public static void Endgame()
        {
            int deadCounter = 0;
            foreach (Player1 p in level.Players)
            {
                
                switch (p.ID)
                {
                    case 1: if (p.IsDead == true) { deadCounter += 1; }
                        break;
                    case 2: if (p.IsDead == true) { deadCounter += 1; }
                        break;
                    case 3: if (p.IsDead == true) { deadCounter += 1; }
                        break;
                    case 4: if (p.IsDead == true) { deadCounter += 1; }
                        break;
                }
                if (deadCounter == level.Players.Count-1)
                {
                    level.LevelState = level.levelpause;
                }
               
            }
            Console.WriteLine(deadCounter);
        }



    }
}
            
                            
                           
                            
                           
                            
                            
               

                
           
