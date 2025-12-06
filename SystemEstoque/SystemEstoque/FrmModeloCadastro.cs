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
    public partial class FrmModeloCadastro : Form
    {
        public String operacao;
        public FrmModeloCadastro()
        {
            InitializeComponent();
        }
        public void alteraBotoes(int op)
        {
            // op = operaçoes que serao feitas com os botoes
            // 1  = Preparar os botoes para inserir e localizar
            // 2  = preparar os para inserir/alterar um registro
            // 3  = preparar a tela para excluir ou alterar

            //pnlDados.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            

            if (op == 1)
            {
                btnNovo.Enabled = true;
                btnLocalizar.Enabled = true;
                
            }
            if (op == 2)
            {
               // pnlDados.Enabled = true;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
                ;
            }
            if (op == 3)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
                
            }
        }

        private void FrmModeloCadastro_Load(object sender, EventArgs e)
        {
            alteraBotoes(1);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void FrmModeloCadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
