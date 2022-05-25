using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MohammedTbakhi_Ac1306
{
    public partial class frm6 : Form
    {
        public frm6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Chicken Burger ");
            listBox1.Items.Add("Price 5 $");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double r1 = (double)numericUpDown1.Value * 5;
            string R1 = r1.ToString();
            textBox1.Text = R1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
        }
    }
}
