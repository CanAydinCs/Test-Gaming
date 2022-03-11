using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Gaming.Lvl
{
    public partial class lvl8 : Form
    {
        public lvl8()
        {
            InitializeComponent();
        }

        Random rast = new Random();
        int m1, m2, m3;
        int say = 10;

        public void Bttn()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
            button28.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = false;

            button1.Enabled = false;
        }

        public int Test(int i)
        {
            if(i == m1 || i == m2 || i == m3)
            {
                MessageBox.Show("Bombaya Bastınız!");
                Sonlar.ending2 x = new Sonlar.ending2();
                x.Show();
                this.Hide();
                Bttn();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void Kntrl(int i)
        {
            if (i == 0)
            {
                MessageBox.Show("Tebrikler! Kazandınız!");
                lvl9 x = new lvl9();
                x.Show();
                this.Hide();
                Bttn();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Test(1) == 0)
            {
                button1.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Test(2) == 0)
            {
                button2.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Test(4) == 0)
            {
                button4.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Test(5) == 0)
            {
                button5.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Test(6) == 0)
            {
                button6.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Test(7) == 0)
            {
                button7.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Test(8) == 0)
            {
                button8.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Test(9) == 0)
            {
                button9.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Test(10) == 0)
            {
                button10.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Test(11) == 0)
            {
                button11.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Test(12) == 0)
            {
                button12.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Test(13) == 0)
            {
                button13.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Test(14) == 0)
            {
                button14.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Test(15) == 0)
            {
                button15.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Test(16) == 0)
            {
                button16.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Test(17) == 0)
            {
                button17.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Test(18) == 0)
            {
                button18.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Test(19) == 0)
            {
                button19.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Test(20) == 0)
            {
                button20.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (Test(21) == 0)
            {
                button21.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (Test(22) == 0)
            {
                button22.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (Test(23) == 0)
            {
                button23.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (Test(24) == 0)
            {
                button24.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (Test(25) == 0)
            {
                button25.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (Test(26) == 0)
            {
                button26.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (Test(27) == 0)
            {
                button27.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (Test(28) == 0)
            {
                button28.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (Test(29) == 0)
            {
                button29.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (Test(30) == 0)
            {
                button30.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void Lvl8_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Test(3) == 0)
            {
                button3.Enabled = false;
            }
            say--;
            Kntrl(say);
        }

        private void lvl8_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Mayın Tarlası. 10 Boş Kutu Seç ve Hayatta kal!");
            kontrol:
            m1 = rast.Next(1, 31);
            m2 = rast.Next(1, 31);
            m3 = rast.Next(1, 31);

            if (m1 == m2 || m2 == m3 || m3 == m1)
                goto kontrol;
        }
    }
}
