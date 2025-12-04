using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BLL;
using DAL;
using Modelo;

namespace SystemEstoque
{
    public partial class FrmCadCategoria : SystemEstoque.FrmModeloCadastro
    {
        public FrmCadCategoria()
        {
            InitializeComponent();
        }
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void FrmCadCategoria_Load(object sender, EventArgs e)
        {
            alteraBotoes(1);
            txtNome.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            operacao = "inserir";
            alteraBotoes(2);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaTela();
            txtNome.Enabled = false;
            alteraBotoes(1);
        }
        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al INICIAR ----------------------------------------------------------
        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //leitura dos dados
                ModeloCategoria modelo = new ModeloCategoria();
                modelo.CatNome = txtNome.Text;
                //obj para gravar os dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.CatCod.ToString());

                }
                else
                {
                    //alterar uma categoria
                    modelo.CatCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
                txtNome.Enabled=false;
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
                    BLLCategoria bll = new BLLCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
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
            FrmConsultaCategoria f = new FrmConsultaCategoria();
            f.ShowDialog(this);
            if(f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bLL = new BLLCategoria(cx);
                ModeloCategoria modelo = bLL.CarregaModeloCategoria(f.codigo);
                txtCodigo.Text = modelo.CatCod.ToString();
                txtNome.Text = modelo.CatNome;
                alteraBotoes(3);

            }
            else
            {
                LimpaTela();
                alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            operacao = "alterar";
            alteraBotoes(2);
            txtNome.Enabled = true;
        }
    }
}
