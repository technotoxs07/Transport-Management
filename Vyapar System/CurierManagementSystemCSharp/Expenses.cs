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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'expenses_.expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.expenses_.expenses);
            // TODO: This line of code loads data into the 'expenses_.expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.expenses_.expenses);
            // TODO: This line of code loads data into the 'customer_payement.Customer_payment' table. You can move, or remove it, as needed.
            showdatacategory();
            showdatafromexpenses();
        }

        private void showdatafromexpenses()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    string query3 = "SELECT * FROM expenses";
                    SqlCommand cmd3 = new SqlCommand(query3, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd3);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView2.DataSource = new BindingSource(dt, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void showdatacategory()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
            try
            {


                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT category FROM Exp_category", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    if (!txtexpensescategory.Items.Contains(row["category"].ToString()))
                    {
                        txtexpensescategory.Items.Add(row["category"].ToString());
                    }
                    //comboBox1.Items.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
            if (isempty())
            {


                try
                {
                    con.Open();
                    decimal quantity, price, amount, total;
                    if (!decimal.TryParse(txtquantity.Text, out quantity))
                    {
                        MessageBox.Show("Invalid quantity value: " + txtquantity.Text);
                        return;
                    }

                    if (!decimal.TryParse(txtprice.Text, out price))
                    {
                        MessageBox.Show("Invalid price value: " + txtprice.Text);
                        return;
                    }

                    // Calculate amount
                    amount = quantity * price;

                    // Set the calculated amount to txtamount TextBox
                    txtamount.Text = amount.ToString();

                    // Calculate total
                    total = amount; // You might adjust this if there's any additional logic for calculating total

                    // Set the total to textBox5 TextBox
                    textBox5.Text = total.ToString();

                    // Insert into the database
                    string query = "INSERT INTO expenses(Date, Category, Item, quantity, price, amount, total) " +
                                   "VALUES(@Date, @Category, @Item, @quantity, @price, @amount, @total);";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Category", txtexpensescategory.Text);
                    cmd.Parameters.AddWithValue("@Item", txtitems.Text);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.ExecuteNonQuery();


                    // Retrieve the maximum Id
                    string query2 = "SELECT MAX(ID) FROM expenses;";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    int maxId = (int)cmd2.ExecuteScalar();

                    // Clear input fields
                    //txtexpensescategory.Text = "";

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                    // Log the error for further investigation
                }
                finally
                {
                    con.Close();
                }
            }



        }

        private bool isempty()
        {
            if(txtexpensescategory.SelectedItem== "Add Expenses Category +")
            {
                MessageBox.Show("Please Select A Category", "Unselected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(txtitems.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Item Name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtquantity.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Item Name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtprice.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Item Name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtamount.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Item Name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (textBox5.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Item Name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
            con.Open();
            try
            {

                decimal quantity, price, amount, total;
                if (!decimal.TryParse(txtquantity.Text, out quantity))
                {
                    MessageBox.Show("Invalid quantity value: " + txtquantity.Text);
                    return;
                }

                if (!decimal.TryParse(txtprice.Text, out price))
                {
                    MessageBox.Show("Invalid price value: " + txtprice.Text);
                    return;
                }

                // Calculate amount
                amount = quantity * price;

                // Set the calculated amount to txtamount TextBox
                txtamount.Text = amount.ToString();

                // Calculate total
                total = amount; // You might adjust this if there's any additional logic for calculating total

                // Set the total to textBox5 TextBox
                textBox5.Text = total.ToString();

                // Insert into the database
                string query = "INSERT INTO expenses_real(Date, Category, Item, quantity, price, amount, total) " +
                               "VALUES(@Date, @Category, @Item, @quantity, @price, @amount, @total);";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Category", txtexpensescategory.Text);
                cmd.Parameters.AddWithValue("@Item", txtitems.Text);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.ExecuteNonQuery();


                // Retrieve the maximum Id
                string query2 = "SELECT MAX(ID) FROM expenses_real;";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                int maxId = (int)cmd2.ExecuteScalar();

                // Clear input fields
                //txtexpensescategory.Text = "";
                txtitems.Text = "";
                txtquantity.Text = "";
                txtprice.Text = "";
                txtamount.Text = "";
                textBox5.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
                // Log the error for further investigation
            }
            finally
            {
                con.Close();
            }
        }

        private void txtexpensescategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtexpensescategory.SelectedItem == "Add Expenses Category +")
            {
                Expensesaddcategory ec = new Expensesaddcategory();
                int centerX = (this.Width - ec.Width) / 2;
                int centerY = (this.Height - ec.Height) / 2;

                // Set the location of the user control to the center
                ec.Location = new Point(centerX, centerY);
                this.Controls.Add(ec);
                ec.BringToFront();
                //Savesettings();
            }
        }

        private void txtexpensescategory_Click(object sender, EventArgs e)
        {
            showdatacategory();
        }
    }
}
