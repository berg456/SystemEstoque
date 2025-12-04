using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            InsertForm obj = new InsertForm();
            obj.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            UpDateForm obj = new UpDateForm();
            obj.Show();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DeleteForm obj = new DeleteForm();
            obj.Show();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            ViewForm obj = new ViewForm();
            obj.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
