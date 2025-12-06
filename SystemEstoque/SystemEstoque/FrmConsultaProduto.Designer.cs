namespace SystemEstoque
{
    partial class FrmConsultaProduto
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btnLocalizar = new Guna.UI2.WinForms.Guna2Button();
            this.txtValor = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.dgvDados);
            this.guna2Panel1.Controls.Add(this.btnFechar);
            this.guna2Panel1.Controls.Add(this.gunaLabel3);
            this.guna2Panel1.Controls.Add(this.btnLocalizar);
            this.guna2Panel1.Controls.Add(this.txtValor);
            this.guna2Panel1.Controls.Add(this.gunaLabel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1151, 914);
            this.guna2Panel1.TabIndex = 1;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.BackgroundColor = System.Drawing.Color.White;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(61, 174);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersWidth = 62;
            this.dgvDados.RowTemplate.Height = 28;
            this.dgvDados.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvDados.Size = new System.Drawing.Size(1042, 691);
            this.dgvDados.TabIndex = 11;
            this.dgvDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellDoubleClick);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFechar.Location = new System.Drawing.Point(0, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(37, 38);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel3.Location = new System.Drawing.Point(67, 20);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(550, 45);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = "TELA DE CONSULTA DE PRODUTOS";
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
            this.btnLocalizar.Location = new System.Drawing.Point(945, 109);
            this.btnLocalizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.ShadowDecoration.Parent = this.btnLocalizar;
            this.btnLocalizar.Size = new System.Drawing.Size(158, 43);
            this.btnLocalizar.TabIndex = 2;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // txtValor
            // 
            this.txtValor.BorderRadius = 4;
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.DefaultText = "";
            this.txtValor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.DisabledState.Parent = this.txtValor;
            this.txtValor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.FocusedState.Parent = this.txtValor;
            this.txtValor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.HoverState.Parent = this.txtValor;
            this.txtValor.Location = new System.Drawing.Point(61, 109);
            this.txtValor.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.PlaceholderText = "";
            this.txtValor.SelectedText = "";
            this.txtValor.ShadowDecoration.Parent = this.txtValor;
            this.txtValor.Size = new System.Drawing.Size(782, 43);
            this.txtValor.TabIndex = 1;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.gunaLabel1.Location = new System.Drawing.Point(56, 80);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(91, 30);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Produto";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            // 
            // FrmConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 914);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmConsultaProduto";
            this.Load += new System.EventHandler(this.FrmConsultaProduto_Load);
            this.DoubleClick += new System.EventHandler(this.FrmConsultaProduto_DoubleClick);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Button btnFechar;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI2.WinForms.Guna2Button btnLocalizar;
        private Guna.UI2.WinForms.Guna2TextBox txtValor;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.DataGridView dgvDados;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}