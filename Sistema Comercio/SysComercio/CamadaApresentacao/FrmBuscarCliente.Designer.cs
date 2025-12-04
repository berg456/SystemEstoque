namespace CamadaApresentacao
{
    partial class FrmBuscarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.DataLista = new System.Windows.Forms.DataGridView();
            this.Deletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBuscar = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbBusca = new Guna.UI.WinForms.GunaComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Clientes";
            // 
            // DataLista
            // 
            this.DataLista.AllowUserToAddRows = false;
            this.DataLista.AllowUserToDeleteRows = false;
            this.DataLista.AllowUserToOrderColumns = true;
            this.DataLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar});
            this.DataLista.Location = new System.Drawing.Point(12, 108);
            this.DataLista.MultiSelect = false;
            this.DataLista.Name = "DataLista";
            this.DataLista.ReadOnly = true;
            this.DataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataLista.Size = new System.Drawing.Size(567, 278);
            this.DataLista.TabIndex = 18;
            this.DataLista.DoubleClick += new System.EventHandler(this.DataLista_DoubleClick);
            // 
            // Deletar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.NullValue = false;
            this.Deletar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Deletar.HeaderText = "Deletar";
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(523, 92);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "label2";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BaseColor = System.Drawing.Color.White;
            this.txtBuscar.BorderColor = System.Drawing.Color.Silver;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBuscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Location = new System.Drawing.Point(268, 46);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(207, 30);
            this.txtBuscar.TabIndex = 16;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(12, 51);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(45, 15);
            this.gunaLabel1.TabIndex = 15;
            this.gunaLabel1.Text = "Buscar:";
            // 
            // cbBusca
            // 
            this.cbBusca.BackColor = System.Drawing.Color.Transparent;
            this.cbBusca.BaseColor = System.Drawing.Color.White;
            this.cbBusca.BorderColor = System.Drawing.Color.Silver;
            this.cbBusca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusca.FocusedColor = System.Drawing.Color.Empty;
            this.cbBusca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBusca.ForeColor = System.Drawing.Color.Black;
            this.cbBusca.FormattingEnabled = true;
            this.cbBusca.Items.AddRange(new object[] {
            "Nome",
            "Documento"});
            this.cbBusca.Location = new System.Drawing.Point(63, 46);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbBusca.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbBusca.Size = new System.Drawing.Size(187, 26);
            this.cbBusca.TabIndex = 19;
            this.cbBusca.SelectedIndexChanged += new System.EventHandler(this.cbBusca_SelectedIndexChanged);
            // 
            // FrmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 393);
            this.Controls.Add(this.cbBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataLista);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "FrmBuscarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Cliente";
            this.Load += new System.EventHandler(this.FrmBuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataLista;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deletar;
        private System.Windows.Forms.Label lblTotal;
        private Guna.UI.WinForms.GunaTextBox txtBuscar;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cbBusca;
    }
}