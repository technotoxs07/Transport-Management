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

namespace CurierManagementSystemCSharp
{
    public partial class consignmentreport : Form
    {
        public consignmentreport()
        {
            InitializeComponent();
        }

        private void consignmentreport_Load(object sender, EventArgs e)
        {
            this.add_businessTableAdapter.Fill(this.add_business._add_business);
            
            this.consignTableAdapter.Fill(this.courierDataSet.consign);
           

            this.reportViewer1.RefreshReport();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Customer_Name from consign", con);
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
                // Further processing with the selectedCustomerName.
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
                {
                    con.Open();
                    // Modify the SQL query to filter by the selectedCustomerName
                    string query = "SELECT * FROM consign WHERE Customer_Name = @Customer_Name";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Customer_Name", selectedCustomerName);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    // Clear any previous data sources and set the new data source
                    foreach (var dataSource in reportViewer1.LocalReport.DataSources)
                    {
                        if (dataSource.Name == "DataSet1")
                        {
                            reportViewer1.LocalReport.DataSources.Remove(dataSource);
                            break; // Exit the loop once removed
                        }
                    }
                    //reportViewer1.LocalReport.DataSources.Clear();

                    ReportDataSource source = new ReportDataSource("DataSet1", dt);
                    reportViewer1.LocalReport.ReportPath = "consignment.rdlc";
                    reportViewer1.LocalReport.DataSources.Add(source);
                    reportViewer1.RefreshReport();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Correct Customer Name", "Customer Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
