namespace BrickBreaker
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.livesLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.pauseLivesLabel = new System.Windows.Forms.Label();
            this.pauseScoreLabel = new System.Windows.Forms.Label();
            this.powerupLabel = new System.Windows.Forms.Label();
            this.levelPauseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // livesLabel
            // 
            this.livesLabel.BackColor = System.Drawing.Color.Transparent;
            this.livesLabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLabel.ForeColor = System.Drawing.Color.Black;
            this.livesLabel.Location = new System.Drawing.Point(3, 0);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(155, 34);
            this.livesLabel.TabIndex = 0;
            this.livesLabel.Text = "Lives: 1";
            this.livesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Black;
            this.scoreLabel.Location = new System.Drawing.Point(439, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(161, 34);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score: 1";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pauseLabel
            // 
            this.pauseLabel.BackColor = System.Drawing.Color.Gray;
            this.pauseLabel.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseLabel.Location = new System.Drawing.Point(186, 203);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(219, 277);
            this.pauseLabel.TabIndex = 3;
            this.pauseLabel.Text = "\r\nPaused";
            this.pauseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pauseLabel.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(220, 386);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(152, 42);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pauseLivesLabel
            // 
            this.pauseLivesLabel.BackColor = System.Drawing.Color.DimGray;
            this.pauseLivesLabel.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseLivesLabel.ForeColor = System.Drawing.Color.Black;
            this.pauseLivesLabel.Location = new System.Drawing.Point(237, 273);
            this.pauseLivesLabel.Name = "pauseLivesLabel";
            this.pauseLivesLabel.Size = new System.Drawing.Size(116, 34);
            this.pauseLivesLabel.TabIndex = 6;
            this.pauseLivesLabel.Text = "Score: 1";
            this.pauseLivesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pauseLivesLabel.Visible = false;
            // 
            // pauseScoreLabel
            // 
            this.pauseScoreLabel.BackColor = System.Drawing.Color.DimGray;
            this.pauseScoreLabel.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.pauseScoreLabel.Location = new System.Drawing.Point(237, 325);
            this.pauseScoreLabel.Name = "pauseScoreLabel";
            this.pauseScoreLabel.Size = new System.Drawing.Size(116, 34);
            this.pauseScoreLabel.TabIndex = 7;
            this.pauseScoreLabel.Text = "Score: 1";
            this.pauseScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pauseScoreLabel.Visible = false;
            // 
            // powerupLabel
            // 
            this.powerupLabel.BackColor = System.Drawing.Color.Transparent;
            this.powerupLabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerupLabel.ForeColor = System.Drawing.Color.White;
            this.powerupLabel.Location = new System.Drawing.Point(0, 670);
            this.powerupLabel.Name = "powerupLabel";
            this.powerupLabel.Size = new System.Drawing.Size(600, 23);
            this.powerupLabel.TabIndex = 9;
            this.powerupLabel.Text = "Instructions";
            this.powerupLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.powerupLabel.Visible = false;
            // 
            // levelPauseLabel
            // 
            this.levelPauseLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelPauseLabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelPauseLabel.ForeColor = System.Drawing.Color.Black;
            this.levelPauseLabel.Location = new System.Drawing.Point(190, 0);
            this.levelPauseLabel.Name = "levelPauseLabel";
            this.levelPauseLabel.Size = new System.Drawing.Size(215, 34);
            this.levelPauseLabel.TabIndex = 8;
            this.levelPauseLabel.Text = "Pause";
            this.levelPauseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.levelPauseLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.powerupLabel);
            this.Controls.Add(this.levelPauseLabel);
            this.Controls.Add(this.pauseScoreLabel);
            this.Controls.Add(this.pauseLivesLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pauseLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.livesLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(600, 700);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameScreen_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameScreen_MouseMove);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label pauseLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label pauseLivesLabel;
        private System.Windows.Forms.Label pauseScoreLabel;
        private System.Windows.Forms.Label powerupLabel;
        private System.Windows.Forms.Label levelPauseLabel;
    }
}
