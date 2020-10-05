using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DGame
{
    class Hero
    {
        public int width, height, x, y; 
        public Hero (int _width, int _height, int _x, int _y)
        {
            width = _width;
            height = _height;
            x = _x;
            y = _y;
        }

        public void Move(int speed)
        {
            if (Form1.leftArrowDown == true && x < 900)
            {
                x -= speed; 
            }
            else if (Form1.rightArrowDown == true && x > 0)
            {
                x += speed;
            }
            else if (Form1.upArrowDown == true)
            {
                y -= speed;
            }
            else if (Form1.downArrowDown == true)
            {
                y += speed;
            }
        }
    }
}
