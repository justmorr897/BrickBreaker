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

        //Lists of images for UX and animation
        List<PictureBox> leftPictureBoxes = new List<PictureBox>();
        List<PictureBox> rightPictureBoxes = new List<PictureBox>();

        public SelectScreen()
        {
            InitializeComponent();

            leftPictureBoxes.Add(pictureBox3);
            leftPictureBoxes.Add(pictureBox4);
            leftPictureBoxes.Add(pictureBox5);
            leftPictureBoxes.Add(pictureBox6);
            leftPictureBoxes.Add(pictureBox7);
            leftPictureBoxes.Add(pictureBox8);
            leftPictureBoxes.Add(pictureBox1);
            leftPictureBoxes.Add(pictureBox2);

            Bitmap flipImage1 = new Bitmap(Properties.Resources.Duck01);
            Bitmap flipImage2 = new Bitmap(Properties.Resources.Duck02);
            Bitmap flipImage3 = new Bitmap(Properties.Resources.Duck03);

            //Flip the images
            flipImage1.RotateFlip(RotateFlipType.Rotate180FlipY);
            flipImage2.RotateFlip(RotateFlipType.Rotate180FlipY);
            flipImage3.RotateFlip(RotateFlipType.Rotate180FlipY);

            pictureBox9.BackgroundImage = flipImage3;
            pictureBox10.BackgroundImage = flipImage2;
            pictureBox11.BackgroundImage = flipImage1;
            pictureBox12.BackgroundImage = flipImage2;
            pictureBox13.BackgroundImage = flipImage3;
            pictureBox14.BackgroundImage = flipImage2;
            pictureBox15.BackgroundImage = flipImage1;
            pictureBox16.BackgroundImage = flipImage2;

            rightPictureBoxes.Add(pictureBox11);
            rightPictureBoxes.Add(pictureBox12);
            rightPictureBoxes.Add(pictureBox13);
            rightPictureBoxes.Add(pictureBox14);
            rightPictureBoxes.Add(pictureBox15);
            rightPictureBoxes.Add(pictureBox16);
            rightPictureBoxes.Add(pictureBox9);
            rightPictureBoxes.Add(pictureBox10);
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            errorLabel.Visible = false;

            //Make sure the user adds a username
            //It crashes the program if the username is null
            if (e.KeyCode == Keys.Enter && usernameInput.Text != "")
            {
                username = usernameInput.Text;
                usernameCheckbox.Checked = true;
                usernameInput.Enabled = false;
                partyModeCheckbox.Focus();
            }
            else
            {
                usernameCheckbox.Checked = false;
            }
        }

        public void ChangeScreen()
        {
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void levelsButton_Click(object sender, EventArgs e)
        {
            //Load gameLevel one
            if (usernameCheckbox.Checked == true)
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
            //Load save level that is sent
            //Change to GameScreen
            if (usernameCheckbox.Checked == true)
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
            //For each save button send the sender tag value to ButtonClick event to load corresponding level
            Button button = sender as Button;
            level = Convert.ToInt32(button.Tag);
            ButtonClick(level);
        }

        public void Error()
        {
            //If user didn't enter a username and tried to click, make error label visible
            errorLabel.Visible = true;

            //Focus back onto the username input for the user to enter
            usernameInput.Focus();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //Back to Menu
            Form1.ChangeScreen(this, new MenuScreen());
        }

        private void partyModeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            //Change partymode variable
            GameScreen.partyMode = partyModeCheckbox.Checked;

            //Focus on the next control
            SaveButton1.Focus();
            leftPictureBoxes[0].Visible = true;
            rightPictureBoxes[0].Visible = true;
        }

        public void MakeVisible(int tag)
        {
            //Uses the tag of the control sent to make that duck image visible
            leftPictureBoxes[tag].Visible = true;
            rightPictureBoxes[tag].Visible = true;
        }

        public void MakeNotVisible()
        {
            //Make all duck images not visible
            for (int i = 0; i < rightPictureBoxes.Count; i++)
            {
                rightPictureBoxes[i].Visible = false;
                leftPictureBoxes[i].Visible = false;
            }
        }

        private void SaveButton1_MouseEnter(object sender, EventArgs e)
        {
            //On mouse enter make corresponding duck visible
            Button button = sender as Button;
            int tag = Convert.ToInt16(button.Tag);
            MakeVisible(tag - 1);
        }

        private void SaveButton1_MouseLeave(object sender, EventArgs e)
        {
            //On any save button leave
            //Make all pictures not visible
            MakeNotVisible();
        }

        private void SaveButton1_Enter(object sender, EventArgs e)
        {
            //When the button is focused do the same as if it was moused-over
            Button button = sender as Button;
            int tag = Convert.ToInt16(button.Tag);

            MakeNotVisible();
            MakeVisible(tag - 1);
        }

        private void usernameInput_Enter(object sender, EventArgs e)
        {
            MakeNotVisible();
            MakeVisible(6);
        }

        private void partyModeCheckbox_Enter(object sender, EventArgs e)
        {
            MakeNotVisible();
            MakeVisible(7);
        }

        private void partyModeCheckbox_MouseEnter(object sender, EventArgs e)
        {
            partyModeCheckbox.Focus();

            CheckBox checkBox = sender as CheckBox;
            int tag = Convert.ToInt16(checkBox.Tag);

            MakeNotVisible();
            MakeVisible(tag - 1);
        }

        private void partyModeCheckbox_MouseLeave(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            int tag = Convert.ToInt16(checkBox.Tag);

            MakeNotVisible();
        }
    }
}
