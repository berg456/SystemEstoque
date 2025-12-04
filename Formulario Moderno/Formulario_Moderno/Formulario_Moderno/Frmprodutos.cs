using Formulario_Moderno.mercadinhoDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Moderno
{
    public partial class Frmprodutos : Form
    {
        public Frmprodutos()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try//tente
            {
                this.Validate();
                this.produtoBindingSource.EndEdit();
                produtoTableAdapter.Update(mercadinhoDataSet.produto);
                produtoBunifuDataGridView.Enabled = false;
                MessageBox.Show("Registro Salvo");
            }
            catch (Exception)//captura o erro
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");

            }

        }

        private void Frmprodutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mercadinhoDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.mercadinhoDataSet.produto);

        }

        private void produtoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            produtoBindingSource.AddNew();
            produtoBunifuDataGridView.Enabled = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            produtoBindingSource.CancelEdit();
            produtoBunifuDataGridView.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            produtoBunifuDataGridView.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma exclusão do registro", "mercadinho", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    produtoBindingSource.RemoveCurrent();//removeu
                    produtoTableAdapter.Update(mercadinhoDataSet.produto);//salvou
                }
            }
            catch (Exception)//captura o erro
            {
                produtoTableAdapter.Fill(mercadinhoDataSet.produto);
                MessageBox.Show("Registro não pode ser excluido");

            }
        }
    }
}
