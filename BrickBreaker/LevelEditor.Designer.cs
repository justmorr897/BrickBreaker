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
            this.button1.Location = new System.Drawing.Point(243, 666);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oneHPButton
            // 
            this.oneHPButton.Location = new System.Drawing.Point(55, 642);
            this.oneHPButton.Name = "oneHPButton";
            this.oneHPButton.Size = new System.Drawing.Size(75, 23);
            this.oneHPButton.TabIndex = 1;
            this.oneHPButton.Text = "1 HP";
            this.oneHPButton.UseVisualStyleBackColor = true;
            this.oneHPButton.Click += new System.EventHandler(this.oneHPButton_Click);
            this.oneHPButton.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.oneHPButton_PreviewKeyDown);
            // 
            // twoHPButton
            // 
            this.twoHPButton.Location = new System.Drawing.Point(155, 642);
            this.twoHPButton.Name = "twoHPButton";
            this.twoHPButton.Size = new System.Drawing.Size(75, 23);
            this.twoHPButton.TabIndex = 2;
            this.twoHPButton.Text = "2 HP";
            this.twoHPButton.UseVisualStyleBackColor = true;
            this.twoHPButton.Click += new System.EventHandler(this.twoHPButton_Click);
            // 
            // threeHPButton
            // 
            this.threeHPButton.Location = new System.Drawing.Point(255, 642);
            this.threeHPButton.Name = "threeHPButton";
            this.threeHPButton.Size = new System.Drawing.Size(75, 23);
            this.threeHPButton.TabIndex = 3;
            this.threeHPButton.Text = "3 HP";
            this.threeHPButton.UseVisualStyleBackColor = true;
            this.threeHPButton.Click += new System.EventHandler(this.threeHPButton_Click);
            // 
            // fiveHPButton
            // 
            this.fiveHPButton.Location = new System.Drawing.Point(455, 642);
            this.fiveHPButton.Name = "fiveHPButton";
            this.fiveHPButton.Size = new System.Drawing.Size(75, 23);
            this.fiveHPButton.TabIndex = 4;
            this.fiveHPButton.Text = "5 HP";
            this.fiveHPButton.UseVisualStyleBackColor = true;
            this.fiveHPButton.Click += new System.EventHandler(this.fiveHPButton_Click);
            // 
            // fourHPButton
            // 
            this.fourHPButton.Location = new System.Drawing.Point(355, 642);
            this.fourHPButton.Name = "fourHPButton";
            this.fourHPButton.Size = new System.Drawing.Size(75, 23);
            this.fourHPButton.TabIndex = 7;
            this.fourHPButton.Text = "4 HP";
            this.fourHPButton.UseVisualStyleBackColor = true;
            this.fourHPButton.Click += new System.EventHandler(this.fourHPButton_Click);
            // 
            // LevelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.fourHPButton);
            this.Controls.Add(this.fiveHPButton);
            this.Controls.Add(this.threeHPButton);
            this.Controls.Add(this.twoHPButton);
            this.Controls.Add(this.oneHPButton);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LevelEditor";
            this.Size = new System.Drawing.Size(600, 700);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LevelEditor_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LevelEditor_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LevelEditor_MouseMove);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LevelEditor_PreviewKeyDown);
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
