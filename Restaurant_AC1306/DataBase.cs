using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;


namespace Restaurant_Ac1306
{
    public partial class frmDataBase : Form
    {
        public frmDataBase()
        {
            InitializeComponent();
        }
        void GetAllCourses()
        {

            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; " +
                "Data Source=C:\\Users\\ASUS\\Desktop\\Food.accdb");
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter("Select * from courses", con);
            con.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtFoodType.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " +
                    "Data Source=C:\\Users\\ASUS\\Desktop\\Food.accdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into Restaraunt values(@ID, @Food Type, @Price)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
            cmd.Parameters.AddWithValue("@Food Type", txtFoodType.Text);
            cmd.Parameters.AddWithValue("@Price", int.Parse(txtPrice.Text));

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Saved is successfully");
            GetAllCourses();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string delete = "Delete From Restaraunt Where ID=@ID";
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " +
                "Data Source=C:\\Users\\ASUS\\Desktop\\Food.accdb");

            OleDbCommand cmd = new OleDbCommand(delete, con);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete is successfully");
            GetAllCourses();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " + 
                "Data Source=C:\\Users\\SCHOOL\\Desktop\\Database21.accdb");

            string update = "UPDATE Restaraunt" + " SET Food Type=@Food Type, Pricer=@Price " + "WHERE id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "";
            OleDbCommand cmd = new OleDbCommand(update, con);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtID.Text));
            cmd.Parameters.AddWithValue("@Food Type", txtFoodType.Text);
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update is successfully");
            GetAllCourses();
        }

        private void frmDataBase_Load(object sender, EventArgs e)
        {
            GetAllCourses();
        }
    }
}
