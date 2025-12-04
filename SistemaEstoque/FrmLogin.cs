using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstoque
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtSenha.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("Administrador"))
            {
                if (txtSenha.Text.Equals("123"))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Senha invalida");
                }
            }
            else
            {
                MessageBox.Show("Usuario invalido");
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
