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
    public partial class finance_view : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aaytiw1\source\repos\sign_up\sign_up\Employee_data.mdf;Integrated Security=True";

        public finance_view()
        {
            InitializeComponent();
        }
        private void cleardata()
        {
            comboBox_status.SelectedIndex = -1;
            bill_name.Text = "";
            bill_date.Text = "";
            description.Text = "";
            amount.Text = "";
            ref_id.Text = "";
            sub_date.Text = "";
            category.Text = "";
            username.Text = "";

        }
        private void DisplayData()
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                bool ch = false;
                SqlDataAdapter da = new SqlDataAdapter("select * from Expense_Table where is_deleted='" + ch + "'", sqlcon);
                sqlcon.Open();
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                // dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void finance_view_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_dataDataSet4.Expense_Table' table. You can move, or remove it, as needed.
            this.expense_TableTableAdapter.Fill(this.employee_dataDataSet4.Expense_Table);
            this.expense_TableTableAdapter.Fill(this.employee_dataDataSet4.Expense_Table);
            label1.Text = LoginInfo.UserID;
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                bool ch = false;
                SqlDataAdapter da = new SqlDataAdapter("select * from Expense_Table where is_deleted='" + ch + "'", sqlcon);
                sqlcon.Open();
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
                // dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoginInfo.refid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            ref_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            username.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            bill_name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            category.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            bill_date.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            description.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
          amount.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            sub_date.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            comboBox_status.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            if (LoginInfo.refid != 0)
            {
                SqlCommand cmd = new SqlCommand("update Expense_Table set status=@status where Ref_Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", LoginInfo.refid);
                cmd.Parameters.AddWithValue("@status", comboBox_status.Text.Trim());
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
    }
}
