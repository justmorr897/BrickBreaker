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
    public partial class Form1 : Form
    {
        public static int formWidth, formHeight;

        public Form1()
        {
            InitializeComponent();
            ReadXmlFile();
        }

        public void ReadXmlFile()
        {
            string name;
            int score, time;
            string levelFile = "HighScoreXML.xml";
            XmlReader reader = XmlReader.Create(levelFile);

            reader.ReadToFollowing("HighScores");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    name = reader.ReadString();

                    reader.ReadToNextSibling("Score");
                    score = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("Time");
                    time = Convert.ToInt32(reader.ReadString());

                    Scores newScore = new Scores(name, score, time);
                    MenuScreen.scores.Add(newScore);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formWidth = this.Width;
            formHeight = this.Height;

            // Start the program centred on the Menu Screen
            ChangeScreen(this, new MenuScreen());
        }

        public static void ChangeScreen(object sender, UserControl next)
        {
            Form f; // will either be the sender or parent of sender

            if (sender is Form)
            {
                f = (Form)sender;
            }
            else
            {
                UserControl current = (UserControl)sender;
                f = current.FindForm();
                f.Controls.Remove(current);
            }

            next.Location = new Point((f.ClientSize.Width - next.Width) / 2,
                (f.ClientSize.Height - next.Height) / 2);

            f.Controls.Add(next);
            next.Focus();
        }

    }
}
