using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaYarısıTutorial
{
    public partial class Form1 : Form
    {
        //Ses ekleme
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");

        Random r = new Random();
        int x, y, z;

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            if (pictureBoxSariAraba.Location.X - pictureBoxSariAraba.Width >= lblFinish.Location.X-130)
            {
                timer1.Stop();
                lblDurum.Text = "SARI ARABA KAZANDI";
                this.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show("SARI ARABA KAZANDI");
                finishSoundPlayer.Play();//bitiş sesi
                
                return;

            }
            if (pictureBoxMaviAraba.Location.X - pictureBoxMaviAraba.Width >= lblFinish.Location.X-130)
            {
                timer1.Stop();
                lblDurum.Text = "MAVİ ARABA KAZANDI";
                this.BackColor = System.Drawing.Color.Blue;
                MessageBox.Show("MAVİ ARABA KAZANDI");
                finishSoundPlayer.Play();//bitiş sesi
                return;

            }
            if (pictureBoxYesilAraba.Location.X - pictureBoxYesilAraba.Width >= lblFinish.Location.X-130)
            {
                timer1.Stop();
                lblDurum.Text = "YEŞİL ARABA KAZANDI";
                this.BackColor = System.Drawing.Color.Green;
                MessageBox.Show("YEŞİL ARABA KAZANDI");
                finishSoundPlayer.Play();//bitiş sesi
                return;

            }

            x = r.Next(5, 10);
            pictureBoxSariAraba.Left += x;

            y = r.Next(5, 10);
            pictureBoxMaviAraba.Left += y;

            z = r.Next(5, 10);
            pictureBoxYesilAraba.Left += z;


            if (pictureBoxSariAraba.Location.X > pictureBoxMaviAraba.Location.X && pictureBoxSariAraba.Location.X > pictureBoxYesilAraba.Location.X)
            {
                lblDurum.Text = "Sarı araba önde";
                lblDurum.ForeColor = Color.Yellow;
              
            }
            else if (pictureBoxMaviAraba.Location.X > pictureBoxSariAraba.Location.X && pictureBoxMaviAraba.Location.X > pictureBoxYesilAraba.Location.X)
            {
                lblDurum.Text = "Mavi araba önde";
                lblDurum.ForeColor = Color.Blue;

            }
            else if (pictureBoxYesilAraba.Location.X > pictureBoxSariAraba.Location.X && pictureBoxYesilAraba.Location.X > pictureBoxMaviAraba.Location.X)
            {
                lblDurum.Text = "Yeşil araba önde";
                lblDurum.ForeColor = Color.Green;

            }
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            pictureBoxSariAraba.Left = 1;
            pictureBoxMaviAraba.Left = 1;
            pictureBoxYesilAraba.Left = 1;

            lblDurum.Text = "";


        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            startSoundPlayer.Play();//açılış sesi.
            timer1.Start();

        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
