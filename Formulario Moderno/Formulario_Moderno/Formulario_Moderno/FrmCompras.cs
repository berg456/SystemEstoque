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
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void compraBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.compraBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mercadinhoDataSet);

        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mercadinhoDataSet.fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedorTableAdapter.Fill(this.mercadinhoDataSet.fornecedor);
            // TODO: esta linha de código carrega dados na tabela 'mercadinhoDataSet.compra'. Você pode movê-la ou removê-la conforme necessário.
            this.compraTableAdapter.Fill(this.mercadinhoDataSet.compra);

        }
    }
}
