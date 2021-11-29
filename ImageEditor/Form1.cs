using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Form fe = System.Windows.Forms.Application.OpenForms["FormEdycja"];
        bool leave = false, enter = false;
        public Bitmap bmp, tbmp, ebmp;
        public string path;

        /*
        - Przesuwanie histogramu - shifting
        - zmiana wartości w filtrach przez textbox
        */

        private void PictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                if (e.Delta > 0)
                {
                    if (pictureBox1.Image != null)
                    {
                        double zoomIn = 1.1;
                        tbmp = new Bitmap(Bitmap.FromFile(path), Convert.ToInt32(bmp.Width * zoomIn),
                            Convert.ToInt32(bmp.Height * zoomIn));
                        bmp = new Bitmap(tbmp);
                        pictureBox1.Image = bmp;
                    }
                }
                if (e.Delta < 0) 
                {
                    if (pictureBox1.Image != null)
                    {
                        double zoomOut = 0.9;
                        tbmp = new Bitmap(Bitmap.FromFile(path), Convert.ToInt32(bmp.Width * zoomOut),
                            Convert.ToInt32(bmp.Height * zoomOut));
                        bmp = new Bitmap(tbmp);
                        pictureBox1.Image = bmp;
                    }
                }
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
                fe.Close();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path = openFileDialog1.FileName;
                    bmp = new Bitmap(Image.FromFile(path));
                    pictureBox1.Image = bmp;
                    buttonEdycja.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd podczas ładowania pliku");
                }
            }
        }

        private void buttonEdycja_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                fe = new FormEdycja();
                fe.Show();
            }
        }

        private void PanelOpcje_MouseEnter(object sender, EventArgs e)
        { 
            timer1.Start();
            enter = true;
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if(bmp != null && tbmp != null)
            {
                bmp = new Bitmap(tbmp);
                pictureBox1.Image = bmp;
                tbmp = null;
            }

            if (pictureBox1.Image != null)
            {
                timer1.Start();
                leave = true;
            }
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (saveFileDialog1.FileName != "")
                    {
                        Bitmap bitmap = new Bitmap(bmp);
                        System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                        pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);

                        fs.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd podczas zapisywania do pliku");
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                bmp = new Bitmap(Image.FromFile(path), pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = bmp;
                ebmp = new Bitmap(bmp, ((FormEdycja)fe).pictureBox1.Width, ((FormEdycja)fe).pictureBox1.Height);
                ((FormEdycja)fe).pictureBox1.Image = ebmp;
                ((FormEdycja)fe).histogramy(sender, e, bmp);
            }
        }

        private void PictureBox1_SizeChanged(object sender, EventArgs e)
        {
            /*if (bmp != null)
            {
                tbmp = new Bitmap(bmp, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = tbmp;
            }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (leave)
            {
                if (panelOpcje.Height > 10) {
                    panelOpcje.Height -= 4;
                }
                    
                else
                {
                    timer1.Stop();
                    leave = false;
                }
            }
            else if (enter)
            {
                if (panelOpcje.Height < 50)
                    panelOpcje.Height += 4;
                else
                {
                    timer1.Stop();
                    enter = false;
                }
            }
        }
    }
}
