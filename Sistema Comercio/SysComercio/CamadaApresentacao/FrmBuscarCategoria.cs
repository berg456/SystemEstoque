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
    public partial class FrmBuscarCategoria : Form
    {
        public FrmBuscarCategoria()
        {
            InitializeComponent();
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
            this.DataLista.DataSource = NCategoria.Mostrar();
            this.ocultarColunas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(DataLista.Rows.Count);
        }



        //Buscar pelo Nome
        private void BuscarNome()
        {
            this.DataLista.DataSource = NCategoria.BuscarNome(this.txtBuscar.Text);

            this.ocultarColunas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(DataLista.Rows.Count);

        }

        private void FrmBuscarCategoria_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void DataLista_DoubleClick(object sender, EventArgs e)
        {
            //FrmProduto form = FrmProduto.GetInstancia();
            //string par1, par2;
           //par1 = Convert.ToString(DataLista.CurrentRow.Cells["idcategoria"].Value);
           // par2 = Convert.ToString(DataLista.CurrentRow.Cells["nome"].Value);
           // form.setCategoria(par1, par2);
          //  this.Hide();
        }

        private void DataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmProduto form = FrmProduto.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(DataLista.CurrentRow.Cells["idcategoria"].Value);
            par2 = Convert.ToString(DataLista.CurrentRow.Cells["nome"].Value);
            form.setCategoria(par1, par2);
            this.Hide();
            
        }
    }
}
