namespace BrickBreaker
{
    partial class Leaderboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabelColumn = new System.Windows.Forms.Label();
            this.scoreLabelColumn = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.timeLabelColumn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.tryAgainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "       Leaderboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabelColumn
            // 
            this.nameLabelColumn.BackColor = System.Drawing.Color.Transparent;
            this.nameLabelColumn.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabelColumn.Location = new System.Drawing.Point(84, 138);
            this.nameLabelColumn.Name = "nameLabelColumn";
            this.nameLabelColumn.Size = new System.Drawing.Size(156, 30);
            this.nameLabelColumn.TabIndex = 1;
            this.nameLabelColumn.Text = "Justin";
            this.nameLabelColumn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreLabelColumn
            // 
            this.scoreLabelColumn.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabelColumn.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabelColumn.Location = new System.Drawing.Point(273, 138);
            this.scoreLabelColumn.Name = "scoreLabelColumn";
            this.scoreLabelColumn.Size = new System.Drawing.Size(131, 30);
            this.scoreLabelColumn.TabIndex = 2;
            this.scoreLabelColumn.Text = "Score:\r\n";
            this.scoreLabelColumn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(22, 18);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(82, 34);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // timeLabelColumn
            // 
            this.timeLabelColumn.BackColor = System.Drawing.Color.Transparent;
            this.timeLabelColumn.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabelColumn.Location = new System.Drawing.Point(450, 138);
            this.timeLabelColumn.Name = "timeLabelColumn";
            this.timeLabelColumn.Size = new System.Drawing.Size(131, 30);
            this.timeLabelColumn.TabIndex = 11;
            this.timeLabelColumn.Text = "Time:\r\n";
            this.timeLabelColumn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(239, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 55);
            this.button1.TabIndex = 12;
            this.button1.Text = "Clear Scores";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(22, 258);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(578, 48);
            this.outputLabel.TabIndex = 13;
            this.outputLabel.Text = "Levels Cleared";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputLabel.Visible = false;
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.Color.LightBlue;
            this.yesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.yesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesButton.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.Location = new System.Drawing.Point(315, 391);
            this.yesButton.Margin = new System.Windows.Forms.Padding(2);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(142, 55);
            this.yesButton.TabIndex = 14;
            this.yesButton.Text = "yes";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Visible = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.Color.LightBlue;
            this.noButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.noButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noButton.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.Location = new System.Drawing.Point(169, 391);
            this.noButton.Margin = new System.Windows.Forms.Padding(2);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(142, 55);
            this.noButton.TabIndex = 15;
            this.noButton.Text = "no";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Visible = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // tryAgainLabel
            // 
            this.tryAgainLabel.BackColor = System.Drawing.Color.Transparent;
            this.tryAgainLabel.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryAgainLabel.Location = new System.Drawing.Point(169, 335);
            this.tryAgainLabel.Name = "tryAgainLabel";
            this.tryAgainLabel.Size = new System.Drawing.Size(288, 30);
            this.tryAgainLabel.TabIndex = 16;
            this.tryAgainLabel.Text = "Try Again?";
            this.tryAgainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tryAgainLabel.Visible = false;
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.Background;
            this.Controls.Add(this.tryAgainLabel);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeLabelColumn);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.scoreLabelColumn);
            this.Controls.Add(this.nameLabelColumn);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Leaderboard";
            this.Size = new System.Drawing.Size(600, 700);
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabelColumn;
        private System.Windows.Forms.Label scoreLabelColumn;

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label timeLabelColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label tryAgainLabel;
    }
}
