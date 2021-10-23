using System;

namespace _07_snake
{
    /// <summary>
    /// Represents a square in the snakes body.
    /// </summary>
    class Segment : Actor
    {
        
        public Segment(Point position, Point velocity)
        {
            _position = position;
            _velocity = velocity;
        }
        
    }

}