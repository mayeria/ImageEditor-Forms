using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FIP;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace ImageEditor
{
    public partial class FormEdycja : Form
    {
        public FormEdycja()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form f1 = System.Windows.Forms.Application.OpenForms["Form1"];
        System.Windows.Forms.Form fc = System.Windows.Forms.Application.OpenForms["PanelContrast"];
        System.Windows.Forms.Form fg = System.Windows.Forms.Application.OpenForms["PanelGamma"];
        System.Windows.Forms.Form fph = System.Windows.Forms.Application.OpenForms["PanelPrzesuwanieHistogramu"];
        System.Windows.Forms.Form fo = System.Windows.Forms.Application.OpenForms["PanelObrot"];
        System.Windows.Forms.Form fzr = System.Windows.Forms.Application.OpenForms["PanelZmianaRozmiaru"];
        System.Windows.Forms.Form fbw = System.Windows.Forms.Application.OpenForms["PanelBW"];
        System.Windows.Forms.Form fi = System.Windows.Forms.Application.OpenForms["PanelInverse"];
        System.Windows.Forms.Form fj = System.Windows.Forms.Application.OpenForms["PanelJasnosc"];
        System.Windows.Forms.Form ffk = System.Windows.Forms.Application.OpenForms["PanelFiltracjaKoloru"];
        FIP.FIP fip = new FIP.FIP();
        public Bitmap bmp;

        private void FormEdycja_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(((Form1)f1).bmp, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            histogramy(sender, e, bmp);
        }

        private void buttonGrayscaleAVG_Click(object sender, EventArgs e)
        {
            Bitmap luminance = fip.ToGreyscale(((Form1)f1).bmp);
            ((Form1)f1).bmp = luminance;
            ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            histogramy(sender, e, ((Form1)f1).bmp);
        }

        private void buttonGrayscaleAVG_MouseEnter(object sender, EventArgs e)
        {
            Bitmap luminance = fip.ToGreyscale(bmp);
            pictureBox1.Image = luminance;
            histogramy(sender, e, luminance);
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            bmp = new Bitmap(((Form1)f1).bmp, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            histogramy(sender, e, bmp);
        }

        private void buttonGrayscaleLightness_Click(object sender, EventArgs e)
        {
            Bitmap lightness = fip.ToGreyscaleLightness(((Form1)f1).bmp);
            ((Form1)f1).bmp = lightness;
            ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            histogramy(sender, e, ((Form1)f1).bmp);
        }

        private void buttonGrayscaleLightness_MouseEnter(object sender, EventArgs e)
        {
            Bitmap lightness = fip.ToGreyscaleLightness(bmp);
            pictureBox1.Image = lightness;
            histogramy(sender, e, lightness);
        }

        private void buttonGrayscaleLuminance_Click(object sender, EventArgs e)
        {
            Bitmap luminance = fip.ToGreyscale(((Form1)f1).bmp);
            ((Form1)f1).bmp = luminance;
            ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            histogramy(sender, e, ((Form1)f1).bmp);
        }

        private void buttonGrayscaleLuminance_MouseEnter(object sender, EventArgs e)
        {
            Bitmap luminance = fip.ToGreyscale(bmp);
            pictureBox1.Image = luminance;
            histogramy(sender, e, luminance);
        }

        private void buttonBlackWhite_Click(object sender, EventArgs e)
        {
            fbw = new PanelBW();
            fbw.Show();
        }

        private void buttonBlackWhite_MouseEnter(object sender, EventArgs e)
        {
            Bitmap bw = fip.ToBlackwhite(bmp, 128);
            pictureBox1.Image = bw;
            histogramy(sender, e, bw);
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            Bitmap negative = fip.NegativeImageColor(((Form1)f1).bmp);
            ((Form1)f1).bmp = negative;
            ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            histogramy(sender, e, ((Form1)f1).bmp);
        }

        private void buttonNegative_MouseEnter(object sender, EventArgs e)
        {
            Bitmap negative = fip.NegativeImageColor(bmp);
            pictureBox1.Image = negative;
            histogramy(sender, e, negative);
        }

        private void buttonInverse_Click(object sender, EventArgs e)
        {
            fi = new PanelInverse();
            fi.Show();
        }

        private void buttonInverse_MouseEnter(object sender, EventArgs e)
        {
            Bitmap inverse = fip.InverseImage(bmp, 128);
            pictureBox1.Image = inverse;
            histogramy(sender, e, inverse);
        }

        private void buttonDetekcjaKrawedzi_Click(object sender, EventArgs e)
        {
            Bitmap prewitt1 = fip.ImagePrewittFilterColor(((Form1)f1).bmp);
            ((Form1)f1).bmp = prewitt1;
            ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            histogramy(sender, e, ((Form1)f1).bmp);
        }

        private void buttonDetekcjaKrawedzi_MouseEnter(object sender, EventArgs e)
        {
            Bitmap prewitt1 = fip.ImagePrewittFilterColor(bmp);
            pictureBox1.Image = prewitt1;
            histogramy(sender, e, prewitt1);
        }

        private void buttonFiltracjaKoloru_Click(object sender, EventArgs e)
        {
            ffk = new PanelFiltracjaKoloru();
            ffk.Show();
        }
        

        private void buttonKuwahara_Click(object sender, EventArgs e)
        {
            Bitmap kuwahara = fip.ImageKuwaharaFilterColor(((Form1)f1).bmp, 3);
            ((Form1)f1).bmp = kuwahara;
            ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            histogramy(sender, e, ((Form1)f1).bmp);
        }

        private void buttonKuwahara_MouseEnter(object sender, EventArgs e)
        {
            Bitmap kuwahara = fip.ImageKuwaharaFilterColor(bmp, 3);
            pictureBox1.Image = kuwahara;
            histogramy(sender, e, kuwahara);
        }

        private void buttonErosion_Click(object sender, EventArgs e)
        {
            Bitmap erosion = fip.ImageErosionFilterGS(((Form1)f1).bmp, 3);
            ((Form1)f1).bmp = erosion;
            ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            histogramy(sender, e, ((Form1)f1).bmp);
        }

        private void buttonErosion_MouseEnter(object sender, EventArgs e)
        {
            Bitmap erosion = fip.ImageErosionFilterGS(bmp, 3);
            pictureBox1.Image = erosion;
            histogramy(sender, e, erosion);
        }

        private void buttonDilatation_Click(object sender, EventArgs e)
        {
            Bitmap dilatation = fip.ImageDilatationFilterGS(((Form1)f1).bmp, 3);
            ((Form1)f1).bmp = dilatation;
            ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            histogramy(sender, e, ((Form1)f1).bmp);
        }

        private void buttonDilatation_MouseEnter(object sender, EventArgs e)
        {
            Bitmap dilatation = fip.ImageDilatationFilterGS(bmp, 3);
            pictureBox1.Image = dilatation;
            histogramy(sender, e, dilatation);
        }

        private void buttonTiltShift_Click(object sender, EventArgs e)
        {
            Bitmap tiltshift = fip.TiltShift(((Form1)f1).bmp);
            ((Form1)f1).bmp = tiltshift;
            ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            histogramy(sender, e, ((Form1)f1).bmp);
        }

        private void buttonTiltShift_MouseEnter(object sender, EventArgs e)
        {
            Bitmap tiltshift = fip.TiltShift(bmp);
            pictureBox1.Image = tiltshift;
            histogramy(sender, e, tiltshift);
        }

        private void buttonSzkic_Click(object sender, EventArgs e)
        {
            Bitmap sketch = fip.Sketch(((Form1)f1).bmp);
            ((Form1)f1).bmp = sketch;
            ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            histogramy(sender, e, ((Form1)f1).bmp);
        }

        private void buttonSzkic_MouseEnter(object sender, EventArgs e)
        {
            Bitmap sketch = fip.Sketch(bmp);
            pictureBox1.Image = sketch;
            histogramy(sender, e, sketch);
        }

        private void buttonOilPaint_Click(object sender, EventArgs e)
        {
            Bitmap oilpaint = fip.OilPaint(((Form1)f1).bmp, 7, 20);
            ((Form1)f1).bmp = oilpaint;
            ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            histogramy(sender, e, ((Form1)f1).bmp);
        }

        private void buttonOilPaint_MouseEnter(object sender, EventArgs e)
        {
            Bitmap oilpaint = fip.OilPaint(bmp, 7, 20);
            pictureBox1.Image = oilpaint;
            histogramy(sender, e, oilpaint);
        }

        private void buttonCartoon_Click(object sender, EventArgs e)
        {
            Bitmap cartoon = fip.Cartoon(((Form1)f1).bmp, 7, 10, 40, fip.LaplaceF1());
            ((Form1)f1).bmp = cartoon;
            ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            histogramy(sender, e, ((Form1)f1).bmp);
        }

        private void buttonCartoon_MouseEnter(object sender, EventArgs e)
        {
            Bitmap cartoon = fip.Cartoon(bmp, 7, 10, 40, fip.LaplaceF1());
            pictureBox1.Image = cartoon;
            histogramy(sender, e, cartoon);
        }

        private void buttonObrot_Click(object sender, EventArgs e)
        {
            fo = new PanelObrot();
            fo.Show();
        }

        private void buttonContrast_Click(object sender, EventArgs e)
        {
            fc = new PanelContrast();
            fc.Show();
        }

        private void buttonContrast_MouseEnter(object sender, EventArgs e)
        {
            ContrastCorrection filter = new ContrastCorrection(30);
            Bitmap kontrast = new Bitmap(bmp);
            filter.ApplyInPlace(kontrast);
            pictureBox1.Image = kontrast;
            histogramy(sender, e, kontrast);
        }

        private void buttonGamma_Click(object sender, EventArgs e)
        {
            fg = new PanelGamma();
            fg.Show();
        }

        private void buttonGamma_MouseEnter(object sender, EventArgs e)
        {
            Bitmap gamma = fip.GammaCorrection(bmp, 0.25);
            pictureBox1.Image = gamma;
            histogramy(sender, e, gamma);
        }

        private void buttonPrzesuwanieHistogramu_Click(object sender, EventArgs e)
        {
            fph = new PanelPrzesuwanieHistogramu();
            fph.Show();
        }

        private void buttonWyrownanieHistogramu_Click(object sender, EventArgs e)
        {
            Bitmap histeq = fip.HistoramEqualization(((Form1)f1).bmp);
            ((Form1)f1).bmp = histeq;
            ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            histogramy(sender, e, ((Form1)f1).bmp);
        }

        private void buttonWyrownanieHistogramu_MouseEnter(object sender, EventArgs e)
        {
            Bitmap histeq = fip.HistoramEqualization(bmp);
            pictureBox1.Image = histeq;
            histogramy(sender, e, histeq);
        }

        public void histogramy(object sender, EventArgs e, Bitmap bitmap)
        {
            this.histogramGray.Series.Clear();
            this.histogramRGB.Series.Clear();

            int[,] rgb = fip.RGBHistogram(bitmap);
            int[] greyscaleHistogram = fip.Histogram(bitmap);

            Series series = this.histogramGray.Series.Add("Szarość");
            series.Points.DataBindY(greyscaleHistogram);

            Series series1 = this.histogramRGB.Series.Add("1");
            for (int i = 0; i < rgb.GetLength(1); i++)
                series1.Points.Add(rgb[0, i]);
            Series series2 = this.histogramRGB.Series.Add("2");
            for (int i = 0; i < rgb.GetLength(1); i++)
                series2.Points.Add(rgb[1, i]);
            Series series3 = this.histogramRGB.Series.Add("3");
            for (int i = 0; i < rgb.GetLength(1); i++)
                series3.Points.Add(rgb[2, i]);

            this.histogramGray.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            this.histogramGray.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            this.histogramGray.Series[0].ChartType = SeriesChartType.Line;
            this.histogramRGB.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            this.histogramRGB.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            this.histogramRGB.Series[0].ChartType = SeriesChartType.Line;
            this.histogramRGB.Series[1].ChartType = SeriesChartType.Line;
            this.histogramRGB.Series[2].ChartType = SeriesChartType.Line;
            this.histogramRGB.Series[0].Color = Color.Red;
            this.histogramRGB.Series[1].Color = Color.Green;
            this.histogramRGB.Series[2].Color = Color.Blue;
        }

        private void buttonZmianaRozmiaru_Click(object sender, EventArgs e)
        {
            fzr = new PanelZmianaRozmiaru();
            fzr.Show();
        }

        private void buttonJasnosc_Click(object sender, EventArgs e)
        {
            fj = new PanelJasnosc();
            fj.Show();
        }

        private void buttonJasnosc_MouseEnter(object sender, EventArgs e)
        {
            BrightnessCorrection filter = new BrightnessCorrection(-50);
            Bitmap jasnosc = new Bitmap(bmp);
            filter.ApplyInPlace(jasnosc);
            pictureBox1.Image = jasnosc;
            histogramy(sender, e, jasnosc);
        }
    }
}
