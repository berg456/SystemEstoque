namespace BordasArredondadas
{
    partial class FrmBorda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelContainer = new Panel();
            panelTitleBar = new Panel();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(129, 131, 250);
            panelContainer.Dock = DockStyle.Top;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(817, 48);
            panelContainer.TabIndex = 0;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // panelTitleBar
            // 
            panelTitleBar.Dock = DockStyle.Fill;
            panelTitleBar.Location = new Point(0, 48);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(817, 547);
            panelTitleBar.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 595);
            Controls.Add(panelTitleBar);
            Controls.Add(panelContainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            ResizeEnd += Form1_ResizeEnd;
            SizeChanged += Form1_SizeChanged;
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private Panel panelTitleBar;
    }
}