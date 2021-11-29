namespace ImageEditor
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelOpcje = new System.Windows.Forms.Panel();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonEdycja = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelOpcje.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 383);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.PictureBox1_SizeChanged);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this.pictureBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseWheel);
            // 
            // panelOpcje
            // 
            this.panelOpcje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOpcje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelOpcje.Controls.Add(this.buttonZapisz);
            this.panelOpcje.Controls.Add(this.buttonEdycja);
            this.panelOpcje.Controls.Add(this.buttonReset);
            this.panelOpcje.Controls.Add(this.buttonDodaj);
            this.panelOpcje.Location = new System.Drawing.Point(-3, -5);
            this.panelOpcje.Name = "panelOpcje";
            this.panelOpcje.Size = new System.Drawing.Size(505, 53);
            this.panelOpcje.TabIndex = 1;
            this.panelOpcje.MouseEnter += new System.EventHandler(this.PanelOpcje_MouseEnter);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonZapisz.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonZapisz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonZapisz.Location = new System.Drawing.Point(378, 14);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(121, 23);
            this.buttonZapisz.TabIndex = 3;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = false;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonEdycja
            // 
            this.buttonEdycja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdycja.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEdycja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdycja.Location = new System.Drawing.Point(253, 14);
            this.buttonEdycja.Name = "buttonEdycja";
            this.buttonEdycja.Size = new System.Drawing.Size(121, 23);
            this.buttonEdycja.TabIndex = 2;
            this.buttonEdycja.Text = "Edytuj";
            this.buttonEdycja.UseVisualStyleBackColor = false;
            this.buttonEdycja.Click += new System.EventHandler(this.buttonEdycja_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReset.Location = new System.Drawing.Point(128, 14);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(121, 23);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDodaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDodaj.Location = new System.Drawing.Point(3, 14);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(121, 23);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj zdjęcie";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(500, 407);
            this.Controls.Add(this.panelOpcje);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Image Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelOpcje.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelOpcje;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonEdycja;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

