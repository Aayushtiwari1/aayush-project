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
    public partial class edit_form : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aaytiw1\source\repos\sign_up\sign_up\Employee_data.mdf;Integrated Security=True";

        public edit_form()
        {
            InitializeComponent();
        }

        private void edit_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_dataDataSet4.Expense_Table' table. You can move, or remove it, as needed.
            this.expense_TableTableAdapter.Fill(this.employee_dataDataSet4.Expense_Table);
            label1.Text = LoginInfo.UserID;
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                bool ch = false;
                SqlDataAdapter da = new SqlDataAdapter("select * from Expense_Table where username='" + LoginInfo.UserID + "'and is_deleted='" + ch + "'", sqlcon);
                sqlcon.Open();
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                // dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void cleardata()
        {
            txt_bill_name.Clear();
            txt_amount.Clear();
            txt_discription.Clear();
            bill_date_picker.ResetText();
            comboBox_category.SelectedIndex = -1;
        }
        private void DisplayData()
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                bool ch = false;
                SqlDataAdapter da = new SqlDataAdapter("select * from Expense_Table where username='" + LoginInfo.UserID + "'and is_deleted='" + ch + "'", sqlcon);
                sqlcon.Open();
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                // dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            if (LoginInfo.refid != 0)
            {
                bool flag = true;
                SqlCommand cmd = new SqlCommand("update Expense_Table set bill_name=@bname,bill_Category=@bcategory,bill_date=@bdate,description=@des,amount=@am where Ref_Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", LoginInfo.refid);
                cmd.Parameters.AddWithValue("@bname", txt_bill_name.Text.Trim());
                cmd.Parameters.AddWithValue("@bcategory", comboBox_category.Text.Trim());
                cmd.Parameters.AddWithValue("@bdate", SqlDbType.Date).Value = bill_date_picker.Value.Date;
                cmd.Parameters.AddWithValue("@des", txt_discription.Text.Trim());
                cmd.Parameters.AddWithValue("@am", SqlDbType.Int).Value = txt_amount.Text.Trim();
                int i = cmd.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show("record updated successfully");
                    con.Close();
                    DisplayData();
                    cleardata();
                }
                else
                {
                    MessageBox.Show("ERROR record NOT Updated . . . .");
                }
                LoginInfo.refid = 0;
                //cleardata();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoginInfo.refid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_bill_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_discription.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_amount.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            bill_date_picker.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox_category.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         SqlConnection con = new SqlConnection(connectionString);
            if (LoginInfo.refid != 0)
            {
                bool flag = true;
                SqlCommand cmd = new SqlCommand("update Expense_Table set is_deleted=@flag where Ref_Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", LoginInfo.refid);
                cmd.Parameters.AddWithValue("@flag", flag);
                int i = cmd.ExecuteNonQuery();
                if (i >= 1)
                {
                    MessageBox.Show("record deleted successfully");
                    con.Close();
                    DisplayData();
                    cleardata();
                }
                else
                {
                    MessageBox.Show("ERROR record NOT deleted . . . .");
                }
                LoginInfo.refid = 0;
                //cleardata();
            }
            else
            {
                MessageBox.Show("Please Select Record to delete");
            }
        
        }
    }
}
