using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet
{
    public partial class FrmCliente : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;
        private static FrmCliente _Instancia;

        public static FrmCliente GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FrmCliente();
            }
            return _Instancia;
        }
        public FrmCliente()
        {
            InitializeComponent();
        }

        //Limpar Campos
        private void Limpar()
        {
            txtEmail.Text = string.Empty;
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtCelular.Text = string.Empty;
            pxImagem.Image = Properties.Resources.noImage;
        }

        //Habilitar os text box
        private void Habilitar(bool valor)
        {
            txtNome.ReadOnly = !valor;
            txtCelular.ReadOnly = !valor;
            txtEmail.ReadOnly = !valor;
            txtEndereco.ReadOnly = !valor;
            txtCpf.ReadOnly = !valor;
            btnBuscar.Enabled = valor;
            btnLimpar.Enabled = valor;
            btnCarregar.Enabled = valor;
        }

        //Habilitar os botoes
        private void botoes()
        {
            if (eNovo || eEditar)
            {
                Habilitar(true);
                btnNovo.Enabled = false;
                btnSalvar.Enabled = true;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = true;

            }
            else
            {
                Habilitar(false);
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }

        }
    }
}
