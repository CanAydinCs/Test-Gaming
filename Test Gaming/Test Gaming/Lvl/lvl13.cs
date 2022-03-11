using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Gaming.Lvl
{
    public partial class lvl13 : Form
    {
        public lvl13()
        {
            InitializeComponent();
        }

        private void Lvl13_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimler\\hata.png";
            timer1.Enabled = true;
        }

        int say = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Beep.Play();
            if (say == 20)
            {
                pictureBox1.ImageLocation = "Resimler\\basla.gif";
            }
            say++;
            if (say == 35)
            {
                lvl14 x = new lvl14();
                x.Show();
                this.Hide();
            }
        }

        private void Lvl13_FormClosing(object sender, FormClosingEventArgs e)
        {
            lvl13 x = new lvl13();
            x.Show();
        }
    }
}
