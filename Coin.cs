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
        private PictureBox pbCoin = new PictureBox();        //This defines it as a picture box
        public Coin()
        {
            pbCoin.Width = 20;                              //this defines the size of the coin
            pbCoin.Height = 20;
            pbCoin.BackColor = Color.MediumVioletRed;
        }
        public  void drawTo(Form f)
        {
            f.Controls.Add(pbCoin);                        //This just starts the new cycle of the code
        }
        public Rectangle getBounds()
        {
            return pbCoin.Bounds;                         //Reset away
        }
        public void setPos(int x,int y)
        {
            pbCoin.Location = new Point(x, y);             //This jhust assigns a new class and resets the positions 
        }
    }
}
