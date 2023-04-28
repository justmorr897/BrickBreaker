using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    internal class Fire
    {
        public int i, x, y = 0;
        public int size = 15;
        public SolidBrush fireColour = new SolidBrush(Color.Yellow);
        Random random = new Random();
        public Fire(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void Move()
        {
            if (GameScreen.fireBallTimer > 0)
            {
                i += random.Next(1, 4);
            }
            else
            {
                i += random.Next(20, 30);
            }

            if (i > 20 && i < 275)
            {
                fireColour.Color = Color.FromArgb(255, 255 - (i - 20), 0);
                x += random.Next(-1, 2);
                y += random.Next(-1, 2);
            }
            if (i > 150 && i < 300)
            {
                x += random.Next(-2, 3);
                y += random.Next(-2, 3);
                if (i < 160)
                {
                    size = 165 - i;
                }
            }
        }
    }
}
