using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace sayı_tahmin
{
    public partial class tahminet : Form
    {
        public tahminet()
        {
            InitializeComponent();
        }
        int tahmin = 0;
        private void btnhelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En kısa süre içerisinde tahmin edilen sayıyı yönlendirmelerle bulma oyunu.100 saniyeniz var.");
        }

        private void btnbasla_Click(object sender, EventArgs e)
        {
            Random sayi = new Random();
            tahmin = sayi.Next(1,100);
            timer1.Enabled = true;
        }
        int rasgelesayi = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                
            }

            if (int.TryParse(textBox1.Text, out int sonuc))
            {
                rasgelesayi = sonuc;
               
            }
            else
            {
                labelkontrol.Text = "Lütfen geçerli bir sayı girin.";
            }
        }
        SoundPlayer dogruSes = new SoundPlayer(@"C:\Users\egenu\Desktop\kod\c#\sayı tahmin\sayı tahmin\ses\dogru.wav");
        SoundPlayer yanlisSes = new SoundPlayer(@"C:\Users\egenu\Desktop\kod\c#\sayı tahmin\sayı tahmin\ses\yanlis.wav");
        private void btnKontrol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                labelkontrol.Text = "Lütfen bir sayı girin.";
                return; 
            }
            
            if (tahmin==rasgelesayi) 
            {
                labelkontrol.Text = ("Tebrikler! Tahmin edilen sayıyı buldunuz");
                timer1.Enabled=false;
                dogruSes.Play();
            }
            else if (tahmin>rasgelesayi)
            {
                labelkontrol.Text = ("Daha Büyük");
                yanlisSes.Play();
            }
            else if (tahmin < rasgelesayi)
            {
                labelkontrol.Text = ("Daha Küçük");
                yanlisSes.Play();
            }
        }
        int sure = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            labelsure.Text = Convert.ToString(sure);
            if(sure <=10)
            {
                labelpuan.Text = "100";
            }
            else if(sure > 10 && sure<=20)
            {
                labelpuan.Text = "90";
            }
            else if (sure > 20 && sure <= 30)
            {
                labelpuan.Text = "80";
            }
            else if (sure > 30 && sure <= 40)
            {
                labelpuan.Text = "70";
            }
            else if (sure > 40 && sure <= 50)
            {
                labelpuan.Text = "60";
            }
            else if (sure > 50 && sure <= 60)
            {
                labelpuan.Text = "50";
            }
            else if (sure > 60 && sure <= 70)
            {
                labelpuan.Text = "40";
            }
            else if (sure > 70 && sure <= 80)
            {
                labelpuan.Text = "30";
            }
            else if (sure > 80 && sure <= 90)
            {
                labelpuan.Text = "20";
            }
            else if (sure > 90 && sure <=100)
            {
                labelpuan.Text = "10";
            }
            else if (sure > 100)
            {
                labelpuan.Text = "0";
                MessageBox.Show("Kaybettiniz.");
            }
        }

        private void tahminet_Load(object sender, EventArgs e)
        {

        }
    }
}
