using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamKare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        
        private void btnBul_Click(object sender, EventArgs e)
        {
            int son = Convert.ToInt32(txtSayi.Text);
            for (i = 0; i < son; i++)
            {
                if ((i * i < son))
                {
                    lbSonuc.Items.Add(Math.Pow(i, 2));
                    
                }
            }
            
        }
    }
}
