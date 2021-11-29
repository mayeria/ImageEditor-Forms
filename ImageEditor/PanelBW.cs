using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIP;

namespace ImageEditor
{
    public partial class PanelBW : Form
    {
        public PanelBW()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form fe = System.Windows.Forms.Application.OpenForms["FormEdycja"];
        System.Windows.Forms.Form f1 = System.Windows.Forms.Application.OpenForms["Form1"];
        FIP.FIP fip = new FIP.FIP();

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Bitmap bw = fip.ToBlackwhite(((FormEdycja)fe).bmp, (int)numericUpDown1.Value);
            ((FormEdycja)fe).pictureBox1.Image = bw;
            ((FormEdycja)fe).histogramy(sender, e, bw);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Bitmap bw = fip.ToBlackwhite(((Form1)f1).bmp, (int)numericUpDown1.Value);
            ((Form1)f1).bmp = bw;
            ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            ((FormEdycja)fe).histogramy(sender, e, ((Form1)f1).bmp);
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
