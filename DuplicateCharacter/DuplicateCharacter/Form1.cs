using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateCharacter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            string input = txtMetin.Text;
            string output = "";
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    output += input[i].ToString() + input[i - 1].ToString();
                }
            }
            txtHarfler.Text = output;
            
        }
    }
}
