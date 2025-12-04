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

namespace modernoUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelRelatorioSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmCliente());

            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelChildForm.Controls.Count > 0)
                this.panelChildForm.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Add(fh);
            this.panelChildForm.Tag = fh;
            fh.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void btnVenda_Click(object sender, EventArgs e)
        {

        }

        private void btnCompra_Click(object sender, EventArgs e)
        {

        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRelatorioSubMenu);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
          //  AbrirFormEnPanel(new frmInicio());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
