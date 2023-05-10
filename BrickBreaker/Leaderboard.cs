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

namespace BrickBreaker
{
    public partial class Leaderboard : UserControl
    {
        Bitmap duckImage = new Bitmap(Properties.Resources.Duck03);

        public Leaderboard()
        {
            InitializeComponent();
            PrintToScreen();
        }

        public void PrintToScreen()
        {
            nameLabelColumn.Text = "Name:";
            scoreLabelColumn.Text = "Score:";
            timeLabelColumn.Text = "Time:";

            List<Scores> sortedScores = MenuScreen.scores.OrderByDescending(x => x.score).ToList();

            int start = 140;

            foreach (Scores s in sortedScores)
            {
                nameLabelColumn.Text += $"\n{s.name}";
                scoreLabelColumn.Text += $"\n{s.score}";
                timeLabelColumn.Text += $"\n{s.time}";

                nameLabelColumn.Size = new Size(nameLabelColumn.Width, nameLabelColumn.Height + 30);
                scoreLabelColumn.Size = new Size(scoreLabelColumn.Width, scoreLabelColumn.Height + 30);
                timeLabelColumn.Size = new Size(timeLabelColumn.Width, timeLabelColumn.Height + 30);

                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.Transparent;
                pictureBox.Location = new Point(25, start + 30);
                pictureBox.Size = new Size(45,30);
                pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox.BackgroundImage = duckImage;
                this.Controls.Add(pictureBox);

                start = start + 30;

            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuScreen.scores.Clear();
            PrintToScreen();
        }
    }
}
