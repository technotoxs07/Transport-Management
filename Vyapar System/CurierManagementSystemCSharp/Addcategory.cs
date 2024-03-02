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
    public partial class Addcategory : UserControl
    {
        public Addcategory()
        {
            InitializeComponent();
        }
       // Items itms = new Items();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True");
            //con.Open();
            try
            {
                con.Open();
                string query = "INSERT INTO Category(category)VALUES('" + textBox1.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Added Successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

