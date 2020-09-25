﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGame
{
    class Crab
    {
        public int size, x, y;
        public Color colour;

        public Crab(int _size, int _x, int _y, Color _colour)
        {
            size = _size;
            colour = _colour;
            x = _x;
            y = _y;

        }

        public void Move(int speed)
        {
            x += speed;
        }

    }
}
