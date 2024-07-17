using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classOrnegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenci ogr1 = new ogrenci();
            string adi = textBox1.Text;

            ogr1.ad = adi;

            ogr1.adYaz();
        }
    }
}
