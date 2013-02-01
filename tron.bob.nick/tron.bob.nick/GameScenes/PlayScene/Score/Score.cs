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
    public class Score
    {
        private  static int points1,points2,points3,points4;

        public static int P1
        {
            get { return points1; }
            set { points1 = value; }
        }
        public static int P2
        {
            get { return points2; }
            set { points2 = value; }
        }
        public static int P3
        {
            get { return points3; }
            set { points3 = value; }
        }
        public static int P4
        {
            get { return points4; }
            set { points4 = value; }
        }

        public static void ScoreReset()
        {
            points1 = 0;
            points2 = 0;
            points3 = 0;
            points4 = 0;
        }
    }
}
