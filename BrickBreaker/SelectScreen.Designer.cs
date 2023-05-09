namespace BrickBreaker
{
    partial class SelectScreen
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
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.SaveButton1 = new System.Windows.Forms.Button();
            this.SaveButton3 = new System.Windows.Forms.Button();
            this.SaveButton4 = new System.Windows.Forms.Button();
            this.SaveButton5 = new System.Windows.Forms.Button();
            this.SaveButton2 = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.levelsButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(215, 177);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(185, 26);
            this.usernameInput.TabIndex = 0;
            this.usernameInput.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // SaveButton1
            // 
            this.SaveButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton1.Location = new System.Drawing.Point(30, 450);
            this.SaveButton1.Name = "SaveButton1";
            this.SaveButton1.Size = new System.Drawing.Size(100, 200);
            this.SaveButton1.TabIndex = 2;
            this.SaveButton1.Tag = "1";
            this.SaveButton1.Text = "Save 1";
            this.SaveButton1.UseVisualStyleBackColor = true;
            this.SaveButton1.Click += new System.EventHandler(this.SaveButton1_Click);
            // 
            // SaveButton3
            // 
            this.SaveButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton3.Location = new System.Drawing.Point(250, 450);
            this.SaveButton3.Name = "SaveButton3";
            this.SaveButton3.Size = new System.Drawing.Size(100, 200);
            this.SaveButton3.TabIndex = 4;
            this.SaveButton3.Tag = "3";
            this.SaveButton3.Text = "Save 3";
            this.SaveButton3.UseVisualStyleBackColor = true;
            this.SaveButton3.Click += new System.EventHandler(this.SaveButton1_Click);
            // 
            // SaveButton4
            // 
            this.SaveButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton4.Location = new System.Drawing.Point(360, 450);
            this.SaveButton4.Name = "SaveButton4";
            this.SaveButton4.Size = new System.Drawing.Size(100, 200);
            this.SaveButton4.TabIndex = 5;
            this.SaveButton4.Tag = "4";
            this.SaveButton4.Text = "Save 4";
            this.SaveButton4.UseVisualStyleBackColor = true;
            this.SaveButton4.Click += new System.EventHandler(this.SaveButton1_Click);
            // 
            // SaveButton5
            // 
            this.SaveButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton5.Location = new System.Drawing.Point(470, 450);
            this.SaveButton5.Name = "SaveButton5";
            this.SaveButton5.Size = new System.Drawing.Size(100, 200);
            this.SaveButton5.TabIndex = 6;
            this.SaveButton5.Tag = "5";
            this.SaveButton5.Text = "Save 5";
            this.SaveButton5.UseVisualStyleBackColor = true;
            this.SaveButton5.Click += new System.EventHandler(this.SaveButton1_Click);
            // 
            // SaveButton2
            // 
            this.SaveButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton2.Location = new System.Drawing.Point(140, 450);
            this.SaveButton2.Name = "SaveButton2";
            this.SaveButton2.Size = new System.Drawing.Size(100, 200);
            this.SaveButton2.TabIndex = 3;
            this.SaveButton2.Tag = "2";
            this.SaveButton2.Text = "Save 2";
            this.SaveButton2.UseVisualStyleBackColor = true;
            this.SaveButton2.Click += new System.EventHandler(this.SaveButton1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(215, 139);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(185, 35);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Username";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelsButton
            // 
            this.levelsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelsButton.Location = new System.Drawing.Point(30, 250);
            this.levelsButton.Name = "levelsButton";
            this.levelsButton.Size = new System.Drawing.Size(540, 150);
            this.levelsButton.TabIndex = 1;
            this.levelsButton.Text = "Levels";
            this.levelsButton.UseVisualStyleBackColor = true;
            this.levelsButton.Click += new System.EventHandler(this.levelsButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox1.Location = new System.Drawing.Point(406, 177);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(19, 26);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(163, 74);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(311, 65);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "Please Enter A Username";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(22, 11);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(82, 34);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BrickBreaker.Properties.Resources.Duck01;
            this.pictureBox1.Location = new System.Drawing.Point(42, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 100);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BrickBreaker.Properties.Resources.Duck01;
            this.pictureBox2.Location = new System.Drawing.Point(431, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(155, 100);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // SelectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.Background;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.levelsButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.SaveButton2);
            this.Controls.Add(this.SaveButton5);
            this.Controls.Add(this.SaveButton4);
            this.Controls.Add(this.SaveButton3);
            this.Controls.Add(this.SaveButton1);
            this.Controls.Add(this.usernameInput);
            this.DoubleBuffered = true;
            this.Name = "SelectScreen";
            this.Size = new System.Drawing.Size(600, 700);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Button SaveButton1;
        private System.Windows.Forms.Button SaveButton3;
        private System.Windows.Forms.Button SaveButton4;
        private System.Windows.Forms.Button SaveButton5;
        private System.Windows.Forms.Button SaveButton2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button levelsButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
