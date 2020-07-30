namespace PlatformerHome
{
    partial class Form1
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
            this.pbground = new System.Windows.Forms.PictureBox();
            this.pbplayer = new System.Windows.Forms.PictureBox();
            this.tmrGravity = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbground
            // 
            this.pbground.BackColor = System.Drawing.SystemColors.Highlight;
            this.pbground.Location = new System.Drawing.Point(-51, 440);
            this.pbground.Name = "pbground";
            this.pbground.Size = new System.Drawing.Size(589, 24);
            this.pbground.TabIndex = 0;
            this.pbground.TabStop = false;
            // 
            // pbplayer
            // 
            this.pbplayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbplayer.Location = new System.Drawing.Point(144, 86);
            this.pbplayer.Name = "pbplayer";
            this.pbplayer.Size = new System.Drawing.Size(49, 54);
            this.pbplayer.TabIndex = 1;
            this.pbplayer.TabStop = false;
            // 
            // tmrGravity
            // 
            this.tmrGravity.Enabled = true;
            this.tmrGravity.Interval = 10;
            this.tmrGravity.Tick += new System.EventHandler(this.tmrGravity_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(415, 462);
            this.Controls.Add(this.pbplayer);
            this.Controls.Add(this.pbground);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbplayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbground;
        private System.Windows.Forms.PictureBox pbplayer;
        private System.Windows.Forms.Timer tmrGravity;
    }
}

