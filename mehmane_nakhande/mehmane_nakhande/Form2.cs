using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace mehmane_nakhande
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }


        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbusers.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void pic_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Size screensize = Screen.PrimaryScreen.WorkingArea.Size;
            Location = new Point(screensize.Width / 2 - Width / 2, screensize.Height / 2 - Height / 2);
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            mainform mainform = new mainform();
            mainform.name = txtusername.Text;

            if (txtusername.Text == "" && txtpass.Text == "" && txtpassconfirm.Text == "")
            {
                MessageBox.Show("لطفا نام کاربری و پسورد را وارد کنید", "ثبت نام موفقیت آمیز نبود", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtpass.Text == txtpassconfirm.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + txtusername.Text + "','" + txtpass.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtusername.Text = "";
                txtpass.Text = "";
                txtpassconfirm.Text = "";

                MessageBox.Show("حساب شما با موفقیت ایجاد شد", "عملیات موفقیت آمیز بود", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                
                
                mainform.ShowDialog();
            }
            
            else
            {
                MessageBox.Show("گذرواژه های وارد شده باهم مطابقت ندارند", "ثبت نام موفقیت آمیز نبود" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Text = "";
                txtpassconfirm.Text = "";
                txtpass.Focus();
            }
        }

        private void checkshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkshowpass.Checked)
            {
                txtpass.PasswordChar = '\0';
                txtpassconfirm.PasswordChar = '\0';

            }
            else
            {
                txtpass.PasswordChar = '*';
                txtpassconfirm.PasswordChar = '*';
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpass.Text = "";
            txtpassconfirm.Text = "";
            txtusername.Focus();
        }

        private void lblreturn_Click(object sender, EventArgs e)
        {
            new loginform().Show();
            this.Hide();
        }
       
    }
}
