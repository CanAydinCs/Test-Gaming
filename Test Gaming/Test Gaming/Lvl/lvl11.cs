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
    public partial class lvl11 : Form
    {
        public lvl11()
        {
            InitializeComponent();
        }

        private void Lvl11_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hatalı Veya Eksik Dosya!");
            MessageBox.Show("Işık Dosyası Yüklenemedi.");
            MessageBox.Show("Güvenli Mod Başlatılırken Hata Oluştu!");
            MessageBox.Show("Oyun Yardımcısı Devre Dışı...");
            MessageBox.Show("Oyuncunun Güvenliği İçin Yön Tuşları Aktif Edildi.");

            StreamReader isim = new StreamReader("GameData\\bilgi.txt");
            label1.Text = isim.ReadLine();
        }

        private void Lvl11_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                label1.Top -= 5;
            }
            if (e.KeyCode == Keys.Down)
            {
                label1.Top += 5;
            }
            if (e.KeyCode == Keys.Right)
            {
                label1.Left += 5;
            }
            if (e.KeyCode == Keys.Left)
            {
                label1.Left -= 5;
            }
        }

        private void Label1_LocationChanged(object sender, EventArgs e)
        {
            if (label1.Location.X <= 5)
            {
                MessageBox.Show("Güvenli Olmayan Bölgeye Giriş Red Edildi.");
                label1.Location = new Point(15, label1.Location.Y);
            }
            if(label1.Location.Y >= 375)
            {
                MessageBox.Show("Güvenli Olmayan Bölgeye Giriş Red Edildi.");
                label1.Location = new Point(label1.Location.X, 350);
            }
            if (label1.Location.Y <= 5)
            {
                MessageBox.Show("Güvenli Olmayan Bölgeye Giriş Red Edildi.");
                label1.Location = new Point(label1.Location.X, 10);
            }
            if (label1.Location.X > 668)
            {
                MessageBox.Show("Çıkış İzni Red Edildi. Oyuna Sızan Kötü Amaçlı Yazılımlar Var.");
                MessageBox.Show("Sistemimiz Onları Temizlerken Lütfen Bekleyiniz.");

                lvl12 x = new lvl12();
                x.Show();
                this.Hide();
            }
        }

        private void Lvl11_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }
    }
}
