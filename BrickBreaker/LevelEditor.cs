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
    public partial class LevelEditor : UserControl
    {
        public LevelEditor()
        {
            InitializeComponent();
        }

        private void LevelEditor_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textbox = new TextBox();
            textbox.Location = new Point(e.X, e.Y);
            textbox.Size = new Size(50, 25);
            textbox.BackColor = Color.Black;
            textbox.ForeColor = Color.White;
            textbox.TextAlign = HorizontalAlignment.Center;
            this.Controls.Add(textbox);
            textbox.Focus();

            if(textbox.Text == "1")
            {
                textbox.BackColor = Color.Yellow;
            }
            else if (textbox.Text == "2")
            {
                textbox.BackColor = Color.Orange;
            }
            else if (textbox.Text == "3")
            {
                textbox.BackColor = Color.Red;
            }
            else if (textbox.Text == "4")
            {
                textbox.BackColor = Color.White;
            }

            //textbox.KeyDown 

            //Label label = new Label();
            //label.Location = new Point(e.X, e.Y);
            //label.Size = new Size(50, 25);
            //label.BackColor = Color.Black;
            //this.Controls.Add(label);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("Resources/LevelEditorXML.xml", null);

            writer.WriteStartElement("Level");

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {

                    writer.WriteStartElement("brick");
                    writer.WriteElementString("x", $"{c.Location.X}");
                    writer.WriteElementString("y", $"{c.Location.Y}");
                    writer.WriteElementString("hp", $"{c.Text}");
                    writer.WriteElementString("color", $"{c.BackColor.Name}");

                    writer.WriteEndElement();
                }
            }

            writer.WriteEndElement();

            writer.Close();
        }
    }
}
