using System;
using System.Collections.Generic;

namespace _05_hide_and_seek
{
    /// <summary>
    /// The Hider is responsible to watch the seeker and give hints.
    /// 
    /// Stereotype:
    ///     Information Holder
    /// </summary>
    public class Hider
    {
        // TODO: Add any member variables here

        /// <summary>
        /// Initializes the location of the hider to a random location 1-1000.
        /// Also initializes the list of distances to be a new, empty list.
        /// </summary>
        public Hider()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Computes the distance from the hider's location to the provided location of the seeker
        /// and stores it in a list of distances to use later.
        /// </summary>
        /// <param name="seekerLocation">The current location of the seeker.</param>
        public void Watch(int seekerLocation)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get's a hint.
        /// 
        /// If there is not enough information yet (fewer than 2 distances), a generic hint is given.
        /// If the seeker has found the hider, the hint notes they have been found.
        /// If the seeker is moving closer, the hint notes they are getting warmer.
        /// If the seeker is moving futher away, the hing notes they are getting colder.
        /// </summary>
        /// <returns>The hint message</returns>
        public string GetHint()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns whether the hider has been found. (Hint: the last distance is 0 in that case.)
        /// </summary>
        /// <returns>True if the hider has been found.</returns>
        public bool IsFound()
        {
            throw new NotImplementedException();
        }
    }
}
