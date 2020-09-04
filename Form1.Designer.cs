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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbground = new System.Windows.Forms.PictureBox();
            this.pbplayer = new System.Windows.Forms.PictureBox();
            this.tmrGravity = new System.Windows.Forms.Timer(this.components);
            this.tmrup = new System.Windows.Forms.Timer(this.components);
            this.tmrRight = new System.Windows.Forms.Timer(this.components);
            this.tmrleft = new System.Windows.Forms.Timer(this.components);
            this.platform = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrGameloop = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbair = new System.Windows.Forms.PictureBox();
            this.sun = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sun)).BeginInit();
            this.SuspendLayout();
            // 
            // pbground
            // 
            this.pbground.BackColor = System.Drawing.SystemColors.Highlight;
            this.pbground.Location = new System.Drawing.Point(-53, 466);
            this.pbground.Name = "pbground";
            this.pbground.Size = new System.Drawing.Size(1036, 50);
            this.pbground.TabIndex = 0;
            this.pbground.TabStop = false;
            // 
            // pbplayer
            // 
            this.pbplayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbplayer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbplayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbplayer.BackgroundImage")));
            this.pbplayer.Location = new System.Drawing.Point(217, 425);
            this.pbplayer.Name = "pbplayer";
            this.pbplayer.Size = new System.Drawing.Size(38, 35);
            this.pbplayer.TabIndex = 1;
            this.pbplayer.TabStop = false;
            this.pbplayer.Click += new System.EventHandler(this.pbplayer_Click);
            // 
            // tmrGravity
            // 
            this.tmrGravity.Enabled = true;
            this.tmrGravity.Interval = 1;
            this.tmrGravity.Tick += new System.EventHandler(this.tmrGravity_Tick);
            // 
            // tmrup
            // 
            this.tmrup.Enabled = true;
            this.tmrup.Interval = 1;
            this.tmrup.Tick += new System.EventHandler(this.tmrup_Tick);
            // 
            // tmrRight
            // 
            this.tmrRight.Enabled = true;
            this.tmrRight.Interval = 1;
            this.tmrRight.Tick += new System.EventHandler(this.tmrright_Tick);
            // 
            // tmrleft
            // 
            this.tmrleft.Enabled = true;
            this.tmrleft.Interval = 1;
            this.tmrleft.Tick += new System.EventHandler(this.tmrleft_Tick);
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.SystemColors.Highlight;
            this.platform.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("platform.BackgroundImage")));
            this.platform.Location = new System.Drawing.Point(-29, 244);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(523, 20);
            this.platform.TabIndex = 2;
            this.platform.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblScore.Location = new System.Drawing.Point(10, 40);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(164, 25);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Marco Score:  0";
            // 
            // tmrGameloop
            // 
            this.tmrGameloop.Enabled = true;
            this.tmrGameloop.Interval = 1;
            this.tmrGameloop.Tick += new System.EventHandler(this.tmrGameloop_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Location = new System.Drawing.Point(967, -95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 589);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox2.Location = new System.Drawing.Point(-28, -63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 589);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.pauseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.FileHelp_clicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.FileExit_clicked);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem});
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pbair
            // 
            this.pbair.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbair.Location = new System.Drawing.Point(-29, 27);
            this.pbair.Name = "pbair";
            this.pbair.Size = new System.Drawing.Size(1043, 10);
            this.pbair.TabIndex = 7;
            this.pbair.TabStop = false;
            // 
            // sun
            // 
            this.sun.BackColor = System.Drawing.Color.White;
            this.sun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sun.BackgroundImage")));
            this.sun.ErrorImage = null;
            this.sun.InitialImage = null;
            this.sun.Location = new System.Drawing.Point(431, 40);
            this.sun.Name = "sun";
            this.sun.Size = new System.Drawing.Size(85, 200);
            this.sun.TabIndex = 8;
            this.sun.TabStop = false;
            this.sun.Tag = "Enemy1";
            this.sun.Click += new System.EventHandler(this.sun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tip 1 : move in all directions to escape the pull of the sun monster";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(333, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Up Down Left Right Keys to move. Up to Fly";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(974, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sun);
            this.Controls.Add(this.pbair);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.pbplayer);
            this.Controls.Add(this.pbground);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbground;
        private System.Windows.Forms.PictureBox pbplayer;
        private System.Windows.Forms.Timer tmrGravity;
        private System.Windows.Forms.Timer tmrup;
        private System.Windows.Forms.Timer tmrRight;
        private System.Windows.Forms.Timer tmrleft;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrGameloop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbair;
        private System.Windows.Forms.PictureBox sun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
    }
}

 