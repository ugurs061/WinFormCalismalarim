using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SıcaklıkHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(txtC.Text);
            lblF.Text = Convert.ToString((c * 1.8) + 32);
            lblK.Text = Convert.ToString((c * 273.5));


        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(txtF.Text);
            lblC.Text = Convert.ToString((f - 32) * 5 / 9);
            lblK2.Text = Convert.ToString((f + 459.67) * 5 / 9);
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            double k = Convert.ToDouble(txtK.Text);
            label12.Text = Convert.ToString((k - 273.15));
            label13.Text = Convert.ToString((k * 9 / 5) - 459); 

        }
    }
}
