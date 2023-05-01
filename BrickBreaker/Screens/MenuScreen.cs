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
        List<Scores> scores = new List<Scores>();
        public MenuScreen()
        {
            InitializeComponent();
            CooperCode();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // Goes to the game screen'

            SelectScreen ss = new SelectScreen();
            Form form = this.FindForm();

            form.Controls.Add(ss);
            form.Controls.Remove(this);

            ss.Location = new Point((form.Width - ss.Width) / 2, (form.Height - ss.Height) / 2);

            //GameScreen gs = new GameScreen();
            //Form form = this.FindForm();

            //form.Controls.Add(gs);
            //form.Controls.Remove(this);

            //gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LevelEditor le = new LevelEditor();
            Form form = this.FindForm();

            form.Controls.Add(le);
            form.Controls.Remove(this);

            le.Location = new Point((form.Width - le.Width) / 2, (form.Height - le.Height) / 2);
        }

        public void CooperCode()
        {
            string name, score;

            XmlReader reader = XmlReader.Create("HighScoreXML.xml");
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    name = reader.ReadString();

                    reader.ReadToNextSibling("score");

                    score = reader.ReadString();

                    Scores s = new Scores(name, score);

                    scores.Add(s);
                }
            }
            reader.Close();
        }

    }
}
