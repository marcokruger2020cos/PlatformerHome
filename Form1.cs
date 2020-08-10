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
        List<Coin> cList = new List<Coin>();
        int Score = 0;
     


        public Form1()
        {
            InitializeComponent();

        }



        private void tmrGravity_Tick(object sender, EventArgs e)
        {
            if (!pbplayer.Bounds.IntersectsWith(pbground.Bounds) && isJumping == false)
            {
                pbplayer.Top += 10;
              

            }
            if (pbplayer.Bounds.IntersectsWith(platform.Bounds) && isJumping == true)
            {                                                                                                   //Figured this out all on my own feel emty and fufuled.
                pbplayer.Top += 10;
               

            }
            else if (pbplayer.Bounds.IntersectsWith(platform.Bounds) && isJumping == false)
            {
                pbplayer.Top -= 10;


            }
        }

       

    private void tmrup_Tick(object sender, EventArgs e)
        {
            pbplayer.Top -= 10;
            isJumping = true;
        }
        private void tmrright_Tick(object sender, EventArgs e)
        {
            pbplayer.Left += 10;
        }

        private void tmrleft_Tick(object sender, EventArgs e)
        {
            pbplayer.Left -= 10;
        }

      

       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                tmrup.Start();
            }
           else if (e.KeyCode == Keys.Right)
            {
                tmrRight.Start();
            }
            else if (e.KeyCode == Keys.Left)
            {
                tmrleft.Start();
            }



        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                tmrup.Stop();
                isJumping = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                tmrRight.Stop();
            }
            else if (e.KeyCode == Keys.Left)
            {
                tmrleft.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Coin c1 = new Coin();
            c1.drawTo(this);
            cList.Add(c1);
            c1.setPos(100, 200);
            Coin c2 = new Coin();
            c2.drawTo(this);
            cList.Add(c2);
            c2.setPos(200, 300);
        }

        private void tmrGameloop_Tick(object sender, EventArgs e)
        {
            foreach(Coin c in cList)
            {
                if(pbplayer.Bounds.IntersectsWith(c.getBounds()))
                {
                    c.setPos(1001, 1001);
                    Score++;
                    lblScore.Text = "Score" + Score;
                  
                }



            }  
                
                   
                    
                    
                    }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
 }

  

