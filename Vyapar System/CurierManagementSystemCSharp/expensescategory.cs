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
    public partial class expensescategory : Form
    {
        private string watermarkText1 = "SEARCH";
        public expensescategory()
        {
            InitializeComponent();
        }

        private void expensescategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'expenses_real.expenses_real' table. You can move, or remove it, as needed.
            this.expenses_realTableAdapter.Fill(this.expenses_real.expenses_real);
            gettingcategoryandamount();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");

        private void searchData(string valueToSearch)
        {
            try
            {
                string query = "SELECT * FROM expenses_real WHERE CONCAT( ID, Date, Category, Item, amount) LIKE @valueToSearch";
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

        private void gettingcategoryandamount()
        {
            try 
            {


                string query = "SELECT Category, price FROM expenses_real";
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
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
                    string query = "SELECT ID, Date, Category, Item, amount FROM expenses_real WHERE Category = @Category";
                   // string query3 = "SELECT opening_quantity, Stock_Value FROM items WHERE Category = @Category";

                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
                    {
                        con.Open();

                        // Execute query to fetch purchase price from Items table
                        string query2 = "SELECT total FROM expenses_real WHERE Category = @Category";
                        //SqlCommand command = new SqlCommand(query3, con);

                        SqlCommand cmd2 = new SqlCommand(query2, con);
                        cmd2.Parameters.AddWithValue("@Category", selectedItemName);
                       

                        object purchasePriceObj = cmd2.ExecuteScalar();

                        if (purchasePriceObj != null && purchasePriceObj != DBNull.Value)
                        {
                            if (purchasePriceObj is decimal purchasePrice)
                            {
                                label1.Text = purchasePrice.ToString("0.00"); // Format decimal with two decimal places
                            }
                            else
                            {
                                label1.Text = purchasePriceObj.ToString();
                            }
                        }
                        else
                        {
                            label1.Text = "Price not available";
                        }

                        // Fill dataGridView2 with data from Purchase(real) table
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Category", selectedItemName);
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
            if (textBox1.Text == watermarkText1 && textBox1.ForeColor == System.Drawing.Color.Gray)
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string valueToSearch = textBox1.Text;
            searchData(valueToSearch);
        }
    }
}
