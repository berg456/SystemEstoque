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

namespace Pet
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.pnlCentral.Controls.Count > 0)
                this.pnlCentral.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlCentral.Controls.Add(fh);
            this.pnlCentral.Tag = fh;
            fh.Show();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "formulario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmInicio());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmCliente());
        }
    }
}
