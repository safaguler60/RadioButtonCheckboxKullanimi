using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            if (radioButton1.Checked == true) s = "Dereceli \n";
            if (radioButton2.Checked == true) s = "Derecesiz \n";

            if (checkBox1.Checked == true) s += "Smoke \n";
            if (checkBox2.Checked == true) s += "Entry \n";
            if (checkBox3.Checked == true) s += "Support \n";
            if (checkBox4.Checked == true) s += "Sentinel \n";
            if (checkBox5.Checked == true) s += "Troll \n";
            label1.Text = s+ "Maç aranıyor";

        }
    }
}
