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
            this.tmrup = new System.Windows.Forms.Timer(this.components);
            this.tmrRight = new System.Windows.Forms.Timer(this.components);
            this.tmrleft = new System.Windows.Forms.Timer(this.components);
            this.platform = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            this.SuspendLayout();
            // 
            // pbground
            // 
            this.pbground.BackColor = System.Drawing.SystemColors.Highlight;
            this.pbground.Location = new System.Drawing.Point(-53, 466);
            this.pbground.Name = "pbground";
            this.pbground.Size = new System.Drawing.Size(1036, 24);
            this.pbground.TabIndex = 0;
            this.pbground.TabStop = false;
            // 
            // pbplayer
            // 
            this.pbplayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbplayer.ErrorImage = global::PlatformerHome.Properties.Resources.alien;
            this.pbplayer.InitialImage = global::PlatformerHome.Properties.Resources.alien;
            this.pbplayer.Location = new System.Drawing.Point(265, 184);
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
            // tmrup
            // 
            this.tmrup.Enabled = true;
            this.tmrup.Interval = 10;
            this.tmrup.Tick += new System.EventHandler(this.tmrup_Tick);
            // 
            // tmrRight
            // 
            this.tmrRight.Enabled = true;
            this.tmrRight.Interval = 10;
            this.tmrRight.Tick += new System.EventHandler(this.tmrright_Tick);
            // 
            // tmrleft
            // 
            this.tmrleft.Enabled = true;
            this.tmrleft.Interval = 10;
            this.tmrleft.Tick += new System.EventHandler(this.tmrleft_Tick);
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.SystemColors.Highlight;
            this.platform.Location = new System.Drawing.Point(114, 244);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(475, 20);
            this.platform.TabIndex = 2;
            this.platform.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(957, 502);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.pbplayer);
            this.Controls.Add(this.pbground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbground;
        private System.Windows.Forms.PictureBox pbplayer;
        private System.Windows.Forms.Timer tmrGravity;
        private System.Windows.Forms.Timer tmrup;
        private System.Windows.Forms.Timer tmrRight;
        private System.Windows.Forms.Timer tmrleft;
        private System.Windows.Forms.PictureBox platform;
    }
}

