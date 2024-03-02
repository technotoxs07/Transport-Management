using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CurierManagementSystemCSharp
{
    public partial class backupandrestore : Form
    {
        public backupandrestore()
        {
            InitializeComponent();
        }
       // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");

        private void btnbrowser_Click(object sender, EventArgs e)
        {
          
        }

        private void btnbrowser2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            // dlg.Filter = "SQL SERVER database Backup files| .bak";
            // dlg.Title = "Server Restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtrestorelocation.Text = dlg.FileName;
                btnrestore.Enabled = true;
            }
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            try
            {
                string dataDirectory = AppDomain.CurrentDomain.BaseDirectory;

                if (string.IsNullOrEmpty(dataDirectory))
                {
                    MessageBox.Show("DataDirectory is not set. Backup cannot proceed.");
                    return;
                }

                string sourceFilePath = Path.Combine(dataDirectory, "courier.mdf");
                string destinationFolderPath = txtlocationbckup.Text;
                string destinationFilePath = Path.Combine(destinationFolderPath, $"courier-{DateTime.Now.Ticks}.mdf");

                // Check if the destination file already exists and handle it appropriately
                if (File.Exists(destinationFilePath))
                {
                    MessageBox.Show("A backup file with the same name already exists. Please choose a different location or file name.");
                    return;
                }

                // Copy the MDF file to the backup location
                File.Copy(sourceFilePath, destinationFilePath);

                MessageBox.Show("Backup done successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during database backup: {ex.Message}");
            }
        }

        private void backupandrestore_Load(object sender, EventArgs e)
        {
            txtlocationbckup.Text = Properties.Settings.Default.usertext;
            txtrestorelocation.Text = Properties.Settings.Default.passwordtxt;

        }

        private void btnbrowser_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtlocationbckup.Text = dlg.SelectedPath;
                btnbackup.Enabled = true;
            }
        }

        private void btnbrowser2_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SERVER Restore |*.mdf|All Files|*.*";
            dlg.Title = "SELECT RESTORE FILE";
            dlg.Multiselect = true;
            // dlg.Filter = "SQL SERVER database Backup files| .bak";
            // dlg.Title = "Server Restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[] selectedFilenames = dlg.FileNames;

                string filesText = string.Join(Environment.NewLine, selectedFilenames);

                txtrestorelocation.Text = dlg.FileName;
                btnrestore.Enabled = true;
            }
        }

        private void btnbackup_Click_1(object sender, EventArgs e)
        {
            try
            {
                string dataDirectory = AppDomain.CurrentDomain.BaseDirectory;

                if (string.IsNullOrEmpty(dataDirectory))
                {
                    MessageBox.Show("DataDirectory is not set. Backup cannot proceed.");
                    return;
                }

                string sourceFilePath = Path.Combine(dataDirectory, "courier.mdf");
                string sorcefilepaths = Path.Combine(dataDirectory, "courier_log.ldf");
                string destinationFolderPath = txtlocationbckup.Text;

                // Use DateTime to generate a unique backup file name
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss");
                string destinationFilePath = Path.Combine(destinationFolderPath, $"courier-{timestamp}.mdf");
                string destinationFilepaths = Path.Combine(destinationFolderPath, $"courier_log-{timestamp}.ldf");

                // Check if the destination file already exists and handle it appropriately
                if (File.Exists(destinationFilePath))
                {
                    MessageBox.Show("A backup file with the same name already exists. Please choose a different location or file name.");
                    return;
                }

                // Copy the MDF file to the backup location
                File.Copy(sourceFilePath, destinationFilePath);
                File.Copy(sorcefilepaths, destinationFilepaths);

                MessageBox.Show("Backup done successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during database backup: {ex.Message}");
            }

        }

        private void btnrestore_Click(object sender, EventArgs e)
        {
            try
            {
                string datadirectory = AppDomain.CurrentDomain.BaseDirectory;

                if(string.IsNullOrEmpty(datadirectory))
                {
                    MessageBox.Show("DataDirectory is not set. Restore cannot Proceed");
                    return;
                }

                string sourceFilePath = txtrestorelocation.Text;

                string originalFileName = Path.GetFileNameWithoutExtension(sourceFilePath);
                string destinationFilePath = Path.Combine(datadirectory, "courier.mdf");
                string destinationFilepaths = Path.Combine(datadirectory, "courier_log.ldf");


                if (File.Exists(destinationFilePath))
                {
                    File.Copy(sourceFilePath, destinationFilePath, true);
                    File.Copy(sourceFilePath, destinationFilepaths, true);
                    MessageBox.Show("Existing file replaced with the restore file.");

                }
                else
                {

                    File.Copy(sourceFilePath, destinationFilePath);
                    File.Copy(sourceFilePath, destinationFilepaths);
                    MessageBox.Show("Restore done successfully!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error during database restore: {ex.Message}");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backupandrestore_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.usertext = txtlocationbckup.Text;
            Properties.Settings.Default.passwordtxt = txtrestorelocation.Text;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Close();
            register rg = new register();
            rg.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msipath = AppDomain.CurrentDomain.BaseDirectory + "SqlLocalDB.msi";

            if(System.IO.File.Exists(msipath))
            {
                try
                {
                    Process.Start(msipath);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error starting the Server" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }
            else
            {
                MessageBox.Show("Installer not found at: " + msipath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
