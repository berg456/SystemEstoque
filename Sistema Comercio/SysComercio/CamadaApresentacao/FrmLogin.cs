using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaApresentacao
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DataTable Dados = CamadaNegocio.NFuncionario.Login(txtUsuario.Text, txtSenha.Text);
            if (Dados.Rows.Count == 0)
            {
                MessageBox.Show("O Usuário não Existe, tente novamente!", "Sistema Comércio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmPrincipal frm = new FrmPrincipal();
                frm.IdFuncionario = Dados.Rows[0][0].ToString();
                frm.Nome = Dados.Rows[0][1].ToString();
                frm.Sobrenome = Dados.Rows[0][2].ToString();
                frm.Acesso = Dados.Rows[0][3].ToString();
                frm.Show();
                this.Hide();


            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
