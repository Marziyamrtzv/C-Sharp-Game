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
    public partial class collectappleform : Form
    {
        bool goLeft, goRight, jumping, isGameOver;

        int jumpspeed;
        int force;
        int score = 0;
        int playerspeed = 7;

        int horizontalspeed = 5;
        int verticalspeed = 3;

        int enemyOneSpeed = 3;
        int enemyTwoSpeed = 2;

      
        void magic()
        {
            System.Media.SoundPlayer magic = new System.Media.SoundPlayer("vaccine.wav");
            magic.Play();

        }
        void voice3()
        {
            System.Media.SoundPlayer voice3 = new System.Media.SoundPlayer("platformgame.WAV");
            voice3.Play();
        }

        void apple()
        {
            System.Media.SoundPlayer apple = new System.Media.SoundPlayer("apple eating.wav");
            apple.Play();
        }

        public collectappleform()
        {
            InitializeComponent();
        }

        private void collectappleform_Load(object sender, EventArgs e)
        {
            Size screensize = Screen.PrimaryScreen.WorkingArea.Size;
            Location = new Point(screensize.Width / 2 - Width / 2, screensize.Height / 2 - Height / 2);
            voice3();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtcore.Text = "سطح سلامتی و دانش:" + score;

            player.Top += jumpspeed;

            if (goLeft==true)
            {
                player.Left -= playerspeed;
            }
            if (goRight==true)
            {
                player.Left += playerspeed;
            }

            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            if (jumping==true)
            {
                jumpspeed = -8;
                force -= 1;

            }
            else
            {
                jumpspeed = 10;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag=="platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;


                            if ((string)x.Name== "horizantalplatform" && goLeft==false || (string)x.Name == "horizantalplatform" && goRight == false)
                            {
                                player.Left -= horizontalspeed;

                            }
                        }
                        x.BringToFront();
                    }

                    if ((string)x.Tag =="apple")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible==true)
                        {
                            x.Visible = false;
                            apple();
                            score++;
                           

                        }
                    }
                    if ((string)x.Tag == "vacc")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            magic();
                            score++;


                        }
                    }



                    if ((string)x.Tag=="enemy")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            gametimer.Stop();
                            isGameOver = true;
                            collectingbad applebadscore = new collectingbad();
                            applebadscore.ShowDialog();
                            
                            lblrestart.Visible = true;

                        }
                    }




                }
            }

            horizantalplatform.Left -= horizontalspeed;

            if (horizantalplatform.Left<0 || horizantalplatform.Left + horizantalplatform.Width>this.ClientSize.Width)
            {
                horizontalspeed = -horizontalspeed;
            }

            verticalplatform.Top += verticalspeed;

            if (verticalplatform.Top<283 || verticalplatform.Top > 565)
            {
                verticalspeed =-verticalspeed;
            }


            enemyone.Left -= enemyOneSpeed;

            if (enemyone.Left<pictureBox5.Left || enemyone.Left + enemyone.Width > pictureBox5.Left + pictureBox5.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;
            }

            enemytwo.Left += enemyTwoSpeed;

            if (enemytwo.Left <pictureBox2.Left||enemytwo.Left+enemytwo.Width> pictureBox2.Left+pictureBox2.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
            }


            if (player.Top +player.Height>this.ClientSize.Height+50)
            {
                gametimer.Stop();
                isGameOver = true;
                {
                    collectingbad applebadscore = new collectingbad();
                    applebadscore.ShowDialog();
                  
                    lblrestart.Visible = true;
                }
            }

            if (player.Bounds.IntersectsWith(family.Bounds) && score == 35)
            {
                gametimer.Stop();
                isGameOver = true;

                collectinggood applegoodscore = new collectinggood();
                applegoodscore.ShowDialog();
                lblrestart.Visible = true;
            }

           
            
        }

        private void enemytwo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mymainform = new mainform();

        }

        private void pic_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblhelp1_Click(object sender, EventArgs e)
        {
            gametimer.Stop();
            messagebox3 help3 = new messagebox3();
            help3.ShowDialog();
            gametimer.Start();
        }

        private void lblhelp1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.lblhelp1, "راهنما");
        }

        private void lblstart_Click(object sender, EventArgs e)
        {
            RestartGame();
            lblstart.Visible = false;
        }

        private void lblrestart_Click(object sender, EventArgs e)
        {
            RestartGame();
            lblrestart.Visible = false;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left)
            {
                goLeft = true;
            }

            if (e.KeyCode==Keys.Right)
            {
                goRight = true;
            }

            if (e.KeyCode==Keys.Space && jumping ==false)
            {
                jumping = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (jumping==true)
            {
                jumping = false;
            }

        }

        private void RestartGame()
        {
            jumping = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            score = 0;

            txtcore.Text = "سطح سلامتی و دانش:"+ score;


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible==false)
                {
                    x.Visible = true;
                }
            }

            // reset the position of player, platform and enemies

            player.Left = 82;
            player.Top = 637;

            enemyone.Left = 442;
            enemytwo.Left = 330;

            horizantalplatform.Left = 238;
            verticalplatform.Top = 565;

            gametimer.Start();
        }
    }
}
