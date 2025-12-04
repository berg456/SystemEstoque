using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Formulario_Moderno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnfechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.PanelCentral.Controls.Count > 0)
                this.PanelCentral.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelCentral.Controls.Add(fh);
            this.PanelCentral.Tag = fh;
            fh.Show();

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            btninicio_Click_1(null, e);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnProdutos_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Frmprodutos());
        }

        private void btninicio_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmInicio());
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmVendas());
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
        }

        private void btnrptVendas_Click_1(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            AbrirFormEnPanel(new FrmRelVendas());

        }

        private void btnrptCompras_Click_1(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnrptPag_Click_1(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmClientes());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmCompras());
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmFuncionarios());
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmPagamentos());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmFornecedor());
        }
    }
}
