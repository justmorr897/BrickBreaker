using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BrickBreaker
{
    public partial class MenuScreen : UserControl
    {
        public static List<Scores> scores = new List<Scores>();
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit program
            Application.Exit();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // Goes to the game screen
            Form1.ChangeScreen(this, new SelectScreen());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Launch Level Editor
            Form1.ChangeScreen(this, new LevelEditor());
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {
            //Launch leaderboard and set gameOver to false since it was accessed through the menu
            Leaderboard.gameOver = false;
            Form1.ChangeScreen(this, new Leaderboard());
        }
    }
}
