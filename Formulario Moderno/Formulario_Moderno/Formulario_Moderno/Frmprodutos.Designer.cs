namespace Formulario_Moderno
{
    partial class Frmprodutos
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
            System.Windows.Forms.Label nome_produtoLabel;
            System.Windows.Forms.Label cod_barraLabel;
            System.Windows.Forms.Label unidadeLabel;
            System.Windows.Forms.Label estoqueLabel;
            System.Windows.Forms.Label min_estoqueLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mercadinhoDataSet = new Formulario_Moderno.mercadinhoDataSet();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new Formulario_Moderno.mercadinhoDataSetTableAdapters.produtoTableAdapter();
            this.tableAdapterManager = new Formulario_Moderno.mercadinhoDataSetTableAdapters.TableAdapterManager();
            this.produtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.produtoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.nome_produtoTextBox = new System.Windows.Forms.TextBox();
            this.cod_barraTextBox = new System.Windows.Forms.TextBox();
            this.unidadeTextBox = new System.Windows.Forms.TextBox();
            this.estoqueTextBox = new System.Windows.Forms.TextBox();
            this.min_estoqueTextBox = new System.Windows.Forms.TextBox();
            this.produtoBunifuDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            codigoLabel = new System.Windows.Forms.Label();
            nome_produtoLabel = new System.Windows.Forms.Label();
            cod_barraLabel = new System.Windows.Forms.Label();
            unidadeLabel = new System.Windows.Forms.Label();
            estoqueLabel = new System.Windows.Forms.Label();
            min_estoqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mercadinhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).BeginInit();
            this.produtoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBunifuDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(22, 57);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(42, 13);
            codigoLabel.TabIndex = 1;
            codigoLabel.Text = "codigo:";
            // 
            // nome_produtoLabel
            // 
            nome_produtoLabel.AutoSize = true;
            nome_produtoLabel.Location = new System.Drawing.Point(22, 83);
            nome_produtoLabel.Name = "nome_produtoLabel";
            nome_produtoLabel.Size = new System.Drawing.Size(75, 13);
            nome_produtoLabel.TabIndex = 3;
            nome_produtoLabel.Text = "nome produto:";
            // 
            // cod_barraLabel
            // 
            cod_barraLabel.AutoSize = true;
            cod_barraLabel.Location = new System.Drawing.Point(246, 60);
            cod_barraLabel.Name = "cod_barraLabel";
            cod_barraLabel.Size = new System.Drawing.Size(55, 13);
            cod_barraLabel.TabIndex = 5;
            cod_barraLabel.Text = "cod barra:";
            // 
            // unidadeLabel
            // 
            unidadeLabel.AutoSize = true;
            unidadeLabel.Location = new System.Drawing.Point(352, 86);
            unidadeLabel.Name = "unidadeLabel";
            unidadeLabel.Size = new System.Drawing.Size(48, 13);
            unidadeLabel.TabIndex = 7;
            unidadeLabel.Text = "unidade:";
            // 
            // estoqueLabel
            // 
            estoqueLabel.AutoSize = true;
            estoqueLabel.Location = new System.Drawing.Point(541, 89);
            estoqueLabel.Name = "estoqueLabel";
            estoqueLabel.Size = new System.Drawing.Size(48, 13);
            estoqueLabel.TabIndex = 9;
            estoqueLabel.Text = "estoque:";
            // 
            // min_estoqueLabel
            // 
            min_estoqueLabel.AutoSize = true;
            min_estoqueLabel.Location = new System.Drawing.Point(741, 92);
            min_estoqueLabel.Name = "min_estoqueLabel";
            min_estoqueLabel.Size = new System.Drawing.Size(67, 13);
            min_estoqueLabel.TabIndex = 11;
            min_estoqueLabel.Text = "min estoque:";
            // 
            // mercadinhoDataSet
            // 
            this.mercadinhoDataSet.DataSetName = "mercadinhoDataSet";
            this.mercadinhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.mercadinhoDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.compraTableAdapter = null;
            this.tableAdapterManager.fornecedorTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Formulario_Moderno.mercadinhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // produtoBindingNavigator
            // 
            this.produtoBindingNavigator.AddNewItem = null;
            this.produtoBindingNavigator.BindingSource = this.produtoBindingSource;
            this.produtoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produtoBindingNavigator.DeleteItem = null;
            this.produtoBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.produtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produtoBindingNavigatorSaveItem,
            this.btnCancelar,
            this.btnEditar});
            this.produtoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produtoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produtoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produtoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produtoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produtoBindingNavigator.Name = "produtoBindingNavigator";
            this.produtoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produtoBindingNavigator.Size = new System.Drawing.Size(1036, 39);
            this.produtoBindingNavigator.TabIndex = 0;
            this.produtoBindingNavigator.Text = "bindingNavigator1";
            this.produtoBindingNavigator.RefreshItems += new System.EventHandler(this.produtoBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 36);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::Formulario_Moderno.Properties.Resources.first;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::Formulario_Moderno.Properties.Resources._previous_icon;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::Formulario_Moderno.Properties.Resources.previous_icon___Copia;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::Formulario_Moderno.Properties.Resources.first___Copia;
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
            this.bindingNavigatorAddNewItem.Image = global::Formulario_Moderno.Properties.Resources.new_copy_64px;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::Formulario_Moderno.Properties.Resources.delete__4_;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // produtoBindingNavigatorSaveItem
            // 
            this.produtoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produtoBindingNavigatorSaveItem.Image = global::Formulario_Moderno.Properties.Resources.save_64px;
            this.produtoBindingNavigatorSaveItem.Name = "produtoBindingNavigatorSaveItem";
            this.produtoBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.produtoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.produtoBindingNavigatorSaveItem.Click += new System.EventHandler(this.produtoBindingNavigatorSaveItem_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = global::Formulario_Moderno.Properties.Resources._7952174_box_remove_deny_removal_cancel_icon;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(36, 36);
            this.btnCancelar.Text = "toolStripButton1";
            this.btnCancelar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::Formulario_Moderno.Properties.Resources.edit_prop_64px;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(36, 36);
            this.btnEditar.Text = "toolStripButton2";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(103, 54);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextBox.TabIndex = 2;
            // 
            // nome_produtoTextBox
            // 
            this.nome_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "nome_produto", true));
            this.nome_produtoTextBox.Location = new System.Drawing.Point(103, 80);
            this.nome_produtoTextBox.Name = "nome_produtoTextBox";
            this.nome_produtoTextBox.Size = new System.Drawing.Size(212, 20);
            this.nome_produtoTextBox.TabIndex = 4;
            // 
            // cod_barraTextBox
            // 
            this.cod_barraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "cod_barra", true));
            this.cod_barraTextBox.Location = new System.Drawing.Point(327, 57);
            this.cod_barraTextBox.Name = "cod_barraTextBox";
            this.cod_barraTextBox.Size = new System.Drawing.Size(206, 20);
            this.cod_barraTextBox.TabIndex = 6;
            // 
            // unidadeTextBox
            // 
            this.unidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "unidade", true));
            this.unidadeTextBox.Location = new System.Drawing.Point(433, 83);
            this.unidadeTextBox.Name = "unidadeTextBox";
            this.unidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.unidadeTextBox.TabIndex = 8;
            // 
            // estoqueTextBox
            // 
            this.estoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "estoque", true));
            this.estoqueTextBox.Location = new System.Drawing.Point(622, 86);
            this.estoqueTextBox.Name = "estoqueTextBox";
            this.estoqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.estoqueTextBox.TabIndex = 10;
            // 
            // min_estoqueTextBox
            // 
            this.min_estoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "min_estoque", true));
            this.min_estoqueTextBox.Location = new System.Drawing.Point(822, 89);
            this.min_estoqueTextBox.Name = "min_estoqueTextBox";
            this.min_estoqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.min_estoqueTextBox.TabIndex = 12;
            // 
            // produtoBunifuDataGridView
            // 
            this.produtoBunifuDataGridView.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.produtoBunifuDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.produtoBunifuDataGridView.AutoGenerateColumns = false;
            this.produtoBunifuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.produtoBunifuDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.produtoBunifuDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.produtoBunifuDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produtoBunifuDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.produtoBunifuDataGridView.ColumnHeadersHeight = 40;
            this.produtoBunifuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.produtoBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.produtoBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.produtoBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.produtoBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.produtoBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.produtoBunifuDataGridView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.produtoBunifuDataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.produtoBunifuDataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.produtoBunifuDataGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.produtoBunifuDataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.produtoBunifuDataGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.produtoBunifuDataGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.produtoBunifuDataGridView.CurrentTheme.Name = null;
            this.produtoBunifuDataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.produtoBunifuDataGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.produtoBunifuDataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.produtoBunifuDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.produtoBunifuDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.produtoBunifuDataGridView.DataSource = this.produtoBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produtoBunifuDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.produtoBunifuDataGridView.EnableHeadersVisualStyles = false;
            this.produtoBunifuDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.produtoBunifuDataGridView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.produtoBunifuDataGridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.produtoBunifuDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.produtoBunifuDataGridView.Location = new System.Drawing.Point(25, 178);
            this.produtoBunifuDataGridView.Name = "produtoBunifuDataGridView";
            this.produtoBunifuDataGridView.RowHeadersVisible = false;
            this.produtoBunifuDataGridView.RowTemplate.Height = 40;
            this.produtoBunifuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produtoBunifuDataGridView.Size = new System.Drawing.Size(897, 220);
            this.produtoBunifuDataGridView.TabIndex = 13;
            this.produtoBunifuDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_produto";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome_produto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cod_barra";
            this.dataGridViewTextBoxColumn3.HeaderText = "cod_barra";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "unidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "unidade";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "estoque";
            this.dataGridViewTextBoxColumn5.HeaderText = "estoque";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "min_estoque";
            this.dataGridViewTextBoxColumn6.HeaderText = "min_estoque";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Frmprodutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 631);
            this.Controls.Add(this.produtoBunifuDataGridView);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(nome_produtoLabel);
            this.Controls.Add(this.nome_produtoTextBox);
            this.Controls.Add(cod_barraLabel);
            this.Controls.Add(this.cod_barraTextBox);
            this.Controls.Add(unidadeLabel);
            this.Controls.Add(this.unidadeTextBox);
            this.Controls.Add(estoqueLabel);
            this.Controls.Add(this.estoqueTextBox);
            this.Controls.Add(min_estoqueLabel);
            this.Controls.Add(this.min_estoqueTextBox);
            this.Controls.Add(this.produtoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmprodutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "produtos";
            this.Load += new System.EventHandler(this.Frmprodutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mercadinhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).EndInit();
            this.produtoBindingNavigator.ResumeLayout(false);
            this.produtoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBunifuDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mercadinhoDataSet mercadinhoDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private mercadinhoDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private mercadinhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produtoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton produtoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox nome_produtoTextBox;
        private System.Windows.Forms.TextBox cod_barraTextBox;
        private System.Windows.Forms.TextBox unidadeTextBox;
        private System.Windows.Forms.TextBox estoqueTextBox;
        private System.Windows.Forms.TextBox min_estoqueTextBox;
        private Bunifu.UI.WinForms.BunifuDataGridView produtoBunifuDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnEditar;
    }
}