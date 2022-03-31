using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnBuyukIkinciSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayi = new int[10];

        private void btnEkle_Click(object sender, EventArgs e)
        {
            /*
            int a;
            try
            {
                a = Convert.ToInt32(textBox1.Text);
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Sayısal Bir Değer Girin", "Uyarı", MessageBoxButtons.OK);
            }
            */

            for (int i = 0; i < sayi.Length; i++)
            {
                sayi[i] = Convert.ToInt32(txtSayi.Text);
            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnIkinciSayi_Click(object sender, EventArgs e)
        {
            /*
            int enBuyuk = Convert.ToInt32(listBox1.Items[0]), sayi;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayi = Convert.ToInt32(listBox1.Items[i]);
                if (sayi > enBuyuk)
                {
                    enBuyuk = sayi;
                }
            }
            label1.Text=enBuyuk.ToString();
            */
            Array.Sort(sayi);
            int enBuyuk=sayi[sayi.Length-2];

            lblSonuc.Text=enBuyuk.ToString();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sayi.Length; i++)
            {
                lbListe.Items.Add(sayi[i]);
                break;
            }
            
        }
    }
}
