using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsalSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            bool bolunmeDurum = false;
            int sinirDeger=Convert.ToInt32(txtSinirDeger.Text);

            for (int sayi = 2; sayi < sinirDeger; sayi++)
            {
                bolunmeDurum = false;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        bolunmeDurum = true;
                        break;
                    }

                }
                if (!bolunmeDurum)
                {
                    toplam += sayi;

                }

            }
            txtSonuc.Text=toplam.ToString();
        }
    }
}
