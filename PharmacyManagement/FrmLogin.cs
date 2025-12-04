using DevComponents.DotNetBar.Controls;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "berg" && txtSenha.Text == "123")
            {
                FrmAdministrador administrador = new FrmAdministrador();
                administrador.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha Inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
