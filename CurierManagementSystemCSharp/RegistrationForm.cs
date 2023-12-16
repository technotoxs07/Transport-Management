using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurierManagementSystemCSharp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        public string ProductID { get; private set; }
        public string ProductKey { get; private set; }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter all required information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           

            // Check if the experience days have passed since registration
         

            // Continue with the registration logic
            ProductID = textBox1.Text;
            ProductKey = textBox2.Text;
            if (!IsLicenseKeyValid(ProductKey))
            {
                MessageBox.Show("Invalid license key. Please enter a valid key.", "Invalid Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsLicenseAlreadyRegistered(ProductKey))
            {
                // Extract the number of experience days from the product key
                int experienceDays = ExtractExperienceDaysFromProductKey(ProductKey);

                // Check if the experience days have passed since registration
                if (HasExperienceDaysPassed(experienceDays))
                {
                    MessageBox.Show("Experience days have passed since registration.", "Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Open the registration form for re-registration
                    OpenRegistrationForm();
                    return;
                }

                // Open the Login form directly
               
                return;
            }
            // Optionally, you can perform additional validation or processing here
            if (IsLicenseAlreadyRegistered(textBox2.Text))
            {
                MessageBox.Show("This license is already registered.", "Duplicate Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Login lg = new Login();
                lg.ShowDialog();
                this.Close();
                return;
            }

            // Continue with the registration logic
            RegisterLicense(textBox2.Text);
            // Close the registration form with DialogResult.OK to indicate success
            DialogResult = DialogResult.OK;
            MessageBox.Show("Successfully Registered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login gl = new Login();
            gl.ShowDialog();
            this.Close();

        }

        private void OpenRegistrationForm()
        {
            RegistrationForm rf = new RegistrationForm();
            rf.ShowDialog();

        }

        private bool IsLicenseKeyValid(string productKey)
        {
            productKey = productKey.Trim();

            // Check length and character set
            if (productKey.Length != 25 || !productKey.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Invalid product key.", "Invalid Key", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Additional validation logic can be added based on your specific requirements

            return true;
        }

        private void RegisterLicense(string licenseKey)
        {
            // Create the directory if it doesn't exist
            string directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Transportation Management System");

            if (!Directory.Exists(directoryPath))
            {
                try
                {
                    Directory.CreateDirectory(directoryPath);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Error creating the directory: {ex.Message}", "Directory Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Now create the file path
            string filePath = Path.Combine(directoryPath, "RegisteredLicense.txt");

            // Check if the file exists; if not, create the file
            if (!File.Exists(filePath))
            {
                try
                {
                    // Create the file
                    using (File.Create(filePath)) { }
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Error creating the file: {ex.Message}", "File Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Append the new license key to the file
            try
            {
                File.AppendAllLines(filePath, new[] { licenseKey });
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error writing to the file: {ex.Message}", "File Write Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool IsLicenseAlreadyRegistered(string licenseKey)
        {

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Transportation Management System", "RegisteredLicense.txt");

            // Check if the license key exists in the file
            return File.Exists(filePath) && File.ReadAllLines(filePath).Contains(licenseKey);


        }

        private bool HasExperienceDaysPassed(int experienceDays)
        {
            // Retrieve the date of registration (you need to store this information during registration)
            DateTime registrationDate = DateTime.Now; // Replace with the actual registration date

            // Calculate the expiration date
            DateTime expirationDate = registrationDate.AddDays(experienceDays);

            // Check if the current date is after the expiration date
            return DateTime.Now > expirationDate;
        }

        private int ExtractExperienceDaysFromProductKey(string productKey)
        {
            string[] parts = productKey.Split('-');

            // Retrieve the encoded experience days (assuming it's the third part)
            if (parts.Length >= 3)
            {
                string encodedExperienceDays = parts[2];

                // Decode the experience days from the encoded string
                if (int.TryParse(encodedExperienceDays, out int experienceDays))
                {
                    return experienceDays;
                }
            }

            // Return a default value or handle the error as needed
            return 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            string licenseKey = textBox2.Text.Trim();

            if (IsLicenseAlreadyRegistered(licenseKey))
            {
              
                Login lg = new Login();
                lg.ShowDialog();
                this.Close();
                return;
            }
        }
    }
}
