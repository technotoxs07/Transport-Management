using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Diagnostics;
using System.Linq;

namespace CurierManagementSystemCSharp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            WebClient webclient = new WebClient();
            var client = new WebClient();

            if(!webclient.DownloadString("https://www.dropbox.com/scl/fi/lfjhqqzv79azq72ipr94c/Transportation-Setup.txt?rlkey=5d39bl91xeq609y2teo144riv&dl=1").Contains("4.0.0"))
            {
                if (MessageBox.Show("New update available ! Do you want to install it", "Transportation Management System", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)

                
                {
                        try
                        {
                            if(File.Exists(@".\Transportation Setup.msi"))
                            {
                                File.Delete(@".\Transportation Setup.msi");
                            }
                            client.DownloadFile("https://www.dropbox.com/scl/fi/csqvmv7u1f5wwas6hmd2e/Transportation-Setup.zip?rlkey=dmr3im9jw3ppzjmxpknw2k3ee&dl=1", @"Transportation Setup.zip");
                            string zipPath = @".\Transportation Setup.zip";
                            string extractPath = @".\";
                        ZipFile.ExtractToDirectory(zipPath, extractPath);

                        Process process = new Process();
                        process.StartInfo.FileName = "msiexec";
                        process.StartInfo.Arguments = string.Format("/i Transportation Setup.msi");

                        this.Close();
                        process.Start();
                        }
                        catch
                        {

                        }
                }
            }
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

        private void FetchUserData(string text)
        {
            loadingdelivery();
            loadingaddbusines();
            loadaddcustomer();
            loadconsign();
            loadcustomerpayement();
           
            loadsale();
            loadpurchase();
            loadstaff();
        }

        private void loadstaff()
        {
            using (SqlConnection userConnection = new SqlConnection(@"Data Source=DESKTOP-Q7QFH6B\SQLEXPRESS;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
            {
                userConnection.Open();

                // Example query to fetch data from the "delivery" table in the user-specific database
                string query = "SELECT * FROM staff";
                using (SqlCommand cmd = new SqlCommand(query, userConnection))
                {
                    // Process the retrieved data as needed
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        StaffDetails mainForm = Application.OpenForms.OfType<StaffDetails>().FirstOrDefault();

                        // Check if the MainForm instance exists
                        if (mainForm != null)
                        {
                            // Call the method in MainForm to load the data into the DataGridView
                            mainForm.LoadDataIntoDataGridView(reader);
                        }
                    }
                }
            }
        }

        private void loadpurchase()
        {
            using (SqlConnection userConnection = new SqlConnection(@"Data Source=DESKTOP-Q7QFH6B\SQLEXPRESS;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
            {
                userConnection.Open();

                // Example query to fetch data from the "delivery" table in the user-specific database
                string query = "SELECT * FROM [Purchase(real)]";
                using (SqlCommand cmd = new SqlCommand(query, userConnection))
                {
                    // Process the retrieved data as needed
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Purchasesss mainForm = Application.OpenForms.OfType<Purchasesss>().FirstOrDefault();

                        // Check if the MainForm instance exists
                        if (mainForm != null)
                        {
                            // Call the method in MainForm to load the data into the DataGridView
                            mainForm.LoadDataIntoDataGridView(reader);
                        }
                    }
                }
            }
        }

        private void loadsale()
        {
            using (SqlConnection userConnection = new SqlConnection(@"Data Source=DESKTOP-Q7QFH6B\SQLEXPRESS;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
            {
                userConnection.Open();

                // Example query to fetch data from the "delivery" table in the user-specific database
                string query = "SELECT * FROM Purchase";
                using (SqlCommand cmd = new SqlCommand(query, userConnection))
                {
                    // Process the retrieved data as needed
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        ViewAllCouriers mainForm = Application.OpenForms.OfType<ViewAllCouriers>().FirstOrDefault();

                        // Check if the MainForm instance exists
                        if (mainForm != null)
                        {
                            // Call the method in MainForm to load the data into the DataGridView
                            mainForm.LoadDataIntoDataGridView(reader);
                        }
                    }
                }
            }
        }

       

        private void loadcustomerpayement()
        {
            using (SqlConnection userConnection = new SqlConnection(@"Data Source=DESKTOP-Q7QFH6B\SQLEXPRESS;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
            {
                userConnection.Open();

                // Example query to fetch data from the "delivery" table in the user-specific database
                string query = "SELECT * FROM Customer_payment";
                using (SqlCommand cmd = new SqlCommand(query, userConnection))
                {
                    // Process the retrieved data as needed
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        customerpayement mainForm = Application.OpenForms.OfType<customerpayement>().FirstOrDefault();

                        // Check if the MainForm instance exists
                        if (mainForm != null)
                        {
                            // Call the method in MainForm to load the data into the DataGridView
                            mainForm.LoadDataIntoDataGridView(reader);
                        }
                    }
                }
            }
        }

        private void loadconsign()
        {
            using (SqlConnection userConnection = new SqlConnection(@"Data Source=DESKTOP-Q7QFH6B\SQLEXPRESS;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
            {
                userConnection.Open();

                // Example query to fetch data from the "delivery" table in the user-specific database
                string query = "SELECT * FROM consign";
                using (SqlCommand cmd = new SqlCommand(query, userConnection))
                {
                    // Process the retrieved data as needed
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Consignment mainForm = Application.OpenForms.OfType<Consignment>().FirstOrDefault();

                        // Check if the MainForm instance exists
                        if (mainForm != null)
                        {
                            // Call the method in MainForm to load the data into the DataGridView
                            mainForm.LoadDataIntoDataGridView(reader);
                        }
                    }
                }
            }
        }

        private void loadaddcustomer()
        {
            using (SqlConnection userConnection = new SqlConnection(@"Data Source=DESKTOP-Q7QFH6B\SQLEXPRESS;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
            {
                userConnection.Open();

                // Example query to fetch data from the "delivery" table in the user-specific database
                string query = "SELECT * FROM addcustomers";
                using (SqlCommand cmd = new SqlCommand(query, userConnection))
                {
                    // Process the retrieved data as needed
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        ADD_CUSTOMER mainForm = Application.OpenForms.OfType<ADD_CUSTOMER>().FirstOrDefault();

                        // Check if the MainForm instance exists
                        if (mainForm != null)
                        {
                            // Call the method in MainForm to load the data into the DataGridView
                            mainForm.LoadDataIntoDataGridView(reader);
                        }
                    }
                }
            }
        }

        private void loadingaddbusines()
        {
            using (SqlConnection userConnection = new SqlConnection(@"Data Source=DESKTOP-Q7QFH6B\SQLEXPRESS;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
            {
                userConnection.Open();

                // Example query to fetch data from the "delivery" table in the user-specific database
                string query = "SELECT * FROM add_business";
                using (SqlCommand cmd = new SqlCommand(query, userConnection))
                {
                    // Process the retrieved data as needed
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        Internalcompanydetails mainForm = Application.OpenForms.OfType<Internalcompanydetails>().FirstOrDefault();

                        // Check if the MainForm instance exists
                        if (mainForm != null)
                        {
                            // Call the method in MainForm to load the data into the DataGridView
                            mainForm.LoadDataIntoDataGridView(reader);
                        }
                    }
                }
            }
        }

        private void loadingdelivery()
        {
            using (SqlConnection userConnection = new SqlConnection(@"Data Source=DESKTOP-Q7QFH6B\SQLEXPRESS;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
            {
                userConnection.Open();

                // Example query to fetch data from the "delivery" table in the user-specific database
                string query = "SELECT * FROM delivery";
                using (SqlCommand cmd = new SqlCommand(query, userConnection))
                {
                    // Process the retrieved data as needed
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DeliveryDetails mainForm = Application.OpenForms.OfType<DeliveryDetails>().FirstOrDefault();

                        // Check if the MainForm instance exists
                        if (mainForm != null)
                        {
                            // Call the method in MainForm to load the data into the DataGridView
                            mainForm.LoadDataIntoDataGridView(reader);
                        }
                    }
                }
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
    }
}
