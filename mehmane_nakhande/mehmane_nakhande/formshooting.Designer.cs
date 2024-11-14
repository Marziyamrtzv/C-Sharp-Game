namespace mehmane_nakhande
{
    partial class formshooting
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblhelp1 = new System.Windows.Forms.Label();
            this.txtammo = new System.Windows.Forms.Label();
            this.txtcore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.healthbar = new System.Windows.Forms.ProgressBar();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblstart = new System.Windows.Forms.Label();
            this.lblrestart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("B Kamran", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "بازی خاموش کردن سیگار";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblhelp1
            // 
            this.lblhelp1.AutoSize = true;
            this.lblhelp1.BackColor = System.Drawing.Color.Black;
            this.lblhelp1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblhelp1.Font = new System.Drawing.Font("B Titr", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblhelp1.ForeColor = System.Drawing.Color.Yellow;
            this.lblhelp1.Location = new System.Drawing.Point(566, 5);
            this.lblhelp1.Name = "lblhelp1";
            this.lblhelp1.Size = new System.Drawing.Size(45, 51);
            this.lblhelp1.TabIndex = 20;
            this.lblhelp1.Text = "?";
            this.lblhelp1.Click += new System.EventHandler(this.lblhelp1_Click);
            this.lblhelp1.MouseHover += new System.EventHandler(this.lblhelp1_MouseHover);
            // 
            // txtammo
            // 
            this.txtammo.AutoSize = true;
            this.txtammo.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtammo.Location = new System.Drawing.Point(33, 71);
            this.txtammo.Name = "txtammo";
            this.txtammo.Size = new System.Drawing.Size(122, 33);
            this.txtammo.TabIndex = 21;
            this.txtammo.Text = "تعداد شلیک :۰";
            // 
            // txtcore
            // 
            this.txtcore.AutoSize = true;
            this.txtcore.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtcore.Location = new System.Drawing.Point(181, 73);
            this.txtcore.Name = "txtcore";
            this.txtcore.Size = new System.Drawing.Size(245, 33);
            this.txtcore.TabIndex = 22;
            this.txtcore.Text = "تعداد سیگار های خاموش شده:۰";
            this.txtcore.Click += new System.EventHandler(this.txtcore_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(444, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 33);
            this.label3.TabIndex = 23;
            this.label3.Text = "سلامتی:";
            // 
            // healthbar
            // 
            this.healthbar.Location = new System.Drawing.Point(526, 73);
            this.healthbar.Name = "healthbar";
            this.healthbar.Size = new System.Drawing.Size(192, 23);
            this.healthbar.TabIndex = 24;
            this.healthbar.Value = 100;
            // 
            // gametimer
            // 
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // player
            // 
            this.player.Image = global::mehmane_nakhande.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(322, 385);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 101);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 25;
            this.player.TabStop = false;
            this.player.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Black;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::mehmane_nakhande.Properties.Resources.red_24842_640;
            this.pictureBox7.Location = new System.Drawing.Point(682, 5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(48, 49);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "button";
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::mehmane_nakhande.Properties.Resources.Remove;
            this.pictureBox6.Location = new System.Drawing.Point(618, -2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(58, 58);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "button";
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // lblstart
            // 
            this.lblstart.BackColor = System.Drawing.Color.Turquoise;
            this.lblstart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblstart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblstart.Font = new System.Drawing.Font("B Kamran", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblstart.Location = new System.Drawing.Point(231, 217);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(287, 147);
            this.lblstart.TabIndex = 31;
            this.lblstart.Text = "شروع بازی";
            this.lblstart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblstart.Click += new System.EventHandler(this.lblstart_Click);
            // 
            // lblrestart
            // 
            this.lblrestart.BackColor = System.Drawing.Color.Turquoise;
            this.lblrestart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblrestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblrestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblrestart.Font = new System.Drawing.Font("B Kamran", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblrestart.Location = new System.Drawing.Point(231, 218);
            this.lblrestart.Name = "lblrestart";
            this.lblrestart.Size = new System.Drawing.Size(286, 146);
            this.lblrestart.TabIndex = 32;
            this.lblrestart.Text = "شروع مجدد";
            this.lblrestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblrestart.Visible = false;
            this.lblrestart.Click += new System.EventHandler(this.lblrestart_Click);
            // 
            // formshooting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(730, 542);
            this.Controls.Add(this.lblstart);
            this.Controls.Add(this.lblrestart);
            this.Controls.Add(this.healthbar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcore);
            this.Controls.Add(this.txtammo);
            this.Controls.Add(this.lblhelp1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formshooting";
            this.Text = "formshooting";
            this.Load += new System.EventHandler(this.formshooting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblhelp1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label txtammo;
        private System.Windows.Forms.Label txtcore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar healthbar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Label lblrestart;
    }
}