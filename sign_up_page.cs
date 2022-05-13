using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sign_up
{
    public partial class sign_up_page : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aaytiw1\source\repos\sign_up\sign_up\Employee_data.mdf;Integrated Security=True";
        public sign_up_page()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_password.Text == "" || txt_email_id.Text == "" || txt_phone.Text==""|| comboBox1.Text=="" || txt_cfrm_password.Text=="")
                MessageBox.Show("Please fill mandatory fields");
            else { 
            Regex phonenumber = new Regex("\\d{4}\\d{3}\\d{4}");
            if (!phonenumber.IsMatch(txt_phone.Text))
            {
                MessageBox.Show("Not Valid phone number!");
                txt_phone.Focus();
            }
            Regex emailid = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!emailid.IsMatch(txt_email_id.Text))
                {
                    MessageBox.Show("Not Valid email id!");
                }
                else if (txt_password.Text != txt_cfrm_password.Text)
                {
                    MessageBox.Show("Password does not Match");
                    txt_cfrm_password.Clear();
                    txt_password.Clear();
                    txt_password.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Employee_Master where email_id='" + txt_email_id.Text.Trim() + "' or phone = '" + txt_phone.Text.Trim() + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    /*   SqlCommand cmd1 = new SqlCommand("select * from Employee_Master where phone='" + txt_phone.Text + "'", con);
                       SqlDataReader dr1 = cmd1.ExecuteReader(); */

                    if (dr.Read())
                    {
                        dr.Close();

                        MessageBox.Show("Username or phone number Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_email_id.Clear();
                        txt_phone.Clear();
                        txt_email_id.Focus();

                        //dr.Close();
                        /*      cmd = new SqlCommand("select * from Employee_Master where phone='" + txt_phone.Text + "'", con);
                              dr = cmd.ExecuteReader();
                              if (dr.Read())
                              {
                                  dr.Close();
                                  MessageBox.Show("Mobile Number Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                  txt_phone.Clear();
                                  txt_phone.Focus();
                              }*/
                    }

                    else
                        using (SqlConnection sqlcon = new SqlConnection(connectionString))
                        {
                            sqlcon.Open();
                            SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlcon);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@first_name", txt_first_name.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@last_name", txt_last_name.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@email_id", txt_email_id.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@phone", txt_phone.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@address", txt_address.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@department", comboBox1.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@password", txt_password.Text.Trim());
                            sqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Registration is Successfull");
                            txt_first_name.Clear();
                            txt_last_name.Clear();
                            txt_email_id.Clear();
                            txt_phone.Clear();
                            comboBox1.SelectedIndex = -1;
                            txt_address.Clear();
                            txt_password.Clear();
                            txt_cfrm_password.Clear();
                            txt_first_name.Focus();
                            sqlcon.Close();
                        }
                }
            }
        }

        private void bACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new main_page().Show();
            this.Hide();
        }
    }
}
