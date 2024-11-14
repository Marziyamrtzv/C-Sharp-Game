using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mehmane_nakhande
{
    public partial class mainform : Form
    {
        public string name{ get; set; }
       

        void voice1()
        {
            
           System.Media.SoundPlayer voice1 = new System.Media.SoundPlayer("welcome.WAV");
            voice1.Play();
            
        }
        public mainform()
        {
            InitializeComponent();
           
        }
        private bool mousedown;
        private Point lastlocation;

        private void mainform_Load(object sender, EventArgs e)
        {
            lblname.Text = name;
            Size screensize = Screen.PrimaryScreen.WorkingArea.Size;
            Location = new Point(screensize.Width / 2 - Width / 2, screensize.Height / 2 - Height / 2);
            if (Program.soundplayed==false)
            {
                Program.soundplayed = true;
                voice1();
            }

        }

        private void pic_minimize_Click(object sender, EventArgs e)
        {
             this.WindowState = FormWindowState.Minimized;
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void spraycovid_Click(object sender, EventArgs e)
        {
            Program.mymainform.Hide();
           spraygame game1 = new spraygame();
            game1.ShowDialog();

          
        }

        private void shootingcovid_Click(object sender, EventArgs e)
        {
            Program.mymainform.Hide();
            formshooting game2 = new formshooting();
            game2.Show();
           
        }

        private void mariostyle_Click(object sender, EventArgs e)
        {
            Program.mymainform.Hide();
            collectappleform game3 =  new collectappleform();
            game3.Show();

        }

        private void mainform_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            lastlocation = e.Location;
        }

        private void mainform_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                this.Location = new Point((
                    this.Location.X - lastlocation.X) + e.X, (this.Location.Y - lastlocation.Y) + e.Y);
                this.Update();
            }
        }

        private void mainform_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void lblblack1_Click(object sender, EventArgs e)
        {

        }

        private void picqout_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Program.mymainform.Hide();
            abtsoftware software = new abtsoftware();
            software.ShowDialog();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip aboutsoftware = new ToolTip();
            aboutsoftware.SetToolTip(this.pictureBox1,"درباره نرم افزار");

        }

        private void aboutsoftware_Click(object sender, EventArgs e)
        {
            Program.mymainform.Hide();
            aboutus about = new aboutus();
            about.ShowDialog();
        }

        private void lbltiltle_Click(object sender, EventArgs e)
        {

        }

        private void lbltiltle_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aboutsoftware_MouseHover(object sender, EventArgs e)
        {
            ToolTip aboutus = new ToolTip();
            aboutus.SetToolTip(this.aboutsoftware,"درباره ما");

        }

        private void spraycovid_MouseHover(object sender, EventArgs e)
        {
            ToolTip spraycovid = new ToolTip();
            spraycovid.SetToolTip(this.spraycovid,"بازی نابودی سیگار با کتاب");
        }

        private void mariostyle_MouseHover(object sender, EventArgs e)
        {
            ToolTip vaccgame = new ToolTip();
            vaccgame.SetToolTip(this.mariostyle,"بازی دریافت کتاب و فرار از سیگار");
        }

        private void shootingcovid_MouseHover(object sender, EventArgs e)
        {
            ToolTip shooting = new ToolTip();
            shooting.SetToolTip(this.shootingcovid,"بازی خاموش کردن سیگار");
        }
    }
}
