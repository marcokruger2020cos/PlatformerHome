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
    public partial class You_win : Form
    {
        public You_win()
        {
            InitializeComponent();
        }

        private void You_win_Load(object sender, EventArgs e)
        {
            this.TopMost = true;           //Sets dominant form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();             //Closes all forms
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Menu")
                    Application.OpenForms[i].Close();
            }
        }
    }
}
