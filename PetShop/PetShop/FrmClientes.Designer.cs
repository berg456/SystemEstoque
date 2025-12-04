namespace PetShop
{
    partial class FrmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlterar = new Guna.UI2.WinForms.Guna2Button();
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNovo = new Guna.UI2.WinForms.Guna2Button();
            this.GroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvfunc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtBusca = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCelular = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCpf = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndereco = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFoto = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbCliente = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.button_upload = new System.Windows.Forms.Button();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).BeginInit();
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
            this.btnCancelar.Image = global::PetShop.Properties.Resources.remove_48px;
            this.btnCancelar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancelar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnCancelar.Location = new System.Drawing.Point(768, 545);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(208, 55);
            this.btnCancelar.TabIndex = 42;
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
            this.btnExcluir.Image = global::PetShop.Properties.Resources.delete_icon;
            this.btnExcluir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExcluir.ImageSize = new System.Drawing.Size(32, 32);
            this.btnExcluir.Location = new System.Drawing.Point(768, 482);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.ShadowDecoration.Parent = this.btnExcluir;
            this.btnExcluir.Size = new System.Drawing.Size(208, 55);
            this.btnExcluir.TabIndex = 41;
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
            this.btnAlterar.Image = global::PetShop.Properties.Resources.author_48;
            this.btnAlterar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAlterar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAlterar.Location = new System.Drawing.Point(768, 420);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.ShadowDecoration.Parent = this.btnAlterar;
            this.btnAlterar.Size = new System.Drawing.Size(208, 55);
            this.btnAlterar.TabIndex = 40;
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
            this.btnSalvar.Image = global::PetShop.Properties.Resources.saveicon;
            this.btnSalvar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSalvar.ImageSize = new System.Drawing.Size(32, 32);
            this.btnSalvar.Location = new System.Drawing.Point(768, 357);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.ShadowDecoration.Parent = this.btnSalvar;
            this.btnSalvar.Size = new System.Drawing.Size(208, 55);
            this.btnSalvar.TabIndex = 39;
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
            this.btnNovo.Image = global::PetShop.Properties.Resources.add_new_icon;
            this.btnNovo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNovo.ImageSize = new System.Drawing.Size(32, 32);
            this.btnNovo.Location = new System.Drawing.Point(768, 294);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.ShadowDecoration.Parent = this.btnNovo;
            this.btnNovo.Size = new System.Drawing.Size(208, 55);
            this.btnNovo.TabIndex = 38;
            this.btnNovo.Text = " NOVO";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.dgvfunc);
            this.GroupBox.Controls.Add(this.txtBusca);
            this.GroupBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GroupBox.Location = new System.Drawing.Point(12, 273);
            this.GroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.ShadowDecoration.Parent = this.GroupBox;
            this.GroupBox.Size = new System.Drawing.Size(723, 331);
            this.GroupBox.TabIndex = 37;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvfunc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvfunc.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvfunc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvfunc.EnableHeadersVisualStyles = false;
            this.dgvfunc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvfunc.Location = new System.Drawing.Point(8, 117);
            this.dgvfunc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvfunc.Name = "dgvfunc";
            this.dgvfunc.ReadOnly = true;
            this.dgvfunc.RowHeadersVisible = false;
            this.dgvfunc.RowHeadersWidth = 51;
            this.dgvfunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfunc.Size = new System.Drawing.Size(715, 214);
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
            this.dgvfunc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvfunc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvfunc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvfunc.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvfunc.ThemeStyle.ReadOnly = true;
            this.dgvfunc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvfunc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvfunc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtBusca.Location = new System.Drawing.Point(7, 65);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PasswordChar = '\0';
            this.txtBusca.PlaceholderText = "";
            this.txtBusca.SelectedText = "";
            this.txtBusca.ShadowDecoration.Parent = this.txtBusca;
            this.txtBusca.Size = new System.Drawing.Size(375, 41);
            this.txtBusca.TabIndex = 7;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.BorderColor = System.Drawing.Color.Silver;
            this.txtNome.BorderRadius = 10;
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
            this.txtNome.Location = new System.Drawing.Point(99, 52);
            this.txtNome.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderText = "";
            this.txtNome.SelectedText = "";
            this.txtNome.ShadowDecoration.Parent = this.txtNome;
            this.txtNome.Size = new System.Drawing.Size(353, 41);
            this.txtNome.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 36;
            this.label2.Text = "Nome:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(107, 12);
            this.lblCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(24, 28);
            this.lblCod.TabIndex = 34;
            this.lblCod.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 28);
            this.label5.TabIndex = 33;
            this.label5.Text = "Código:";
            // 
            // txtCelular
            // 
            this.txtCelular.BorderColor = System.Drawing.Color.Silver;
            this.txtCelular.BorderRadius = 10;
            this.txtCelular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCelular.DefaultText = "";
            this.txtCelular.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCelular.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCelular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCelular.DisabledState.Parent = this.txtCelular;
            this.txtCelular.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCelular.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCelular.FocusedState.Parent = this.txtCelular;
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCelular.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCelular.HoverState.Parent = this.txtCelular;
            this.txtCelular.Location = new System.Drawing.Point(576, 52);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.PasswordChar = '\0';
            this.txtCelular.PlaceholderText = "";
            this.txtCelular.SelectedText = "";
            this.txtCelular.ShadowDecoration.Parent = this.txtCelular;
            this.txtCelular.Size = new System.Drawing.Size(159, 41);
            this.txtCelular.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 44;
            this.label1.Text = "Celular:";
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
            this.txtEmail.Location = new System.Drawing.Point(99, 106);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(353, 41);
            this.txtEmail.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 28);
            this.label3.TabIndex = 46;
            this.label3.Text = "Email:";
            // 
            // txtCpf
            // 
            this.txtCpf.BorderColor = System.Drawing.Color.Silver;
            this.txtCpf.BorderRadius = 10;
            this.txtCpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpf.DefaultText = "";
            this.txtCpf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCpf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCpf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCpf.DisabledState.Parent = this.txtCpf;
            this.txtCpf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCpf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCpf.FocusedState.Parent = this.txtCpf;
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCpf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCpf.HoverState.Parent = this.txtCpf;
            this.txtCpf.Location = new System.Drawing.Point(576, 106);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PasswordChar = '\0';
            this.txtCpf.PlaceholderText = "";
            this.txtCpf.SelectedText = "";
            this.txtCpf.ShadowDecoration.Parent = this.txtCpf;
            this.txtCpf.Size = new System.Drawing.Size(159, 41);
            this.txtCpf.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 28);
            this.label4.TabIndex = 48;
            this.label4.Text = "Cpf:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderColor = System.Drawing.Color.Silver;
            this.txtEndereco.BorderRadius = 10;
            this.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndereco.DefaultText = "";
            this.txtEndereco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEndereco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEndereco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndereco.DisabledState.Parent = this.txtEndereco;
            this.txtEndereco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndereco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndereco.FocusedState.Parent = this.txtEndereco;
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEndereco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndereco.HoverState.Parent = this.txtEndereco;
            this.txtEndereco.Location = new System.Drawing.Point(112, 159);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.PlaceholderText = "";
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.ShadowDecoration.Parent = this.txtEndereco;
            this.txtEndereco.Size = new System.Drawing.Size(623, 41);
            this.txtEndereco.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 166);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 28);
            this.label6.TabIndex = 50;
            this.label6.Text = "Endereço:";
            // 
            // txtFoto
            // 
            this.txtFoto.BorderColor = System.Drawing.Color.Silver;
            this.txtFoto.BorderRadius = 10;
            this.txtFoto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFoto.DefaultText = "";
            this.txtFoto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFoto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFoto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFoto.DisabledState.Parent = this.txtFoto;
            this.txtFoto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFoto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFoto.FocusedState.Parent = this.txtFoto;
            this.txtFoto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFoto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFoto.HoverState.Parent = this.txtFoto;
            this.txtFoto.Location = new System.Drawing.Point(99, 208);
            this.txtFoto.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.PasswordChar = '\0';
            this.txtFoto.PlaceholderText = "";
            this.txtFoto.SelectedText = "";
            this.txtFoto.ShadowDecoration.Parent = this.txtFoto;
            this.txtFoto.Size = new System.Drawing.Size(636, 41);
            this.txtFoto.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 215);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 28);
            this.label7.TabIndex = 52;
            this.label7.Text = "Foto:";
            // 
            // pbCliente
            // 
            this.pbCliente.Image = ((System.Drawing.Image)(resources.GetObject("pbCliente.Image")));
            this.pbCliente.Location = new System.Drawing.Point(777, 12);
            this.pbCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCliente.Name = "pbCliente";
            this.pbCliente.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbCliente.ShadowDecoration.Parent = this.pbCliente;
            this.pbCliente.Size = new System.Drawing.Size(199, 196);
            this.pbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCliente.TabIndex = 53;
            this.pbCliente.TabStop = false;
            // 
            // button_upload
            // 
            this.button_upload.BackColor = System.Drawing.Color.Green;
            this.button_upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_upload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.ForeColor = System.Drawing.Color.White;
            this.button_upload.Location = new System.Drawing.Point(800, 215);
            this.button_upload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(133, 42);
            this.button_upload.TabIndex = 54;
            this.button_upload.Text = "Upload ";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 615);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.pbCliente);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnAlterar;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2Button btnNovo;
        private Guna.UI2.WinForms.Guna2GroupBox GroupBox;
        private Guna.UI2.WinForms.Guna2DataGridView dgvfunc;
        private Guna.UI2.WinForms.Guna2TextBox txtBusca;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtCelular;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtCpf;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtEndereco;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtFoto;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbCliente;
        private System.Windows.Forms.Button button_upload;
    }
}