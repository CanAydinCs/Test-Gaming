using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Gaming.Lvl
{
    public partial class lvl12 : Form
    {
        public lvl12()
        {
            InitializeComponent();
        }

        private void Lvl12_Load(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            pictureBox1.ImageLocation = "Resimler\\ykln.gif";
            timer1.Enabled = true;
        }

        int say = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            say++;

            if (say == 5)
            {
                progressBar1.Value = 25;
            }
            if (say == 10)
            {
                progressBar1.Value = 50;
            }
            if (say == 20)
            {
                progressBar1.Value = 75;
            }
            if (say == 25)
            {
                progressBar1.Value = 99;
                MessageBox.Show("Bilgisayarda Depolanmış Virüslere Rastlandı.");
                SystemSounds.Beep.Play();

                lvl13 x = new lvl13();
                x.Show();
                this.Hide();

                timer1.Enabled = false;
            }
        }

        private void Lvl12_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }
    }
}
