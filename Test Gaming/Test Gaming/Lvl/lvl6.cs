using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Gaming.Lvl
{
    public partial class lvl6 : Form
    {
        public lvl6()
        {
            InitializeComponent();
        }

        Random rast = new Random();
        int blgsecim, insansec;
        int kazan = 0, kaybet = 0, berabere = 0;
        int lblsira = 1;

        public void Kontrol(int i)
        {
            if (i == 6)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;

                if(kazan>kaybet && kazan > berabere)
                {
                    MessageBox.Show("Tebrikler. Kazandınız!");

                    lvl7 x = new lvl7();
                    x.Show();
                    this.Hide();
                }
                else if(berabere>kazan && berabere > kaybet)
                {
                    MessageBox.Show("Berabere Kaldınız. Yani Oyunu Kaybettiniz.");

                    Sonlar.ending4 x = new Sonlar.ending4();
                    x.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kazanma Sayınız Kaybetme ve Berabere Kalma Sayınıza Göre Çok Değil!");
                    MessageBox.Show("Kaybettiniz!");//eğer herhangi iki durum eşitse de buraya yönlendirecek. 

                    Sonlar.ending1 x = new Sonlar.ending1();
                    x.Show();
                    this.Hide();
                }
            }
        }

        public void Bilgisec(int x)
        {
            if (x == 1)
                label2.Text = "Taş";
            else if (x == 2)
                label2.Text = "Kağıt";
            else
                label2.Text = "Makas";
        }

        public void Karar(int x,int y)
        {
            if (x == y)
            {
                berabere++;
                switch (lblsira)
                {
                    case 1:
                        label8.BackColor = Color.Yellow;
                        break;
                    case 2:
                        label9.BackColor = Color.Yellow;
                        break;
                    case 3:
                        label10.BackColor = Color.Yellow;
                        break;
                    case 4:
                        label11.BackColor = Color.Yellow;
                        break;
                    case 5:
                        label12.BackColor = Color.Yellow;
                        break;
                }
            }
            else if((x==1 && y==3) || (x==2 && y==1) || (x==3 && y == 2)) 
            {
                kazan++;
                switch (lblsira)
                {
                    case 1:
                        label8.BackColor = Color.Green;
                        break;
                    case 2:
                        label9.BackColor = Color.Green;
                        break;
                    case 3:
                        label10.BackColor = Color.Green;
                        break;
                    case 4:
                        label11.BackColor = Color.Green;
                        break;
                    case 5:
                        label12.BackColor = Color.Green;
                        break;
                }
            }
            else
            {
                kaybet++;
                switch (lblsira)
                {
                    case 1:
                        label8.BackColor = Color.Red;
                        break;
                    case 2:
                        label9.BackColor = Color.Red;
                        break;
                    case 3:
                        label10.BackColor = Color.Red;
                        break;
                    case 4:
                        label11.BackColor = Color.Red;
                        break;
                    case 5:
                        label12.BackColor = Color.Red;
                        break;
                }
            }
            lblsira++;
        }
        
        private void lvl6_Load(object sender, EventArgs e)
        {
            StreamReader isim = new StreamReader("GameData\\bilgi.txt");
            groupBox1.Text = isim.ReadLine();
            label5.Text = groupBox1.Text;

            MessageBox.Show("Taş-Kağıt-Makas");
        }

        private void Lvl6_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insansec = 1;
            blgsecim = rast.Next(1, 4);

            Bilgisec(blgsecim);
            Karar(insansec, blgsecim);

            Kontrol(lblsira);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insansec = 2;
            blgsecim = rast.Next(1, 4);

            Bilgisec(blgsecim);
            Karar(insansec, blgsecim);

            Kontrol(lblsira);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            insansec = 3;
            blgsecim = rast.Next(1, 4);

            Bilgisec(blgsecim);
            Karar(insansec, blgsecim);

            Kontrol(lblsira);
        }
    }
}