namespace ImageEditor
{
    partial class FormEdycja
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.histogramGray = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxFiltry = new System.Windows.Forms.GroupBox();
            this.buttonDilatation = new System.Windows.Forms.Button();
            this.buttonErosion = new System.Windows.Forms.Button();
            this.buttonKuwahara = new System.Windows.Forms.Button();
            this.buttonInverse = new System.Windows.Forms.Button();
            this.buttonNegative = new System.Windows.Forms.Button();
            this.buttonBlackWhite = new System.Windows.Forms.Button();
            this.buttonGrayscaleAVG = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxSzarosci = new System.Windows.Forms.GroupBox();
            this.buttonGrayscaleLuminance = new System.Windows.Forms.Button();
            this.buttonGrayscaleLightness = new System.Windows.Forms.Button();
            this.buttonDetekcjaKrawedzi = new System.Windows.Forms.Button();
            this.buttonFiltracjaKoloru = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBoxEfekty = new System.Windows.Forms.GroupBox();
            this.buttonCartoon = new System.Windows.Forms.Button();
            this.buttonOilPaint = new System.Windows.Forms.Button();
            this.buttonSzkic = new System.Windows.Forms.Button();
            this.buttonTiltShift = new System.Windows.Forms.Button();
            this.groupBoxEdycja = new System.Windows.Forms.GroupBox();
            this.buttonObrot = new System.Windows.Forms.Button();
            this.buttonZmianaRozmiaru = new System.Windows.Forms.Button();
            this.histogramRGB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxEdycja2 = new System.Windows.Forms.GroupBox();
            this.buttonJasnosc = new System.Windows.Forms.Button();
            this.buttonWyrownanieHistogramu = new System.Windows.Forms.Button();
            this.buttonGamma = new System.Windows.Forms.Button();
            this.buttonPrzesuwanieHistogramu = new System.Windows.Forms.Button();
            this.buttonContrast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.histogramGray)).BeginInit();
            this.groupBoxFiltry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxSzarosci.SuspendLayout();
            this.groupBoxEfekty.SuspendLayout();
            this.groupBoxEdycja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramRGB)).BeginInit();
            this.groupBoxEdycja2.SuspendLayout();
            this.SuspendLayout();
            // 
            // histogramGray
            // 
            this.histogramGray.BackColor = System.Drawing.Color.Black;
            this.histogramGray.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.histogramGray.ChartAreas.Add(chartArea1);
            this.histogramGray.Location = new System.Drawing.Point(304, 141);
            this.histogramGray.Name = "histogramGray";
            this.histogramGray.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Name = "Series1";
            this.histogramGray.Series.Add(series1);
            this.histogramGray.Size = new System.Drawing.Size(255, 142);
            this.histogramGray.TabIndex = 0;
            this.histogramGray.Text = "chart1";
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Szarość";
            title1.Text = "Szarość";
            this.histogramGray.Titles.Add(title1);
            // 
            // groupBoxFiltry
            // 
            this.groupBoxFiltry.Controls.Add(this.buttonDilatation);
            this.groupBoxFiltry.Controls.Add(this.buttonErosion);
            this.groupBoxFiltry.Controls.Add(this.buttonKuwahara);
            this.groupBoxFiltry.Controls.Add(this.buttonInverse);
            this.groupBoxFiltry.Controls.Add(this.buttonNegative);
            this.groupBoxFiltry.Controls.Add(this.buttonBlackWhite);
            this.groupBoxFiltry.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxFiltry.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFiltry.Name = "groupBoxFiltry";
            this.groupBoxFiltry.Size = new System.Drawing.Size(200, 111);
            this.groupBoxFiltry.TabIndex = 1;
            this.groupBoxFiltry.TabStop = false;
            this.groupBoxFiltry.Text = "Filtry";
            // 
            // buttonDilatation
            // 
            this.buttonDilatation.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonDilatation.Location = new System.Drawing.Point(102, 77);
            this.buttonDilatation.Name = "buttonDilatation";
            this.buttonDilatation.Size = new System.Drawing.Size(92, 23);
            this.buttonDilatation.TabIndex = 5;
            this.buttonDilatation.Text = "Dylatacja";
            this.buttonDilatation.UseVisualStyleBackColor = false;
            this.buttonDilatation.Click += new System.EventHandler(this.buttonDilatation_Click);
            this.buttonDilatation.MouseEnter += new System.EventHandler(this.buttonDilatation_MouseEnter);
            this.buttonDilatation.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonErosion
            // 
            this.buttonErosion.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonErosion.Location = new System.Drawing.Point(102, 48);
            this.buttonErosion.Name = "buttonErosion";
            this.buttonErosion.Size = new System.Drawing.Size(92, 23);
            this.buttonErosion.TabIndex = 4;
            this.buttonErosion.Text = "Erozja";
            this.buttonErosion.UseVisualStyleBackColor = false;
            this.buttonErosion.Click += new System.EventHandler(this.buttonErosion_Click);
            this.buttonErosion.MouseEnter += new System.EventHandler(this.buttonErosion_MouseEnter);
            this.buttonErosion.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonKuwahara
            // 
            this.buttonKuwahara.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonKuwahara.Location = new System.Drawing.Point(102, 19);
            this.buttonKuwahara.Name = "buttonKuwahara";
            this.buttonKuwahara.Size = new System.Drawing.Size(92, 23);
            this.buttonKuwahara.TabIndex = 3;
            this.buttonKuwahara.Text = "Kuwahara";
            this.buttonKuwahara.UseVisualStyleBackColor = false;
            this.buttonKuwahara.Click += new System.EventHandler(this.buttonKuwahara_Click);
            this.buttonKuwahara.MouseEnter += new System.EventHandler(this.buttonKuwahara_MouseEnter);
            this.buttonKuwahara.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonInverse
            // 
            this.buttonInverse.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonInverse.Location = new System.Drawing.Point(6, 77);
            this.buttonInverse.Name = "buttonInverse";
            this.buttonInverse.Size = new System.Drawing.Size(90, 23);
            this.buttonInverse.TabIndex = 2;
            this.buttonInverse.Text = "Inwersja";
            this.buttonInverse.UseVisualStyleBackColor = false;
            this.buttonInverse.Click += new System.EventHandler(this.buttonInverse_Click);
            this.buttonInverse.MouseEnter += new System.EventHandler(this.buttonInverse_MouseEnter);
            this.buttonInverse.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonNegative
            // 
            this.buttonNegative.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonNegative.Location = new System.Drawing.Point(6, 48);
            this.buttonNegative.Name = "buttonNegative";
            this.buttonNegative.Size = new System.Drawing.Size(90, 23);
            this.buttonNegative.TabIndex = 1;
            this.buttonNegative.Text = "Negatyw";
            this.buttonNegative.UseVisualStyleBackColor = false;
            this.buttonNegative.Click += new System.EventHandler(this.buttonNegative_Click);
            this.buttonNegative.MouseEnter += new System.EventHandler(this.buttonNegative_MouseEnter);
            this.buttonNegative.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonBlackWhite
            // 
            this.buttonBlackWhite.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonBlackWhite.Location = new System.Drawing.Point(6, 19);
            this.buttonBlackWhite.Name = "buttonBlackWhite";
            this.buttonBlackWhite.Size = new System.Drawing.Size(90, 23);
            this.buttonBlackWhite.TabIndex = 0;
            this.buttonBlackWhite.Text = "Czarno-biały";
            this.buttonBlackWhite.UseVisualStyleBackColor = false;
            this.buttonBlackWhite.Click += new System.EventHandler(this.buttonBlackWhite_Click);
            this.buttonBlackWhite.MouseEnter += new System.EventHandler(this.buttonBlackWhite_MouseEnter);
            this.buttonBlackWhite.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonGrayscaleAVG
            // 
            this.buttonGrayscaleAVG.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonGrayscaleAVG.Location = new System.Drawing.Point(10, 19);
            this.buttonGrayscaleAVG.Name = "buttonGrayscaleAVG";
            this.buttonGrayscaleAVG.Size = new System.Drawing.Size(104, 23);
            this.buttonGrayscaleAVG.TabIndex = 0;
            this.buttonGrayscaleAVG.Text = "Metodą average";
            this.buttonGrayscaleAVG.UseVisualStyleBackColor = false;
            this.buttonGrayscaleAVG.Click += new System.EventHandler(this.buttonGrayscaleAVG_Click);
            this.buttonGrayscaleAVG.MouseEnter += new System.EventHandler(this.buttonGrayscaleAVG_MouseEnter);
            this.buttonGrayscaleAVG.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(64, 339);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 98);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxSzarosci
            // 
            this.groupBoxSzarosci.Controls.Add(this.buttonGrayscaleLuminance);
            this.groupBoxSzarosci.Controls.Add(this.buttonGrayscaleLightness);
            this.groupBoxSzarosci.Controls.Add(this.buttonGrayscaleAVG);
            this.groupBoxSzarosci.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxSzarosci.Location = new System.Drawing.Point(12, 218);
            this.groupBoxSzarosci.Name = "groupBoxSzarosci";
            this.groupBoxSzarosci.Size = new System.Drawing.Size(126, 115);
            this.groupBoxSzarosci.TabIndex = 3;
            this.groupBoxSzarosci.TabStop = false;
            this.groupBoxSzarosci.Text = "Odcienie szarości";
            // 
            // buttonGrayscaleLuminance
            // 
            this.buttonGrayscaleLuminance.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonGrayscaleLuminance.Location = new System.Drawing.Point(10, 77);
            this.buttonGrayscaleLuminance.Name = "buttonGrayscaleLuminance";
            this.buttonGrayscaleLuminance.Size = new System.Drawing.Size(104, 23);
            this.buttonGrayscaleLuminance.TabIndex = 2;
            this.buttonGrayscaleLuminance.Text = "Metodą luminance";
            this.buttonGrayscaleLuminance.UseVisualStyleBackColor = false;
            this.buttonGrayscaleLuminance.Click += new System.EventHandler(this.buttonGrayscaleLuminance_Click);
            this.buttonGrayscaleLuminance.MouseEnter += new System.EventHandler(this.buttonGrayscaleLuminance_MouseEnter);
            this.buttonGrayscaleLuminance.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonGrayscaleLightness
            // 
            this.buttonGrayscaleLightness.BackColor = System.Drawing.Color.LightSlateGray;
            this.buttonGrayscaleLightness.Location = new System.Drawing.Point(10, 48);
            this.buttonGrayscaleLightness.Name = "buttonGrayscaleLightness";
            this.buttonGrayscaleLightness.Size = new System.Drawing.Size(104, 23);
            this.buttonGrayscaleLightness.TabIndex = 1;
            this.buttonGrayscaleLightness.Text = "Metodą lightness";
            this.buttonGrayscaleLightness.UseVisualStyleBackColor = false;
            this.buttonGrayscaleLightness.Click += new System.EventHandler(this.buttonGrayscaleLightness_Click);
            this.buttonGrayscaleLightness.MouseEnter += new System.EventHandler(this.buttonGrayscaleLightness_MouseEnter);
            this.buttonGrayscaleLightness.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonDetekcjaKrawedzi
            // 
            this.buttonDetekcjaKrawedzi.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonDetekcjaKrawedzi.Location = new System.Drawing.Point(6, 19);
            this.buttonDetekcjaKrawedzi.Name = "buttonDetekcjaKrawedzi";
            this.buttonDetekcjaKrawedzi.Size = new System.Drawing.Size(105, 23);
            this.buttonDetekcjaKrawedzi.TabIndex = 4;
            this.buttonDetekcjaKrawedzi.Text = "Detekcja krawędzi";
            this.buttonDetekcjaKrawedzi.UseVisualStyleBackColor = false;
            this.buttonDetekcjaKrawedzi.Click += new System.EventHandler(this.buttonDetekcjaKrawedzi_Click);
            this.buttonDetekcjaKrawedzi.MouseEnter += new System.EventHandler(this.buttonDetekcjaKrawedzi_MouseEnter);
            this.buttonDetekcjaKrawedzi.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonFiltracjaKoloru
            // 
            this.buttonFiltracjaKoloru.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonFiltracjaKoloru.Location = new System.Drawing.Point(87, 77);
            this.buttonFiltracjaKoloru.Name = "buttonFiltracjaKoloru";
            this.buttonFiltracjaKoloru.Size = new System.Drawing.Size(134, 23);
            this.buttonFiltracjaKoloru.TabIndex = 5;
            this.buttonFiltracjaKoloru.Text = "Filtracja Koloru";
            this.buttonFiltracjaKoloru.UseVisualStyleBackColor = false;
            this.buttonFiltracjaKoloru.Click += new System.EventHandler(this.buttonFiltracjaKoloru_Click);
            // 
            // groupBoxEfekty
            // 
            this.groupBoxEfekty.Controls.Add(this.buttonCartoon);
            this.groupBoxEfekty.Controls.Add(this.buttonOilPaint);
            this.groupBoxEfekty.Controls.Add(this.buttonSzkic);
            this.groupBoxEfekty.Controls.Add(this.buttonTiltShift);
            this.groupBoxEfekty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxEfekty.Location = new System.Drawing.Point(12, 131);
            this.groupBoxEfekty.Name = "groupBoxEfekty";
            this.groupBoxEfekty.Size = new System.Drawing.Size(200, 81);
            this.groupBoxEfekty.TabIndex = 7;
            this.groupBoxEfekty.TabStop = false;
            this.groupBoxEfekty.Text = "Efekty";
            // 
            // buttonCartoon
            // 
            this.buttonCartoon.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonCartoon.Location = new System.Drawing.Point(102, 48);
            this.buttonCartoon.Name = "buttonCartoon";
            this.buttonCartoon.Size = new System.Drawing.Size(92, 23);
            this.buttonCartoon.TabIndex = 3;
            this.buttonCartoon.Text = "Kreskówka";
            this.buttonCartoon.UseVisualStyleBackColor = false;
            this.buttonCartoon.Click += new System.EventHandler(this.buttonCartoon_Click);
            this.buttonCartoon.MouseEnter += new System.EventHandler(this.buttonCartoon_MouseEnter);
            this.buttonCartoon.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonOilPaint
            // 
            this.buttonOilPaint.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonOilPaint.Location = new System.Drawing.Point(6, 48);
            this.buttonOilPaint.Name = "buttonOilPaint";
            this.buttonOilPaint.Size = new System.Drawing.Size(90, 23);
            this.buttonOilPaint.TabIndex = 2;
            this.buttonOilPaint.Text = "Farba olejna";
            this.buttonOilPaint.UseVisualStyleBackColor = false;
            this.buttonOilPaint.Click += new System.EventHandler(this.buttonOilPaint_Click);
            this.buttonOilPaint.MouseEnter += new System.EventHandler(this.buttonOilPaint_MouseEnter);
            this.buttonOilPaint.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonSzkic
            // 
            this.buttonSzkic.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonSzkic.Location = new System.Drawing.Point(102, 19);
            this.buttonSzkic.Name = "buttonSzkic";
            this.buttonSzkic.Size = new System.Drawing.Size(92, 23);
            this.buttonSzkic.TabIndex = 1;
            this.buttonSzkic.Text = "Szkic";
            this.buttonSzkic.UseVisualStyleBackColor = false;
            this.buttonSzkic.Click += new System.EventHandler(this.buttonSzkic_Click);
            this.buttonSzkic.MouseEnter += new System.EventHandler(this.buttonSzkic_MouseEnter);
            this.buttonSzkic.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonTiltShift
            // 
            this.buttonTiltShift.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonTiltShift.Location = new System.Drawing.Point(6, 19);
            this.buttonTiltShift.Name = "buttonTiltShift";
            this.buttonTiltShift.Size = new System.Drawing.Size(90, 23);
            this.buttonTiltShift.TabIndex = 0;
            this.buttonTiltShift.Text = "Tilt shift";
            this.buttonTiltShift.UseVisualStyleBackColor = false;
            this.buttonTiltShift.Click += new System.EventHandler(this.buttonTiltShift_Click);
            this.buttonTiltShift.MouseEnter += new System.EventHandler(this.buttonTiltShift_MouseEnter);
            this.buttonTiltShift.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // groupBoxEdycja
            // 
            this.groupBoxEdycja.Controls.Add(this.buttonObrot);
            this.groupBoxEdycja.Controls.Add(this.buttonZmianaRozmiaru);
            this.groupBoxEdycja.Controls.Add(this.buttonDetekcjaKrawedzi);
            this.groupBoxEdycja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxEdycja.Location = new System.Drawing.Point(144, 218);
            this.groupBoxEdycja.Name = "groupBoxEdycja";
            this.groupBoxEdycja.Size = new System.Drawing.Size(121, 115);
            this.groupBoxEdycja.TabIndex = 8;
            this.groupBoxEdycja.TabStop = false;
            this.groupBoxEdycja.Text = "Edycja";
            // 
            // buttonObrot
            // 
            this.buttonObrot.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonObrot.Location = new System.Drawing.Point(7, 77);
            this.buttonObrot.Name = "buttonObrot";
            this.buttonObrot.Size = new System.Drawing.Size(104, 23);
            this.buttonObrot.TabIndex = 6;
            this.buttonObrot.Text = "Obrót obrazu";
            this.buttonObrot.UseVisualStyleBackColor = false;
            this.buttonObrot.Click += new System.EventHandler(this.buttonObrot_Click);
            // 
            // buttonZmianaRozmiaru
            // 
            this.buttonZmianaRozmiaru.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonZmianaRozmiaru.Location = new System.Drawing.Point(7, 48);
            this.buttonZmianaRozmiaru.Name = "buttonZmianaRozmiaru";
            this.buttonZmianaRozmiaru.Size = new System.Drawing.Size(104, 23);
            this.buttonZmianaRozmiaru.TabIndex = 4;
            this.buttonZmianaRozmiaru.Text = "Zmiana rozmiaru";
            this.buttonZmianaRozmiaru.UseVisualStyleBackColor = false;
            this.buttonZmianaRozmiaru.Click += new System.EventHandler(this.buttonZmianaRozmiaru_Click);
            // 
            // histogramRGB
            // 
            this.histogramRGB.BackColor = System.Drawing.Color.Black;
            this.histogramRGB.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.histogramRGB.ChartAreas.Add(chartArea2);
            this.histogramRGB.Location = new System.Drawing.Point(304, 289);
            this.histogramRGB.Name = "histogramRGB";
            this.histogramRGB.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.histogramRGB.Series.Add(series2);
            this.histogramRGB.Size = new System.Drawing.Size(255, 142);
            this.histogramRGB.TabIndex = 10;
            this.histogramRGB.Text = "chart1";
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.Text = "RGB";
            this.histogramRGB.Titles.Add(title2);
            // 
            // groupBoxEdycja2
            // 
            this.groupBoxEdycja2.Controls.Add(this.buttonJasnosc);
            this.groupBoxEdycja2.Controls.Add(this.buttonWyrownanieHistogramu);
            this.groupBoxEdycja2.Controls.Add(this.buttonFiltracjaKoloru);
            this.groupBoxEdycja2.Controls.Add(this.buttonGamma);
            this.groupBoxEdycja2.Controls.Add(this.buttonPrzesuwanieHistogramu);
            this.groupBoxEdycja2.Controls.Add(this.buttonContrast);
            this.groupBoxEdycja2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxEdycja2.Location = new System.Drawing.Point(224, 12);
            this.groupBoxEdycja2.Name = "groupBoxEdycja2";
            this.groupBoxEdycja2.Size = new System.Drawing.Size(228, 111);
            this.groupBoxEdycja2.TabIndex = 10;
            this.groupBoxEdycja2.TabStop = false;
            this.groupBoxEdycja2.Text = "Edycja";
            // 
            // buttonJasnosc
            // 
            this.buttonJasnosc.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonJasnosc.Location = new System.Drawing.Point(6, 77);
            this.buttonJasnosc.Name = "buttonJasnosc";
            this.buttonJasnosc.Size = new System.Drawing.Size(75, 23);
            this.buttonJasnosc.TabIndex = 5;
            this.buttonJasnosc.Text = "Jasność";
            this.buttonJasnosc.UseVisualStyleBackColor = false;
            this.buttonJasnosc.Click += new System.EventHandler(this.buttonJasnosc_Click);
            this.buttonJasnosc.MouseEnter += new System.EventHandler(this.buttonJasnosc_MouseEnter);
            this.buttonJasnosc.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonWyrownanieHistogramu
            // 
            this.buttonWyrownanieHistogramu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonWyrownanieHistogramu.Location = new System.Drawing.Point(87, 48);
            this.buttonWyrownanieHistogramu.Name = "buttonWyrownanieHistogramu";
            this.buttonWyrownanieHistogramu.Size = new System.Drawing.Size(134, 23);
            this.buttonWyrownanieHistogramu.TabIndex = 3;
            this.buttonWyrownanieHistogramu.Text = "Wyrównanie histogramu";
            this.buttonWyrownanieHistogramu.UseVisualStyleBackColor = false;
            this.buttonWyrownanieHistogramu.Click += new System.EventHandler(this.buttonWyrownanieHistogramu_Click);
            this.buttonWyrownanieHistogramu.MouseEnter += new System.EventHandler(this.buttonWyrownanieHistogramu_MouseEnter);
            this.buttonWyrownanieHistogramu.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonGamma
            // 
            this.buttonGamma.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonGamma.Location = new System.Drawing.Point(6, 48);
            this.buttonGamma.Name = "buttonGamma";
            this.buttonGamma.Size = new System.Drawing.Size(75, 23);
            this.buttonGamma.TabIndex = 2;
            this.buttonGamma.Text = "Gamma";
            this.buttonGamma.UseVisualStyleBackColor = false;
            this.buttonGamma.Click += new System.EventHandler(this.buttonGamma_Click);
            this.buttonGamma.MouseEnter += new System.EventHandler(this.buttonGamma_MouseEnter);
            this.buttonGamma.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // buttonPrzesuwanieHistogramu
            // 
            this.buttonPrzesuwanieHistogramu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonPrzesuwanieHistogramu.Location = new System.Drawing.Point(87, 19);
            this.buttonPrzesuwanieHistogramu.Name = "buttonPrzesuwanieHistogramu";
            this.buttonPrzesuwanieHistogramu.Size = new System.Drawing.Size(134, 23);
            this.buttonPrzesuwanieHistogramu.TabIndex = 1;
            this.buttonPrzesuwanieHistogramu.Text = "Przesuwanie histogramu";
            this.buttonPrzesuwanieHistogramu.UseVisualStyleBackColor = false;
            this.buttonPrzesuwanieHistogramu.Click += new System.EventHandler(this.buttonPrzesuwanieHistogramu_Click);
            // 
            // buttonContrast
            // 
            this.buttonContrast.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonContrast.Location = new System.Drawing.Point(6, 19);
            this.buttonContrast.Name = "buttonContrast";
            this.buttonContrast.Size = new System.Drawing.Size(75, 23);
            this.buttonContrast.TabIndex = 0;
            this.buttonContrast.Text = "Kontrast";
            this.buttonContrast.UseVisualStyleBackColor = false;
            this.buttonContrast.Click += new System.EventHandler(this.buttonContrast_Click);
            this.buttonContrast.MouseEnter += new System.EventHandler(this.buttonContrast_MouseEnter);
            this.buttonContrast.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // FormEdycja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(571, 440);
            this.Controls.Add(this.groupBoxEdycja2);
            this.Controls.Add(this.groupBoxEdycja);
            this.Controls.Add(this.groupBoxEfekty);
            this.Controls.Add(this.groupBoxSzarosci);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxFiltry);
            this.Controls.Add(this.histogramGray);
            this.Controls.Add(this.histogramRGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEdycja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Edycji";
            this.Load += new System.EventHandler(this.FormEdycja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.histogramGray)).EndInit();
            this.groupBoxFiltry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxSzarosci.ResumeLayout(false);
            this.groupBoxEfekty.ResumeLayout(false);
            this.groupBoxEdycja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histogramRGB)).EndInit();
            this.groupBoxEdycja2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxFiltry;
        private System.Windows.Forms.Button buttonGrayscaleAVG;
        private System.Windows.Forms.GroupBox groupBoxSzarosci;
        private System.Windows.Forms.Button buttonGrayscaleLuminance;
        private System.Windows.Forms.Button buttonGrayscaleLightness;
        private System.Windows.Forms.Button buttonBlackWhite;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonNegative;
        private System.Windows.Forms.Button buttonInverse;
        private System.Windows.Forms.Button buttonDetekcjaKrawedzi;
        private System.Windows.Forms.Button buttonFiltracjaKoloru;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonKuwahara;
        private System.Windows.Forms.Button buttonErosion;
        private System.Windows.Forms.Button buttonDilatation;
        private System.Windows.Forms.GroupBox groupBoxEfekty;
        private System.Windows.Forms.Button buttonTiltShift;
        private System.Windows.Forms.Button buttonSzkic;
        private System.Windows.Forms.Button buttonCartoon;
        private System.Windows.Forms.Button buttonOilPaint;
        private System.Windows.Forms.GroupBox groupBoxEdycja;
        private System.Windows.Forms.Button buttonObrot;
        private System.Windows.Forms.GroupBox groupBoxEdycja2;
        private System.Windows.Forms.Button buttonContrast;
        private System.Windows.Forms.Button buttonPrzesuwanieHistogramu;
        private System.Windows.Forms.Button buttonGamma;
        public System.Windows.Forms.DataVisualization.Charting.Chart histogramGray;
        public System.Windows.Forms.DataVisualization.Charting.Chart histogramRGB;
        private System.Windows.Forms.Button buttonWyrownanieHistogramu;
        private System.Windows.Forms.Button buttonZmianaRozmiaru;
        private System.Windows.Forms.Button buttonJasnosc;
    }
}