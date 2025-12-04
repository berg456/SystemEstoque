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
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;
        public string IdFuncionario = "";
        public string Nome = "";
        public string Sobrenome = "";
        public string Acesso = "";
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProduto frm = FrmProduto.GetInstancia();
           // frm.MdiParent = this;
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategoria frm = new FrmCategoria();
           // frm.MdiParent = this;
            frm.Show();
        }

        private void apresentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmApresentacao frm = new FrmApresentacao();
          //  frm.MdiParent = this;
            frm.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            GestaoUsuario();
            lbNome.Text = Nome.ToLower();
            lbacesso.Text = Acesso;

            //FrmVenda frm = FrmVenda.GetInstancia();
          //  frm.MdiParent = this;
          //  frm.Show();
          //  frm.idfuncionario = Convert.ToInt32(this.IdFuncionario);
        }
        private void GestaoUsuario()
        {
            if (Acesso == "Administrador")
            {
               // MenuProdutos.Enabled = true;
               // MenuVendas.Enabled = true;
               // MenuCompras.Enabled = true;
              //  MenuConsultas.Enabled = true;
              //  MenuFerramentas.Enabled = true;
              //  MenuConfiguracoes.Enabled = true;
               // MenuExibir.Enabled = true;
              //  MenuJanela.Enabled = true;
              //  MenuSistema.Enabled = true;
            }
            else if (Acesso == "Gerente")
            {
              //  MenuProdutos.Enabled = true;
               // MenuVendas.Enabled = true;
               // MenuCompras.Enabled = true;
              //  MenuFerramentas.Enabled = false;
              //  MenuConfiguracoes.Enabled = true;
              //  MenuExibir.Enabled = true;
               // MenuJanela.Enabled = true;
               // MenuSistema.Enabled = true;
            }
            else
            {
               // MenuProdutos.Enabled = true;
             //   MenuVendas.Enabled = true;
               // MenuCompras.Enabled = false;
               // MenuConsultas.Enabled = true;
               // MenuFerramentas.Enabled = false;
             //   MenuConfiguracoes.Enabled = false;
              //  MenuExibir.Enabled = true;
              //  MenuJanela.Enabled = true;
              //  MenuSistema.Enabled = true;
            }
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedor frm = new FrmFornecedor();
           // frm.MdiParent = this;
            frm.Show();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntrada frm = FrmEntrada.GetInstancia();
           // frm.MdiParent = this;
            frm.Show();
            frm.idfuncionario = Convert.ToInt32(this.IdFuncionario);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVenda frm = FrmVenda.GetInstancia();
           // frm.MdiParent = this;
            frm.Show();
            frm.idfuncionario = Convert.ToInt32(this.IdFuncionario);
        }

        private void estoqueDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  Consultas.frmConsulta_Estoque_Produtos frm = new Consultas.frmConsulta_Estoque_Produtos();
          //  frm.ShowDialog();
        }

        private void vendasPorDatasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenda frm = FrmVenda.GetInstancia();
           // frm.MdiParent = this;
            frm.OcultarTab();
            frm.Show();
        }

        private void comprasPorDatasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEntrada frm = FrmEntrada.GetInstancia();
           // frm.MdiParent = this;
            frm.OcultarTab();
            frm.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario frm = new FrmFuncionario();
            //frm.MdiParent = this;

            frm.Show();
        }
    }
}
