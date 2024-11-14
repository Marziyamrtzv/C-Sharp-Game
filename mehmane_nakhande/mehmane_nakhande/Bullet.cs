using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace mehmane_nakhande
{
    class Bullet
    {
        public string direction2;
        public int bulletLeft;
        public int bulletTop;

        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void MakeBullet(Form form)
        {
            bullet.BackColor = Color.Blue;
            bullet.Size = new Size(5,5);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            bullet.BringToFront();

            form.Controls.Add(bullet);


            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();

        }

        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if (direction2 == "left")
            {
                bullet.Left -= speed;
            }

            if (direction2 == "right")
            {
                bullet.Left += speed;
            }

            if (direction2 == "up")
            {
                bullet.Top -= speed;
            }

            if (direction2 == "down")
            {
                bullet.Top += speed;
            }


            if (bullet.Left < 10 || bullet.Left > 542||bullet.Top < 10||bullet.Top > 600)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }



        }

    }
}
