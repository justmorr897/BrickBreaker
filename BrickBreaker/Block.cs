using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    public class Block
    {
        public int width = 50;
        public int height = 25;
        public int x, y, hp;
        public Color colour;

        //animation
        public int frame;
        public int flow = 1;
        public Image image;

        public static Random rand = new Random();

        public Block(int _x, int _y, int _hp, Color _colour)
        {
            x = _x;
            y = _y;
            hp = _hp;
            colour = _colour;
            frame = rand.Next(1, 4);
        }

        public bool CrossHairCollision(Block block, Rectangle _crosshairRectangle)
        {
            Rectangle blockRec = new Rectangle(block.x, block.y, block.width, block.height);

            return blockRec.IntersectsWith(_crosshairRectangle);
        }
    }
}
