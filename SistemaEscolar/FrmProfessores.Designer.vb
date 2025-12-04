<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProfessores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProfessores))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_inserir = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnFecharCad = New System.Windows.Forms.Button()
        Me.btnEditar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSalvar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtEndereco = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rbFemenino = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtBuscarNome = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBuscarCpf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.rbNome = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rbCpf = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.label4 = New System.Windows.Forms.Label()
        Me.rbMasculino = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIdade = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSobrenome = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNome = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtCpf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTelefone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMateria = New Guna.UI2.WinForms.Guna2ComboBox()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(966, 61)
        Me.pictureBox1.TabIndex = 57
        Me.pictureBox1.TabStop = False
        '
        'btn_inserir
        '
        Me.btn_inserir.BackColor = System.Drawing.Color.Transparent
        Me.btn_inserir.BackgroundImage = CType(resources.GetObject("btn_inserir.BackgroundImage"), System.Drawing.Image)
        Me.btn_inserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_inserir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inserir.FlatAppearance.BorderSize = 0
        Me.btn_inserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btn_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inserir.Location = New System.Drawing.Point(396, 92)
        Me.btn_inserir.Name = "btn_inserir"
        Me.btn_inserir.Size = New System.Drawing.Size(48, 43)
        Me.btn_inserir.TabIndex = 14
        Me.btn_inserir.UseVisualStyleBackColor = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(7, 562)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(0, 13)
        Me.lblInfo.TabIndex = 69
        '
        'btnFecharCad
        '
        Me.btnFecharCad.BackColor = System.Drawing.Color.SkyBlue
        Me.btnFecharCad.FlatAppearance.BorderSize = 0
        Me.btnFecharCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFecharCad.Location = New System.Drawing.Point(938, 58)
        Me.btnFecharCad.Name = "btnFecharCad"
        Me.btnFecharCad.Size = New System.Drawing.Size(21, 23)
        Me.btnFecharCad.TabIndex = 68
        Me.btnFecharCad.Text = "X"
        Me.btnFecharCad.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BorderRadius = 8
        Me.btnEditar.CheckedState.Parent = Me.btnEditar
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.CustomImages.Parent = Me.btnEditar
        Me.btnEditar.FillColor = System.Drawing.Color.OliveDrab
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.HoverState.Parent = Me.btnEditar
        Me.btnEditar.Location = New System.Drawing.Point(740, 465)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.ShadowDecoration.Parent = Me.btnEditar
        Me.btnEditar.Size = New System.Drawing.Size(117, 38)
        Me.btnEditar.TabIndex = 66
        Me.btnEditar.Text = "Editar"
        '
        'btnSalvar
        '
        Me.btnSalvar.BorderRadius = 8
        Me.btnSalvar.CheckedState.Parent = Me.btnSalvar
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.CustomImages.Parent = Me.btnSalvar
        Me.btnSalvar.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSalvar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalvar.ForeColor = System.Drawing.Color.White
        Me.btnSalvar.HoverState.Parent = Me.btnSalvar
        Me.btnSalvar.Location = New System.Drawing.Point(617, 465)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.ShadowDecoration.Parent = Me.btnSalvar
        Me.btnSalvar.Size = New System.Drawing.Size(117, 38)
        Me.btnSalvar.TabIndex = 65
        Me.btnSalvar.Text = "Salvar"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.SistemaEscolar.My.Resources.Resources.add_new_patient_background
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-2, 55)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(971, 501)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 59
        Me.Guna2PictureBox1.TabStop = False
        '
        'txtEndereco
        '
        Me.txtEndereco.BorderRadius = 8
        Me.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEndereco.DefaultText = ""
        Me.txtEndereco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEndereco.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEndereco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEndereco.DisabledState.Parent = Me.txtEndereco
        Me.txtEndereco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEndereco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEndereco.FocusedState.Parent = Me.txtEndereco
        Me.txtEndereco.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtEndereco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEndereco.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEndereco.HoverState.Parent = Me.txtEndereco
        Me.txtEndereco.Location = New System.Drawing.Point(93, 276)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEndereco.PlaceholderText = ""
        Me.txtEndereco.SelectedText = ""
        Me.txtEndereco.ShadowDecoration.Parent = Me.txtEndereco
        Me.txtEndereco.Size = New System.Drawing.Size(318, 33)
        Me.txtEndereco.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label10.Location = New System.Drawing.Point(4, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 21)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Endereço"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.BorderRadius = 8
        Me.DateTimePicker1.CheckedState.Parent = Me.DateTimePicker1
        Me.DateTimePicker1.FillColor = System.Drawing.SystemColors.HotTrack
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.HoverState.Parent = Me.DateTimePicker1
        Me.DateTimePicker1.Location = New System.Drawing.Point(186, 234)
        Me.DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShadowDecoration.Parent = Me.DateTimePicker1
        Me.DateTimePicker1.Size = New System.Drawing.Size(151, 36)
        Me.DateTimePicker1.TabIndex = 24
        Me.DateTimePicker1.Value = New Date(2023, 10, 27, 19, 57, 40, 808)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Location = New System.Drawing.Point(4, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 21)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Data de Nascimento"
        '
        'rbFemenino
        '
        Me.rbFemenino.AutoSize = True
        Me.rbFemenino.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbFemenino.CheckedState.BorderThickness = 0
        Me.rbFemenino.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbFemenino.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbFemenino.CheckedState.InnerOffset = -4
        Me.rbFemenino.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbFemenino.Location = New System.Drawing.Point(314, 190)
        Me.rbFemenino.Name = "rbFemenino"
        Me.rbFemenino.Size = New System.Drawing.Size(104, 25)
        Me.rbFemenino.TabIndex = 22
        Me.rbFemenino.TabStop = True
        Me.rbFemenino.Text = "Femenino"
        Me.rbFemenino.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbFemenino.UncheckedState.BorderThickness = 2
        Me.rbFemenino.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbFemenino.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rbFemenino.UseVisualStyleBackColor = True
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pictureBox1
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Controls.Add(Me.btn_inserir)
        Me.Guna2GroupBox1.Controls.Add(Me.txtBuscarNome)
        Me.Guna2GroupBox1.Controls.Add(Me.txtBuscarCpf)
        Me.Guna2GroupBox1.Controls.Add(Me.lblBuscar)
        Me.Guna2GroupBox1.Controls.Add(Me.rbNome)
        Me.Guna2GroupBox1.Controls.Add(Me.rbCpf)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Teal
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(518, 214)
        Me.Guna2GroupBox1.TabIndex = 60
        Me.Guna2GroupBox1.Text = "Buscar Por"
        '
        'txtBuscarNome
        '
        Me.txtBuscarNome.BorderRadius = 8
        Me.txtBuscarNome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscarNome.DefaultText = ""
        Me.txtBuscarNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBuscarNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBuscarNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscarNome.DisabledState.Parent = Me.txtBuscarNome
        Me.txtBuscarNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscarNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscarNome.FocusedState.Parent = Me.txtBuscarNome
        Me.txtBuscarNome.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtBuscarNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBuscarNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscarNome.HoverState.Parent = Me.txtBuscarNome
        Me.txtBuscarNome.Location = New System.Drawing.Point(66, 88)
        Me.txtBuscarNome.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBuscarNome.Name = "txtBuscarNome"
        Me.txtBuscarNome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscarNome.PlaceholderText = ""
        Me.txtBuscarNome.SelectedText = ""
        Me.txtBuscarNome.ShadowDecoration.Parent = Me.txtBuscarNome
        Me.txtBuscarNome.Size = New System.Drawing.Size(201, 33)
        Me.txtBuscarNome.TabIndex = 13
        '
        'txtBuscarCpf
        '
        Me.txtBuscarCpf.BorderRadius = 8
        Me.txtBuscarCpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscarCpf.DefaultText = ""
        Me.txtBuscarCpf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBuscarCpf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBuscarCpf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscarCpf.DisabledState.Parent = Me.txtBuscarCpf
        Me.txtBuscarCpf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscarCpf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscarCpf.FocusedState.Parent = Me.txtBuscarCpf
        Me.txtBuscarCpf.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtBuscarCpf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBuscarCpf.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscarCpf.HoverState.Parent = Me.txtBuscarCpf
        Me.txtBuscarCpf.Location = New System.Drawing.Point(67, 88)
        Me.txtBuscarCpf.Margin = New System.Windows.Forms.Padding(5)
        Me.txtBuscarCpf.Name = "txtBuscarCpf"
        Me.txtBuscarCpf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscarCpf.PlaceholderText = ""
        Me.txtBuscarCpf.SelectedText = ""
        Me.txtBuscarCpf.ShadowDecoration.Parent = Me.txtBuscarCpf
        Me.txtBuscarCpf.Size = New System.Drawing.Size(201, 33)
        Me.txtBuscarCpf.TabIndex = 12
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblBuscar.Location = New System.Drawing.Point(8, 92)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(38, 21)
        Me.lblBuscar.TabIndex = 2
        Me.lblBuscar.Text = "CPF"
        '
        'rbNome
        '
        Me.rbNome.AutoSize = True
        Me.rbNome.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbNome.CheckedState.BorderThickness = 0
        Me.rbNome.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbNome.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbNome.CheckedState.InnerOffset = -4
        Me.rbNome.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbNome.Location = New System.Drawing.Point(85, 45)
        Me.rbNome.Name = "rbNome"
        Me.rbNome.Size = New System.Drawing.Size(75, 25)
        Me.rbNome.TabIndex = 1
        Me.rbNome.TabStop = True
        Me.rbNome.Text = "Nome"
        Me.rbNome.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbNome.UncheckedState.BorderThickness = 2
        Me.rbNome.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbNome.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rbNome.UseVisualStyleBackColor = True
        '
        'rbCpf
        '
        Me.rbCpf.AutoSize = True
        Me.rbCpf.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbCpf.CheckedState.BorderThickness = 0
        Me.rbCpf.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbCpf.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbCpf.CheckedState.InnerOffset = -4
        Me.rbCpf.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbCpf.Location = New System.Drawing.Point(5, 45)
        Me.rbCpf.Name = "rbCpf"
        Me.rbCpf.Size = New System.Drawing.Size(56, 25)
        Me.rbCpf.TabIndex = 0
        Me.rbCpf.TabStop = True
        Me.rbCpf.Text = "CPF"
        Me.rbCpf.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbCpf.UncheckedState.BorderThickness = 2
        Me.rbCpf.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbCpf.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rbCpf.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.label4.Font = New System.Drawing.Font("Bauhaus 93", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(99, 12)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(264, 30)
        Me.label4.TabIndex = 58
        Me.label4.Text = "REGISTRO DE ALUNOS"
        '
        'rbMasculino
        '
        Me.rbMasculino.AutoSize = True
        Me.rbMasculino.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbMasculino.CheckedState.BorderThickness = 0
        Me.rbMasculino.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbMasculino.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbMasculino.CheckedState.InnerOffset = -4
        Me.rbMasculino.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.rbMasculino.Location = New System.Drawing.Point(204, 189)
        Me.rbMasculino.Name = "rbMasculino"
        Me.rbMasculino.Size = New System.Drawing.Size(107, 25)
        Me.rbMasculino.TabIndex = 21
        Me.rbMasculino.TabStop = True
        Me.rbMasculino.Text = "Masculino"
        Me.rbMasculino.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbMasculino.UncheckedState.BorderThickness = 2
        Me.rbMasculino.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbMasculino.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.rbMasculino.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(157, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 21)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Sexo"
        '
        'txtIdade
        '
        Me.txtIdade.BorderRadius = 8
        Me.txtIdade.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIdade.DefaultText = ""
        Me.txtIdade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtIdade.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtIdade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIdade.DisabledState.Parent = Me.txtIdade
        Me.txtIdade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtIdade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdade.FocusedState.Parent = Me.txtIdade
        Me.txtIdade.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtIdade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIdade.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIdade.HoverState.Parent = Me.txtIdade
        Me.txtIdade.Location = New System.Drawing.Point(57, 189)
        Me.txtIdade.Margin = New System.Windows.Forms.Padding(5)
        Me.txtIdade.Name = "txtIdade"
        Me.txtIdade.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIdade.PlaceholderText = ""
        Me.txtIdade.SelectedText = ""
        Me.txtIdade.ShadowDecoration.Parent = Me.txtIdade
        Me.txtIdade.Size = New System.Drawing.Size(95, 33)
        Me.txtIdade.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(4, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 21)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Idade"
        '
        'txtSobrenome
        '
        Me.txtSobrenome.BorderRadius = 8
        Me.txtSobrenome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSobrenome.DefaultText = ""
        Me.txtSobrenome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSobrenome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSobrenome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSobrenome.DisabledState.Parent = Me.txtSobrenome
        Me.txtSobrenome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSobrenome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSobrenome.FocusedState.Parent = Me.txtSobrenome
        Me.txtSobrenome.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtSobrenome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSobrenome.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSobrenome.HoverState.Parent = Me.txtSobrenome
        Me.txtSobrenome.Location = New System.Drawing.Point(113, 146)
        Me.txtSobrenome.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSobrenome.Name = "txtSobrenome"
        Me.txtSobrenome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSobrenome.PlaceholderText = ""
        Me.txtSobrenome.SelectedText = ""
        Me.txtSobrenome.ShadowDecoration.Parent = Me.txtSobrenome
        Me.txtSobrenome.Size = New System.Drawing.Size(198, 33)
        Me.txtSobrenome.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(4, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 21)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "SobreNome"
        '
        'txtNome
        '
        Me.txtNome.BorderRadius = 8
        Me.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNome.DefaultText = ""
        Me.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNome.DisabledState.Parent = Me.txtNome
        Me.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNome.FocusedState.Parent = Me.txtNome
        Me.txtNome.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNome.HoverState.Parent = Me.txtNome
        Me.txtNome.Location = New System.Drawing.Point(259, 100)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(5)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNome.PlaceholderText = ""
        Me.txtNome.SelectedText = ""
        Me.txtNome.ShadowDecoration.Parent = Me.txtNome
        Me.txtNome.Size = New System.Drawing.Size(159, 33)
        Me.txtNome.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(203, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 21)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(3, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CPF"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BorderColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Controls.Add(Me.cbMateria)
        Me.Guna2GroupBox2.Controls.Add(Me.txtTelefone)
        Me.Guna2GroupBox2.Controls.Add(Me.Label1)
        Me.Guna2GroupBox2.Controls.Add(Me.Label12)
        Me.Guna2GroupBox2.Controls.Add(Me.txtEmail)
        Me.Guna2GroupBox2.Controls.Add(Me.Label11)
        Me.Guna2GroupBox2.Controls.Add(Me.txtNome)
        Me.Guna2GroupBox2.Controls.Add(Me.Label5)
        Me.Guna2GroupBox2.Controls.Add(Me.txtCpf)
        Me.Guna2GroupBox2.Controls.Add(Me.Label3)
        Me.Guna2GroupBox2.Controls.Add(Me.Label6)
        Me.Guna2GroupBox2.Controls.Add(Me.txtSobrenome)
        Me.Guna2GroupBox2.Controls.Add(Me.txtEndereco)
        Me.Guna2GroupBox2.Controls.Add(Me.Label7)
        Me.Guna2GroupBox2.Controls.Add(Me.txtIdade)
        Me.Guna2GroupBox2.Controls.Add(Me.Label10)
        Me.Guna2GroupBox2.Controls.Add(Me.Label8)
        Me.Guna2GroupBox2.Controls.Add(Me.rbMasculino)
        Me.Guna2GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.Guna2GroupBox2.Controls.Add(Me.rbFemenino)
        Me.Guna2GroupBox2.Controls.Add(Me.Label9)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Teal
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(536, 84)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(423, 375)
        Me.Guna2GroupBox2.TabIndex = 64
        Me.Guna2GroupBox2.Text = "Dados Pessoais"
        '
        'txtCpf
        '
        Me.txtCpf.BorderRadius = 8
        Me.txtCpf.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCpf.DefaultText = ""
        Me.txtCpf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCpf.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCpf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCpf.DisabledState.Parent = Me.txtCpf
        Me.txtCpf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCpf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCpf.FocusedState.Parent = Me.txtCpf
        Me.txtCpf.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCpf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCpf.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCpf.HoverState.Parent = Me.txtCpf
        Me.txtCpf.Location = New System.Drawing.Point(49, 58)
        Me.txtCpf.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCpf.PlaceholderText = ""
        Me.txtCpf.SelectedText = ""
        Me.txtCpf.ShadowDecoration.Parent = Me.txtCpf
        Me.txtCpf.Size = New System.Drawing.Size(136, 33)
        Me.txtCpf.TabIndex = 13
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Enabled = False
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(448, 562)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(14, 15)
        Me.lbl_total.TabIndex = 63
        Me.lbl_total.Text = "0"
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 4
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(10, 318)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(520, 232)
        Me.DataGridView1.TabIndex = 61
        Me.DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Me.DataGridView1.ThemeStyle.ReadOnly = False
        Me.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(403, 562)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Total"
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuLabel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuLabel2.CursorType = System.Windows.Forms.Cursors.Hand
        Me.BunifuLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel2.Location = New System.Drawing.Point(938, 9)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(25, 40)
        Me.BunifuLabel2.TabIndex = 70
        Me.BunifuLabel2.Text = "X"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'txtEmail
        '
        Me.txtEmail.BorderRadius = 8
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.Parent = Me.txtEmail
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.FocusedState.Parent = Me.txtEmail
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.HoverState.Parent = Me.txtEmail
        Me.txtEmail.Location = New System.Drawing.Point(93, 319)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.ShadowDecoration.Parent = Me.txtEmail
        Me.txtEmail.Size = New System.Drawing.Size(318, 33)
        Me.txtEmail.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label11.Location = New System.Drawing.Point(4, 319)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 21)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Email"
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.BackColor = System.Drawing.Color.Transparent
        Me.lbl_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.Location = New System.Drawing.Point(9, 565)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(0, 13)
        Me.lbl_info.TabIndex = 71
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label12.Location = New System.Drawing.Point(190, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 21)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Matéria"
        '
        'txtTelefone
        '
        Me.txtTelefone.BorderRadius = 8
        Me.txtTelefone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefone.DefaultText = ""
        Me.txtTelefone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTelefone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTelefone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTelefone.DisabledState.Parent = Me.txtTelefone
        Me.txtTelefone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTelefone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTelefone.FocusedState.Parent = Me.txtTelefone
        Me.txtTelefone.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtTelefone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTelefone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTelefone.HoverState.Parent = Me.txtTelefone
        Me.txtTelefone.Location = New System.Drawing.Point(89, 99)
        Me.txtTelefone.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefone.PlaceholderText = ""
        Me.txtTelefone.SelectedText = ""
        Me.txtTelefone.ShadowDecoration.Parent = Me.txtTelefone
        Me.txtTelefone.Size = New System.Drawing.Size(114, 33)
        Me.txtTelefone.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(9, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 21)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Telefone"
        '
        'cbMateria
        '
        Me.cbMateria.BackColor = System.Drawing.Color.Transparent
        Me.cbMateria.BorderRadius = 8
        Me.cbMateria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMateria.FocusedColor = System.Drawing.Color.Empty
        Me.cbMateria.FocusedState.Parent = Me.cbMateria
        Me.cbMateria.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbMateria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbMateria.FormattingEnabled = True
        Me.cbMateria.HoverState.Parent = Me.cbMateria
        Me.cbMateria.ItemHeight = 30
        Me.cbMateria.ItemsAppearance.Parent = Me.cbMateria
        Me.cbMateria.Location = New System.Drawing.Point(259, 56)
        Me.cbMateria.Name = "cbMateria"
        Me.cbMateria.ShadowDecoration.Parent = Me.cbMateria
        Me.cbMateria.Size = New System.Drawing.Size(159, 36)
        Me.cbMateria.TabIndex = 35
        '
        'FrmProfessores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 580)
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnFecharCad)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProfessores"
        Me.Text = "FrmProfessores"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents btn_inserir As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnFecharCad As Button
    Private WithEvents btnEditar As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnSalvar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents txtEndereco As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents rbFemenino As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Private WithEvents txtBuscarNome As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtBuscarCpf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents rbNome As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbCpf As Guna.UI2.WinForms.Guna2RadioButton
    Private WithEvents label4 As Label
    Friend WithEvents rbMasculino As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Label8 As Label
    Private WithEvents txtIdade As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Private WithEvents txtSobrenome As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Private WithEvents txtNome As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Private WithEvents txtCpf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Private WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_info As Label
    Private WithEvents txtTelefone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbMateria As Guna.UI2.WinForms.Guna2ComboBox
End Class
