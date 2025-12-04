<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMatricula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMatricula))
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.label4 = New System.Windows.Forms.Label()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.cbTurmas = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSerie = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVagas = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCpf = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCodigo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtValor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnSalvar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnLimpar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnConsultar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBuscar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.label4.Font = New System.Drawing.Font("Bauhaus 93", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(10, 9)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(314, 30)
        Me.label4.TabIndex = 72
        Me.label4.Text = "REGISTRO DE MATRICULA"
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Hand
        Me.BunifuLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.Location = New System.Drawing.Point(515, 0)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(25, 40)
        Me.BunifuLabel1.TabIndex = 71
        Me.BunifuLabel1.Text = "X"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Enabled = False
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(476, 446)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(14, 15)
        Me.lbl_total.TabIndex = 77
        Me.lbl_total.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(396, 446)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Matriculas"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.BorderRadius = 8
        Me.DateTimePicker1.CheckedState.Parent = Me.DateTimePicker1
        Me.DateTimePicker1.FillColor = System.Drawing.SystemColors.HotTrack
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.HoverState.Parent = Me.DateTimePicker1
        Me.DateTimePicker1.Location = New System.Drawing.Point(3, 132)
        Me.DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShadowDecoration.Parent = Me.DateTimePicker1
        Me.DateTimePicker1.Size = New System.Drawing.Size(143, 36)
        Me.DateTimePicker1.TabIndex = 57
        Me.DateTimePicker1.Value = New Date(2023, 10, 27, 19, 57, 40, 808)
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Controls.Add(Me.cbTurmas)
        Me.Guna2GroupBox1.Controls.Add(Me.Label9)
        Me.Guna2GroupBox1.Controls.Add(Me.txtSerie)
        Me.Guna2GroupBox1.Controls.Add(Me.Label8)
        Me.Guna2GroupBox1.Controls.Add(Me.txtVagas)
        Me.Guna2GroupBox1.Controls.Add(Me.Label7)
        Me.Guna2GroupBox1.Controls.Add(Me.txtAno)
        Me.Guna2GroupBox1.Controls.Add(Me.txtCpf)
        Me.Guna2GroupBox1.Controls.Add(Me.txtCodigo)
        Me.Guna2GroupBox1.Controls.Add(Me.Label6)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.txtValor)
        Me.Guna2GroupBox1.Controls.Add(Me.lblBuscar)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Teal
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(31, 83)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(308, 259)
        Me.Guna2GroupBox1.TabIndex = 74
        Me.Guna2GroupBox1.Text = "Registrar Matrícula"
        '
        'cbTurmas
        '
        Me.cbTurmas.BackColor = System.Drawing.Color.Transparent
        Me.cbTurmas.BorderRadius = 8
        Me.cbTurmas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTurmas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTurmas.FocusedColor = System.Drawing.Color.Empty
        Me.cbTurmas.FocusedState.Parent = Me.cbTurmas
        Me.cbTurmas.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbTurmas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbTurmas.FormattingEnabled = True
        Me.cbTurmas.HoverState.Parent = Me.cbTurmas
        Me.cbTurmas.ItemHeight = 30
        Me.cbTurmas.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cbTurmas.ItemsAppearance.Parent = Me.cbTurmas
        Me.cbTurmas.Location = New System.Drawing.Point(3, 203)
        Me.cbTurmas.Name = "cbTurmas"
        Me.cbTurmas.ShadowDecoration.Parent = Me.cbTurmas
        Me.cbTurmas.Size = New System.Drawing.Size(88, 36)
        Me.cbTurmas.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Location = New System.Drawing.Point(3, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 21)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Turma"
        '
        'txtSerie
        '
        Me.txtSerie.BorderRadius = 8
        Me.txtSerie.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSerie.DefaultText = ""
        Me.txtSerie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSerie.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSerie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSerie.DisabledState.Parent = Me.txtSerie
        Me.txtSerie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSerie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSerie.FocusedState.Parent = Me.txtSerie
        Me.txtSerie.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtSerie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSerie.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSerie.HoverState.Parent = Me.txtSerie
        Me.txtSerie.Location = New System.Drawing.Point(99, 209)
        Me.txtSerie.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSerie.PlaceholderText = ""
        Me.txtSerie.SelectedText = ""
        Me.txtSerie.ShadowDecoration.Parent = Me.txtSerie
        Me.txtSerie.Size = New System.Drawing.Size(70, 36)
        Me.txtSerie.TabIndex = 66
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(95, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 21)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Série"
        '
        'txtVagas
        '
        Me.txtVagas.BorderRadius = 8
        Me.txtVagas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVagas.DefaultText = ""
        Me.txtVagas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtVagas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtVagas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVagas.DisabledState.Parent = Me.txtVagas
        Me.txtVagas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtVagas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVagas.FocusedState.Parent = Me.txtVagas
        Me.txtVagas.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtVagas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtVagas.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtVagas.HoverState.Parent = Me.txtVagas
        Me.txtVagas.Location = New System.Drawing.Point(197, 205)
        Me.txtVagas.Margin = New System.Windows.Forms.Padding(5)
        Me.txtVagas.Name = "txtVagas"
        Me.txtVagas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVagas.PlaceholderText = ""
        Me.txtVagas.SelectedText = ""
        Me.txtVagas.ShadowDecoration.Parent = Me.txtVagas
        Me.txtVagas.Size = New System.Drawing.Size(95, 36)
        Me.txtVagas.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(193, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 21)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Vagas Livres"
        '
        'txtAno
        '
        Me.txtAno.BorderColor = System.Drawing.Color.DodgerBlue
        Me.txtAno.BorderRadius = 8
        Me.txtAno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtAno.DefaultText = ""
        Me.txtAno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAno.DisabledState.Parent = Me.txtAno
        Me.txtAno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAno.FocusedState.Parent = Me.txtAno
        Me.txtAno.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtAno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAno.HoverState.Parent = Me.txtAno
        Me.txtAno.Location = New System.Drawing.Point(206, 70)
        Me.txtAno.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAno.PlaceholderText = ""
        Me.txtAno.SelectedText = ""
        Me.txtAno.ShadowDecoration.Parent = Me.txtAno
        Me.txtAno.Size = New System.Drawing.Size(95, 36)
        Me.txtAno.TabIndex = 62
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
        Me.txtCpf.Location = New System.Drawing.Point(78, 70)
        Me.txtCpf.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCpf.PlaceholderText = ""
        Me.txtCpf.SelectedText = ""
        Me.txtCpf.ShadowDecoration.Parent = Me.txtCpf
        Me.txtCpf.Size = New System.Drawing.Size(123, 36)
        Me.txtCpf.TabIndex = 61
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderRadius = 8
        Me.txtCodigo.BorderThickness = 2
        Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigo.DefaultText = ""
        Me.txtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCodigo.DisabledState.Parent = Me.txtCodigo
        Me.txtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.FillColor = System.Drawing.Color.PapayaWhip
        Me.txtCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigo.FocusedState.Parent = Me.txtCodigo
        Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigo.HoverState.Parent = Me.txtCodigo
        Me.txtCodigo.Location = New System.Drawing.Point(7, 70)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(5)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodigo.PlaceholderText = ""
        Me.txtCodigo.SelectedText = ""
        Me.txtCodigo.ShadowDecoration.Parent = Me.txtCodigo
        Me.txtCodigo.Size = New System.Drawing.Size(61, 36)
        Me.txtCodigo.TabIndex = 60
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label6.Location = New System.Drawing.Point(202, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 21)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Ano Escolar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(74, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 21)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "CPF Aluno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(3, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 21)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Código"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(3, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 21)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Data"
        '
        'txtValor
        '
        Me.txtValor.BorderRadius = 8
        Me.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtValor.DefaultText = ""
        Me.txtValor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtValor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtValor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtValor.DisabledState.Parent = Me.txtValor
        Me.txtValor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtValor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtValor.FocusedState.Parent = Me.txtValor
        Me.txtValor.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtValor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtValor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtValor.HoverState.Parent = Me.txtValor
        Me.txtValor.Location = New System.Drawing.Point(203, 138)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(5)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtValor.PlaceholderText = ""
        Me.txtValor.SelectedText = ""
        Me.txtValor.ShadowDecoration.Parent = Me.txtValor
        Me.txtValor.Size = New System.Drawing.Size(95, 36)
        Me.txtValor.TabIndex = 12
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblBuscar.Location = New System.Drawing.Point(199, 108)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(50, 21)
        Me.lblBuscar.TabIndex = 2
        Me.lblBuscar.Text = "Valor"
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
        Me.btnSalvar.Location = New System.Drawing.Point(28, 44)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.ShadowDecoration.Parent = Me.btnSalvar
        Me.btnSalvar.Size = New System.Drawing.Size(117, 38)
        Me.btnSalvar.TabIndex = 53
        Me.btnSalvar.Text = "Salvar"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pictureBox1
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(540, 49)
        Me.pictureBox1.TabIndex = 70
        Me.pictureBox1.TabStop = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridView1.ColumnHeadersHeight = 4
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(31, 348)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(497, 95)
        Me.DataGridView1.TabIndex = 75
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
        Me.DataGridView1.ThemeStyle.ReadOnly = True
        Me.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.SistemaEscolar.My.Resources.Resources.add_new_patient_background
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 46)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(540, 421)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 73
        Me.Guna2PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BorderColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btnLimpar)
        Me.GroupBox2.Controls.Add(Me.btnConsultar)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Controls.Add(Me.btnEditar)
        Me.GroupBox2.Controls.Add(Me.btnSalvar)
        Me.GroupBox2.CustomBorderColor = System.Drawing.Color.Teal
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(345, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.ShadowDecoration.Parent = Me.GroupBox2
        Me.GroupBox2.Size = New System.Drawing.Size(183, 259)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.Text = "Ações"
        '
        'btnLimpar
        '
        Me.btnLimpar.BorderRadius = 8
        Me.btnLimpar.CheckedState.Parent = Me.btnLimpar
        Me.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpar.CustomImages.Parent = Me.btnLimpar
        Me.btnLimpar.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.btnLimpar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpar.ForeColor = System.Drawing.Color.White
        Me.btnLimpar.HoverState.Parent = Me.btnLimpar
        Me.btnLimpar.Location = New System.Drawing.Point(28, 210)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.ShadowDecoration.Parent = Me.btnLimpar
        Me.btnLimpar.Size = New System.Drawing.Size(117, 38)
        Me.btnLimpar.TabIndex = 57
        Me.btnLimpar.Text = "Limpar"
        '
        'btnConsultar
        '
        Me.btnConsultar.BorderRadius = 8
        Me.btnConsultar.CheckedState.Parent = Me.btnConsultar
        Me.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultar.CustomImages.Parent = Me.btnConsultar
        Me.btnConsultar.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.btnConsultar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnConsultar.ForeColor = System.Drawing.Color.White
        Me.btnConsultar.HoverState.Parent = Me.btnConsultar
        Me.btnConsultar.Location = New System.Drawing.Point(28, 168)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.ShadowDecoration.Parent = Me.btnConsultar
        Me.btnConsultar.Size = New System.Drawing.Size(117, 38)
        Me.btnConsultar.TabIndex = 56
        Me.btnConsultar.Text = "Consultar"
        '
        'btnBuscar
        '
        Me.btnBuscar.BorderRadius = 8
        Me.btnBuscar.CheckedState.Parent = Me.btnBuscar
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.CustomImages.Parent = Me.btnBuscar
        Me.btnBuscar.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.HoverState.Parent = Me.btnBuscar
        Me.btnBuscar.Location = New System.Drawing.Point(28, 126)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.ShadowDecoration.Parent = Me.btnBuscar
        Me.btnBuscar.Size = New System.Drawing.Size(117, 38)
        Me.btnBuscar.TabIndex = 55
        Me.btnBuscar.Text = "Buscar"
        '
        'btnEditar
        '
        Me.btnEditar.BorderRadius = 8
        Me.btnEditar.CheckedState.Parent = Me.btnEditar
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.CustomImages.Parent = Me.btnEditar
        Me.btnEditar.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.HoverState.Parent = Me.btnEditar
        Me.btnEditar.Location = New System.Drawing.Point(28, 84)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.ShadowDecoration.Parent = Me.btnEditar
        Me.btnEditar.Size = New System.Drawing.Size(117, 38)
        Me.btnEditar.TabIndex = 54
        Me.btnEditar.Text = "Editar"
        '
        'FrmMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 489)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMatricula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMatricula"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label4 As Label
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Private WithEvents btnSalvar As Guna.UI2.WinForms.Guna2Button
    Private WithEvents txtValor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Private WithEvents txtCodigo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Private WithEvents txtVagas As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Private WithEvents txtAno As Guna.UI2.WinForms.Guna2TextBox
    Private WithEvents txtCpf As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Private WithEvents txtSerie As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbTurmas As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Private WithEvents btnLimpar As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnConsultar As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnBuscar As Guna.UI2.WinForms.Guna2Button
    Private WithEvents btnEditar As Guna.UI2.WinForms.Guna2Button
End Class
