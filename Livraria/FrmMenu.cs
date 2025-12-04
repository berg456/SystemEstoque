using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Sistema Gestão de Livraria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ucCliente1.BringToFront();
        }

        private void btnTelefone_Click(object sender, EventArgs e)
        {

        }

        private void btnLivro_Click(object sender, EventArgs e)
        {

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnEditora_Click(object sender, EventArgs e)
        {

        }

        private void btnAutor_Click(object sender, EventArgs e)
        {

        }

        private void btnPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            ucFuncionarios1.BringToFront();
        }

        private void FrmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
            
        }

        private void FrmMenu_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void FrmMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           //lblHoras.Text = DateTime.Now.ToString();
            lblHoras.Text = DateTime.Now.ToString("HH:mm:ss");
            lblData.Text = DateTime.Now.ToString("dd/MMMM/yyyy");
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            ucPrincipal1.BringToFront();
            lblUsuarioLogado.Text = FrmLogin.usuario;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void reflectionLabel1_Click(object sender, EventArgs e)
        {
            ucPrincipal1.BringToFront();
        }
    }
}
