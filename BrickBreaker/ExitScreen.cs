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
    public partial class ExitScreen : UserControl
    {
        public ExitScreen()
        {
            InitializeComponent();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            MenuScreen ss = new MenuScreen();
            Form form = this.FindForm();

            form.Controls.Add(ss);
            form.Controls.Remove(this);

            ss.Location = new Point((form.Width - ss.Width) / 2, (form.Height - ss.Height) / 2);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
