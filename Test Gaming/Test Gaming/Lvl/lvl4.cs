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
    public partial class lvl4 : Form
    {
        public lvl4()
        {
            InitializeComponent();
        }

        private void lvl4_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Zıplak kuş. Sadece Boşluk Tuşu Aktif.");

            StreamReader isim = new StreamReader("GameData\\bilgi.txt");
            lblisim.Text = isim.ReadLine();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblisim.Location.X > 700)
            {
                timer1.Stop();
            }
            else
            {
                lblisim.Left += 1;
                lblisim.Top += 2;
            }
        }

        private void lvl4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                lblisim.Top -= 50;
        }

        int say = 0;
        private void lblisim_LocationChanged(object sender, EventArgs e)
        {
            if (lblisim.Location.Y > 365 && say == 0)
            {
                timer1.Stop();
                MessageBox.Show("Yere Çakıldın!");
                say = 1;

                Sonlar.ending3 x = new Sonlar.ending3();
                x.Show();
                this.Hide();
            }

            if (lblisim.Top < 0 && say == 0)
            {
                timer1.Stop();
                MessageBox.Show("Hava Türbülansına düştün.");
                say = 1;

                Sonlar.ending3 x = new Sonlar.ending3();
                x.Show();
                this.Hide();
            }

            if((lblisim.Location.X+lblisim.Width>561 && lblisim.Location.X<664)&&(lblisim.Location.Y<93 || lblisim.Location.Y > 225) && say == 0)
            {
                timer1.Stop();
                MessageBox.Show("Çarptın!");
                say = 1;

                Sonlar.ending3 x = new Sonlar.ending3();
                x.Show();
                this.Hide();
            }

            if (lblisim.Location.X > 700 && say == 0)
            {
                timer1.Stop();
                MessageBox.Show("");
                MessageBox.Show("Tebrikler! Uçmakta Yeteneklisin! Yeni Seviyeye Geçtin!");

                lvl5 x = new lvl5();
                x.Show();
                this.Hide();
                say = 1;
            }
        }

        private void Lvl4_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }
    }
}
