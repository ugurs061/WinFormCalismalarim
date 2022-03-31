using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnKucukEleman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] dizi = new int[10] ;
        int j = 0;
        
        private void btnSayiEkle_Click(object sender, EventArgs e)
        {
            
            dizi[j] = Convert.ToInt32(txtSayi.Text);
            j++;
            txtSayi.Text = "";
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            foreach (int eleman in dizi)
            {
                try
                {
                    if (eleman == 0)
                    {
                        lbSonuc.Items.Add(" ");
                    }
                    else
                    {
                        lbSonuc.Items.Add(eleman);
                    }
                }
                catch { }
            }
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
           lbSonuc.Sorted = true;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lbSonuc.Items.Clear();
        }
    }
}
