namespace SchoolManagementSystem
{
    partial class Principal
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVer = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnDeletar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAtualizar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnInserir = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnFechar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInserir)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Inserir Registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Atualizar Registro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(545, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ver Registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Deletar Registro";
            // 
            // btnVer
            // 
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer.Image = global::SchoolManagementSystem.Properties.Resources.file_document_view_eye_icon;
            this.btnVer.Location = new System.Drawing.Point(468, 331);
            this.btnVer.Name = "btnVer";
            this.btnVer.ShadowDecoration.Parent = this.btnVer;
            this.btnVer.Size = new System.Drawing.Size(273, 200);
            this.btnVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVer.TabIndex = 3;
            this.btnVer.TabStop = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Image = global::SchoolManagementSystem.Properties.Resources.cancel_delete_document;
            this.btnDeletar.Location = new System.Drawing.Point(62, 331);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.ShadowDecoration.Parent = this.btnDeletar;
            this.btnDeletar.Size = new System.Drawing.Size(273, 200);
            this.btnDeletar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.TabStop = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Image = global::SchoolManagementSystem.Properties.Resources.update_task_progress_icon;
            this.btnAtualizar.Location = new System.Drawing.Point(468, 24);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.ShadowDecoration.Parent = this.btnAtualizar;
            this.btnAtualizar.Size = new System.Drawing.Size(273, 200);
            this.btnAtualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.Image = global::SchoolManagementSystem.Properties.Resources.document_folder_insert_icon;
            this.btnInserir.Location = new System.Drawing.Point(62, 24);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.ShadowDecoration.Parent = this.btnInserir;
            this.btnInserir.Size = new System.Drawing.Size(273, 200);
            this.btnInserir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInserir.TabIndex = 0;
            this.btnInserir.TabStop = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // btnFechar
            // 
            this.btnFechar.AutoSize = true;
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(807, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "X";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 599);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnInserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Principal_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Principal_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.btnVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInserir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox btnInserir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox btnVer;
        private Guna.UI2.WinForms.Guna2PictureBox btnDeletar;
        private Guna.UI2.WinForms.Guna2PictureBox btnAtualizar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label btnFechar;
    }
}