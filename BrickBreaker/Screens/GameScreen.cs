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
using System.IO;
using System.Diagnostics;

namespace BrickBreaker
{
    public partial class GameScreen : UserControl
    {
        #region global values

        //player1 button control keys - DO NOT CHANGE
        public static Boolean leftArrowDown, rightArrowDown, spaceDown;

        // Game values
        int mouseX, mouseY, score, powerUpChance;
        int shotgunShots, theoTracker, timerDrawLocation = 0;
        public static int saveLevel, gameLevel, ballDamage, powerUpIntensity = 1;
        public static int lives;
        int totalLevels = 5;
        int gravity = 1;
        int paddleYMove = 0;

        //Set all power ups bools to false
        public static bool edgeProtector, stickyPaddle, moveBall, isSaveLevelSelcted, partyMode, shotReady, shotgunPowerup = false;
        public static string powerupMessage = "";

        //Ball will be launched by player by pressing space
        public bool awaitingLaunch = true;

        // initialize all timers to 0
        public static int paddleSizeTimer, paddleSpeedTimer, speedBallTimer, damageTimer, fireBallTimer, explosiveHitTimer, magnetTimer, stickyPaddleTimer, messageTimer = 0;

        //pictures for blocks
        Bitmap paddleImage = new Bitmap(Properties.Resources.Paddle);
        Bitmap[] ducks = {Properties.Resources.Duck01, Properties.Resources.Duck02, Properties.Resources.Duck03, Properties.Resources.Duck11
        , Properties.Resources.Duck12, Properties.Resources.Duck13, Properties.Resources.Duck21, Properties.Resources.Duck22
        , Properties.Resources.Duck23, Properties.Resources.Duck31, Properties.Resources.Duck32, Properties.Resources.Duck33
        , Properties.Resources.Duck41, Properties.Resources.Duck42, Properties.Resources.Duck43};

        Random random = new Random();

        // Paddle and Ball objects
        public static Paddle paddle;
        public static List<Ball> balls = new List<Ball>();

        // list of all blocks for current level
        List<Block> blocks = new List<Block>();
        List<Block> deadBlocks = new List<Block>();

        // list of power ups
        List<PowerUp> powerups = new List<PowerUp>();

        // fire ball power up
        List<Fire> flames = new List<Fire>();

        // explosive hit power up
        List<Point> explosions = new List<Point>();

        // List of all colours for good power ups
        public static List<Color> powerupColours = new List<Color> { Color.Green, Color.Cyan, Color.Red, Color.Pink, Color.Purple, Color.Yellow, Color.Magenta, Color.Beige, Color.Orange, Color.Maroon, Color.Lime, Color.DodgerBlue };

        // Brushes and Pens
        SolidBrush ballBrush = new SolidBrush(Color.Red);
        SolidBrush purple = new SolidBrush(Color.Purple);
        SolidBrush darkBlue = new SolidBrush(Color.FromArgb(0, 0, 200));
        SolidBrush brush = new SolidBrush(Color.White);
        Pen shotgunPen = new Pen(Color.Black);
        Pen moveBallPen = new Pen(Color.Lime, 3);
        Color colour = Color.White;

        // Fonts
        //Font powerupMessageFont = new Font("Forte", 50);

        Stopwatch stopwatch = new Stopwatch();
        Stopwatch gameTimeStopwatch = new Stopwatch();

        Rectangle CrosshairRectangle = new Rectangle();
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

            // reset power up values
            paddleSizeTimer = paddleSpeedTimer = speedBallTimer = damageTimer = fireBallTimer = explosiveHitTimer = magnetTimer = stickyPaddleTimer = messageTimer = 0;
            edgeProtector = stickyPaddle = moveBall = shotReady = shotgunPowerup = false;
            balls.Clear();

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
            int xSpeed = 2;
            int ySpeed = 2;
            int ballSize = 20;
            
            balls.Add(new Ball(ballX, ballY, xSpeed, ySpeed, ballSize));

            LevelBuild();
            lives *= powerUpIntensity;
        }

