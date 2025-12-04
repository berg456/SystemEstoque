namespace Livraria
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMenu = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnSair = new Guna.UI2.WinForms.Guna2Button();
            this.btnCaixa = new Guna.UI2.WinForms.Guna2Button();
            this.btnPedido = new Guna.UI2.WinForms.Guna2Button();
            this.btnAutor = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditora = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategoria = new Guna.UI2.WinForms.Guna2Button();
            this.btnLivro = new Guna.UI2.WinForms.Guna2Button();
            this.btnTelefone = new Guna.UI2.WinForms.Guna2Button();
            this.btnCliente = new Guna.UI2.WinForms.Guna2Button();
            this.btnFuncionario = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLogo = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.BarraTitulo = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ucCliente1 = new Livraria.UCCliente();
            this.ucFuncionarios1 = new Livraria.UCFuncionarios();
            this.ucPrincipal1 = new Livraria.UCPrincipal();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            this.pnlFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnCaixa);
            this.pnlMenu.Controls.Add(this.btnPedido);
            this.pnlMenu.Controls.Add(this.btnAutor);
            this.pnlMenu.Controls.Add(this.btnEditora);
            this.pnlMenu.Controls.Add(this.btnCategoria);
            this.pnlMenu.Controls.Add(this.btnLivro);
            this.pnlMenu.Controls.Add(this.btnTelefone);
            this.pnlMenu.Controls.Add(this.btnCliente);
            this.pnlMenu.Controls.Add(this.btnFuncionario);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.FillColor = System.Drawing.SystemColors.Highlight;
            this.pnlMenu.FillColor2 = System.Drawing.SystemColors.Highlight;
            this.pnlMenu.FillColor3 = System.Drawing.SystemColors.Highlight;
            this.pnlMenu.FillColor4 = System.Drawing.SystemColors.Highlight;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.ShadowDecoration.Parent = this.pnlMenu;
            this.pnlMenu.Size = new System.Drawing.Size(220, 739);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.CheckedState.Parent = this.btnSair;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.CustomImages.Parent = this.btnSair;
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSair.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.HoverState.Parent = this.btnSair;
            this.btnSair.Image = global::Livraria.Properties.Resources.Salir_;
            this.btnSair.ImageSize = new System.Drawing.Size(42, 42);
            this.btnSair.Location = new System.Drawing.Point(0, 636);
            this.btnSair.Name = "btnSair";
            this.btnSair.ShadowDecoration.Parent = this.btnSair;
            this.btnSair.Size = new System.Drawing.Size(220, 59);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair do Sistema";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.CheckedState.Parent = this.btnCaixa;
            this.btnCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaixa.CustomImages.Parent = this.btnCaixa;
            this.btnCaixa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaixa.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnCaixa.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.Color.White;
            this.btnCaixa.HoverState.Parent = this.btnCaixa;
            this.btnCaixa.Image = global::Livraria.Properties.Resources._1452281162_cash_register;
            this.btnCaixa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCaixa.ImageSize = new System.Drawing.Size(42, 42);
            this.btnCaixa.Location = new System.Drawing.Point(0, 577);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.ShadowDecoration.Parent = this.btnCaixa;
            this.btnCaixa.Size = new System.Drawing.Size(220, 59);
            this.btnCaixa.TabIndex = 9;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.CheckedState.Parent = this.btnPedido;
            this.btnPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedido.CustomImages.Parent = this.btnPedido;
            this.btnPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedido.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnPedido.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.Color.White;
            this.btnPedido.HoverState.Parent = this.btnPedido;
            this.btnPedido.Image = global::Livraria.Properties.Resources.novavenda;
            this.btnPedido.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPedido.ImageSize = new System.Drawing.Size(42, 42);
            this.btnPedido.Location = new System.Drawing.Point(0, 518);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.ShadowDecoration.Parent = this.btnPedido;
            this.btnPedido.Size = new System.Drawing.Size(220, 59);
            this.btnPedido.TabIndex = 8;
            this.btnPedido.Text = "Pedido";
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnAutor
            // 
            this.btnAutor.CheckedState.Parent = this.btnAutor;
            this.btnAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutor.CustomImages.Parent = this.btnAutor;
            this.btnAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutor.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnAutor.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutor.ForeColor = System.Drawing.Color.White;
            this.btnAutor.HoverState.Parent = this.btnAutor;
            this.btnAutor.Image = global::Livraria.Properties.Resources.Administrador;
            this.btnAutor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAutor.ImageSize = new System.Drawing.Size(42, 42);
            this.btnAutor.Location = new System.Drawing.Point(0, 459);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.ShadowDecoration.Parent = this.btnAutor;
            this.btnAutor.Size = new System.Drawing.Size(220, 59);
            this.btnAutor.TabIndex = 7;
            this.btnAutor.Text = "Autor";
            this.btnAutor.Click += new System.EventHandler(this.btnAutor_Click);
            // 
            // btnEditora
            // 
            this.btnEditora.CheckedState.Parent = this.btnEditora;
            this.btnEditora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditora.CustomImages.Parent = this.btnEditora;
            this.btnEditora.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditora.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnEditora.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditora.ForeColor = System.Drawing.Color.White;
            this.btnEditora.HoverState.Parent = this.btnEditora;
            this.btnEditora.Image = global::Livraria.Properties.Resources.add_new_icon;
            this.btnEditora.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEditora.ImageSize = new System.Drawing.Size(42, 42);
            this.btnEditora.Location = new System.Drawing.Point(0, 400);
            this.btnEditora.Name = "btnEditora";
            this.btnEditora.ShadowDecoration.Parent = this.btnEditora;
            this.btnEditora.Size = new System.Drawing.Size(220, 59);
            this.btnEditora.TabIndex = 6;
            this.btnEditora.Text = "Editora";
            this.btnEditora.Click += new System.EventHandler(this.btnEditora_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.CheckedState.Parent = this.btnCategoria;
            this.btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoria.CustomImages.Parent = this.btnCategoria;
            this.btnCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoria.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnCategoria.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCategoria.HoverState.Parent = this.btnCategoria;
            this.btnCategoria.Image = global::Livraria.Properties.Resources.descricao_do_produto;
            this.btnCategoria.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategoria.ImageSize = new System.Drawing.Size(42, 42);
            this.btnCategoria.Location = new System.Drawing.Point(0, 341);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.ShadowDecoration.Parent = this.btnCategoria;
            this.btnCategoria.Size = new System.Drawing.Size(220, 59);
            this.btnCategoria.TabIndex = 5;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnLivro
            // 
            this.btnLivro.CheckedState.Parent = this.btnLivro;
            this.btnLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLivro.CustomImages.Parent = this.btnLivro;
            this.btnLivro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLivro.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnLivro.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivro.ForeColor = System.Drawing.Color.White;
            this.btnLivro.HoverState.Parent = this.btnLivro;
            this.btnLivro.Image = global::Livraria.Properties.Resources.issue;
            this.btnLivro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLivro.ImageSize = new System.Drawing.Size(42, 42);
            this.btnLivro.Location = new System.Drawing.Point(0, 282);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.ShadowDecoration.Parent = this.btnLivro;
            this.btnLivro.Size = new System.Drawing.Size(220, 59);
            this.btnLivro.TabIndex = 4;
            this.btnLivro.Text = "Livro";
            this.btnLivro.Click += new System.EventHandler(this.btnLivro_Click);
            // 
            // btnTelefone
            // 
            this.btnTelefone.CheckedState.Parent = this.btnTelefone;
            this.btnTelefone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelefone.CustomImages.Parent = this.btnTelefone;
            this.btnTelefone.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTelefone.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnTelefone.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelefone.ForeColor = System.Drawing.Color.White;
            this.btnTelefone.HoverState.Parent = this.btnTelefone;
            this.btnTelefone.Image = global::Livraria.Properties.Resources.call___191_;
            this.btnTelefone.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTelefone.ImageSize = new System.Drawing.Size(42, 42);
            this.btnTelefone.Location = new System.Drawing.Point(0, 223);
            this.btnTelefone.Name = "btnTelefone";
            this.btnTelefone.ShadowDecoration.Parent = this.btnTelefone;
            this.btnTelefone.Size = new System.Drawing.Size(220, 59);
            this.btnTelefone.TabIndex = 3;
            this.btnTelefone.Text = "Telefone";
            this.btnTelefone.Click += new System.EventHandler(this.btnTelefone_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.CheckedState.Parent = this.btnCliente;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.CustomImages.Parent = this.btnCliente;
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnCliente.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.HoverState.Parent = this.btnCliente;
            this.btnCliente.Image = global::Livraria.Properties.Resources.reception_50px;
            this.btnCliente.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCliente.ImageSize = new System.Drawing.Size(42, 42);
            this.btnCliente.Location = new System.Drawing.Point(0, 164);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.ShadowDecoration.Parent = this.btnCliente;
            this.btnCliente.Size = new System.Drawing.Size(220, 59);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.CheckedState.Parent = this.btnFuncionario;
            this.btnFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionario.CustomImages.Parent = this.btnFuncionario;
            this.btnFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFuncionario.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnFuncionario.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnFuncionario.HoverState.Parent = this.btnFuncionario;
            this.btnFuncionario.Image = global::Livraria.Properties.Resources._131507_hacker_administrator_system_sys_hack_icon1;
            this.btnFuncionario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFuncionario.ImageSize = new System.Drawing.Size(42, 42);
            this.btnFuncionario.Location = new System.Drawing.Point(0, 105);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.ShadowDecoration.Parent = this.btnFuncionario;
            this.btnFuncionario.Size = new System.Drawing.Size(220, 59);
            this.btnFuncionario.TabIndex = 1;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.BorderColor = System.Drawing.Color.Transparent;
            this.pnlLogo.Controls.Add(this.reflectionLabel1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.ShadowDecoration.Parent = this.pnlLogo;
            this.pnlLogo.Size = new System.Drawing.Size(220, 105);
            this.pnlLogo.TabIndex = 0;
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.Location = new System.Drawing.Point(3, 3);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(217, 100);
            this.reflectionLabel1.TabIndex = 0;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Sistema </i><font color=\"#B02B2C\">Bibliotecário</font></fon" +
    "t></b>";
            this.reflectionLabel1.Click += new System.EventHandler(this.reflectionLabel1_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.Transparent;
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Controls.Add(this.lblUsuarioLogado);
            this.BarraTitulo.Controls.Add(this.lblData);
            this.BarraTitulo.Controls.Add(this.lblHoras);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.FillColor = System.Drawing.SystemColors.Highlight;
            this.BarraTitulo.FillColor2 = System.Drawing.SystemColors.HotTrack;
            this.BarraTitulo.FillColor3 = System.Drawing.SystemColors.Highlight;
            this.BarraTitulo.FillColor4 = System.Drawing.SystemColors.HotTrack;
            this.BarraTitulo.Location = new System.Drawing.Point(220, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.ShadowDecoration.Parent = this.BarraTitulo;
            this.BarraTitulo.Size = new System.Drawing.Size(820, 105);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuário Logado:";
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.ForeColor = System.Drawing.Color.Gold;
            this.lblUsuarioLogado.Location = new System.Drawing.Point(16, 50);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(83, 32);
            this.lblUsuarioLogado.TabIndex = 11;
            this.lblUsuarioLogado.Text = "label1";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(482, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(65, 25);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "label2";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.White;
            this.lblHoras.Location = new System.Drawing.Point(482, 57);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(65, 25);
            this.lblHoras.TabIndex = 0;
            this.lblHoras.Text = "label1";
            // 
            // pnlFundo
            // 
            this.pnlFundo.Controls.Add(this.ucCliente1);
            this.pnlFundo.Controls.Add(this.ucFuncionarios1);
            this.pnlFundo.Controls.Add(this.ucPrincipal1);
            this.pnlFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFundo.Location = new System.Drawing.Point(220, 105);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(820, 634);
            this.pnlFundo.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucCliente1
            // 
            this.ucCliente1.Location = new System.Drawing.Point(0, 0);
            this.ucCliente1.Name = "ucCliente1";
            this.ucCliente1.Size = new System.Drawing.Size(820, 612);
            this.ucCliente1.TabIndex = 2;
            // 
            // ucFuncionarios1
            // 
            this.ucFuncionarios1.BackColor = System.Drawing.Color.White;
            this.ucFuncionarios1.Location = new System.Drawing.Point(0, 0);
            this.ucFuncionarios1.Name = "ucFuncionarios1";
            this.ucFuncionarios1.Size = new System.Drawing.Size(820, 612);
            this.ucFuncionarios1.TabIndex = 1;
            // 
            // ucPrincipal1
            // 
            this.ucPrincipal1.Location = new System.Drawing.Point(0, 0);
            this.ucPrincipal1.Name = "ucPrincipal1";
            this.ucPrincipal1.Size = new System.Drawing.Size(820, 612);
            this.ucPrincipal1.TabIndex = 0;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 739);
            this.Controls.Add(this.pnlFundo);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMenu_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMenu_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMenu_KeyUp);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.pnlFundo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlMenu;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlLogo;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private Guna.UI2.WinForms.Guna2Button btnFuncionario;
        private Guna.UI2.WinForms.Guna2Button btnCaixa;
        private Guna.UI2.WinForms.Guna2Button btnPedido;
        private Guna.UI2.WinForms.Guna2Button btnAutor;
        private Guna.UI2.WinForms.Guna2Button btnEditora;
        private Guna.UI2.WinForms.Guna2Button btnCategoria;
        private Guna.UI2.WinForms.Guna2Button btnLivro;
        private Guna.UI2.WinForms.Guna2Button btnTelefone;
        private Guna.UI2.WinForms.Guna2Button btnCliente;
        private Guna.UI2.WinForms.Guna2Button btnSair;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel BarraTitulo;
        private System.Windows.Forms.Panel pnlFundo;
        private UCPrincipal ucPrincipal1;
        private UCFuncionarios ucFuncionarios1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private UCCliente ucCliente1;
    }
}