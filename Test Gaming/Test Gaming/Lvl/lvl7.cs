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
    public partial class lvl7 : Form
    {
        public lvl7()
        {
            InitializeComponent();
        }

        int say = 0;

        public void Kazan()
        {
            if (label1.Text == "M" && label2.Text == "E" && label3.Text == "R" && label4.Text == "S" && label5.Text == "İ" && label6.Text == "N")
            {
                MessageBox.Show("Tebrikler!! Kazandınız!");
                lvl8 x = new lvl8();
                x.Show();
                this.Hide();
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
                button26.Enabled = false;
                button27.Enabled = false;
                button28.Enabled = false;
                button29.Enabled = false;
            }
        }

        public void Hata()
        {
            say++;

            switch (say)
            {
                case 1:
                    pictureBox1.ImageLocation = "Resimler\\adam2.png";
                    break;
                case 2:
                    pictureBox1.ImageLocation = "Resimler\\adam3.png";
                    break;
                case 3:
                    pictureBox1.ImageLocation = "Resimler\\adam4.png";
                    break;
                case 4:
                    pictureBox1.ImageLocation = "Resimler\\adam5.png";
                    break;
                case 5:
                    pictureBox1.ImageLocation = "Resimler\\adam6.png";
                    break;
                case 6:
                    pictureBox1.ImageLocation = "Resimler\\adam7.png";
                    break;
                default:
                    MessageBox.Show("Çok Fazla Hatalı Giriş Yaptınız!");
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
                    button26.Enabled = false;
                    button27.Enabled = false;
                    button28.Enabled = false;
                    button29.Enabled = false;
                    Sonlar.ending2 x = new Sonlar.ending2();
                    x.Show();
                    this.Hide();
                    break; 
            }
        }

        private void lvl7_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Adam Asmaca! Doğru Harfleri Yerleştir ve Hayatta Kal!");

            pictureBox1.ImageLocation = "Resimler\\adam1.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hata();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "M";
            Kazan();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "E";
            Kazan();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label3.Text = "R";
            Kazan();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label4.Text = "S";
            Kazan();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label5.Text = "İ";
            Kazan();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label6.Text = "N";
            Kazan();
        }

        private void Lvl7_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }
    }
}
