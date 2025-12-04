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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mercadinhoDataSet);

        }

        private void clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mercadinhoDataSet);

        }

        private void clienteBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            try//tente
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(mercadinhoDataSet.cliente);
                clienteGunaDataGridView.Enabled = false;
                MessageBox.Show("Registro Salvo");
            }
            catch (Exception)//captura o erro
            {
                MessageBox.Show("Ocorreu um erro, verifique os valores informados");

            }

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mercadinhoDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.mercadinhoDataSet.cliente);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            clienteGunaDataGridView.Enabled = true;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clienteBindingSource.AddNew();
            clienteGunaDataGridView.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            clienteGunaDataGridView.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma exclusão do registro", "mercadinho", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteBindingSource.RemoveCurrent();//removeu
                    clienteTableAdapter.Update(mercadinhoDataSet.cliente);//salvou
                }
            }
            catch (Exception)//captura o erro
            {
                clienteTableAdapter.Fill(mercadinhoDataSet.cliente);
                MessageBox.Show("Registro não pode ser excluido");

            }
        }
    }
}
