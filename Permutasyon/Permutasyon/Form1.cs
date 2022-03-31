using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Permutasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            int[] seri = { 1, 2, 3, 4, 5, 6, 7 };
            string s = "";
            for (int i = 0; i < seri.Length; i++)
            {
                Console.WriteLine($"{seri[i]}");
                s += seri[i].ToString();
                for (int j = i + 1; j < seri.Length; j++)
                {
                    lbSonuc.Items.Add($"{seri[i]},{seri[j]}");
                    
                }
            }
            lbSonuc.Items.Add(s);

        }
    }
}
