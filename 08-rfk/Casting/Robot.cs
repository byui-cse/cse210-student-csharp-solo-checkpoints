using System;

namespace _08_rfk.Casting
{
    /// <summary>
    /// The Robot is a base actor with some particular values.
    /// </summary>
    public class Robot : Actor
    {
        public Robot()
        {
            SetText("#");

            int x = Constants.MAX_X / 2;
            int y = Constants.MAX_Y / 2;
            Point position = new Point(x, y);
            SetPosition(position);

            SetVelocity(new Point(1, 0));
        }
    }
}