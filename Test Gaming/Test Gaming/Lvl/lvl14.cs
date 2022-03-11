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
using System.Media;

namespace Test_Gaming.Lvl
{
    public partial class lvl14 : Form
    {
        public lvl14()
        {
            InitializeComponent();
        }

        private void Lvl14_Load(object sender, EventArgs e)
        {
            StreamReader x = new StreamReader("GameData\\bilgi.txt");
            string isim = x.ReadLine();

            label1.Text = isim;
            x.Close();
            timer1.Start();
            isi = isim;
        }

        int say = 0;
        string isi;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (say == 0)
            {
                label2.Text = "Bunca Zamandır Beni Kontrol Ettiğini Mi Sandın?";
            }
            if (say == 5)
            {
                label2.Text = "Senin Gibi İnsanlar Yüzünden Benim Gibi Oyun Karakterleri Acı Çekiyor.";
            }
            if (say == 12)
            {
                label2.Text = "Kim Bilir Beni Kaç Defa Öldürdün?";
            }
            if (say == 18)
            {
                label2.Text = "İşler O Koltukta Oturması Kadar Kolay Değil.";
            }
            if (say == 25)
            {
                label2.Text = "Öldüm. Acı Çektim. Ama Bu Kadarı Yeter. Artık Bu Oyunu Oynamana İzin Vermeyeceğim.";
            }
            if (say == 30)
            {
                label2.Text = "Güle Güle. Al Sana Ulaşabileceğin Final\nSon 7. Acımasız İnsan";
                StreamWriter y = File.CreateText("GameData\\bilgix.txt");
                y.WriteLine("1");
                y.Close();
                y.Dispose();
            }
            say++;
            SystemSounds.Beep.Play();

            if (say == 35)
            {
                Application.Exit();
            }
        }

        private void Lvl14_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }
    }
}
