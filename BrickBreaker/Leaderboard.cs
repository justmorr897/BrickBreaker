using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace BrickBreaker
{
    public partial class Leaderboard : UserControl
    {
        Bitmap duckImage = new Bitmap(Properties.Resources.Duck03);
        Stopwatch stopwatch = new Stopwatch();
        public static bool gameOver = false;

        public Leaderboard()
        {
            InitializeComponent();
            //PrintToScreen();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            Animation();
        }

        public void Animation()
        {
            outputLabel.Font = new Font(outputLabel.Font.Name, 24);

            if (gameOver)
            {
                nameLabelColumn.Text = "Name:";
                scoreLabelColumn.Text = "Score:";
                timeLabelColumn.Text = "Time:";

                nameLabelColumn.Size = new Size(nameLabelColumn.Width, nameLabelColumn.Height + 40);
                scoreLabelColumn.Size = new Size(scoreLabelColumn.Width, scoreLabelColumn.Height + 40);
                timeLabelColumn.Size = new Size(timeLabelColumn.Width, timeLabelColumn.Height + 40);

                nameLabelColumn.Text += $"\n{MenuScreen.scores[MenuScreen.scores.Count - 1].name}";
                scoreLabelColumn.Text += $"\n{MenuScreen.scores[MenuScreen.scores.Count - 1].score}";
                timeLabelColumn.Text += $"\n{MenuScreen.scores[MenuScreen.scores.Count - 1].time}";


                if (GameScreen.saveLevel > 5 || GameScreen.gameLevel > 5)
                {
                    outputLabel.Visible = true;
                    outputLabel.Text = "Levels Cleared!";

                    int textSize = 12;
                    while (outputLabel.Font.Size < 32)
                    {
                        textSize += 2;
                        outputLabel.Font = new Font(outputLabel.Font.Name, textSize);
                        Refresh();
                    }

                    while (outputLabel.Location.Y < 400)
                    {
                        outputLabel.Location = new Point(outputLabel.Location.X, outputLabel.Location.Y + 20);
                        Refresh();
                    }

                    stopwatch.Start();
                    while (stopwatch.ElapsedMilliseconds  < 1200)
                    {

                    }

                    for (int i = outputLabel.Location.Y; i < this.Height; i += 18)
                    {
                        outputLabel.Location = new Point(outputLabel.Location.X, i);
                        Refresh();
                    }

                    stopwatch.Reset();

                    PrintToScreen();
                }
                else
                {
                    outputLabel.Visible = true;
                    outputLabel.Text = "So Close!";
                    tryAgainLabel.Visible = true;
                    tryAgainLabel.Text = "Try Again?";
                    yesButton.Visible = true;
                    noButton.Visible = true;

                    int textSize = 12;
                    while(outputLabel.Font.Size < 32)
                    {
                        textSize += 2;
                        outputLabel.Font = new Font(outputLabel.Font.Name, textSize);
                        Refresh();
                    }

                    
                }

            }
            else
            {
                PrintToScreen();
            }
        }

        public void PrintToScreen()
        {
            nameLabelColumn.Text = "Name:";
            scoreLabelColumn.Text = "Score:";
            timeLabelColumn.Text = "Time:";

            nameLabelColumn.Size = new Size(nameLabelColumn.Width, nameLabelColumn.Height - 40);
            scoreLabelColumn.Size = new Size(scoreLabelColumn.Width, scoreLabelColumn.Height - 40);
            timeLabelColumn.Size = new Size(timeLabelColumn.Width, timeLabelColumn.Height - 40);


            List<Scores> sortedScores = MenuScreen.scores.OrderByDescending(x => x.score).ToList();

            int start = 180;

            foreach (Scores s in sortedScores)
            {
                if (s.Equals(MenuScreen.scores[MenuScreen.scores.Count - 1]))
                {
                    nameLabelColumn.Text += $"\n*{s.name}*";
                    scoreLabelColumn.Text += $"\n*{s.score}*";
                    timeLabelColumn.Text += $"\n*{s.time}*";
                }
                else
                {
                    nameLabelColumn.Text += $"\n{s.name}";
                    scoreLabelColumn.Text += $"\n{s.score}";
                    timeLabelColumn.Text += $"\n{s.time}";
                }

                nameLabelColumn.Size = new Size(nameLabelColumn.Width, nameLabelColumn.Height + 40);
                scoreLabelColumn.Size = new Size(scoreLabelColumn.Width, scoreLabelColumn.Height + 40);
                timeLabelColumn.Size = new Size(timeLabelColumn.Width, timeLabelColumn.Height + 40);

                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.Transparent;
                pictureBox.Location = new Point(40, start);
                pictureBox.Size = new Size(45, 30);
                pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox.BackgroundImage = duckImage;
                this.Controls.Add(pictureBox);

                start = start + 35;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            XmlWriter writer = XmlWriter.Create("HighScoreXML.xml", null);
            writer.WriteStartElement("HighScores");
            writer.WriteEndElement();
            writer.Close();

            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                if (Controls[i] is PictureBox)
                {
                    Controls.Remove(Controls[i]);
                }
            }

            MenuScreen.scores.Clear();

            PrintToScreen();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new SelectScreen());
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            yesButton.Visible = false;
            noButton.Visible = false;
            outputLabel.Visible = false;
            tryAgainLabel.Visible = false;
            PrintToScreen();
        }


    }
}
