using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MohammedTbakhi_Ac1306
{
    public partial class frmlogin : Form
    {
        private List<User> Users = new List<User>();
        public frmlogin()
        {
            InitializeComponent();
            User user1 = new User("mohammed tbakhi", "1234");
            Users.Add(user1);
        }
       
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string usersname = txtUserName.Text;
            string Password = txtPassword.Text;
            foreach (User user in Users)
            {
                if (usersname == user.username && Password == user.password)
                {
                    frmlogin_2 log = new frmlogin_2(txtUserName.Text);
                    log.Show();
                    return;

                }
            }

        }
    }
}
