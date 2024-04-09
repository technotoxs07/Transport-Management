﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CurierManagementSystemCSharp
{
    public partial class ViewAllCouriers : Form
    {
        public int Id;
        public ViewAllCouriers()
        {
            InitializeComponent();
        }
        public void LoadDataIntoDataGridView(SqlDataReader reader)
        {
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;
        }
        private void ViewAllCouriers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemcalculation.Itmcalculation' table. You can move, or remove it, as needed.
            this.itmcalculationTableAdapter.Fill(this.itemcalculation.Itmcalculation);
            // TODO: This line of code loads data into the 'itemcalculation.Itmcalculation' table. You can move, or remove it, as needed.
            //dataGridView1.Rows.Clear();

            // TODO: This line of code loads data into the 'itemcalculation.Itmcalculation' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'itemcalculation.Itmcalculation' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'purchase._Purchase' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'itemcalculation.Itmcalculation' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'purchase._Purchase' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'itemcalculation.Itmcalculation' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'purchase._Purchase' table. You can move, or remove it, as needed.
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // TODO: This line of code loads data into the 'purchase._Purchase' table. You can move, or remove it, as needed.

            /*using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=""D:\COURIER MANAGEMENT SYSTEM\CURIERMANAGEMENTSYSTEMCSHARP\BIN\RELEASE\COURIER.MDF"";Integrated Security=True"))
            {

                string str2 = "SELECT Item_Name, Quantity, Unit, Price, Discount, Amount_Charged FROM Purchase";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }*/
            gettingname();
            getitemfromcategory();
        }

        private void getitemfromcategory()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
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

        private void gettingname()
        {
            decimal grandtotal = Convert.ToDecimal(txtgrandtotal.Text);


            if (dataGridView1.DataSource != null)
            {
                if(dataGridView1.DataSource is BindingSource bindingSource)
                {
                    bindingSource.DataSource = null;
                }
                else if(dataGridView1.DataSource is DataTable dataTable)
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


          
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Customer_Name from addcustomers", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                customernametxt.Items.Add(sdr[0].ToString());
            }
            con.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
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
                loadinfitemcalculation();
               
                
            }

        }

        private void loadinfitemcalculation()
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

        private bool emptyboxes()
        {
            if (customernametxt.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Customer Name", "Customer Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


            if (decimal.TryParse(txtvat.Text, out decimal vatPercentage))
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
        }

        private void qtytxt_TextChanged(object sender, EventArgs e)
        {
            /* try
             {
                 decimal a = Convert.ToDecimal(qtytxt.Text);
             }
             catch(Exception)
             {
                 qtytxt.Text = ""; // Handle invalid input with a meaningful message.

             }
             try
             {
                 decimal a = Convert.ToDecimal(qtytxt.Text);

                 decimal b = Convert.ToDecimal(pricetxt.Text);
                 // int c = Convert.ToInt32(servicetaxtxt.Text);
                 Decimal totalprice = a * b;



                 //double vatandamount = totalvatwithamount + c;
                 amountchargedtxt.Text = totalprice.ToString();
             }
             catch (Exception)
             {
                 amountchargedtxt.Text = ""; // H
                                             // andle invalid input with a meaningful message.

             }
            */
        }

        private void Amountchargedtxt_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void customernametxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            getdetails();
            DataTable customerData = new DataTable();

            string selectedCustomerName = customernametxt.SelectedItem.ToString();

            // Clear the existing data for the currently selected customer
            customerData.Clear();

            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
            {
                string str2 = "SELECT * FROM Purchase WHERE Customer_Name = @Customer_Name";
                SqlCommand cmd3 = new SqlCommand(str2, con1);
                cmd3.Parameters.AddWithValue("@Customer_Name", selectedCustomerName);
                SqlDataAdapter sda = new SqlDataAdapter(cmd3);
                sda.Fill(customerData);
                dataGridView1.DataSource = new BindingSource(customerData, null);
            }

        }

        private void getdetails()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
            if (customernametxt.SelectedIndex != -1)
            {
                string selecteditem = customernametxt.SelectedItem.ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Customer_Address, Customer_Phone_Number, Customer_Mail FROM addcustomers WHERE Customer_Name = @Customer_Name", con);
                cmd.Parameters.AddWithValue("@Customer_Name", selecteditem);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    string address = sdr["Customer_Address"].ToString();
                    customeraddrtxt.Text = address;
                    string phonenumber = sdr["Customer_Phone_Number"].ToString();
                    customernumbertxt.Text = phonenumber;
                    string email = sdr["Customer_Mail"].ToString();
                    customermailtxt.Text = email;
                }
                sdr.Close();
                con.Close();

            }
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
                            string query = "INSERT INTO Purchase (Date, Customer_Name, Customer_Phone_Number, Address, Email, Category, Item_Name, Quantity, Unit, Price, Discount, Total_Amount, Sub_Total, VAT, Amout_VAT, Grand_Total) " +
                                           "VALUES (@Date, @Customer_Name, @Customer_Phone_Number, @Address, @Email, @Category, @Item_Name, @Quantity, @Unit, @Price, @Discount, @Total_Amount, @Sub_Total, @VAT, @Amout_VAT, @Grand_Total)";
                            SqlCommand cmd = new SqlCommand(query, con, transaction);
                            cmd.Parameters.AddWithValue("@Date", datetxt.Value);
                            cmd.Parameters.AddWithValue("@Customer_Name", customerName);
                            cmd.Parameters.AddWithValue("@Customer_Phone_Number", customerPhoneNumber);
                            cmd.Parameters.AddWithValue("@Address", address);
                            cmd.Parameters.AddWithValue("@Email", email);
                            cmd.Parameters.AddWithValue("@Category", categorytxt.SelectedItem);
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


                            string updateQuery = "UPDATE Items SET opening_quantity = opening_quantity - @Quantity WHERE item_name = @ItemName";
                            SqlCommand updateCmd = new SqlCommand(updateQuery, con, transaction);
                            updateCmd.Parameters.AddWithValue("@Quantity", quantity);
                            updateCmd.Parameters.AddWithValue("@ItemName", itemName);
                            updateCmd.ExecuteNonQuery();
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
                   

                    MessageBox.Show("Data Has been Cleared","CLEARED", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnreport_Click(object sender, EventArgs e)
        {
          
        }
        
        

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Check if the cell value is not null before converting or accessing
                if (selectedRow.Cells[0].Value != null && selectedRow.Cells[0].Value != DBNull.Value)
                {
                    Id = Convert.ToInt32(selectedRow.Cells[0].Value);
                }

                // Check if the cell value is not null before converting or accessing
                if (selectedRow.Cells[1].Value != null && selectedRow.Cells[1].Value != DBNull.Value)
                {
                    itemnametxt.Text = selectedRow.Cells[1].Value.ToString();
                }

                // Repeat similar checks for other cells...

                // Example for other cells
                if (selectedRow.Cells[2].Value != null && selectedRow.Cells[2].Value != DBNull.Value)
                {
                    qtytxt.Text = selectedRow.Cells[2].Value.ToString();
                }

                if (selectedRow.Cells[3].Value != null && selectedRow.Cells[3].Value != DBNull.Value)
                {
                    unittxt.Text = selectedRow.Cells[3].Value.ToString();
                }

                if (selectedRow.Cells[4].Value != null && selectedRow.Cells[4].Value != DBNull.Value)
                {
                    pricetxt.Text = selectedRow.Cells[4].Value.ToString();
                }

                if (selectedRow.Cells[5].Value != null && selectedRow.Cells[5].Value != DBNull.Value)
                {
                    discouttxt.Text = selectedRow.Cells[5].Value.ToString();
                }

                if (selectedRow.Cells[6].Value != null && selectedRow.Cells[6].Value != DBNull.Value)
                {
                    amountchargedtxt.Text = selectedRow.Cells[6].Value.ToString();
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
                loadinfitemcalculation();
            }
        }

        private void categorytxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = categorytxt.SelectedItem.ToString();
            showitemsdata(selectedCategory);
            if (categorytxt.SelectedItem != null && itemnametxt.SelectedItem != null)
            {
                // string selectedCategory = categorytxt.SelectedItem.ToString();
                string selectedItemName = itemnametxt.SelectedItem.ToString(); // or however you retrieve the selected item name
                                                                               // showitemsdata(selectedCategory);
                showpricedata(selectedItemName, selectedCategory);
            }
        }

        private void showitemsdata(string selectedcategory)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ItemName FROM Items WHERE Category = @selectedcategory", con);
                    cmd.Parameters.AddWithValue("@selectedcategory", selectedcategory);
                    itemnametxt.Items.Clear();
                    unittxt.Items.Clear();

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            itemnametxt.Items.Add(sdr["ItemName"].ToString());


                            //unittxt.Items.Add(sdr["Unit"].ToString());
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

        private void itemnametxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemnametxt.SelectedItem != null && categorytxt.SelectedItem != null)
            {
                string selectedItemName = itemnametxt.SelectedItem.ToString();
                string selectedCategory = categorytxt.SelectedItem.ToString();
                showpricedata(selectedItemName, selectedCategory);
            }

        }

        private void showpricedata(string selectedItemName, string selectedCategory)
        {
            pricetxt.Clear();

            // Query to retrieve the price data for the item name and category
            string query = "SELECT PurchasePrice, Unit FROM Items WHERE ItemName = @selectedItemName AND Category = @selectedCategory";

            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@selectedItemName", selectedItemName);
                    cmd.Parameters.AddWithValue("@selectedCategory", selectedCategory);

                    using (SqlDataReader srd = cmd.ExecuteReader())
                    {
                        while (srd.Read())
                        {
                            pricetxt.AppendText(srd["PurchasePrice"].ToString() + Environment.NewLine);
                            unittxt.Items.Add(srd["Unit"].ToString() + Environment.NewLine);
                        }
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
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            unittxt.Items.Clear();

            // Add "NONE" to the ComboBox
            unittxt.Items.Add("NONE");
            unittxt.Items.Add("BAGS (BAG)");
            unittxt.Items.Add("BOTTLES (BTL)");
            unittxt.Items.Add("BOX (BOX)");
            unittxt.Items.Add("BUNDLES (BDL)");
            unittxt.Items.Add("CANS (CAN)");
            unittxt.Items.Add("CARTONS (CTN)");
            unittxt.Items.Add("DOZENS (DZN)");
            unittxt.Items.Add("GRAMMES (GM)");
            unittxt.Items.Add("KILOGRAMS (KG)");
            unittxt.Items.Add("LITRE (LTR)");
            unittxt.Items.Add("METERS (MTR)");
            unittxt.Items.Add("MILILITRE (ML)");
            unittxt.Items.Add("NUMBERS (NOS)");
            unittxt.Items.Add("PACKS (PAC)");
            unittxt.Items.Add("PAIRS (PRS)");
            unittxt.Items.Add("PIECES (PCS)");
            unittxt.Items.Add("QUINTAL (QTL)");
            unittxt.Items.Add("ROLLS (ROL)");
            unittxt.Items.Add("SQUARE FEET (SQF)");
            unittxt.Items.Add("SQUARE METERS (SQM)");
            unittxt.Items.Add("TABLETS (TBS)");
        }
    }
}
