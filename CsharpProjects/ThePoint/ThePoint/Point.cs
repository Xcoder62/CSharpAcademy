using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThePoint
{
    public class Point
    {
        private int _X { get; set; }
        private int _Y { get; set; }
        public Point()
        {
            _X = 0;
            _Y = 0;
        }
        public Point(int x, int y)
        {
            _X = x;
            _Y = y;
        }

        public void Show(){
            System.Console.WriteLine($"({_X},{_Y})");
        }

    }

    
}