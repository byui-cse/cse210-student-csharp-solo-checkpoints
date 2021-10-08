using System;
using System.Collections.Generic;

namespace _04_dice
{
    /// <summary>
    /// Represents the thrower in the game. Tracks the dice, the points,
    /// and the decisions around throwing again.
    /// </summary>
    class Thrower
    {
        const int NUM_DICE = 5;

        // TODO: Declare your member variables here


        /// <summary>
        /// Determines if this is the first roll.
        /// 
        /// The condition is: if the number of throws is 0.
        /// </summary>
        public bool IsFirstThrow()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines if the set of dice contains any that are scoring.
        /// 
        /// The condition is: if there is a 1 or a 5 in the list.
        /// </summary>
        public bool ContainsScoringDie()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Determines if the player can throw again.
        /// 
        /// The condition is: if it is the first throw or if the current roll
        /// contains a scoring die. (Hint, there are methods for those...)
        /// </summary>
        public bool CanThrow()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Clears the previous roll and throws a new set of dice.
        /// This also increments the number of throws counter.
        /// 
        /// The new roll will contain NUM_DICE random numbers from 1-6.
        /// </summary>
        public void ThrowDice()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the number of points associated with a single die.
        /// 
        /// The rules are:
        ///     Die value 1: 100 Points
        ///     Die value 5: 50 Points
        ///     Other values: 0 Points
        /// </summary>
        /// <param name="die">The provided die value.</param>
        /// <returns>The points associated with the provided die value.</returns>
        public int GetPointsForDie(int die)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the number of points associated with the current roll.
        /// 
        /// (Hint: There is a method to determine the points for a single die
        /// that can be called once for each die value in the current list.)
        /// </summary>
        /// <returns>The number of points.</returns>
        public int GetPoints()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a list of the current dice in the format:
        ///     [3, 2, 6, 3, 1]
        /// </summary>
        /// <returns></returns>
        public string GetDiceString()
        {
            throw new NotImplementedException();
        }
    }
}
