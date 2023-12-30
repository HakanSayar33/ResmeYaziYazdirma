using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resim_Yazi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        string resim;
        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;
        }

        Color renk;
        private void btnRenk_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }

        Bitmap bmp;
        private void btnYaz_Click(object sender, EventArgs e)
        {
            try
            {
                bmp = new Bitmap(resim);
                Graphics gr = Graphics.FromImage(bmp);
                gr.DrawString(textMetin.Text, new Font("Mistral", Convert.ToUInt16(textBoyut.Text), FontStyle.Bold), new SolidBrush(renk), 20, 30);
                pictureBox1.Image = bmp;
            }
            catch
            {
                MessageBox.Show("Tüm değerleri doğru girdiğinizden emin olun!");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Resim|.jpg";
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}
