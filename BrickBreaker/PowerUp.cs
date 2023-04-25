using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    internal class PowerUp
    {
        public int type, x, y;
        public int size = 20;
        public SolidBrush powerupBrush = new SolidBrush(Color.White);
        public PowerUp(int _type, int _x, int _y)
        {
            type = _type;
            x = _x;
            y = _y;

            switch (type)
            {
                case 1:
                    powerupBrush.Color = Color.Green;
                    break;
                case 2:
                    powerupBrush.Color = Color.Blue;
                    break;
                case 3:
                    powerupBrush.Color = Color.Red;
                    break;
                case 4:
                    powerupBrush.Color = Color.Pink;
                    break;
                default:
                    break;
            }
            /// TYPE VARIABLE
            // 1 = more balls
            // 2 = large paddle
            // 3 = fire ball
            // 4 = more health
        }
        public void Move()
        {
            Random random = new Random();
            y += 2;
            if (type != 0) // If the type is zero, the powerup is disabled and should be removed
            {
                Rectangle PowerUpRec = new Rectangle(x, y, size, size);
                Rectangle PaddleRec = new Rectangle(GameScreen.paddle.x, GameScreen.paddle.y, GameScreen.paddle.width, GameScreen.paddle.height);
                if (PowerUpRec.IntersectsWith(PaddleRec))
                {
                    if (type == 1)
                    {
                        GameScreen.balls.Add(new Ball(GameScreen.paddle.x, GameScreen.paddle.y - 40, 4, -4, 20));
                        GameScreen.balls.Add(new Ball(GameScreen.paddle.x, GameScreen.paddle.y - 40, -4, -4, 20));
                    }
                    else if (type == 2)
                    {
                        GameScreen.paddle.width = 160;
                        GameScreen.lPaddletimer = 1000;
                    }
                    else if (type == 3)
                    {
                        GameScreen.fireBallTimer = 1000;
                    }
                    else if (type == 4)
                    {
                        GameScreen.lives++;
                    }
                    type = 0;
                }
                if (y > Form1.formHeight)
                {
                    type = 0;
                }

                if (type < 0 && random.Next(1, 5) == 1)
                {

                }
            }
        }
    }
}
