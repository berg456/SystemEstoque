namespace Formulario_Moderno
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label nome_clienteLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label ufLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label cpf_cnpjLabel;
            System.Windows.Forms.Label rg_ieLabel;
            System.Windows.Forms.Label data_cadastroLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label obsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mercadinhoDataSet = new Formulario_Moderno.mercadinhoDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Formulario_Moderno.mercadinhoDataSetTableAdapters.clienteTableAdapter();
            this.tableAdapterManager = new Formulario_Moderno.mercadinhoDataSetTableAdapters.TableAdapterManager();
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.codigoBunifuCustomTextbox = new Bunifu.Framework.BunifuCustomTextbox();
            this.enderecoBunifuCustomTextbox = new Bunifu.Framework.BunifuCustomTextbox();
            this.bairroBunifuCustomTextbox = new Bunifu.Framework.BunifuCustomTextbox();
            this.cidadeBunifuCustomTextbox = new Bunifu.Framework.BunifuCustomTextbox();
            this.cepBunifuCustomTextbox = new Bunifu.Framework.BunifuCustomTextbox();
            this.numeroBunifuCustomTextbox = new Bunifu.Framework.BunifuCustomTextbox();
            this.ufComboBox = new System.Windows.Forms.ComboBox();
            this.celularBunifuCustomTextbox = new Bunifu.Framework.BunifuCustomTextbox();
            this.cpf_cnpjBunifuCustomTextbox = new Bunifu.Framework.BunifuCustomTextbox();
            this.rg_ieBunifuCustomTextbox = new Bunifu.Framework.BunifuCustomTextbox();
            this.data_cadastroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailBunifuCustomTextbox = new Bunifu.Framework.BunifuCustomTextbox();
            this.obsBunifuCustomTextbox = new Bunifu.Framework.BunifuCustomTextbox();
            this.clienteGunaDataGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_clienteBunifuCustomTextbox = new Bunifu.Framework.BunifuCustomTextbox();
            codigoLabel = new System.Windows.Forms.Label();
            nome_clienteLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            ufLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            cpf_cnpjLabel = new System.Windows.Forms.Label();
            rg_ieLabel = new System.Windows.Forms.Label();
            data_cadastroLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mercadinhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteGunaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(57, 54);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(42, 13);
            codigoLabel.TabIndex = 1;
            codigoLabel.Text = "codigo:";
            // 
            // nome_clienteLabel
            // 
            nome_clienteLabel.AutoSize = true;
            nome_clienteLabel.Location = new System.Drawing.Point(29, 89);
            nome_clienteLabel.Name = "nome_clienteLabel";
            nome_clienteLabel.Size = new System.Drawing.Size(70, 13);
            nome_clienteLabel.TabIndex = 3;
            nome_clienteLabel.Text = "nome cliente:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(435, 89);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(55, 13);
            enderecoLabel.TabIndex = 5;
            enderecoLabel.Text = "endereco:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(63, 124);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(36, 13);
            bairroLabel.TabIndex = 7;
            bairroLabel.Text = "bairro:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(399, 131);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(42, 13);
            cidadeLabel.TabIndex = 9;
            cidadeLabel.Text = "cidade:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(701, 127);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(28, 13);
            cepLabel.TabIndex = 11;
            cepLabel.Text = "cep:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(790, 92);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(45, 13);
            numeroLabel.TabIndex = 13;
            numeroLabel.Text = "numero:";
            // 
            // ufLabel
            // 
            ufLabel.AutoSize = true;
            ufLabel.Location = new System.Drawing.Point(814, 130);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new System.Drawing.Size(19, 13);
            ufLabel.TabIndex = 15;
            ufLabel.Text = "uf:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(58, 161);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(41, 13);
            celularLabel.TabIndex = 17;
            celularLabel.Text = "celular:";
            // 
            // cpf_cnpjLabel
            // 
            cpf_cnpjLabel.AutoSize = true;
            cpf_cnpjLabel.Location = new System.Drawing.Point(225, 164);
            cpf_cnpjLabel.Name = "cpf_cnpjLabel";
            cpf_cnpjLabel.Size = new System.Drawing.Size(48, 13);
            cpf_cnpjLabel.TabIndex = 19;
            cpf_cnpjLabel.Text = "cpf cnpj:";
            // 
            // rg_ieLabel
            // 
            rg_ieLabel.AutoSize = true;
            rg_ieLabel.Location = new System.Drawing.Point(390, 167);
            rg_ieLabel.Name = "rg_ieLabel";
            rg_ieLabel.Size = new System.Drawing.Size(30, 13);
            rg_ieLabel.TabIndex = 21;
            rg_ieLabel.Text = "rg ie:";
            // 
            // data_cadastroLabel
            // 
            data_cadastroLabel.AutoSize = true;
            data_cadastroLabel.Location = new System.Drawing.Point(563, 171);
            data_cadastroLabel.Name = "data_cadastroLabel";
            data_cadastroLabel.Size = new System.Drawing.Size(75, 13);
            data_cadastroLabel.TabIndex = 23;
            data_cadastroLabel.Text = "data cadastro:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(65, 212);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 25;
            emailLabel.Text = "email:";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Location = new System.Drawing.Point(393, 215);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(27, 13);
            obsLabel.TabIndex = 27;
            obsLabel.Text = "obs:";
            // 
            // mercadinhoDataSet
            // 
            this.mercadinhoDataSet.DataSetName = "mercadinhoDataSet";
            this.mercadinhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.mercadinhoDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.compraTableAdapter = null;
            this.tableAdapterManager.fornecedorTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Formulario_Moderno.mercadinhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = null;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = null;
            this.clienteBindingNavigator.DeleteItem = null;
            this.clienteBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clienteBindingNavigatorSaveItem,
            this.btnCancelar,
            this.btnEditar});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(934, 39);
            this.clienteBindingNavigator.TabIndex = 0;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 36);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteBindingNavigatorSaveItem.Image")));
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.clienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click_2);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(36, 36);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.ToolTipText = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(36, 36);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.ToolTipText = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // codigoBunifuCustomTextbox
            // 
            this.codigoBunifuCustomTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.codigoBunifuCustomTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "codigo", true));
            this.codigoBunifuCustomTextbox.Location = new System.Drawing.Point(105, 51);
            this.codigoBunifuCustomTextbox.Name = "codigoBunifuCustomTextbox";
            this.codigoBunifuCustomTextbox.Size = new System.Drawing.Size(100, 20);
            this.codigoBunifuCustomTextbox.TabIndex = 2;
            // 
            // enderecoBunifuCustomTextbox
            // 
            this.enderecoBunifuCustomTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.enderecoBunifuCustomTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "endereco", true));
            this.enderecoBunifuCustomTextbox.Location = new System.Drawing.Point(496, 86);
            this.enderecoBunifuCustomTextbox.Name = "enderecoBunifuCustomTextbox";
            this.enderecoBunifuCustomTextbox.Size = new System.Drawing.Size(269, 20);
            this.enderecoBunifuCustomTextbox.TabIndex = 6;
            // 
            // bairroBunifuCustomTextbox
            // 
            this.bairroBunifuCustomTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.bairroBunifuCustomTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "bairro", true));
            this.bairroBunifuCustomTextbox.Location = new System.Drawing.Point(105, 121);
            this.bairroBunifuCustomTextbox.Name = "bairroBunifuCustomTextbox";
            this.bairroBunifuCustomTextbox.Size = new System.Drawing.Size(274, 20);
            this.bairroBunifuCustomTextbox.TabIndex = 8;
            // 
            // cidadeBunifuCustomTextbox
            // 
            this.cidadeBunifuCustomTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.cidadeBunifuCustomTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cidade", true));
            this.cidadeBunifuCustomTextbox.Location = new System.Drawing.Point(465, 128);
            this.cidadeBunifuCustomTextbox.Name = "cidadeBunifuCustomTextbox";
            this.cidadeBunifuCustomTextbox.Size = new System.Drawing.Size(230, 20);
            this.cidadeBunifuCustomTextbox.TabIndex = 10;
            // 
            // cepBunifuCustomTextbox
            // 
            this.cepBunifuCustomTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.cepBunifuCustomTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cep", true));
            this.cepBunifuCustomTextbox.Location = new System.Drawing.Point(735, 124);
            this.cepBunifuCustomTextbox.Name = "cepBunifuCustomTextbox";
            this.cepBunifuCustomTextbox.Size = new System.Drawing.Size(71, 20);
            this.cepBunifuCustomTextbox.TabIndex = 12;
            // 
            // numeroBunifuCustomTextbox
            // 
            this.numeroBunifuCustomTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.numeroBunifuCustomTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "numero", true));
            this.numeroBunifuCustomTextbox.Location = new System.Drawing.Point(841, 89);
            this.numeroBunifuCustomTextbox.Name = "numeroBunifuCustomTextbox";
            this.numeroBunifuCustomTextbox.Size = new System.Drawing.Size(63, 20);
            this.numeroBunifuCustomTextbox.TabIndex = 14;
            // 
            // ufComboBox
            // 
            this.ufComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "uf", true));
            this.ufComboBox.FormattingEnabled = true;
            this.ufComboBox.Items.AddRange(new object[] {
            "AC\t",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
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
            "TO"});
            this.ufComboBox.Location = new System.Drawing.Point(839, 127);
            this.ufComboBox.Name = "ufComboBox";
            this.ufComboBox.Size = new System.Drawing.Size(65, 21);
            this.ufComboBox.TabIndex = 16;
            // 
            // celularBunifuCustomTextbox
            // 
            this.celularBunifuCustomTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.celularBunifuCustomTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "celular", true));
            this.celularBunifuCustomTextbox.Location = new System.Drawing.Point(105, 158);
            this.celularBunifuCustomTextbox.Name = "celularBunifuCustomTextbox";
            this.celularBunifuCustomTextbox.Size = new System.Drawing.Size(100, 20);
            this.celularBunifuCustomTextbox.TabIndex = 18;
            // 
            // cpf_cnpjBunifuCustomTextbox
            // 
            this.cpf_cnpjBunifuCustomTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.cpf_cnpjBunifuCustomTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cpf_cnpj", true));
            this.cpf_cnpjBunifuCustomTextbox.Location = new System.Drawing.Point(279, 161);
            this.cpf_cnpjBunifuCustomTextbox.Name = "cpf_cnpjBunifuCustomTextbox";
            this.cpf_cnpjBunifuCustomTextbox.Size = new System.Drawing.Size(100, 20);
            this.cpf_cnpjBunifuCustomTextbox.TabIndex = 20;
            // 
            // rg_ieBunifuCustomTextbox
            // 
            this.rg_ieBunifuCustomTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.rg_ieBunifuCustomTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "rg_ie", true));
            this.rg_ieBunifuCustomTextbox.Location = new System.Drawing.Point(426, 164);
            this.rg_ieBunifuCustomTextbox.Name = "rg_ieBunifuCustomTextbox";
            this.rg_ieBunifuCustomTextbox.Size = new System.Drawing.Size(100, 20);
            this.rg_ieBunifuCustomTextbox.TabIndex = 22;
            // 
            // data_cadastroDateTimePicker
            // 
            this.data_cadastroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "data_cadastro", true));
            this.data_cadastroDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_cadastroDateTimePicker.Location = new System.Drawing.Point(644, 167);
            this.data_cadastroDateTimePicker.Name = "data_cadastroDateTimePicker";
            this.data_cadastroDateTimePicker.Size = new System.Drawing.Size(87, 20);
            this.data_cadastroDateTimePicker.TabIndex = 24;
            // 
            // emailBunifuCustomTextbox
            // 
            this.emailBunifuCustomTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.emailBunifuCustomTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "email", true));
            this.emailBunifuCustomTextbox.Location = new System.Drawing.Point(105, 209);
            this.emailBunifuCustomTextbox.Name = "emailBunifuCustomTextbox";
            this.emailBunifuCustomTextbox.Size = new System.Drawing.Size(274, 20);
            this.emailBunifuCustomTextbox.TabIndex = 26;
            // 
            // obsBunifuCustomTextbox
            // 
            this.obsBunifuCustomTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.obsBunifuCustomTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "obs", true));
            this.obsBunifuCustomTextbox.Location = new System.Drawing.Point(426, 212);
            this.obsBunifuCustomTextbox.Name = "obsBunifuCustomTextbox";
            this.obsBunifuCustomTextbox.Size = new System.Drawing.Size(303, 20);
            this.obsBunifuCustomTextbox.TabIndex = 28;
            // 
            // clienteGunaDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.clienteGunaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.clienteGunaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clienteGunaDataGridView.AutoGenerateColumns = false;
            this.clienteGunaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clienteGunaDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.clienteGunaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clienteGunaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.clienteGunaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clienteGunaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.clienteGunaDataGridView.ColumnHeadersHeight = 40;
            this.clienteGunaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.clienteGunaDataGridView.DataSource = this.clienteBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clienteGunaDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.clienteGunaDataGridView.EnableHeadersVisualStyles = false;
            this.clienteGunaDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.clienteGunaDataGridView.Location = new System.Drawing.Point(12, 235);
            this.clienteGunaDataGridView.Name = "clienteGunaDataGridView";
            this.clienteGunaDataGridView.RowHeadersVisible = false;
            this.clienteGunaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clienteGunaDataGridView.Size = new System.Drawing.Size(896, 220);
            this.clienteGunaDataGridView.TabIndex = 29;
            this.clienteGunaDataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.clienteGunaDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.clienteGunaDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.clienteGunaDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.clienteGunaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.clienteGunaDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.clienteGunaDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.clienteGunaDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.clienteGunaDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.clienteGunaDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.clienteGunaDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.clienteGunaDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.clienteGunaDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.clienteGunaDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.clienteGunaDataGridView.ThemeStyle.ReadOnly = false;
            this.clienteGunaDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.clienteGunaDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.clienteGunaDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.clienteGunaDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.clienteGunaDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.clienteGunaDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.clienteGunaDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "endereco";
            this.dataGridViewTextBoxColumn3.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "bairro";
            this.dataGridViewTextBoxColumn4.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cidade";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cep";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cep";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "numero";
            this.dataGridViewTextBoxColumn7.HeaderText = "Número";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "uf";
            this.dataGridViewTextBoxColumn8.HeaderText = "UF";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "celular";
            this.dataGridViewTextBoxColumn9.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "cpf_cnpj";
            this.dataGridViewTextBoxColumn10.HeaderText = "Cpf_Cnpj";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "rg_ie";
            this.dataGridViewTextBoxColumn11.HeaderText = "Rg_Ie";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "data_cadastro";
            this.dataGridViewTextBoxColumn12.HeaderText = "Data de Cadastro";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn13.HeaderText = "Email";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "obs";
            this.dataGridViewTextBoxColumn14.HeaderText = "Obs";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // nome_clienteBunifuCustomTextbox
            // 
            this.nome_clienteBunifuCustomTextbox.BorderColor = System.Drawing.Color.SeaGreen;
            this.nome_clienteBunifuCustomTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "nome_cliente", true));
            this.nome_clienteBunifuCustomTextbox.Location = new System.Drawing.Point(105, 86);
            this.nome_clienteBunifuCustomTextbox.Name = "nome_clienteBunifuCustomTextbox";
            this.nome_clienteBunifuCustomTextbox.Size = new System.Drawing.Size(315, 20);
            this.nome_clienteBunifuCustomTextbox.TabIndex = 4;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 553);
            this.Controls.Add(this.clienteGunaDataGridView);
            this.Controls.Add(obsLabel);
            this.Controls.Add(this.obsBunifuCustomTextbox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailBunifuCustomTextbox);
            this.Controls.Add(data_cadastroLabel);
            this.Controls.Add(this.data_cadastroDateTimePicker);
            this.Controls.Add(rg_ieLabel);
            this.Controls.Add(this.rg_ieBunifuCustomTextbox);
            this.Controls.Add(cpf_cnpjLabel);
            this.Controls.Add(this.cpf_cnpjBunifuCustomTextbox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularBunifuCustomTextbox);
            this.Controls.Add(ufLabel);
            this.Controls.Add(this.ufComboBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroBunifuCustomTextbox);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.cepBunifuCustomTextbox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeBunifuCustomTextbox);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.bairroBunifuCustomTextbox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoBunifuCustomTextbox);
            this.Controls.Add(nome_clienteLabel);
            this.Controls.Add(this.nome_clienteBunifuCustomTextbox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoBunifuCustomTextbox);
            this.Controls.Add(this.clienteBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mercadinhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteGunaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mercadinhoDataSet mercadinhoDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private mercadinhoDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private mercadinhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private Bunifu.Framework.BunifuCustomTextbox codigoBunifuCustomTextbox;
        private Bunifu.Framework.BunifuCustomTextbox enderecoBunifuCustomTextbox;
        private Bunifu.Framework.BunifuCustomTextbox bairroBunifuCustomTextbox;
        private Bunifu.Framework.BunifuCustomTextbox cidadeBunifuCustomTextbox;
        private Bunifu.Framework.BunifuCustomTextbox cepBunifuCustomTextbox;
        private Bunifu.Framework.BunifuCustomTextbox numeroBunifuCustomTextbox;
        private System.Windows.Forms.ComboBox ufComboBox;
        private Bunifu.Framework.BunifuCustomTextbox celularBunifuCustomTextbox;
        private Bunifu.Framework.BunifuCustomTextbox cpf_cnpjBunifuCustomTextbox;
        private Bunifu.Framework.BunifuCustomTextbox rg_ieBunifuCustomTextbox;
        private System.Windows.Forms.DateTimePicker data_cadastroDateTimePicker;
        private Bunifu.Framework.BunifuCustomTextbox emailBunifuCustomTextbox;
        private Bunifu.Framework.BunifuCustomTextbox obsBunifuCustomTextbox;
        private Guna.UI.WinForms.GunaDataGridView clienteGunaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private Bunifu.Framework.BunifuCustomTextbox nome_clienteBunifuCustomTextbox;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnEditar;
    }
}