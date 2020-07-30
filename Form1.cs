using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformerHome
{
    public partial class Form1 : Form
    {

        bool isJumping = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrGravity_Tick(object sender, EventArgs e)
        {
            if (!pbplayer.Bounds.IntersectsWith(pbground.Bounds) && isJumping == false)
                pbplayer.Top += 10;
        }
    }
}
