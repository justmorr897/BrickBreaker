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
            this.button1 = new System.Windows.Forms.Button();
            this.oneHPButton = new System.Windows.Forms.Button();
            this.twoHPButton = new System.Windows.Forms.Button();
            this.threeHPButton = new System.Windows.Forms.Button();
            this.fiveHPButton = new System.Windows.Forms.Button();
            this.fourHPButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 934);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oneHPButton
            // 
            this.oneHPButton.Location = new System.Drawing.Point(82, 988);
            this.oneHPButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oneHPButton.Name = "oneHPButton";
            this.oneHPButton.Size = new System.Drawing.Size(112, 35);
            this.oneHPButton.TabIndex = 1;
            this.oneHPButton.Text = "1 HP";
            this.oneHPButton.UseVisualStyleBackColor = true;
            this.oneHPButton.Click += new System.EventHandler(this.oneHPButton_Click);
            // 
            // twoHPButton
            // 
            this.twoHPButton.Location = new System.Drawing.Point(232, 988);
            this.twoHPButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.twoHPButton.Name = "twoHPButton";
            this.twoHPButton.Size = new System.Drawing.Size(112, 35);
            this.twoHPButton.TabIndex = 2;
            this.twoHPButton.Text = "2 HP";
            this.twoHPButton.UseVisualStyleBackColor = true;
            this.twoHPButton.Click += new System.EventHandler(this.twoHPButton_Click);
            // 
            // threeHPButton
            // 
            this.threeHPButton.Location = new System.Drawing.Point(382, 988);
            this.threeHPButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.threeHPButton.Name = "threeHPButton";
            this.threeHPButton.Size = new System.Drawing.Size(112, 35);
            this.threeHPButton.TabIndex = 3;
            this.threeHPButton.Text = "3 HP";
            this.threeHPButton.UseVisualStyleBackColor = true;
            this.threeHPButton.Click += new System.EventHandler(this.threeHPButton_Click);
            // 
            // fiveHPButton
            // 
            this.fiveHPButton.Location = new System.Drawing.Point(682, 988);
            this.fiveHPButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fiveHPButton.Name = "fiveHPButton";
            this.fiveHPButton.Size = new System.Drawing.Size(112, 35);
            this.fiveHPButton.TabIndex = 4;
            this.fiveHPButton.Text = "5 HP";
            this.fiveHPButton.UseVisualStyleBackColor = true;
            this.fiveHPButton.Click += new System.EventHandler(this.fiveHPButton_Click);
            // 
            // fourHPButton
            // 
            this.fourHPButton.Location = new System.Drawing.Point(532, 988);
            this.fourHPButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fourHPButton.Name = "fourHPButton";
            this.fourHPButton.Size = new System.Drawing.Size(112, 35);
            this.fourHPButton.TabIndex = 7;
            this.fourHPButton.Text = "4 HP";
            this.fourHPButton.UseVisualStyleBackColor = true;
            this.fourHPButton.Click += new System.EventHandler(this.fourHPButton_Click);
            // 
            // LevelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.fourHPButton);
            this.Controls.Add(this.fiveHPButton);
            this.Controls.Add(this.threeHPButton);
            this.Controls.Add(this.twoHPButton);
            this.Controls.Add(this.oneHPButton);
            this.Controls.Add(this.button1);
            this.Name = "LevelEditor";
            this.Size = new System.Drawing.Size(900, 1077);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LevelEditor_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LevelEditor_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LevelEditor_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button oneHPButton;
        private System.Windows.Forms.Button twoHPButton;
        private System.Windows.Forms.Button threeHPButton;
        private System.Windows.Forms.Button fiveHPButton;
        private System.Windows.Forms.Button fourHPButton;
    }
}
