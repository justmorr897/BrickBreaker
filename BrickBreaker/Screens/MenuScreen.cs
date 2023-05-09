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
            //CooperCode();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // Goes to the game screen'
            Form1.ChangeScreen(this, new SelectScreen());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new LevelEditor());
        }

        public void CooperCode()
        {
            //scores.Clear();

            //string name, score;

            //XmlReader reader = XmlReader.Create("HighScoreXML.xml");
            //while (reader.Read())
            //{
            //    if (reader.NodeType == XmlNodeType.Text)
            //    {
            //        name = reader.ReadString();

            //        reader.ReadToNextSibling("Score");

            //        score = reader.ReadString();

            //        int newScore = Convert.ToInt32(score);

            //        Scores s = new Scores(name, newScore);

            //        scores.Add(s);
            //    }
            //}
            //reader.Close();
        }

        private void leaderboardButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new Leaderboard());     
        }
    }
    
}
