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
    public partial class finance_home : Form
    {
        public finance_home()
        {
            InitializeComponent();
        }

        private void viewApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new finance_view().Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginInfo.UserID = null;
            new finance_login().Show();
            this.Hide();
        }

        private void finance_home_Load(object sender, EventArgs e)
        {
            label1.Text = LoginInfo.UserID;
        }
    }
}
