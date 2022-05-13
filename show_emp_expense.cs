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
    public partial class show_emp_expense : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aaytiw1\source\repos\sign_up\sign_up\Employee_data.mdf;Integrated Security=True";
        public show_emp_expense()
        {
            InitializeComponent();
        }

        private void show_emp_expense_Load(object sender, EventArgs e)
        {
            label1.Text = LoginInfo.UserID;
            // TODO: This line of code loads data into the 'employee_dataDataSet4.Expense_Table' table. You can move, or remove it, as needed.
            this.expense_TableTableAdapter2.Fill(this.employee_dataDataSet4.Expense_Table);
            // TODO: This line of code loads data into the 'employee_dataDataSet2.Expense_Table' table. You can move, or remove it, as needed.
           // this.expense_TableTableAdapter1.Fill(this.employee_dataDataSet2.Expense_Table);

            // TODO: This line of code loads data into the 'employee_dataDataSet1.Expense_Table' table. You can move, or remove it, as needed.
            //this.expense_TableTableAdapter.Fill(this.employee_dataDataSet1.Expense_Table);
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                bool ch = false;
                SqlDataAdapter da= new SqlDataAdapter("select * from Expense_Table where username='" + LoginInfo.UserID +"'and is_deleted='"+ch+"'", sqlcon);
                sqlcon.Open();
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds);
               // dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           LoginInfo.refid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
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
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
