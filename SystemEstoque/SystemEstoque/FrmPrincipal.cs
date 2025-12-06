using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemEstoque
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            hideSubMenu();
        }

        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al INICIAR ----------------------------------------------------------
        public void MostrarFormLogo()
        {
            openChildForm(new FormLogo());
        }


        private void hideSubMenu()
        {
            pnlCadastroSubMenu.Visible = false;
            pnlConsultaSubMenu.Visible = false;
            pnlFerramentasSubMenu.Visible = false;
            pnlMovimentacaoSubMenu.Visible = false;
            pnlRelatorioSubMenu.Visible = false;
            pnlFerramentasSubMenu.Visible = false;
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

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlCadastroSubMenu);
        }

        #region CadastroSubMenu


        #endregion

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCadCategoria());
            //..
            //your codes
            //..
            hideSubMenu();
            FrmCadCategoria fm = new FrmCadCategoria();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
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

        

        

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlConsultaSubMenu);
        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlMovimentacaoSubMenu);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlRelatorioSubMenu);
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlFerramentasSubMenu);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            if (panelSideMenu.Width == 180)
            {
                this.tmContraerMenu.Start();
            }
            else if (panelSideMenu.Width == 55)
            {
                this.tmExpandirMenu.Start();
            }
        }
        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }
        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (panelSideMenu.Width >= 180)
                this.tmExpandirMenu.Stop();
            else
                panelSideMenu.Width = panelSideMenu.Width + 5;
        }

        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (panelSideMenu.Width <= 55)
                this.tmContraerMenu.Stop();
            else
                panelSideMenu.Width = panelSideMenu.Width - 5;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MostrarFormLogo();
            //verifica conexao com o banco
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                DadosDaConexao.servidor = arquivo.ReadLine();
                DadosDaConexao.banco = arquivo.ReadLine();
                DadosDaConexao.usuario = arquivo.ReadLine();
                DadosDaConexao.senha = arquivo.ReadLine();
                arquivo.Close();
                //testar a conexao
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
            }
            catch (SqlException errob)
            {
                MessageBox.Show("Erro ao se conectar no banco de dados \n" +
                                "Acesse as configurações do banco de dados e informe os parâmetros de conexao");
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }

        }

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void btnConCategoria_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConsultaCategoria());
            //..
            //your codes
            //..
            hideSubMenu();
            FrmConsultaCategoria fm = new FrmConsultaCategoria();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);

        }

        private void btnSubCategoria_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCadSubCategoria());
            //..
            //your codes
            //..
            hideSubMenu();
            FrmCadSubCategoria fm = new FrmCadSubCategoria();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
            

        }

        private void btnConSubCategoria_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConsultaSubCategoria());
            //..
            //your codes
            //..
            hideSubMenu();
            FrmConsultaSubCategoria fm = new FrmConsultaSubCategoria();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCadUnidadeDeMedida());
            //..
            //your codes
            //..
            hideSubMenu();
            FrmCadUnidadeDeMedida fm = new FrmCadUnidadeDeMedida();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);

        }

        private void btnConUnidMedida_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConUnidadeMedida());
            //..
            //your codes
            //..
            hideSubMenu();
            FrmConUnidadeMedida fm = new FrmConUnidadeMedida();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void button5_Click(object sender, EventArgs e)
        { //btnProdutos
            openChildForm(new FrmCadProduto());
            //..
            //your codes
            //..
            hideSubMenu();
            FrmCadProduto fm = new FrmCadProduto();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void btnConProduto_Click(object sender, EventArgs e)
        {
            FrmConsultaProduto f = new FrmConsultaProduto();
            f.ShowDialog();
            f.Dispose();
            // openChildForm(new FrmConsultaProduto());
            //..
            //your codes
            //..
            // hideSubMenu();
            // FrmConsultaProduto fm = new FrmConsultaProduto();
            // fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
        }

        private void btnConfigBancoDados_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmConfigBancoDados());
            //..
            //your codes
            //..
            hideSubMenu();
            FrmConfigBancoDados fm = new FrmConfigBancoDados();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            //AbrirFormEnPanel(fm);
            
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }
    }
}
