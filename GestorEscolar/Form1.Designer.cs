namespace GestorEscolar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormCaptionButton1 = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.btnCancelar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnLogar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(247, 294);
            this.guna2Panel1.TabIndex = 0;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderRadius = 6;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "";
            this.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.DisabledState.Parent = this.txtUsuario;
            this.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.FocusedState.Parent = this.txtUsuario;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsuario.HoverState.Parent = this.txtUsuario;
            this.txtUsuario.IconLeft = global::GestorEscolar.Properties.Resources._06Funcionario;
            this.txtUsuario.Location = new System.Drawing.Point(276, 70);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PlaceholderText = "Digite o usuário";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.ShadowDecoration.Parent = this.txtUsuario;
            this.txtUsuario.Size = new System.Drawing.Size(262, 25);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderRadius = 6;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.DefaultText = "";
            this.txtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.DisabledState.Parent = this.txtSenha;
            this.txtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.FocusedState.Parent = this.txtSenha;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenha.HoverState.Parent = this.txtSenha;
            this.txtSenha.IconLeft = global::GestorEscolar.Properties.Resources.security;
            this.txtSenha.Location = new System.Drawing.Point(276, 110);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.PlaceholderText = "Digite a senha";
            this.txtSenha.SelectedText = "";
            this.txtSenha.ShadowDecoration.Parent = this.txtSenha;
            this.txtSenha.Size = new System.Drawing.Size(262, 27);
            this.txtSenha.TabIndex = 2;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bunifuLabel1.Location = new System.Drawing.Point(326, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(175, 32);
            this.bunifuLabel1.TabIndex = 5;
            this.bunifuLabel1.Text = "TELA DE LOGIN";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormCaptionButton1
            // 
            this.bunifuFormCaptionButton1.AllowAnimations = true;
            this.bunifuFormCaptionButton1.AllowBorderColorChanges = true;
            this.bunifuFormCaptionButton1.AllowDefaults = true;
            this.bunifuFormCaptionButton1.AllowMouseEffects = true;
            this.bunifuFormCaptionButton1.AnimationSpeed = 200;
            this.bunifuFormCaptionButton1.AutoSizeCaptions = true;
            this.bunifuFormCaptionButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.bunifuFormCaptionButton1.BackHoverColor = System.Drawing.Color.LightGray;
            this.bunifuFormCaptionButton1.BackPressedColor = System.Drawing.Color.Silver;
            this.bunifuFormCaptionButton1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuFormCaptionButton1.BorderHoverColor = System.Drawing.Color.DarkGray;
            this.bunifuFormCaptionButton1.BorderPressedColor = System.Drawing.Color.DarkGray;
            this.bunifuFormCaptionButton1.BorderRadius = 1;
            this.bunifuFormCaptionButton1.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.bunifuFormCaptionButton1.BorderThickness = 1;
            this.bunifuFormCaptionButton1.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Minimize;
            this.bunifuFormCaptionButton1.ColorContrastOnClick = 30;
            this.bunifuFormCaptionButton1.ColorContrastOnHover = 30;
            this.bunifuFormCaptionButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bunifuFormCaptionButton1.CustomizableEdges = borderEdges4;
            this.bunifuFormCaptionButton1.DefaultBorderColor = System.Drawing.Color.Silver;
            this.bunifuFormCaptionButton1.DefaultColor = System.Drawing.Color.Gainsboro;
            this.bunifuFormCaptionButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuFormCaptionButton1.IconColor = System.Drawing.Color.Black;
            this.bunifuFormCaptionButton1.IconHoverColor = System.Drawing.Color.Black;
            this.bunifuFormCaptionButton1.IconPressedColor = System.Drawing.Color.Black;
            this.bunifuFormCaptionButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuFormCaptionButton1.Image")));
            this.bunifuFormCaptionButton1.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.bunifuFormCaptionButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.bunifuFormCaptionButton1.Location = new System.Drawing.Point(584, 0);
            this.bunifuFormCaptionButton1.Name = "bunifuFormCaptionButton1";
            this.bunifuFormCaptionButton1.ShowBorders = true;
            this.bunifuFormCaptionButton1.Size = new System.Drawing.Size(31, 28);
            this.bunifuFormCaptionButton1.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AllowAnimations = true;
            this.btnCancelar.AllowMouseEffects = true;
            this.btnCancelar.AllowToggling = false;
            this.btnCancelar.AnimationSpeed = 200;
            this.btnCancelar.AutoGenerateColors = false;
            this.btnCancelar.AutoRoundBorders = false;
            this.btnCancelar.AutoSizeLeftIcon = true;
            this.btnCancelar.AutoSizeRightIcon = true;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.ButtonTextMarginLeft = 0;
            this.btnCancelar.ColorContrastOnClick = 45;
            this.btnCancelar.ColorContrastOnHover = 45;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnCancelar.CustomizableEdges = borderEdges5;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancelar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancelar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancelar.IconMarginLeft = 11;
            this.btnCancelar.IconPadding = 10;
            this.btnCancelar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.IdleBorderRadius = 6;
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.IdleIconLeftImage = null;
            this.btnCancelar.IdleIconRightImage = null;
            this.btnCancelar.IndicateFocus = false;
            this.btnCancelar.Location = new System.Drawing.Point(433, 168);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelar.OnDisabledState.BorderRadius = 6;
            this.btnCancelar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnDisabledState.BorderThickness = 1;
            this.btnCancelar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancelar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancelar.OnDisabledState.IconLeftImage = null;
            this.btnCancelar.OnDisabledState.IconRightImage = null;
            this.btnCancelar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCancelar.onHoverState.BorderRadius = 6;
            this.btnCancelar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.onHoverState.BorderThickness = 1;
            this.btnCancelar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCancelar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.onHoverState.IconLeftImage = null;
            this.btnCancelar.onHoverState.IconRightImage = null;
            this.btnCancelar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.OnIdleState.BorderRadius = 6;
            this.btnCancelar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnIdleState.BorderThickness = 1;
            this.btnCancelar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnIdleState.IconLeftImage = null;
            this.btnCancelar.OnIdleState.IconRightImage = null;
            this.btnCancelar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancelar.OnPressedState.BorderRadius = 6;
            this.btnCancelar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnPressedState.BorderThickness = 1;
            this.btnCancelar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancelar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnPressedState.IconLeftImage = null;
            this.btnCancelar.OnPressedState.IconRightImage = null;
            this.btnCancelar.Size = new System.Drawing.Size(105, 39);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.TextMarginLeft = 0;
            this.btnCancelar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancelar.UseDefaultRadiusAndThickness = true;
            // 
            // btnLogar
            // 
            this.btnLogar.AllowAnimations = true;
            this.btnLogar.AllowMouseEffects = true;
            this.btnLogar.AllowToggling = false;
            this.btnLogar.AnimationSpeed = 200;
            this.btnLogar.AutoGenerateColors = false;
            this.btnLogar.AutoRoundBorders = false;
            this.btnLogar.AutoSizeLeftIcon = true;
            this.btnLogar.AutoSizeRightIcon = true;
            this.btnLogar.BackColor = System.Drawing.Color.Transparent;
            this.btnLogar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnLogar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogar.BackgroundImage")));
            this.btnLogar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogar.ButtonText = "Logar";
            this.btnLogar.ButtonTextMarginLeft = 0;
            this.btnLogar.ColorContrastOnClick = 45;
            this.btnLogar.ColorContrastOnHover = 45;
            this.btnLogar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnLogar.CustomizableEdges = borderEdges6;
            this.btnLogar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogar.ForeColor = System.Drawing.Color.White;
            this.btnLogar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogar.IconMarginLeft = 11;
            this.btnLogar.IconPadding = 10;
            this.btnLogar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogar.IconSize = 25;
            this.btnLogar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLogar.IdleBorderRadius = 6;
            this.btnLogar.IdleBorderThickness = 1;
            this.btnLogar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnLogar.IdleIconLeftImage = null;
            this.btnLogar.IdleIconRightImage = null;
            this.btnLogar.IndicateFocus = false;
            this.btnLogar.Location = new System.Drawing.Point(276, 168);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogar.OnDisabledState.BorderRadius = 6;
            this.btnLogar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogar.OnDisabledState.BorderThickness = 1;
            this.btnLogar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogar.OnDisabledState.IconLeftImage = null;
            this.btnLogar.OnDisabledState.IconRightImage = null;
            this.btnLogar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLogar.onHoverState.BorderRadius = 6;
            this.btnLogar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogar.onHoverState.BorderThickness = 1;
            this.btnLogar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnLogar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogar.onHoverState.IconLeftImage = null;
            this.btnLogar.onHoverState.IconRightImage = null;
            this.btnLogar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnLogar.OnIdleState.BorderRadius = 6;
            this.btnLogar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogar.OnIdleState.BorderThickness = 1;
            this.btnLogar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnLogar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnLogar.OnIdleState.IconLeftImage = null;
            this.btnLogar.OnIdleState.IconRightImage = null;
            this.btnLogar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLogar.OnPressedState.BorderRadius = 6;
            this.btnLogar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogar.OnPressedState.BorderThickness = 1;
            this.btnLogar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnLogar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogar.OnPressedState.IconLeftImage = null;
            this.btnLogar.OnPressedState.IconRightImage = null;
            this.btnLogar.Size = new System.Drawing.Size(105, 39);
            this.btnLogar.TabIndex = 3;
            this.btnLogar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogar.TextMarginLeft = 0;
            this.btnLogar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLogar.UseDefaultRadiusAndThickness = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 294);
            this.Controls.Add(this.bunifuFormCaptionButton1);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogar;
        private BunifuButton btnCancelar;
        private BunifuLabel bunifuLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton bunifuFormCaptionButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

