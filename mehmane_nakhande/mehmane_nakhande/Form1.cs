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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbusers.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private bool mousedown;
        private Point lastlocation;

        private void pic_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username='" + txtname.Text + "' and password='" + txtpassword.Text + "' ";
            cmd = new OleDbCommand(login,con);
            OleDbDataReader dr = cmd.ExecuteReader();


            if (dr.Read() == true)
            {
                this.Hide();
                mainform mainform = new mainform();
                mainform.name = txtname.Text;
                mainform.ShowDialog();

            }

            else
            {
                MessageBox.Show("نام کاربری یا گذرواژه شما نا معتبر است", "عملیات موفقیت آمیز نبود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Text = "";
                txtpassword.Text = "";
                txtname.Focus();
            
            }
            
            
            
           
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            Size screensize = Screen.PrimaryScreen.WorkingArea.Size;
            Location = new Point(screensize.Width / 2 - Width / 2, screensize.Height / 2 - Height / 2);
        }

        private void loginform_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            lastlocation = e.Location;
        }

        private void loginform_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void loginform_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtpassword.Text = "";
            txtname.Focus();
        }

        private void checkshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkshowpass.Checked)
            {
                txtpassword.PasswordChar = '\0';
               

            }
            else
            {
                txtpassword.PasswordChar = '*';
                
            }
        }

        private void lblsignup_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
    }
}
