using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _07_snake
{
    /// <summary>
    /// The director is responsible to direct the game, including to keep track of all
    /// the actors and to control the sequence of play.
    /// 
    /// Stereotype:
    ///     Controller
    /// </summary>
    public class Director
    {
        private bool _keepPlaying = true;

        OutputService _outputService = new OutputService();
        InputService _inputService = new InputService();

        // TODO: Add this line back in when the Food class
        // is ready
        //Food _food = new Food();

        Snake _snake = new Snake();
        ScoreBoard _scoreBoard = new ScoreBoard();

        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void StartGame()
        {
            PrepareGame();

            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();

                if (_inputService.IsWindowClosing())
                {
                    _keepPlaying = false;
                }
            }

            Console.WriteLine("Game over!");
        }

        /// <summary>
        /// Performs any initial setup for the game.
        /// </summary>
        private void PrepareGame()
        {
            _outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Snake Game", Constants.FRAME_RATE);
        }

        /// <summary>
        /// Get any input needed from the user.
        /// </summary>
        private void GetInputs()
        {
            if (_inputService.IsLeftPressed())
            {
                _snake.TurnHead(new Point(-1, 0));
            }
            else if (_inputService.IsRightPressed())
            {
                _snake.TurnHead(new Point(1, 0));
            }
            else if (_inputService.IsUpPressed())
            {
                _snake.TurnHead(new Point(0, -1));
            }
            else if (_inputService.IsDownPressed())
            {
                _snake.TurnHead(new Point(0, 1));
            }
        }

        /// <summary>
        /// Update any of the actors.
        /// </summary>
        private void DoUpdates()
        {
            _snake.Move();

            HandleFoodCollision();
            HandleBodyCollision();
        }

        /// <summary>
        /// Display the updated state of the game to the user.
        /// </summary>
        private void DoOutputs()
        {
            _outputService.StartDrawing();

            _outputService.DrawActor(_scoreBoard);

            // TODO: Add this back in when the food class is complete.
            //_outputService.DrawActor(_food);
            
            _outputService.DrawActors(_snake.GetAllSegments());

            _outputService.EndDrawing();
        }

        /// <summary>
        /// Looks for and handles collisions between the snake's head
        /// and it's body.
        /// </summary>
        private void HandleBodyCollision()
        {
            Actor head = _snake.GetHead();

            List<Actor> segments = _snake.GetCollidableSegments();

            foreach(Actor segment in segments)
            {
                if (IsCollision(head, segment))
                {
                    // There is a collision
                    _keepPlaying = false;
                    break;
                }
            }
        }

        /// <summary>
        /// Looks for and handles the case of the snake's head
        /// colliding with the food.
        /// </summary>
        private void HandleFoodCollision()
        {
            // TODO: Add this code back in when
            // the food class is complete.

            // Actor head = _snake.GetHead();
            
            // if (IsCollision(head, _food))
            // {
            //     int points = _food.GetPoints();

            //     _snake.GrowTail(points);
            //     _scoreBoard.AddPoints(points);
            //     _food.Reset();
            // }
        }

        /// <summary>
        /// Returns true if the two actors are overlapping.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public bool IsCollision(Actor first, Actor second)
        {
            int x1 = first.GetX();
            int y1 = first.GetY();
            int width1 = first.GetWidth();
            int height1 = first.GetHeight();

            Raylib_cs.Rectangle rectangle1
                = new Raylib_cs.Rectangle(x1, y1, width1, height1);

            int x2 = second.GetX();
            int y2 = second.GetY();
            int width2 = second.GetWidth();
            int height2 = second.GetHeight();

            Raylib_cs.Rectangle rectangle2
                = new Raylib_cs.Rectangle(x2, y2, width2, height2);

            return Raylib.CheckCollisionRecs(rectangle1, rectangle2);
        }


    }
}
