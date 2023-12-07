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
    public partial class staffReport : Form
    {
        public staffReport()
        {
            InitializeComponent();
        }

        private void staffReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courierDataSet4.staff' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'courierDataSet4.staff' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'courierDataSet4.staff' table. You can move, or remove it, as needed.
            this.reportViewer1.RefreshReport();
            // TODO: This line of code loads data into the 'courierDataSet4.staff' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'courierDataSet4.staff' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'add_business._add_business' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'courierDataSet4.staff' table. You can move, or remove it, as needed.

          

         
        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True");

            con.Open();

            // Create a SqlCommand with your SQL query
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM staff", con))
            {
                // Create a SqlDataAdapter and a DataTable
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                // Fill the DataTable with data from the database
                sda.Fill(dt);

                // Create a ReportDataSource with the DataTable
                ReportDataSource source = new ReportDataSource("DataSet1", dt);

                // Set the ReportViewer's ReportPath and add the ReportDataSource
                reportViewer1.LocalReport.ReportPath = "Staffreports.rdlc";
                reportViewer1.LocalReport.DataSources.Add(source);

                // Refresh the ReportViewer to display the report
                reportViewer1.RefreshReport();
            }
        }

       
    }
}
