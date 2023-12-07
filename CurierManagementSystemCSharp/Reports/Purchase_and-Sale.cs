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
    public partial class Purchase_and_Sale : Form
    {
        public Purchase_and_Sale()
        {
            InitializeComponent();
        }

        private void Purchase_and_Sale_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
           

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True");
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
            supplyingaddbusiness();
            if (comboBox1.SelectedItem != null)
            {
                string selectedCustomerName = comboBox1.SelectedItem.ToString();
                // Further processing with the selectedCustomerName.
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
                {
                    con.Open();

                    // Modify the SQL query to filter by the selectedCustomerName
                    string query = "SELECT * FROM Purchase WHERE Customer_Name = @Customer_Name";
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
                    reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
                    reportViewer1.LocalReport.DataSources.Add(source);
                    reportViewer1.RefreshReport();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Correct Customer Name", "Customer Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void supplyingaddbusiness()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
            {
                con.Open();

                // Modify the SQL query to filter by the selectedCustomerName
                string query1 = "SELECT * FROM add_business";

               
                SqlCommand smd = new SqlCommand(query1, con);
           
                SqlDataAdapter sdaa = new SqlDataAdapter(smd);

               
                DataTable bt = new DataTable();

                
                sdaa.Fill(bt);
                // Clear any previous data sources and set the new data source
               //reportViewer1.LocalReport.DataSources.Clear();
              
                ReportDataSource sources = new ReportDataSource("DataSet2", bt);
                reportViewer1.LocalReport.ReportPath = "Report1.rdlc";


                reportViewer1.LocalReport.DataSources.Add(sources);

                reportViewer1.RefreshReport();

             
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
        
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
