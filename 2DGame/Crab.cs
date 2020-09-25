using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGame
{
    class Crab
    {
        public int size, x, y;
        Boolean colour;

        public Crab(int _size, int _x, int _y, Boolean _colour)
        {
            size = _size;
            colour = _colour;
            x = _x;
            y = _y;
            // decides colour of crab based upon input

            if (colour == true) //turns crab red
            {

            }
            else // turns crab orange
            {

            }
        }

        public void Move(int speed)
        {
            x += speed;
        }

    }
}
