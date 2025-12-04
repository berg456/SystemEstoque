using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Sistema PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHoras.Text = DateTime.Now.ToString("HH:mm:ss");
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuarioLogado.Text = FrmLogin.usuario;
        }
        //to show register form in mainform
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlCentral.Controls.Add(childForm);
            pnlCentral.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmFuncionarios());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmClientes());
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmInicio());
        }

        private void btnRacas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRacas());
        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAnimal());
        }

        private void btnAgendamentos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmAgendamentos());
        }
    }
}
