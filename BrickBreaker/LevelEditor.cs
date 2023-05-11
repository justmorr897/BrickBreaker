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
        Pen drawPen = new Pen(Color.White);
        Rectangle newRect;
        int mouseX, mouseY;
        int width = 45;
        int height = 30;
        int level = 0;
        int buttonSpeed = 5;
        int color;

        public LevelEditor()
        {
            InitializeComponent();
            Rectangle backButtonRect = new Rectangle(backButton.Location.X, backButton.Location.Y, width, height);
            rectangles.Add(backButtonRect);

            // Set a default value
            color = 1;
        }

        private void LevelEditor_MouseClick(object sender, MouseEventArgs e)
        {
            Print();
        }

        public void Print()
        {
            bool isOverlapping = false;

            if (drawPen.Color == Color.White)
            {
                for (int i = 0; i < rectangles.Count; i++)
                {
                    if (newRect.IntersectsWith(rectangles[i]))
                    {
                        isOverlapping = true;
                    }
                }

                if (isOverlapping == false)
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

                    textbox.Font = new Font("Arial", 13);
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
                    drawPen = new Pen(Color.White);
                }
            }

            Refresh();
        }

        public void Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            outputLabel.Visible = false;

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

            if (e.KeyCode == Keys.Up && mouseY - (height + 5) > 0)
            {
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - (height + 5));
                Print();
            }
            else if (e.KeyCode == Keys.Right && mouseX + (width + 5) < Form1.formWidth - width)
            {
                Cursor.Position = new Point(Cursor.Position.X + (width + 10), Cursor.Position.Y);
                Print();

            }
            else if (e.KeyCode == Keys.Down && mouseY + (height + 5) < Form1.formHeight - height)
            {
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + (height + 5));
                Print();

            }
            else if (e.KeyCode == Keys.Left && mouseX - (width + 5) > 0)
            {
                Cursor.Position = new Point(Cursor.Position.X - (width + 10), Cursor.Position.Y);
                Print();
            }

            if (e.KeyCode == Keys.V)
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

            level1Button.Location = new Point(-140, level1Button.Location.Y);
            level2Button.Location = new Point(-140, level2Button.Location.Y);
            level3Button.Location = new Point(-140, level3Button.Location.Y);
            level4Button.Location = new Point(-140, level4Button.Location.Y);
            level5Button.Location = new Point(-140, level5Button.Location.Y);

            while (level1Button.Location.X < -15)
            {
                level1Button.Location = new Point(level1Button.Location.X + buttonSpeed, level1Button.Location.Y);
                level1Button.Refresh();
            }
            while (level2Button.Location.X < -15)
            {
                level2Button.Location = new Point(level2Button.Location.X + buttonSpeed, level2Button.Location.Y);
                level2Button.Refresh();
            }
            while (level3Button.Location.X < -15)
            {
                level3Button.Location = new Point(level3Button.Location.X + buttonSpeed, level3Button.Location.Y);
                level3Button.Refresh();
            }
            while (level4Button.Location.X < -15)
            {
                level4Button.Location = new Point(level4Button.Location.X + buttonSpeed, level4Button.Location.Y);
                level4Button.Refresh();
            }
            while (level5Button.Location.X < -15)
            {
                level5Button.Location = new Point(level5Button.Location.X + buttonSpeed, level5Button.Location.Y);
                level5Button.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            color = Convert.ToInt16(button.Tag);
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            level = Convert.ToInt16(button.Tag);
            LevelButtonClick();
        }      

        public void LevelButtonClick()
        {
            string levelFile = "Resources/UserLevel" + level + ".xml";
            XmlWriter writer = XmlWriter.Create(levelFile);

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

            for (int i = length - 13; i >= 0; i--)
            {
                this.Controls.Remove(textboxList[i]);
            }

            textboxList.Clear();
            rectangles.Clear();
            outputLabel.Visible = true;
            outputLabel.Text = $"Level {level} Saved";

            ButtonVisibleChange();
        }

        private void LevelEditor_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(drawPen, mouseX, mouseY, width, height);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
