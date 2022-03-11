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
    public partial class lvl1 : Form
    {
        public lvl1()
        {
            InitializeComponent();
        }

        private void lvl1_KeyDown(object sender, KeyEventArgs e)
        {
            //tuş girdisi için

            if (e.KeyCode == Keys.Up)
                label2.Top -= 5;
            if (e.KeyCode == Keys.Down)
                label2.Top += 5;
            if (e.KeyCode == Keys.Right)
                label2.Left += 5;
            if (e.KeyCode == Keys.Left)
                label2.Left -= 5;
        }

        private void lvl1_Load(object sender, EventArgs e)
        {
            //ismi okuyalım. Test edelim.

            StreamReader isim = new StreamReader("GameData\\bilgi.txt");
            label2.Text = isim.ReadLine();

            timer1.Enabled = true;
            isim.Close();
        }

        int say = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            say++;

            if (say == 5)
            {
                pictureBox1.ImageLocation = "Resimler\\load2.png";
                label4.Text = "%25";
            }
            else if (say == 10)
            {
                pictureBox1.ImageLocation = "Resimler\\load3.png";
                label4.Text = "%50";
            }
            else if (say == 15)
            {
                pictureBox1.ImageLocation = "Resimler\\load4.png";
                label4.Text = "%99";
                button1.Visible = true;
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Yüklendiği Kadarıyla Devam Edilsin Mi?")
            {
                MessageBox.Show("Oyun Başlatılıyor...");
                lvl2 x = new lvl2();
                x.Show();
                this.Hide();//test edelim
            }
            button1.Location = new Point(12, 89);

            label1.Text = "Oyun Tamamen Yüklenemedi.";
            button1.Text = "Yüklendiği Kadarıyla Devam Edilsin Mi?";
        }

        private void Lvl1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }
    }
}
