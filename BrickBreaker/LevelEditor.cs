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
        List<Rectangle> rectangles = new List<Rectangle>();

        TextBox textbox = new TextBox();
        SolidBrush redbrush = new SolidBrush(Color.Red);
        Pen drawPen = new Pen(Color.White);
        Rectangle newRect;
        int mouseX;
        int mouseY;
        int width = 50;
        int height = 25;


        public LevelEditor()
        {
            InitializeComponent();
            Rectangle saveButtonRect = new Rectangle(button1.Location.X, button1.Location.Y, width, height);
            rectangles.Add(saveButtonRect);
        }

        private void LevelEditor_MouseClick(object sender, MouseEventArgs e)
        {
            if(drawPen.Color == Color.Blue)
            {
                rectangles.Add(newRect);

                textbox = new TextBox();
                textbox.Font = new Font("Arial", 14);
                textbox.Location = new Point(e.X, e.Y);
                textbox.Size = new Size(50, 25);
                textbox.BackColor = Color.Black;
                textbox.ForeColor = Color.White;
                textbox.TextAlign = HorizontalAlignment.Center;


                textbox.KeyDown += new KeyEventHandler(Textbox_KeyDown);

                this.Controls.Add(textbox);
                textbox.Focus();
            }
            else
            {

            }
            
        }

        private void LevelEditor_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;

            newRect = new Rectangle(e.X, e.Y, width, height);

            for (int i = 0; i < rectangles.Count; i++)
            {
                if (newRect.IntersectsWith(rectangles[i]))
                {
                    drawPen = new Pen(Color.Red);
                    break;
                }
                else
                {
                    drawPen = new Pen(Color.Blue);
                }

            }

            Refresh();


        }

        public void Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textbox.Text == "1")
                {
                    textbox.BackColor = Color.Green;
                }
                else if (textbox.Text == "2")
                {
                    textbox.BackColor = Color.DarkCyan;
                }
                else if (textbox.Text == "3")
                {
                    textbox.BackColor = Color.Orange;
                }
                else if (textbox.Text == "4")
                {
                    textbox.BackColor = Color.Red;
                }
                else if (textbox.Text == "5")
                {
                    textbox.BackColor = Color.Purple;
                }
                else if (textbox.Text == "6")
                {
                    textbox.BackColor = Color.Gold;
                }
                else if (textbox.Text == "7")
                {
                    textbox.BackColor = Color.Black;
                }

                textbox.Enabled = false;
            }
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



        private void LevelEditor_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(drawPen, mouseX, mouseY, 50, 25);
        }
    }
}
