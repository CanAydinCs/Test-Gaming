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
    public partial class lvl3 : Form
    {
        public lvl3()
        {
            InitializeComponent();
        }

        private void lvl3_Load(object sender, EventArgs e)
        {
            StreamReader isim = new StreamReader("GameData\\bilgi.txt");
            lblisim.Text = isim.ReadLine();

            MessageBox.Show("60 Saniye Hayatta Kal. Sadece Sağ Ve Sol Yön Tuşları Aktif.");

            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        Random x = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Arabanın rastgele olarak şeritte üretilmesi

            int s1, s2, s3, s4;
            s1 = x.Next(0, 2);
            s2 = x.Next(0, 2);
            s3 = x.Next(0, 2);
            s4 = x.Next(0, 2);

            if(arb1.Visible == false && s1 == 1)
                arb1.Visible = true;
            if (arb2.Visible == false && s2 == 1)
                arb2.Visible = true;
            if (arb3.Visible == false && s3 == 1)
                arb3.Visible = true;
            if (arb4.Visible == false && s4 == 1)
                arb4.Visible = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Arabanın Şeritte ilerlemesi

            if (arb1.Visible == true)
                arb1.Top += 40;
            if (arb2.Visible == true)
                arb2.Top += 40;
            if (arb3.Visible == true)
                arb3.Top += 40;
            if (arb4.Visible == true)
                arb4.Top += 40;
        }

        private void arb1_LocationChanged(object sender, EventArgs e)
        {
            if (arb1.Location.Y > 524)
            {
                arb1.Visible = false;
                arb1.Location = new Point(arb1.Location.X, 0);
            }

            if (arb1.Location.Y == lblisim.Location.Y && arb1.Location.X == lblisim.Location.X) 
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();

                Sonlar.ending2 x = new Sonlar.ending2();
                x.Show();
                this.Hide();

                MessageBox.Show("Kaza yaptınız!");
            }
        }

        private void arb2_LocationChanged(object sender, EventArgs e)
        {
            if (arb2.Location.Y > 524)
            {
                arb2.Visible = false;
                arb2.Location = new Point(arb2.Location.X, 0);
            }

            if (arb2.Location.Y == lblisim.Location.Y && arb2.Location.X == lblisim.Location.X)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();

                Sonlar.ending2 x = new Sonlar.ending2();
                x.Show();
                this.Hide();

                MessageBox.Show("Kaza yaptınız!");
            }
        }

        private void arb3_LocationChanged(object sender, EventArgs e)
        {
            if (arb3.Location.Y > 524)
            {
                arb3.Visible = false;
                arb3.Location = new Point(arb3.Location.X, 0);
            }

            if (arb3.Location.Y == lblisim.Location.Y && arb3.Location.X == lblisim.Location.X)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();

                Sonlar.ending2 x = new Sonlar.ending2();
                x.Show();
                this.Hide();

                MessageBox.Show("Kaza yaptınız!");
            }
        }

        private void arb4_LocationChanged(object sender, EventArgs e)
        {
            if (arb4.Location.Y > 524)
            {
                arb4.Visible = false;
                arb4.Location = new Point(arb4.Location.X, 0);
            }

            if (arb4.Location.Y == lblisim.Location.Y && arb4.Location.X == lblisim.Location.X)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();

                Sonlar.ending2 x = new Sonlar.ending2();
                x.Show();
                this.Hide();

                MessageBox.Show("Kaza yaptınız!");
            }
        }

        private void lvl3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                lblisim.Left += 200;
            if (e.KeyCode == Keys.Left)
                lblisim.Left -= 200;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt16(label1.Text) - 1).ToString();

            if (label1.Text == "0")
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();

                MessageBox.Show("Tebrikler! Başardınız.");

                lvl4 x = new lvl4();
                x.Show();
                this.Hide();
            }
        }

        private void lblisim_LocationChanged(object sender, EventArgs e)
        {
            //ekran dışına çıkmasını engellemek

            if (lblisim.Location.X < 0)
                lblisim.Location = new Point(30, lblisim.Location.Y);
            else if(lblisim.Location.X>700)
                lblisim.Location = new Point(630, lblisim.Location.Y);

            if (arb1.Location.Y == lblisim.Location.Y && arb1.Location.X == lblisim.Location.X)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();

                Sonlar.ending2 x = new Sonlar.ending2();
                x.Show();
                this.Hide();

                MessageBox.Show("Kaza yaptınız!");
            }
            if (arb2.Location.Y == lblisim.Location.Y && arb2.Location.X == lblisim.Location.X)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();

                Sonlar.ending2 x = new Sonlar.ending2();
                x.Show();
                this.Hide();

                MessageBox.Show("Kaza yaptınız!");
            }
            if (arb3.Location.Y == lblisim.Location.Y && arb3.Location.X == lblisim.Location.X)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();

                Sonlar.ending2 x = new Sonlar.ending2();
                x.Show();
                this.Hide();

                MessageBox.Show("Kaza yaptınız!");
            }
            if (arb4.Location.Y == lblisim.Location.Y && arb4.Location.X == lblisim.Location.X)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();

                Sonlar.ending2 x = new Sonlar.ending2();
                x.Show();
                this.Hide();

                MessageBox.Show("Kaza yaptınız!");
            }
        }

        private void arb1_Click(object sender, EventArgs e)
        {

        }

        private void Lvl3_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }
    }
}
