using System;

namespace _07_snake
{
    // TODO: Define the Food class here.
    class Food : Actor
    {
        private int _points = 1;
        Random r = new Random();
        
        public Food()
        {
            int x = r.Next(1, Constants.MAX_X-1);
            int y = r.Next(1, Constants.MAX_Y-1);
            _position = new Point(x,y);
        }

        public int GetPoints()
        {
            return _points;
        }
        public void Reset()
        {
            int x = r.Next(1, Constants.MAX_X-1);
            int y = r.Next(1, Constants.MAX_Y-1);
            _position = new Point(x,y);
        }

    }
}