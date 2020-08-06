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
       

        bool isJumping = false;                                            //This is telling it that its not jumping
     


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
            {                                                                                                   //Figured this out all on my own feel pretty chufed about it :)
                                                                                                                 //Picture Boxes Clip Through one anotheer.
                pbplayer.Top += 10;                                                                              // + and - means the opposite
                                                                                                                //A bunch of bugs do originate from this segment.
               

            }
            else if (pbplayer.Bounds.IntersectsWith(platform.Bounds) && isJumping == false)
            {
                pbplayer.Top -= 10;                           // + and - means the opposite


            }
        }

        public void CreateMyMainMenu()
        {
            // Create an empty MainMenu.
            MainMenu mainMenu1 = new MainMenu();

            MenuItem menuItem1 = new MenuItem();
            MenuItem menuItem2 = new MenuItem();

            menuItem1.Text = "File";
            menuItem2.Text = "Edit";
            // Add two MenuItem objects to the MainMenu.
            mainMenu1.MenuItems.Add(menuItem1);
            mainMenu1.MenuItems.Add(menuItem2);

            // Bind the MainMenu to Form1.
            Menu = mainMenu1;
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

        }

       
    }
 }

  

