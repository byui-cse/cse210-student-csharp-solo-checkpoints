using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _07_snake
{
    /// <summary>
    /// Handles all the interaction with the drawing library.
    /// </summary>
    public class OutputService
    {
        private Raylib_cs.Color _backgroundColor = Raylib_cs.Color.WHITE;

        public OutputService()
        {

        }

        /// <summary>
        /// Opens a new window with the specified coordinates and title.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="title"></param>
        /// <param name="frameRate"></param>
        public void OpenWindow(int width, int height, string title, int frameRate)
        {
            Raylib.InitWindow(width, height, title);
            Raylib.SetTargetFPS(frameRate);
        }

        /// <summary>
        /// Closes the window
        /// </summary>
        public void CloseWindow()
        {
            Raylib.CloseWindow();
        }

        /// <summary>
        /// Starts the drawing process. This should be called
        /// before any draw commands.
        /// </summary>
        public void StartDrawing()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(_backgroundColor);
        }

        /// <summary>
        /// This finishes the drawing process. This should be called
        /// after all draw commands are finished.
        /// </summary>
        public void EndDrawing()
        {
            Raylib.EndDrawing();
        }

        /// <summary>
        /// Draws a rectangular box on the screen at the provided coordinates.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void DrawBox(int x, int y, int width, int height)
        {
            Raylib.DrawRectangle(x, y, width, height, Raylib_cs.Color.BLUE);            
        }

        /// <summary>
        /// Displays text on the screen at the provided coordinates.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="text"></param>
        /// <param name="darkText"></param>
        public void DrawText(int x, int y, string text, bool darkText)
        {
            Raylib_cs.Color color = Raylib_cs.Color.WHITE;

            if (darkText)
            {
                color = Raylib_cs.Color.BLACK;
            }

            Raylib.DrawText(text,
                x + Constants.DEFAULT_TEXT_OFFSET,
                y + Constants.DEFAULT_TEXT_OFFSET,
                Constants.DEFAULT_FONT_SIZE,
                color);
        }

        /// <summary>
        /// Draws a single actor.
        /// </summary>
        /// <param name="actor"></param>
        public void DrawActor(Actor actor)
        {
            int x = actor.GetX();
            int y = actor.GetY();
            int width = actor.GetWidth();
            int height = actor.GetHeight();

            bool darkText = true;

            if (actor.HasBox())
            {
                DrawBox(x, y, width, height);
                darkText = false;
            }

            if (actor.HasText())
            {
                string text = actor.GetText();
                DrawText(x, y, text, darkText);
            }
        }

        /// <summary>
        /// Draws a list of actors.
        /// </summary>
        /// <param name="actors"></param>
        public void DrawActors(List<Actor> actors)
        {
            foreach (Actor actor in actors)
            {
                DrawActor(actor);
            }
        }

    }

}