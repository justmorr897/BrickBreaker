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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leaderboard";
            // 
            // nameLabelColumn
            // 
            this.nameLabelColumn.BackColor = System.Drawing.Color.White;
            this.nameLabelColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabelColumn.Location = new System.Drawing.Point(120, 174);
            this.nameLabelColumn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabelColumn.Name = "nameLabelColumn";
            this.nameLabelColumn.Size = new System.Drawing.Size(177, 530);
            this.nameLabelColumn.TabIndex = 1;
            this.nameLabelColumn.Text = "Names:";
            this.nameLabelColumn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreLabelColumn
            // 
            this.scoreLabelColumn.BackColor = System.Drawing.Color.White;
            this.scoreLabelColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabelColumn.Location = new System.Drawing.Point(419, 174);
            this.scoreLabelColumn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreLabelColumn.Name = "scoreLabelColumn";
            this.scoreLabelColumn.Size = new System.Drawing.Size(175, 530);
            this.scoreLabelColumn.TabIndex = 2;
            this.scoreLabelColumn.Text = "Score:";
            this.scoreLabelColumn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(30, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(110, 42);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.scoreLabelColumn);
            this.Controls.Add(this.nameLabelColumn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Leaderboard";
            this.Size = new System.Drawing.Size(800, 862);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabelColumn;
        private System.Windows.Forms.Label scoreLabelColumn;
        private System.Windows.Forms.Button backButton;
    }
}
