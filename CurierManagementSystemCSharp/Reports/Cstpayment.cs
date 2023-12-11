using Microsoft.Reporting.WinForms;
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

namespace CurierManagementSystemCSharp.Reports
{
    public partial class customerpayment : Form
    {
        public customerpayment()
        {
            InitializeComponent();
        }

        private void customerpayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'add_business._add_business' table. You can move, or remove it, as needed.
            this.add_businessTableAdapter.Fill(this.add_business._add_business);
            // TODO: This line of code loads data into the 'customer_payement.Customer_payment' table. You can move, or remove it, as needed.
            this.customer_paymentTableAdapter.Fill(this.customer_payement.Customer_payment);
            // TODO: This line of code loads data into the 'add_business._add_business' table. You can move, or remove it, as needed.
          
            this.reportViewer1.RefreshReport();
            getname();
        }

        private void getname()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Update the table name in the query
                string query = "SELECT Customer_Name FROM Customer_payment";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            comboBox1.Items.Add(sdr[0].ToString());
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.add_businessTableAdapter.Fill(this.add_business._add_business);
            if (comboBox1.SelectedItem != null)
            {
                string selectedCustomerName = comboBox1.SelectedItem.ToString();

                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
                    {
                        con.Open();

                        string query = "SELECT * FROM Customer_payment WHERE Customer_Name = @Customer_Name";
                        string query1 = "SELECT * FROM add_business";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Customer_Name", selectedCustomerName);

                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                sda.Fill(dt);

                                ReportDataSource source = new ReportDataSource("customer_payement", dt);

                                using (SqlCommand cmd1 = new SqlCommand(query1, con))
                                {
                                    using (SqlDataAdapter sda1 = new SqlDataAdapter(cmd1))
                                    {
                                        DataTable bt = new DataTable();
                                        sda1.Fill(bt);

                                        // ReportDataSource for "add_business"
                                        ReportDataSource source1 = new ReportDataSource("add_business", bt);

                                        // Clear data sources once after both queries
                                        reportViewer1.LocalReport.DataSources.Clear();

                                        // Add data sources to the report
                                        reportViewer1.LocalReport.DataSources.Add(source);
                                        reportViewer1.LocalReport.DataSources.Add(source1);

                                        // Set the report path
                                        string reportPath = "cstpayments.rdlc";
                                        reportViewer1.LocalReport.ReportPath = reportPath;

                                        // Refresh the report
                                        reportViewer1.RefreshReport();
                                    }
                                }


                               
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception (e.g., log it or show an error message)
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
