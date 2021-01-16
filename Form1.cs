/****************************************************************************
// Hüseyin Hıra 2018
// Çiftlik Projem
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace _1A_B181210105_Proje
{
    public partial class Form1 : Form
    {
        //burada ana classımızdan gelen zaman sayacı için değişken oluşturduk
        Hayvan zamansayac = new Hayvan();
        //burada alt classlardan gelen hayvanların mahsüllerini tutan sayaçlarımızı oluşturduk
        Tavuk TavukYumurtaSayac = new Tavuk();
        Ördek ÖrdekYumurtaSayac = new Ördek();
        İnek İnekSütSayac = new İnek();
        Keçi KeçiSütSayac = new Keçi();
        //bu kısımda en son çıkacak sesler iççin timer içinde kullandığımız sayaçları oluşturduk
        int tavuksessayacı =0;
        int ördeksessayacı = 0;
        int ineksessayacı = 0;
        int keçisessayacı = 0;

        int kasa = 0;

        int i = 0;

        public Form1()
        {
            InitializeComponent();
            //bu kısımda  classlardan aldığımız bilgilere değer atadık 
            zamansayac.zaman = 0;
            TavukYumurtaSayac.TavukYumurta = 0;
            ÖrdekYumurtaSayac.ÖrdekYumurta = 0;
            İnekSütSayac.İnekSüt = 0;
            KeçiSütSayac.KeçiSüt = 0;



        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;//bu kısımda timer milisaniye ile çalıştığından zaman sürecini 1 saniyeye eşitledik 
            timer1.Enabled = true;// timeri aktif hale getirdik

            button9.Text = kasa.ToString() + " TL";//kasa bilgisinin anlık olarak butona yazılmasını sağladık

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            zamansayac.zaman++;
            i++;

            button10.Text = zamansayac.zaman.ToString();


            //tavuk değerlerini hesaplayan kısım
            if (progressBar1.Value!=0)
            {
                progressBar1.Value -=2;
            }
            if (progressBar1.Value == 0)//bu kısımda hayvanın ölü olup olmadığını kontrol edip yazdırdık
            {
                button1.Text = "ÖLÜ";

            }
            else
            {
                button1.Text = "CANLI";
            }
            if (button1.Text == "CANLI")//bu kısımda  yumurta üretimini ayarladık
            {
                if(i%3==0)
                {
                    TavukYumurtaSayac.TavukYumurta++;
                }

                
            }
            button15.Text = TavukYumurtaSayac.TavukYumurta.ToString() + " ADET";
            if (tavuksessayacı < 1)
            {
                if (button1.Text == "ÖLÜ")// bu kısımda  ses dosyasını çalıştıttırdık
                {
                    SoundPlayer player = new SoundPlayer();
                    string path = Application.StartupPath.ToString() + "\\tavuk.wav";
                    player.SoundLocation = path;
                    player.Play();
                    tavuksessayacı++;
                }

            }



            //ördek değerlerini hesaplayan kısım
            if (progressBar2.Value == 1)
            {
                progressBar2.Value -= 1;
            }
            if (progressBar2.Value != 0)
            {
                progressBar2.Value -= 3;
            }
            if (progressBar2.Value == 0)//bu kısımda hayvanın ölü olup olmadığını kontrol edip yazdırdık
            {
                button4.Text = "ÖLÜ";
            }
            else
            {
                button4.Text = "CANLI";
            }
            if (button4.Text == "CANLI")//bu kısımda  yumurta üretimini ayarladık
            {
                if (i % 5 == 0)
                {
                    ÖrdekYumurtaSayac.ÖrdekYumurta++;
                }
               
                
            }
            button18.Text = ÖrdekYumurtaSayac.ÖrdekYumurta.ToString() + " ADET";
            if (ördeksessayacı < 1)
            {
                if (button4.Text == "ÖLÜ")// bu kısımda  ses dosyasını çalıştıttırdık
                {
                    SoundPlayer player = new SoundPlayer();
                    string path = Application.StartupPath.ToString() + "\\ordek.wav";
                    player.SoundLocation = path;
                    player.Play();
                    ördeksessayacı++;
                }

            }

            //inek değerlerini hesaplayan kısım
            if (progressBar3.Value == 4)
            {
                progressBar3.Value -= 4;
            }
            if (progressBar3.Value != 0)
            {
                progressBar3.Value -= 8;
            }
            if (progressBar3.Value == 0)//bu kısımda hayvanın ölü olup olmadığını kontrol edip yazdırdık
            {
                button2.Text = "ÖLÜ";
 
            }
            else
            {
                button2.Text = "CANLI";
            }
            if (button2.Text == "CANLI")//bu kısımda  süt üretimini ayarladık
            {
                if (i % 8 == 0)
                {
                    İnekSütSayac.İnekSüt++;
                }
                
                
            }
            button17.Text = İnekSütSayac.İnekSüt.ToString() + " KG";
            if (ineksessayacı<1)
            {
                if (button2.Text == "ÖLÜ")// bu kısımda  ses dosyasını çalıştıttırdık
                {
                    SoundPlayer player = new SoundPlayer();
                    string path = Application.StartupPath.ToString() + "\\inek.wav";
                    player.SoundLocation = path;
                    player.Play();
                    ineksessayacı++;
                }
                
            }

            //keçi değerlerini hesaplayan kısım
            if (progressBar4.Value == 4)
            {
                progressBar4.Value -= 4;
            }
            if (progressBar4.Value != 0)
            {
                progressBar4.Value -= 6;
            }
            if (progressBar4.Value == 0)//bu kısımda hayvanın ölü olup olmadığını kontrol edip yazdırdık
            {
                button3.Text = "ÖLÜ";
            }
            else
            {
                button3.Text = "CANLI";
            }
            if (button3.Text == "CANLI")//bu kısımda  süt üretimini ayarladık
            {
                if (i % 7 == 0)
                {
                    KeçiSütSayac.KeçiSüt++;
                }
                
                
            }
            button19.Text = KeçiSütSayac.KeçiSüt.ToString() + " KG";
            if (keçisessayacı < 1)
            {
                if (button3.Text == "ÖLÜ")// bu kısımda  ses dosyasını çalıştıttırdık
                {
                    SoundPlayer player = new SoundPlayer();
                    string path = Application.StartupPath.ToString() + "\\keci.wav";
                    player.SoundLocation = path;
                    player.Play();
                    keçisessayacı++;
                }

            }


            
        }


        private void button8_Click(object sender, EventArgs e)
        {
            if (button1.Text == "CANLI")//bu kısımda butona basıldığında hayvanın canının artışını veya değişmeyişini yaptık
            {
                progressBar1.Value = 100;
            }
            else
            {
                button1.Enabled = false;
            }
        }

    

        private void button6_Click(object sender, EventArgs e)
        {
            if (button2.Text == "CANLI")//bu kısımda butona basıldığında hayvanın canının artışını veya değişmeyişini yaptık
            {
                progressBar3.Value = 100;
            }
            else
            {
                button6.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button4.Text == "CANLI")//bu kısımda butona basıldığında hayvanın canının artışını veya değişmeyişini yaptık
            {
                progressBar2.Value = 100;
            }
            else
            {
                button5.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button3.Text == "CANLI")//bu kısımda butona basıldığında hayvanın canının artışını veya değişmeyişini yaptık
            {
                progressBar4.Value = 100;
            }
            else
            {
                button7.Enabled = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            kasa += KeçiSütSayac.KeçiSüt*8;//bu kısımda mahsüllerin satışnı sğaladım
            KeçiSütSayac.KeçiSüt = 0;
            button9.Text = kasa.ToString() + " TL";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            kasa += TavukYumurtaSayac.TavukYumurta;//bu kısımda mahsüllerin satışnı sğaladım
            TavukYumurtaSayac.TavukYumurta = 0;
            button9.Text = kasa.ToString() + " TL";
            

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            kasa += ÖrdekYumurtaSayac.ÖrdekYumurta*3;//bu kısımda mahsüllerin satışnı sğaladım
            ÖrdekYumurtaSayac.ÖrdekYumurta = 0;
            button9.Text = kasa.ToString() + " TL";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            kasa += İnekSütSayac.İnekSüt*5;//bu kısımda mahsüllerin satışnı sğaladım
            İnekSütSayac.İnekSüt = 0;
            button9.Text = kasa.ToString() + " TL";
        }
    }
}
