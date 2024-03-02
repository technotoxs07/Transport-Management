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
    public partial class Purchasesss : Form
    {

        public int Id;
        public Purchasesss()
        {
            InitializeComponent();
           // customernametxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

        }
        public void LoadDataIntoDataGridView(SqlDataReader reader)
        {
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;
        }
        private void Purchasesss_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemcalculation.Itmcalculation' table. You can move, or remove it, as needed.
            this.itmcalculationTableAdapter.Fill(this.itemcalculation.Itmcalculation);
            // TODO: This line of code loads data into the 'itemcalculation.Itmcalculation' table. You can move, or remove it, as needed.
            this.itmcalculationTableAdapter.Fill(this.itemcalculation.Itmcalculation);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // TODO: This line of code loads data into the 'itemcalculation.Itmcalculation' table. You can move, or remove it, as needed.
            this.itmcalculationTableAdapter.Fill(this.itemcalculation.Itmcalculation);
            // TODO: This line of code loads data into the 'itemcalculation.Itmcalculation' table. You can move, or remove it, as needed.
            this.itmcalculationTableAdapter.Fill(this.itemcalculation.Itmcalculation);


            gettingname();
            Getcategoryfromitems();
            
        }

        private void Getcategoryfromitems()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Category from Items", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                categorytxt.Items.Add(sdr[0].ToString());
                //customernumbertxt.Items.Add(sdr[0].ToString());
                // string customerpayment = sdr["Amount_Charged"].ToString();
                //amountchargedtxt.Text = customerpayment;
            }
            con.Close();
           


        }
        private void categorytxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = categorytxt.SelectedItem.ToString();
            showitemsdata(selectedCategory);
        }
       


        private void showitemsdata(string selectedcategory)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ItemName, Unit FROM Items WHERE Category = @selectedcategory", con);
                    cmd.Parameters.AddWithValue("@selectedcategory", selectedcategory);
                    itemnametxt.Items.Clear();
                    unittxt.Items.Clear();
                   
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            itemnametxt.Items.Add(sdr["ItemName"].ToString());
                           

                            unittxt.Items.Add(sdr["Unit"].ToString());
                            // pricetxt.AppendText(sdr["SalePrice"].ToString() + Environment.NewLine);
                           
                        }
                    }
                   //
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

        private void showpricedata()
        {
            pricetxt.Clear();

            //Get the selected item name
            string selectedItemName = itemnametxt.SelectedItem.ToString();

            //Query to retreive the price data for the item name
            string query = "SELECT SalePrice FROM Items WHERE ItemName = @selectedItemName";

            using(SqlConnection  con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@selectedItemName", selectedItemName);

                    using (SqlDataReader srd = cmd.ExecuteReader())
                    {
                        while(srd.Read())
                        {
                            pricetxt.AppendText(srd["SalePrice"].ToString() + Environment.NewLine);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void gettingname()
        {
            decimal grandtotal = Convert.ToDecimal(txtgrandtotal.Text);


            if (dataGridView1.DataSource != null)
            {
                if (dataGridView1.DataSource is BindingSource bindingSource)
                {
                    bindingSource.DataSource = null;
                }
                else if (dataGridView1.DataSource is DataTable dataTable)
                {
                    dataTable.Clear();
                }
                else
                {
                    MessageBox.Show("Sorry Old Data Can' Be Deleted Please Contact Vendor (9812236482)", "Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (emptyboxes())
            {
                calculations();
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
                con.Open();
                try
                {
                    string query = "INSERT INTO Itmcalculation(Item_Name, Quantity, Unit, Price, Discount, Total_Amount) " +
                                    "VALUES(@ItemName, @Quantity, @Unit, @Price, @Discount, @TotalAmount);";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ItemName", itemnametxt.Text);
                    cmd.Parameters.AddWithValue("@Quantity", Convert.ToDecimal(qtytxt.Text)); // Convert to decimal
                    cmd.Parameters.AddWithValue("@Unit", unittxt.Text);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(pricetxt.Text)); // Convert to decimal
                    cmd.Parameters.AddWithValue("@Discount", Convert.ToDecimal(discouttxt.Text)); // Convert to decimal
                    cmd.Parameters.AddWithValue("@TotalAmount", Convert.ToDecimal(amountchargedtxt.Text)); // Convert to decimal
                    cmd.ExecuteNonQuery();

                    // Retrieve the maximum Id
                    string query2 = "SELECT MAX(Id) FROM Itmcalculation;";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    int maxId = (int)cmd2.ExecuteScalar();

                    // Clear input fields
                    itemnametxt.Text = "";
                    qtytxt.Text = "";
                    unittxt.Text = "";
                    pricetxt.Text = "";
                    discouttxt.Text = "";
                    amountchargedtxt.Text = "";
                }

                
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
               loadingdatafromitemcal();
            }
        }

        private void loadingdatafromitemcal()
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
            try
            {
                string str2 = "SELECT * FROM Itmcalculation";
                SqlCommand cmd3 = new SqlCommand(str2, con1);
                SqlDataAdapter sda = new SqlDataAdapter(cmd3);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);   
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con1.Close();
            }
        }

        private void calculations()
        {
            decimal totalAmount = 0;

            decimal vat = decimal.Parse(txtvat.Text);
            //string formattedValue = vat.ToString();
            try
            {
                decimal qty = decimal.Parse(qtytxt.Text);
                decimal price = decimal.Parse(pricetxt.Text);

                decimal discount = decimal.Parse(discouttxt.Text);
                decimal discountFactor = discount / 100;

                decimal total = qty * price;


                decimal discountAmount = total * discountFactor;
                total -= discountAmount;

                amountchargedtxt.Text = total.ToString();

                if (decimal.TryParse(txtsubtotal.Text, out decimal subtotal))
                {
                    // Update the subtotal by subtracting the previous total and adding the new total.
                    subtotal = subtotal - (qty * price) + total;

                    // Update the txtsubtotal TextBox with the new subtotal.
                    txtsubtotal.Text = subtotal.ToString();
                }
                else
                {
                    // Show an error message to the user if txtsubtotal.Text is not a valid decimal.
                    MessageBox.Show("Invalid value in the 'Subtotal' field. Please enter a valid decimal value.");
                }

                if (decimal.TryParse(amountchargedtxt.Text, out decimal displayedAmount))
                {
                    totalAmount += displayedAmount;
                }
                else
                {
                    amountchargedtxt.Text = "Invalid Input";
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please Enter Initially Value");
                // Handle the exception for invalid input (e.g., qtytxt.Text or pricetxt.Text not being valid decimals).
                amountchargedtxt.Text = "0"; // Clear the amountchargedtxt TextBox.
                                             // You can show an error message to the user.
            }



            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Assuming "Amount_Charged" is the name of the column, you can replace it with the actual column name.
                if (row.Cells["Total_Amount"].Value != null)
                {
                    decimal amountCharged = Convert.ToDecimal(row.Cells["Total_Amount"].Value);
                    totalAmount += amountCharged;
                }
            }



            txtsubtotal.Text = totalAmount.ToString();


            if(decimal.TryParse(txtvat.Text, out decimal vatPercentage))
            {
                decimal vatAmount = totalAmount * (vatPercentage / 100);

                decimal totalamountwithvat = totalAmount + vatAmount;

                txtamountwithvat.Text = totalamountwithvat.ToString();
                //txtvatamount.Text = vatAmount.ToString();



            }
            else
            {
                txtamountwithvat.Text = "Invalid VAT";
            }
            //decimal totalamountwithvat = totalAmount / (1 + vat);
        }

        private bool emptyboxes()
        {
            if (customernametxt.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Party Name", "Party Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (itemnametxt.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Item Name", "Items", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (unittxt.Text == string.Empty)
            {
                MessageBox.Show("Plese Select Unit", "Units", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtsubtotal.Text == string.Empty)
            {
                txtsubtotal.Text = "0";
                return false;
            }
            if (discouttxt.Text == string.Empty)
            {
                discouttxt.Text = "0";
                return false;
            }
            if (txtamountwithvat.Text == string.Empty)
            {
                txtamountwithvat.Text = "13";
                return false;
            }
            if (txtamountwithvat.Text == string.Empty)
            {
                txtamountwithvat.Text = "13";
                return false;
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // Common data for the entire purchases
                    //  DateTime date = DateTime.Parse(datetxt.Text);\
                    DateTime date = datetxt.Value;
                    string customerName = customernametxt.Text;
                    string customerPhoneNumber = customernumbertxt.Text;
                    string address = customeraddrtxt.Text;
                    string email = customermailtxt.Text;


                    decimal grandtotal = 0;


                    // Calculate the subtotal from the "txtsubtotal" TextBox.
                    if (decimal.TryParse(txtsubtotal.Text, out decimal subtotal))
                    {
                        grandtotal += subtotal;
                    }
                    else
                    {
                        // Show an error message to the user if "txtsubtotal" is not a valid decimal.
                        MessageBox.Show("Invalid value in the 'Subtotal' field. Please enter a valid decimal value.");
                    }

                    // Calculate the VAT from the "txtvat" TextBox.
                    if (decimal.TryParse(txtamountwithvat.Text, out decimal VAT))
                    {
                        grandtotal += VAT;
                    }
                    else
                    {
                        // Show an error message to the user if "txtvat" is not a valid decimal.
                        MessageBox.Show("Invalid value in the 'VAT' field. Please enter a valid decimal value.");
                    }
                    txtgrandtotal.Text = grandtotal.ToString();
                    // condn if GRANDTOTAL - PAIDAMOUT = 0

                    // You can display the result in a TextBox if needed.


                    // Loop through the DataGridView rows to save items
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            // Extract item-specific data from the DataGridView
                            string itemName = row.Cells["Item_Name"].Value.ToString();
                            int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                            string unit = row.Cells["Unit"].Value.ToString();
                            decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                            decimal discount = Convert.ToDecimal(row.Cells["Discount"].Value);
                            decimal totalAmount = Convert.ToDecimal(row.Cells["Total_Amount"].Value);


                            // Insert each item record into the "Purchase" table
                            string query = "INSERT INTO [Purchase(real)] (Date, Party_Name, Party_Phone_Number, Address, Email, Item_Name, Quantity, Unit, Price, Discount, Total_Amount, Sub_Total, VAT, Amout_VAT, Grand_Total) " +
                                           "VALUES (@Date, @Party_Name, @Party_Phone_Number, @Address, @Email, @Item_Name, @Quantity, @Unit, @Price, @Discount, @Total_Amount, @Sub_Total, @VAT, @Amout_VAT, @Grand_Total)";
                            SqlCommand cmd = new SqlCommand(query, con, transaction);
                            cmd.Parameters.AddWithValue("@Date", date);
                            cmd.Parameters.AddWithValue("@Party_Name", customerName);
                            cmd.Parameters.AddWithValue("@Party_Phone_Number", customerPhoneNumber);
                            cmd.Parameters.AddWithValue("@Address", address);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Item_Name", itemName);
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@Unit", unit);
                            cmd.Parameters.AddWithValue("@Price", price);
                            cmd.Parameters.AddWithValue("@Discount", discount);
                            cmd.Parameters.AddWithValue("@Total_Amount", totalAmount);
                            cmd.Parameters.AddWithValue("@Sub_Total", txtsubtotal.Text);
                            cmd.Parameters.AddWithValue("@VAT", txtvat.Text);
                            cmd.Parameters.AddWithValue("@Amout_VAT", txtamountwithvat.Text);
                            cmd.Parameters.AddWithValue("@Grand_Total", txtgrandtotal.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();

                    //clearing the datagridview items



                    MessageBox.Show("Items have been Saved Successfully.", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close(); // Close the database connection
                }
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    string deleteQuery = "DELETE FROM Itmcalculation";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, con, transaction);
                    deleteCmd.ExecuteNonQuery();

                    transaction.Commit();

                    // Clear the DataGridView after successfully saving and deleting

                    if (dataGridView1.DataSource != null)
                    {
                        if (dataGridView1.DataSource is BindingSource bindingSource)
                        {
                            bindingSource.DataSource = null;
                        }
                        else if (dataGridView1.DataSource is DataTable dataTable)
                        {
                            dataTable.Clear();
                        }
                        else
                        {
                            // Handle other data source types if needed
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();
                    }

                    datetxt.Text = "";
                    customernametxt.Text = "";
                    customernumbertxt.Text = "";
                    customeraddrtxt.Text = "";
                    customermailtxt.Text = "";
                    txtsubtotal.Text = "0.00";
                    discouttxt.Text = "0";
                    txtvat.Text = "13";
                    txtamountwithvat.Text = "0";
                    txtgrandtotal.Text = "0.00";


                    MessageBox.Show("Data Has been Cleared", "CLEARED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ... (Rest of your code)
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: Please Contact Vendor (9812236482)" + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");

        private void updtxt_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Itmcalculation SET Item_Name = @Item_Name, Quantity = @Quantity, Unit = @Unit, Price = @Price, Discount = @Discount, Total_Amount = @Total_Amount WHERE Id = @Id", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Item_Name", itemnametxt.Text);
                cmd.Parameters.AddWithValue("@Quantity", qtytxt.Text);
                cmd.Parameters.AddWithValue("@Unit", unittxt.Text);
                cmd.Parameters.AddWithValue("@Price", pricetxt.Text);
                cmd.Parameters.AddWithValue("@Discount", discouttxt.Text);
                cmd.Parameters.AddWithValue("@Total_Amount", amountchargedtxt.Text);
                
                cmd.Parameters.AddWithValue("@Id", this.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Purchases Items are Successfully Updates", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadingdatafromitemcal();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int id;
                if (selectedRow.Cells[0].Value != null && selectedRow.Cells[0].Value != DBNull.Value &&
                    int.TryParse(selectedRow.Cells[0].Value.ToString(), out id))
                {
                    Id = id;
                }

                if (selectedRow.Cells[1].Value != null && selectedRow.Cells[1].Value != DBNull.Value)
                {
                    itemnametxt.Text = selectedRow.Cells[1].Value.ToString();
                }

                // Repeat similar checks for other cells...

                int qty;
                if (selectedRow.Cells[2].Value != null && selectedRow.Cells[2].Value != DBNull.Value &&
                    int.TryParse(selectedRow.Cells[2].Value.ToString(), out qty))
                {
                    qtytxt.Text = qty.ToString();
                }

                // Repeat for other cells...

                decimal price;
                if (selectedRow.Cells[4].Value != null && selectedRow.Cells[4].Value != DBNull.Value &&
                    decimal.TryParse(selectedRow.Cells[4].Value.ToString(), out price))
                {
                    pricetxt.Text = price.ToString();
                }

                decimal discount;
                if (selectedRow.Cells[5].Value != null && selectedRow.Cells[5].Value != DBNull.Value &&
                    decimal.TryParse(selectedRow.Cells[5].Value.ToString(), out discount))
                {
                    discouttxt.Text = discount.ToString();
                }

                decimal amountCharged;
                if (selectedRow.Cells[6].Value != null && selectedRow.Cells[6].Value != DBNull.Value &&
                    decimal.TryParse(selectedRow.Cells[6].Value.ToString(), out amountCharged))
                {
                    amountchargedtxt.Text = amountCharged.ToString();
                }
            }


        }

        private void itemnametxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            showpricedata();
        }
    }
}
