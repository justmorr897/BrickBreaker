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
        bool leftArrowDown, rightArrowDown, spaceDown;

        // Game values
        public static int lives;
        public static int saveLevel = 1;
        public static int gameLevel = 1;
        int totalLevels = 5;
        int timerDrawLocation = 0;

        public bool awaitingLaunch = true;
        public static bool edgeProtector = false;
        public static bool stickyPaddle = false;
        public static int ballDamage = 1;
        public static string powerupMessage = "";
        public static bool isSaveLevelSelcted = false;

        // timers
        public static int paddleSizeTimer = 0;
        public static int paddleSpeedTimer = 0;
        public static int speedBallTimer = 0;
        public static int damageTimer = 0;
        public static int fireBallTimer = 0;
        public static int messageTimer = 0;

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
        SolidBrush paddleBrush = new SolidBrush(Color.Transparent);

        SolidBrush ballBrush = new SolidBrush(Color.Red);
        
        SolidBrush red = new SolidBrush(Color.Red);
        SolidBrush orange = new SolidBrush(Color.Orange);
        SolidBrush yellow = new SolidBrush(Color.Yellow);
        SolidBrush purple = new SolidBrush(Color.Purple);
        SolidBrush darkBlue = new SolidBrush(Color.FromArgb(0, 0, 200));
        SolidBrush timerBrush = new SolidBrush(Color.White);
        Font font;

        public static List<Color> powerupColours = new List<Color>{ Color.Green, Color.Cyan, Color.Red, Color.Pink, Color.Purple, Color.Yellow, Color.Magenta };

        Bitmap paddleImage = new Bitmap(Properties.Resources.Paddle);

        // Font
        Font powerupMessageFont = new Font("Arial", 50);

        #endregion

        public GameScreen()
        {
            InitializeComponent();
            font = new Font("Arial", 24, FontStyle.Bold);
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
            paddle = new Paddle(paddleX, paddleY, paddleWidth, paddleHeight, paddleSpeed, Color.Transparent);

            // setup starting ball values
            int ballX = this.Width / 2 - 10;
            int ballY = this.Height - paddle.height - 80;

 
            /**
             * Set the ball speed to 0 so it doesnt move upon start so it can be launched
             */
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
            //gameTimer.Enabled = true;
        }


        public void LevelBuild()
        {
            //balls.Clear();
            //balls.Add(new Ball(ballX, ballY, xSpeed, ySpeed, ballSize));
            int x, y, hp;
            string color;

            blocks.Clear();
            XmlReader reader;

            if (isSaveLevelSelcted && saveLevel <= totalLevels)
            {
                string levelFile = "Resources/UserLevel" + saveLevel + ".xml";
                reader = XmlReader.Create(levelFile);
            }
            else
            {
                string levelFile = "Resources/GameLevel" + gameLevel + ".xml";
                reader = XmlReader.Create(levelFile);
            }

            //XmlReader reader = XmlReader.Create("Resources/LevelEditorXML.xml");

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

            //Ball newBall = new Ball(this.Width / 2 - 10, this.Height - paddle.height - 80, 4, 4, 20);
            //balls.Add(newBall);

            gameTimer.Enabled = true;
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
                case Keys.Space:
                    stickyPaddle = false;
                    spaceDown = true;
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
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            livesLabel.Text = $"Lives: {lives}";
            scoreLabel.Text = $"Score: {score}";    

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
                    if (ball.BlockCollision(b, ball))
                    {
                        b.hp -= ballDamage;
                        if(b.hp <= 0)
                        {
                            JustinCode();

                            if (random.Next(1, 9) == 1)
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

                            blocks.Remove(b);
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

            CountTimers();

            if (lives == 0)
            {
                gameTimer.Enabled = false;
                Form form = this.FindForm();
                MenuScreen ps = new MenuScreen();

                ps.Location = new Point((form.Width - ps.Width) / 2, (form.Height - ps.Height) / 2);

                form.Controls.Add(ps);
                form.Controls.Remove(this);
                //OnEnd();
            }
            //TheodoropoulosCode();

            //redraw the screen
            Refresh();
        }

        public void SpinArrow()
        {

        }

        public void JustinCode()
        {
            score++;
        }

        public void OnEnd()
        {
            CooperCode();

            if(gameLevel < totalLevels)
            {
                JustinCode2();

            }
            else if(gameLevel >= totalLevels || saveLevel >= totalLevels)
            {            
                // Goes to the game over screen

                Form form = this.FindForm();
                MenuScreen ps = new MenuScreen();

                ps.Location = new Point((form.Width - ps.Width) / 2, (form.Height - ps.Height) / 2);

                form.Controls.Add(ps);
                form.Controls.Remove(this);
            }
        }


        public void JustinCode2()
        {
            if (isSaveLevelSelcted)
            {
                saveLevel++;
                LevelBuild();
            }
            else 
            {
                gameLevel++;
                LevelBuild();
            }
        }

        public void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            // Draws Fire for fireball powerup
            foreach (Fire f in flames)
            {
                e.Graphics.FillEllipse(f.fireColour, f.x, f.y, f.size + random.Next(-2, 3), f.size + random.Next(-2, 3));
            }

            // Draws paddle
            //paddleBrush.Color = paddle.colour;
            //e.Graphics.FillRectangle(paddleBrush, paddle.x, paddle.y, paddle.width, paddle.height);
            e.Graphics.DrawImage(paddleImage, paddle.x, paddle.y, paddle.width, paddle.width * 1.1f);


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

            // Draws powerups
            foreach (PowerUp p in powerups)
            {
                e.Graphics.FillRectangle(p.powerupBrush, p.x, p.y, p.size, p.size);
            }

            if (edgeProtector)
            {
                e.Graphics.FillRectangle(purple, 0, Height - 5, Width, 5);
            }

            //e.Graphics.DrawImage(Properties.Resources.Paddle, paddle.x, paddle.y, 70, 80);

            // Draws powerup message
            if (messageTimer > 0)
            {
                e.Graphics.DrawString(powerupMessage, powerupMessageFont, darkBlue, 50, Height / 2 - 50);
            }

            // Draw timers

            float pie;
            timerDrawLocation = 0;

            if (paddleSizeTimer > 0)
            {
                timerDrawLocation += 30;
                timerBrush.Color = powerupColours[1];
                pie = paddleSizeTimer / 1000 * 360;
                e.Graphics.FillPie(timerBrush, Width - 30, timerDrawLocation, 20, 20, 0, pie);
            }
        }

        public void TheodoropoulosCode()
        {
   
        }

        public void CooperCode()
        {
            string name;
            name = "do this later";
            string HS = score.ToString();
            XmlWriter writer = XmlWriter.Create("HighScoreXML.xml", null);
            writer.WriteStartElement("HighScores");

            writer.WriteElementString("Name", name);
            writer.WriteElementString("Score", HS);

            writer.WriteEndElement();
            writer.Close();

        }

        public static void WritePowerupMessage(string message)
        {
            messageTimer = 100;
            powerupMessage = message;
        }

        public void CountTimers()
        {
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

            if (damageTimer == 0)
            {
                ballDamage = 1;
            }
            else
            {
                damageTimer--;
            }

            if (messageTimer > 0)
            {
                messageTimer--;
            }
        }
    }
}
