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
    public class MenuStartScene
    {

        private enum Buttonstate { Start, Options, Leveledit, Help, Quit }

        //fields
        private Image start, options, leveledit, help, quit;
        private TronGame game;
        private int top, left, space;
        private Buttonstate buttonstate;
        private Color buttoncolor = Color.DarkGoldenrod;



        //constructor
        public MenuStartScene(TronGame game)
        {
            this.game = game;
            this.Initialize();
        }

        //Initialize
        private void Initialize()
        {
            this.buttonstate = Buttonstate.Start;
            this.top = 430;
            this.left = 3;
            this.space = 107;
            this.Loadcontent();

        }

        //loadContent
        private void Loadcontent()
        {
            this.start = new Image(this.game, new Vector2(this.left, this.top), "Buttons\\Button_start");
            this.options = new Image(this.game, new Vector2(this.left + this.space, this.top), "Buttons\\Button_load");
            this.leveledit = new Image(this.game, new Vector2(this.left + this.space * 2, this.top), "Buttons\\Button_leveleditor");
            this.help = new Image(this.game, new Vector2(this.left + this.space * 3, this.top), "Buttons\\Button_help");
            this.quit = new Image(this.game, new Vector2(this.left + this.space * 4, this.top), "Buttons\\Button_quit");


        }

        //update
        public void Update(GameTime gameTime)
        {
            if (Input.EdgeDetectKeyDown(Keys.Right))
            {
                this.buttonstate++;
                if (this.buttonstate > Buttonstate.Quit)
                {
                    this.buttonstate = Buttonstate.Start;
                }

            }

            if (Input.EdgeDetectKeyDown(Keys.Left))
            {
                this.buttonstate--;
                if (this.buttonstate < Buttonstate.Start)
                {
                    this.buttonstate = Buttonstate.Quit;
                }

            }

            ////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////keyboard buttons///////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////
            if (Input.EdgeDetectKeyDown(Keys.Enter))
            {
                if (this.buttonstate == Buttonstate.Start)
                {
                    this.game.GameState = new PlayScene(this.game);
                }

                if (this.buttonstate == Buttonstate.Options)
                {
                    this.game.GameState = new OptionScene(this.game);
                }

                if (this.buttonstate == Buttonstate.Leveledit)
                {
                    this.game.GameState = new LevelEditorScene(this.game);
                }

                if (this.buttonstate == Buttonstate.Help)
                {
                    this.game.GameState = new HelpScene(this.game);
                }

                if (this.buttonstate == Buttonstate.Quit)
                {
                    this.game.GameState = new QuitScene(this.game);

                }
            }


            ////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////mouse buttons//////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////
            if (Input.MouseEdgeDetectPressLeft())
            {
                if (this.start.Rectangle.Intersects(Input.MouseRectangle()))
                {
                    this.game.GameState = new PlayScene(this.game);
                }

                if (this.options.Rectangle.Intersects(Input.MouseRectangle()))
                {
                    this.game.GameState = new OptionScene(this.game);
                }

                if (this.leveledit.Rectangle.Intersects(Input.MouseRectangle()))
                {
                    this.game.GameState = new LevelEditorScene(this.game);
                }

                if (this.help.Rectangle.Intersects(Input.MouseRectangle()))
                {
                    this.game.GameState = new HelpScene(this.game);
                }

                if (this.quit.Rectangle.Intersects(Input.MouseRectangle()))
                {
                    this.game.GameState = new QuitScene(this.game);

                }

            }
            ////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////buttonstate met muis///////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////
            if (this.start.Rectangle.Intersects(Input.MouseRectangle()))
            {
                this.buttonstate = Buttonstate.Start;
            }

            if (this.options.Rectangle.Intersects(Input.MouseRectangle()))
            {
                this.buttonstate = Buttonstate.Options;
            }

            if (this.leveledit.Rectangle.Intersects(Input.MouseRectangle()))
            {
                this.buttonstate = Buttonstate.Leveledit;
            }

            if (this.help.Rectangle.Intersects(Input.MouseRectangle()))
            {
                this.buttonstate = Buttonstate.Help;
            }

            if (this.quit.Rectangle.Intersects(Input.MouseRectangle()))
            {
                this.buttonstate = Buttonstate.Quit;
            }

        }





        //draw
        public void Draw(GameTime gameTime)
        {
            Color buttoncolorstart = Color.White;
            Color buttoncolorload = Color.White;
            Color buttoncolorleveledit = Color.White;
            Color buttoncolorscore = Color.White;
            Color buttoncolorhelp = Color.White;
            Color buttoncolorquit = Color.White;

            switch (this.buttonstate)
            {
                case Buttonstate.Start:
                    buttoncolorstart = this.buttoncolor;
                    break;

                case Buttonstate.Options:
                    buttoncolorload = this.buttoncolor;
                    break;

                case Buttonstate.Help:
                    buttoncolorhelp = this.buttoncolor;
                    break;

                case Buttonstate.Leveledit:
                    buttoncolorleveledit = this.buttoncolor;
                    break;

                case Buttonstate.Quit:
                    buttoncolorquit = this.buttoncolor;

                    break;
                default:
                    break;
            }

            this.start.Draw(this.game.SpriteBatch, buttoncolorstart);
            this.options.Draw(this.game.SpriteBatch, buttoncolorload);
            this.leveledit.Draw(this.game.SpriteBatch, buttoncolorleveledit);
            this.help.Draw(this.game.SpriteBatch, buttoncolorhelp);
            this.quit.Draw(this.game.SpriteBatch, buttoncolorquit);
        }
    }
}
