﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Diagnostics;
using System.Linq;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace CurierManagementSystemCSharp
{
    public partial class Login : Form
    {
        



        //   private readonly string tempFolderPath = Path.Combine(Path.GetTempPath(), "Vyapar System");

        public Login()
        {
            InitializeComponent();

         

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHACOURIER;User Id=Ronit Shrivastav;Password=H@ck3r777;");

        private void button2_Click(object sender, EventArgs e)
        {
        }
        private Form activeForm = null;

        private void label4_Click(object sender, EventArgs e)
        {
            gotoresgister(new register());
        }

        private void gotoresgister(register ChildForm)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtusername.Text != "" && txtpassword.Text != "")
            {
                string query = "select count(*) from registration_login where email_Username = '" + txtusername.Text + "' AND  password ='" + txtpassword.Text + "'";
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {


                        int count = (int)cmd.ExecuteScalar();

                        if (count != 1)
                        {
                            MessageBox.Show("Error: Invalid Username or Password", "Error");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Welcome, You are logged in successfully.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //FetchUserData(txtusername.Text);
                        }

                        cleartext();
                        this.Visible = false;
                        Home obj1 = new Home();
                        obj1.ShowDialog();

                    }

                    // Close the connection explicitly
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Username and Password.");
            }



        }

     


        private void cleartext()
        {

            txtusername.Text = "";
            txtpassword.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            cleartext();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
            register rg = new register();
            rg.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }

       

    

       

        private void btndownloadserver_Click(object sender, EventArgs e)
        {
            btndownloadserver.Enabled = false;
            downloadmdf();
            btndownloadserver.Text = string.Empty;
            btndownloadserver.Text += "Please wait ....";
        }

     

        private async void downloadmdf()
        {
            try
            {
                // Replace "courier.mdf" and "courier.ldf" with the appropriate file names
                string mdfFileName = "courier.mdf";
                string ldfFileName = "courier.ldf";

                string mdfPath = Path.Combine(Application.StartupPath, mdfFileName);
                string ldfPath = Path.Combine(Application.StartupPath, ldfFileName);

                // Check if both files already exist
                if (File.Exists(mdfPath) && File.Exists(ldfPath))
                {
                    // Both files exist, hide btndownloadserver
                    btndownloadserver.Visible = false;
                }
                else
                {
                    using (HttpClient client = new HttpClient())
                    {
                        // Replace exeUrl with your Google Drive or appropriate URL
                        string mdfUrl = "https://drive.google.com/uc?id=1tsB3vJMeGrO3oKOOEnPY_Z6hH3LF7wTG";
                        string ldfUrl = "https://drive.google.com/uc?id=1TQbAVFC0ZZ2v1s5KZ-25xbphxLv2mnHV"; // Replace with the actual Google Drive file ID for courier.ldf

                        // Download the mdf file asynchronously
                        HttpResponseMessage mdfResponse = await client.GetAsync(mdfUrl);

                        // Check if the download was successful
                        if (mdfResponse.IsSuccessStatusCode)
                        {
                            // Save the downloaded content to the mdf file
                            byte[] mdfData = await mdfResponse.Content.ReadAsByteArrayAsync();
                            File.WriteAllBytes(mdfPath, mdfData);

                            // Download the ldf file asynchronously
                            HttpResponseMessage ldfResponse = await client.GetAsync(ldfUrl);

                            // Check if the download was successful
                            if (ldfResponse.IsSuccessStatusCode)
                            {
                                // Save the downloaded content to the ldf file
                                byte[] ldfData = await ldfResponse.Content.ReadAsByteArrayAsync();
                                File.WriteAllBytes(ldfPath, ldfData);

                                // Hide btndownloadserver after downloading both files
                                btndownloadserver.Visible = false;
                                btndownloadserver.Dispose();
                                btndownloadserver = null;
                            }
                            else
                            {
                                MessageBox.Show($"Error downloading the ldf file: {ldfResponse.ReasonPhrase}");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Error downloading the mdf file: {mdfResponse.ReasonPhrase}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please Contact Vendor (9812236482): {ex.Message}");
            }


        }
    }
}
