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

namespace Test_Gaming.Sonlar
{
    public partial class ending3 : Form
    {
        public ending3()
        {
            InitializeComponent();
        }

        private void ending3_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "Resimler\\bird.png";
        }

        private void Ending3_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("GameData\\bilgi.txt");
            sw.WriteLine("");
            sw.Close();
        }
    }
}
