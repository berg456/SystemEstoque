namespace C1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks1 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeMarks c1GaugeMarks2 = new C1.Win.C1Gauge.C1GaugeMarks();
            C1.Win.C1Gauge.C1GaugeLabels c1GaugeLabels1 = new C1.Win.C1Gauge.C1GaugeLabels();
            C1.Win.C1Gauge.C1GaugeRectangle c1GaugeRectangle1 = new C1.Win.C1Gauge.C1GaugeRectangle();
            C1.Win.C1Gauge.C1GaugeEllipse c1GaugeEllipse1 = new C1.Win.C1Gauge.C1GaugeEllipse();
            C1.Win.C1Gauge.C1GaugePointer c1GaugePointer1 = new C1.Win.C1Gauge.C1GaugePointer();
            C1.Win.C1Gauge.C1GaugePointer c1GaugePointer2 = new C1.Win.C1Gauge.C1GaugePointer();
            C1.Win.C1Gauge.C1GaugePointer c1GaugePointer3 = new C1.Win.C1Gauge.C1GaugePointer();
            this.c1RadialMenu1 = new C1.Win.C1Command.C1RadialMenu();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.c1Command1 = new C1.Win.C1Command.C1Command();
            this.c1Gauge1 = new C1.Win.C1Gauge.C1Gauge();
            this.c1RadialGauge1 = new C1.Win.C1Gauge.C1RadialGauge();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.c1Command1);
            this.c1CommandHolder1.Owner = this;
            // 
            // c1Command1
            // 
            this.c1Command1.Image = ((System.Drawing.Image)(resources.GetObject("c1Command1.Image")));
            this.c1Command1.Name = "c1Command1";
            this.c1Command1.ShortcutText = "";
            this.c1Command1.Text = "&New";
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.Gauges.AddRange(new C1.Win.C1Gauge.C1GaugeBase[] {
            this.c1RadialGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(555, 12);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(200, 200);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(639278345763304469));
            // 
            // c1RadialGauge1
            // 
            this.c1RadialGauge1.Cap.Border.Color = System.Drawing.Color.DarkSeaGreen;
            this.c1RadialGauge1.Cap.Border.Thickness = 1.5D;
            this.c1RadialGauge1.Cap.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            this.c1RadialGauge1.Cap.Filling.Color = System.Drawing.Color.MistyRose;
            this.c1RadialGauge1.Cap.Filling.Color2 = System.Drawing.Color.DimGray;
            this.c1RadialGauge1.Cap.Radius = 5D;
            this.c1RadialGauge1.Cap.Shadow.Visible = true;
            c1GaugeMarks1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks1.CustomShape.EndRadius = 2.5D;
            c1GaugeMarks1.CustomShape.StartRadius = 1.5D;
            c1GaugeMarks1.CustomShape.StartWidth = 3D;
            c1GaugeMarks1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeMarks1.Filling.Color = System.Drawing.Color.MistyRose;
            c1GaugeMarks1.Filling.Color2 = System.Drawing.Color.DimGray;
            c1GaugeMarks1.Filling.SwapColors = true;
            c1GaugeMarks1.From = 0.5D;
            c1GaugeMarks1.Interval = 5D;
            c1GaugeMarks1.Length = 12D;
            c1GaugeMarks1.Location = 86D;
            c1GaugeMarks1.ScaleFrom = 0D;
            c1GaugeMarks1.Shadow.OffsetX = 0.5D;
            c1GaugeMarks1.Shadow.OffsetY = 0.5D;
            c1GaugeMarks1.Shadow.Visible = true;
            c1GaugeMarks1.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Custom;
            c1GaugeMarks1.ViewTag = ((long)(634302468273582893));
            c1GaugeMarks2.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeMarks2.Filling.Color = System.Drawing.Color.Gray;
            c1GaugeMarks2.From = 0.5D;
            c1GaugeMarks2.Interval = 1D;
            c1GaugeMarks2.Length = 3D;
            c1GaugeMarks2.Location = 90D;
            c1GaugeMarks2.ScaleFrom = 0D;
            c1GaugeMarks2.Shadow.OffsetX = 0.5D;
            c1GaugeMarks2.Shadow.OffsetY = 0.5D;
            c1GaugeMarks2.Shadow.Visible = true;
            c1GaugeMarks2.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Round;
            c1GaugeMarks2.ViewTag = ((long)(634583943250743575));
            c1GaugeMarks2.Width = 3D;
            c1GaugeLabels1.Color = System.Drawing.Color.Gainsboro;
            c1GaugeLabels1.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            c1GaugeLabels1.FontSize = 17D;
            c1GaugeLabels1.From = 0.5D;
            c1GaugeLabels1.Interval = 5D;
            c1GaugeLabels1.Location = 68D;
            c1GaugeLabels1.Name = "nums";
            c1GaugeLabels1.ScaleFrom = 0D;
            c1GaugeLabels1.Shadow.OffsetX = 0.5D;
            c1GaugeLabels1.Shadow.OffsetY = 0.5D;
            c1GaugeLabels1.Shadow.Visible = true;
            c1GaugeLabels1.ValueFactor = 0.2D;
            c1GaugeLabels1.ViewTag = ((long)(634865418227634241));
            this.c1RadialGauge1.Decorators.AddRange(new C1.Win.C1Gauge.C1GaugeDecorator[] {
            c1GaugeMarks1,
            c1GaugeMarks2,
            c1GaugeLabels1});
            c1GaugeRectangle1.Border.Color = System.Drawing.Color.DarkSeaGreen;
            c1GaugeRectangle1.Border.Thickness = 4D;
            c1GaugeRectangle1.CornerRadius = 30D;
            c1GaugeRectangle1.Filling.Color = System.Drawing.Color.DarkSlateGray;
            c1GaugeRectangle1.Filling.Color2 = System.Drawing.Color.White;
            c1GaugeRectangle1.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.RadialOuter;
            c1GaugeRectangle1.HitTestable = false;
            c1GaugeEllipse1.Border.Color = System.Drawing.Color.DarkSeaGreen;
            c1GaugeEllipse1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugeEllipse1.Border.Thickness = 2D;
            c1GaugeEllipse1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugeEllipse1.Filling.Color = System.Drawing.Color.SlateGray;
            c1GaugeEllipse1.Filling.Color2 = System.Drawing.Color.DarkSlateGray;
            c1GaugeEllipse1.Gradient.CenterPointX = 0.6D;
            c1GaugeEllipse1.Gradient.CenterPointY = 0.65D;
            c1GaugeEllipse1.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.RadialInner;
            c1GaugeEllipse1.Gradient.FocusScaleX = 0.1D;
            c1GaugeEllipse1.Gradient.FocusScaleY = 0.1D;
            c1GaugeEllipse1.Height = -0.97D;
            c1GaugeEllipse1.HitTestable = false;
            c1GaugeEllipse1.Width = -0.97D;
            this.c1RadialGauge1.FaceShapes.AddRange(new C1.Win.C1Gauge.C1GaugeBaseShape[] {
            c1GaugeRectangle1,
            c1GaugeEllipse1});
            this.c1RadialGauge1.Maximum = 60D;
            c1GaugePointer1.Border.Color = System.Drawing.Color.DimGray;
            c1GaugePointer1.CustomShape.EndRadius = 1.928571428571D;
            c1GaugePointer1.CustomShape.EndWidth = 3.857142857144D;
            c1GaugePointer1.CustomShape.StartRadius = 2.571428571429D;
            c1GaugePointer1.CustomShape.StartWidth = 9D;
            c1GaugePointer1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugePointer1.Filling.Color = System.Drawing.Color.MistyRose;
            c1GaugePointer1.Filling.Color2 = System.Drawing.Color.DimGray;
            c1GaugePointer1.Length = 63D;
            c1GaugePointer1.Name = "hours";
            c1GaugePointer1.Offset = -15D;
            c1GaugePointer1.Shadow.Visible = true;
            c1GaugePointer1.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Custom;
            c1GaugePointer1.Value = 0.42D;
            c1GaugePointer1.ValueFactor = 5D;
            c1GaugePointer1.ViewTag = ((long)(635146893204754921));
            c1GaugePointer2.Border.Color = System.Drawing.Color.DimGray;
            c1GaugePointer2.CustomShape.EndRadius = 1.928571428571D;
            c1GaugePointer2.CustomShape.EndWidth = 3.857142857144D;
            c1GaugePointer2.CustomShape.StartRadius = 2.571428571429D;
            c1GaugePointer2.CustomShape.StartWidth = 9D;
            c1GaugePointer2.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient;
            c1GaugePointer2.Filling.Color = System.Drawing.Color.MistyRose;
            c1GaugePointer2.Filling.Color2 = System.Drawing.Color.DimGray;
            c1GaugePointer2.Length = 94D;
            c1GaugePointer2.Name = "minutes";
            c1GaugePointer2.Offset = -15D;
            c1GaugePointer2.Shadow.Visible = true;
            c1GaugePointer2.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Custom;
            c1GaugePointer2.Value = 22.3D;
            c1GaugePointer2.ViewTag = ((long)(635428368181515579));
            c1GaugePointer3.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None;
            c1GaugePointer3.Filling.Color = System.Drawing.Color.DarkSeaGreen;
            c1GaugePointer3.Length = 115D;
            c1GaugePointer3.Name = "seconds";
            c1GaugePointer3.Offset = -25D;
            c1GaugePointer3.Shadow.Visible = true;
            c1GaugePointer3.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Round;
            c1GaugePointer3.Value = 17D;
            c1GaugePointer3.ViewTag = ((long)(635709843158236236));
            c1GaugePointer3.Width = 2D;
            this.c1RadialGauge1.MorePointers.AddRange(new C1.Win.C1Gauge.C1GaugePointer[] {
            c1GaugePointer1,
            c1GaugePointer2,
            c1GaugePointer3});
            this.c1RadialGauge1.Name = "c1RadialGauge1";
            this.c1RadialGauge1.Pointer.Visible = false;
            this.c1RadialGauge1.Radius = 0.49D;
            this.c1RadialGauge1.StartAngle = 0D;
            this.c1RadialGauge1.SweepAngle = 360D;
            this.c1RadialGauge1.ViewTag = ((long)(636272793112967623));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.c1Gauge1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Win.C1Command.C1RadialMenu c1RadialMenu1;
        private Win.C1Command.C1CommandHolder c1CommandHolder1;
        private Win.C1Command.C1Command c1Command1;
        private Win.C1Gauge.C1Gauge c1Gauge1;
        private Win.C1Gauge.C1RadialGauge c1RadialGauge1;
    }
}

