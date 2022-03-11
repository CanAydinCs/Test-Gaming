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
    public partial class lvl5 : Form
    {
        public lvl5()
        {
            InitializeComponent();
        }

        Random rast = new Random();
        int blgsec;

        string resim1 = "1", resim2 = "2", resim3 = "3", resim4 = "4", resim5 = "5", resim6 = "6", resim7 = "7", resim8 = "8", resim9 = "9";

        public int Oyunsonu()
        {
            if ((resim1 == resim2 && resim2 == resim3) || (resim7 == resim4 && resim4 == resim1) || (resim4 == resim5 && resim5 == resim6) || (resim7 == resim8 && resim8 == resim9) || (resim8 == resim5 && resim5 == resim2) || (resim3 == resim6 && resim6 == resim9) || (resim9 == resim5 && resim5 == resim1) || (resim3 == resim5 && resim5 == resim7))
            {
                button10.Enabled = false;
                button11.Enabled = false;
                return 1;
            }
            else
                return 0;
        }

        public void Bilgisec()
        {
            int blg = rast.Next(0, 2);
        kontrol:
            blgsec = rast.Next(1, 10);

            if (blgsec == 1 && button1.Enabled == false)
                goto kontrol;
            else if (blgsec == 2 && button2.Enabled == false)
                goto kontrol;
            else if (blgsec == 3 && button3.Enabled == false)
                goto kontrol;
            else if (blgsec == 4 && button4.Enabled == false)
                goto kontrol;
            else if (blgsec == 5 && button5.Enabled == false)
                goto kontrol;
            else if (blgsec == 6 && button6.Enabled == false)
                goto kontrol;
            else if (blgsec == 7 && button7.Enabled == false)
                goto kontrol;
            else if (blgsec == 8 && button8.Enabled == false)
                goto kontrol;
            else if (blgsec == 9 && button9.Enabled == false)
                goto kontrol;

            if (blg == 0)
                Koy("x");
            else
                Koy("o");
        }

        public void Koy(string x,string y="b")
        {
            if (y == "b")
            {
                switch (blgsec)
                {
                    case 1:
                        pictureBox1.Visible = true;
                        if (x == "x")
                            pictureBox1.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox1.ImageLocation = "Resimler\\o.png";
                        resim1 = x;
                        button1.Visible = false;
                        button1.Enabled = false;
                        blgsec = 0;
                        break;
                    case 2:
                        pictureBox2.Visible = true;
                        button2.Visible = false;
                        button2.Enabled = false;
                        if (x == "x")
                            pictureBox2.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox2.ImageLocation = "Resimler\\o.png";
                        resim2 = x;
                        blgsec = 0;
                        break;
                    case 3:
                        pictureBox3.Visible = true;
                        button3.Visible = false;
                        button3.Enabled = false;
                        if (x == "x")
                            pictureBox3.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox3.ImageLocation = "Resimler\\o.png";
                        resim3 = x;
                        blgsec = 0;
                        break;
                    case 4:
                        pictureBox4.Visible = true;
                        button4.Visible = false;
                        button4.Enabled = false;
                        if (x == "x")
                            pictureBox4.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox4.ImageLocation = "Resimler\\o.png";
                        resim4 = x;
                        blgsec = 0;
                        break;
                    case 5:
                        pictureBox5.Visible = true;
                        button5.Visible = false;
                        button5.Enabled = false;
                        if (x == "x")
                            pictureBox5.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox5.ImageLocation = "Resimler\\o.png";
                        resim5 = x;
                        blgsec = 0;
                        break;
                    case 6:
                        pictureBox6.Visible = true;
                        button6.Visible = false;
                        button6.Enabled = false;
                        if (x == "x")
                            pictureBox6.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox6.ImageLocation = "Resimler\\o.png";
                        resim6 = x;
                        blgsec = 0;
                        break;
                    case 7:
                        pictureBox7.Visible = true;
                        button7.Visible = false;
                        button7.Enabled = false;
                        if (x == "x")
                            pictureBox7.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox7.ImageLocation = "Resimler\\o.png";
                        resim7 = x;
                        blgsec = 0;
                        break;
                    case 8:
                        pictureBox8.Visible = true;
                        button8.Visible = false;
                        button8.Enabled = false;
                        if (x == "x")
                            pictureBox8.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox8.ImageLocation = "Resimler\\o.png";
                        resim8 = x;
                        blgsec = 0;
                        break;
                    case 9:
                        pictureBox9.Visible = true;
                        button9.Visible = false;
                        button9.Enabled = false;
                        if (x == "x")
                            pictureBox9.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox9.ImageLocation = "Resimler\\o.png";
                        resim9 = x;
                        blgsec = 0;
                        break;
                    default:
                        MessageBox.Show("Lütfen bir bölge seçiniz!");
                        break;
                }
            }
            else if (y == "s")
            {
                switch (sec)
                {
                    case 1:
                        resim1 = x;
                        if (x == "x")
                            pictureBox1.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox1.ImageLocation = "Resimler\\o.png";
                        button1.Enabled = false;
                        sec = 0;
                        break;
                    case 2:
                        resim2 = x;
                        button2.Enabled = false;
                        if (x == "x")
                            pictureBox2.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox2.ImageLocation = "Resimler\\o.png";
                        sec = 0;
                        break;
                    case 3:
                        resim3 = x;
                        button3.Enabled = false;
                        if (x == "x")
                            pictureBox3.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox3.ImageLocation = "Resimler\\o.png";
                        sec = 0;
                        break;
                    case 4:
                        resim4 = x;
                        button4.Enabled = false;
                        if (x == "x")
                            pictureBox4.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox4.ImageLocation = "Resimler\\o.png";
                        sec = 0;
                        break;
                    case 5:
                        resim5 = x;
                        button5.Enabled = false;
                        if (x == "x")
                            pictureBox5.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox5.ImageLocation = "Resimler\\o.png";
                        sec = 0;
                        break;
                    case 6:
                        resim6 = x;
                        button6.Enabled = false;
                        if (x == "x")
                            pictureBox6.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox6.ImageLocation = "Resimler\\o.png";
                        sec = 0;
                        break;
                    case 7:
                        resim7 = x;
                        button7.Enabled = false;
                        if (x == "x")
                            pictureBox7.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox7.ImageLocation = "Resimler\\o.png";
                        sec = 0;
                        break;
                    case 8:
                        resim8 = x;
                        button8.Enabled = false;
                        if (x == "x")
                            pictureBox8.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox8.ImageLocation = "Resimler\\o.png";
                        sec = 0;
                        break;
                    case 9:
                        resim9 = x;
                        button9.Enabled = false;
                        if (x == "x")
                            pictureBox9.ImageLocation = "Resimler\\x.png";
                        else if (x == "o")
                            pictureBox9.ImageLocation = "Resimler\\o.png";
                        sec = 0;
                        break;
                    default:
                        MessageBox.Show("Lütfen bir bölge seçiniz!");
                        break;
                }
            }
            
            
        }

        public void Goster()
        {
            if (button1.Enabled)
            {
                button1.Visible = true;
                pictureBox1.Visible = false;
            }
            if (button2.Enabled)
            {
                button2.Visible = true;
                pictureBox2.Visible = false;
            }
            if (button3.Enabled)
            {
                button3.Visible = true;
                pictureBox3.Visible = false;
            }
            if (button4.Enabled)
            {
                button4.Visible = true;
                pictureBox4.Visible = false;
            }
            if (button5.Enabled)
            {
                button5.Visible = true;
                pictureBox5.Visible = false;
            }
            if (button6.Enabled)
            {
                button6.Visible = true;
                pictureBox6.Visible = false;
            }
            if (button7.Enabled)
            {
                button7.Visible = true;
                pictureBox7.Visible = false;
            }
            if (button8.Enabled)
            {
                button8.Visible = true;
                pictureBox8.Visible = false;
            }
            if (button9.Enabled)
            {
                button9.Visible = true;
                pictureBox9.Visible = false;
            }
        }

        private void lvl5_Load(object sender, EventArgs e)
        {
            MessageBox.Show("XOX oyunu. Ardı ardına 3 tanesini sıralayıp kazanın.");
        }

        int sec;

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Enabled)
            {
                Goster();
                button1.Visible = false;
                pictureBox1.Visible = true;
                pictureBox1.ImageLocation = "Resimler\\secili.png";
                sec = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Enabled)
            {
                Goster();
                button2.Visible = false;
                pictureBox2.Visible = true;
                pictureBox2.ImageLocation = "Resimler\\secili.png";
                sec = 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Enabled)
            {
                Goster();
                button3.Visible = false;
                pictureBox3.Visible = true;
                pictureBox3.ImageLocation = "Resimler\\secili.png";
                sec = 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Enabled)
            {
                Goster();
                button4.Visible = false;
                pictureBox4.Visible = true;
                pictureBox4.ImageLocation = "Resimler\\secili.png";
                sec = 4;
            }
        }

        private void Lvl5_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Enabled)
            {
                Goster();
                button5.Visible = false;
                pictureBox5.Visible = true;
                pictureBox5.ImageLocation = "Resimler\\secili.png";
                sec = 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Enabled)
            {
                Goster();
                button6.Visible = false;
                pictureBox6.Visible = true;
                pictureBox6.ImageLocation = "Resimler\\secili.png";
                sec = 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Enabled)
            {
                Goster();
                button7.Visible = false;
                pictureBox7.Visible = true;
                pictureBox7.ImageLocation = "Resimler\\secili.png";
                sec = 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Enabled)
            {
                Goster();
                button8.Visible = false;
                pictureBox8.Visible = true;
                pictureBox8.ImageLocation = "Resimler\\secili.png";
                sec = 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Enabled)
            {
                Goster();
                button9.Visible = false;
                pictureBox9.Visible = true;
                pictureBox9.ImageLocation = "Resimler\\secili.png";
                sec = 9;
            }
        }

        int say = 0;

        private void button10_Click(object sender, EventArgs e)
        {
            say++;
            if (say == 5 && Oyunsonu() == 0)
            {
                button10.Enabled = false;
                button11.Enabled = false;
                MessageBox.Show("Berabere! Ama kazanmanız gerekiyordu o yüzden kaybettiniz!");
                Sonlar.ending4 x = new Sonlar.ending4();
                x.Show();
                this.Hide();
            }
            Koy("x", "s");
            if (Oyunsonu() == 1)
            {
                MessageBox.Show("Tebrikler! Kazandınız!");
                lvl6 x = new lvl6();
                x.Show();
                this.Hide();
            }
            else
            {
                if (say != 5)
                    Bilgisec();
                if (Oyunsonu() == 1)
                {
                    MessageBox.Show("Kaybettiniz!");
                    Sonlar.ending1 x = new Sonlar.ending1();
                    x.Show();
                    this.Hide();
                }
            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            say++;
            if (say == 5 && Oyunsonu() == 0)
            {
                button10.Enabled = false;
                button11.Enabled = false;
                MessageBox.Show("Berabere! Ama kazanmanız gerekiyordu o yüzden kaybettiniz!");
                Sonlar.ending4 x = new Sonlar.ending4();
                x.Show();
                this.Hide();
            }
            Koy("o","s");
            if (Oyunsonu() == 1)
            {
                MessageBox.Show("Tebrikler! Kazandınız!");
                lvl6 x = new lvl6();
                x.Show();
                this.Hide();
            }
            else
            {
                if (say != 5)
                    Bilgisec();
                if (Oyunsonu() == 1)
                {
                    MessageBox.Show("Kaybettiniz!");
                    Sonlar.ending1 x = new Sonlar.ending1();
                    x.Show();
                    this.Hide();
                }
            }
        }
    }
}
