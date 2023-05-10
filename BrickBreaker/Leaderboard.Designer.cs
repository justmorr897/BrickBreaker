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
            this.scoreLabelBorder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leaderboard";
            // 
            // nameLabelColumn
            // 
            this.nameLabelColumn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameLabelColumn.Font = new System.Drawing.Font("Vox Round Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabelColumn.ForeColor = System.Drawing.Color.Maroon;
            this.nameLabelColumn.Location = new System.Drawing.Point(100, 150);
            this.nameLabelColumn.Name = "nameLabelColumn";
            this.nameLabelColumn.Size = new System.Drawing.Size(150, 450);
            this.nameLabelColumn.TabIndex = 1;
            this.nameLabelColumn.Text = "Names:";
            this.nameLabelColumn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreLabelColumn
            // 
            this.scoreLabelColumn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.scoreLabelColumn.Font = new System.Drawing.Font("Vox Round Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabelColumn.ForeColor = System.Drawing.Color.Maroon;
            this.scoreLabelColumn.Location = new System.Drawing.Point(350, 150);
            this.scoreLabelColumn.Name = "scoreLabelColumn";
            this.scoreLabelColumn.Size = new System.Drawing.Size(150, 450);
            this.scoreLabelColumn.TabIndex = 2;
            this.scoreLabelColumn.Text = "Score:";
            this.scoreLabelColumn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreLabelBorder
            // 
            this.scoreLabelBorder.BackColor = System.Drawing.Color.Maroon;
            this.scoreLabelBorder.Location = new System.Drawing.Point(95, 120);
            this.scoreLabelBorder.Name = "scoreLabelBorder";
            this.scoreLabelBorder.Size = new System.Drawing.Size(160, 485);
            this.scoreLabelBorder.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(345, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 485);
            this.label2.TabIndex = 4;
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.Background;
            this.Controls.Add(this.scoreLabelColumn);
            this.Controls.Add(this.nameLabelColumn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreLabelBorder);
            this.Controls.Add(this.label2);
            this.Name = "Leaderboard";
            this.Size = new System.Drawing.Size(600, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabelColumn;
        private System.Windows.Forms.Label scoreLabelColumn;
        private System.Windows.Forms.Label scoreLabelBorder;
        private System.Windows.Forms.Label label2;
    }
}
