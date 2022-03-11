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

namespace Test_Gaming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")//boş girdiyi önlemek için
                MessageBox.Show("Gerekli Alanları Doldurunuz!");
            else if (textBox1.TextLength > 10)
            {
                MessageBox.Show("Çok Uzun Bir İsim Girdiniz!"); //fazla uzun isim girişini önleyelim
            }
            else
            {
                //ismi alalım ve txt dosyasına yazdıralım, ilk önce dosyayı oluşturalım

                StreamWriter isim = File.CreateText("GameData\\bilgi.txt");

                isim.WriteLine(textBox1.Text);
                isim.Close();
                //şimdi txt dosyasına girilen ismi kaydetmesi lazım.
                //isim kayıt edildi.

                Lvl.lvl1 x = new Lvl.lvl1();
                x.Show(); //yeni formu açalım
                this.Hide(); //bu formu kapaması için
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader x = new StreamReader("GameData\\bilgix.txt");
                if (x.ReadLine() == "1")
                {
                    MessageBox.Show("Bu Oyuna Artık Girmen Yasak.");
                    Application.Exit();
                }
            }
            catch (Exception)
            {
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }
    }
}
