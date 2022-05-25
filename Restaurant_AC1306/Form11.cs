using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MohammedTbakhi_Ac1306
{
    public partial class frm11 : Form
    {
        public frm11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(" Meet Pizza");
            listBox1.Items.Add("Price 9 $");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double r1 = (double)numericUpDown1.Value * 9;
            string R1 = r1.ToString();
            textBox1.Text = R1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm11_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
        }
    }
}
