namespace ConexFirebird
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usuarios1 = new ConexFirebird.Usuarios();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 16;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 169);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.guna2GradientButton6);
            this.panel2.Controls.Add(this.guna2GradientButton5);
            this.panel2.Controls.Add(this.guna2GradientButton4);
            this.panel2.Controls.Add(this.guna2GradientButton3);
            this.panel2.Controls.Add(this.guna2GradientButton2);
            this.panel2.Controls.Add(this.guna2GradientButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 169);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 493);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.usuarios1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(201, 169);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(736, 493);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Cadastros e Vendas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(482, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rua Chapada do Araripe , 896   Bairro - São Jorge - Uberlândia - MG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone: (94)99209-1409";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPF: 568.369.702.63";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(913, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ConexFirebird.Properties.Resources.Logo1;
            this.pictureBox2.Location = new System.Drawing.Point(17, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(521, 439);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // guna2GradientButton6
            // 
            this.guna2GradientButton6.BorderRadius = 8;
            this.guna2GradientButton6.CheckedState.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.CustomImages.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientButton6.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton6.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton6.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton6.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton6.HoverState.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.Image = global::ConexFirebird.Properties.Resources.ic_import_export_white;
            this.guna2GradientButton6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton6.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2GradientButton6.Location = new System.Drawing.Point(0, 176);
            this.guna2GradientButton6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButton6.Name = "guna2GradientButton6";
            this.guna2GradientButton6.ShadowDecoration.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.Size = new System.Drawing.Size(199, 44);
            this.guna2GradientButton6.TabIndex = 12;
            this.guna2GradientButton6.Text = "Trocar Logo";
            this.guna2GradientButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2GradientButton5
            // 
            this.guna2GradientButton5.BorderRadius = 8;
            this.guna2GradientButton5.CheckedState.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.CustomImages.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientButton5.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton5.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton5.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton5.HoverState.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton5.Image")));
            this.guna2GradientButton5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton5.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2GradientButton5.Location = new System.Drawing.Point(0, 132);
            this.guna2GradientButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButton5.Name = "guna2GradientButton5";
            this.guna2GradientButton5.ShadowDecoration.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.Size = new System.Drawing.Size(199, 44);
            this.guna2GradientButton5.TabIndex = 11;
            this.guna2GradientButton5.Text = "Vendas (PDV)";
            this.guna2GradientButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BorderRadius = 8;
            this.guna2GradientButton4.CheckedState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.CustomImages.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientButton4.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton4.Image")));
            this.guna2GradientButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton4.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2GradientButton4.Location = new System.Drawing.Point(0, 88);
            this.guna2GradientButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.ShadowDecoration.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Size = new System.Drawing.Size(199, 44);
            this.guna2GradientButton4.TabIndex = 10;
            this.guna2GradientButton4.Text = "Clientes";
            this.guna2GradientButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderRadius = 8;
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientButton3.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton3.Image")));
            this.guna2GradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton3.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2GradientButton3.Location = new System.Drawing.Point(0, 44);
            this.guna2GradientButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(199, 44);
            this.guna2GradientButton3.TabIndex = 9;
            this.guna2GradientButton3.Text = "Produtos";
            this.guna2GradientButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderRadius = 8;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Image = global::ConexFirebird.Properties.Resources._131507_hacker_administrator_system_sys_hack_icon;
            this.guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton2.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2GradientButton2.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(199, 44);
            this.guna2GradientButton2.TabIndex = 8;
            this.guna2GradientButton2.Text = "Funcionários";
            this.guna2GradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 8;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Image = global::ConexFirebird.Properties.Resources.Salir_;
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(48, 48);
            this.guna2GradientButton1.Location = new System.Drawing.Point(0, 447);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(199, 44);
            this.guna2GradientButton1.TabIndex = 7;
            this.guna2GradientButton1.Text = "Sair";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConexFirebird.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usuarios1
            // 
            this.usuarios1.Location = new System.Drawing.Point(-1, -1);
            this.usuarios1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usuarios1.Name = "usuarios1";
            this.usuarios1.Size = new System.Drawing.Size(736, 493);
            this.usuarios1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 662);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton6;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton5;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Usuarios usuarios1;
    }
}

