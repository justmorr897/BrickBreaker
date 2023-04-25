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
            this.paddlePicture = new System.Windows.Forms.PictureBox();
            this.ballPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.paddlePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // paddlePicture
            // 
            this.paddlePicture.BackColor = System.Drawing.Color.Transparent;
            this.paddlePicture.BackgroundImage = global::BrickBreaker.Properties.Resources.Paddle;
            this.paddlePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paddlePicture.Location = new System.Drawing.Point(248, 467);
            this.paddlePicture.Name = "paddlePicture";
            this.paddlePicture.Size = new System.Drawing.Size(100, 50);
            this.paddlePicture.TabIndex = 0;
            this.paddlePicture.TabStop = false;
            // 
            // ballPicture
            // 
            this.ballPicture.BackColor = System.Drawing.Color.Transparent;
            this.ballPicture.BackgroundImage = global::BrickBreaker.Properties.Resources.Ball;
            this.ballPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ballPicture.Location = new System.Drawing.Point(248, 333);
            this.ballPicture.Name = "ballPicture";
            this.ballPicture.Size = new System.Drawing.Size(100, 50);
            this.ballPicture.TabIndex = 1;
            this.ballPicture.TabStop = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.ballPicture);
            this.Controls.Add(this.paddlePicture);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(600, 700);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.paddlePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox paddlePicture;
        private System.Windows.Forms.PictureBox ballPicture;
    }
}
