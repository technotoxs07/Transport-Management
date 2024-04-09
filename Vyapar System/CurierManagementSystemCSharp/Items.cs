using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurierManagementSystemCSharp
{
    public partial class Items : Form
    {
        private string watermarkText1 = "Opening Quantity";
        private string watermarkText2 = "At Price";
        private string watermarkText3 = "Min Stock To Maintain";
        private string watermarkText4 = "Location";
        public Items()
        {
            InitializeComponent();
            // comboBox1.SelectedItem = Properties.Settings.Default.categorytxt.ToString();
            // LoadComboBoxText();
            //LoadComboBoxItems();
            showdatacategory();
            SetWatermark();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Unitconversion UC = new Unitconversion();
            int centerX = (this.Width - UC.Width) / 2;
            int centerY = (this.Height - UC.Height) / 2;

            // Set the location of the user control to the center
            UC.Location = new Point(centerX, centerY);
            this.Controls.Add(UC);
            UC.BringToFront();
        }
        public void GetSettings()
        {
            comboBox1.SelectedItem = Properties.Settings.Default.categorytxt.ToString(); 

        }
        private void Items_Load(object sender, EventArgs e)
        {
            // GetSettings();
            //SaveComboBoxText();
            //   Savesettings();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DodgerBlue;

            // TODO: This line of code loads data into the 'itemsdata.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.itemsdata.Items);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            showdatacategory();
            showdatafromitems();
        }

        private void showdatafromitems()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    string query3 = "SELECT * FROM Items";
                    SqlCommand cmd3 = new SqlCommand(query3, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd3);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = new BindingSource(dt, null);
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
                SqlDataAdapter sda = new SqlDataAdapter("SELECT category FROM Category", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    if (!comboBox1.Items.Contains(row["category"].ToString()))
                    {
                        comboBox1.Items.Add(row["category"].ToString());
                    }
                    //comboBox1.Items.Add(row[0].ToString());
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

        private void SaveComboBoxText()
        {
           // Properties.Settings.Default.categorytxt = comboBox1.Text;

            // Save items to settings
            Properties.Settings.Default.categorytxt = new StringCollection();
            Properties.Settings.Default.categorytxt.AddRange(comboBox1.Items.Cast<string>().ToArray());

            // Save changes
            Properties.Settings.Default.Save();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void AddItemsToComboBox(string newItem)
        {
            // Add the new item to ComboBox1
            comboBox1.Items.Add(newItem);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // showdatacategory();
            //showrecentdatacategory();
            if (comboBox1.SelectedItem == "+ Add Category")
            {
                Addcategory AC = new Addcategory();
                int centerX = (this.Width - AC.Width) / 2;
                int centerY = (this.Height - AC.Height) / 2;

                // Set the location of the user control to the center
                AC.Location = new Point(centerX, centerY);
                this.Controls.Add(AC);
                AC.BringToFront();

                //Savesettings();
            }
            
           
        }

        private void showrecentdatacategory()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");

            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Category", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    comboBox1.Items.Add(row[0].ToString());
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

        private void Items_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            // Assuming yourUserControl is an instance of YourUserControl in your form
            // Create an instance of Unitconversion
            if(isempty())
            {

                Unitconversion UN = new Unitconversion();
                List<string> listBoxItems = UN.GetListBoxItems();

                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
                {
                    con.Open();

                    try
                    {
                        foreach (string item in listBoxItems)
                        {
                            decimal openingQuantity = decimal.Parse(txtopeningquantity.Text);
                            decimal price = decimal.Parse(txtprice.Text);
                            decimal stockValue = openingQuantity * price;
                            // SQL query with parameters
                            // string Id = Guid.NewGuid().ToString("N");

                            string query = "INSERT INTO Items (ItemName, Category, Unit, SalePrice, PurchasePrice, opening_quantity, at_Price, date, Min_Stock, Location, Stock_Value) VALUES (@ItemName, @Category, @Unit, @SalePrice, @PurchasePrice, @opening_quantity, @at_Price, @date, @Min_Stock, @Location, @Stock_Value)";
                            SqlCommand cmd = new SqlCommand(query, con);

                            // Add parameters to the command
                           // cmd.Parameters.AddWithValue("@Id", Id);
                            cmd.Parameters.AddWithValue("@ItemName", itemnametxt.Text);
                            cmd.Parameters.AddWithValue("@Category", comboBox1.SelectedItem);
                            cmd.Parameters.AddWithValue("@Unit", item);
                            cmd.Parameters.AddWithValue("@SalePrice", txtsale.Text);
                            cmd.Parameters.AddWithValue("@PurchasePrice", txtpurchase.Text);
                            cmd.Parameters.AddWithValue("@opening_quantity", txtopeningquantity.Text);
                                cmd.Parameters.AddWithValue("@at_Price", txtprice.Text);
                            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                            cmd.Parameters.AddWithValue("@Min_Stock", txtminstock.Text);
                            cmd.Parameters.AddWithValue("@Location", txtlocation.Text);
                            cmd.Parameters.AddWithValue("@Stock_Value", stockValue); 
                            cmd.ExecuteNonQuery();

                            // Get the max Id from the Items table
                            string query2 = "SELECT max(Id) FROM Items";
                            SqlCommand cmd2 = new SqlCommand(query2, con);
                            int maxId = (int)cmd2.ExecuteScalar();

                            MessageBox.Show("Item added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                            itemnametxt.Text = "";
                            txtsale.Text = "";
                            txtpurchase.Text = "";
                            txtopeningquantity.Text = "";
                           

                            // Reload the data in the DataGridView
                            showdatafromitems();
                            UN.ClearListBoxItems();
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Handle the exception, for example, show an error message
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                       
                    }
                }
            }
        }

        private bool isempty()
        {
             if(comboBox1.SelectedItem == "+ Add Category")
            {
                MessageBox.Show("Please Select A Category", "Unselected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           if(itemnametxt.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Item Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtsale.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Item Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtpurchase.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Item Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
           
        }

        private void Savesettings()
        {
           // Save selected text to settings
           // Properties.Settings.Default.categorytxt = comboBox1.Text;

    // Save items to settings
            Properties.Settings.Default.categorytxt = new System.Collections.Specialized.StringCollection();
            Properties.Settings.Default.categorytxt.AddRange(comboBox1.Items.Cast<string>().ToArray());

    // Save changes
             Properties.Settings.Default.Save();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            showdatacategory();
        }

        private void txtsale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit or control key, ignore the input
                e.Handled = true;
            }
        }

        private void txtpurchase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not a digit or control key, ignore the input
                e.Handled = true;
            }
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtopeningquantity.Text == watermarkText1 && txtopeningquantity.ForeColor == System.Drawing.Color.Gray)
            {
                txtopeningquantity.Text = "";
                txtopeningquantity.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void ClearWatermark()
        {
          
           
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
           // SetWatermark();
            if (string.IsNullOrEmpty(txtopeningquantity.Text))
            {
                txtopeningquantity.Text = watermarkText1;
                txtopeningquantity.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void SetWatermark()
        {
            if (string.IsNullOrEmpty(txtopeningquantity.Text))
            {
                txtopeningquantity.Text = watermarkText1;
                txtopeningquantity.ForeColor = System.Drawing.Color.Gray;
            }
            /*else if (string.IsNullOrEmpty(textBox1.Text))
             {
                 textBox1.Text = watermarkText2;
                 textBox1.ForeColor = System.Drawing.Color.Gray;
             }
             else if (string.IsNullOrEmpty(textBox3.Text))
             {
                 textBox3.Text = watermarkText3;
                 textBox3.ForeColor = System.Drawing.Color.Gray;
             }
             else if (string.IsNullOrEmpty(textBox4.Text))
             {
                 textBox4.Text = watermarkText4;
                 textBox4.ForeColor = System.Drawing.Color.Gray;
             }*/
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtprice.Text == watermarkText2 && txtprice.ForeColor == System.Drawing.Color.Gray)
            {
                txtprice.Text = "";
                txtprice.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (txtminstock.Text == watermarkText3 && txtminstock.ForeColor == System.Drawing.Color.Gray)
            {
                txtminstock.Text = "";
                txtminstock.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (txtlocation.Text == watermarkText4 && txtlocation.ForeColor == System.Drawing.Color.Gray)
            {
                txtlocation.Text = "";
                txtlocation.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtprice.Text))
            {
                txtprice.Text = watermarkText2;
                txtprice.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtminstock.Text))
            {
                txtminstock.Text = watermarkText3;
                txtminstock.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtlocation.Text))
            {
                txtlocation.Text = watermarkText4;
                txtlocation.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}

