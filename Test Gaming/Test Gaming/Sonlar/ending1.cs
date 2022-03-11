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

namespace Test_Gaming.Sonlar
{
    public partial class ending1 : Form
    {
        public ending1()
        {
            InitializeComponent();
        }

        private void ending1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                label7.Top -= 5;
            if (e.KeyCode == Keys.Down)
                label7.Top += 5;
            if (e.KeyCode == Keys.Right)
                label7.Left += 5;
            if (e.KeyCode == Keys.Left)
                label7.Left -= 5;
            if (e.KeyCode == Keys.W)
                label7.Text = "Test";
        }

        private void ending1_Load(object sender, EventArgs e)
        {
            StreamReader isim = new StreamReader("GameData\\bilgi.txt");
            label7.Text = isim.ReadLine();
        }

        private void label7_LocationChanged(object sender, EventArgs e)
        {
            if (label7.Location.X < 60 || label7.Location.X > 240)
            {
                label7.Location = new Point(150, label7.Location.Y);
                label2.Visible = true;
            }
            if (label7.Location.Y < 58 || label7.Location.Y > 190)
            {
                label7.Location = new Point(label7.Location.X, 150);
                label2.Visible = true;
            }
        }

        private void Ending1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }
    }
}
