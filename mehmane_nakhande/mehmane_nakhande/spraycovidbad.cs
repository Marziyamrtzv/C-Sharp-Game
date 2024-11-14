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
    public partial class spraycovidbad : Form
    {
        public spraycovidbad()
        {
            InitializeComponent();
        }

        private void spraycovidbad_Load(object sender, EventArgs e)
        {
            Size screensize = Screen.PrimaryScreen.WorkingArea.Size;
            Location = new Point(screensize.Width / 2 - Width / 2, screensize.Height / 2 - Height / 2);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
