namespace SystemEstoque
{
    partial class FrmCadProduto
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
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtDescricao = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtQuantidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.txlabel = new Guna.UI.WinForms.GunaLabel();
            this.txtValorPago = new Guna.UI2.WinForms.Guna2TextBox();
            this.label = new Guna.UI.WinForms.GunaLabel();
            this.txtValorVenda = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.cbUnidadeMedida = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbSubCategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pbFoto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.btLoFoto = new Guna.UI2.WinForms.Guna2Button();
            this.btRmFoto = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCancelar.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnExcluir.CheckedState.Parent = this.btnExcluir;
            this.btnExcluir.CustomImages.Parent = this.btnExcluir;
            this.btnExcluir.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExcluir.HoverState.Parent = this.btnExcluir;
            this.btnExcluir.ShadowDecoration.Parent = this.btnExcluir;
            this.btnExcluir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExcluir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnExcluir.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnAlterar.CheckedState.Parent = this.btnAlterar;
            this.btnAlterar.CustomImages.Parent = this.btnAlterar;
            this.btnAlterar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAlterar.HoverState.Parent = this.btnAlterar;
            this.btnAlterar.ShadowDecoration.Parent = this.btnAlterar;
            this.btnAlterar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAlterar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnAlterar.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnSalvar.CheckedState.Parent = this.btnSalvar;
            this.btnSalvar.CustomImages.Parent = this.btnSalvar;
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalvar.HoverState.Parent = this.btnSalvar;
            this.btnSalvar.ShadowDecoration.Parent = this.btnSalvar;
            this.btnSalvar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSalvar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSalvar.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnNovo.CheckedState.Parent = this.btnNovo;
            this.btnNovo.CustomImages.Parent = this.btnNovo;
            this.btnNovo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNovo.HoverState.Parent = this.btnNovo;
            this.btnNovo.ShadowDecoration.Parent = this.btnNovo;
            this.btnNovo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNovo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnNovo.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.DefaultButton;
            this.btnLocalizar.CheckedState.Parent = this.btnLocalizar;
            this.btnLocalizar.CustomImages.Parent = this.btnLocalizar;
            this.btnLocalizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLocalizar.HoverState.Parent = this.btnLocalizar;
            this.btnLocalizar.ShadowDecoration.Parent = this.btnLocalizar;
            this.btnLocalizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLocalizar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnLocalizar.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.None;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // txtNome
            // 
            this.txtNome.BorderRadius = 6;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.DefaultText = "";
            this.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.DisabledState.Parent = this.txtNome;
            this.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.FocusedState.Parent = this.txtNome;
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.HoverState.Parent = this.txtNome;
            this.txtNome.Location = new System.Drawing.Point(35, 379);
            this.txtNome.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderText = "Insira o Nome do Prduto";
            this.txtNome.SelectedText = "";
            this.txtNome.ShadowDecoration.Parent = this.txtNome;
            this.txtNome.Size = new System.Drawing.Size(565, 43);
            this.txtNome.TabIndex = 14;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderRadius = 6;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.DefaultText = "";
            this.txtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.DisabledState.Parent = this.txtCodigo;
            this.txtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.FocusedState.Parent = this.txtCodigo;
            this.txtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.HoverState.Parent = this.txtCodigo;
            this.txtCodigo.Location = new System.Drawing.Point(35, 294);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.ShadowDecoration.Parent = this.txtCodigo;
            this.txtCodigo.Size = new System.Drawing.Size(122, 43);
            this.txtCodigo.TabIndex = 13;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel2.Location = new System.Drawing.Point(35, 345);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(66, 28);
            this.gunaLabel2.TabIndex = 12;
            this.gunaLabel2.Text = "Nome";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel1.Location = new System.Drawing.Point(30, 258);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(77, 28);
            this.gunaLabel1.TabIndex = 11;
            this.gunaLabel1.Text = "Código";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderRadius = 4;
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.DefaultText = "";
            this.txtDescricao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescricao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescricao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescricao.DisabledState.Parent = this.txtDescricao;
            this.txtDescricao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescricao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescricao.FocusedState.Parent = this.txtDescricao;
            this.txtDescricao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescricao.HoverState.Parent = this.txtDescricao;
            this.txtDescricao.Location = new System.Drawing.Point(625, 379);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.PlaceholderText = "";
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.ShadowDecoration.Parent = this.txtDescricao;
            this.txtDescricao.Size = new System.Drawing.Size(382, 142);
            this.txtDescricao.TabIndex = 16;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel3.Location = new System.Drawing.Point(629, 343);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(96, 28);
            this.gunaLabel3.TabIndex = 15;
            this.gunaLabel3.Text = "Descrição";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderRadius = 6;
            this.txtQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantidade.DefaultText = "";
            this.txtQuantidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantidade.DisabledState.Parent = this.txtQuantidade;
            this.txtQuantidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantidade.FocusedState.Parent = this.txtQuantidade;
            this.txtQuantidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantidade.HoverState.Parent = this.txtQuantidade;
            this.txtQuantidade.Location = new System.Drawing.Point(35, 478);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.PlaceholderText = "";
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.ShadowDecoration.Parent = this.txtQuantidade;
            this.txtQuantidade.Size = new System.Drawing.Size(132, 43);
            this.txtQuantidade.TabIndex = 18;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // txlabel
            // 
            this.txlabel.AutoSize = true;
            this.txlabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txlabel.Location = new System.Drawing.Point(35, 442);
            this.txlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txlabel.Name = "txlabel";
            this.txlabel.Size = new System.Drawing.Size(115, 28);
            this.txlabel.TabIndex = 17;
            this.txlabel.Text = "Quantidade";
            // 
            // txtValorPago
            // 
            this.txtValorPago.BorderRadius = 6;
            this.txtValorPago.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValorPago.DefaultText = "";
            this.txtValorPago.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValorPago.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValorPago.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValorPago.DisabledState.Parent = this.txtValorPago;
            this.txtValorPago.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValorPago.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValorPago.FocusedState.Parent = this.txtValorPago;
            this.txtValorPago.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValorPago.HoverState.Parent = this.txtValorPago;
            this.txtValorPago.Location = new System.Drawing.Point(205, 478);
            this.txtValorPago.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.PasswordChar = '\0';
            this.txtValorPago.PlaceholderText = "";
            this.txtValorPago.SelectedText = "";
            this.txtValorPago.ShadowDecoration.Parent = this.txtValorPago;
            this.txtValorPago.Size = new System.Drawing.Size(212, 43);
            this.txtValorPago.TabIndex = 20;
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label.Location = new System.Drawing.Point(200, 442);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(106, 28);
            this.label.TabIndex = 19;
            this.label.Text = "Valor Pago";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.BorderRadius = 6;
            this.txtValorVenda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValorVenda.DefaultText = "";
            this.txtValorVenda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValorVenda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValorVenda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValorVenda.DisabledState.Parent = this.txtValorVenda;
            this.txtValorVenda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValorVenda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValorVenda.FocusedState.Parent = this.txtValorVenda;
            this.txtValorVenda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValorVenda.HoverState.Parent = this.txtValorVenda;
            this.txtValorVenda.Location = new System.Drawing.Point(440, 478);
            this.txtValorVenda.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.PasswordChar = '\0';
            this.txtValorVenda.PlaceholderText = "";
            this.txtValorVenda.SelectedText = "";
            this.txtValorVenda.ShadowDecoration.Parent = this.txtValorVenda;
            this.txtValorVenda.Size = new System.Drawing.Size(173, 43);
            this.txtValorVenda.TabIndex = 22;
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            this.txtValorVenda.Leave += new System.EventHandler(this.txtValorVenda_Leave);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel6.Location = new System.Drawing.Point(435, 442);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(142, 28);
            this.gunaLabel6.TabIndex = 21;
            this.gunaLabel6.Text = "Valor da venda";
            // 
            // cbUnidadeMedida
            // 
            this.cbUnidadeMedida.BackColor = System.Drawing.Color.Transparent;
            this.cbUnidadeMedida.BorderRadius = 6;
            this.cbUnidadeMedida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidadeMedida.FocusedColor = System.Drawing.Color.Empty;
            this.cbUnidadeMedida.FocusedState.Parent = this.cbUnidadeMedida;
            this.cbUnidadeMedida.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbUnidadeMedida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbUnidadeMedida.FormattingEnabled = true;
            this.cbUnidadeMedida.HoverState.Parent = this.cbUnidadeMedida;
            this.cbUnidadeMedida.ItemHeight = 30;
            this.cbUnidadeMedida.ItemsAppearance.Parent = this.cbUnidadeMedida;
            this.cbUnidadeMedida.Location = new System.Drawing.Point(35, 589);
            this.cbUnidadeMedida.Name = "cbUnidadeMedida";
            this.cbUnidadeMedida.ShadowDecoration.Parent = this.cbUnidadeMedida;
            this.cbUnidadeMedida.Size = new System.Drawing.Size(285, 36);
            this.cbUnidadeMedida.TabIndex = 23;
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cbCategoria.BorderRadius = 6;
            this.cbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FocusedColor = System.Drawing.Color.Empty;
            this.cbCategoria.FocusedState.Parent = this.cbCategoria;
            this.cbCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.HoverState.Parent = this.cbCategoria;
            this.cbCategoria.ItemHeight = 30;
            this.cbCategoria.ItemsAppearance.Parent = this.cbCategoria;
            this.cbCategoria.Location = new System.Drawing.Point(340, 589);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.ShadowDecoration.Parent = this.cbCategoria;
            this.cbCategoria.Size = new System.Drawing.Size(285, 36);
            this.cbCategoria.TabIndex = 24;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // cbSubCategoria
            // 
            this.cbSubCategoria.BackColor = System.Drawing.Color.Transparent;
            this.cbSubCategoria.BorderRadius = 6;
            this.cbSubCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubCategoria.FocusedColor = System.Drawing.Color.Empty;
            this.cbSubCategoria.FocusedState.Parent = this.cbSubCategoria;
            this.cbSubCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSubCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSubCategoria.FormattingEnabled = true;
            this.cbSubCategoria.HoverState.Parent = this.cbSubCategoria;
            this.cbSubCategoria.ItemHeight = 30;
            this.cbSubCategoria.ItemsAppearance.Parent = this.cbSubCategoria;
            this.cbSubCategoria.Location = new System.Drawing.Point(656, 589);
            this.cbSubCategoria.Name = "cbSubCategoria";
            this.cbSubCategoria.ShadowDecoration.Parent = this.cbSubCategoria;
            this.cbSubCategoria.Size = new System.Drawing.Size(351, 36);
            this.cbSubCategoria.TabIndex = 25;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel7.Location = new System.Drawing.Point(651, 542);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(131, 28);
            this.gunaLabel7.TabIndex = 26;
            this.gunaLabel7.Text = "SubCategoria";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel8.Location = new System.Drawing.Point(335, 542);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(97, 28);
            this.gunaLabel8.TabIndex = 27;
            this.gunaLabel8.Text = "Categoria";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel9.Location = new System.Drawing.Point(35, 542);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(185, 28);
            this.gunaLabel9.TabIndex = 28;
            this.gunaLabel9.Text = "Unidade de Medida";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pbFoto);
            this.guna2Panel1.Location = new System.Drawing.Point(1025, 167);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(386, 402);
            this.guna2Panel1.TabIndex = 29;
            // 
            // pbFoto
            // 
            this.pbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFoto.Location = new System.Drawing.Point(0, 0);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.ShadowDecoration.Parent = this.pbFoto;
            this.pbFoto.Size = new System.Drawing.Size(386, 402);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.gunaLabel10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel10.Location = new System.Drawing.Point(40, 57);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(558, 45);
            this.gunaLabel10.TabIndex = 30;
            this.gunaLabel10.Text = "TELA DE CADASTRO DE PRODUTOS";
            // 
            // btLoFoto
            // 
            this.btLoFoto.BorderRadius = 6;
            this.btLoFoto.CheckedState.Parent = this.btLoFoto;
            this.btLoFoto.CustomImages.Parent = this.btLoFoto;
            this.btLoFoto.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btLoFoto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btLoFoto.ForeColor = System.Drawing.Color.White;
            this.btLoFoto.HoverState.Parent = this.btLoFoto;
            this.btLoFoto.Image = global::SystemEstoque.Properties.Resources.Picture1;
            this.btLoFoto.ImageSize = new System.Drawing.Size(50, 50);
            this.btLoFoto.Location = new System.Drawing.Point(1016, 576);
            this.btLoFoto.Name = "btLoFoto";
            this.btLoFoto.ShadowDecoration.Parent = this.btLoFoto;
            this.btLoFoto.Size = new System.Drawing.Size(191, 70);
            this.btLoFoto.TabIndex = 31;
            this.btLoFoto.Text = "Carregar Foto";
            this.btLoFoto.Click += new System.EventHandler(this.btLoFoto_Click);
            // 
            // btRmFoto
            // 
            this.btRmFoto.BorderRadius = 6;
            this.btRmFoto.CheckedState.Parent = this.btRmFoto;
            this.btRmFoto.CustomImages.Parent = this.btRmFoto;
            this.btRmFoto.FillColor = System.Drawing.Color.Salmon;
            this.btRmFoto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btRmFoto.ForeColor = System.Drawing.Color.White;
            this.btRmFoto.HoverState.Parent = this.btRmFoto;
            this.btRmFoto.Image = global::SystemEstoque.Properties.Resources.limpar_32x32;
            this.btRmFoto.ImageSize = new System.Drawing.Size(50, 50);
            this.btRmFoto.Location = new System.Drawing.Point(1220, 576);
            this.btRmFoto.Name = "btRmFoto";
            this.btRmFoto.ShadowDecoration.Parent = this.btRmFoto;
            this.btRmFoto.Size = new System.Drawing.Size(191, 70);
            this.btRmFoto.TabIndex = 32;
            this.btRmFoto.Text = "Remover Foto";
            this.btRmFoto.Click += new System.EventHandler(this.btRmFoto_Click);
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel11.Location = new System.Drawing.Point(1011, 136);
            this.gunaLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(53, 28);
            this.gunaLabel11.TabIndex = 33;
            this.gunaLabel11.Text = "Foto";
            // 
            // FrmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1440, 771);
            this.Controls.Add(this.gunaLabel11);
            this.Controls.Add(this.btRmFoto);
            this.Controls.Add(this.btLoFoto);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.cbSubCategoria);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbUnidadeMedida);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.txtValorPago);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txlabel);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "FrmCadProduto";
            this.Load += new System.EventHandler(this.FrmCadProduto_Load);
            this.Controls.SetChildIndex(this.gunaLabel1, 0);
            this.Controls.SetChildIndex(this.gunaLabel2, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.gunaLabel3, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.txlabel, 0);
            this.Controls.SetChildIndex(this.txtQuantidade, 0);
            this.Controls.SetChildIndex(this.label, 0);
            this.Controls.SetChildIndex(this.txtValorPago, 0);
            this.Controls.SetChildIndex(this.gunaLabel6, 0);
            this.Controls.SetChildIndex(this.txtValorVenda, 0);
            this.Controls.SetChildIndex(this.cbUnidadeMedida, 0);
            this.Controls.SetChildIndex(this.cbCategoria, 0);
            this.Controls.SetChildIndex(this.cbSubCategoria, 0);
            this.Controls.SetChildIndex(this.gunaLabel7, 0);
            this.Controls.SetChildIndex(this.gunaLabel8, 0);
            this.Controls.SetChildIndex(this.gunaLabel9, 0);
            this.Controls.SetChildIndex(this.guna2Panel1, 0);
            this.Controls.SetChildIndex(this.gunaLabel10, 0);
            this.Controls.SetChildIndex(this.btLoFoto, 0);
            this.Controls.SetChildIndex(this.btRmFoto, 0);
            this.Controls.SetChildIndex(this.gunaLabel11, 0);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigo;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtDescricao;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantidade;
        private Guna.UI.WinForms.GunaLabel txlabel;
        private Guna.UI2.WinForms.Guna2TextBox txtValorPago;
        private Guna.UI.WinForms.GunaLabel label;
        private Guna.UI2.WinForms.Guna2TextBox txtValorVenda;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2ComboBox cbUnidadeMedida;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategoria;
        private Guna.UI2.WinForms.Guna2ComboBox cbSubCategoria;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI2.WinForms.Guna2Button btLoFoto;
        private Guna.UI2.WinForms.Guna2Button btRmFoto;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI2.WinForms.Guna2PictureBox pbFoto;
    }
}
