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
    public partial class unitsdetails : Form
    {
        private string watermarkText1 = "SEARCH";

        public unitsdetails()
        {
            InitializeComponent();
        }

        private void unitsdetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'unit_sonversion.unit_convers' table. You can move, or remove it, as needed.
            this.unit_conversTableAdapter.Fill(this.unit_sonversion.unit_convers);
            addingunit();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            searchData("");
            gettingunitconversion();
        }

        private void gettingunitconversion()
        {
            try
            {
                string query = "SELECT  ID, Unit_Conversion FROM unit_convers";
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
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

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");


        private void searchData(string valueToSearch)
        {
            try
            {
                string query = "SELECT * FROM unit_convers WHERE Unit_Conversion LIKE @valueToSearch";
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

        private void addingunit()
        {
            dataGridView1.Rows.Add("BAGS", "(BAG)");
            dataGridView1.Rows.Add("BOTTLES", "BOTTLES");
            dataGridView1.Rows.Add("BOX", "(BOX)");
            dataGridView1.Rows.Add("BUNDLES", "(BDL)");
            dataGridView1.Rows.Add("CANS", "(CAN)");
            dataGridView1.Rows.Add("CARTONS", "(CTN)");
            dataGridView1.Rows.Add("DOZENS", "(DZN)");
            dataGridView1.Rows.Add("GRAMMES", "(GM)");
            dataGridView1.Rows.Add("KILOGRAMS", "(KG)");
            dataGridView1.Rows.Add("LITRE", "(LTR)"); 
            dataGridView1.Rows.Add("METERS", "(MTR)");
            dataGridView1.Rows.Add("MILILITRE", "(ML)");
            dataGridView1.Rows.Add("NUMBERS", "(NOS)"); 
            dataGridView1.Rows.Add("PACKS", "(PAC)");
            dataGridView1.Rows.Add("PAIRS", "(PRS)");
            dataGridView1.Rows.Add("PIECES", "(PCS)");
            dataGridView1.Rows.Add("QUINTAL", "(QTL)");
            dataGridView1.Rows.Add("ROLLS", "(ROL)");
            dataGridView1.Rows.Add("SQUARE FEET", "(SQF)");
            dataGridView1.Rows.Add("SQUARE METERS", "(SQM)");
            dataGridView1.Rows.Add("TABLETS", "(TBS)");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Get the value of the "Unit_Conversion" column
                string unitConversion = row.Cells["FULL_NAME"].Value.ToString();

                // Display the unit conversion in a label or textbox
                label6.Text = unitConversion;
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

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            gettingunitconversion();
        }
    }
}
