using System;
using System.Collections.Generic;

namespace _05_hide_and_seek
{
    /// <summary>
    /// The responsibility of this class is to move from location to location
    /// in pursuit of the Hider. And to track how far the seeker has moved since
    /// the most recent location.
    /// 
    /// Stereotype:
    ///     Information Holder
    /// </summary>
    public class Seeker
    {
        // In the future, we'll make some of these member variables/functions private,
        // but for now, we'll just make everything public, until we discuss it in more detail.

        public int _location;
        public List<int> _distances;

        /// <summary>
        /// Initializes the location of the seeker to a random location 1-1000.
        /// Also initializes the list of distances traveled to be a new, empty list.
        /// </summary>
        public Seeker()
        {
            // Start at a new random position from 1-1000
            Random randomGenerator = new Random();
            _location = randomGenerator.Next(1, 1001);

            // Set up the list to track the distances we have traveled.            
            _distances = new List<int>();
        }

        /// <summary>
        /// Gets a message based on whether the most recent distance traveled is
        /// more or less than the last time the seeker moved.
        /// 
        /// If there is not enough information yet (fewer than 2 distances), a generic message is given
        /// If the distance traveled is smaller than the time before, the message
        ///     notes that the seeker is sneaking in.
        /// If the distance traveled is larger than the time before, the message
        ///     notes that the seeker is just wandering around.
        /// </summary>
        /// <returns>The message</returns>
        public string GetMessage()
        {
            string message = "";
            
            if (_distances.Count < 2)
            {
                // We don't have enough information to know if we are closing in on them
                // or if we are running around in big steps, so we will just give a
                // generic message here.
                message = "I'm going to find you!";
            }
            else
            {
                if (_distances[_distances.Count - 1] <= _distances[_distances.Count - 2])
                {
                    // Our last movement amount was the same size or smaller than the time before,
                    // so we must be closing in on them.
                    message = "Shhh. I'm sneaking in now...";
                }
                else
                {
                    // Our last movement amount was the same or larger, so we are just wandering around
                    message = "I'm just running around, but I'll find you...";
                }
            }

            return message;
        }

        /// <summary>
        /// Moves the seeker to a new location and computes (and saves) the distance traveled.
        /// </summary>
        /// <param name="newLocation">The new seeker location</param>
        public void Move(int newLocation)
        {
            // Compute the distance we have moved since last time
            int distanceMoved = Math.Abs(_location - newLocation);
            _distances.Add(distanceMoved);

            // Update the current location
            _location = newLocation;
        }
    }
}
