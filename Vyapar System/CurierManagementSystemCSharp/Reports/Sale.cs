using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurierManagementSystemCSharp.Reports
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'add_business._add_business' table. You can move, or remove it, as needed.
            this.add_businessTableAdapter.Fill(this.add_business._add_business);
            // TODO: This line of code loads data into the 'purchase._Purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.purchase._Purchase);
            // TODO: This line of code loads data into the 'add_business._add_business' table. You can move, or remove it, as needed.
            this.add_businessTableAdapter.Fill(this.add_business._add_business);
            // TODO: This line of code loads data into the 'purchase._Purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.purchase._Purchase);


            this.reportViewer1.RefreshReport();
            getname();
        }

        private void getname()
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Customer_Name from Purchase", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                comboBox1.Items.Add(sdr[0].ToString());
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedCustomerName = comboBox1.SelectedItem.ToString();

                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
                    {
                        con.Open();

                        string query = "SELECT * FROM Purchase WHERE Customer_Name = @Customer_Name";
                        string query1 = "SELECT * FROM add_business";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Customer_Name", selectedCustomerName);

                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                sda.Fill(dt);

                                // ReportDataSource for "Purchase"
                                ReportDataSource source = new ReportDataSource("Purchase", dt);

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
                                        string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Salesss.rdlc");
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
