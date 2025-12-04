using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class FrmSplash : Form
    {
        int startPoint = 0;
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
            
        {
            startPoint += 2;
            myProgressBar.Value = startPoint;
            if (myProgressBar.Value == 100)
            {
                myProgressBar.Value = 0;
                timer1.Stop();
                FrmLogin loginForm = new FrmLogin();
                this.Hide();
                loginForm.Show();
            }
            
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
