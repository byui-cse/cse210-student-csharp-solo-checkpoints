using System;

namespace _06_nim
{
    /// <summary>
    /// Represents a person taking part in the game. This course keeps track
    /// of their name and their current move.
    /// 
    /// Stereotype:
    ///     Information Holder
    /// </summary>
    class Player
    {
        private string _name;
        private Move _move;

        /// <summary>
        /// Initializes a new player with the provided name.
        /// </summary>
        /// <param name="name">The name of the player</param>
        public Player(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetMove(Move move)
        {
            _move = move;
        }

        public Move GetMove()
        {
            return _move;
        }
    }
}
