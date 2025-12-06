using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SystemEstoque
{
    public partial class FrmCadSubCategoria : SystemEstoque.FrmModeloCadastro
    {
        public FrmCadSubCategoria()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtScatCod.Clear();
            txtSnomeSubCategoria.Clear();
            //cbCodCategoria.Items.Clear();
        }
        

        private void FrmCadSubCategoria_Load(object sender, EventArgs e)
        {
            alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            cbCodCategoria.DataSource = bll.Localizar("");
            cbCodCategoria.DisplayMember = "cat_nome";
            cbCodCategoria.ValueMember = "cat_cod";
            txtSnomeSubCategoria.Enabled = false;
            cbCodCategoria.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtSnomeSubCategoria.Enabled = true;
            cbCodCategoria.Enabled = true;
            operacao = "inserir";
            alteraBotoes(2);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            txtSnomeSubCategoria.Enabled = false;
            cbCodCategoria.Enabled = false;
            alteraBotoes(1);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            operacao = "alterar";
            alteraBotoes(2);
            txtSnomeSubCategoria.Enabled = true;
            cbCodCategoria.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                modelo.ScatNome = txtSnomeSubCategoria.Text;
                modelo.CatCod = Convert.ToInt32(cbCodCategoria.SelectedValue);
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.ScatCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.ScatCod = Convert.ToInt32(txtScatCod.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
                txtSnomeSubCategoria.Enabled = false;
                cbCodCategoria.Enabled = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLSubCategoria bll = new BLLSubCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txtScatCod.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        { 
            FrmConsultaSubCategoria f = new FrmConsultaSubCategoria();
            f.ShowDialog(this);
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);
                ModeloSubCategoria modelo = bll.CarregaModeloSubCategoria(f.codigo);
                txtScatCod.Text = modelo.ScatCod.ToString();
                txtSnomeSubCategoria.Text = modelo.ScatNome;
                cbCodCategoria.SelectedValue = modelo.CatCod.ToString();
                //cbCodCategoria.SelectedValue = modelo.CatCod;
                alteraBotoes(3);

            }
            else
            {
                LimpaTela();
                alteraBotoes(1);
            }
            f.Dispose();
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
