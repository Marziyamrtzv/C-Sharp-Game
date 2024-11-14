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
    public partial class spraygame : Form
    {
       

        int speed;
       public int score;
       public int count;
        Random rnd = new Random();
        bool gameOver;

       
        public void voice()
        {

            System.Media.SoundPlayer voice = new System.Media.SoundPlayer("spraygame.WAV");
            voice.Play();
        }
        void spray_sound()
        {
           System.Media.SoundPlayer player = new System.Media.SoundPlayer("blow.wav");
            player.Play();
        }
        public spraygame()
        {
            InitializeComponent();
          
        }

        private void pic_close_Click(object sender, EventArgs e)
        {}

        private void pic_minimize_Click(object sender, EventArgs e)
        {}

        private bool mousedown;
        private Point lastlocation;
        private void spraygame_MouseDown(object sender, MouseEventArgs e)
        {

            lastlocation = e.Location;
        }

        private void spraygame_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void spraygame_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void spraygame_Load(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(new Bitmap("alcohol.png"), 50, 60);
            this.Cursor = new Cursor(bmp.GetHicon());
            Size screensize = Screen.PrimaryScreen.WorkingArea.Size;
            Location = new Point(screensize.Width / 2 - Width / 2, screensize.Height / 2 - Height / 2);
            voice();

         


        }

        private void maintimerevent(object sender, EventArgs e)
        {
            lblemtiaz.Text = "امتیاز:" + score;
            lblkill.Text = "تعداد سیگار های نابود شده: " +count;
                if (gameOver==true )
                {
                    gametimer.Stop();
                

                if (count > 20)
                {
                    spraycovidgood goodscore = new spraycovidgood();
                    goodscore.ShowDialog();
                    lblrestart.Visible = true;

                }

                else
                {
                    spraycovidbad badscore = new spraycovidbad();
                    badscore.ShowDialog();
                    lblrestart.Visible = true;
                }
            }

            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "virussssssss")
                {
                    x.Top -= speed;
                    if (x.Top < -100)
                    {
                        x.Top = rnd.Next(700, 1000);
                        x.Left = rnd.Next(5, 500);
                    }

                    if ((string)x.Tag== "virussssssss")
                    {
                    if (x.Top<-50)
                    {
                        gameOver = true;
                    }

                    if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
                        {
                            x.Top = rnd.Next(700, 1000);
                            x.Left = rnd.Next(5, 500);
                        }
                      if (pictureBox3.Bounds.IntersectsWith(pictureBox4.Bounds))
                        {
                            x.Top = rnd.Next(700, 1000);
                            x.Left = rnd.Next(5, 500);
                        }
                         if (pictureBox2.Bounds.IntersectsWith(pictureBox5.Bounds))
                        {
                            x.Top = rnd.Next(700, 1000);
                            x.Left = rnd.Next(5, 500);
                        }
                    }
                }
            }
            if (score > 5)
            {
                speed = 7;
            }
            if (score > 25 && score < 35)
            {
                speed = 8;
            }
        }
       


private void popcovid(object sender, EventArgs e)
        {
            if(gameOver==false)
            {
                var covid = (PictureBox)sender;

                covid.Top = rnd.Next(750, 1000);
                covid.Left = rnd.Next(5, 500);
                score += 5;
                count += 1;
                spray_sound();
            }
        }

        private void KeyIUP(object sender, KeyEventArgs e)
        {
        }

        private void RestartGame()
        {
            speed = 5;
            score = 0;
            count = 0;
            gameOver = false;

            foreach (Control x in this.Controls)
            {
                if ((string)x.Tag == "virussssssss")
                {
                    x.Top = rnd.Next(750, 1000);
                    x.Left = rnd.Next(5, 500);
                }
                gametimer.Start();
               

            }
            
        }
       
    
        private void button1_Click(object sender, EventArgs e)
        {}

        private void lblscore_Click(object sender, EventArgs e)
        {}

        private void btnexit_Click(object sender, EventArgs e)
        {}

        private void btnminimize_Click(object sender, EventArgs e)
        {}

        private void button1_Click_1(object sender, EventArgs e)
        {}

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblhelp1_Click(object sender, EventArgs e)
        {
            gametimer.Stop();
            messagebox1 help1 = new messagebox1();
            help1.ShowDialog();
            gametimer.Start();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mymainform.Show();
          
           
        }

        private void lblhelp1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.lblhelp1, "راهنما");
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
          
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
          
        }

        private void btnrestart_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnstart_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void lblstart_Click(object sender, EventArgs e)
        {
            lblstart.Visible = false;
            RestartGame();
        }

        private void lblrestart_Click(object sender, EventArgs e)
        {
            if (gameOver == true)
            {

                lblrestart.Visible = false;
                RestartGame();

            }
        }
    }
}
