using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid19Dashboard
{
    public partial class DashForm : Form
    {
        public DashForm()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(3,bunifuImageButton1.Location.Y + 7);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(3, bunifuImageButton2.Location.Y + 7);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(3, bunifuImageButton3.Location.Y + 7);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(3, bunifuImageButton4.Location.Y+7);
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(3, bunifuImageButton5.Location.Y + 7);
        }
    }
}
