namespace TesteMensagem
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
            this.btnDeletar = new Guna.UI2.WinForms.Guna2Button();
            this.btnNovo = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.labelDialogResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeletar
            // 
            this.btnDeletar.CheckedState.Parent = this.btnDeletar;
            this.btnDeletar.CustomImages.Parent = this.btnDeletar;
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.HoverState.Parent = this.btnDeletar;
            this.btnDeletar.Location = new System.Drawing.Point(222, 279);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.ShadowDecoration.Parent = this.btnDeletar;
            this.btnDeletar.Size = new System.Drawing.Size(180, 45);
            this.btnDeletar.TabIndex = 0;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.CheckedState.Parent = this.btnNovo;
            this.btnNovo.CustomImages.Parent = this.btnNovo;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.HoverState.Parent = this.btnNovo;
            this.btnNovo.Location = new System.Drawing.Point(36, 279);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.ShadowDecoration.Parent = this.btnNovo;
            this.btnNovo.Size = new System.Drawing.Size(180, 45);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "novo";
            // 
            // btnEditar
            // 
            this.btnEditar.CheckedState.Parent = this.btnEditar;
            this.btnEditar.CustomImages.Parent = this.btnEditar;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.HoverState.Parent = this.btnEditar;
            this.btnEditar.Location = new System.Drawing.Point(419, 279);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ShadowDecoration.Parent = this.btnEditar;
            this.btnEditar.Size = new System.Drawing.Size(180, 45);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // labelDialogResult
            // 
            this.labelDialogResult.BackColor = System.Drawing.Color.White;
            this.labelDialogResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDialogResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDialogResult.ForeColor = System.Drawing.Color.DimGray;
            this.labelDialogResult.Location = new System.Drawing.Point(0, 358);
            this.labelDialogResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDialogResult.Name = "labelDialogResult";
            this.labelDialogResult.Size = new System.Drawing.Size(800, 92);
            this.labelDialogResult.TabIndex = 3;
            this.labelDialogResult.Text = "Dialog Result";
            this.labelDialogResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDialogResult);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnDeletar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDeletar;
        private Guna.UI2.WinForms.Guna2Button btnNovo;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private System.Windows.Forms.Label labelDialogResult;
    }
}

