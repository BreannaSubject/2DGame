using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGame
{
    class Jewel
    {
        int width, height, x, y;
        int colour;
        public Jewel (int _width, int _height, int _x, int _y, int _colour)
        {
            width = _width;
            height = _height; 
            colour = _colour;
            y = _y;
            x = _x;
        }

        public void Move(int speed)
        {
            y += speed;
        }
    }
}
