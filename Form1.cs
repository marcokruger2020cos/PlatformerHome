using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformerHome
{
    public partial class Form1 : Form
    {


        int Force;
        int Gravity;
        

        bool isJumping = false;                         // are you jumping? No ok boomer!
        List<Coin> cList = new List<Coin>();            //using the list for coinz
        int Score = 0;                                  //using the int to set score


        private int _skipframes = 1;                   //This kind of helps the buffering
        public Form1()
        {
            InitializeComponent();

           
           
        }
        private void FileExit_clicked(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FileHelp_clicked(object sender, EventArgs e)
        {
            Game_Over newForm = new Game_Over();
            newForm.Show(); 
        }

        private void tmrGravity_Tick(object sender, EventArgs e)
        {
            if (!pbplayer.Bounds.IntersectsWith(pbground.Bounds) && isJumping == false)
            {
                pbplayer.Top += 10;


            }
            if (pbplayer.Bounds.IntersectsWith(pbair.Bounds))
            {
                pbplayer.Top += 10;
            }

            //Space for above new code
           
            if (pbplayer.Bounds.IntersectsWith(platform.Bounds) && isJumping == true)
            {                                                                                                   //Figured this out all on my own feel empty and fufuled.
                 pbplayer.Top += 10;
                 pbplayer.Left -= 10;
               

            }
            else if (pbplayer.Bounds.IntersectsWith(platform.Bounds) && isJumping == false)
            {
                 pbplayer.Top -= 10;
                 

            }
            if (pbplayer.Bounds.IntersectsWith(pictureBox1.Bounds) && isJumping ==true)
            {
                pbplayer.Left -= 10;
                //THIS SECTION HAS TO BE DONE BETTER AS IT DOES NOT WORK WELL.
            }
            else if (pbplayer.Bounds.IntersectsWith(pictureBox1.Bounds) && isJumping == false)
            {
                pbplayer.Left -= 10;
            }
            if (pbplayer.Bounds.IntersectsWith(pictureBox2.Bounds) && isJumping == true)
            {
                pbplayer.Left += 10;
                //THIS SECTION HAS TO BE DONE BETTER AS IT DOES NOT WORK WELL.
            }
            else if (pbplayer.Bounds.IntersectsWith(pictureBox2.Bounds) && isJumping == false)
            {
                pbplayer.Left += 10;
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
        {                                                         //THIS IS THE INSTRUCTIONS FOR MOVEMENT
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

            //Breaker for testing purposes

            if (!isJumping && pbplayer.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                Force = Gravity;
                isJumping = true;
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
            //This is for my coinz brothers
            Coin c1 = new Coin();
            c1.drawTo(this);
            cList.Add(c1);
            c1.setPos(80, 300);
            Coin c2 = new Coin();
            c2.drawTo(this);
            cList.Add(c2);
            c2.setPos(200, 200);
            Coin c3 = new Coin();
            c3.drawTo(this);
            cList.Add(c3);
            c3.setPos(300, 200);
            Coin c4 = new Coin();
            c4.drawTo(this);
            cList.Add(c4);
            c4.setPos(400, 200);
            Coin c5 = new Coin();
            c5.drawTo(this);
            cList.Add(c5);
            c5.setPos(500, 200);
            Coin c6 = new Coin();
            c6.drawTo(this);
            cList.Add(c6);
            c6.setPos(600, 430);
        }

        private void tmrGameloop_Tick(object sender, EventArgs e)
        {

            int width = this.Width = 1000; // get the width of Form.

            if (sun.Location.X > width - sun.Width) //to check condition if pic box is touch the boundroy of form width
            {
                sun.Location = new Point(1, sun.Location.Y); // pic box is set to the new point. here 1 is indicate of X coordinate.
            }
            else
            {
                sun.Location = new Point(sun.Location.X + 5, sun.Location.Y); // to move picture box from x coordinate by 100 Point.
            }
            //Delete above code if dead
            if (pbplayer.Bounds.IntersectsWith(sun.Bounds) && isJumping == false)
            {
                tmrGameloop.Stop();
                MessageBox.Show("You died.Why did you fly into the sun.");
                this.DialogResult = DialogResult.OK;
                this.Close();
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "Menu")
                        Application.OpenForms[i].Close();
                }

            }

            if (Score > 5)
            {
                tmrGameloop.Stop();
                You_win newForm = new You_win();
                newForm.Show();
                
               // Bring up the form to show that you've won.
             


               
            }
                 foreach (Coin c in cList)
              {
                if(pbplayer.Bounds.IntersectsWith(c.getBounds()))
                {
                    c.setPos(1001, 1001);
                    Score++;
                    lblScore.Text = "Score" + Score;
                }

              
              

              }  
                
                   
                    
                    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sun_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show("I WILL KILL You");
        }
    }
 }

  

