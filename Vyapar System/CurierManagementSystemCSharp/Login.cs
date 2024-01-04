using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Diagnostics;
using System.Linq;
using System.ComponentModel;

namespace CurierManagementSystemCSharp
{
    public partial class Login : Form
    {

        
        private readonly string updateUrl = "https://drive.google.com/uc?id=1tC_ps4njqqQQ5khYX9vJqEwSTsmfvBdv";
        private readonly string versionUrl = "https://drive.google.com/uc?id=1B-SEEpArsFRnKrj6OyYppSOAz_Krrecj";

        private readonly string tempFolderPath = Path.Combine(Path.GetTempPath(), "Vyapar System");

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

        private void FetchUserData(string text)
        {
         
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
            CheckForUpdates();
        }

        private void CheckForUpdates()
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (sender, e) =>
            {
                // Perform update check in the background
                bool updateAvailable = IsUpdateAvailable();
                e.Result = updateAvailable;
            };

            worker.RunWorkerCompleted += (sender, e) =>
            {
                // Handle the result on the UI thread
                bool updateAvailable = (bool)e.Result;
                if (updateAvailable)
                {
                    DialogResult result = MessageBox.Show("An update is available. Do you want to install it now?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DownloadAndInstallUpdate();
                    }
                }
                else
                {
                    MessageBox.Show("You are using the latest version.", "No Updates Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            worker.RunWorkerAsync();
        }
        private bool IsUpdateAvailable()
        {
            Version currentVersion = new Version(Application.ProductVersion);

            // Fetch the latest version available on the server
            Version latestVersion = GetLatestVersionFromServer();

            // Compare versions
            return latestVersion > currentVersion;
        }

        private Version GetLatestVersionFromServer()
        {
            try
            {
                // Download the version file from the server (assuming it's a simple text file with the version number)
                using (WebClient webClient = new WebClient())
                {
                    string versionString = webClient.DownloadString(versionUrl);

                    // Parse the version string
                    if (Version.TryParse(versionString, out Version latestVersion))
                    {
                        return latestVersion;
                    }
                    else
                    {
                        // Handle invalid version string
                        return new Version(3,0,0,0);
                    }
                }
            }
            catch (WebException)
            {
                // Handle exceptions (e.g., file not found, network error)
                return new Version(3,0,0,0);
            }
        }

        private void DownloadAndInstallUpdate()
        {
            try
            {
                // Inform the user about the update process
                MessageBox.Show("Updating the application. Please wait...", "Update in Progress", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Create a temporary folder for downloading and extracting the update
                if (!Directory.Exists(tempFolderPath))
                {
                    Directory.CreateDirectory(tempFolderPath);
                }

                // Download the update file
                string updateFilePath = Path.Combine(tempFolderPath, "Transportation Setup.zip");
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile(updateUrl, updateFilePath);
                }

                // Extract the update
                ZipFile.ExtractToDirectory(updateFilePath, tempFolderPath);

                // Close the current application with user confirmation
                if (MessageBox.Show("Update downloaded successfully. The application will now restart.", "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    // Close the current application
                    Application.Exit();

                    // Replace the old files with the updated files
                    string appFolderPath = AppDomain.CurrentDomain.BaseDirectory;
                    foreach (string file in Directory.GetFiles(tempFolderPath))
                    {
                        string fileName = Path.GetFileName(file);
                        string destinationPath = Path.Combine(appFolderPath, fileName);
                        File.Copy(file, destinationPath, true);
                    }

                    // Clean up temporary files
                    Directory.Delete(tempFolderPath, true);

                    // Start the updated application
                    Process.Start(Path.Combine(appFolderPath, Process.GetCurrentProcess().ProcessName + ".exe"));
                }
            }
            catch (Exception ex)
            {
                // Log the error
                Console.WriteLine($"Error during update: {ex.Message}");

                // Show an error message to the user
                MessageBox.Show($"Error during update: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
