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
    public partial class ending2 : Form
    {
        public ending2()
        {
            InitializeComponent();
        }

        private void ending2_Load(object sender, EventArgs e)
        {
            StreamReader isim = new StreamReader("GameData\\bilgi.txt");
            label4.Text = isim.ReadLine();

            DateTime x = new DateTime();
            x = DateTime.Now;
            label6.Text = x.Day.ToString() + ":" + x.Month.ToString() + ":" + x.Year.ToString();
        }

        private void Ending2_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }
    }
}
