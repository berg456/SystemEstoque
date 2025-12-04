namespace modernoUi
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelToolsSubMenu = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btnTools = new System.Windows.Forms.Button();
            this.btnEqualizer = new System.Windows.Forms.Button();
            this.panelRelatorioSubMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.panelMediaSubMenu = new System.Windows.Forms.Panel();
            this.btnCadastros = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.panelSideMenu.SuspendLayout();
            this.panelToolsSubMenu.SuspendLayout();
            this.panelRelatorioSubMenu.SuspendLayout();
            this.panelMediaSubMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.MediumBlue;
            this.panelLogo.Controls.Add(this.btnInicio);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 62);
            this.panelLogo.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(12, -4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(204, 60);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.BackColor = System.Drawing.Color.Blue;
            this.btnCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.ForeColor = System.Drawing.Color.Silver;
            this.btnCompra.Location = new System.Drawing.Point(0, 120);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCompra.Size = new System.Drawing.Size(233, 40);
            this.btnCompra.TabIndex = 3;
            this.btnCompra.Text = "       Compra";
            this.btnCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnVenda
            // 
            this.btnVenda.BackColor = System.Drawing.Color.Blue;
            this.btnVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVenda.FlatAppearance.BorderSize = 0;
            this.btnVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.ForeColor = System.Drawing.Color.Silver;
            this.btnVenda.Location = new System.Drawing.Point(0, 80);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVenda.Size = new System.Drawing.Size(233, 40);
            this.btnVenda.TabIndex = 2;
            this.btnVenda.Text = "       Venda";
            this.btnVenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.Blue;
            this.btnFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFuncionario.FlatAppearance.BorderSize = 0;
            this.btnFuncionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.Color.Silver;
            this.btnFuncionario.Location = new System.Drawing.Point(0, 40);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFuncionario.Size = new System.Drawing.Size(233, 40);
            this.btnFuncionario.TabIndex = 1;
            this.btnFuncionario.Text = "       Funcionario";
            this.btnFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Blue;
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.Silver;
            this.btnCliente.Location = new System.Drawing.Point(0, 0);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCliente.Size = new System.Drawing.Size(233, 40);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "       Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.MediumBlue;
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.panelToolsSubMenu);
            this.panelSideMenu.Controls.Add(this.btnTools);
            this.panelSideMenu.Controls.Add(this.btnEqualizer);
            this.panelSideMenu.Controls.Add(this.panelRelatorioSubMenu);
            this.panelSideMenu.Controls.Add(this.btnPlaylist);
            this.panelSideMenu.Controls.Add(this.panelMediaSubMenu);
            this.panelSideMenu.Controls.Add(this.btnCadastros);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 609);
            this.panelSideMenu.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 702);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(233, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "  Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelToolsSubMenu
            // 
            this.panelToolsSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelToolsSubMenu.Controls.Add(this.button10);
            this.panelToolsSubMenu.Controls.Add(this.button12);
            this.panelToolsSubMenu.Controls.Add(this.button13);
            this.panelToolsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolsSubMenu.Location = new System.Drawing.Point(0, 572);
            this.panelToolsSubMenu.Name = "panelToolsSubMenu";
            this.panelToolsSubMenu.Size = new System.Drawing.Size(233, 130);
            this.panelToolsSubMenu.TabIndex = 7;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Blue;
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.Silver;
            this.button10.Location = new System.Drawing.Point(0, 80);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(233, 40);
            this.button10.TabIndex = 2;
            this.button10.Text = "Preferences";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Blue;
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.Silver;
            this.button12.Location = new System.Drawing.Point(0, 40);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(233, 40);
            this.button12.TabIndex = 1;
            this.button12.Text = "Effects and filters";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Blue;
            this.button13.Dock = System.Windows.Forms.DockStyle.Top;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.Silver;
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(233, 40);
            this.button13.TabIndex = 0;
            this.button13.Text = "Media converter";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // btnTools
            // 
            this.btnTools.BackColor = System.Drawing.Color.MediumBlue;
            this.btnTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTools.FlatAppearance.BorderSize = 0;
            this.btnTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnTools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.ForeColor = System.Drawing.Color.Silver;
            this.btnTools.Image = ((System.Drawing.Image)(resources.GetObject("btnTools.Image")));
            this.btnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.Location = new System.Drawing.Point(0, 527);
            this.btnTools.Name = "btnTools";
            this.btnTools.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTools.Size = new System.Drawing.Size(233, 45);
            this.btnTools.TabIndex = 6;
            this.btnTools.Text = "  Tools";
            this.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTools.UseVisualStyleBackColor = false;
            // 
            // btnEqualizer
            // 
            this.btnEqualizer.BackColor = System.Drawing.Color.MediumBlue;
            this.btnEqualizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEqualizer.FlatAppearance.BorderSize = 0;
            this.btnEqualizer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnEqualizer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnEqualizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqualizer.ForeColor = System.Drawing.Color.Silver;
            this.btnEqualizer.Image = ((System.Drawing.Image)(resources.GetObject("btnEqualizer.Image")));
            this.btnEqualizer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEqualizer.Location = new System.Drawing.Point(0, 482);
            this.btnEqualizer.Name = "btnEqualizer";
            this.btnEqualizer.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnEqualizer.Size = new System.Drawing.Size(233, 45);
            this.btnEqualizer.TabIndex = 5;
            this.btnEqualizer.Text = "  Equalizer";
            this.btnEqualizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEqualizer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEqualizer.UseVisualStyleBackColor = false;
            // 
            // panelRelatorioSubMenu
            // 
            this.panelRelatorioSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelRelatorioSubMenu.Controls.Add(this.button1);
            this.panelRelatorioSubMenu.Controls.Add(this.button6);
            this.panelRelatorioSubMenu.Controls.Add(this.button7);
            this.panelRelatorioSubMenu.Controls.Add(this.button8);
            this.panelRelatorioSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRelatorioSubMenu.Location = new System.Drawing.Point(0, 317);
            this.panelRelatorioSubMenu.Name = "panelRelatorioSubMenu";
            this.panelRelatorioSubMenu.Size = new System.Drawing.Size(233, 165);
            this.panelRelatorioSubMenu.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(0, 120);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(233, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Relátorio Fornecedor";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Blue;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Silver;
            this.button6.Location = new System.Drawing.Point(0, 80);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(233, 40);
            this.button6.TabIndex = 2;
            this.button6.Text = "Relátorio Compra";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Blue;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Silver;
            this.button7.Location = new System.Drawing.Point(0, 40);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(233, 40);
            this.button7.TabIndex = 1;
            this.button7.Text = "Relatório Cliente";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Blue;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Silver;
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(233, 40);
            this.button8.TabIndex = 0;
            this.button8.Text = "Relatório de Venda";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackColor = System.Drawing.Color.MediumBlue;
            this.btnPlaylist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnPlaylist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.ForeColor = System.Drawing.Color.SeaShell;
            this.btnPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.Image")));
            this.btnPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.Location = new System.Drawing.Point(0, 272);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPlaylist.Size = new System.Drawing.Size(233, 45);
            this.btnPlaylist.TabIndex = 3;
            this.btnPlaylist.Text = "  Relátorios";
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlaylist.UseVisualStyleBackColor = false;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // panelMediaSubMenu
            // 
            this.panelMediaSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMediaSubMenu.Controls.Add(this.btnCompra);
            this.panelMediaSubMenu.Controls.Add(this.btnVenda);
            this.panelMediaSubMenu.Controls.Add(this.btnFuncionario);
            this.panelMediaSubMenu.Controls.Add(this.btnCliente);
            this.panelMediaSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMediaSubMenu.Location = new System.Drawing.Point(0, 107);
            this.panelMediaSubMenu.Name = "panelMediaSubMenu";
            this.panelMediaSubMenu.Size = new System.Drawing.Size(233, 165);
            this.panelMediaSubMenu.TabIndex = 2;
            // 
            // btnCadastros
            // 
            this.btnCadastros.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastros.FlatAppearance.BorderSize = 0;
            this.btnCadastros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnCadastros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastros.ForeColor = System.Drawing.Color.Silver;
            this.btnCadastros.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastros.Image")));
            this.btnCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.Location = new System.Drawing.Point(0, 62);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCadastros.Size = new System.Drawing.Size(233, 45);
            this.btnCadastros.TabIndex = 1;
            this.btnCadastros.Text = "        Cadastros";
            this.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastros.UseVisualStyleBackColor = false;
            this.btnCadastros.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelChildForm.Controls.Add(this.bunifuCards1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1083, 609);
            this.panelChildForm.TabIndex = 5;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.MediumBlue;
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(833, 39);
            this.BarraTitulo.TabIndex = 6;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(256, 45);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(605, 397);
            this.bunifuCards1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 609);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelChildForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.panelSideMenu.ResumeLayout(false);
            this.panelToolsSubMenu.ResumeLayout(false);
            this.panelRelatorioSubMenu.ResumeLayout(false);
            this.panelMediaSubMenu.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelToolsSubMenu;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btnTools;
        private System.Windows.Forms.Button btnEqualizer;
        private System.Windows.Forms.Panel panelRelatorioSubMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Panel panelMediaSubMenu;
        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel BarraTitulo;
        private BunifuCards bunifuCards1;
    }
}

