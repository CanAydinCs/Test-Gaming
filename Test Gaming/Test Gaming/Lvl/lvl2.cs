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
    public partial class lvl2 : Form
    {
        public lvl2()
        {
            InitializeComponent();
        }

        private void lvl2_Load(object sender, EventArgs e)
        {
            StreamReader isim = new StreamReader("GameData\\bilgi.txt");
            lblisim.Text = isim.ReadLine();

            timer1.Enabled = true;
        }

        private void lblisim_LocationChanged(object sender, EventArgs e)
        {
            if(lblisim.Location.Y<66 || lblisim.Location.Y > 166)
            {
                label3.Text = "Yarış Alanı İçinde Kal!";
                lblisim.Location = new Point(lblisim.Location.X, 110);
            }

            if (lblisim.Location.X < 42)
            {
                label3.Text = "Bitiş Çizgisi Diğer Tarafta!";
                lblisim.Location = new Point(55, lblisim.Location.Y);
            }
            
            if (label5.Visible == true  && lblisim.Location.X > 150)
            {
                label3.Text = "Yarış Daha Başlamadı!";
                lblisim.Location = new Point(55, lblisim.Location.Y);
            }

            if (lblisim.Location.X >= 733)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler!! Kazandınız!");
                lvl3 x = new lvl3();
                x.Show();
                this.Hide();
            }
        }

        private void lvl2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                lblisim.Top -= 5;
            if (e.KeyCode == Keys.Down)
                lblisim.Top += 5;
            if (e.KeyCode == Keys.Right)
                lblisim.Left += 5;
            if (e.KeyCode == Keys.Left)
                lblisim.Left -= 5;
        }

        int say = 4;
        private void timer1_Tick(object sender, EventArgs e)
        {
            say--;
            label2.Text = say.ToString();

            if (say < 0)
            {
                label2.Text = "Hadi Başla!";
                lblblg.Location = new Point((lblblg.Location.X + 5), lblblg.Location.Y);
                label5.Visible = false;
            }
        }

        private void lblblg_LocationChanged(object sender, EventArgs e)
        {
            //bilgisayarın kazanma durumu

            if (lblblg.Location.X > 672)
            {
                timer1.Stop();
                MessageBox.Show("Bilgisayar Kazandı!");
                Sonlar.ending1 x = new Sonlar.ending1();
                x.Show();
                this.Hide();
            }
        }

        private void lblisim_Click(object sender, EventArgs e)
        {

        }

        private void Lvl2_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }
    }
}
