using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ThePoint
{
    public class TheColor
    {
        private int _red;
        private int _green;
        private int _blue;

        public int Red
        {
            get { return _red; }
            set
            {
                _red = value;
                if (_red > 255)
                {
                    _red = 255;
                }
                else if (_red < 0)
                {
                    _red = 0;
                }
            }
        }

        public int Green
        {
            get { return _green; }
            set
            {
                _green = value;
                if (_green > 255)
                {
                    _green = 255;
                }
                else if (_green < 0)
                {
                    _green = 0;
                }
            }
        }

        public int Blue
        {
            get { return _blue; }
            set
            {
                _blue = value;
                if (_blue > 255)
                {
                    _blue = 255;
                }
                else if (_blue < 0)
                {
                    _blue = 0;
                }
            }
        }


        public TheColor(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
        public void ShowColor()
        {
            System.Console.WriteLine($"({Red},{Green},{Blue})");
        }
        public static TheColor MakeWhite()
        {
            return new TheColor(255, 255, 255);
        }
        public static TheColor MakeBlack() => new TheColor(0, 0, 0);
        public static TheColor MakeRed()
        {
            return new TheColor(255, 0, 0);
        }
        public static TheColor MakeOrange()
        {
            return new TheColor(255, 165, 0);
        }
        public static TheColor MakeYellow()
        {
            return new TheColor(255, 255, 0);
        }
        public static TheColor MakeGreen()
        {
            return new TheColor(0, 128, 0);
        }
        public static TheColor MakeBlue()
        {
            return new TheColor(0, 0, 255);
        }
        public static TheColor MakePurple() => new TheColor(128, 0, 128);
    }
}