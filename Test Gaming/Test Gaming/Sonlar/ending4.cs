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
    public partial class ending4 : Form
    {
        public ending4()
        {
            InitializeComponent();
        }

        private void ending4_Load(object sender, EventArgs e)
        {
            StreamReader isim = new StreamReader("GameData\\bilgi.txt");
            label10.Text = isim.ReadLine();
        }

        private void Ending4_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }
    }
}
