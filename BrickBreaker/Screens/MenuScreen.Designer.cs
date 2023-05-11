namespace BrickBreaker
{
    partial class MenuScreen
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
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.editorButton = new System.Windows.Forms.Button();
            this.leaderboardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = global::BrickBreaker.Properties.Resources.Sign;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Chiller", 140.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Black;
            this.playButton.Location = new System.Drawing.Point(3, -149);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(594, 507);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "\r\nPlay";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = global::BrickBreaker.Properties.Resources.Exit_Sign;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(379, 473);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(250, 250);
            this.exitButton.TabIndex = 1;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // editorButton
            // 
            this.editorButton.BackColor = System.Drawing.Color.Transparent;
            this.editorButton.BackgroundImage = global::BrickBreaker.Properties.Resources.Sign;
            this.editorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editorButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editorButton.FlatAppearance.BorderSize = 0;
            this.editorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editorButton.Font = new System.Drawing.Font("Chiller", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorButton.ForeColor = System.Drawing.Color.Black;
            this.editorButton.Location = new System.Drawing.Point(98, 324);
            this.editorButton.Margin = new System.Windows.Forms.Padding(5);
            this.editorButton.Name = "editorButton";
            this.editorButton.Size = new System.Drawing.Size(389, 178);
            this.editorButton.TabIndex = 2;
            this.editorButton.Text = "\r\nLevel Editor";
            this.editorButton.UseVisualStyleBackColor = false;
            this.editorButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // leaderboardButton
            // 
            this.leaderboardButton.BackColor = System.Drawing.Color.Transparent;
            this.leaderboardButton.BackgroundImage = global::BrickBreaker.Properties.Resources.Sign;
            this.leaderboardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leaderboardButton.FlatAppearance.BorderSize = 0;
            this.leaderboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.leaderboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.leaderboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaderboardButton.Font = new System.Drawing.Font("Chiller", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboardButton.ForeColor = System.Drawing.Color.Black;
            this.leaderboardButton.Location = new System.Drawing.Point(178, 0);
            this.leaderboardButton.Name = "leaderboardButton";
            this.leaderboardButton.Size = new System.Drawing.Size(227, 103);
            this.leaderboardButton.TabIndex = 3;
            this.leaderboardButton.Text = "\r\nLeaderboard";
            this.leaderboardButton.UseVisualStyleBackColor = false;
            this.leaderboardButton.Click += new System.EventHandler(this.leaderboardButton_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.leaderboardButton);
            this.Controls.Add(this.editorButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.DoubleBuffered = true;
            this.Name = "MenuScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(600, 700);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button editorButton;
        private System.Windows.Forms.Button leaderboardButton;
    }
}
