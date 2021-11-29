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
    public partial class PanelObrot : Form
    {
        public PanelObrot()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form fe = System.Windows.Forms.Application.OpenForms["FormEdycja"];
        System.Windows.Forms.Form f1 = System.Windows.Forms.Application.OpenForms["Form1"];
        FIP.FIP fip = new FIP.FIP();

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Bitmap rotate = fip.Rotate(((FormEdycja)fe).bmp, trackBar1.Value);
            numericUpDown1.Value = trackBar1.Value;
            ((FormEdycja)fe).pictureBox1.Image = rotate;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)numericUpDown1.Value;
            trackBar1_Scroll(sender, e);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Bitmap rotate = fip.Rotate(((Form1)f1).bmp, trackBar1.Value);
            ((Form1)f1).bmp = rotate;
            ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            this.Close();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            ((FormEdycja)fe).bmp = new Bitmap(((Form1)f1).bmp, ((FormEdycja)fe).pictureBox1.Width, ((FormEdycja)fe).pictureBox1.Height);
            ((FormEdycja)fe).pictureBox1.Image = ((FormEdycja)fe).bmp;
            this.Close();
        }
    }
}
