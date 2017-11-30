namespace TilePicker
{
    partial class TilePicker
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblScore = new System.Windows.Forms.Label();
            this.lblClicks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 373);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(127, 23);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score : 0";
            this.lblScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblClicks
            // 
            this.lblClicks.AutoSize = true;
            this.lblClicks.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClicks.Location = new System.Drawing.Point(12, 396);
            this.lblClicks.Name = "lblClicks";
            this.lblClicks.Size = new System.Drawing.Size(218, 23);
            this.lblClicks.TabIndex = 1;
            this.lblClicks.Text = "Clicks Left : 10";
            // 
            // TilePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(323, 423);
            this.Controls.Add(this.lblClicks);
            this.Controls.Add(this.lblScore);
            this.Name = "TilePicker";
            this.Text = "TilePicker";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TilePicker_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TilePicker_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblClicks;
    }
}

