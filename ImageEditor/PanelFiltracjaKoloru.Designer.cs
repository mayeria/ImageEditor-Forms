namespace ImageEditor
{
    partial class PanelFiltracjaKoloru
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
            this.labelYellow = new System.Windows.Forms.Label();
            this.labelCyan = new System.Windows.Forms.Label();
            this.labelYellowCyan = new System.Windows.Forms.Label();
            this.labelCyanMagenta = new System.Windows.Forms.Label();
            this.labelMagentaYellow = new System.Windows.Forms.Label();
            this.labelMagenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelYellow
            // 
            this.labelYellow.BackColor = System.Drawing.Color.Yellow;
            this.labelYellow.Location = new System.Drawing.Point(67, 60);
            this.labelYellow.Name = "labelYellow";
            this.labelYellow.Size = new System.Drawing.Size(157, 20);
            this.labelYellow.TabIndex = 13;
            this.labelYellow.Text = "Yellow";
            this.labelYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelYellow.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.labelYellow.Click += new System.EventHandler(this.label_Click);
            // 
            // labelCyan
            // 
            this.labelCyan.BackColor = System.Drawing.Color.Cyan;
            this.labelCyan.Location = new System.Drawing.Point(67, 80);
            this.labelCyan.Name = "labelCyan";
            this.labelCyan.Size = new System.Drawing.Size(157, 20);
            this.labelCyan.TabIndex = 12;
            this.labelCyan.Text = "Cyan";
            this.labelCyan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCyan.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.labelCyan.Click += new System.EventHandler(this.label_Click);
            // 
            // labelYellowCyan
            // 
            this.labelYellowCyan.BackColor = System.Drawing.Color.Yellow;
            this.labelYellowCyan.ForeColor = System.Drawing.Color.Cyan;
            this.labelYellowCyan.Location = new System.Drawing.Point(67, 120);
            this.labelYellowCyan.Name = "labelYellowCyan";
            this.labelYellowCyan.Size = new System.Drawing.Size(157, 20);
            this.labelYellowCyan.TabIndex = 11;
            this.labelYellowCyan.Text = "Yellow-Cyan";
            this.labelYellowCyan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelYellowCyan.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.labelYellowCyan.Click += new System.EventHandler(this.label_Click);
            // 
            // labelCyanMagenta
            // 
            this.labelCyanMagenta.BackColor = System.Drawing.Color.Cyan;
            this.labelCyanMagenta.ForeColor = System.Drawing.Color.Magenta;
            this.labelCyanMagenta.Location = new System.Drawing.Point(67, 140);
            this.labelCyanMagenta.Name = "labelCyanMagenta";
            this.labelCyanMagenta.Size = new System.Drawing.Size(157, 20);
            this.labelCyanMagenta.TabIndex = 10;
            this.labelCyanMagenta.Text = "Cyan-Magenta";
            this.labelCyanMagenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCyanMagenta.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.labelCyanMagenta.Click += new System.EventHandler(this.label_Click);
            // 
            // labelMagentaYellow
            // 
            this.labelMagentaYellow.BackColor = System.Drawing.Color.Magenta;
            this.labelMagentaYellow.ForeColor = System.Drawing.Color.Yellow;
            this.labelMagentaYellow.Location = new System.Drawing.Point(67, 100);
            this.labelMagentaYellow.Name = "labelMagentaYellow";
            this.labelMagentaYellow.Size = new System.Drawing.Size(157, 20);
            this.labelMagentaYellow.TabIndex = 9;
            this.labelMagentaYellow.Text = "Magenta-Yellow";
            this.labelMagentaYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMagentaYellow.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.labelMagentaYellow.Click += new System.EventHandler(this.label_Click);
            // 
            // labelMagenta
            // 
            this.labelMagenta.BackColor = System.Drawing.Color.Magenta;
            this.labelMagenta.Location = new System.Drawing.Point(67, 40);
            this.labelMagenta.Name = "labelMagenta";
            this.labelMagenta.Size = new System.Drawing.Size(157, 20);
            this.labelMagenta.TabIndex = 8;
            this.labelMagenta.Text = "Magenta";
            this.labelMagenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMagenta.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.labelMagenta.Click += new System.EventHandler(this.label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Wybierz kolor do filtracji";
            // 
            // PanelFiltracjaKoloru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(294, 196);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelYellow);
            this.Controls.Add(this.labelCyan);
            this.Controls.Add(this.labelYellowCyan);
            this.Controls.Add(this.labelCyanMagenta);
            this.Controls.Add(this.labelMagentaYellow);
            this.Controls.Add(this.labelMagenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PanelFiltracjaKoloru";
            this.Text = "Filtracja koloru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYellow;
        private System.Windows.Forms.Label labelCyan;
        private System.Windows.Forms.Label labelYellowCyan;
        private System.Windows.Forms.Label labelCyanMagenta;
        private System.Windows.Forms.Label labelMagentaYellow;
        private System.Windows.Forms.Label labelMagenta;
        private System.Windows.Forms.Label label1;
    }
}