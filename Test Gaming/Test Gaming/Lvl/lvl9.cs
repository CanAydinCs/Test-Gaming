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
    public partial class lvl9 : Form
    {
        public lvl9()
        {
            InitializeComponent();
        }

        int topara = 0;
        int tik = 1;
        int tikpara = 1;
        int toppara = 0;

        private void lvl9_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ortadaki Butona Tıklayarak Para Kazan ve 10.000 Üstü Para Kazandığında Seviye Atla!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            topara += (tik * tikpara);
            label2.Text = topara.ToString();

            toppara += (tik * tikpara);
            label13.Text = toppara.ToString();
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label2.Text) >= Convert.ToInt32(label6.Text))
                button2.Enabled = true;
            else
                button2.Enabled = false;
            if (Convert.ToInt32(label2.Text) >= Convert.ToInt32(label7.Text))
                button3.Enabled = true;
            else
                button3.Enabled = false;
            if (Convert.ToInt32(label2.Text) >= 10000)
            {
                MessageBox.Show("Tebrikler! Oyunu Kazandınız!");
                button4.Visible = true;
            }
            else
                button4.Visible = false;
            if (topara >= 100000)
            {
                Sonlar.ending5 x = new Sonlar.ending5();
                x.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            topara -= Convert.ToInt32(label6.Text);
            tik++;
            label4.Text = tik.ToString();
            label6.Text = (Convert.ToInt32(label6.Text) * 2).ToString();
            button2.Enabled = false;
            label2.Text = topara.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            topara -= Convert.ToInt32(label7.Text);
            tikpara++;
            label9.Text = tikpara.ToString();
            label7.Text = (Convert.ToInt32(label7.Text) * 2).ToString();
            button3.Enabled = false;
            label2.Text = topara.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (topara >= 10000)
            {
                lvl10 x = new lvl10();
                x.Show();
                this.Hide();
            }
        }

        private void Lvl9_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }
    }
}
