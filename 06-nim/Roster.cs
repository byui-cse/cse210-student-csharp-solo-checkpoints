using System;
using System.Collections.Generic;

namespace _06_nim
{
    /// <summary>
    /// Keeps track of all the players in the game. Provides a way
    /// to get the current player and to advance to the next one.
    /// 
    /// Stereotype:
    ///     Information Holder
    /// </summary>
    class Roster
    {
        private int _currentPlayerIndex = 0;
        private List<Player> _players = new List<Player>();

        /// <summary>
        /// Adds a new player to the game.
        /// </summary>
        /// <param name="player">The new player</param>
        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }

        /// <summary>
        /// Returns the player whose turn it is.
        /// </summary>
        /// <returns></returns>
        public Player GetCurrentPlayer()
        {
            return _players[_currentPlayerIndex];
        }

        /// <summary>
        /// Advances the current player to be the next one in the roster.
        /// </summary>
        public void AdvanceNextPlayer()
        {
            _currentPlayerIndex = (_currentPlayerIndex + 1) % _players.Count;
        }
    }
}
