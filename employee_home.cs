using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sign_up
{
    public partial class employee_home : Form
    {
        public employee_home()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

            new employee_login().Show();
            this.Hide();
        }
        private void employee_home_Load(object sender, EventArgs e)
        {
            label1.Text=LoginInfo.UserID;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginInfo.UserID = null;
            new employee_login().Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginInfo.UserID = null;
            new employee_login().Show();
            this.Hide();
        }

        private void addApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Expense_Form().Show();
            this.Hide();
        }

        private void viewApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new show_emp_expense().Show();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new edit_form().Show();
        }
    }
}
