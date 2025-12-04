<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSair = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEntrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSenha = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtSenha = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.pictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pictureBox6 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.groupBox1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.btnSenha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.label1.Location = New System.Drawing.Point(197, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(202, 29)
        Me.label1.TabIndex = 36
        Me.label1.Text = "Sistema Escolar"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnSair)
        Me.groupBox1.Controls.Add(Me.btnEntrar)
        Me.groupBox1.Controls.Add(Me.Guna2Panel1)
        Me.groupBox1.Controls.Add(Me.pictureBox3)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.groupBox1.Location = New System.Drawing.Point(68, 92)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(410, 189)
        Me.groupBox1.TabIndex = 40
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Acesso ao Sistema"
        '
        'btnSair
        '
        Me.btnSair.BorderRadius = 8
        Me.btnSair.CheckedState.Parent = Me.btnSair
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.CustomImages.Parent = Me.btnSair
        Me.btnSair.FillColor = System.Drawing.Color.Red
        Me.btnSair.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnSair.ForeColor = System.Drawing.Color.White
        Me.btnSair.HoverState.Parent = Me.btnSair
        Me.btnSair.Location = New System.Drawing.Point(172, 142)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.ShadowDecoration.Parent = Me.btnSair
        Me.btnSair.Size = New System.Drawing.Size(117, 38)
        Me.btnSair.TabIndex = 14
        Me.btnSair.Text = "Sair"
        '
        'btnEntrar
        '
        Me.btnEntrar.BorderRadius = 8
        Me.btnEntrar.CheckedState.Parent = Me.btnEntrar
        Me.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntrar.CustomImages.Parent = Me.btnEntrar
        Me.btnEntrar.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.btnEntrar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnEntrar.ForeColor = System.Drawing.Color.White
        Me.btnEntrar.HoverState.Parent = Me.btnEntrar
        Me.btnEntrar.Location = New System.Drawing.Point(49, 142)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.ShadowDecoration.Parent = Me.btnEntrar
        Me.btnEntrar.Size = New System.Drawing.Size(117, 38)
        Me.btnEntrar.TabIndex = 13
        Me.btnEntrar.Text = "Entrar"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnSenha)
        Me.Guna2Panel1.Controls.Add(Me.guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.txtSenha)
        Me.Guna2Panel1.Controls.Add(Me.txtUsuario)
        Me.Guna2Panel1.Controls.Add(Me.label2)
        Me.Guna2Panel1.Controls.Add(Me.label3)
        Me.Guna2Panel1.Location = New System.Drawing.Point(6, 38)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(313, 100)
        Me.Guna2Panel1.TabIndex = 10
        '
        'btnSenha
        '
        Me.btnSenha.Image = Global.SistemaEscolar.My.Resources.Resources.cadastroUser__2_
        Me.btnSenha.Location = New System.Drawing.Point(74, 57)
        Me.btnSenha.Name = "btnSenha"
        Me.btnSenha.ShadowDecoration.Parent = Me.btnSenha
        Me.btnSenha.Size = New System.Drawing.Size(30, 30)
        Me.btnSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnSenha.TabIndex = 16
        Me.btnSenha.TabStop = False
        '
        'guna2PictureBox1
        '
        Me.guna2PictureBox1.Image = Global.SistemaEscolar.My.Resources.Resources._131507_hacker_administrator_system_sys_hack_icon
        Me.guna2PictureBox1.Location = New System.Drawing.Point(74, 13)
        Me.guna2PictureBox1.Name = "guna2PictureBox1"
        Me.guna2PictureBox1.ShadowDecoration.Parent = Me.guna2PictureBox1
        Me.guna2PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.guna2PictureBox1.TabIndex = 15
        Me.guna2PictureBox1.TabStop = False
        '
        'txtSenha
        '
        Me.txtSenha.BorderRadius = 8
        Me.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSenha.DefaultText = "123456"
        Me.txtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSenha.DisabledState.Parent = Me.txtSenha
        Me.txtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSenha.FocusedState.Parent = Me.txtSenha
        Me.txtSenha.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSenha.HoverState.Parent = Me.txtSenha
        Me.txtSenha.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.txtSenha.Location = New System.Drawing.Point(106, 54)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(8)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSenha.PlaceholderText = ""
        Me.txtSenha.SelectedText = ""
        Me.txtSenha.SelectionStart = 6
        Me.txtSenha.ShadowDecoration.Parent = Me.txtSenha
        Me.txtSenha.Size = New System.Drawing.Size(201, 33)
        Me.txtSenha.TabIndex = 12
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderRadius = 8
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsuario.DefaultText = "Admin"
        Me.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsuario.DisabledState.Parent = Me.txtUsuario
        Me.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsuario.FocusedState.Parent = Me.txtUsuario
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsuario.HoverState.Parent = Me.txtUsuario
        Me.txtUsuario.Location = New System.Drawing.Point(106, 14)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(5)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuario.PlaceholderText = ""
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.SelectionStart = 5
        Me.txtUsuario.ShadowDecoration.Parent = Me.txtUsuario
        Me.txtUsuario.Size = New System.Drawing.Size(201, 33)
        Me.txtUsuario.TabIndex = 11
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label2.Location = New System.Drawing.Point(5, 14)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(69, 21)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Usuário"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.label3.Location = New System.Drawing.Point(6, 54)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(57, 21)
        Me.label3.TabIndex = 14
        Me.label3.Text = "Senha"
        '
        'pictureBox3
        '
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(325, 68)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(81, 70)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox3.TabIndex = 7
        Me.pictureBox3.TabStop = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(117, 284)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(270, 17)
        Me.label4.TabIndex = 42
        Me.label4.Text = "Desenvolvido por Lindebergue Valadares"
        '
        'pictureBox5
        '
        Me.pictureBox5.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pictureBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.pictureBox5.Location = New System.Drawing.Point(0, 61)
        Me.pictureBox5.Name = "pictureBox5"
        Me.pictureBox5.Size = New System.Drawing.Size(6, 217)
        Me.pictureBox5.TabIndex = 44
        Me.pictureBox5.TabStop = False
        '
        'pictureBox6
        '
        Me.pictureBox6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox6.Dock = System.Windows.Forms.DockStyle.Right
        Me.pictureBox6.Location = New System.Drawing.Point(521, 61)
        Me.pictureBox6.Name = "pictureBox6"
        Me.pictureBox6.Size = New System.Drawing.Size(6, 217)
        Me.pictureBox6.TabIndex = 43
        Me.pictureBox6.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pictureBox2.Location = New System.Drawing.Point(0, 278)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(527, 28)
        Me.pictureBox2.TabIndex = 41
        Me.pictureBox2.TabStop = False
        '
        'pictureBox4
        '
        Me.pictureBox4.Image = Global.SistemaEscolar.My.Resources.Resources._131507_hacker_administrator_system_sys_hack_icon
        Me.pictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(61, 61)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox4.TabIndex = 37
        Me.pictureBox4.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(527, 61)
        Me.pictureBox1.TabIndex = 29
        Me.pictureBox1.TabStop = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 306)
        Me.Controls.Add(Me.pictureBox5)
        Me.Controls.Add(Me.pictureBox6)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.pictureBox4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.groupBox1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.btnSenha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnSair As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnEntrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents btnSenha As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents txtSenha As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtUsuario As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents label2 As Label
    Private WithEvents label3 As Label
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents label4 As Label
    Private WithEvents pictureBox6 As PictureBox
    Private WithEvents pictureBox5 As PictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
