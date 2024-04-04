using Microsoft.ReportingServices.Diagnostics.Internal;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CurierManagementSystemCSharp
{
    public partial class productdetails : Form
    {
        private string watermarkText1 = "SEARCH";
        public productdetails()
        {
            InitializeComponent();
        }

        private void productdetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemsdata.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.itemsdata.Items);
            // TODO: This line of code loads data into the 'itemsdata.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.itemsdata.Items);
            // TODO: This line of code loads data into the '_Purchases_Real_._Purchase_real_' table. You can move, or remove it, as needed.
            this.purchase_real_TableAdapter.Fill(this._Purchases_Real_._Purchase_real_);
            // TODO: This line of code loads data into the 'itemsdata.Items' table. You can move, or remove it, as needed.
           
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            getitemsandquantity(); 
            searchData("");

        }

        private void searchData(string valueToSearch)
        {
            try
            {
                string query = "SELECT * FROM [Purchase(real)] WHERE CONCAT( Id, Date, Item_Name, Quantity, Unit, Price) LIKE @valueToSearch";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@valueToSearch", "%" + valueToSearch + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView2.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close(); // Ensure to close the connection
            }
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True;");

        private void getitemsandquantity()
        {
            try
            {
                string query = "SELECT DISTINCT Category, opening_quantity FROM Items";
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True;"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    // Assuming you have a DataGridView named dataGridView1
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected Item_Name from the first column of the selected row
                string selectedItemName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                try
                {
                    // Query to retrieve data from the Purchase table for the selected item
                    string query = "SELECT Id, Date, Item_Name, Quantity, Unit, Price FROM [Purchase(real)] WHERE Item_Name = @Item_Name";
                    string query3 = "SELECT opening_quantity, Stock_Value FROM items WHERE Category = @Category";
                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
                    {
                        con.Open();

                        // Execute query to fetch purchase price from Items table
                        string query2 = "SELECT PurchasePrice FROM Items WHERE ItemName = @ItemName";
                        SqlCommand cmd2 = new SqlCommand(query2, con);

                        //feting data from Items of Quantity and Stock Value
                        SqlCommand command = new SqlCommand(query3, con);
                        cmd2.Parameters.AddWithValue("@ItemName", selectedItemName);

                        //
                        command.Parameters.AddWithValue("@Category", selectedItemName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Set the opening quantity to label1
                                label1.Text = reader["opening_quantity"].ToString();

                                // Set the stock value to label3
                                label3.Text = reader["Stock_Value"].ToString();
                            }
                            else
                            {
                                // Handle the case where no rows were returned for the given category
                            }
                        }

                        object purchasePriceObj = cmd2.ExecuteScalar();

                        if (purchasePriceObj != null && purchasePriceObj != DBNull.Value)
                        {
                            if (purchasePriceObj is decimal purchasePrice)
                            {
                                label7.Text = purchasePrice.ToString("0.00"); // Format decimal with two decimal places
                            }
                            else
                            {
                                label7.Text = purchasePriceObj.ToString();
                            }
                        }
                        else
                        {
                            label7.Text = "Price not available";
                        }

                        // Fill dataGridView2 with data from Purchase(real) table
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Item_Name", selectedItemName);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView2.DataSource = dt;

                        label6.Text = selectedItemName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {

                MessageBox.Show("There is No Purchase", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT  Id, Date, Item_Name, Quantity, Unit, Price FROM [Purchase(real)]";
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True;"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    // Assuming you have a DataGridView named dataGridView1
                    dataGridView2.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == watermarkText1 && textBox1.ForeColor == System.Drawing.Color.Gray)
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = watermarkText1;
                textBox1.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string valueToSearch = textBox1.Text;
            searchData(valueToSearch);
        }
    }
}
