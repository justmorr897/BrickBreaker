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
        List<TextBox> textboxList = new List<TextBox>();

        TextBox textbox = new TextBox();
        SolidBrush redbrush = new SolidBrush(Color.Red);
        Pen drawPen = new Pen(Color.White);
        Rectangle newRect;
        int mouseX;
        int mouseY;
        int width = 30;
        int height = 20;
        int level = 0;
        int totalLevels = 5;

        int color;

        public LevelEditor()
        {
            InitializeComponent();
            Rectangle saveButtonRect = new Rectangle(button1.Location.X, button1.Location.Y, width, height);
            rectangles.Add(saveButtonRect);
        }

        private void LevelEditor_MouseClick(object sender, MouseEventArgs e)
        {
            Print();
        }

        public void Print()
        {
            if (drawPen.Color == Color.Blue)
            {
                rectangles.Add(newRect);

                textbox = new TextBox();

                    if (color == 1)
                    {
                        textbox.BackColor = Color.Green;
                        textbox.Text = "1";
                    }
                    else if (color == 2)
                    {
                        textbox.BackColor = Color.DarkCyan;
                        textbox.Text = "2";
                    }
                    else if (color == 3)
                    {
                        textbox.BackColor = Color.Orange;
                        textbox.Text = "3";
                    }
                    else if (color == 4)
                    {
                        textbox.BackColor = Color.Purple;
                        textbox.Text = "4";
                    }
                    else if (color == 5)
                    {
                        textbox.BackColor = Color.Gold;
                        textbox.Text = "5";
                    }
                    else if (color == 6)
                    {
                        textbox.BackColor = Color.Black;
                        textbox.Text = "6";
                    }
                    else if (color == 7)
                    {
                        textbox.BackColor = Color.Red;
                        textbox.Text = "7";
                    }

                textbox.Font = new Font("Arial", 7);
                textbox.Location = new Point(mouseX, mouseY);
                textbox.Size = new Size(width, height);
                textbox.ForeColor = Color.White;
                textbox.TextAlign = HorizontalAlignment.Center;
                textbox.ReadOnly = true;

                textbox.KeyDown += new KeyEventHandler(Textbox_KeyDown);

                this.Controls.Add(textbox);
                textbox.Focus();

                textboxList.Add(textbox);
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
            TextBox textbox = sender as TextBox;
            //string currentText = textbox.Text;

            if (e.KeyCode == Keys.D1)
            {
                color = 1;
            }
            else if (e.KeyCode == Keys.D2)
            {
                color = 2;
            }
            else if (e.KeyCode == Keys.D3)
            {
                color = 3;
            }
            else if (e.KeyCode == Keys.D4)
            {
                color = 4;
            }
            else if (e.KeyCode == Keys.D5)
            {
                color = 5;
            }

            if (e.KeyCode == Keys.Up)
            {
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - 30);
                Print();
            }
            else if (e.KeyCode == Keys.Right)
            {
                Cursor.Position = new Point(Cursor.Position.X + 60, Cursor.Position.Y);
                Print();

            }
            else if (e.KeyCode == Keys.Down)
            {
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + 30);
                Print();

            }
            else if (e.KeyCode == Keys.Left)
            {
                Cursor.Position = new Point(Cursor.Position.X - 60, Cursor.Position.Y);
                Print();
            }

            if(e.KeyCode == Keys.V)
            {
                ButtonVisibleChange();
            }
        }

        public void ButtonVisibleChange()
        {
            level1Button.Visible = !level1Button.Visible;
            level2Button.Visible = !level2Button.Visible;
            level3Button.Visible = !level3Button.Visible;
            level4Button.Visible = !level4Button.Visible;
            level5Button.Visible = !level5Button.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LevelEditor_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(drawPen, mouseX, mouseY, width, height);
        }

        private void oneHPButton_Click(object sender, EventArgs e)
        {
            color = 1;
        }

        private void twoHPButton_Click(object sender, EventArgs e)
        {
            color = 2;
        }

        private void threeHPButton_Click(object sender, EventArgs e)
        {
            color = 3;
        }

        private void fourHPButton_Click(object sender, EventArgs e)
        {
            color = 4;
        }

        private void fiveHPButton_Click(object sender, EventArgs e)
        {
            color = 5;
        }

        private void level1Button_MouseEnter(object sender, EventArgs e)
        {
            //Button tempButton = sender as Button;
            //tempButton.Location = new Point(100, tempButton.Location.Y);
        }

        private void level1Button_MouseLeave(object sender, EventArgs e)
        {
            //Button tempButton = sender as Button;
            //tempButton.Location = new Point(-50, tempButton.Location.Y);

        }

        private void level1Button_Click(object sender, EventArgs e)
        {
            level = 1;
            LevelButtonClick(level);
            ButtonVisibleChange();

            //string levelFile = "Resources/level" + level + ".xml";
            //XmlWriter writer = XmlWriter.Create(levelFile);

            ////XmlWriter writer = XmlWriter.Create("Resources/LevelEditorXML.xml");

        }

        private void level2Button_Click(object sender, EventArgs e)
        {
            level = 2;
            LevelButtonClick(level);
            ButtonVisibleChange();

            //string levelFile = "Resources/level" + level + ".xml";
            //XmlWriter writer = XmlWriter.Create(levelFile);

            ////XmlWriter writer = XmlWriter.Create("Resources/LevelEditorXML.xml");

        }

        private void level3Button_Click(object sender, EventArgs e)
        {
            level = 3;
            LevelButtonClick(level);
            ButtonVisibleChange();

            //string levelFile = "Resources/level" + level + ".xml";
            //XmlWriter writer = XmlWriter.Create(levelFile);

            ////XmlWriter writer = XmlWriter.Create("Resources/LevelEditorXML.xml");

            //writer.WriteStartElement("Level");
        }

        private void level4Button_Click(object sender, EventArgs e)
        {
            level = 4;
            LevelButtonClick(level);
            ButtonVisibleChange();

            //string levelFile = "Resources/level" + level + ".xml";
            //XmlWriter writer = XmlWriter.Create(levelFile);

            ////XmlWriter writer = XmlWriter.Create("Resources/LevelEditorXML.xml");

            //writer.WriteStartElement("Level");
        }

        private void level5Button_Click(object sender, EventArgs e)
        {
            level = 5;
            LevelButtonClick(level);
            ButtonVisibleChange();
            //string levelFile = "Resources/level" + level + ".xml";
            //XmlWriter writer = XmlWriter.Create(levelFile);

            ////XmlWriter writer = XmlWriter.Create("Resources/LevelEditorXML.xml");
        }

        public void LevelButtonClick(int _level)
        {
            level = _level;

            string levelFile = "Resources/level" + level + ".xml";
            XmlWriter writer = XmlWriter.Create(levelFile);

            //XmlWriter writer = XmlWriter.Create("Resources/LevelEditorXML.xml");

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

            int length = this.Controls.Count;

            for (int i = length - 12; i >= 0; i--)
            {
                //this.Controls.RemoveAt(i);
                this.Controls.Remove(textboxList[i]);
            }

            textboxList.Clear();
            //level5Button.Enabled = false;
        }
    }
}
