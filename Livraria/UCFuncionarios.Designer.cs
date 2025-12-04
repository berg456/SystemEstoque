namespace Livraria
{
    partial class UCFuncionarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.GroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvfunc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtBusca = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbAtivo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbInativo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlterar = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNovo = new Guna.UI2.WinForms.Guna2Button();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(317, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Image = global::Livraria.Properties.Resources.cadastroUser__2_;
            this.lblSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSenha.Location = new System.Drawing.Point(318, 196);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(81, 21);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha     :";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblSenha_MouseDown);
            this.lblSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblSenha_MouseUp);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderColor = System.Drawing.Color.Silver;
            this.txtSenha.BorderRadius = 10;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.DefaultText = "";
            this.txtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.DisabledState.Parent = this.txtSenha;
            this.txtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.FocusedState.Parent = this.txtSenha;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.HoverState.Parent = this.txtSenha;
            this.txtSenha.Location = new System.Drawing.Point(408, 190);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(5);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.PlaceholderText = "";
            this.txtSenha.SelectedText = "";
            this.txtSenha.ShadowDecoration.Parent = this.txtSenha;
            this.txtSenha.Size = new System.Drawing.Size(179, 33);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSenha_MouseDown);
            this.txtSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtSenha_MouseUp);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderColor = System.Drawing.Color.Silver;
            this.txtUsuario.BorderRadius = 10;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.DisabledState.Parent = this.txtUsuario;
            this.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.FocusedState.Parent = this.txtUsuario;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.HoverState.Parent = this.txtUsuario;
            this.txtUsuario.Location = new System.Drawing.Point(155, 190);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PlaceholderText = "";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.ShadowDecoration.Parent = this.txtUsuario;
            this.txtUsuario.Size = new System.Drawing.Size(164, 33);
            this.txtUsuario.TabIndex = 2;
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
            this.txtNome.Location = new System.Drawing.Point(155, 134);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderText = "";
            this.txtNome.SelectedText = "";
            this.txtNome.ShadowDecoration.Parent = this.txtNome;
            this.txtNome.Size = new System.Drawing.Size(432, 33);
            this.txtNome.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Código:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(154, 96);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(19, 21);
            this.lblCod.TabIndex = 8;
            this.lblCod.Text = "0";
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.dgvfunc);
            this.GroupBox.Controls.Add(this.txtBusca);
            this.GroupBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GroupBox.Location = new System.Drawing.Point(3, 296);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.ShadowDecoration.Parent = this.GroupBox;
            this.GroupBox.Size = new System.Drawing.Size(587, 293);
            this.GroupBox.TabIndex = 9;
            this.GroupBox.Text = "Pesquisar por Funcionário";
            // 
            // dgvfunc
            // 
            this.dgvfunc.AllowUserToAddRows = false;
            this.dgvfunc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvfunc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvfunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvfunc.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvfunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvfunc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvfunc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvfunc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvfunc.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvfunc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvfunc.EnableHeadersVisualStyles = false;
            this.dgvfunc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvfunc.Location = new System.Drawing.Point(6, 95);
            this.dgvfunc.Name = "dgvfunc";
            this.dgvfunc.ReadOnly = true;
            this.dgvfunc.RowHeadersVisible = false;
            this.dgvfunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfunc.Size = new System.Drawing.Size(578, 195);
            this.dgvfunc.TabIndex = 8;
            this.dgvfunc.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvfunc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvfunc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvfunc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvfunc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvfunc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvfunc.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvfunc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvfunc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvfunc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvfunc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvfunc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvfunc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvfunc.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvfunc.ThemeStyle.ReadOnly = true;
            this.dgvfunc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvfunc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvfunc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvfunc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dgvfunc.ThemeStyle.RowsStyle.Height = 22;
            this.dgvfunc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvfunc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvfunc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvfunc_MouseDoubleClick);
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
            this.txtBusca.Location = new System.Drawing.Point(5, 53);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status:";
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
            this.rbAtivo.Location = new System.Drawing.Point(155, 244);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(69, 25);
            this.rbAtivo.TabIndex = 11;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAtivo.UncheckedState.BorderThickness = 2;
            this.rbAtivo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAtivo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbAtivo.UseVisualStyleBackColor = true;
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
            this.rdbInativo.Location = new System.Drawing.Point(230, 244);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(82, 25);
            this.rdbInativo.TabIndex = 12;
            this.rdbInativo.TabStop = true;
            this.rdbInativo.Text = "Inativo";
            this.rdbInativo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbInativo.UncheckedState.BorderThickness = 2;
            this.rdbInativo.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbInativo.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbInativo.UseVisualStyleBackColor = true;
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
            this.btnCancelar.Location = new System.Drawing.Point(613, 429);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(156, 45);
            this.btnCancelar.TabIndex = 17;
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
            this.btnExcluir.Location = new System.Drawing.Point(613, 349);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.ShadowDecoration.Parent = this.btnExcluir;
            this.btnExcluir.Size = new System.Drawing.Size(156, 45);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "    EXCLUIR";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.btnAlterar.Location = new System.Drawing.Point(613, 275);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.ShadowDecoration.Parent = this.btnAlterar;
            this.btnAlterar.Size = new System.Drawing.Size(156, 45);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "  EDITAR";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
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
            this.btnSalvar.Location = new System.Drawing.Point(613, 205);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.ShadowDecoration.Parent = this.btnSalvar;
            this.btnSalvar.Size = new System.Drawing.Size(156, 45);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "   SALVAR";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.btnNovo.Location = new System.Drawing.Point(613, 122);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.ShadowDecoration.Parent = this.btnNovo;
            this.btnNovo.Size = new System.Drawing.Size(156, 45);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = " NOVO";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // UCFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.rdbInativo);
            this.Controls.Add(this.rbAtivo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCFuncionarios";
            this.Size = new System.Drawing.Size(820, 612);
            this.Load += new System.EventHandler(this.UCFuncionarios_Load);
            this.GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCod;
        private Guna.UI2.WinForms.Guna2GroupBox GroupBox;
        private Guna.UI2.WinForms.Guna2DataGridView dgvfunc;
        private Guna.UI2.WinForms.Guna2TextBox txtBusca;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2RadioButton rbAtivo;
        private Guna.UI2.WinForms.Guna2RadioButton rdbInativo;
        private Guna.UI2.WinForms.Guna2Button btnNovo;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2Button btnAlterar;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}
