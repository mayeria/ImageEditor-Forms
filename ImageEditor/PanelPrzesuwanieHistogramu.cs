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

namespace ImageEditor
{
    public partial class PanelPrzesuwanieHistogramu : Form
    {
        public PanelPrzesuwanieHistogramu()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form fe = System.Windows.Forms.Application.OpenForms["FormEdycja"];
        System.Windows.Forms.Form f1 = System.Windows.Forms.Application.OpenForms["Form1"];
        FIP.FIP fip = new FIP.FIP();

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Bitmap histshift = fip.HistogramShift(((FormEdycja)fe).bmp, (int)numericUpDown1.Value);
                ((FormEdycja)fe).pictureBox1.Image = histshift;

                ((FormEdycja)fe).histogramy(sender, e, ((FormEdycja)fe).bmp);
            }
            catch { }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap histshift = fip.HistogramShift(((Form1)f1).bmp, (int)numericUpDown1.Value);
                ((Form1)f1).bmp = histshift;
                ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            }
            catch { }
            this.Close();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            ((FormEdycja)fe).bmp = new Bitmap(((Form1)f1).bmp, ((FormEdycja)fe).pictureBox1.Width, ((FormEdycja)fe).pictureBox1.Height);
            ((FormEdycja)fe).pictureBox1.Image = ((FormEdycja)fe).bmp;

            ((FormEdycja)fe).histogramy(sender, e, ((FormEdycja)fe).bmp);
            this.Close();
        }
    }
}
