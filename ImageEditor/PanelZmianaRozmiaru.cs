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
    public partial class PanelZmianaRozmiaru : Form
    {
        public PanelZmianaRozmiaru()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form fe = System.Windows.Forms.Application.OpenForms["FormEdycja"];
        System.Windows.Forms.Form f1 = System.Windows.Forms.Application.OpenForms["Form1"];
        FIP.FIP fip = new FIP.FIP();

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0 && numericUpDown2.Value > 0)
            {
                Bitmap img3 = fip.Resize2(((FormEdycja)fe).bmp, (int)numericUpDown1.Value - 339, (int)numericUpDown2.Value - 277);
                ((FormEdycja)fe).pictureBox1.Image = img3;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0 && numericUpDown2.Value > 0)
            {
                Bitmap img3 = fip.Resize2(((Form1)f1).bmp, (int)numericUpDown1.Value, (int)numericUpDown2.Value);
                ((Form1)f1).bmp = img3;
                ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
                this.Close();
            }
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            ((FormEdycja)fe).bmp = new Bitmap(((Form1)f1).bmp, ((FormEdycja)fe).pictureBox1.Width, ((FormEdycja)fe).pictureBox1.Height);
            ((FormEdycja)fe).pictureBox1.Image = ((FormEdycja)fe).bmp;
            this.Close();
        }
    }
}
