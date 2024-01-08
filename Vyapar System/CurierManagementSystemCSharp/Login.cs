using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Diagnostics;
using System.Linq;
using System.ComponentModel;
using System.Net.Http;

namespace CurierManagementSystemCSharp
{
    public partial class Login : Form
    {


        private const string MsiUrl = "https://www.dropbox.com/scl/fi/zyfqclfoywsflyqe9j9e9/CurierManagementSystemCSharp.exe?rlkey=tx9nsnaxmw686u8yjzsvlb3ie&dl=1";

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

        private async void CheckForUpdates()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Replace ExeUrl with your Google Drive or appropriate URL
                    string exeUrl = "https://www.dropbox.com/scl/fi/zyfqclfoywsflyqe9j9e9/CurierManagementSystemCSharp.exe?rlkey=tx9nsnaxmw686u8yjzsvlb3ie&dl=1";

                    // Download the executable file asynchronously
                    HttpResponseMessage response = await client.GetAsync(exeUrl);

                    // Check if the download was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Replace "Update.exe" with the appropriate file name or path
                        string exeFileName = "CurierManagementSystemCSharp.exe";
                        string exePath = Path.Combine(Application.StartupPath, exeFileName);

                        // Save the downloaded content to the executable file
                        byte[] exeData = await response.Content.ReadAsByteArrayAsync();
                        File.WriteAllBytes(exePath, exeData);

                        // Notify the user and ask if they want to run the update executable
                        DialogResult result = MessageBox.Show($"Download completed successfully. Do you want to run {exeFileName} now?", "Update Available", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            RunUpdate(exePath);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Error downloading the file: {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking for updates: {ex.Message}");
            }
        }

        private void RunUpdate(string exePath)
        {
            try
            {
                // Run the update executable
                Process.Start(exePath);

                // Close the current application
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error running the update: {ex.Message}");
            }
        }

      

       


    }
}
