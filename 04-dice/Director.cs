using System;

namespace _04_dice
{
    /// <summary>
    /// Like a director in a play, this class is responsible for the game, the script,
    /// the actors, and all of their interactions.
    /// 
    /// For this program, it has responsibility for the score, coordinating with the
    /// player to roll, and the sequence of play.
    /// </summary>
    class Director
    {
        bool _keepPlaying = true;
        int _score = 0;
        Thrower _thrower = new Thrower();

        public void StartGame()
        {
            while (_keepPlaying)
            {
                GetInputs();

                if (_keepPlaying)
                {
                    DoUpdates();
                    DoOutputs();
                }
            }
        }

        void GetInputs()
        {
            if (!_thrower.IsFirstThrow())
            {
                Console.WriteLine("Roll again? [y/n] ");
                string choice = Console.ReadLine();
                _keepPlaying = (choice == "y");
            }
        }

        void DoUpdates()
        {
            _thrower.ThrowDice();

            if (_thrower.ContainsScoringDie())
            {
                _score += _thrower.GetPoints();
            }
            else
            {
                _score = 0;
            }
        }

        void DoOutputs()
        {
            string diceString = _thrower.GetDiceString();

            Console.WriteLine();
            Console.WriteLine($"You rolled: {diceString}");
            Console.WriteLine($"Your score is: {_score}");

            if (!_thrower.CanThrow())
            {
                Console.WriteLine("Game Over");
                _keepPlaying = false;
            }
        }

    } // end of class: Director
}
