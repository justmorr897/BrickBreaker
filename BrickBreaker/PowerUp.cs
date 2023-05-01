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
        public static string[] goodPowerups = { "Multi ball!", "Large paddle!", "Fire ball!", "Extra Life!", "Edge Protector!", "Sticky Paddle!" };
        public static string[] badPowerups = { "Small paddle!", "Fast ball!", "Disorientation!", "Lose a Life!", "Slow Paddle!" };
        Random random = new Random();

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
                    powerupBrush.Color = Color.Cyan;
                    break;
                case 3:
                    powerupBrush.Color = Color.Red;
                    break;
                case 4:
                    powerupBrush.Color = Color.Pink;
                    break;
                case 5:
                    powerupBrush.Color = Color.Purple;
                    break;
                case 6:
                    powerupBrush.Color = Color.Yellow;
                    break;
                default:
                    break;
            }

            if (random.Next(1, 6) == 1)
            {
                type = 99;
            }
            /// TYPE VARIABLE
            /// Good powerups (> 0)
            // 1 = more balls
            // 2 = large paddle
            // 3 = fire ball
            // 4 = more health
            // 5 = edge protector
            // 6 = sticky paddle

            /// Bad powerups (< 0)
            // -1 = small paddle
            // -2 = fast ball
            // -3 = random paddle and ball teleportation
            // -4 = subtract a life
            // -5 = slow paddle

            // 99 = mystery
        }
        public void Move()
        {
            y += 2;
            if (type != 0) // If the type is zero, the powerup is disabled and should be removed
            {
                Rectangle PowerUpRec = new Rectangle(x, y, size, size);
                Rectangle PaddleRec = new Rectangle(GameScreen.paddle.x, GameScreen.paddle.y, GameScreen.paddle.width, GameScreen.paddle.height);
                if (PowerUpRec.IntersectsWith(PaddleRec))
                {
                    if (type > 0 && type < 99)
                    {
                        if (type == 1)
                        {
                            GameScreen.balls.Add(new Ball(GameScreen.paddle.x, GameScreen.paddle.y - 40, 4, -4, 20));
                            GameScreen.balls.Add(new Ball(GameScreen.paddle.x, GameScreen.paddle.y - 40, -4, -4, 20));
                        }
                        else if (type == 2)
                        {
                            if (GameScreen.paddle.width == 40)
                            {
                                GameScreen.paddleSizeTimer = 0;
                            }
                            else
                            {
                                GameScreen.paddle.width = 160;
                                GameScreen.paddleSizeTimer = 1000;
                            }
                        }
                        else if (type == 3)
                        {
                            GameScreen.fireBallTimer = 600;
                        }
                        else if (type == 4)
                        {
                            GameScreen.lives++;
                        }
                        else if (type == 5)
                        {
                            GameScreen.edgeProtector = true;
                        }
                        else if (type == 6)
                        {
                            GameScreen.stickyPaddle = true;
                        }
                        GameScreen.WritePowerupMessage(goodPowerups[type - 1]);
                        type = 0;
                    }
                    else if (type < 0)
                    {
                        if (type == -1)
                        {
                            if (GameScreen.paddle.width == 160)
                            {
                                GameScreen.paddleSizeTimer = 0;
                            }
                            else
                            {
                                GameScreen.paddle.width = 40;
                                GameScreen.paddleSizeTimer = 750;
                            }
                        }
                        else if (type == -2)
                        {
                            foreach (Ball b in GameScreen.balls)
                            {
                                b.speed = 2;
                                GameScreen.speedBallTimer = 500;
                            }
                        }
                        else if (type == -3)
                        {
                            foreach (Ball b in GameScreen.balls)
                            {
                                b.x = random.Next(0, Form1.formWidth);
                                b.y = random.Next(0, Form1.formHeight);
                            }
                            GameScreen.paddle.x = random.Next(0, Form1.formWidth - GameScreen.paddle.width);
                        }
                        else if (type == -4)
                        {
                            GameScreen.lives--;
                        }
                        else if (type == -5)
                        {
                            GameScreen.paddle.speed = 4;
                            GameScreen.paddleSpeedTimer = 750;
                        }
                        GameScreen.WritePowerupMessage(badPowerups[type * -1 - 1]);
                        type = 0;
                    }
                    else
                    {
                        if (random.Next(1, 4) == 1)
                        {
                            type = random.Next(badPowerups.Length * -1, 0);
                        }
                        else
                        {
                            type = random.Next(1, goodPowerups.Length + 1);
                        }
                    }
                }
                if (y > Form1.formHeight)
                {
                    type = 0;
                }

                if (type < 0 && random.Next(1, 5) == 1)
                {
                    if (powerupBrush.Color == Color.FromArgb(255, 200, 0))
                    {
                        powerupBrush.Color = Color.FromArgb(255, 100, 0);
                    }
                    else
                    {
                        powerupBrush.Color = Color.FromArgb(255, 200, 0);
                    }
                }

                if (type == 99 && random.Next(1, 5) == 1) // Random power up
                {
                    powerupBrush.Color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                }
            }
        }
    }
}
