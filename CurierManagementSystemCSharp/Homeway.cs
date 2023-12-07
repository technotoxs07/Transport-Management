
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace CurierManagementSystemCSharp
{
    public partial class Homeway : Form
    {
        public Homeway()
        {
            InitializeComponent();
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Homeway_Load(object sender, EventArgs e)
        {
            loadingstaffrow();
            loadingcustomerrow();

            DisplayTotalGrandTotal();
            loadingconsignment();
            loadallconsigngrandtotal();
            DisplayGrandtotalfromrealpurchase();
        }

        private void DisplayGrandtotalfromrealpurchase()
        {
            decimal totalGrandTotal = CalculateTotalGrandTotalfromrealpurchase();
            label19.Text = $"Grand Total: Rs {totalGrandTotal}";
        }

        private decimal CalculateTotalGrandTotalfromrealpurchase()
        {
            decimal totalGrandTotal = 0;

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
            {
                con.Open();

                string query = "SELECT ISNULL(SUM(Grand_Total), 0) FROM [Purchase(real)]";
                SqlCommand cmd = new SqlCommand(query, con);

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalGrandTotal = Convert.ToDecimal(result);
                }
            }

            return totalGrandTotal;
        }

        private void loadallconsigngrandtotal()
        {
            decimal totalGrandTotal = CalculateconsignGrandTotal();
            label25.Text = $": Rs {totalGrandTotal}";
        }

        private decimal CalculateconsignGrandTotal()
        {
            decimal totalGrandTotal = 0;

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
            {
                con.Open();

                string query = "SELECT ISNULL(SUM(Amount_Charged), 0) FROM consign";
                SqlCommand cmd = new SqlCommand(query, con);

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalGrandTotal = Convert.ToDecimal(result);
                }
            }

            return totalGrandTotal;
        }

        private void loadingconsignment()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Execute a SQL query to get data
                    string sqlQuery = "SELECT * FROM consign";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Display the count in a label
                        if (dataTable.Rows.Count > 0)
                        {
                            int rowCount = dataTable.Rows.Count;
                            label24.Text = $"{rowCount}";
                        }
                        else
                        {
                            label24.Text = "Branch : 0";
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayTotalGrandTotal()
        {
            decimal totalGrandTotal = CalculateTotalGrandTotal();
            label12.Text = $"Grand Total: Rs {totalGrandTotal}";
        }

        private decimal CalculateTotalGrandTotal()
        {
            decimal totalGrandTotal = 0;

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
            {
                con.Open();

                string query = "SELECT ISNULL(SUM(Grand_Total), 0) FROM Purchase";
                SqlCommand cmd = new SqlCommand(query, con);

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalGrandTotal = Convert.ToDecimal(result);
                }
            }

            return totalGrandTotal;
        }

        private void loadingcustomerrow()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Execute a SQL query to get data
                    string sqlQuery = "SELECT * FROM addcustomers";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Display the count in a label
                        if (dataTable.Rows.Count > 0)
                        {
                            int rowCount = dataTable.Rows.Count;
                            label3.Text = $"Number of Customer: {rowCount}";
                        }
                        else
                        {
                            label3.Text = "Customer : 0";
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void loadingstaffrow()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Execute a SQL query to get data
                    string sqlQuery = "SELECT * FROM staff";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Display the count in a label
                        if (dataTable.Rows.Count > 0)
                        {
                            int rowCount = dataTable.Rows.Count;
                            label2.Text = $"Number of Staffs: {rowCount}";
                        }
                        else
                        {
                            label2.Text = "Staffs : 0";
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //showing current date sale

            
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\\CURIERMANAGEMENTSYSTEMCSHARP\\CURIERMANAGEMENTSYSTEMCSHARP\\COURIER.MDF;Integrated Security=True"))
                    {
                        con.Open();

                        // Create a parameterized query for today's sales
                        string queryTodaySales = "SELECT ISNULL(SUM(Grand_Total), 0) FROM Purchase WHERE CONVERT(DATE, Date) = CONVERT(DATE, GETDATE())";

                        SqlCommand cmdTodaySales = new SqlCommand(queryTodaySales, con);

                        decimal grandTotalTodaySales = Convert.ToDecimal(cmdTodaySales.ExecuteScalar());

                        con.Close();

                        // Display today's sales
                        label15.Text = $"{grandTotalTodaySales}"; // Assuming you want to format as currency
                    if (decimal.TryParse(label15.Text, out decimal valueInLabel))
                    {
                        if (valueInLabel == 0 && valueInLabel <= 4999)
                        {
                            label15.ForeColor = Color.Red;
                            label16.Text = "↓ 100%";
                            label16.ForeColor = Color.Red;
                            label22.Text = "The Current Sale\n " +
                                "Situations is down\n" +
                                "Keep Patience\n";
                        }
                        else if (valueInLabel >= 5000 && valueInLabel == 10000)
                        {
                            label15.ForeColor = Color.Yellow;
                            label16.Text = "↨ 25 %";
                            label16.ForeColor = Color.Yellow;
                            label22.Text = "The Current Sale\n" +
                                "Situations is average\n" +
                                "Keep Going\n";
                        }
                        else if (valueInLabel >= 10000)
                        {
                            label15.ForeColor = Color.Green;
                            label16.Text = "↑";
                            label16.ForeColor = Color.Green;
                            label22.Text = "The Current Sale\n" +
                                "is going Well\n" +
                                "Well Done\n";
                        }
                    }
                }
                }
                catch (Exception ex)
                {
                    // Handle or log the exception
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
          

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private Form activeForm = null;
        private void gotoaddstaff(StaffDetails ChildForm)
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

        private void button1_Click(object sender, EventArgs e)
        {
            gotoaddstaff(new StaffDetails());
        }

        private void customerdetailsrow_Click(object sender, EventArgs e)
        {
            gotoaddcustomer(new ADD_CUSTOMER());
        }

        private void gotoaddcustomer(ADD_CUSTOMER ChildForm)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedItem == "This Months")
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\\CURIERMANAGEMENTSYSTEMCSHARP\\CURIERMANAGEMENTSYSTEMCSHARP\\COURIER.MDF;Integrated Security=True"))
                {
                    con.Open();

                    // Create a parameterized query for this month
                    string queryThisMonth = "SELECT ISNULL(SUM(Grand_Total), 0) FROM Purchase WHERE DATEPART(YEAR, Date) = YEAR(GETDATE()) AND DATEPART(MONTH, Date) = MONTH(GETDATE())";

                    // Create a parameterized query for this year
                    //string queryThisYear = "SELECT ISNULL(SUM(Grand_Total), 0) FROM Purchase WHERE DATEPART(YEAR, Date) = YEAR(GETDATE())";

                    SqlCommand cmdThisMonth = new SqlCommand(queryThisMonth, con);
                    //SqlCommand cmdThisYear = new SqlCommand(queryThisYear, con);

                    decimal grandTotalThisMonth = Convert.ToDecimal(cmdThisMonth.ExecuteScalar());
                  //  decimal grandTotalThisYear = Convert.ToDecimal(cmdThisYear.ExecuteScalar());

                    con.Close();

                    // Now, you have the grand totals for this month and this year
                    // You can use these values as needed, for example, display them in labels.
                    label12.Text = $"Grand-Total Of this Month Rs {grandTotalThisMonth}"; // Assuming you want to format as currency
                    //label12.Text = grandTotalThisYear.ToString("C");
                }
            }
           else if (comboBox2.SelectedItem == "This Year")
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\\CURIERMANAGEMENTSYSTEMCSHARP\\CURIERMANAGEMENTSYSTEMCSHARP\\COURIER.MDF;Integrated Security=True"))
                {
                    con.Open();

                    // Create a parameterized query for this month
                    //string queryThisMonth = "SELECT ISNULL(SUM(Grand_Total), 0) FROM Purchase WHERE DATEPART(YEAR, Date) = YEAR(GETDATE()) AND DATEPART(MONTH, Date) = MONTH(GETDATE())";

                    // Create a parameterized query for this year
                    string queryThisYear = "SELECT ISNULL(SUM(Grand_Total), 0) FROM Purchase WHERE DATEPART(YEAR, Date) = YEAR(GETDATE())";

                    //SqlCommand cmdThisMonth = new SqlCommand(queryThisMonth, con);
                    SqlCommand cmdThisYear = new SqlCommand(queryThisYear, con);

                   // decimal grandTotalThisMonth = Convert.ToDecimal(cmdThisMonth.ExecuteScalar());
                    decimal grandTotalThisYear = Convert.ToDecimal(cmdThisYear.ExecuteScalar());

                    con.Close();

                    // Now, you have the grand totals for this month and this year
                    // You can use these values as needed, for example, display them in labels.
                    //label12.Text = grandTotalThisMonth.ToString("C"); // Assuming you want to format as currency
                    label12.Text = $"Grand-Total Of this Year Rs {grandTotalThisYear}";
                }
            }
            else if(comboBox2.SelectedItem == "Entire Sale")
            {
                DisplayTotalGrandTotal();
            }

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "This Months")
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\\CURIERMANAGEMENTSYSTEMCSHARP\\CURIERMANAGEMENTSYSTEMCSHARP\\COURIER.MDF;Integrated Security=True"))
                {
                    con.Open();

                    // Create a parameterized query for this month
                    string queryThisMonth = "SELECT ISNULL(SUM(Grand_Total), 0) FROM [Purchase(real)] WHERE DATEPART(YEAR, Date) = YEAR(GETDATE()) AND DATEPART(MONTH, Date) = MONTH(GETDATE())";

                    // Create a parameterized query for this year
                    //string queryThisYear = "SELECT ISNULL(SUM(Grand_Total), 0) FROM Purchase WHERE DATEPART(YEAR, Date) = YEAR(GETDATE())";

                    SqlCommand cmdThisMonth = new SqlCommand(queryThisMonth, con);
                    //SqlCommand cmdThisYear = new SqlCommand(queryThisYear, con);

                    decimal grandTotalThisMonth = Convert.ToDecimal(cmdThisMonth.ExecuteScalar());
                    //  decimal grandTotalThisYear = Convert.ToDecimal(cmdThisYear.ExecuteScalar());

                    con.Close();

                    // Now, you have the grand totals for this month and this year
                    // You can use these values as needed, for example, display them in labels.
                    label19.Text = $"Grand-Total Of this Month Rs {grandTotalThisMonth}"; // Assuming you want to format as currency
                    //label12.Text = grandTotalThisYear.ToString("C");
                }
            }
            else if (comboBox2.SelectedItem == "This Year")
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\\CURIERMANAGEMENTSYSTEMCSHARP\\CURIERMANAGEMENTSYSTEMCSHARP\\COURIER.MDF;Integrated Security=True"))
                {
                    con.Open();

                    // Create a parameterized query for this month
                    //string queryThisMonth = "SELECT ISNULL(SUM(Grand_Total), 0) FROM Purchase WHERE DATEPART(YEAR, Date) = YEAR(GETDATE()) AND DATEPART(MONTH, Date) = MONTH(GETDATE())";

                    // Create a parameterized query for this year
                    string queryThisYear = "SELECT ISNULL(SUM(Grand_Total), 0) FROM [Purchase(real)] WHERE DATEPART(YEAR, Date) = YEAR(GETDATE())";

                    //SqlCommand cmdThisMonth = new SqlCommand(queryThisMonth, con);
                    SqlCommand cmdThisYear = new SqlCommand(queryThisYear, con);

                    // decimal grandTotalThisMonth = Convert.ToDecimal(cmdThisMonth.ExecuteScalar());
                    decimal grandTotalThisYear = Convert.ToDecimal(cmdThisYear.ExecuteScalar());

                    con.Close();

                    // Now, you have the grand totals for this month and this year
                    // You can use these values as needed, for example, display them in labels.
                    //label12.Text = grandTotalThisMonth.ToString("C"); // Assuming you want to format as currency
                    label19.Text = $"Grand-Total Of this Year Rs {grandTotalThisYear}";
                }
            }
            else if (comboBox2.SelectedItem == "Entire Sale")
            {
                DisplayGrandtotalfromrealpurchase();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gotoaddbusiness(new Internalcompanydetails());
        }

        private void gotoaddbusiness(Internalcompanydetails ChildForm)
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

        private void button3_Click(object sender, EventArgs e)
        {
            gotopurchase(new Purchasesss());
        }

        private void gotopurchase(Purchasesss ChildForm)
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            gotosaless(new ViewAllCouriers());
        }

        private void gotosaless(ViewAllCouriers ChildForm)
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

        private void button4_Click(object sender, EventArgs e)
        {
            gotodeliverydetails(new DeliveryDetails());
        }

        private void gotodeliverydetails(DeliveryDetails ChildForm)
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
    }
}
