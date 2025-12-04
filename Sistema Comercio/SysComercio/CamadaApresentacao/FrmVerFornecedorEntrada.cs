using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;

namespace CamadaApresentacao
{
    public partial class FrmVerFornecedorEntrada : Form
    {
        public FrmVerFornecedorEntrada()
        {
            InitializeComponent();
        }

        private void FrmVerFornecedorEntrada_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }
        //Ocultar as Colunas do Grid
        private void ocultarColunas()
        {
            this.DataLista.Columns[0].Visible = false;
            this.DataLista.Columns[1].Visible = false;
        }


        //Mostrar no Data Grid
        private void Mostrar()
        {
            this.DataLista.DataSource = NFornecedor.Mostrar();
            this.ocultarColunas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(DataLista.Rows.Count);
        }



        //Buscar pelo Nome da Empresa
        private void BuscarNome()
        {
            this.DataLista.DataSource = NFornecedor.BuscarNome(this.txtBuscar.Text);

            this.ocultarColunas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(DataLista.Rows.Count);
        }


        //Buscar pelo Num Doc
        private void BuscarDocumento()
        {
            this.DataLista.DataSource = NFornecedor.BuscarDocumento(this.txtBuscar.Text);

            this.ocultarColunas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(DataLista.Rows.Count);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbBusca.Text.Equals("Empresa"))
            {
                this.BuscarNome();
            }
            else if (cbBusca.Text.Equals("Documento"))
            {
                this.BuscarDocumento();
            }
        }

        private void cbBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBuscar.Text = string.Empty;
        }

        private void DataLista_DoubleClick(object sender, EventArgs e)
        {
            FrmEntrada form = FrmEntrada.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.DataLista.CurrentRow.Cells["idfornecedor"].Value);
            par2 = Convert.ToString(this.DataLista.CurrentRow.Cells["empresa"].Value);
            form.setFornecedor(par1, par2);
            this.Hide();
        }
    }
}
