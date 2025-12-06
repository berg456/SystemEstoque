namespace SystemEstoque
{
    partial class FrmConfigBancoDados
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
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new Guna.UI.WinForms.GunaButton();
            this.txtBanco = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtServidor = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTestar = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gunaLabel1.Location = new System.Drawing.Point(43, 192);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(96, 25);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "SERVIDOR";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel5.Location = new System.Drawing.Point(40, 72);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(759, 45);
            this.gunaLabel5.TabIndex = 8;
            this.gunaLabel5.Text = "TELA DE CONFIGURAÇÃO DO BANCO DE DADOS";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gunaLabel2.Location = new System.Drawing.Point(455, 300);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(69, 25);
            this.gunaLabel2.TabIndex = 9;
            this.gunaLabel2.Text = "SENHA";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gunaLabel3.Location = new System.Drawing.Point(43, 300);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(88, 25);
            this.gunaLabel3.TabIndex = 10;
            this.gunaLabel3.Text = "USÚARIO";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gunaLabel4.Location = new System.Drawing.Point(455, 192);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(166, 25);
            this.gunaLabel4.TabIndex = 11;
            this.gunaLabel4.Text = "BANCO DE DADOS";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFechar.Location = new System.Drawing.Point(3, 9);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(37, 38);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.AnimationHoverSpeed = 0.07F;
            this.btnSalvar.AnimationSpeed = 0.03F;
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSalvar.BorderColor = System.Drawing.Color.Black;
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSalvar.FocusedColor = System.Drawing.Color.Empty;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = global::SystemEstoque.Properties.Resources.backup_52px;
            this.btnSalvar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSalvar.Location = new System.Drawing.Point(768, 424);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSalvar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSalvar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSalvar.OnHoverImage = null;
            this.btnSalvar.OnPressedColor = System.Drawing.Color.Black;
            this.btnSalvar.Radius = 6;
            this.btnSalvar.Size = new System.Drawing.Size(186, 61);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtBanco
            // 
            this.txtBanco.BorderRadius = 6;
            this.txtBanco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBanco.DefaultText = "";
            this.txtBanco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBanco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBanco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBanco.DisabledState.Parent = this.txtBanco;
            this.txtBanco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBanco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBanco.FocusedState.Parent = this.txtBanco;
            this.txtBanco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBanco.HoverState.Parent = this.txtBanco;
            this.txtBanco.IconLeft = global::SystemEstoque.Properties.Resources.iconBd;
            this.txtBanco.IconLeftSize = new System.Drawing.Size(32, 32);
            this.txtBanco.Location = new System.Drawing.Point(460, 222);
            this.txtBanco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.PasswordChar = '\0';
            this.txtBanco.PlaceholderText = "";
            this.txtBanco.SelectedText = "";
            this.txtBanco.ShadowDecoration.Parent = this.txtBanco;
            this.txtBanco.Size = new System.Drawing.Size(494, 45);
            this.txtBanco.TabIndex = 7;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderRadius = 6;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.DefaultText = "";
            this.txtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.DisabledState.Parent = this.txtSenha;
            this.txtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.FocusedState.Parent = this.txtSenha;
            this.txtSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.HoverState.Parent = this.txtSenha;
            this.txtSenha.IconLeft = global::SystemEstoque.Properties.Resources.security;
            this.txtSenha.IconLeftSize = new System.Drawing.Size(32, 32);
            this.txtSenha.Location = new System.Drawing.Point(460, 330);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.PlaceholderText = "";
            this.txtSenha.SelectedText = "";
            this.txtSenha.ShadowDecoration.Parent = this.txtSenha;
            this.txtSenha.Size = new System.Drawing.Size(494, 45);
            this.txtSenha.TabIndex = 6;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderRadius = 6;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.DisabledState.Parent = this.txtUsuario;
            this.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.FocusedState.Parent = this.txtUsuario;
            this.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.HoverState.Parent = this.txtUsuario;
            this.txtUsuario.IconLeft = global::SystemEstoque.Properties.Resources._1120619_businessman_client_man_manager_person_icon;
            this.txtUsuario.IconLeftSize = new System.Drawing.Size(32, 32);
            this.txtUsuario.IconRightSize = new System.Drawing.Size(40, 40);
            this.txtUsuario.Location = new System.Drawing.Point(48, 330);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PlaceholderText = "";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.ShadowDecoration.Parent = this.txtUsuario;
            this.txtUsuario.Size = new System.Drawing.Size(404, 45);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtServidor
            // 
            this.txtServidor.BorderRadius = 6;
            this.txtServidor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServidor.DefaultText = "";
            this.txtServidor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServidor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServidor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServidor.DisabledState.Parent = this.txtServidor;
            this.txtServidor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServidor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServidor.FocusedState.Parent = this.txtServidor;
            this.txtServidor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServidor.HoverState.Parent = this.txtServidor;
            this.txtServidor.IconLeft = global::SystemEstoque.Properties.Resources.workstation1;
            this.txtServidor.IconLeftSize = new System.Drawing.Size(32, 32);
            this.txtServidor.Location = new System.Drawing.Point(48, 222);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.PasswordChar = '\0';
            this.txtServidor.PlaceholderText = "";
            this.txtServidor.SelectedText = "";
            this.txtServidor.ShadowDecoration.Parent = this.txtServidor;
            this.txtServidor.Size = new System.Drawing.Size(404, 45);
            this.txtServidor.TabIndex = 4;
            // 
            // btnTestar
            // 
            this.btnTestar.AnimationHoverSpeed = 0.07F;
            this.btnTestar.AnimationSpeed = 0.03F;
            this.btnTestar.BackColor = System.Drawing.Color.Transparent;
            this.btnTestar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnTestar.BorderColor = System.Drawing.Color.Black;
            this.btnTestar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTestar.FocusedColor = System.Drawing.Color.Empty;
            this.btnTestar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTestar.ForeColor = System.Drawing.Color.White;
            this.btnTestar.Image = global::SystemEstoque.Properties.Resources.backup_52px;
            this.btnTestar.ImageSize = new System.Drawing.Size(40, 40);
            this.btnTestar.Location = new System.Drawing.Point(515, 424);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTestar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTestar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTestar.OnHoverImage = null;
            this.btnTestar.OnPressedColor = System.Drawing.Color.Black;
            this.btnTestar.Radius = 6;
            this.btnTestar.Size = new System.Drawing.Size(186, 61);
            this.btnTestar.TabIndex = 15;
            this.btnTestar.Text = "TESTAR";
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // FrmConfigBancoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 497);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConfigBancoDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfigBancoDados";
            this.Load += new System.EventHandler(this.FrmConfigBancoDados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtBanco;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtServidor;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaButton btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private Guna.UI.WinForms.GunaButton btnTestar;
    }
}