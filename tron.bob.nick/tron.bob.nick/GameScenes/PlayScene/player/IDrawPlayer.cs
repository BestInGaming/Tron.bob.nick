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
   public interface IDrawPlayer
    {
        TronGame Game { get; }
        Rectangle Rectangle { get; }
        Texture2D Texture { get; }
        Color ColorPlayer { get; }
    }
}
