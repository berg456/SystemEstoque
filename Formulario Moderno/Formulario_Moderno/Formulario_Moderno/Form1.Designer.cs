namespace Formulario_Moderno
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraTitulo = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnmaximizar = new Guna.UI2.WinForms.Guna2Button();
            this.btnfechar = new Guna.UI2.WinForms.Guna2Button();
            this.MenuVertical = new Guna.UI2.WinForms.Guna2Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnFornecedor = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelSelecao = new System.Windows.Forms.Panel();
            this.btninicio = new System.Windows.Forms.PictureBox();
            this.btnRelatorios = new Guna.UI2.WinForms.Guna2Button();
            this.btnPagamentos = new Guna.UI2.WinForms.Guna2Button();
            this.btnFuncionarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnCompras = new Guna.UI2.WinForms.Guna2Button();
            this.btnClientes = new Guna.UI2.WinForms.Guna2Button();
            this.btnVendas = new Guna.UI2.WinForms.Guna2Button();
            this.btnProdutos = new Guna.UI2.WinForms.Guna2Button();
            this.SubmenuReportes = new Guna.UI2.WinForms.Guna2Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnrptPag = new Guna.UI2.WinForms.Guna2Button();
            this.btnrptCompras = new Guna.UI2.WinForms.Guna2Button();
            this.btnrptVendas = new Guna.UI2.WinForms.Guna2Button();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btninicio)).BeginInit();
            this.SubmenuReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Controls.Add(this.btnminimizar);
            this.BarraTitulo.Controls.Add(this.btnmaximizar);
            this.BarraTitulo.Controls.Add(this.btnfechar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.ShadowDecoration.Parent = this.BarraTitulo;
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1231, 7);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 4;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.CheckedState.Parent = this.btnminimizar;
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.CustomImages.Parent = this.btnminimizar;
            this.btnminimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnminimizar.FillColor = System.Drawing.Color.Transparent;
            this.btnminimizar.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.btnminimizar.ForeColor = System.Drawing.Color.Black;
            this.btnminimizar.HoverState.Parent = this.btnminimizar;
            this.btnminimizar.Location = new System.Drawing.Point(1186, 0);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.ShadowDecoration.Parent = this.btnminimizar;
            this.btnminimizar.Size = new System.Drawing.Size(38, 38);
            this.btnminimizar.TabIndex = 2;
            this.btnminimizar.Text = "-";
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.CheckedState.Parent = this.btnmaximizar;
            this.btnmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaximizar.CustomImages.Parent = this.btnmaximizar;
            this.btnmaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnmaximizar.FillColor = System.Drawing.Color.Transparent;
            this.btnmaximizar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnmaximizar.ForeColor = System.Drawing.Color.Black;
            this.btnmaximizar.HoverState.Parent = this.btnmaximizar;
            this.btnmaximizar.Location = new System.Drawing.Point(1224, 0);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.ShadowDecoration.Parent = this.btnmaximizar;
            this.btnmaximizar.Size = new System.Drawing.Size(38, 38);
            this.btnmaximizar.TabIndex = 1;
            this.btnmaximizar.Text = "Ξ";
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.CheckedState.Parent = this.btnfechar;
            this.btnfechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfechar.CustomImages.Parent = this.btnfechar;
            this.btnfechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnfechar.FillColor = System.Drawing.Color.Transparent;
            this.btnfechar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnfechar.ForeColor = System.Drawing.Color.Black;
            this.btnfechar.HoverState.Parent = this.btnfechar;
            this.btnfechar.Location = new System.Drawing.Point(1262, 0);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.ShadowDecoration.Parent = this.btnfechar;
            this.btnfechar.Size = new System.Drawing.Size(38, 38);
            this.btnfechar.TabIndex = 0;
            this.btnfechar.Text = "X";
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.panel10);
            this.MenuVertical.Controls.Add(this.btnFornecedor);
            this.MenuVertical.Controls.Add(this.panel6);
            this.MenuVertical.Controls.Add(this.panel5);
            this.MenuVertical.Controls.Add(this.panel4);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.PanelSelecao);
            this.MenuVertical.Controls.Add(this.btninicio);
            this.MenuVertical.Controls.Add(this.btnRelatorios);
            this.MenuVertical.Controls.Add(this.btnPagamentos);
            this.MenuVertical.Controls.Add(this.btnFuncionarios);
            this.MenuVertical.Controls.Add(this.btnCompras);
            this.MenuVertical.Controls.Add(this.btnClientes);
            this.MenuVertical.Controls.Add(this.btnVendas);
            this.MenuVertical.Controls.Add(this.btnProdutos);
            this.MenuVertical.Controls.Add(this.SubmenuReportes);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 38);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.ShadowDecoration.Parent = this.MenuVertical;
            this.MenuVertical.Size = new System.Drawing.Size(220, 612);
            this.MenuVertical.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel10.Location = new System.Drawing.Point(14, 321);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(4, 32);
            this.panel10.TabIndex = 12;
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.CheckedState.Parent = this.btnFornecedor;
            this.btnFornecedor.CustomImages.Parent = this.btnFornecedor;
            this.btnFornecedor.FillColor = System.Drawing.Color.Transparent;
            this.btnFornecedor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnFornecedor.HoverState.Parent = this.btnFornecedor;
            this.btnFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedor.Image")));
            this.btnFornecedor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFornecedor.ImageSize = new System.Drawing.Size(42, 42);
            this.btnFornecedor.Location = new System.Drawing.Point(22, 321);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.ShadowDecoration.Parent = this.btnFornecedor;
            this.btnFornecedor.Size = new System.Drawing.Size(196, 32);
            this.btnFornecedor.TabIndex = 11;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(14, 397);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(4, 32);
            this.panel6.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(14, 359);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 32);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(14, 283);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 32);
            this.panel4.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(14, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 32);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(14, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 32);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(14, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 32);
            this.panel1.TabIndex = 9;
            // 
            // PanelSelecao
            // 
            this.PanelSelecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.PanelSelecao.Location = new System.Drawing.Point(14, 131);
            this.PanelSelecao.Name = "PanelSelecao";
            this.PanelSelecao.Size = new System.Drawing.Size(4, 32);
            this.PanelSelecao.TabIndex = 8;
            // 
            // btninicio
            // 
            this.btninicio.Image = ((System.Drawing.Image)(resources.GetObject("btninicio.Image")));
            this.btninicio.Location = new System.Drawing.Point(3, 3);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(217, 102);
            this.btninicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btninicio.TabIndex = 7;
            this.btninicio.TabStop = false;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click_1);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.CheckedState.Parent = this.btnRelatorios;
            this.btnRelatorios.CustomImages.Parent = this.btnRelatorios;
            this.btnRelatorios.FillColor = System.Drawing.Color.Transparent;
            this.btnRelatorios.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRelatorios.ForeColor = System.Drawing.Color.White;
            this.btnRelatorios.HoverState.Parent = this.btnRelatorios;
            this.btnRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorios.Image")));
            this.btnRelatorios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRelatorios.ImageSize = new System.Drawing.Size(32, 32);
            this.btnRelatorios.Location = new System.Drawing.Point(22, 396);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.ShadowDecoration.Parent = this.btnRelatorios;
            this.btnRelatorios.Size = new System.Drawing.Size(195, 32);
            this.btnRelatorios.TabIndex = 6;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnPagamentos
            // 
            this.btnPagamentos.CheckedState.Parent = this.btnPagamentos;
            this.btnPagamentos.CustomImages.Parent = this.btnPagamentos;
            this.btnPagamentos.FillColor = System.Drawing.Color.Transparent;
            this.btnPagamentos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPagamentos.ForeColor = System.Drawing.Color.White;
            this.btnPagamentos.HoverState.Parent = this.btnPagamentos;
            this.btnPagamentos.Image = ((System.Drawing.Image)(resources.GetObject("btnPagamentos.Image")));
            this.btnPagamentos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPagamentos.ImageSize = new System.Drawing.Size(32, 32);
            this.btnPagamentos.Location = new System.Drawing.Point(22, 359);
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.ShadowDecoration.Parent = this.btnPagamentos;
            this.btnPagamentos.Size = new System.Drawing.Size(196, 32);
            this.btnPagamentos.TabIndex = 5;
            this.btnPagamentos.Text = "Pagamentos";
            this.btnPagamentos.Click += new System.EventHandler(this.btnPagamentos_Click);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.CheckedState.Parent = this.btnFuncionarios;
            this.btnFuncionarios.CustomImages.Parent = this.btnFuncionarios;
            this.btnFuncionarios.FillColor = System.Drawing.Color.Transparent;
            this.btnFuncionarios.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnFuncionarios.HoverState.Parent = this.btnFuncionarios;
            this.btnFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionarios.Image")));
            this.btnFuncionarios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFuncionarios.ImageSize = new System.Drawing.Size(32, 32);
            this.btnFuncionarios.Location = new System.Drawing.Point(22, 283);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.ShadowDecoration.Parent = this.btnFuncionarios;
            this.btnFuncionarios.Size = new System.Drawing.Size(196, 32);
            this.btnFuncionarios.TabIndex = 4;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.CheckedState.Parent = this.btnCompras;
            this.btnCompras.CustomImages.Parent = this.btnCompras;
            this.btnCompras.FillColor = System.Drawing.Color.Transparent;
            this.btnCompras.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.HoverState.Parent = this.btnCompras;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCompras.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCompras.Location = new System.Drawing.Point(22, 245);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.ShadowDecoration.Parent = this.btnCompras;
            this.btnCompras.Size = new System.Drawing.Size(196, 32);
            this.btnCompras.TabIndex = 3;
            this.btnCompras.Text = "Compras";
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.CheckedState.Parent = this.btnClientes;
            this.btnClientes.CustomImages.Parent = this.btnClientes;
            this.btnClientes.FillColor = System.Drawing.Color.Transparent;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.HoverState.Parent = this.btnClientes;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClientes.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClientes.Location = new System.Drawing.Point(22, 207);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.ShadowDecoration.Parent = this.btnClientes;
            this.btnClientes.Size = new System.Drawing.Size(196, 32);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.CheckedState.Parent = this.btnVendas;
            this.btnVendas.CustomImages.Parent = this.btnVendas;
            this.btnVendas.FillColor = System.Drawing.Color.Transparent;
            this.btnVendas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnVendas.ForeColor = System.Drawing.Color.White;
            this.btnVendas.HoverState.Parent = this.btnVendas;
            this.btnVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnVendas.Image")));
            this.btnVendas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnVendas.ImageSize = new System.Drawing.Size(32, 32);
            this.btnVendas.Location = new System.Drawing.Point(22, 169);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.ShadowDecoration.Parent = this.btnVendas;
            this.btnVendas.Size = new System.Drawing.Size(196, 32);
            this.btnVendas.TabIndex = 1;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.CheckedState.Parent = this.btnProdutos;
            this.btnProdutos.CustomImages.Parent = this.btnProdutos;
            this.btnProdutos.FillColor = System.Drawing.Color.Transparent;
            this.btnProdutos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnProdutos.ForeColor = System.Drawing.Color.White;
            this.btnProdutos.HoverState.Parent = this.btnProdutos;
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProdutos.ImageSize = new System.Drawing.Size(32, 32);
            this.btnProdutos.Location = new System.Drawing.Point(22, 131);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.ShadowDecoration.Parent = this.btnProdutos;
            this.btnProdutos.Size = new System.Drawing.Size(196, 32);
            this.btnProdutos.TabIndex = 0;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click_1);
            // 
            // SubmenuReportes
            // 
            this.SubmenuReportes.Controls.Add(this.panel9);
            this.SubmenuReportes.Controls.Add(this.panel8);
            this.SubmenuReportes.Controls.Add(this.panel7);
            this.SubmenuReportes.Controls.Add(this.btnrptPag);
            this.SubmenuReportes.Controls.Add(this.btnrptCompras);
            this.SubmenuReportes.Controls.Add(this.btnrptVendas);
            this.SubmenuReportes.Location = new System.Drawing.Point(25, 434);
            this.SubmenuReportes.Name = "SubmenuReportes";
            this.SubmenuReportes.ShadowDecoration.Parent = this.SubmenuReportes;
            this.SubmenuReportes.Size = new System.Drawing.Size(195, 110);
            this.SubmenuReportes.TabIndex = 0;
            this.SubmenuReportes.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(18, 75);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(4, 32);
            this.panel9.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(18, 41);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(4, 32);
            this.panel8.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(18, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(4, 32);
            this.panel7.TabIndex = 10;
            // 
            // btnrptPag
            // 
            this.btnrptPag.CheckedState.Parent = this.btnrptPag;
            this.btnrptPag.CustomImages.Parent = this.btnrptPag;
            this.btnrptPag.FillColor = System.Drawing.Color.Transparent;
            this.btnrptPag.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnrptPag.ForeColor = System.Drawing.Color.White;
            this.btnrptPag.HoverState.Parent = this.btnrptPag;
            this.btnrptPag.Location = new System.Drawing.Point(28, 79);
            this.btnrptPag.Name = "btnrptPag";
            this.btnrptPag.ShadowDecoration.Parent = this.btnrptPag;
            this.btnrptPag.Size = new System.Drawing.Size(151, 28);
            this.btnrptPag.TabIndex = 2;
            this.btnrptPag.Text = "Relatório de Pag";
            this.btnrptPag.Click += new System.EventHandler(this.btnrptPag_Click_1);
            // 
            // btnrptCompras
            // 
            this.btnrptCompras.CheckedState.Parent = this.btnrptCompras;
            this.btnrptCompras.CustomImages.Parent = this.btnrptCompras;
            this.btnrptCompras.FillColor = System.Drawing.Color.Transparent;
            this.btnrptCompras.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnrptCompras.ForeColor = System.Drawing.Color.White;
            this.btnrptCompras.HoverState.Parent = this.btnrptCompras;
            this.btnrptCompras.Location = new System.Drawing.Point(28, 36);
            this.btnrptCompras.Name = "btnrptCompras";
            this.btnrptCompras.ShadowDecoration.Parent = this.btnrptCompras;
            this.btnrptCompras.Size = new System.Drawing.Size(164, 28);
            this.btnrptCompras.TabIndex = 1;
            this.btnrptCompras.Text = "Relatório de Compras";
            this.btnrptCompras.Click += new System.EventHandler(this.btnrptCompras_Click_1);
            // 
            // btnrptVendas
            // 
            this.btnrptVendas.CheckedState.Parent = this.btnrptVendas;
            this.btnrptVendas.CustomImages.Parent = this.btnrptVendas;
            this.btnrptVendas.FillColor = System.Drawing.Color.Transparent;
            this.btnrptVendas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnrptVendas.ForeColor = System.Drawing.Color.White;
            this.btnrptVendas.HoverState.Parent = this.btnrptVendas;
            this.btnrptVendas.Location = new System.Drawing.Point(28, 3);
            this.btnrptVendas.Name = "btnrptVendas";
            this.btnrptVendas.ShadowDecoration.Parent = this.btnrptVendas;
            this.btnrptVendas.Size = new System.Drawing.Size(164, 28);
            this.btnrptVendas.TabIndex = 0;
            this.btnrptVendas.Text = "Relatório de Vendas";
            this.btnrptVendas.Click += new System.EventHandler(this.btnrptVendas_Click_1);
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(220, 38);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(1080, 612);
            this.PanelCentral.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btninicio)).EndInit();
            this.SubmenuReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel BarraTitulo;
        private Guna.UI2.WinForms.Guna2Button btnminimizar;
        private Guna.UI2.WinForms.Guna2Button btnmaximizar;
        private Guna.UI2.WinForms.Guna2Button btnfechar;
        private Guna.UI2.WinForms.Guna2Panel MenuVertical;
        private System.Windows.Forms.Panel PanelSelecao;
        private System.Windows.Forms.PictureBox btninicio;
        private Guna.UI2.WinForms.Guna2Button btnRelatorios;
        private Guna.UI2.WinForms.Guna2Button btnPagamentos;
        private Guna.UI2.WinForms.Guna2Button btnFuncionarios;
        private Guna.UI2.WinForms.Guna2Button btnCompras;
        private Guna.UI2.WinForms.Guna2Button btnClientes;
        private Guna.UI2.WinForms.Guna2Button btnVendas;
        private Guna.UI2.WinForms.Guna2Button btnProdutos;
        private Guna.UI2.WinForms.Guna2Panel SubmenuReportes;
        private Guna.UI2.WinForms.Guna2Button btnrptPag;
        private Guna.UI2.WinForms.Guna2Button btnrptCompras;
        private Guna.UI2.WinForms.Guna2Button btnrptVendas;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Panel panel10;
        private Guna.UI2.WinForms.Guna2Button btnFornecedor;
    }
}

