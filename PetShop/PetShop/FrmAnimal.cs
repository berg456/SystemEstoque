using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PetShop
{
    public partial class FrmAnimal : Form
    {
        public FrmAnimal()
        {
            InitializeComponent();
        }
        //Estabelecendo conexão com o banco de dados sql server
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-OJPN3JR;Initial Catalog=PetShop;Integrated Security=True;Encrypt=False");
        SqlCommand cm = new SqlCommand();
        // SqlDataReader dt;

        private void desabilitaCampo()
        {
            //txtNome.Enabled = false;
            //txtUsuario.Enabled = false;
            //txtSenha.Enabled = false;
            //btnCancelar.Enabled = false;
           // btnAlterar.Enabled = false;
           // btnSalvar.Enabled = false;
            //btnExcluir.Enabled = false;
            //btnNovo.Enabled = false;
        }

    }
}
