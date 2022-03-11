using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Gaming.Sonlar
{
    public partial class ending6 : Form
    {
        public ending6()
        {
            InitializeComponent();
        }

        private void Ending6_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }
    }
}
