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
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\rexts\Desktop\AtYarisiTutorial\ArabaYarısıTutorial\ArabaYarısıTutorial\bin\Debug\ses\at.wav");
        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");

        Random r = new Random();
        int x, y, z;

        private void timer1_Tick(object sender, EventArgs e)
        {
         //finish 
            if (pictureBoxKirmiziAt.Location.X - pictureBoxKirmiziAt.Width >= lblFinish.Location.X-130)
            {
                timer1.Stop();
                lblDurum.Text = "BEYAZ AT KAZANDI";
                this.BackColor = System.Drawing.Color.White;
                MessageBox.Show("BEYAZ AT KAZANDI");
                finishSoundPlayer.Play();//bitiş sesi
                btnYeniOyun.Enabled = true;
                return;

            }
            if (pictureBoxPembeAt.Location.X - pictureBoxPembeAt.Width >= lblFinish.Location.X-130)
            {
                timer1.Stop();
                lblDurum.Text = "PEMBE AT KAZANDI";
                this.BackColor = System.Drawing.Color.Pink;
                MessageBox.Show("PEMBE AT KAZANDI");
                finishSoundPlayer.Play();//bitiş sesi
                btnYeniOyun.Enabled = true;
                return;

            }
            if (pictureBoxMaviAt.Location.X - pictureBoxMaviAt.Width >= lblFinish.Location.X-130)
            {
                timer1.Stop();
                lblDurum.Text = "MAVİ AT KAZANDI";
                this.BackColor = System.Drawing.Color.Blue;
                MessageBox.Show("MAVİ AT KAZANDI");
                finishSoundPlayer.Play();//bitiş sesi
                btnYeniOyun.Enabled = true;
                return;

            }
            //hareket
            x = r.Next(10, 30);
            pictureBoxKirmiziAt.Left += x;
            y = r.Next(10, 30);
            pictureBoxPembeAt.Left += y;
            z = r.Next(10, 30);
            pictureBoxMaviAt.Left += z;

            //durum info
            if (pictureBoxKirmiziAt.Location.X > pictureBoxPembeAt.Location.X && pictureBoxKirmiziAt.Location.X > pictureBoxMaviAt.Location.X)
            {
                lblDurum.Text = "Beyaz at önde";
                lblDurum.ForeColor = Color.White;
              
            }
            else if (pictureBoxPembeAt.Location.X > pictureBoxKirmiziAt.Location.X && pictureBoxPembeAt.Location.X > pictureBoxMaviAt.Location.X)
            {
                lblDurum.Text = "Pembe at önde";
                lblDurum.ForeColor = Color.Pink;

            }
            else if (pictureBoxMaviAt.Location.X > pictureBoxKirmiziAt.Location.X && pictureBoxMaviAt.Location.X > pictureBoxPembeAt.Location.X)
            {
                lblDurum.Text = "Mavi at önde";
                lblDurum.ForeColor = Color.Blue;

            }
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            //Yeni oyun atları başlangıç konumuna getirme 
            this.BackColor = System.Drawing.Color.Green;

            pictureBoxKirmiziAt.Left = 1;
            pictureBoxPembeAt.Left = 1;
            pictureBoxMaviAt.Left = 1;

            lblDurum.Text = "";
            btnYeniOyun.Enabled = false;

            startSoundPlayer.Play();

        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            // adım adım hareket etmek için timer2 kullandık
            timer1.Stop();
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           //space basınca çalışması için
            if (e.KeyCode == Keys.Space)
            {
                
                timer1.Start();
                timer2.Start();
            }
            
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startSoundPlayer.Play();
        }

        

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            timer2.Start();
            
            
            btnYeniOyun.Enabled = false;

        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
