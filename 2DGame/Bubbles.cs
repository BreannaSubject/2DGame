using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGame
{
    class Bubbles
    {
        public int size, x, y;
        public Bubbles (int _size, int _x, int _y)
        {
            size = _size;
            y = _y;
            x = _x;
        }

        public void Move(int speed)
        {
            y += speed;
        }
    }
}
