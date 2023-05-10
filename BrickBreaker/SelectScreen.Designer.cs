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
            this.SuspendLayout();
            // 
            // usernameInput
            // 
            this.usernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(287, 218);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(4);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(245, 30);
            this.usernameInput.TabIndex = 0;
            this.usernameInput.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textBox1_PreviewKeyDown);
            // 
            // SaveButton1
            // 
            this.SaveButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton1.Location = new System.Drawing.Point(40, 554);
            this.SaveButton1.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton1.Name = "SaveButton1";
            this.SaveButton1.Size = new System.Drawing.Size(133, 246);
            this.SaveButton1.TabIndex = 2;
            this.SaveButton1.Text = "Save 1";
            this.SaveButton1.UseVisualStyleBackColor = true;
            this.SaveButton1.Click += new System.EventHandler(this.SaveButton1_Click);
            // 
            // SaveButton3
            // 
            this.SaveButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton3.Location = new System.Drawing.Point(333, 554);
            this.SaveButton3.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton3.Name = "SaveButton3";
            this.SaveButton3.Size = new System.Drawing.Size(133, 246);
            this.SaveButton3.TabIndex = 4;
            this.SaveButton3.Text = "Save 3";
            this.SaveButton3.UseVisualStyleBackColor = true;
            this.SaveButton3.Click += new System.EventHandler(this.SaveButton3_Click);
            // 
            // SaveButton4
            // 
            this.SaveButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton4.Location = new System.Drawing.Point(480, 554);
            this.SaveButton4.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton4.Name = "SaveButton4";
            this.SaveButton4.Size = new System.Drawing.Size(133, 246);
            this.SaveButton4.TabIndex = 5;
            this.SaveButton4.Text = "Save 4";
            this.SaveButton4.UseVisualStyleBackColor = true;
            this.SaveButton4.Click += new System.EventHandler(this.SaveButton4_Click);
            // 
            // SaveButton5
            // 
            this.SaveButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton5.Location = new System.Drawing.Point(627, 554);
            this.SaveButton5.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton5.Name = "SaveButton5";
            this.SaveButton5.Size = new System.Drawing.Size(133, 246);
            this.SaveButton5.TabIndex = 6;
            this.SaveButton5.Text = "Save 5";
            this.SaveButton5.UseVisualStyleBackColor = true;
            this.SaveButton5.Click += new System.EventHandler(this.SaveButton5_Click);
            // 
            // SaveButton2
            // 
            this.SaveButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton2.Location = new System.Drawing.Point(187, 554);
            this.SaveButton2.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton2.Name = "SaveButton2";
            this.SaveButton2.Size = new System.Drawing.Size(133, 246);
            this.SaveButton2.TabIndex = 3;
            this.SaveButton2.Text = "Save 2";
            this.SaveButton2.UseVisualStyleBackColor = true;
            this.SaveButton2.Click += new System.EventHandler(this.SaveButton2_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(287, 171);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(247, 43);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Enter A Username";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelsButton
            // 
            this.levelsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelsButton.Location = new System.Drawing.Point(40, 308);
            this.levelsButton.Margin = new System.Windows.Forms.Padding(4);
            this.levelsButton.Name = "levelsButton";
            this.levelsButton.Size = new System.Drawing.Size(720, 185);
            this.levelsButton.TabIndex = 1;
            this.levelsButton.Text = "Levels";
            this.levelsButton.UseVisualStyleBackColor = true;
            this.levelsButton.Click += new System.EventHandler(this.levelsButton_Click);
            // 
            // SelectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.Controls.Add(this.levelsButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.SaveButton2);
            this.Controls.Add(this.SaveButton5);
            this.Controls.Add(this.SaveButton4);
            this.Controls.Add(this.SaveButton3);
            this.Controls.Add(this.SaveButton1);
            this.Controls.Add(this.usernameInput);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectScreen";
            this.Size = new System.Drawing.Size(800, 862);
            this.Load += new System.EventHandler(this.SelectScreen_Load);
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
    }
}
