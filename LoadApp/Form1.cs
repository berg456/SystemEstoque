using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadLab.Parent = pictureBox1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Hide();
            realapp form   = new realapp();
            form.ShowDialog();
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
