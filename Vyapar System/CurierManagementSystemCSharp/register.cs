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

namespace CurierManagementSystemCSharp
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void gotologin(Login ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            
            gotologin(new Login());
            this.Close();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfirstname.Text != "" && txtlastname.Text != "" && txtaddress.Text != "" && txtphonenumber.Text != "" && txtbusinessname.Text != "" && txtuserandemail.Text != "" && txtpassword.Text != "" && txtconfirmpassword.Text != "")
                {
                    if (txtpassword.Text == txtconfirmpassword.Text)
                    {
                        int v = check(txtuserandemail.Text, con);
                        if (v != 1)
                        {
                            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
                            {
                                con.Open();

                                // Hash the password before storing it
                               

                                using (SqlCommand cmd = new SqlCommand("INSERT INTO registration_login VALUES (@First_Name, @Last_Name, @Address, @Phone_Number, @Business_name, @email_Username, @password, @confirm_password)", con))
                                {
                                    cmd.Parameters.AddWithValue("@First_Name", txtfirstname.Text);
                                    cmd.Parameters.AddWithValue("@Last_Name", txtlastname.Text);
                                    cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                                    cmd.Parameters.AddWithValue("@Phone_Number", txtphonenumber.Text);
                                    cmd.Parameters.AddWithValue("@Business_name", txtbusinessname.Text);
                                    cmd.Parameters.AddWithValue("@email_Username", txtuserandemail.Text);
                                    cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                                    cmd.Parameters.AddWithValue("@confirm_password", txtconfirmpassword.Text); // Consider not storing the confirm password in the database

                                    // Use a transaction for better consistency
                                    using (SqlTransaction transaction = con.BeginTransaction())
                                    {
                                        try
                                        {
                                            cmd.Transaction = transaction;
                                            cmd.ExecuteNonQuery();
                                            transaction.Commit();
                                            MessageBox.Show("Register Successfully", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            cleardata();

                                        }
                                        catch (Exception ex)
                                        {
                                            transaction.Rollback();
                                            MessageBox.Show("Error occurred while registering: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("You Have Already Registered", "Already Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Don't Match", "Error Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cleardata()
        {
            txtfirstname.Clear();
            txtlastname.Clear();
            txtaddress.Clear();
            txtphonenumber.Clear();
            txtuserandemail.Clear();
            txtbusinessname.Clear();
            txtpassword.Clear();
            txtconfirmpassword.Clear();
        }

        private int check(string emailOrUsername, SqlConnection connection)
        {
            con.Open();
            using (SqlCommand smd = new SqlCommand("SELECT COUNT(*) FROM registration_login WHERE email_Username = @emailOrUsername", connection))
            {
                smd.Parameters.AddWithValue("@emailOrUsername", emailOrUsername);
                int count = (int)smd.ExecuteScalar();
                con.Close();
                return count;
            }


            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
                txtconfirmpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
                txtconfirmpassword.UseSystemPasswordChar = true;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
