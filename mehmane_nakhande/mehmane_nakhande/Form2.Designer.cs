namespace mehmane_nakhande
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.pic_minimize = new System.Windows.Forms.PictureBox();
            this.lblblack = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassconfirm = new System.Windows.Forms.TextBox();
            this.checkshowpass = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblreturn = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_close
            // 
            this.pic_close.BackColor = System.Drawing.Color.Black;
            this.pic_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(621, 5);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(38, 39);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_close.TabIndex = 6;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // pic_minimize
            // 
            this.pic_minimize.BackColor = System.Drawing.Color.Black;
            this.pic_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pic_minimize.Image")));
            this.pic_minimize.Location = new System.Drawing.Point(565, -1);
            this.pic_minimize.Name = "pic_minimize";
            this.pic_minimize.Size = new System.Drawing.Size(49, 49);
            this.pic_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_minimize.TabIndex = 7;
            this.pic_minimize.TabStop = false;
            this.pic_minimize.Click += new System.EventHandler(this.pic_minimize_Click);
            // 
            // lblblack
            // 
            this.lblblack.BackColor = System.Drawing.Color.Black;
            this.lblblack.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblblack.Location = new System.Drawing.Point(0, 0);
            this.lblblack.Name = "lblblack";
            this.lblblack.Size = new System.Drawing.Size(662, 52);
            this.lblblack.TabIndex = 8;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(242, 98);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(184, 34);
            this.txtusername.TabIndex = 9;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(338, 62);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "نام کاربری:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(357, 144);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(75, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "گذرواژه:";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(242, 180);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(184, 34);
            this.txtpass.TabIndex = 11;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(314, 226);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(118, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "تکرار گذرواژه:";
            // 
            // txtpassconfirm
            // 
            this.txtpassconfirm.Location = new System.Drawing.Point(242, 262);
            this.txtpassconfirm.Multiline = true;
            this.txtpassconfirm.Name = "txtpassconfirm";
            this.txtpassconfirm.PasswordChar = '*';
            this.txtpassconfirm.Size = new System.Drawing.Size(184, 34);
            this.txtpassconfirm.TabIndex = 13;
            this.txtpassconfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkshowpass
            // 
            this.checkshowpass.AutoSize = true;
            this.checkshowpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkshowpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkshowpass.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.checkshowpass.Location = new System.Drawing.Point(324, 302);
            this.checkshowpass.Name = "checkshowpass";
            this.checkshowpass.Size = new System.Drawing.Size(108, 30);
            this.checkshowpass.TabIndex = 15;
            this.checkshowpass.Text = "نمایش گذرواژه";
            this.checkshowpass.UseVisualStyleBackColor = true;
            this.checkshowpass.CheckedChanged += new System.EventHandler(this.checkshowpass_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 10.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(264, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "از قبل حساب کاربری دارم";
            // 
            // lblreturn
            // 
            this.lblreturn.AutoSize = true;
            this.lblreturn.BackColor = System.Drawing.Color.Transparent;
            this.lblreturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblreturn.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblreturn.ForeColor = System.Drawing.Color.Navy;
            this.lblreturn.Location = new System.Drawing.Point(239, 438);
            this.lblreturn.Name = "lblreturn";
            this.lblreturn.Size = new System.Drawing.Size(194, 33);
            this.lblreturn.TabIndex = 19;
            this.lblreturn.Text = "برگشت به صفحه ی ورود";
            this.lblreturn.Click += new System.EventHandler(this.lblreturn_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("B Kamran", 18F, System.Drawing.FontStyle.Bold);
            this.btnclear.Location = new System.Drawing.Point(338, 352);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(90, 44);
            this.btnclear.TabIndex = 23;
            this.btnclear.Text = "پاک کردن";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.AutoSize = true;
            this.btnsubmit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubmit.Font = new System.Drawing.Font("B Kamran", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnsubmit.Location = new System.Drawing.Point(242, 352);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(90, 44);
            this.btnsubmit.TabIndex = 22;
            this.btnsubmit.Text = "ثبت نام";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(442, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-12, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(239, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(662, 487);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.lblreturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkshowpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpassconfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.pic_minimize);
            this.Controls.Add(this.lblblack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.PictureBox pic_minimize;
        private System.Windows.Forms.Label lblblack;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassconfirm;
        private System.Windows.Forms.CheckBox checkshowpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblreturn;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}