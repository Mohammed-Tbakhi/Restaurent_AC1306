using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant_AC1306
{
    public partial class frmlogin_2 : Form
    {
        private string _user;

        public frmlogin_2()
        {
        }

        public frmlogin_2(string usersname)
        {
            _user = usersname;
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 log1 = new Form1();
            log1.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmlogin_2_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "Welcome " + _user;
        }

        private void btnDataBase_Click(object sender, EventArgs e)
        {
            frmDataBase data = new frmDataBase();
            data.Show();
        }
    }
}

   

