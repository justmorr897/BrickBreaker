using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrickBreaker
{
    public class Ball
    {
        public int x, y, xSpeed, ySpeed, size, damage, prevX, prevY, startXSpeed, startYSpeed;
        public int speed = 2;
        public Color colour;
        public bool canMove = false;
        public Random rand = new Random();
        public bool stuck = false;
        public int xStuck = 0;
        
        public Ball(int _x, int _y, int _xSpeed, int _ySpeed, int _ballSize)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            size = _ballSize;
            startXSpeed = xSpeed;
            startYSpeed = ySpeed;
        }

        public void Move()
        {
            //x += xSpeed * speed;
            //y += ySpeed * speed;

            prevX = x;
            prevY = y;
            
            if (!stuck)
            {
                x += xSpeed * speed;
                y += ySpeed * speed;
            }
            else
            {
                x = GameScreen.paddle.x + xStuck;

                if (!GameScreen.stickyPaddle)
                {
                    stuck = false;
                }
            }
        }

        public bool BlockCollision(Block block, Ball ball)
        {
            Rectangle blockRec = new Rectangle(block.x, block.y, block.width, block.height);
            Rectangle ballRec = new Rectangle(x, y, size, size);

            if (ballRec.IntersectsWith(blockRec))
            {
                if (GameScreen.fireBallTimer == 0 || GameScreen.balls[0] != this)
                {
                    // Get the range of specific points it may hit
                    if (x + (size / 2) <= block.x || x + (size / 2) >= block.x + block.width) // Hits either side
                    {
                        xSpeed *= -1;

                        x = prevX;
                        y = prevY;

                    }
                    else // hits anywhere else
                    {
                        ySpeed *= -1;

                        x = prevX;
                        y = prevY;
                        
                    }
                }
            }

            return blockRec.IntersectsWith(ballRec);
        }

        public void PaddleCollision(Paddle p)
        {
            Rectangle ballRec = new Rectangle(x, y, size, size);
            Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (ballRec.IntersectsWith(paddleRec))
            {
                if (ySpeed > 0)
                {
                    y = p.y - size;
                }

                ySpeed *= -1;

                // Adjust Angle
                AdjustAngle("X");

                // Get Direction
                if (GameScreen.leftArrowDown)
                {
                    xSpeed = -Math.Abs(xSpeed);
                } 
                else if (GameScreen.rightArrowDown)
                {
                    xSpeed = Math.Abs(xSpeed);
                } 

                // Force launch the ball if you hit another one while holding it
                if (GameScreen.balls[0] != this)
                {
                    GameScreen.balls[0].canMove = true;
                }

                // Get stuck if the paddle is sticky
                if (GameScreen.stickyPaddle && !stuck)
                {
                    foreach (Ball b in GameScreen.balls)
                    {
                        if (!b.stuck)
                        {
                            GameScreen.stickyPaddleTimer = 500;
                        }
                    }
                    stuck = true;
                    xStuck = x - GameScreen.paddle.x;
                }
               
            }
       
        }
        public void WallCollision(UserControl UC)
        {
            // Collision with left wall
            if (x <= 0)
            {
                xSpeed *= -1;
                x = size;
            }
            // Collision with right wall
            if (x >= (UC.Width - size))
            {
                xSpeed *= -1;
                x = UC.Width - size;
            }
            // Collision with top wall
            if (y <= 2)
            {
                ySpeed *= -1;
            }
        }

        public void AdjustAngle(string direction)
        {

            // Declare Paddle
            Paddle paddle = GameScreen.paddle;

            // Max Speed is 8

            // If player doesnt move
            if (paddle.acceleration == 0)
            {
                // Do nothing
                return;
            }
            else if (Math.Abs(paddle.acceleration) <= 3)
            {
                // Small Launch
                xSpeed = startXSpeed - 1;
            }
            else if (Math.Abs(paddle.acceleration) <= 6)
            {
                // Normal Launch
                xSpeed = startXSpeed;
            } else if (Math.Abs(paddle.acceleration) > 6)
            {
                // Big Launch
                xSpeed = startXSpeed + 1;
            }


                //if (direction == "X")
                //{
                //    switch (randomNum)
                //    {
                //        case 0:
                //            xSpeed = startXSpeed - 2;
                //            break;
                //        case 1:
                //            xSpeed = startXSpeed - 1;
                //            break;
                //        case 2:
                //            xSpeed = startXSpeed;
                //            break;
                //        case 3:
                //            xSpeed = startXSpeed + 1;
                //            break;
                //        case 4:
                //            xSpeed = startXSpeed + 2;
                //            break;
                //    }

                //}

            }

        public bool BottomCollision(UserControl UC)
        {
            bool didCollide = false;

            if (y >= UC.Height)
            {
                didCollide = true;
            }

            return didCollide;
        }


    }
}
