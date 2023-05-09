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
        public Leaderboard()
        {
            InitializeComponent();
            PrintToScreen();
        }

        public void PrintToScreen()
        {
            nameLabelColumn.Text = "Username:";
            scoreLabelColumn.Text = "Score:";

            List<Scores> sortedScores = MenuScreen.scores.OrderByDescending(x => x.score).ToList();

            foreach (Scores s in sortedScores)
            {
                nameLabelColumn.Text += $"\n{s.name}";
                scoreLabelColumn.Text += $"\n{s.score}";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
