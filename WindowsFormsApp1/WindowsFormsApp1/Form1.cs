using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIN_LIB;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VIN_LIB.VIN_LIB vn = new VIN_LIB.VIN_LIB();
            MessageBox.Show(vn.GetVINCountry("JAMCM56557C404453") + "");
        }
    }
}
