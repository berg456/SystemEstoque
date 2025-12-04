namespace WindowsFormsApp3
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
            this.licensing1 = new Guna.UI2.Licensing.Licensing();
            this.SuspendLayout();
            // 
            // licensing1
            // 
            this.licensing1.BackColor = System.Drawing.Color.White;
            this.licensing1.Location = new System.Drawing.Point(1, -2);
            this.licensing1.MaximumSize = new System.Drawing.Size(348, 485);
            this.licensing1.MinimumSize = new System.Drawing.Size(348, 485);
            this.licensing1.Name = "licensing1";
            this.licensing1.Size = new System.Drawing.Size(348, 485);
            this.licensing1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 494);
            this.Controls.Add(this.licensing1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.Licensing.Licensing licensing1;
    }
}

