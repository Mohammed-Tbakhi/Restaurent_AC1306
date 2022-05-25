using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MohammedTbakhi_Ac1306
{
    public partial class frm12 : Form
    {
        public frm12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(" Chicken Pizza");
            listBox1.Items.Add("Price 8 $");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double r1 = (double)numericUpDown1.Value * 8;
            string R1 = r1.ToString();
            textBox1.Text = R1;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm12_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
        }
    }
}
