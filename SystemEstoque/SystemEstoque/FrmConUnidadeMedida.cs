using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemEstoque
{
    public partial class FrmConUnidadeMedida : Form
    {
        public int codigo = 0;
        public FrmConUnidadeMedida()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUnidadeDeMedida bll = new BLLUnidadeDeMedida(cx);
            dgvDados.DataSource = bll.Localizar(txtUnidadeMedida.Text);
        }

        private void FrmConUnidadeMedida_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 100;
            dgvDados.Columns[1].HeaderText = "Unidade de Medida";
            dgvDados.Columns[1].Width = 300;
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
