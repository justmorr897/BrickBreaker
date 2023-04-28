/*  Created by: 
 *  Project: Brick Breaker
 *  Date: 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml;

namespace BrickBreaker
{
    public partial class GameScreen : UserControl
    {
        #region global values

        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, rightArrowDown;

        // Game values
        public static int lives;
        public static int paddleSizeTimer = 0;
        public static int fireBallTimer = 0;
        public static int speedBallTimer = 0;
        public static int paddleSpeedTimer = 0;
        public static bool edgeProtector = false;
        Random random = new Random();
        int score;

        // Paddle and Ball objects
        public static Paddle paddle;
        public static List<Ball> balls = new List<Ball>();

        // list of all blocks for current level
        List<Block> blocks = new List<Block>();

        // list of power ups
        List<PowerUp> powerups = new List<PowerUp>();

        // fire ball power up
        List<Fire> flames = new List<Fire>();

        // Brushes
        SolidBrush paddleBrush = new SolidBrush(Color.White);
        SolidBrush ballBrush = new SolidBrush(Color.White);
        SolidBrush red = new SolidBrush(Color.Red);
        SolidBrush orange = new SolidBrush(Color.Orange);
        SolidBrush yellow = new SolidBrush(Color.Yellow);
        SolidBrush purple = new SolidBrush(Color.Purple);
        SolidBrush darkBlue = new SolidBrush(Color.FromArgb(0, 0, 200));

        #endregion

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }


        public void OnStart()
        {
            //set life counter
            lives = 3;

            //set all button presses to false.
            leftArrowDown = rightArrowDown = false;

            // setup starting paddle values and create paddle object
            int paddleWidth = 80;
            int paddleHeight = 20;
            int paddleX = ((this.Width / 2) - (paddleWidth / 2));
            int paddleY = (this.Height - paddleHeight) - 60;
            int paddleSpeed = 8;
            paddle = new Paddle(paddleX, paddleY, paddleWidth, paddleHeight, paddleSpeed, Color.White);

            // setup starting ball values
            int ballX = this.Width / 2 - 10;
            int ballY = this.Height - paddle.height - 80;

            // Creates a new ball
            int xSpeed = 4;
            int ySpeed = 4;
            int ballSize = 20;
            balls.Clear();
            balls.Add(new Ball(ballX, ballY, xSpeed, ySpeed, ballSize));

            #region Creates blocks for generic level. Need to replace with code that loads levels.

            //TODO - replace all the code in this region eventually with code that loads levels from xml files

            LevelBuild();

            //blocks.Clear();
            //int x = 10;

            //while (blocks.Count < 12) // Originally 12
            //{
            //    x += 57;
            //    Block b1 = new Block(x, 10, 1, Color.White);
            //    blocks.Add(b1);
            //}

            #endregion

            // start the game engine loop
            gameTimer.Enabled = true;
        }


        public void LevelBuild()
        {
            int x, y, hp;
            string color;

            blocks.Clear();
            XmlReader reader = XmlReader.Create("Resources/LevelEditorXML.xml");

            reader.ReadToFollowing("Level");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    x = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("y");
                    y = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("hp");
                    hp = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("color");
                    color = reader.ReadString();

                    Color newColor = Color.FromName(color);

                    Block newBlock = new Block(x, y, hp, newColor);
                    blocks.Add(newBlock);
                }
            }

            reader.Close();
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Move the paddle
            if (leftArrowDown && paddle.x > 0)
            {
                paddle.Move("left");
            }
            if (rightArrowDown && paddle.x < (this.Width - paddle.width))
            {
                paddle.Move("right");
            }

            foreach (Ball b in balls)
            {
                b.PaddleCollision(paddle);
                b.Move();
                b.WallCollision(this);
                if (b.BottomCollision(this))
                {
                    if (b == balls[0] && !edgeProtector)
                    {
                        lives--;

                        // Moves the ball back to origin
                        b.x = ((paddle.x - (b.size / 2)) + (paddle.width / 2));
                        b.y = (this.Height - paddle.height) - 85;
                    }
                    else if (!edgeProtector)
                    {
                        balls.Remove(b);
                        break;
                    }
                    else
                    {
                        b.ySpeed *= -1;
                        edgeProtector = false;
                    }
                }
            }

            // Check if ball has collided with any blocks
            foreach (Ball ball in balls)
            {
                foreach (Block b in blocks)
                {
                    if (ball.BlockCollision(b))
                    {
                        JustinCode();
                        blocks.Remove(b);

                        if (random.Next(1, 11) == 1)
                        {
                            if (random.Next(1, 4) == 1)
                            {
                                powerups.Add(new PowerUp(random.Next(PowerUp.badPowerups.Length * -1, 0), b.x, b.y));
                            }
                            else
                            {
                                powerups.Add(new PowerUp(random.Next(1, PowerUp.goodPowerups.Length + 1), b.x, b.y));
                            }
                        }

                        if (blocks.Count == 0)
                        {
                            gameTimer.Enabled = false;
                            OnEnd();
                        }

                        break;
                    }
                }
            }

            foreach (PowerUp p in powerups)
            {
                p.Move();
                if (p.type == 0)
                {
                    powerups.Remove(p);
                    break;
                }
            }

            if (speedBallTimer == 0 && balls[0].speed == 2)
            {
                foreach (Ball b in balls)
                {
                    b.speed = 1;
                }
            }
            else
            {
                speedBallTimer--;
            }

            if (fireBallTimer != 0)
            {
                fireBallTimer--;
                flames.Add(new Fire(balls[0].x, balls[0].y));
            }
            foreach (Fire f in flames)
            {
                f.Move();
            }
            foreach (Fire f in flames)
            {
                if (f.i > 275)
                {
                    flames.Remove(f);
                    break;
                }
            }

            if (paddleSizeTimer == 0)
            {
                paddle.width = 80;
            }
            else
            {
                paddleSizeTimer--;
            }

            if (paddleSpeedTimer == 0)
            {
                paddle.speed = 8;
            }
            else
            {
                paddleSpeedTimer--;
            }

            if (lives == 0)
            {
                gameTimer.Enabled = false;
                OnEnd();
            }

            //redraw the screen
            Refresh();
        }
        public void JustinCode()
        {
            score++;
        }

        public void OnEnd()
        {
            // Goes to the game over screen
            Form form = this.FindForm();
            MenuScreen ps = new MenuScreen();

            ps.Location = new Point((form.Width - ps.Width) / 2, (form.Height - ps.Height) / 2);

            form.Controls.Add(ps);
            form.Controls.Remove(this);
        }

        public void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            // Draws Fire for fireball powerup
            foreach (Fire f in flames)
            {
                e.Graphics.FillEllipse(f.fireColour, f.x, f.y, f.size + random.Next(-2, 3), f.size + random.Next(-2, 3));
            }

            // Draws paddle
            paddleBrush.Color = paddle.colour;
            e.Graphics.FillRectangle(paddleBrush, paddle.x, paddle.y, paddle.width, paddle.height);

            // Draws blocks
            foreach (Block b in blocks)
            {
                e.Graphics.FillRectangle(new SolidBrush(b.colour), b.x, b.y, b.width, b.height);
            }

            // Draws balls
            foreach (Ball b in balls)
            {
                if (b == balls[0])
                {
                    e.Graphics.FillEllipse(darkBlue, b.x, b.y, b.size, b.size);
                }
                else
                {
                    e.Graphics.FillEllipse(ballBrush, b.x, b.y, b.size, b.size);
                }
            }

            // Draws Powerups
            foreach (PowerUp p in powerups)
            {
                e.Graphics.FillRectangle(p.powerupBrush, p.x, p.y, p.size, p.size);
            }

            if (edgeProtector)
            {
                e.Graphics.FillRectangle(purple, 0, Height - 5, Width, 5);
            }
        }

        public void TheodoropoulosCode()
        {

        }
    }
}
