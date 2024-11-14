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
    public partial class formshooting : Form
    {
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerhealth = 100;
        int speed = 10;
        int ammo = 10;
        int virusSpeed = 2;
        int score;
        Random randNum = new Random();

        List<PictureBox> viruslist = new List<PictureBox>();
        void voice2()
        {
            System.Media.SoundPlayer voice2 = new System.Media.SoundPlayer("shootinggame.WAV");
            voice2.Play();
        }
        public formshooting()
        {
            InitializeComponent();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.mymainform = new mainform();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblhelp1_Click(object sender, EventArgs e)
        {
            gametimer.Stop();
            massegebox2 help2 = new massegebox2();
            help2.ShowDialog();
            gametimer.Start();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerhealth>1)
            {
                healthbar.Value = playerhealth;
            }
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.dead;
                gametimer.Stop();
                if (score > 20)
                {
                    shootinggood goodscoreshooting = new shootinggood();
                    goodscoreshooting.ShowDialog();
                    lblrestart.Visible = true;
                    
                }
                else
                {
                    shootingbad badscoreshooting = new shootingbad();
                    badscoreshooting.ShowDialog();
                    lblrestart.Visible = true;

                }
              
            }


            txtammo.Text = "تعداد شلیک:" + ammo;
            txtcore.Text = "تعداد سیگار های خاموش شده:" + score;


            if (goLeft==true && player.Left > 0)
            {
                player.Left -= speed;
            }

            if (goRight==true && player.Left+player.Width<this.ClientSize.Width)
            {
                player.Left += speed;
            }

            if (goUp==true && player.Top> 110)
            {
                player.Top -= speed;
            }

            if (goDown==true && player.Top+player.Height<this.ClientSize.Height)
            {
                player.Top += speed;
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag=="ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;

                    }
                }

                foreach (Control y in this.Controls)
                {
                    if (y is PictureBox && (string)y.Tag == "health")
                    {
                        if (player.Bounds.IntersectsWith(y.Bounds))
                        {
                            this.Controls.Remove(y);
                            ((PictureBox)y).Dispose();
                            playerhealth = 100;
                        }



                    }




                }



                if (x is PictureBox && (string)x.Tag == "virus")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerhealth -= 1;
                    }



                    if (x.Left>player.Left)
                    {
                        x.Left -= virusSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zleft;
                    }
                    if (x.Left < player.Left)
                    {
                        x.Left += virusSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zright;
                    }
                    if (x.Top > player.Top)
                    {
                        x.Top -= virusSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zup;
                    }
                    if (x.Top < player.Top)
                    {
                        x.Top+= virusSpeed;
                        ((PictureBox)x).Image = Properties.Resources.zdown;
                    }

                }

                foreach(Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag=="bullet" && x is PictureBox && (string)x.Tag=="virus")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            viruslist.Remove(((PictureBox)x));
                            MakeVirus();
                        }
                    }
                }


            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
           
            if (gameOver==true)
            {
                return;
            }

            if(e.KeyCode==Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp= true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
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

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
               
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
               
            }

            if (e.KeyCode==Keys.Space && ammo > 0 && gameOver==false)
            {
                ammo --;
                ShootBullet(facing);

                if (ammo<1)
                {
                    Dropammo();
                }

                if (playerhealth<=30)

                {
                    health();

                }
            }

          
        }

        private void formshooting_Load(object sender, EventArgs e)
        {
            Size screensize = Screen.PrimaryScreen.WorkingArea.Size;
            Location = new Point(screensize.Width / 2 - Width / 2, screensize.Height / 2 - Height / 2);
            voice2();

        }

        private void lblhelp1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.lblhelp1, "راهنما");
        }

        private void btnstart_Click(object sender, EventArgs e)
        {}

        private void button2_Click(object sender, EventArgs e)
        {}

        private void btnrestart_MouseHover(object sender, EventArgs e)
        {}

        private void btnstart_MouseHover(object sender, EventArgs e)
        {}

        private void btnstart_Click_1(object sender, EventArgs e)
        {
        }

        private void btnshoro_Click(object sender, EventArgs e)
        {
           
        }

        private void btnagain_Click(object sender, EventArgs e)
        {
           
        }

        private void picstart_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void ShootBullet(string direction)
        {
            Bullet shootbullet = new Bullet();
            shootbullet.direction2 = direction;
            shootbullet.bulletLeft = player.Left + (player.Width/2);
            shootbullet.bulletTop = player.Top + (player.Height/2);
            shootbullet.MakeBullet(this);
        }

        private void txtcore_Click(object sender, EventArgs e)
        {

        }

        private void lblstart_Click(object sender, EventArgs e)
        {
            RestartGame();
            player.Visible = true;
            lblstart.Visible = false;

        }

        private void lblrestart_Click(object sender, EventArgs e)
        {
            if (gameOver == true)
            {

                lblrestart.Visible = false;

                RestartGame();
                player.Visible = true;

            }
        }

        private void MakeVirus()
        {
            PictureBox virus = new PictureBox();
            virus.Tag = "virus";
            virus.Image = Properties.Resources.zdown;
            virus.Left = randNum.Next(0,900);
            virus.Top = randNum.Next(0,800);
            virus.SizeMode = PictureBoxSizeMode.AutoSize;
            viruslist.Add(virus);
            this.Controls.Add(virus);
           
        }

        private void Dropammo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60,this.ClientSize.Height-ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);


            ammo.BringToFront();
            player.BringToFront();


        }

        private void health()
        {
            PictureBox health = new PictureBox();
            health.Image = Properties.Resources.health_Image;
            health.SizeMode = PictureBoxSizeMode.AutoSize;
            health.Left = randNum.Next(10, this.ClientSize.Width - health.Width);
            health.Top = randNum.Next(60, this.ClientSize.Height - health.Height);
            health.Tag = "health";
            this.Controls.Add(health);


            health.BringToFront();
            player.BringToFront();


        }

        private void RestartGame()
        {
            player.Image = Properties.Resources.up;

            foreach (PictureBox i in viruslist)
            {
                this.Controls.Remove(i);
            }

            viruslist.Clear();

            for (int i = 0; i < 3; i++)
            {
                MakeVirus();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            playerhealth = 100;
            score = 0;

            ammo = 10;

            gametimer.Start();
        }
    }
}
