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
            downloadmdf();
            downloadldf();
        }

        private async void downloadldf()
        {
            try
            {
                // Replace "courier.mdf" with the appropriate file name
                string exeFileName = "courier_log.ldf";
                string exePath = Path.Combine(Application.StartupPath, exeFileName);

                // Check if the file already exists
                if (File.Exists(exePath))
                {
                    // The file exists, hide button3
                    btndownloadserver.Visible = false;
                }
                else
                {
                    using (HttpClient client = new HttpClient())
                    {
                        // Replace exeUrl with your Google Drive or appropriate URL
                        string exeUrl = "https://drive.google.com/uc?id=1TQbAVFC0ZZ2v1s5KZ-25xbphxLv2mnHV";

                        // Download the executable file asynchronously
                        HttpResponseMessage response = await client.GetAsync(exeUrl);

                        // Check if the download was successful
                        if (response.IsSuccessStatusCode)
                        {
                            // Save the downloaded content to the executable file
                            byte[] exeData = await response.Content.ReadAsByteArrayAsync();
                            File.WriteAllBytes(exePath, exeData);

                            // Hide button3 after downloading
                            button3.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show($"Error downloading the file: {response.ReasonPhrase}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please Contact Vendor (9812236482): {ex.Message}");
            }
        }

        private async void downloadmdf()
        {
            try
            {
                // Replace "courier.mdf" with the appropriate file name
                string exeFileName = "courier.mdf";
                string exePath = Path.Combine(Application.StartupPath, exeFileName);

                // Check if the file already exists
                if (File.Exists(exePath))
                {
                    // The file exists, hide button3
                    btndownloadserver.Visible = false;
                }
                else
                {
                    using (HttpClient client = new HttpClient())
                    {
                        // Replace exeUrl with your Google Drive or appropriate URL
                        string exeUrl = "https://drive.google.com/uc?id=1tsB3vJMeGrO3oKOOEnPY_Z6hH3LF7wTG";

                        // Download the executable file asynchronously
                        HttpResponseMessage response = await client.GetAsync(exeUrl);

                        // Check if the download was successful
                        if (response.IsSuccessStatusCode)
                        {
                            // Save the downloaded content to the executable file
                            byte[] exeData = await response.Content.ReadAsByteArrayAsync();
                            File.WriteAllBytes(exePath, exeData);

                            // Hide button3 after downloading
                            button3.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show($"Error downloading the file: {response.ReasonPhrase}");
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
