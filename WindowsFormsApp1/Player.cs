using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    internal class Player
    {

        public int width = 34;
        public int height = 22;
        public int speed= 6;
        public int x, y;

        public Player(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        public void Move(string direction, Size ss)
        {
            if (direction == "a")
            {
                x -= speed;

                if (x < 0)
                {
                    x = 0;
                }
            }

            if (direction == "d")
            {
                x += speed;

                if (x > ss.Width - width)
                {
                    x = ss.Width - width;
                }
            }

            if (direction == "w" == true)
            {
                y -= speed;
                if (y < 0)
                {
                    y = 0;
                }
            }

            if (direction == "s")
            {
                 y += speed;

                if (y > ss.Height - height)
                {
                    y = ss.Height - height;
                }
            }
          

        }
    }

}