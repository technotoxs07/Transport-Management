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
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel.Design;

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
            CheckForupdates();
            checkBox1.Checked = Properties.Settings.Default.CheckBox;
            txtusername.Text = Properties.Settings.Default.usertext;
            txtpassword.Text = Properties.Settings.Default.passwordtxt;
        }

        private void btndownloadserver_Click(object sender, EventArgs e)
        {
           
            RunasAdministrator();
        }

        private async void CheckForupdates()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Replace VersionUrl with the URL of your version.txt file
                    string versionUrl = "https://www.dropbox.com/scl/fi/gyz7nivfy8fotpu22qt6h/Transportation-Setup.txt?rlkey=s8i1venjs7lnpy72su5332u8l&dl=1";

                    // Download the version information asynchronously
                    string remoteVersion = await client.GetStringAsync(versionUrl);

                    // Get the local version from your assembly
                    string localVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

                    // Compare versions
                    if (new Version(remoteVersion) > new Version(localVersion))
                    {
                        // New version is available, proceed with downloading
                        btndownloadserver.Text = "Updates Available";
                       
                        // await DownloadAndInstallUpdate();
                    }
                    else
                    {
                        btndownloadserver.Text = "No Updates Available";
                      
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error checking for updates: {ex.Message}");
            }
        }

        private async void RunasAdministrator()
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = Application.ExecutablePath,
                    Verb = "runas",
                    UseShellExecute = true
                };
                Process.Start(startInfo);
                await DownloadAndInstallUpdate();
                Application.Exit();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DownloadAndInstallUpdate()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Replace MsiUrl with your Google Drive or appropriate URL
                    string msiUrl = "https://www.dropbox.com/scl/fi/b7ogr6rotnk3k638oe5l8/Transportation-Setup.msi?rlkey=t2kxzi2ii0y1hfo9gfligu2oa&dl=1";

                    // Download the MSI file asynchronously
                    HttpResponseMessage response = await client.GetAsync(msiUrl);

                    // Check if the download was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Replace "Transportation_Setup.msi" with the appropriate file name or path
                        string msiFileName = "Transportation Setup.msi";
                        string msiPath = Path.Combine(Application.StartupPath, msiFileName);

                        // Save the downloaded content to the MSI file
                        byte[] msiData = await response.Content.ReadAsByteArrayAsync();
                        File.WriteAllBytes(msiPath, msiData);

                        // Notify the user and ask if they want to install the update
                        DialogResult result = MessageBox.Show($"Download completed successfully. Do you want to install {msiFileName} now?", "Update Available", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            InstallUpdate(msiPath);
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

        private void InstallUpdate(string msiPath)
        {
            try
            {
                // Run the installer
                Process.Start(msiPath);

                // Close the current application
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error installing the update: {ex.Message}");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.CheckBox = checkBox1.Checked;
            Properties.Settings.Default.usertext = txtusername.Text;
            Properties.Settings.Default.passwordtxt = txtpassword.Text; 
        }
    }

 }
