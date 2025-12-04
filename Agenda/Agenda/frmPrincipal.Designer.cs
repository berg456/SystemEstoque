namespace Agenda
{
    partial class frmPrincipal
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
            this.btContato = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btContato
            // 
            this.btContato.BorderRadius = 15;
            this.btContato.CheckedState.Parent = this.btContato;
            this.btContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btContato.CustomImages.Parent = this.btContato;
            this.btContato.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btContato.ForeColor = System.Drawing.Color.White;
            this.btContato.HoverState.Parent = this.btContato;
            this.btContato.Location = new System.Drawing.Point(12, 1);
            this.btContato.Name = "btContato";
            this.btContato.ShadowDecoration.Parent = this.btContato;
            this.btContato.Size = new System.Drawing.Size(180, 45);
            this.btContato.TabIndex = 0;
            this.btContato.Text = "Contato";
            this.btContato.Click += new System.EventHandler(this.btContato_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 489);
            this.Controls.Add(this.btContato);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda 2022";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btContato;
    }
}

