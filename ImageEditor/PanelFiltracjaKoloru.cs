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
    public partial class PanelFiltracjaKoloru : Form
    {
        public PanelFiltracjaKoloru()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form fe = System.Windows.Forms.Application.OpenForms["FormEdycja"];
        System.Windows.Forms.Form f1 = System.Windows.Forms.Application.OpenForms["Form1"];
        FIP.FIP fip = new FIP.FIP();

        private void label_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Bitmap filteredColor = fip.ColorFiltration(((FormEdycja)fe).bmp, label.Text);
            ((FormEdycja)fe).pictureBox1.Image = filteredColor;
            ((FormEdycja)fe).histogramy(sender, e, ((FormEdycja)fe).bmp);
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Bitmap filteredColor = fip.ColorFiltration(((Form1)f1).bmp, label.Text);
            ((Form1)f1).bmp = filteredColor;
            ((Form1)f1).pictureBox1.Image = ((Form1)f1).bmp;
            ((FormEdycja)fe).histogramy(sender, e, ((Form1)f1).bmp);
        }
    }
}
