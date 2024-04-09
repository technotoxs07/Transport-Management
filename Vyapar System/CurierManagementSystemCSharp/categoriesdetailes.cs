using Microsoft.ReportingServices.Diagnostics.Internal;
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
    public partial class categoriesdetailes : Form
    {
        private string watermarkText1 = "SEARCH";
        public categoriesdetailes()
        {
            InitializeComponent();
        }

        private void categoriesdetailes_Load(object sender, EventArgs e)
        {
            gettingcatitems();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // TODO: This line of code loads data into the 'itemsdata.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.itemsdata.Items);
            searchData("");

        }

        private void searchData(string valueToSearch)
        {
            
            try
            {
                string query = "SELECT * FROM Items WHERE CONCAT(ItemName, opening_quantity, at_Price, Stock_Value) LIKE @valueToSearch";
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


        SqlConnection con = new SqlConnection(@"l");

        private void gettingcatitems()
        {
            try
            {
                string query = "SELECT Category, COUNT(ItemName) AS Items FROM Items GROUP BY Category";

                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Clear existing columns if needed
                    //dataGridView1.Columns.Clear();

                    // Assign the DataTable as the DataGridView's DataSource
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected Category from the first column of the selected row
                string selectedCategory = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string selecteditem = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();


                try
                {
                    
                    // Query to retrieve data from the Purchase table for the selected category
                    string query = "SELECT ItemName, opening_quantity, at_Price, Stock_Value FROM Items WHERE Category = @Category";
                    using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
                    {
                        con.Open();

                        // Fill dataGridView2 with data from Purchase table
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Category", selectedCategory);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView2.DataSource = dt;
                        label6.Text = selectedCategory;
                        label1.Text = selecteditem;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT ItemName, opening_quantity, at_Price, Stock_Value FROM Items ";

                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Clear existing columns if needed
                    //dataGridView1.Columns.Clear();

                    // Assign the DataTable as the DataGridView's DataSource
                    dataGridView2.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
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

        private void textBox1_Click(object sender, EventArgs e)
        {
            string valueToSearch = textBox1.Text;
            searchData(valueToSearch);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string valueToSearch = textBox1.Text;
            searchData(valueToSearch);
        }
    }
}

