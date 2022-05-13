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
    public partial class Expense_Form : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aaytiw1\source\repos\sign_up\sign_up\Employee_data.mdf;Integrated Security=True";

        public Expense_Form()
        {
            InitializeComponent();
        }

        private void cLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new employee_home().Show();
            this.Hide();
        }

        private void cleardata()
        {
            txt_bill_name.Clear();
            txt_amount.Clear();
            txt_discription.Clear();
            bill_date_picker.ResetText();
            comboBox_category.SelectedIndex = -1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ExpenseAdd", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", LoginInfo.UserID);
                cmd.Parameters.AddWithValue("@bill_name", txt_bill_name.Text.Trim());
                cmd.Parameters.AddWithValue("@bill_Category", comboBox_category.Text.Trim());
                cmd.Parameters.AddWithValue("@bill_date", SqlDbType.Date).Value = bill_date_picker.Value.Date;
                cmd.Parameters.AddWithValue("@description", txt_discription.Text.Trim());
                cmd.Parameters.AddWithValue("@amount", SqlDbType.Int).Value = txt_amount.Text.Trim();
               int i= cmd.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show("record saved successfully");
                    con.Close();
                    cleardata();
                }
                else
                {
                    MessageBox.Show("ERROR record NOT saved . . . .");
                    cleardata();
                }
            }
        }
    }
}
