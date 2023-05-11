namespace BrickBreaker
{
    partial class LevelEditor
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oneHPButton = new System.Windows.Forms.Button();
            this.twoHPButton = new System.Windows.Forms.Button();
            this.threeHPButton = new System.Windows.Forms.Button();
            this.fiveHPButton = new System.Windows.Forms.Button();
            this.fourHPButton = new System.Windows.Forms.Button();
            this.level1Button = new System.Windows.Forms.Button();
            this.level2Button = new System.Windows.Forms.Button();
            this.level3Button = new System.Windows.Forms.Button();
            this.level4Button = new System.Windows.Forms.Button();
            this.level5Button = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oneHPButton
            // 
            this.oneHPButton.BackColor = System.Drawing.Color.Green;
            this.oneHPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneHPButton.Location = new System.Drawing.Point(55, 642);
            this.oneHPButton.Name = "oneHPButton";
            this.oneHPButton.Size = new System.Drawing.Size(95, 45);
            this.oneHPButton.TabIndex = 1;
            this.oneHPButton.Tag = "1";
            this.oneHPButton.Text = "1 HP";
            this.oneHPButton.UseVisualStyleBackColor = false;
            this.oneHPButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // twoHPButton
            // 
            this.twoHPButton.BackColor = System.Drawing.Color.DarkCyan;
            this.twoHPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoHPButton.Location = new System.Drawing.Point(155, 642);
            this.twoHPButton.Name = "twoHPButton";
            this.twoHPButton.Size = new System.Drawing.Size(95, 45);
            this.twoHPButton.TabIndex = 2;
            this.twoHPButton.Tag = "2";
            this.twoHPButton.Text = "2 HP";
            this.twoHPButton.UseVisualStyleBackColor = false;
            this.twoHPButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // threeHPButton
            // 
            this.threeHPButton.BackColor = System.Drawing.Color.Orange;
            this.threeHPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeHPButton.Location = new System.Drawing.Point(255, 642);
            this.threeHPButton.Name = "threeHPButton";
            this.threeHPButton.Size = new System.Drawing.Size(95, 45);
            this.threeHPButton.TabIndex = 3;
            this.threeHPButton.Tag = "3";
            this.threeHPButton.Text = "3 HP";
            this.threeHPButton.UseVisualStyleBackColor = false;
            this.threeHPButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fiveHPButton
            // 
            this.fiveHPButton.BackColor = System.Drawing.Color.Gold;
            this.fiveHPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveHPButton.Location = new System.Drawing.Point(455, 642);
            this.fiveHPButton.Name = "fiveHPButton";
            this.fiveHPButton.Size = new System.Drawing.Size(95, 45);
            this.fiveHPButton.TabIndex = 4;
            this.fiveHPButton.Tag = "5";
            this.fiveHPButton.Text = "5 HP";
            this.fiveHPButton.UseVisualStyleBackColor = false;
            this.fiveHPButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fourHPButton
            // 
            this.fourHPButton.BackColor = System.Drawing.Color.Purple;
            this.fourHPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourHPButton.Location = new System.Drawing.Point(355, 642);
            this.fourHPButton.Name = "fourHPButton";
            this.fourHPButton.Size = new System.Drawing.Size(95, 45);
            this.fourHPButton.TabIndex = 7;
            this.fourHPButton.Tag = "4";
            this.fourHPButton.Text = "4 HP";
            this.fourHPButton.UseVisualStyleBackColor = false;
            this.fourHPButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // level1Button
            // 
            this.level1Button.BackColor = System.Drawing.Color.Gray;
            this.level1Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.level1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.level1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.level1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1Button.Location = new System.Drawing.Point(-140, 250);
            this.level1Button.Name = "level1Button";
            this.level1Button.Size = new System.Drawing.Size(174, 41);
            this.level1Button.TabIndex = 9;
            this.level1Button.Tag = "1";
            this.level1Button.Text = "Save Level 1";
            this.level1Button.UseVisualStyleBackColor = false;
            this.level1Button.Visible = false;
            this.level1Button.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // level2Button
            // 
            this.level2Button.BackColor = System.Drawing.Color.Gray;
            this.level2Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.level2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.level2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.level2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level2Button.Location = new System.Drawing.Point(-140, 320);
            this.level2Button.Name = "level2Button";
            this.level2Button.Size = new System.Drawing.Size(174, 41);
            this.level2Button.TabIndex = 10;
            this.level2Button.Tag = "2";
            this.level2Button.Text = "Save Level 2";
            this.level2Button.UseVisualStyleBackColor = false;
            this.level2Button.Visible = false;
            this.level2Button.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // level3Button
            // 
            this.level3Button.BackColor = System.Drawing.Color.Gray;
            this.level3Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.level3Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.level3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.level3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level3Button.Location = new System.Drawing.Point(-140, 390);
            this.level3Button.Name = "level3Button";
            this.level3Button.Size = new System.Drawing.Size(174, 41);
            this.level3Button.TabIndex = 11;
            this.level3Button.Tag = "3";
            this.level3Button.Text = "Save Level 3";
            this.level3Button.UseVisualStyleBackColor = false;
            this.level3Button.Visible = false;
            this.level3Button.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // level4Button
            // 
            this.level4Button.BackColor = System.Drawing.Color.Gray;
            this.level4Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.level4Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.level4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.level4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level4Button.Location = new System.Drawing.Point(-140, 460);
            this.level4Button.Name = "level4Button";
            this.level4Button.Size = new System.Drawing.Size(174, 41);
            this.level4Button.TabIndex = 12;
            this.level4Button.Tag = "4";
            this.level4Button.Text = "Save Level 4";
            this.level4Button.UseVisualStyleBackColor = false;
            this.level4Button.Visible = false;
            this.level4Button.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // level5Button
            // 
            this.level5Button.BackColor = System.Drawing.Color.Gray;
            this.level5Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.level5Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.level5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.level5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level5Button.Location = new System.Drawing.Point(-140, 530);
            this.level5Button.Name = "level5Button";
            this.level5Button.Size = new System.Drawing.Size(174, 41);
            this.level5Button.TabIndex = 13;
            this.level5Button.Tag = "5";
            this.level5Button.Text = "Save Level 5";
            this.level5Button.UseVisualStyleBackColor = false;
            this.level5Button.Visible = false;
            this.level5Button.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Lime;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Black;
            this.outputLabel.Location = new System.Drawing.Point(155, 594);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(295, 44);
            this.outputLabel.TabIndex = 14;
            this.outputLabel.Text = "Level 1 Saved";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputLabel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(22, 11);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(82, 34);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // LevelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.level5Button);
            this.Controls.Add(this.level4Button);
            this.Controls.Add(this.level3Button);
            this.Controls.Add(this.level2Button);
            this.Controls.Add(this.level1Button);
            this.Controls.Add(this.fourHPButton);
            this.Controls.Add(this.fiveHPButton);
            this.Controls.Add(this.threeHPButton);
            this.Controls.Add(this.twoHPButton);
            this.Controls.Add(this.oneHPButton);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "LevelEditor";
            this.Size = new System.Drawing.Size(600, 701);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LevelEditor_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LevelEditor_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LevelEditor_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button oneHPButton;
        private System.Windows.Forms.Button twoHPButton;
        private System.Windows.Forms.Button threeHPButton;
        private System.Windows.Forms.Button fiveHPButton;
        private System.Windows.Forms.Button fourHPButton;
        private System.Windows.Forms.Button level1Button;
        private System.Windows.Forms.Button level2Button;
        private System.Windows.Forms.Button level3Button;
        private System.Windows.Forms.Button level4Button;
        private System.Windows.Forms.Button level5Button;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button backButton;
    }
}
