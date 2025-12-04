using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animated_SignUpC_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            //425
            if (slideB.Left == 425)
            {
                slideA.Visible = false;
                slideA.Left = 425;
                bunifuSeparator1.Visible = false;

                slideB.Visible = false;
                slideB.Left = 20;
                slideB.Visible = true;
                bunifuSeparator2.Visible = true;

            }
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            //425
            if (slideA.Left == 425)
            {
                slideB.Visible = false;
                slideB.Left = 425;
                bunifuSeparator2.Visible = false;

                slideA.Visible = false;
                slideA.Left = 20;
                slideA.Visible = true;
                bunifuSeparator1.Visible = true;

              
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            bunifuSeparator1.Visible = true;
            bunifuSeparator2.Visible = false;
        }
    }
}
