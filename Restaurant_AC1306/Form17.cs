using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MohammedTbakhi_Ac1306
{
    public partial class frm17 : Form
    {
        public frm17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(" Orange Juice");
            listBox1.Items.Add("Price 3 $");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double r1 = (double)numericUpDown1.Value * 3;
            string R1 = r1.ToString();
            textBox1.Text = R1;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
        }
    }
}