        public void LevelBuild()
        {
            if (partyMode)
            {
                powerUpChance = 3;
                powerUpIntensity = 2;
            }
            else
            {
                powerUpChance = 7;
                powerUpIntensity = 1;
            }

            int x, y, hp;
            string color, level;

            blocks.Clear();
            XmlReader reader;

            if (isSaveLevelSelcted)
            {
                string levelFile = "Resources/UserLevel" + saveLevel + ".xml";
                reader = XmlReader.Create(levelFile);
                level = "Save Level" + " " + saveLevel.ToString();
            }
            else
            {
                string levelFile = "Resources/GameLevel" + gameLevel + ".xml";
                reader = XmlReader.Create(levelFile);
                level = "Level" + " " + gameLevel.ToString();
            }

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


            for (int i = 1; i < balls.Count; i++)
            {
                balls.RemoveAt(i);
            }

            //Write the level to the screen
            WritePowerupMessage(level);

            // Just to make sure the ball doesnt move on start
            balls[0].canMove = false;

            //start game timer 
            gameTimer.Enabled = true;
            gameTimeStopwatch.Start();
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player button presses
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
                    stickyPaddleTimer = 0;
                    paddleYMove = 10;
                    spaceDown = true;
                    break;
                case Keys.P:               
                    PauseAndResume();
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Space:
                    paddleYMove = 0;
                    spaceDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //make a rectangle around the mouse when the shotgun power is on
            if (shotgunPowerup)
            {
                CrosshairRectangle = new Rectangle(mouseX - 10, mouseY - 10, 20, 20);
            }

            // Call Ball Launch
            BallLaunch();

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
                if (!moveBall)
                {
                    b.Move();
                }
                b.WallCollision(this);
                if (b.BottomCollision(this))
                {
                    if (b == balls[0] && !edgeProtector)
                    {
                        lives--;

                        // Moves the ball back to origin
                        b.x = ((paddle.x - (b.size / 2)) + (paddle.width / 2));
                        b.y = (this.Height - paddle.height) - 85;

                        // Prevent ball from moving to allow for launch
                        balls[0].canMove = false;

                    }
                    else if (!edgeProtector)
                    {
                        balls.Remove(b);
                        break;
                    }
                    else
                    {
                        b.ySpeed *= -1;
                        if (random.Next(1, powerUpIntensity + 1) == 1)
                        {
                            edgeProtector = false;
                        }
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
                        //if the explosive timer is on, add an effect at that point
                        if (explosiveHitTimer > 0)
                        {
                            explosions.Add(new Point(ball.x, ball.y));
                        }

                        //reduce block health
                        b.hp -= ballDamage;

                        //Check if the block's health is 0
                        if (b.hp <= 0)
                        {
                            //if it is, add to score
                            score++;

                            //randomize for powerups
                            if (random.Next(1, powerUpChance) == 1)
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

                            //add to deadblocks, remove from blocks
                            deadBlocks.Add(b);
                            blocks.Remove(b);
                        }

                        break;
                    }
                }
            }


            foreach (Block b in blocks)
            {
                foreach (Point p in explosions)
                {
                    if (p.X - (b.x + b.width / 2) < 160 * powerUpIntensity && p.Y - (b.y + b.height / 2) < 80 * powerUpIntensity)
                    {
                        b.hp -= ballDamage;
                    }
                }

                //if any blocks health is 0
                if (b.hp <= 0)
                {
                    //add score
                    score++;

                    //have a random chance to drop a power
                    if (random.Next(1, powerUpChance) == 1)
                    {
                        //randomize what the power will be
                        if (random.Next(1, 4) == 1)
                        {
                            powerups.Add(new PowerUp(random.Next(PowerUp.badPowerups.Length * -1, 0), b.x, b.y));
                        }
                        else
                        {
                            powerups.Add(new PowerUp(random.Next(1, PowerUp.goodPowerups.Length + 1), b.x, b.y));
                        }
                    }

                    //add the block to deadblocks once it is at 0 health
                    //remove it from the blocks list
                    deadBlocks.Add(b);
                    blocks.Remove(b);

                    break;
                }
            }

            //If all the blocks are gone the level is done
            if (blocks.Count == 0)
            {
                gameTimer.Enabled = false;
                OnEnd();
            }

            //move the powerups
            foreach (PowerUp p in powerups)
            {
                p.Move();
                if (p.type == 0)
                {
                    powerups.Remove(p);
                    break;
                }
            }

