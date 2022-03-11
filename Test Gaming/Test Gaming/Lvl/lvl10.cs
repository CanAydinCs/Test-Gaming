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
    public partial class lvl10 : Form
    {
        public lvl10()
        {
            InitializeComponent();
        }

        public void Kontrol()
        {
            if(button1.BackColor == Color.Green && button2.BackColor == Color.Green && button3.BackColor == Color.Green && button4.BackColor == Color.Green && button5.BackColor == Color.Green && button6.BackColor == Color.Green && button7.BackColor == Color.Green && button8.BackColor == Color.Green && button9.BackColor == Color.Green)
            {
                timer1.Enabled = false;
                MessageBox.Show("Tebrikler!! Kazandınız!");
                lvl11 x = new lvl11();
                x.Show();
                this.Hide();
            }
        }

        public void B1()
        {
            if (button1.BackColor == Color.Red)
                button1.BackColor = Color.Green;
            else if (button1.BackColor == Color.Green)
                button1.BackColor = Color.Red;
        }
        public void B2()
        {
            if (button2.BackColor == Color.Red)
                button2.BackColor = Color.Green;
            else if (button2.BackColor == Color.Green)
                button2.BackColor = Color.Red;
        }
        public void B3()
        {
            if (button3.BackColor == Color.Red)
                button3.BackColor = Color.Green;
            else if (button3.BackColor == Color.Green)
                button3.BackColor = Color.Red;
        }
        public void B4()
        {
            if (button4.BackColor == Color.Red)
                button4.BackColor = Color.Green;
            else if (button4.BackColor == Color.Green)
                button4.BackColor = Color.Red;
        }
        public void B5()
        {
            if (button5.BackColor == Color.Red)
                button5.BackColor = Color.Green;
            else if (button5.BackColor == Color.Green)
                button5.BackColor = Color.Red;
        }
        public void B6()
        {
            if (button6.BackColor == Color.Red)
                button6.BackColor = Color.Green;
            else if (button6.BackColor == Color.Green)
                button6.BackColor = Color.Red;
        }
        public void B7()
        {
            if (button7.BackColor == Color.Red)
                button7.BackColor = Color.Green;
            else if (button7.BackColor == Color.Green)
                button7.BackColor = Color.Red;
        }
        public void B8()
        {
            if (button8.BackColor == Color.Red)
                button8.BackColor = Color.Green;
            else if (button8.BackColor == Color.Green)
                button8.BackColor = Color.Red;
        }
        public void B9()
        {
            if (button9.BackColor == Color.Red)
                button9.BackColor = Color.Green;
            else if (button9.BackColor == Color.Green)
                button9.BackColor = Color.Red;
        }

        private void lvl10_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Süre Dolmadan Tüm Düğmeleri Yeşil Yap.");
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            B1();
            B2();
            B4();
            Kontrol();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            B1();
            B2();
            B3();
            B5();
            Kontrol();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            B2();
            B3();
            B6();
            Kontrol();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            B1();
            B4();
            B5();
            B7();
            Kontrol();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            B2();
            B4();
            B5();
            B6();
            B8();
            Kontrol();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            B3();
            B5();
            B6();
            B9();
            Kontrol();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            B4();
            B7();
            B8();
            Kontrol();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            B5();
            B7();
            B8();
            B9();
            Kontrol();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            B6();
            B8();
            B9();
            Kontrol();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = (Convert.ToInt16(label2.Text) - 1).ToString();

            if (label2.Text == "0")
            {
                timer1.Enabled = false;
                MessageBox.Show("Kaybettiniz. Süre Doldu.");
                Sonlar.ending6 x = new Sonlar.ending6();
                x.Show();
                this.Hide();
            }
        }

        private void Lvl10_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }
    }
}
