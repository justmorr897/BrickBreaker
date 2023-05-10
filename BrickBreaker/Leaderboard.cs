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

            int start = 220;

            foreach (Scores s in sortedScores)
            {
                nameLabelColumn.Text += $"\n{s.name}";
                scoreLabelColumn.Text += $"\n{s.score}";
                timeLabelColumn.Text += $"\n{s.time}";

                nameLabelColumn.Size = new Size(nameLabelColumn.Width, nameLabelColumn.Height + 40);
                scoreLabelColumn.Size = new Size(scoreLabelColumn.Width, scoreLabelColumn.Height + 40);
                timeLabelColumn.Size = new Size(timeLabelColumn.Width, timeLabelColumn.Height + 40);

                PictureBox pictureBox = new PictureBox();
                pictureBox.BackColor = Color.Transparent;
                pictureBox.Location = new Point(50, start);
                pictureBox.Size = new Size(45,30);
                pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBox.BackgroundImage = duckImage;
                this.Controls.Add(pictureBox);

                start = start + 38;

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
