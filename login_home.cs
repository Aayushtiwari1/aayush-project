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
    public partial class login_home : Form
    {
        public login_home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new main_page().Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eMPLOYEELOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new employee_login().Show();
            this.Hide();
        }

        private void fINANCELOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new finance_login().Show();
            this.Hide();
        }
    }
}
