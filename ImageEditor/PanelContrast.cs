using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using FIP;

namespace ImageEditor
{
    public partial class PanelContrast : Form
    {
        public PanelContrast()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form fe = System.Windows.Forms.Application.OpenForms["FormEdycja"];
        System.Windows.Forms.Form f1 = System.Windows.Forms.Application.OpenForms["Form1"];
        FIP.FIP fip = new FIP.FIP();

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ContrastCorrection filter = new ContrastCorrection((int)numericUpDown1.Value);
            Bitmap kontrast = new Bitmap(((Form1)f1).bmp);
            filter.ApplyInPlace(kontrast);
            ((Form1)f1).bmp = kontrast;
            ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            this.Close();
            ((FormEdycja)fe).histogramy(sender, e, ((Form1)f1).bmp);
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            ((FormEdycja)fe).bmp = new Bitmap(((Form1)f1).bmp, ((FormEdycja)fe).pictureBox1.Width, ((FormEdycja)fe).pictureBox1.Height);
            ((FormEdycja)fe).pictureBox1.Image = ((FormEdycja)fe).bmp;
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ContrastCorrection filter = new ContrastCorrection((int)numericUpDown1.Value);
            Bitmap kontrast = new Bitmap(((FormEdycja)fe).bmp);
            filter.ApplyInPlace(kontrast);
            ((FormEdycja)fe).pictureBox1.Image = kontrast;
            ((FormEdycja)fe).histogramy(sender, e, ((FormEdycja)fe).bmp);
        }
    }
}
