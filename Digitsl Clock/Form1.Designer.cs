namespace Digitsl_Clock
{
    partial class display
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(display));
            this.frame = new System.Windows.Forms.Panel();
            this.day = new System.Windows.Forms.Label();
            this.period = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.frame.SuspendLayout();
            this.SuspendLayout();
            // 
            // frame
            // 
            this.frame.BackColor = System.Drawing.Color.Black;
            this.frame.Controls.Add(this.day);
            this.frame.Controls.Add(this.period);
            this.frame.Controls.Add(this.date);
            this.frame.Controls.Add(this.time);
            this.frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frame.Location = new System.Drawing.Point(0, 0);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(988, 614);
            this.frame.TabIndex = 2;
            // 
            // day
            // 
            this.day.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.day.BackColor = System.Drawing.Color.Transparent;
            this.day.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(226)))), ((int)(((byte)(254)))));
            this.day.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.day.Location = new System.Drawing.Point(248, 543);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(493, 60);
            this.day.TabIndex = 3;
            this.day.Text = "wednesday";
            this.day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // period
            // 
            this.period.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.period.AutoSize = true;
            this.period.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.period.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.period.Location = new System.Drawing.Point(849, 273);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(120, 69);
            this.period.TabIndex = 1;
            this.period.Text = "AM";
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(226)))), ((int)(((byte)(254)))));
            this.date.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.date.Location = new System.Drawing.Point(248, 448);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(493, 102);
            this.date.TabIndex = 2;
            this.date.Text = "31/12/2000";
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F);
            this.time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(226)))), ((int)(((byte)(254)))));
            this.time.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.time.Location = new System.Drawing.Point(145, 217);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(699, 181);
            this.time.TabIndex = 0;
            this.time.Text = "00:00:00";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(988, 614);
            this.Controls.Add(this.frame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "display";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.display_Load);
            this.Resize += new System.EventHandler(this.display_Resize);
            this.frame.ResumeLayout(false);
            this.frame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel frame;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label period;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label day;
    }
}

