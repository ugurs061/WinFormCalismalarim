using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void btnListele_Click(object sender, EventArgs e)
        {
            int sayi1 = 1;
            int sayi2 = 1;
            int sayi3;
            int kadar = Convert.ToInt32(txtSayi.Text);

            lbSonuc.Items.Add(sayi1);
            lbSonuc.Items.Add(sayi2);

            for (int i = 1; i < kadar; i++)
            {
                sayi3 = sayi1 + sayi2;
                sayi1 = sayi2;
                sayi2 = sayi3;
                lbSonuc.Items.Add(sayi3);
            }
            
            
        }
    }
}
