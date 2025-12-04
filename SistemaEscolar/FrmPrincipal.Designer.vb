<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.label4 = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.btn_notas = New System.Windows.Forms.Button()
        Me.btn_matricula = New System.Windows.Forms.Button()
        Me.btn_cursos = New System.Windows.Forms.Button()
        Me.btn_turmas = New System.Windows.Forms.Button()
        Me.btn_professores = New System.Windows.Forms.Button()
        Me.btn_alunos = New System.Windows.Forms.Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(225, 554)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(270, 17)
        Me.label4.TabIndex = 44
        Me.label4.Text = "Desenvolvido por Lindebergue Valadares"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pictureBox1
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Hand
        Me.BunifuLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.Location = New System.Drawing.Point(939, 1)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(25, 40)
        Me.BunifuLabel1.TabIndex = 53
        Me.BunifuLabel1.Text = "X"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'btn_notas
        '
        Me.btn_notas.BackColor = System.Drawing.Color.Transparent
        Me.btn_notas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_notas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_notas.FlatAppearance.BorderSize = 0
        Me.btn_notas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btn_notas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_notas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_notas.Image = CType(resources.GetObject("btn_notas.Image"), System.Drawing.Image)
        Me.btn_notas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_notas.Location = New System.Drawing.Point(639, 321)
        Me.btn_notas.Name = "btn_notas"
        Me.btn_notas.Size = New System.Drawing.Size(160, 182)
        Me.btn_notas.TabIndex = 52
        Me.btn_notas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_notas.UseVisualStyleBackColor = False
        '
        'btn_matricula
        '
        Me.btn_matricula.BackColor = System.Drawing.Color.Transparent
        Me.btn_matricula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_matricula.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_matricula.FlatAppearance.BorderSize = 0
        Me.btn_matricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btn_matricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_matricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_matricula.Image = CType(resources.GetObject("btn_matricula.Image"), System.Drawing.Image)
        Me.btn_matricula.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_matricula.Location = New System.Drawing.Point(335, 321)
        Me.btn_matricula.Name = "btn_matricula"
        Me.btn_matricula.Size = New System.Drawing.Size(160, 182)
        Me.btn_matricula.TabIndex = 51
        Me.btn_matricula.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_matricula.UseVisualStyleBackColor = False
        '
        'btn_cursos
        '
        Me.btn_cursos.BackColor = System.Drawing.Color.Transparent
        Me.btn_cursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cursos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cursos.FlatAppearance.BorderSize = 0
        Me.btn_cursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btn_cursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cursos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cursos.Image = CType(resources.GetObject("btn_cursos.Image"), System.Drawing.Image)
        Me.btn_cursos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cursos.Location = New System.Drawing.Point(48, 321)
        Me.btn_cursos.Name = "btn_cursos"
        Me.btn_cursos.Size = New System.Drawing.Size(160, 182)
        Me.btn_cursos.TabIndex = 50
        Me.btn_cursos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cursos.UseVisualStyleBackColor = False
        '
        'btn_turmas
        '
        Me.btn_turmas.BackColor = System.Drawing.Color.Transparent
        Me.btn_turmas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_turmas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_turmas.FlatAppearance.BorderSize = 0
        Me.btn_turmas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btn_turmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_turmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_turmas.Image = CType(resources.GetObject("btn_turmas.Image"), System.Drawing.Image)
        Me.btn_turmas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_turmas.Location = New System.Drawing.Point(639, 76)
        Me.btn_turmas.Name = "btn_turmas"
        Me.btn_turmas.Size = New System.Drawing.Size(160, 182)
        Me.btn_turmas.TabIndex = 49
        Me.btn_turmas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_turmas.UseVisualStyleBackColor = False
        '
        'btn_professores
        '
        Me.btn_professores.BackColor = System.Drawing.Color.Transparent
        Me.btn_professores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_professores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_professores.FlatAppearance.BorderSize = 0
        Me.btn_professores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btn_professores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_professores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_professores.Image = CType(resources.GetObject("btn_professores.Image"), System.Drawing.Image)
        Me.btn_professores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_professores.Location = New System.Drawing.Point(335, 76)
        Me.btn_professores.Name = "btn_professores"
        Me.btn_professores.Size = New System.Drawing.Size(160, 182)
        Me.btn_professores.TabIndex = 48
        Me.btn_professores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_professores.UseVisualStyleBackColor = False
        '
        'btn_alunos
        '
        Me.btn_alunos.BackColor = System.Drawing.Color.Transparent
        Me.btn_alunos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_alunos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_alunos.FlatAppearance.BorderSize = 0
        Me.btn_alunos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btn_alunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_alunos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_alunos.Image = CType(resources.GetObject("btn_alunos.Image"), System.Drawing.Image)
        Me.btn_alunos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_alunos.Location = New System.Drawing.Point(48, 76)
        Me.btn_alunos.Name = "btn_alunos"
        Me.btn_alunos.Size = New System.Drawing.Size(160, 182)
        Me.btn_alunos.TabIndex = 47
        Me.btn_alunos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_alunos.UseVisualStyleBackColor = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 47)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(964, 504)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 46
        Me.Guna2PictureBox1.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pictureBox2.Location = New System.Drawing.Point(0, 552)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(964, 28)
        Me.pictureBox2.TabIndex = 43
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(964, 50)
        Me.pictureBox1.TabIndex = 30
        Me.pictureBox1.TabStop = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 580)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.btn_notas)
        Me.Controls.Add(Me.btn_matricula)
        Me.Controls.Add(Me.btn_cursos)
        Me.Controls.Add(Me.btn_turmas)
        Me.Controls.Add(Me.btn_professores)
        Me.Controls.Add(Me.btn_alunos)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPrincipal"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label4 As Label
    Private WithEvents pictureBox2 As PictureBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btn_professores As Button
    Friend WithEvents btn_alunos As Button
    Friend WithEvents btn_notas As Button
    Friend WithEvents btn_matricula As Button
    Friend WithEvents btn_cursos As Button
    Friend WithEvents btn_turmas As Button
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
End Class
