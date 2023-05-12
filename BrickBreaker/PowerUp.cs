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
        public static string[] goodPowerups = { "Multi Ball!", "Large Paddle!", "Fire Ball!", "Extra Life!", "Edge Protector!", "Sticky Paddle!", "Double Damage!", "Shotgun!!!", "Explosive Hit!", "Magnet!", "Move Ball!", "Slow Ball!" };

        public static string[] badPowerups = { "Small Paddle!", "Fast Ball!", "Disorientation!", "Lose a Life!", "Slow Paddle!" };
        Random random = new Random();

        public PowerUp(int _type, int _x, int _y)
        {
            type = _type;
            x = _x;
            y = _y;

            if (type > 0 && type <= GameScreen.powerupColours.Count)
            {
                powerupBrush.Color = GameScreen.powerupColours[type - 1];
            }

            if (random.Next(1, 6) == 1)
            {
                type = 99;
            }

            /// HOW TO ADD POWER UPS:
            // 1. Add the display message to either goodPowerups or badPowerups.
            // 2. If the power up is good, add the colour of the power up to powerupColours on GameScreen.
            // 3. Write the code for the power up in an IF statement under the other ones. Create a public static int timer if needed.
            // 4. If the power up does use a timer, make sure to add a DrawTimer method with the inputs: (name of timer), (amount of time the power up lasts), (colour of power up), e.

            /// TYPE VARIABLE
            /// Good powerups (> 0)
            // 1 = more balls (Green)
            // 2 = large paddle (Cyan)
            // 3 = fire ball (Red)
            // 4 = more health (Pink)
            // 5 = edge protector (Purple)
            // 6 = sticky paddle (Yellow)
            // 7 = double damage (Magenta)
            // 8 = shotgun (Beige)
            // 9 = explosive hit (Orange)
            // 10 = magnet (Maroon)
            // 11 = move ball (Lime)
            // 12 = slow ball (Dodger Blue)

            /// Bad powerups (< 0) (Red and orange flash)
            // -1 = small paddle
            // -2 = fast ball
            // -3 = random paddle and ball teleportation
            // -4 = subtract a life
            // -5 = slow paddle

            // 99 = mystery (Colour flash)
        }
        public void Move()
        {
            y += 2;

            if (GameScreen.magnetTimer > 0 && type > 0 && y > Form1.formHeight / 2)
            {
                if (x < GameScreen.paddle.x + GameScreen.paddle.width / 2)
                {
                    x += 3 * GameScreen.powerUpIntensity;
                }
                else
                {
                    x -= 3 * GameScreen.powerUpIntensity;
                }
            }
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
                            GameScreen.balls.Add(new Ball(GameScreen.paddle.x, GameScreen.paddle.y - 40, 2, -2, 20));
                            GameScreen.balls.Add(new Ball(GameScreen.paddle.x, GameScreen.paddle.y - 40, -2, -2, 20));

                            if (GameScreen.powerUpIntensity == 2)
                            {
                                GameScreen.balls.Add(new Ball(GameScreen.paddle.x, GameScreen.paddle.y - 40, 1, -2, 20));
                                GameScreen.balls.Add(new Ball(GameScreen.paddle.x, GameScreen.paddle.y - 40, -1, -2, 20));
                            }
                        }
                        else if (type == 2)
                        {
                            if (GameScreen.paddle.width == 40 / GameScreen.powerUpIntensity)
                            {
                                GameScreen.paddleSizeTimer = 0;
                            }
                            else
                            {
                                GameScreen.paddle.width = 160 * GameScreen.powerUpIntensity;
                                GameScreen.paddleSizeTimer = 1000;
                            }
                        }
                        else if (type == 3)
                        {
                            GameScreen.fireBallTimer = 600;
                        }
                        else if (type == 4)
                        {
                            GameScreen.lives += GameScreen.powerUpIntensity;
                        }
                        else if (type == 5)
                        {
                            GameScreen.edgeProtector = true;
                        }
                        else if (type == 6)
                        {
                            GameScreen.stickyPaddle = true;
                        }
                        else if (type == 7)
                        {
                            GameScreen.ballDamage = 2 * GameScreen.powerUpIntensity;
                            GameScreen.damageTimer = 750;
                        }
                        else if (type == 8)
                        {
                            GameScreen.shotgunPowerup = true;
                        }
                        else if (type == 9)
                        {
                            GameScreen.explosiveHitTimer = 1000;
                        }
                        else if (type == 10)
                        {
                            GameScreen.magnetTimer = 2000;
                        }
                        else if (type == 11)
                        {
                            GameScreen.moveBall = true;
                            GameScreen.stickyPaddle = false;
                        }
                        else if (type == 12)
                        {
                            if (GameScreen.balls[0].speed == 3 + GameScreen.powerUpIntensity)
                            {
                                foreach (Ball b in GameScreen.balls)
                                {
                                    b.speed = 2;
                                }
                                GameScreen.speedBallTimer = 0;
                            }
                            else
                            {
                                foreach (Ball b in GameScreen.balls)
                                {
                                    b.speed = 1;
                                }
                                GameScreen.speedBallTimer = 750;
                            }
                        }

                        GameScreen.WritePowerupMessage(goodPowerups[type - 1], type);
                        type = 0;
                    }
                    else if (type < 0)
                    {
                        if (type == -1)
                        {
                            if (GameScreen.paddle.width == 160 * GameScreen.powerUpIntensity)
                            {
                                GameScreen.paddleSizeTimer = 0;
                            }
                            else
                            {
                                GameScreen.paddle.width = 40 / GameScreen.powerUpIntensity;
                                GameScreen.paddleSizeTimer = 750;
                            }
                        }
                        else if (type == -2)
                        {
                            if (GameScreen.balls[0].speed == 1)
                            {
                                foreach (Ball b in GameScreen.balls)
                                {
                                    b.speed = 2;
                                }
                                GameScreen.speedBallTimer = 0;
                            }
                            else
                            {
                                foreach (Ball b in GameScreen.balls)
                                {
                                    b.speed = 3 + GameScreen.powerUpIntensity;
                                }
                                GameScreen.speedBallTimer = 500;
                            }
                        }
                        else if (type == -3)
                        {
                            foreach (Ball b in GameScreen.balls)
                            {
                                b.x = random.Next(0, Form1.formWidth);
                                b.y = random.Next(0, Form1.formHeight);
                                GameScreen.stickyPaddle = false;
                                GameScreen.moveBall = false;
                            }
                            GameScreen.paddle.x = random.Next(0, Form1.formWidth - GameScreen.paddle.width);
                        }
                        else if (type == -4)
                        {
                            GameScreen.lives -= GameScreen.powerUpIntensity;
                        }
                        else if (type == -5)
                        {
                            GameScreen.paddle.speed = 5 - GameScreen.powerUpIntensity;
                            GameScreen.paddleSpeedTimer = 750;
                        }

                        GameScreen.WritePowerupMessage(badPowerups[type * -1 - 1], type);
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

                if (type < 0 && random.Next(1, 5) == 1) // Bad power up flash
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

                if (type == 99 && random.Next(1, 5) == 1) // Random power up flash
                {
                    powerupBrush.Color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                }
            }
        }
    }
}
