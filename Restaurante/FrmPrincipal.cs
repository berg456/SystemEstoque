using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class FrmPrincipal : Form
    {
        private Boolean showpnlCadastros = false;
        private Boolean showpnlProdutos = false;
        private Boolean showpnlMovimentos = false;
        private Boolean showpnlPedidos = false;
        private Boolean showpnlReservas = false;
        private Boolean showpnlRelatorios = false;
        public FrmPrincipal()
        {
            InitializeComponent();
            tooglePanels();
        }

        private void tooglePanels()
        {
            //Cadastros
            if (showpnlCadastros)
            {
                pnlCadastros.Height = 150;
            }
            else
            {
                pnlCadastros.Height = 0;
            }
            //Produtos
            if (showpnlProdutos)
            {
                pnlProdutos.Height = 100;
            }
            else
            {
                pnlProdutos.Height = 0;
            }
            //Movimentos
            if (showpnlMovimentos)
            {
                pnlMovimentos.Height = 130;
            }
            else
            {
                pnlMovimentos.Height = 0;
            }
            //pnlPedidos
            if (showpnlPedidos)
            {
                pnlPedidos.Height = 120;
            }
            else
            {
                pnlPedidos.Height = 0;
            }
            //pnlReservas
            if (showpnlReservas)
            {
                    pnlReservas.Height = 70;
            }
              else
            {
                     pnlReservas.Height = 0;
            }
            //pnlReservas
            if (showpnlRelatorios)
            {
                pnlRelatorios.Height = 130;
            }
            else
            {
                pnlRelatorios.Height = 0;
            }
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            showpnlCadastros = !showpnlCadastros;
            tooglePanels();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            showpnlProdutos = !showpnlProdutos;
            tooglePanels();
        }

        private void btnMovimentos_Click(object sender, EventArgs e)
        {
            showpnlMovimentos = !showpnlMovimentos;
            tooglePanels();
        }

        private void Pedidos_Click(object sender, EventArgs e)
        {
            showpnlPedidos = !showpnlPedidos; 
            tooglePanels();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            showpnlReservas = !showpnlReservas;
            tooglePanels();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            showpnlRelatorios = !showpnlRelatorios;
            tooglePanels();
        }
    }
}
