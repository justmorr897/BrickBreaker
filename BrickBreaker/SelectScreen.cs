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
        int level; 

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
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void levelsButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                GameScreen.gameLevel = 1;
                GameScreen.isSaveLevelSelcted = false;
                ChangeScreen();

            }
            else
            {
                Error();

            }
        }

        public void ButtonClick(int _level)
        {
            if (checkBox1.Checked == true)
            {
                GameScreen.saveLevel = _level;
                GameScreen.isSaveLevelSelcted = true;
                Form1.ChangeScreen(this, new GameScreen());

            }
            else
            {
                Error();
            }
        }

        private void SaveButton1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            level = Convert.ToInt32(button.Tag);
            ButtonClick(level);

            //level = 1;
            //ButtonClick(level);
        }

        private void SaveButton2_Click(object sender, EventArgs e)
        {
            level = 2;
            ButtonClick(level);
        }

        private void SaveButton3_Click(object sender, EventArgs e)
        {
            level = 3;
            ButtonClick(level);
        }

        private void SaveButton4_Click(object sender, EventArgs e)
        {
            level = 4;
            ButtonClick(level);
        }

        private void SaveButton5_Click(object sender, EventArgs e)
        {
            level = 5;
            ButtonClick(level);
        }

        public void Error()
        {
            errorLabel.Visible = true;
            usernameInput.Focus();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
