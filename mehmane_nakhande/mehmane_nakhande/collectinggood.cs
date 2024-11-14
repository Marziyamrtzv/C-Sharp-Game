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
    public partial class collectinggood : Form
    {
        void success()
        {
            System.Media.SoundPlayer success = new System.Media.SoundPlayer("success.wav");
            success.Play();
        }
        public collectinggood()
        {
            InitializeComponent();
        }

        private void collectinggood_Load(object sender, EventArgs e)
        {

            Size screensize = Screen.PrimaryScreen.WorkingArea.Size;
            Location = new Point(screensize.Width / 2 - Width / 2, screensize.Height / 2 - Height / 2);
            success();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
