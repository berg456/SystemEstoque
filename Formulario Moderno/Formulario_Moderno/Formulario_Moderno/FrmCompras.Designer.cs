namespace Formulario_Moderno
{
    partial class FrmCompras
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
            System.Windows.Forms.Label fornecedor_codigoLabel;
            System.Windows.Forms.Label pedidoLabel;
            System.Windows.Forms.Label data_pedidoLabel;
            System.Windows.Forms.Label valor_pedidoLabel;
            System.Windows.Forms.Label data_compraLabel;
            System.Windows.Forms.Label valor_compraLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mercadinhoDataSet = new Formulario_Moderno.mercadinhoDataSet();
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraTableAdapter = new Formulario_Moderno.mercadinhoDataSetTableAdapters.compraTableAdapter();
            this.tableAdapterManager = new Formulario_Moderno.mercadinhoDataSetTableAdapters.TableAdapterManager();
            this.fornecedorTableAdapter = new Formulario_Moderno.mercadinhoDataSetTableAdapters.fornecedorTableAdapter();
            this.compraBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.compraBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.fornecedor_codigoComboBox = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTextBox = new System.Windows.Forms.TextBox();
            this.data_pedidoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valor_pedidoTextBox = new System.Windows.Forms.TextBox();
            this.data_compraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valor_compraTextBox = new System.Windows.Forms.TextBox();
            this.compraBunifuDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            codigoLabel = new System.Windows.Forms.Label();
            fornecedor_codigoLabel = new System.Windows.Forms.Label();
            pedidoLabel = new System.Windows.Forms.Label();
            data_pedidoLabel = new System.Windows.Forms.Label();
            valor_pedidoLabel = new System.Windows.Forms.Label();
            data_compraLabel = new System.Windows.Forms.Label();
            valor_compraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mercadinhoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingNavigator)).BeginInit();
            this.compraBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBunifuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(25, 61);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(42, 13);
            codigoLabel.TabIndex = 1;
            codigoLabel.Text = "codigo:";
            // 
            // fornecedor_codigoLabel
            // 
            fornecedor_codigoLabel.AutoSize = true;
            fornecedor_codigoLabel.Location = new System.Drawing.Point(25, 87);
            fornecedor_codigoLabel.Name = "fornecedor_codigoLabel";
            fornecedor_codigoLabel.Size = new System.Drawing.Size(96, 13);
            fornecedor_codigoLabel.TabIndex = 3;
            fornecedor_codigoLabel.Text = "fornecedor codigo:";
            // 
            // pedidoLabel
            // 
            pedidoLabel.AutoSize = true;
            pedidoLabel.Location = new System.Drawing.Point(351, 90);
            pedidoLabel.Name = "pedidoLabel";
            pedidoLabel.Size = new System.Drawing.Size(42, 13);
            pedidoLabel.TabIndex = 5;
            pedidoLabel.Text = "pedido:";
            // 
            // data_pedidoLabel
            // 
            data_pedidoLabel.AutoSize = true;
            data_pedidoLabel.Location = new System.Drawing.Point(617, 91);
            data_pedidoLabel.Name = "data_pedidoLabel";
            data_pedidoLabel.Size = new System.Drawing.Size(66, 13);
            data_pedidoLabel.TabIndex = 7;
            data_pedidoLabel.Text = "data pedido:";
            // 
            // valor_pedidoLabel
            // 
            valor_pedidoLabel.AutoSize = true;
            valor_pedidoLabel.Location = new System.Drawing.Point(25, 128);
            valor_pedidoLabel.Name = "valor_pedidoLabel";
            valor_pedidoLabel.Size = new System.Drawing.Size(68, 13);
            valor_pedidoLabel.TabIndex = 9;
            valor_pedidoLabel.Text = "valor pedido:";
            // 
            // data_compraLabel
            // 
            data_compraLabel.AutoSize = true;
            data_compraLabel.Location = new System.Drawing.Point(333, 133);
            data_compraLabel.Name = "data_compraLabel";
            data_compraLabel.Size = new System.Drawing.Size(69, 13);
            data_compraLabel.TabIndex = 11;
            data_compraLabel.Text = "data compra:";
            // 
            // valor_compraLabel
            // 
            valor_compraLabel.AutoSize = true;
            valor_compraLabel.Location = new System.Drawing.Point(634, 135);
            valor_compraLabel.Name = "valor_compraLabel";
            valor_compraLabel.Size = new System.Drawing.Size(71, 13);
            valor_compraLabel.TabIndex = 13;
            valor_compraLabel.Text = "valor compra:";
            // 
            // mercadinhoDataSet
            // 
            this.mercadinhoDataSet.DataSetName = "mercadinhoDataSet";
            this.mercadinhoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "compra";
            this.compraBindingSource.DataSource = this.mercadinhoDataSet;
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.compraTableAdapter = this.compraTableAdapter;
            this.tableAdapterManager.fornecedorTableAdapter = this.fornecedorTableAdapter;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Formulario_Moderno.mercadinhoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // compraBindingNavigator
            // 
            this.compraBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.compraBindingNavigator.BindingSource = this.compraBindingSource;
            this.compraBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.compraBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.compraBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.compraBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.compraBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.toolStripButton2});
            this.compraBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.compraBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.compraBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.compraBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.compraBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.compraBindingNavigator.Name = "compraBindingNavigator";
            this.compraBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.compraBindingNavigator.Size = new System.Drawing.Size(849, 39);
            this.compraBindingNavigator.TabIndex = 0;
            this.compraBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::Formulario_Moderno.Properties.Resources.new_copy_64px;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 36);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::Formulario_Moderno.Properties.Resources.delete__4_;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
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
            // compraBindingNavigatorSaveItem
            // 
            this.compraBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.compraBindingNavigatorSaveItem.Image = global::Formulario_Moderno.Properties.Resources.save_64px;
            this.compraBindingNavigatorSaveItem.Name = "compraBindingNavigatorSaveItem";
            this.compraBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.compraBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.compraBindingNavigatorSaveItem.Click += new System.EventHandler(this.compraBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Formulario_Moderno.Properties.Resources._7952174_box_remove_deny_removal_cancel_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "Cancelar";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Formulario_Moderno.Properties.Resources.edit_prop_64px;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "Editar";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(127, 58);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(65, 20);
            this.codigoTextBox.TabIndex = 2;
            // 
            // fornecedor_codigoComboBox
            // 
            this.fornecedor_codigoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.compraBindingSource, "fornecedor_codigo", true));
            this.fornecedor_codigoComboBox.DataSource = this.fornecedorBindingSource1;
            this.fornecedor_codigoComboBox.DisplayMember = "nome_fornecedor";
            this.fornecedor_codigoComboBox.FormattingEnabled = true;
            this.fornecedor_codigoComboBox.Location = new System.Drawing.Point(127, 84);
            this.fornecedor_codigoComboBox.Name = "fornecedor_codigoComboBox";
            this.fornecedor_codigoComboBox.Size = new System.Drawing.Size(200, 21);
            this.fornecedor_codigoComboBox.TabIndex = 4;
            this.fornecedor_codigoComboBox.ValueMember = "codigo";
            // 
            // fornecedorBindingSource1
            // 
            this.fornecedorBindingSource1.DataMember = "fornecedor";
            this.fornecedorBindingSource1.DataSource = this.mercadinhoDataSet;
            // 
            // pedidoTextBox
            // 
            this.pedidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "pedido", true));
            this.pedidoTextBox.Location = new System.Drawing.Point(399, 87);
            this.pedidoTextBox.Name = "pedidoTextBox";
            this.pedidoTextBox.Size = new System.Drawing.Size(200, 20);
            this.pedidoTextBox.TabIndex = 6;
            // 
            // data_pedidoDateTimePicker
            // 
            this.data_pedidoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.compraBindingSource, "data_pedido", true));
            this.data_pedidoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_pedidoDateTimePicker.Location = new System.Drawing.Point(719, 87);
            this.data_pedidoDateTimePicker.Name = "data_pedidoDateTimePicker";
            this.data_pedidoDateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.data_pedidoDateTimePicker.TabIndex = 8;
            // 
            // valor_pedidoTextBox
            // 
            this.valor_pedidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "valor_pedido", true));
            this.valor_pedidoTextBox.Location = new System.Drawing.Point(127, 125);
            this.valor_pedidoTextBox.Name = "valor_pedidoTextBox";
            this.valor_pedidoTextBox.Size = new System.Drawing.Size(98, 20);
            this.valor_pedidoTextBox.TabIndex = 10;
            // 
            // data_compraDateTimePicker
            // 
            this.data_compraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.compraBindingSource, "data_compra", true));
            this.data_compraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_compraDateTimePicker.Location = new System.Drawing.Point(435, 129);
            this.data_compraDateTimePicker.Name = "data_compraDateTimePicker";
            this.data_compraDateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.data_compraDateTimePicker.TabIndex = 12;
            // 
            // valor_compraTextBox
            // 
            this.valor_compraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compraBindingSource, "valor_compra", true));
            this.valor_compraTextBox.Location = new System.Drawing.Point(736, 132);
            this.valor_compraTextBox.Name = "valor_compraTextBox";
            this.valor_compraTextBox.Size = new System.Drawing.Size(81, 20);
            this.valor_compraTextBox.TabIndex = 14;
            // 
            // compraBunifuDataGridView
            // 
            this.compraBunifuDataGridView.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.compraBunifuDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.compraBunifuDataGridView.AutoGenerateColumns = false;
            this.compraBunifuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.compraBunifuDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.compraBunifuDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.compraBunifuDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.compraBunifuDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.compraBunifuDataGridView.ColumnHeadersHeight = 40;
            this.compraBunifuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.compraBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.compraBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.compraBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.compraBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.compraBunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.compraBunifuDataGridView.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.compraBunifuDataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.compraBunifuDataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.compraBunifuDataGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.compraBunifuDataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.compraBunifuDataGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.compraBunifuDataGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.compraBunifuDataGridView.CurrentTheme.Name = null;
            this.compraBunifuDataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.compraBunifuDataGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.compraBunifuDataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.compraBunifuDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.compraBunifuDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.compraBunifuDataGridView.DataSource = this.compraBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.compraBunifuDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.compraBunifuDataGridView.EnableHeadersVisualStyles = false;
            this.compraBunifuDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.compraBunifuDataGridView.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.compraBunifuDataGridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.compraBunifuDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.compraBunifuDataGridView.Location = new System.Drawing.Point(28, 175);
            this.compraBunifuDataGridView.Name = "compraBunifuDataGridView";
            this.compraBunifuDataGridView.RowHeadersVisible = false;
            this.compraBunifuDataGridView.RowTemplate.Height = 40;
            this.compraBunifuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.compraBunifuDataGridView.Size = new System.Drawing.Size(789, 352);
            this.compraBunifuDataGridView.TabIndex = 15;
            this.compraBunifuDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fornecedor_codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "fornecedor_codigo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "pedido";
            this.dataGridViewTextBoxColumn3.HeaderText = "pedido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "data_pedido";
            this.dataGridViewTextBoxColumn4.HeaderText = "data_pedido";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "valor_pedido";
            this.dataGridViewTextBoxColumn5.HeaderText = "valor_pedido";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "data_compra";
            this.dataGridViewTextBoxColumn6.HeaderText = "data_compra";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "valor_compra";
            this.dataGridViewTextBoxColumn7.HeaderText = "valor_compra";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "fornecedor";
            this.fornecedorBindingSource.DataSource = this.mercadinhoDataSet;
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 570);
            this.Controls.Add(this.compraBunifuDataGridView);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(fornecedor_codigoLabel);
            this.Controls.Add(this.fornecedor_codigoComboBox);
            this.Controls.Add(pedidoLabel);
            this.Controls.Add(this.pedidoTextBox);
            this.Controls.Add(data_pedidoLabel);
            this.Controls.Add(this.data_pedidoDateTimePicker);
            this.Controls.Add(valor_pedidoLabel);
            this.Controls.Add(this.valor_pedidoTextBox);
            this.Controls.Add(data_compraLabel);
            this.Controls.Add(this.data_compraDateTimePicker);
            this.Controls.Add(valor_compraLabel);
            this.Controls.Add(this.valor_compraTextBox);
            this.Controls.Add(this.compraBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCompras";
            this.Text = "FrmCompras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mercadinhoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingNavigator)).EndInit();
            this.compraBindingNavigator.ResumeLayout(false);
            this.compraBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBunifuDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mercadinhoDataSet mercadinhoDataSet;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private mercadinhoDataSetTableAdapters.compraTableAdapter compraTableAdapter;
        private mercadinhoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator compraBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton compraBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.ComboBox fornecedor_codigoComboBox;
        private System.Windows.Forms.TextBox pedidoTextBox;
        private System.Windows.Forms.DateTimePicker data_pedidoDateTimePicker;
        private System.Windows.Forms.TextBox valor_pedidoTextBox;
        private System.Windows.Forms.DateTimePicker data_compraDateTimePicker;
        private System.Windows.Forms.TextBox valor_compraTextBox;
        private mercadinhoDataSetTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        private Bunifu.UI.WinForms.BunifuDataGridView compraBunifuDataGridView;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.BindingSource fornecedorBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}