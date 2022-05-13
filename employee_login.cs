using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sign_up
{
    public partial class employee_login : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aaytiw1\source\repos\sign_up\sign_up\Employee_data.mdf;Integrated Security=True";

        public employee_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string current_user = txt_emp_username.Text;
            SqlConnection con = new SqlConnection(connectionString);
            string query = "Select * from Employee_Authentication Where username = '" + txt_emp_username.Text.Trim() + "' and password = '" + txt_emp_password.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                LoginInfo.UserID = current_user;
                new employee_home().Show();
               
                
                //MessageBox.Show("login successfull");
                this.Hide();

            }
            else
            {
                MessageBox.Show("invalid username or password");
                txt_emp_username.Clear();
                txt_emp_password.Clear();
                txt_emp_username.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new main_page().Show();
            this.Hide();
        }
    }
}
