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
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
        }
        private void sIGNUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new sign_up_page().Show();
            this.Hide();
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

        private void cLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