            //decremnt all active powerup timers
            CountTimers();

            //If the player runs out of lives the game ends
            if (lives <= 0)
            {
                CooperCode();
                gameTimer.Enabled = false;
                Form1.ChangeScreen(this, new Leaderboard());
                //OnEnd();
            }

            //Animate the ducks
            TheodoropoulosCode();

            //animation for the dead ducks
            foreach (Block deadBlock in deadBlocks)
            {
                int speed = 4;

                if (deadBlock.y < this.Height)
                {
                    //add to the falling speed the further they fall with gravity
                    deadBlock.y += speed + gravity;
                    gravity += 1;
                }

                if (deadBlock.y > this.Height)
                {
                    deadBlocks.Remove(deadBlock);
                    gravity = 1;
                    //up = true;
                    break;
                }
            }

            //Play the reload sound when the player gets the shotgun powerup
            if (shotgunPowerup && shotReady == true)
            {
                //if (stopwatch.ElapsedMilliseconds > 1500)
                //{
                var reloadSound = new System.Windows.Media.MediaPlayer();
                reloadSound.Open(new Uri(Application.StartupPath + "/Resources/shotguCopyEdited.Wav"));
                reloadSound.Play();

                shotReady = false;
                //}
            }

            explosions.Clear();

            //if (paddle.acceleration != 0 && !leftArrowDown && !rightArrowDown || leftArrowDown && rightArrowDown)
            //{
            //    if (paddle.acceleration > 0)
            //    {
            //        paddle.acceleration--;
            //    }
            //    else
            //    {
            //        paddle.acceleration++;
            //    }
            //}
            //update lives and score labels
            livesLabel.Text = $"Lives: {lives}";
            scoreLabel.Text = $"Score: {score}";

