<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnoLetivo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnoLetivo))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.txtAno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DateTimePicker2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalvar = New Guna.UI2.WinForms.Guna2Button()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me.txtAno
        '
        'txtAno
        '
        Me.txtAno.BorderRadius = 8
        Me.txtAno.Cursor = System.Windows.Forms.Cursors.IBeam
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
        Me.txtAno.Location = New System.Drawing.Point(92, 126)
        Me.txtAno.Margin = New System.Windows.Forms.Padding(5)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAno.PlaceholderText = ""
        Me.txtAno.SelectedText = ""
        Me.txtAno.ShadowDecoration.Parent = Me.txtAno
        Me.txtAno.Size = New System.Drawing.Size(201, 33)
        Me.txtAno.TabIndex = 12
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pictureBox1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
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
        Me.DataGridView1.Location = New System.Drawing.Point(31, 245)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(467, 175)
        Me.DataGridView1.TabIndex = 67
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
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.Guna2GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.btnSalvar)
        Me.Guna2GroupBox1.Controls.Add(Me.txtAno)
        Me.Guna2GroupBox1.Controls.Add(Me.lblBuscar)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Teal
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(31, 60)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(467, 179)
        Me.Guna2GroupBox1.TabIndex = 66
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.BorderRadius = 8
        Me.DateTimePicker1.CheckedState.Parent = Me.DateTimePicker1
        Me.DateTimePicker1.FillColor = System.Drawing.SystemColors.HotTrack
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.HoverState.Parent = Me.DateTimePicker1
        Me.DateTimePicker1.Location = New System.Drawing.Point(19, 76)
        Me.DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShadowDecoration.Parent = Me.DateTimePicker1
        Me.DateTimePicker1.Size = New System.Drawing.Size(151, 36)
        Me.DateTimePicker1.TabIndex = 57
        Me.DateTimePicker1.Value = New Date(2023, 10, 27, 19, 57, 40, 808)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.BorderRadius = 8
        Me.DateTimePicker2.CheckedState.Parent = Me.DateTimePicker2
        Me.DateTimePicker2.FillColor = System.Drawing.SystemColors.HotTrack
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.HoverState.Parent = Me.DateTimePicker2
        Me.DateTimePicker2.Location = New System.Drawing.Point(226, 76)
        Me.DateTimePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.ShadowDecoration.Parent = Me.DateTimePicker2
        Me.DateTimePicker2.Size = New System.Drawing.Size(151, 36)
        Me.DateTimePicker2.TabIndex = 56
        Me.DateTimePicker2.Value = New Date(2023, 10, 27, 19, 57, 40, 808)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(222, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 21)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Data Final"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(15, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 21)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Data Inícial"
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
        Me.btnSalvar.Location = New System.Drawing.Point(301, 123)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.ShadowDecoration.Parent = Me.btnSalvar
        Me.btnSalvar.Size = New System.Drawing.Size(117, 38)
        Me.btnSalvar.TabIndex = 53
        Me.btnSalvar.Text = "Salvar"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblBuscar.Location = New System.Drawing.Point(15, 132)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(41, 21)
        Me.lblBuscar.TabIndex = 2
        Me.lblBuscar.Text = "Ano"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.label4.Font = New System.Drawing.Font("Bauhaus 93", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(26, 7)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(314, 30)
        Me.label4.TabIndex = 64
        Me.label4.Text = "REGISTRO DE ANO LETIVO"
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Hand
        Me.BunifuLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.Location = New System.Drawing.Point(515, -2)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(25, 40)
        Me.BunifuLabel1.TabIndex = 63
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
        Me.lbl_total.Location = New System.Drawing.Point(476, 423)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(14, 15)
        Me.lbl_total.TabIndex = 69
        Me.lbl_total.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(431, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Total"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(540, 49)
        Me.pictureBox1.TabIndex = 62
        Me.pictureBox1.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.SistemaEscolar.My.Resources.Resources.add_new_patient_background
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 52)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(540, 392)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 65
        Me.Guna2PictureBox1.TabStop = False
        '
        'FrmAnoLetivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 443)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAnoLetivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAnoLetivo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Private WithEvents btnSalvar As Guna.UI2.WinForms.Guna2Button
    Private WithEvents txtAno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblBuscar As Label
    Private WithEvents label4 As Label
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DateTimePicker2 As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
