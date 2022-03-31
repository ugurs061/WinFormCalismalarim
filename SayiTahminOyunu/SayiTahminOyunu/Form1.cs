using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        
        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            int hak, tahmin;
            
            try
            {
                tahmin = int.Parse(txtSayi.Text);
            }
            catch
            {
                MessageBox.Show("Hatalı Sayı Girdiniz");
                return;
            }
            hak=int.Parse(lblHakSayi.Text);
            hak--;
            lblHakSayi.Text=hak.ToString();


            if (sayi<tahmin)
            {
                lblDurum.Text = "Aşağı";
            }
            else if (sayi>tahmin)
            {
                lblDurum.Text = "Yukarı";
            }
            else
            {
                lblDurum.Text = "TEBRİKLER!";
                MessageBox.Show("TEBRİKLER!");

                btnTahminEt.Enabled = false;    
                btnBasla.Enabled = true;
                
            }
            txtSayi.Text = "";
            if (hak==0)
            {
                MessageBox.Show("Hakkınız bitti");
            }

        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTahminEt.Enabled = false;
            lblHakSayi.Text = "6";

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            btnTahminEt.Enabled = true;
            btnBasla.Enabled = false;
            Random r = new Random();
            //sayi = r.Next(0, 64);
            sayi = 61;
            lblHakSayi.Text = "6";
        }
    }
}
