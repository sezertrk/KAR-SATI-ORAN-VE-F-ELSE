using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KAR_SATIŞ_ORAN_VE_İF_ELSE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int af = int.Parse(textBox1.Text);
            int ko = int.Parse(textBox2.Text);
            int sf = 0;
           
            if (textBox3 .Text == "KAR")
            {
                sf = af * (100 + ko) / 100;
                textBox4.Text = sf.ToString();
            }
            else if (textBox3.Text == "ZARAR")
            {
                sf = af * (100 - ko) / 100;
                textBox4.Text = sf.ToString();
            }
            else
            {
                MessageBox.Show("Dikkat Et Sezer Bunda Çuvalladun");
            }
        }
    }
}
