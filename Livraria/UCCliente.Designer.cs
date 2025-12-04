namespace Livraria
{
    partial class UCCliente
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlterar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNovo = new Guna.UI2.WinForms.Guna2Button();
            this.rdbInativo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbAtivo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvcli = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtBusca = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.GroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbl_Cod = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelefone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLogradouro = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumero = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxPessoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComplemeto = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBairro = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCep = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxUf = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcli)).BeginInit();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Image = global::Livraria.Properties.Resources.remove_48px;
            this.btnCancelar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancelar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCancelar.Location = new System.Drawing.Point(649, 421);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(156, 45);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BorderRadius = 10;
            this.btnExcluir.CheckedState.Parent = this.btnExcluir;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.CustomImages.Parent = this.btnExcluir;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.HoverState.Parent = this.btnExcluir;
            this.btnExcluir.Image = global::Livraria.Properties.Resources.delete_icon;
            this.btnExcluir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExcluir.ImageSize = new System.Drawing.Size(32, 32);
            this.btnExcluir.Location = new System.Drawing.Point(649, 341);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.ShadowDecoration.Parent = this.btnExcluir;
            this.btnExcluir.Size = new System.Drawing.Size(156, 45);
            this.btnExcluir.TabIndex = 34;
            this.btnExcluir.Text = "    EXCLUIR";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BorderRadius = 10;
            this.btnAlterar.CheckedState.Parent = this.btnAlterar;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.CustomImages.Parent = this.btnAlterar;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.HoverState.Parent = this.btnAlterar;
            this.btnAlterar.Image = global::Livraria.Properties.Resources.author_48;
            this.btnAlterar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAlterar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAlterar.Location = new System.Drawing.Point(649, 267);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.ShadowDecoration.Parent = this.btnAlterar;
            this.btnAlterar.Size = new System.Drawing.Size(156, 45);
            this.btnAlterar.TabIndex = 33;
            this.btnAlterar.Text = "  EDITAR";
            // 
            // btnNovo
            // 
            this.btnNovo.BorderRadius = 10;
            this.btnNovo.CheckedState.Parent = this.btnNovo;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.CustomImages.Parent = this.btnNovo;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.HoverState.Parent = this.btnNovo;
            this.btnNovo.Image = global::Livraria.Properties.Resources.add_new_icon;
            this.btnNovo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNovo.ImageSize = new System.Drawing.Size(32, 32);
            this.btnNovo.Location = new System.Drawing.Point(649, 114);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.ShadowDecoration.Parent = this.btnNovo;
            this.btnNovo.Size = new System.Drawing.Size(156, 45);
            this.btnNovo.TabIndex = 31;
            this.btnNovo.Text = " NOVO";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Checked = true;
            this.rdbInativo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbInativo.CheckedState.BorderThickness = 0;
            this.rdbInativo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbInativo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbInativo.CheckedState.InnerOffset = -4;
            this.rdbInativo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInativo.Location = new System.Drawing.Point(553, 267);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(82, 25);
            this.rdbInativo.TabIndex = 30;
            this.rdbInativo.TabStop = true;
            this.rdbInativo.Text = "Inativo";
            this.rdbInativo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbInativo.UncheckedState.BorderThickness = 2;
            this.rdbInativo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbInativo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAtivo.CheckedState.BorderThickness = 0;
            this.rbAtivo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAtivo.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbAtivo.CheckedState.InnerOffset = -4;
            this.rbAtivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAtivo.Location = new System.Drawing.Point(478, 267);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(69, 25);
            this.rbAtivo.TabIndex = 29;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAtivo.UncheckedState.BorderThickness = 2;
            this.rbAtivo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAtivo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "Status:";
            // 
            // dgvcli
            // 
            this.dgvcli.AllowUserToAddRows = false;
            this.dgvcli.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvcli.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcli.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvcli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcli.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvcli.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcli.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcli.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcli.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcli.EnableHeadersVisualStyles = false;
            this.dgvcli.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvcli.Location = new System.Drawing.Point(4, 106);
            this.dgvcli.Name = "dgvcli";
            this.dgvcli.ReadOnly = true;
            this.dgvcli.RowHeadersVisible = false;
            this.dgvcli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcli.Size = new System.Drawing.Size(607, 171);
            this.dgvcli.TabIndex = 8;
            this.dgvcli.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvcli.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvcli.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvcli.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvcli.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvcli.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvcli.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvcli.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvcli.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvcli.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvcli.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcli.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvcli.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvcli.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvcli.ThemeStyle.ReadOnly = true;
            this.dgvcli.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvcli.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvcli.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvcli.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvcli.ThemeStyle.RowsStyle.Height = 22;
            this.dgvcli.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvcli.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvcli.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvcli_MouseDoubleClick);
            // 
            // txtBusca
            // 
            this.txtBusca.BorderColor = System.Drawing.Color.Silver;
            this.txtBusca.BorderRadius = 10;
            this.txtBusca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBusca.DefaultText = "";
            this.txtBusca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBusca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBusca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusca.DisabledState.Parent = this.txtBusca;
            this.txtBusca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBusca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusca.FocusedState.Parent = this.txtBusca;
            this.txtBusca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBusca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBusca.HoverState.Parent = this.txtBusca;
            this.txtBusca.Location = new System.Drawing.Point(6, 65);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(5);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PasswordChar = '\0';
            this.txtBusca.PlaceholderText = "";
            this.txtBusca.SelectedText = "";
            this.txtBusca.ShadowDecoration.Parent = this.txtBusca;
            this.txtBusca.Size = new System.Drawing.Size(281, 33);
            this.txtBusca.TabIndex = 7;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BorderRadius = 10;
            this.btnSalvar.CheckedState.Parent = this.btnSalvar;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.CustomImages.Parent = this.btnSalvar;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.HoverState.Parent = this.btnSalvar;
            this.btnSalvar.Image = global::Livraria.Properties.Resources.saveicon;
            this.btnSalvar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSalvar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnSalvar.Location = new System.Drawing.Point(649, 197);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.ShadowDecoration.Parent = this.btnSalvar;
            this.btnSalvar.Size = new System.Drawing.Size(156, 45);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.Text = "   SALVAR";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.dgvcli);
            this.GroupBox.Controls.Add(this.txtBusca);
            this.GroupBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GroupBox.Location = new System.Drawing.Point(27, 315);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.ShadowDecoration.Parent = this.GroupBox;
            this.GroupBox.Size = new System.Drawing.Size(616, 270);
            this.GroupBox.TabIndex = 27;
            this.GroupBox.Text = "Pesquisar por Cliente";
            // 
            // lbl_Cod
            // 
            this.lbl_Cod.AutoSize = true;
            this.lbl_Cod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cod.Location = new System.Drawing.Point(93, 38);
            this.lbl_Cod.Name = "lbl_Cod";
            this.lbl_Cod.Size = new System.Drawing.Size(19, 21);
            this.lbl_Cod.TabIndex = 26;
            this.lbl_Cod.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Código:";
            // 
            // txtNome
            // 
            this.txtNome.BorderColor = System.Drawing.Color.Silver;
            this.txtNome.BorderRadius = 10;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.DefaultText = "";
            this.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.DisabledState.Parent = this.txtNome;
            this.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.FocusedState.Parent = this.txtNome;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.HoverState.Parent = this.txtNome;
            this.txtNome.Location = new System.Drawing.Point(94, 73);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderText = "";
            this.txtNome.SelectedText = "";
            this.txtNome.ShadowDecoration.Parent = this.txtNome;
            this.txtNome.Size = new System.Drawing.Size(236, 33);
            this.txtNome.TabIndex = 19;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderColor = System.Drawing.Color.Silver;
            this.txtTelefone.BorderRadius = 10;
            this.txtTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefone.DefaultText = "";
            this.txtTelefone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefone.DisabledState.Parent = this.txtTelefone;
            this.txtTelefone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefone.FocusedState.Parent = this.txtTelefone;
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefone.HoverState.Parent = this.txtTelefone;
            this.txtTelefone.Location = new System.Drawing.Point(102, 119);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(5);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.PlaceholderText = "";
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.ShadowDecoration.Parent = this.txtTelefone;
            this.txtTelefone.Size = new System.Drawing.Size(132, 33);
            this.txtTelefone.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(339, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 41);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cliente";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.Location = new System.Drawing.Point(408, 73);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(233, 33);
            this.txtEmail.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 36;
            this.label4.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 38;
            this.label7.Text = "Pessoa:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.BorderColor = System.Drawing.Color.Silver;
            this.txtLogradouro.BorderRadius = 10;
            this.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogradouro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogradouro.DefaultText = "";
            this.txtLogradouro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLogradouro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLogradouro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogradouro.DisabledState.Parent = this.txtLogradouro;
            this.txtLogradouro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLogradouro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogradouro.FocusedState.Parent = this.txtLogradouro;
            this.txtLogradouro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLogradouro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLogradouro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLogradouro.HoverState.Parent = this.txtLogradouro;
            this.txtLogradouro.Location = new System.Drawing.Point(111, 165);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(5);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.PasswordChar = '\0';
            this.txtLogradouro.PlaceholderText = "";
            this.txtLogradouro.SelectedText = "";
            this.txtLogradouro.ShadowDecoration.Parent = this.txtLogradouro;
            this.txtLogradouro.Size = new System.Drawing.Size(219, 33);
            this.txtLogradouro.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "Endereço:";
            // 
            // txtNumero
            // 
            this.txtNumero.BorderColor = System.Drawing.Color.Silver;
            this.txtNumero.BorderRadius = 10;
            this.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumero.DefaultText = "";
            this.txtNumero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero.DisabledState.Parent = this.txtNumero;
            this.txtNumero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero.FocusedState.Parent = this.txtNumero;
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero.HoverState.Parent = this.txtNumero;
            this.txtNumero.Location = new System.Drawing.Point(373, 165);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(5);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.PlaceholderText = "";
            this.txtNumero.SelectedText = "";
            this.txtNumero.ShadowDecoration.Parent = this.txtNumero;
            this.txtNumero.Size = new System.Drawing.Size(60, 33);
            this.txtNumero.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(338, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 21);
            this.label9.TabIndex = 42;
            this.label9.Text = "Nº.";
            // 
            // cbxPessoa
            // 
            this.cbxPessoa.BackColor = System.Drawing.Color.Transparent;
            this.cbxPessoa.BorderRadius = 8;
            this.cbxPessoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPessoa.FocusedColor = System.Drawing.Color.Empty;
            this.cbxPessoa.FocusedState.Parent = this.cbxPessoa;
            this.cbxPessoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxPessoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxPessoa.FormattingEnabled = true;
            this.cbxPessoa.HoverState.Parent = this.cbxPessoa;
            this.cbxPessoa.ItemHeight = 30;
            this.cbxPessoa.Items.AddRange(new object[] {
            "Fisica",
            "Juridica"});
            this.cbxPessoa.ItemsAppearance.Parent = this.cbxPessoa;
            this.cbxPessoa.Location = new System.Drawing.Point(308, 119);
            this.cbxPessoa.Name = "cbxPessoa";
            this.cbxPessoa.ShadowDecoration.Parent = this.cbxPessoa;
            this.cbxPessoa.Size = new System.Drawing.Size(140, 36);
            this.cbxPessoa.TabIndex = 44;
            this.cbxPessoa.SelectedIndexChanged += new System.EventHandler(this.cbxPessoa_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(454, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 21);
            this.label10.TabIndex = 45;
            this.label10.Text = "CPF:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtComplemeto
            // 
            this.txtComplemeto.BorderColor = System.Drawing.Color.Silver;
            this.txtComplemeto.BorderRadius = 10;
            this.txtComplemeto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemeto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComplemeto.DefaultText = "";
            this.txtComplemeto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComplemeto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtComplemeto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComplemeto.DisabledState.Parent = this.txtComplemeto;
            this.txtComplemeto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComplemeto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComplemeto.FocusedState.Parent = this.txtComplemeto;
            this.txtComplemeto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtComplemeto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtComplemeto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComplemeto.HoverState.Parent = this.txtComplemeto;
            this.txtComplemeto.Location = new System.Drawing.Point(153, 211);
            this.txtComplemeto.Margin = new System.Windows.Forms.Padding(5);
            this.txtComplemeto.Name = "txtComplemeto";
            this.txtComplemeto.PasswordChar = '\0';
            this.txtComplemeto.PlaceholderText = "";
            this.txtComplemeto.SelectedText = "";
            this.txtComplemeto.ShadowDecoration.Parent = this.txtComplemeto;
            this.txtComplemeto.Size = new System.Drawing.Size(219, 33);
            this.txtComplemeto.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 21);
            this.label11.TabIndex = 46;
            this.label11.Text = "Complemento:";
            // 
            // txtBairro
            // 
            this.txtBairro.BorderColor = System.Drawing.Color.Silver;
            this.txtBairro.BorderRadius = 10;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBairro.DefaultText = "";
            this.txtBairro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBairro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBairro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBairro.DisabledState.Parent = this.txtBairro;
            this.txtBairro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBairro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBairro.FocusedState.Parent = this.txtBairro;
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBairro.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBairro.HoverState.Parent = this.txtBairro;
            this.txtBairro.Location = new System.Drawing.Point(497, 165);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(5);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.PlaceholderText = "";
            this.txtBairro.SelectedText = "";
            this.txtBairro.ShadowDecoration.Parent = this.txtBairro;
            this.txtBairro.Size = new System.Drawing.Size(141, 33);
            this.txtBairro.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(439, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 21);
            this.label12.TabIndex = 48;
            this.label12.Text = "Bairro:";
            // 
            // txtCidade
            // 
            this.txtCidade.BorderColor = System.Drawing.Color.Silver;
            this.txtCidade.BorderRadius = 10;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCidade.DefaultText = "";
            this.txtCidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCidade.DisabledState.Parent = this.txtCidade;
            this.txtCidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCidade.FocusedState.Parent = this.txtCidade;
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCidade.HoverState.Parent = this.txtCidade;
            this.txtCidade.Location = new System.Drawing.Point(446, 211);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(5);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.PlaceholderText = "";
            this.txtCidade.SelectedText = "";
            this.txtCidade.ShadowDecoration.Parent = this.txtCidade;
            this.txtCidade.Size = new System.Drawing.Size(195, 33);
            this.txtCidade.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(380, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 21);
            this.label13.TabIndex = 50;
            this.label13.Text = "Cidade:";
            // 
            // txtCep
            // 
            this.txtCep.BorderColor = System.Drawing.Color.Silver;
            this.txtCep.BorderRadius = 10;
            this.txtCep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCep.DefaultText = "";
            this.txtCep.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCep.DisabledState.Parent = this.txtCep;
            this.txtCep.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCep.FocusedState.Parent = this.txtCep;
            this.txtCep.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCep.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCep.HoverState.Parent = this.txtCep;
            this.txtCep.Location = new System.Drawing.Point(77, 267);
            this.txtCep.Margin = new System.Windows.Forms.Padding(5);
            this.txtCep.Name = "txtCep";
            this.txtCep.PasswordChar = '\0';
            this.txtCep.PlaceholderText = "";
            this.txtCep.SelectedText = "";
            this.txtCep.ShadowDecoration.Parent = this.txtCep;
            this.txtCep.Size = new System.Drawing.Size(106, 33);
            this.txtCep.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 21);
            this.label14.TabIndex = 52;
            this.label14.Text = "CEP:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(191, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 21);
            this.label15.TabIndex = 54;
            this.label15.Text = "UF:";
            // 
            // cbxUf
            // 
            this.cbxUf.BackColor = System.Drawing.Color.Transparent;
            this.cbxUf.BorderRadius = 8;
            this.cbxUf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUf.FocusedColor = System.Drawing.Color.Empty;
            this.cbxUf.FocusedState.Parent = this.cbxUf;
            this.cbxUf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxUf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxUf.FormattingEnabled = true;
            this.cbxUf.HoverState.Parent = this.cbxUf;
            this.cbxUf.ItemHeight = 30;
            this.cbxUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
            this.cbxUf.ItemsAppearance.Parent = this.cbxUf;
            this.cbxUf.Location = new System.Drawing.Point(221, 264);
            this.cbxUf.Name = "cbxUf";
            this.cbxUf.ShadowDecoration.Parent = this.cbxUf;
            this.cbxUf.Size = new System.Drawing.Size(151, 36);
            this.cbxUf.TabIndex = 55;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(448, 125);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(53, 21);
            this.lblCnpj.TabIndex = 57;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCnpj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(499, 125);
            this.txtCnpj.Mask = "00,000,000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(142, 22);
            this.txtCnpj.TabIndex = 58;
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(499, 125);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(141, 22);
            this.txtCpf.TabIndex = 59;
            // 
            // UCCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.cbxUf);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtComplemeto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxPessoa);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.rdbInativo);
            this.Controls.Add(this.rbAtivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.lbl_Cod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtCpf);
            this.Name = "UCCliente";
            this.Size = new System.Drawing.Size(820, 612);
            this.Load += new System.EventHandler(this.UCCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcli)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnAlterar;
        private Guna.UI2.WinForms.Guna2Button btnNovo;
        private Guna.UI2.WinForms.Guna2RadioButton rdbInativo;
        private Guna.UI2.WinForms.Guna2RadioButton rbAtivo;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dgvcli;
        private Guna.UI2.WinForms.Guna2TextBox txtBusca;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2GroupBox GroupBox;
        private System.Windows.Forms.Label lbl_Cod;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtLogradouro;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtNumero;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cbxPessoa;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtComplemeto;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtBairro;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtCidade;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtCep;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2ComboBox cbxUf;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.MaskedTextBox txtCpf;
    }
}
