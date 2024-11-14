namespace mehmane_nakhande
{
    partial class loginform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            this.btnsubmit = new System.Windows.Forms.Button();
            this.lbltext = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblblack = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_minimize = new System.Windows.Forms.PictureBox();
            this.piclogin = new System.Windows.Forms.PictureBox();
            this.lblsignup = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.checkshowpass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsubmit
            // 
            this.btnsubmit.AutoSize = true;
            this.btnsubmit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubmit.Font = new System.Drawing.Font("B Kamran", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnsubmit.Location = new System.Drawing.Point(364, 314);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(90, 44);
            this.btnsubmit.TabIndex = 0;
            this.btnsubmit.Text = "ورود";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lbltext
            // 
            this.lbltext.BackColor = System.Drawing.Color.Transparent;
            this.lbltext.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbltext.Location = new System.Drawing.Point(531, 166);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(131, 40);
            this.lbltext.TabIndex = 2;
            this.lbltext.Text = ":نام کاربری";
            this.lbltext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(364, 170);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(186, 34);
            this.txtname.TabIndex = 3;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // lblblack
            // 
            this.lblblack.BackColor = System.Drawing.Color.Black;
            this.lblblack.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblblack.Location = new System.Drawing.Point(0, 0);
            this.lblblack.Name = "lblblack";
            this.lblblack.Size = new System.Drawing.Size(662, 52);
            this.lblblack.TabIndex = 4;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(364, 210);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(186, 34);
            this.txtpassword.TabIndex = 7;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(519, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = ":گذرواژه";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_close
            // 
            this.pic_close.BackColor = System.Drawing.Color.Black;
            this.pic_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(624, 5);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(38, 39);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_close.TabIndex = 5;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // pic_minimize
            // 
            this.pic_minimize.BackColor = System.Drawing.Color.Black;
            this.pic_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pic_minimize.Image")));
            this.pic_minimize.Location = new System.Drawing.Point(575, -1);
            this.pic_minimize.Name = "pic_minimize";
            this.pic_minimize.Size = new System.Drawing.Size(49, 49);
            this.pic_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_minimize.TabIndex = 5;
            this.pic_minimize.TabStop = false;
            this.pic_minimize.Click += new System.EventHandler(this.pic_minimize_Click);
            // 
            // piclogin
            // 
            this.piclogin.Image = ((System.Drawing.Image)(resources.GetObject("piclogin.Image")));
            this.piclogin.Location = new System.Drawing.Point(12, 94);
            this.piclogin.Name = "piclogin";
            this.piclogin.Size = new System.Drawing.Size(329, 363);
            this.piclogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogin.TabIndex = 1;
            this.piclogin.TabStop = false;
            // 
            // lblsignup
            // 
            this.lblsignup.AutoSize = true;
            this.lblsignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblsignup.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblsignup.ForeColor = System.Drawing.Color.Navy;
            this.lblsignup.Location = new System.Drawing.Point(390, 421);
            this.lblsignup.Name = "lblsignup";
            this.lblsignup.Size = new System.Drawing.Size(160, 33);
            this.lblsignup.TabIndex = 23;
            this.lblsignup.Text = "ایجاد حساب کاربری";
            this.lblsignup.Click += new System.EventHandler(this.lblsignup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 10.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(412, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "حساب کاربری ندارم";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("B Kamran", 18F, System.Drawing.FontStyle.Bold);
            this.btnclear.Location = new System.Drawing.Point(460, 314);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(90, 44);
            this.btnclear.TabIndex = 21;
            this.btnclear.Text = "پاک کردن";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // checkshowpass
            // 
            this.checkshowpass.AutoSize = true;
            this.checkshowpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkshowpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkshowpass.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.checkshowpass.Location = new System.Drawing.Point(447, 250);
            this.checkshowpass.Name = "checkshowpass";
            this.checkshowpass.Size = new System.Drawing.Size(108, 30);
            this.checkshowpass.TabIndex = 20;
            this.checkshowpass.Text = "نمایش گذرواژه";
            this.checkshowpass.UseVisualStyleBackColor = true;
            this.checkshowpass.CheckedChanged += new System.EventHandler(this.checkshowpass_CheckedChanged);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(662, 487);
            this.Controls.Add(this.lblsignup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.checkshowpass);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.pic_minimize);
            this.Controls.Add(this.lblblack);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.piclogin);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.lbltext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginform";
            this.Text = "ورود";
            this.Load += new System.EventHandler(this.loginform_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginform_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginform_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginform_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.PictureBox piclogin;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Label lblblack;
        private System.Windows.Forms.PictureBox pic_minimize;
        private System.Windows.Forms.PictureBox pic_close;
        public System.Windows.Forms.TextBox txtname;
        public System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsignup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.CheckBox checkshowpass;
    }
}

