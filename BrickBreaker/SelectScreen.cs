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
        public SelectScreen()
        {
            InitializeComponent();
        }

        private void SelectScreen_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

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
            ChangeScreen();
        }

        private void SaveButton1_Click(object sender, EventArgs e)
        {
            GameScreen.level = 1;

            ChangeScreen();

        }

        private void SaveButton2_Click(object sender, EventArgs e)
        {
            GameScreen.level = 2;

            ChangeScreen();

        }

        private void SaveButton3_Click(object sender, EventArgs e)
        {
            GameScreen.level = 3;

            ChangeScreen();

        }

        private void SaveButton4_Click(object sender, EventArgs e)
        {
            GameScreen.level = 4;

            ChangeScreen();

        }

        private void SaveButton5_Click(object sender, EventArgs e)
        {
            GameScreen.level = 5;

            ChangeScreen();

        }
    }
}
