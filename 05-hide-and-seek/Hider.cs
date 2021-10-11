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
        public int _location;
        public List<int> _distances;
        /// <summary>
        /// Initializes the location of the hider to a random location 1-1000.
        /// Also initializes the list of distances to be a new, empty list.
        /// </summary>
        public Hider()
        {
            Random randomGenerator = new Random();
            _location = randomGenerator.Next(1, 1001);

            _distances = new List<int>();
        }

        /// <summary>
        /// Computes the distance from the hider's location to the provided location of the seeker
        /// and stores it in a list of distances to use later.
        /// </summary>
        /// <param name="seekerLocation">The current location of the seeker.</param>
        public void Watch(int seekerLocation)
        {
            // Compute the distance we have moved since last time
            int distanceMoved = Math.Abs(_location - seekerLocation);
            _distances.Add(distanceMoved);
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
            string message = "";
            if (_distances.Count < 2)
            {
                // We don't have enough information to know if we are closing in on them
                // or if we are running around in big steps, so we will just give a
                // generic message here.
                message = "You'll never find me!";
            }
            else
            {
                if (_distances[_distances.Count-1] == 0)
                {
                    message = "You found me!";
                }
                else if (_distances[_distances.Count - 1] <= _distances[_distances.Count - 2])
                {
                    // Our last movement amount was the same size or smaller than the time before,
                    // so we must be closing in on them.
                    message = "Getting Warmer!";
                }
                else
                {
                    // Our last movement amount was the same or larger, so we are just wandering around
                    message = "Getting Colder!";
                }
            }

            return message;
        }

        /// <summary>
        /// Returns whether the hider has been found. (Hint: the last distance is 0 in that case.)
        /// </summary>
        /// <returns>True if the hider has been found.</returns>
        public bool IsFound()
        {
            while (_distances.Count>0)
            {
                if (_distances[_distances.Count-1]==0)
                {
                    return true;
                }
                else{
                    break;
                }
            }
            return false;
        }
    }
}
