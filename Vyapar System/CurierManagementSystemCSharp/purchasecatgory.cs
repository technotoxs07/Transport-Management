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
    public partial class purchasecatgory : UserControl
    {
        public purchasecatgory()
        {
            InitializeComponent();
        }

        private void purchasecatgory_Load(object sender, EventArgs e)
        {
            gettingcatitems();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True");

        private void gettingcatitems()
        {
            try
            {
                string query = "SELECT Category, COUNT(*) AS NumberOfItems FROM Items GROUP BY Category";
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True;"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Assuming you have a DataGridView named dataGridView1
                    // Add the columns to the DataGridView
                    dataGridView1.Columns.Add("Category", "Category");
                    dataGridView1.Columns.Add("NumberOfItems", "Number of Items");

                    // Populate the DataGridView with data from the DataTable
                    foreach (DataRow row in dt.Rows)
                    {
                        dataGridView1.Rows.Add(row["Category"], row["NumberOfItems"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
    }
}
