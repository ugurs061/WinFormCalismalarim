using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekrarEdenKelimeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMetin.Text = "evet evet hayır";
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            //string text = textBox1.Text;
            //string[] words = text.Split(' ');
            //Dictionary<string, int> dic = new Dictionary<string, int>();

            //for (int i = 0; i < words.Length; i++)
            //{
            //    int sayac = 0;
            //    for (int j = i + 1; j < words.Length; j++)
            //    {
            //        if (words[i] == words[j])
            //        {
            //            sayac++;
            //            if (!dic.TryGetValue(words[i], out int temp))
            //            {
            //                dic.Add(words[i], sayac + 1);
            //            }
            //        }

            //    }
            //}

            //listBox1.Items.Clear();
            //foreach (var item in dic)
            //{
            //    listBox1.Items.Add($"{item.Key} = {item.Value}");
            //}

            // çözüm 2 - linq kullandık
            lbSonuc.Items.Clear();
            var arr = txtMetin.Text.Split(' ').GroupBy(x => x);
            foreach (var item in arr)
            {
                lbSonuc.Items.Add($"{item.Key} {item.Count()}");
            }
        }


    }
}
