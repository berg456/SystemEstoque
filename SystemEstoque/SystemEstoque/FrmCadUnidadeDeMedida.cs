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
    public partial class FrmCadUnidadeDeMedida : SystemEstoque.FrmModeloCadastro
    {
        public FrmCadUnidadeDeMedida()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtUnidadeMedida.Enabled = true;
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
            this.operacao = "alterar";
            this.alteraBotoes(2);
            //LimpaTela();
            txtUnidadeMedida.Enabled = true;
        }
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtUnidadeMedida.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                    //MessageBox.Show("mensage");
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloUnidadeDeMedida modelo = new ModeloUnidadeDeMedida();
                modelo.UmedNome = txtUnidadeMedida.Text;
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.UmedCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.UmedCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
                txtUnidadeMedida.Enabled = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {   
            FrmConUnidadeMedida f = new FrmConUnidadeMedida();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                ModeloUnidadeDeMedida modelo = bll.CarregaModeloUnidadeDeMedida(f.codigo);
                txtCodigo.Text = modelo.UmedCod.ToString();
                txtUnidadeMedida.Text = modelo.UmedNome;
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose(); 
        }

        private void txtUnidadeMedida_Leave(object sender, EventArgs e)
        {
            if (this.operacao == "inserir")
            {
                int r = 0;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
                r = bll.VerificaUnidadeDeMedida(txtUnidadeMedida.Text);
                if (r > 0)
                {
                    DialogResult d = MessageBox.Show("Já existe um registro com esse valor. Deseja alterar o registro?", "Aviso", MessageBoxButtons.YesNo);
                    if (d.ToString() == "Yes")
                    {
                        this.operacao = "alterar";
                        ModeloUnidadeDeMedida modelo = bll.CarregaModeloUnidadeDeMedida(r);
                        txtCodigo.Text = modelo.UmedCod.ToString();
                        txtUnidadeMedida.Text = modelo.UmedNome;
                        // alteraBotoes(3);
                    }
                }
            }
        }

        private void FrmCadUnidadeDeMedida_Load(object sender, EventArgs e)
        {
            alteraBotoes(1);
            txtUnidadeMedida.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