            //redraw the screen
            Refresh();
        }

        public void BallLaunch()
        {
            //At the start of each level place the ball in the middle of the paddle
            if (balls[0].canMove == false)
            {
                balls[0].x = paddle.x + (paddle.width / 2) - (balls[0].size / 2);
                balls[0].y = paddle.y - (paddle.height);
            }

            //Once space is pressed, release the ball
            if (spaceDown)
            {
                balls[0].canMove = true;
            }
        }

        private void GameScreen_MouseMove(object sender, MouseEventArgs e)
        {
            //Store where the mouse is on the screen for powerups
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void GameScreen_MouseClick(object sender, MouseEventArgs e)
        {
            if (shotgunPowerup && !moveBall)
            {
                //check if the shotgun power is active and 3 shots haven't been shot
                if (shotgunPowerup && shotgunShots < 3 * powerUpIntensity)
                {
                    //Play shot sound
                    var shotSound = new System.Windows.Media.MediaPlayer();
                    shotSound.Open(new Uri(Application.StartupPath + "/Resources/shotgunShotEdited.wav"));
                    shotSound.Play();

                    //start a stopwatch for the reload sound
                    stopwatch.Start();

                    //The shotgun is now ready to be fired again
                    shotReady = true;

                    //add to the shot counter
                    shotgunShots++;

                    //var reloadSound = new System.Windows.Media.MediaPlayer();
                    //reloadSound.Open(new Uri(Application.StartupPath + "/Resources/shotguCopyEdited.Wav"));
                    //reloadSound.Play();


                    //Check if any blocks are hit by the shot
                    //If they are remove them from blocks and add them to deadblocks
                    //Also increase score
                    for (int i = blocks.Count - 1; i >= 0; i--)
                    {
                        if (blocks[i].CrossHairCollision(blocks[i], CrosshairRectangle))
                        {
                            deadBlocks.Add(blocks[i]);
                            blocks.Remove(blocks[i]);
                            score++;
                        }
                    }

                }
                else
                {
                    shotgunPowerup = false;
                    shotgunShots = 0;
                }
            }

            if (moveBall && Math.Abs(mouseX - balls[0].x) < 150 * powerUpIntensity && Math.Abs(mouseY - balls[0].y) < 150 * powerUpIntensity)
            {
                balls[0].x = mouseX;
                balls[0].y = mouseY;
                moveBall = false;
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            shotgunShots++;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }

        public void PauseAndResume()
        {
            gameTimer.Enabled = !gameTimer.Enabled;
            pauseLabel.Visible = !pauseLabel.Visible;
            pauseLivesLabel.Visible = !pauseLivesLabel.Visible;
            pauseScoreLabel.Visible = !pauseScoreLabel.Visible;
            exitButton.Visible = !exitButton.Visible;

            pauseLabel.BringToFront();
            pauseLivesLabel.BringToFront();
            pauseScoreLabel.BringToFront();
            exitButton.BringToFront();

            pauseLivesLabel.Text = $"Lives: {lives}";
            pauseScoreLabel.Text = $"Score: {score}";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PauseAndResume();
        }

        public void OnEnd()
        {
            CooperCode();

            if (gameLevel < totalLevels)
            {
                JustinCode2();

            }
            else if (gameLevel >= totalLevels || saveLevel >= totalLevels)
            {
                // Goes to the game over screen
                Form1.ChangeScreen(this, new Leaderboard());
            }
        }

        public void JustinCode2()
        {
            powerups.Clear();
            paddleSizeTimer = paddleSpeedTimer = speedBallTimer = damageTimer = fireBallTimer = explosiveHitTimer = magnetTimer = stickyPaddleTimer = messageTimer = 0;
            edgeProtector = stickyPaddle = moveBall = shotReady = shotgunPowerup = false;
            balls.Clear();
            balls.Add(new Ball(0, 0, 2, 2, 20));

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
            if (shotgunPowerup && shotgunShots < 3 * powerUpIntensity && !moveBall)
            {
                e.Graphics.DrawEllipse(shotgunPen, mouseX - 25, mouseY - 25, 50, 50);
                e.Graphics.DrawLine(shotgunPen, mouseX - 25, mouseY, mouseX + 25, mouseY);
                e.Graphics.DrawLine(shotgunPen, mouseX, mouseY - 25, mouseX, mouseY + 25);

            }
            if (moveBall)
            {
                if (Math.Abs(mouseX - balls[0].x) < 150 * powerUpIntensity && Math.Abs(mouseY - balls[0].y) < 150 * powerUpIntensity)
                {
                  
                    e.Graphics.DrawLine(moveBallPen, balls[0].x + balls[0].size / 2, balls[0].y + balls[0].size / 2, mouseX, mouseY);

                    e.Graphics.DrawLine(moveBallPen, mouseX - 15, mouseY - 15, mouseX + 15, mouseY + 15);
                    e.Graphics.DrawLine(moveBallPen, mouseX + 15, mouseY - 15, mouseX - 15, mouseY + 15);
                }
                else
                {
                    e.Graphics.DrawLine(shotgunPen, mouseX - 15, mouseY - 15, mouseX + 15, mouseY + 15);
                    e.Graphics.DrawLine(shotgunPen, mouseX + 15, mouseY - 15, mouseX - 15, mouseY + 15);
                }

                e.Graphics.DrawRectangle(moveBallPen, balls[0].x - 150 * powerUpIntensity, balls[0].y - 150 * powerUpIntensity, 300 * powerUpIntensity, 300 * powerUpIntensity);
            }

            // Draws Fire for fireball powerup
            foreach (Fire f in flames)
            {
                e.Graphics.FillEllipse(f.fireColour, f.x, f.y, f.size + random.Next(-2, 3), f.size + random.Next(-2, 3));
            }

            // Draws paddle
            e.Graphics.DrawImage(paddleImage, paddle.x, paddle.y - paddleYMove, paddle.width, paddle.width * 1.1f);


            // Draws blocks
            foreach (Block b in blocks)
            {
                e.Graphics.DrawImage(ducks[(b.hp - 1) * 3 + b.frame - 1], b.x, b.y, b.width, b.width);
            }

            foreach (Block b in deadBlocks)
            {
                e.Graphics.DrawImage(ducks[1], b.x, b.y, b.width, b.width);
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

            brush.Color = powerupColours[4];

            if (edgeProtector)
            {
                e.Graphics.FillRectangle(brush, 0, Height - 5, Width, 5);
            }

            //brush.Color = powerupColours[8];
            //foreach (Point p in explosions)
            //{
            //    e.Graphics.FillEllipse(brush, p.X - 80, p.Y - 40, 160, 80);
            //}

            if (messageTimer > 50)
            {
                string text = powerupMessage;
                using (Font font = new Font($"Algerian", 45, FontStyle.Bold, GraphicsUnit.Point))
                {
                    Rectangle rect = new Rectangle(0, 15, this.Width, 100);

                    // Create a StringFormat object with the each line of text, and the block
                    // of text centered on the page.
                    StringFormat stringFormat = new StringFormat();
                    stringFormat.Alignment = StringAlignment.Center;
                    stringFormat.LineAlignment = StringAlignment.Center;

                    // Draw the text and the surrounding rectangle.
                    e.Graphics.DrawString(text, font, Brushes.DarkBlue, rect, stringFormat);
                    //e.Graphics.DrawRectangle(Pens.Black, rect1);
                }   
            }

            // Draw timers
            timerDrawLocation = 0;

            if (random.Next(1, 5) == 1) // Bad power up flash
            {
                if (colour == Color.FromArgb(255, 200, 0))
                {
                    colour = Color.FromArgb(255, 100, 0);
                }
                else
                {
                    colour = Color.FromArgb(255, 200, 0);
                }
            }

            if (paddle.width == 160 * powerUpIntensity)
            {
                DrawTimer(paddleSizeTimer, 1000, powerupColours[1], e);
            }
            else
            {
                DrawTimer(paddleSizeTimer, 750, colour, e);
            }
            DrawTimer(paddleSpeedTimer, 750, colour, e);
            if (balls[0].speed == 1)
            {
                DrawTimer(speedBallTimer, 750, powerupColours[11], e);
            }
            else
            {
                DrawTimer(speedBallTimer, 500, colour, e);
            }
            DrawTimer(damageTimer, 750, powerupColours[6], e);
            DrawTimer(fireBallTimer, 600, powerupColours[2], e);
            DrawTimer(stickyPaddleTimer, 500, powerupColours[5], e);
            DrawTimer(explosiveHitTimer, 1000, powerupColours[8], e);
            DrawTimer(magnetTimer, 2000, powerupColours[9], e);
        }

        public void DrawTimer(int timer, int max, Color colour, PaintEventArgs e)
        {
            double pie;

            if (timer > 0)
            {
                timerDrawLocation += 40;
                brush.Color = colour;
                pie = Math.Round(Convert.ToDouble(timer * 360 / max));
                e.Graphics.FillPie(brush, Width - 50, timerDrawLocation, 40, 40, -90, Convert.ToInt16(pie));
            }
        }

        public void TheodoropoulosCode()
        {
            theoTracker++;

            if (theoTracker == 15)
            {
                theoTracker = 0;
                foreach (Block b in blocks)
                {
                    if (b.frame == 1) { b.flow = 1; }
                    else if (b.frame == 3) { b.flow = -1; }
                    b.frame += b.flow;
                }
            }
        }

        public void CooperCode()
        {
            string name;
            name = SelectScreen.username;
            string HS = score.ToString();
            int intScore = Convert.ToInt32(HS);
            int time = Convert.ToInt16(gameTimeStopwatch.ElapsedMilliseconds/1000);

            Scores newScore = new Scores(name, intScore, time);

            MenuScreen.scores.Add(newScore);

            XmlWriter writer = XmlWriter.Create("HighScoreXML.xml", null);
            writer.WriteStartElement("HighScores");

            foreach (Scores s in MenuScreen.scores)
            {
                writer.WriteElementString("Name", s.name);
                writer.WriteElementString("Score", s.score.ToString());
                writer.WriteElementString("Time", s.time.ToString());
            }

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
            if (speedBallTimer == 0 && balls[0].speed != 2)
            {
                foreach (Ball b in balls)
                {
                    b.speed = 2;
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

            if (stickyPaddleTimer == 0)
            {
                foreach (Ball b in balls)
                {
                    if (b.stuck)
                    {
                        stickyPaddle = false;
                    }
                }
            }
            else
            {
                stickyPaddleTimer--;
            }

            if (explosiveHitTimer > 0)
            {
                explosiveHitTimer--;
            }

            if (magnetTimer > 0)
            {
                magnetTimer--;
            }

            if (messageTimer > 0)
            {
                messageTimer--;
            }
        }
    }
}
