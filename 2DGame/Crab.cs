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
        public Image image;

        public Crab(int _size, int _x, int _y, Image _image)
        {
            size = _size;
            image = _image;
            x = _x;
            y = _y;

        }

        public void Move(int speed)
        {
            x += speed;
        }

    }
}
