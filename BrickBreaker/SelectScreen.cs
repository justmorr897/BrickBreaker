using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class SelectScreen : UserControl
    {
        public static string username;
        bool usernameEntered = false;

        public SelectScreen()
        {
            InitializeComponent();
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            errorLabel.Visible = false;

            if(e.KeyCode == Keys.Enter && usernameInput.Text != "")
            {
                username = usernameInput.Text;
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        public void ChangeScreen()
        {
            GameScreen gs = new GameScreen();
            Form form = this.FindForm();

            form.Controls.Add(gs);
            form.Controls.Remove(this);

            gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);
        }

        private void levelsButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                ChangeScreen();
                GameScreen.gameLevel = 1;
                GameScreen.isSaveLevelSelcted = false;
            }
            else
            {
                Error();

            }


        }

        private void SaveButton1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                ChangeScreen();
                GameScreen.saveLevel = 1;
                GameScreen.isSaveLevelSelcted = true;
            }
            else
            {
                Error();

            }

        }

        private void SaveButton2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                ChangeScreen();
                GameScreen.saveLevel = 2;
                GameScreen.isSaveLevelSelcted = true;
            }
            else
            {
                Error();

            }

        }

        private void SaveButton3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                ChangeScreen();
                GameScreen.saveLevel = 3;
                GameScreen.isSaveLevelSelcted = true;
            }
            else
            {
                Error();

            }

        }

        private void SaveButton4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                ChangeScreen();
                GameScreen.saveLevel = 4;
                GameScreen.isSaveLevelSelcted = true;
            }
            else
            {
                Error();

            }

        }

        private void SaveButton5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                ChangeScreen();
                GameScreen.saveLevel = 5;
                GameScreen.isSaveLevelSelcted = true;
            }
            else
            {
                Error();
            }

        }

        public void Error()
        {
            errorLabel.Visible = true;
            usernameInput.Focus();
        }
    }
}
