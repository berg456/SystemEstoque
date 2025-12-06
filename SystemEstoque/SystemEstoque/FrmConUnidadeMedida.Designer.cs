namespace SystemEstoque
{
    partial class FrmConUnidadeMedida
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
            this.btnLocalizar = new Guna.UI2.WinForms.Guna2Button();
            this.txtUnidadeMedida = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BorderRadius = 4;
            this.btnLocalizar.CheckedState.Parent = this.btnLocalizar;
            this.btnLocalizar.CustomImages.Parent = this.btnLocalizar;
            this.btnLocalizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLocalizar.ForeColor = System.Drawing.Color.White;
            this.btnLocalizar.HoverState.Parent = this.btnLocalizar;
            this.btnLocalizar.Image = global::SystemEstoque.Properties.Resources._17search;
            this.btnLocalizar.Location = new System.Drawing.Point(923, 116);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.ShadowDecoration.Parent = this.btnLocalizar;
            this.btnLocalizar.Size = new System.Drawing.Size(158, 43);
            this.btnLocalizar.TabIndex = 10;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // txtUnidadeMedida
            // 
            this.txtUnidadeMedida.BorderRadius = 4;
            this.txtUnidadeMedida.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnidadeMedida.DefaultText = "";
            this.txtUnidadeMedida.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUnidadeMedida.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUnidadeMedida.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnidadeMedida.DisabledState.Parent = this.txtUnidadeMedida;
            this.txtUnidadeMedida.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUnidadeMedida.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnidadeMedida.FocusedState.Parent = this.txtUnidadeMedida;
            this.txtUnidadeMedida.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUnidadeMedida.HoverState.Parent = this.txtUnidadeMedida;
            this.txtUnidadeMedida.Location = new System.Drawing.Point(75, 116);
            this.txtUnidadeMedida.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtUnidadeMedida.Name = "txtUnidadeMedida";
            this.txtUnidadeMedida.PasswordChar = '\0';
            this.txtUnidadeMedida.PlaceholderText = "";
            this.txtUnidadeMedida.SelectedText = "";
            this.txtUnidadeMedida.ShadowDecoration.Parent = this.txtUnidadeMedida;
            this.txtUnidadeMedida.Size = new System.Drawing.Size(782, 43);
            this.txtUnidadeMedida.TabIndex = 9;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel1.Location = new System.Drawing.Point(70, 78);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(205, 30);
            this.gunaLabel1.TabIndex = 8;
            this.gunaLabel1.Text = "Unidade de Medida";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel3.Location = new System.Drawing.Point(67, 15);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(712, 45);
            this.gunaLabel3.TabIndex = 12;
            this.gunaLabel3.Text = "TELA DE CONSULTA DE UNIDADE DE MEDIDA";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFechar.Location = new System.Drawing.Point(3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(37, 38);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.BackgroundColor = System.Drawing.Color.White;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(75, 189);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersWidth = 62;
            this.dgvDados.RowTemplate.Height = 28;
            this.dgvDados.Size = new System.Drawing.Size(1006, 700);
            this.dgvDados.TabIndex = 14;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // FrmConUnidadeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 914);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.txtUnidadeMedida);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConUnidadeMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConUnidadeMedida";
            this.Load += new System.EventHandler(this.FrmConUnidadeMedida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnLocalizar;
        private Guna.UI2.WinForms.Guna2TextBox txtUnidadeMedida;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgvDados;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}