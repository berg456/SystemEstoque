<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnAjustes = New FontAwesome.Sharp.IconButton()
        Me.btnMaketing = New FontAwesome.Sharp.IconButton()
        Me.btnClientes = New FontAwesome.Sharp.IconButton()
        Me.btnProdutos = New FontAwesome.Sharp.IconButton()
        Me.btnPedidos = New FontAwesome.Sharp.IconButton()
        Me.btnDashbord = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New Guna.UI2.WinForms.Guna2Panel()
        Me.ImgHome = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PanelTituloBar = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnMinimize = New FontAwesome.Sharp.IconButton()
        Me.btnMaximize = New FontAwesome.Sharp.IconButton()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.ImgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTituloBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnAjustes)
        Me.PanelMenu.Controls.Add(Me.btnMaketing)
        Me.PanelMenu.Controls.Add(Me.btnClientes)
        Me.PanelMenu.Controls.Add(Me.btnProdutos)
        Me.PanelMenu.Controls.Add(Me.btnPedidos)
        Me.PanelMenu.Controls.Add(Me.btnDashbord)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.ShadowDecoration.Parent = Me.PanelMenu
        Me.PanelMenu.Size = New System.Drawing.Size(256, 693)
        Me.PanelMenu.TabIndex = 0
        '
        'btnAjustes
        '
        Me.btnAjustes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAjustes.FlatAppearance.BorderSize = 0
        Me.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjustes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjustes.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAjustes.IconChar = FontAwesome.Sharp.IconChar.Tools
        Me.btnAjustes.IconColor = System.Drawing.Color.White
        Me.btnAjustes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAjustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAjustes.Location = New System.Drawing.Point(0, 573)
        Me.btnAjustes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAjustes.Name = "btnAjustes"
        Me.btnAjustes.Padding = New System.Windows.Forms.Padding(11, 0, 24, 0)
        Me.btnAjustes.Size = New System.Drawing.Size(256, 78)
        Me.btnAjustes.TabIndex = 6
        Me.btnAjustes.Text = "Ajustes"
        Me.btnAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAjustes.UseVisualStyleBackColor = True
        '
        'btnMaketing
        '
        Me.btnMaketing.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMaketing.FlatAppearance.BorderSize = 0
        Me.btnMaketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaketing.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaketing.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMaketing.IconChar = FontAwesome.Sharp.IconChar.LineChart
        Me.btnMaketing.IconColor = System.Drawing.Color.White
        Me.btnMaketing.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaketing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMaketing.Location = New System.Drawing.Point(0, 495)
        Me.btnMaketing.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMaketing.Name = "btnMaketing"
        Me.btnMaketing.Padding = New System.Windows.Forms.Padding(11, 0, 24, 0)
        Me.btnMaketing.Size = New System.Drawing.Size(256, 78)
        Me.btnMaketing.TabIndex = 5
        Me.btnMaketing.Text = "Marketing"
        Me.btnMaketing.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMaketing.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnClientes.IconChar = FontAwesome.Sharp.IconChar.UserTie
        Me.btnClientes.IconColor = System.Drawing.Color.White
        Me.btnClientes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 417)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Padding = New System.Windows.Forms.Padding(11, 0, 24, 0)
        Me.btnClientes.Size = New System.Drawing.Size(256, 78)
        Me.btnClientes.TabIndex = 4
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnProdutos
        '
        Me.btnProdutos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProdutos.FlatAppearance.BorderSize = 0
        Me.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProdutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdutos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnProdutos.IconChar = FontAwesome.Sharp.IconChar.Palfed
        Me.btnProdutos.IconColor = System.Drawing.Color.White
        Me.btnProdutos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProdutos.Location = New System.Drawing.Point(0, 339)
        Me.btnProdutos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProdutos.Name = "btnProdutos"
        Me.btnProdutos.Padding = New System.Windows.Forms.Padding(11, 0, 24, 0)
        Me.btnProdutos.Size = New System.Drawing.Size(256, 78)
        Me.btnProdutos.TabIndex = 3
        Me.btnProdutos.Text = "Produtos"
        Me.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProdutos.UseVisualStyleBackColor = True
        '
        'btnPedidos
        '
        Me.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPedidos.FlatAppearance.BorderSize = 0
        Me.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPedidos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnPedidos.IconChar = FontAwesome.Sharp.IconChar.Shopify
        Me.btnPedidos.IconColor = System.Drawing.Color.White
        Me.btnPedidos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPedidos.Location = New System.Drawing.Point(0, 261)
        Me.btnPedidos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPedidos.Name = "btnPedidos"
        Me.btnPedidos.Padding = New System.Windows.Forms.Padding(11, 0, 24, 0)
        Me.btnPedidos.Size = New System.Drawing.Size(256, 78)
        Me.btnPedidos.TabIndex = 2
        Me.btnPedidos.Text = "Pedidos"
        Me.btnPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPedidos.UseVisualStyleBackColor = True
        '
        'btnDashbord
        '
        Me.btnDashbord.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashbord.FlatAppearance.BorderSize = 0
        Me.btnDashbord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashbord.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashbord.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDashbord.IconChar = FontAwesome.Sharp.IconChar.GaugeHigh
        Me.btnDashbord.IconColor = System.Drawing.Color.White
        Me.btnDashbord.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashbord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashbord.Location = New System.Drawing.Point(0, 183)
        Me.btnDashbord.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDashbord.Name = "btnDashbord"
        Me.btnDashbord.Padding = New System.Windows.Forms.Padding(11, 0, 24, 0)
        Me.btnDashbord.Size = New System.Drawing.Size(256, 78)
        Me.btnDashbord.TabIndex = 1
        Me.btnDashbord.Text = "Dashboard"
        Me.btnDashbord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDashbord.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.ImgHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.ShadowDecoration.Parent = Me.PanelLogo
        Me.PanelLogo.Size = New System.Drawing.Size(256, 183)
        Me.PanelLogo.TabIndex = 0
        '
        'ImgHome
        '
        Me.ImgHome.Image = Global.ModernoUI_Font_Awesome.My.Resources.Resources.petshop
        Me.ImgHome.Location = New System.Drawing.Point(29, 16)
        Me.ImgHome.Margin = New System.Windows.Forms.Padding(4)
        Me.ImgHome.Name = "ImgHome"
        Me.ImgHome.ShadowDecoration.Parent = Me.ImgHome
        Me.ImgHome.Size = New System.Drawing.Size(182, 107)
        Me.ImgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgHome.TabIndex = 0
        Me.ImgHome.TabStop = False
        '
        'PanelTituloBar
        '
        Me.PanelTituloBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelTituloBar.Controls.Add(Me.btnMinimize)
        Me.PanelTituloBar.Controls.Add(Me.btnMaximize)
        Me.PanelTituloBar.Controls.Add(Me.btnExit)
        Me.PanelTituloBar.Controls.Add(Me.lblFormTitle)
        Me.PanelTituloBar.Controls.Add(Me.IconCurrentForm)
        Me.PanelTituloBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTituloBar.Location = New System.Drawing.Point(256, 0)
        Me.PanelTituloBar.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelTituloBar.Name = "PanelTituloBar"
        Me.PanelTituloBar.ShadowDecoration.Parent = Me.PanelTituloBar
        Me.PanelTituloBar.Size = New System.Drawing.Size(732, 98)
        Me.PanelTituloBar.TabIndex = 1
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btnMinimize.IconColor = System.Drawing.Color.White
        Me.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimize.IconSize = 22
        Me.btnMinimize.Location = New System.Drawing.Point(658, 4)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(27, 22)
        Me.btnMinimize.TabIndex = 4
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.btnMaximize.IconColor = System.Drawing.Color.White
        Me.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaximize.IconSize = 22
        Me.btnMaximize.Location = New System.Drawing.Point(684, 4)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(22, 34)
        Me.btnMaximize.TabIndex = 3
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnExit.IconColor = System.Drawing.Color.White
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.IconSize = 22
        Me.btnExit.Location = New System.Drawing.Point(709, 4)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(24, 34)
        Me.btnExit.TabIndex = 2
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(60, 42)
        Me.lblFormTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(45, 17)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.House
        Me.IconCurrentForm.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 38
        Me.IconCurrentForm.Location = New System.Drawing.Point(17, 30)
        Me.IconCurrentForm.Margin = New System.Windows.Forms.Padding(4)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(38, 42)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.Guna2PictureBox1)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(256, 98)
        Me.PanelDesktop.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.ShadowDecoration.Parent = Me.PanelDesktop
        Me.PanelDesktop.Size = New System.Drawing.Size(732, 595)
        Me.PanelDesktop.TabIndex = 2
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(732, 595)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 693)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelTituloBar)
        Me.Controls.Add(Me.PanelMenu)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(980, 660)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.ImgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTituloBar.ResumeLayout(False)
        Me.PanelTituloBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PanelLogo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ImgHome As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnDashbord As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAjustes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaketing As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnProdutos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPedidos As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelTituloBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents PanelDesktop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMaximize As FontAwesome.Sharp.IconButton
End Class
