using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PlatformerHome
{
    class Coin
    {
        private PictureBox pbCoin = new PictureBox();
        public Coin()
        {
            pbCoin.Width = 20;
            pbCoin.Height = 20;
            pbCoin.BackColor = Color.YellowGreen;
        }
        public  void drawTo(Form f)
        {
            f.Controls.Add(pbCoin);
        }
        public Rectangle getBounds()
        {
            return pbCoin.Bounds;
        }
        public void setPos(int x,int y)
        {
            pbCoin.Location = new Point(x, y);
        }
    }
}
