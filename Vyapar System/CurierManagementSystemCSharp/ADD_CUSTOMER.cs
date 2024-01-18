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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CurierManagementSystemCSharp
{
    public partial class ADD_CUSTOMER : Form
    {
        public ADD_CUSTOMER()
        {
            InitializeComponent();
        }

        public int Id;
        public void LoadDataIntoDataGridView(SqlDataReader reader)
        {
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;
        }
        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void ADD_CUSTOMER_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addcustomer.addcustomers' table. You can move, or remove it, as needed.
            this.addcustomersTableAdapter.Fill(this.addcustomer.addcustomers);

            // TODO: This line of code loads data into the 'addcustomer.addcustomers' table. You can move, or remove it, as needed.
            this.addcustomersTableAdapter.Fill(this.addcustomer.addcustomers);
            // TODO: This line of code loads data into the 'addcustomer.addcustomers' table. You can move, or remove it, as needed.
            //this.addcustomersTableAdapter.Fill(this.addcustomer.addcustomers);
            // TODO: This line of code loads data into the 'addcustomer.addcustomers' table. You can move, or remove it, as needed.
            //this.addcustomersTableAdapter.Fill(this.addcustomer.addcustomers);
            // TODO: This line of code loads data into the 'addcustomer._addcustomer' table. You can move, or remove it, as needed.
            // this.addcustomerTableAdapter.Fill(this.addcustomer._addcustomer);
            // TODO: This line of code loads data into the 'courierDataSet1.delivery' table. You can move, or remove it, as needed.
            //this.deliveryTableAdapter.Fill(this.courierDataSet1.delivery);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoResizeColumnHeadersHeight();

            gettingcustomerdata();
            shownewcustomerdata();
            //textBox3.ForeColor = Color.DarkGray;

        }

        private void gettingcustomerdata()
        {
           
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
            con.Open();
            try
            {
               
                // SqlDataAdapter sda = new SqlDataAdapter(@"Select Customer_Name,Customer_Address,Customer_Phone_Number,Customer_Mail,Customer_Receipt_Number,Status From delivery where id=" + Convert.ToInt32(textBox6.Text)+";",con);
                string str = "Select Date,Customer_Name,Customer_Address,Customer_Phone_Number,Customer_Mail,Customer_Receipt_Number,Status From delivery";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            customernametxt.Text = "";
            customernametxt.ForeColor = Color.Black;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            customernametxt.ForeColor = Color.Black ;

        }

        private void btnaddcustomer_Click(object sender, EventArgs e)
        {
            if (isempty())
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");

                con.Open();
                try
                {
                    string query = "INSERT INTO addcustomers(Date,Customer_Name,Customer_Address,Customer_Phone_Number,Customer_Mail,Customer_Receipt_Number,Status,Balance)VALUES('" + txtdate.Text + "','" + customernametxt.Text + "','" + customeraddrtxt.Text + "','" + customernumbertxt.Text + "','" + customermailtxt.Text + "','" + customervattxt.Text + "','" + customerstatustxt.Text + "','" + customerbalancetxt.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    string query2 = "select max(Id) from addcustomers";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    SqlDataReader sdr = cmd2.ExecuteReader();
                    if (sdr.Read())
                    {
                        MessageBox.Show("Customer Information Saved Successfully..");
                        // cmd.CommandType = CommandType.Text;
                        txtdate.Text = "";
                        customernametxt.Text = "";
                        customeraddrtxt.Text = "";
                        customernumbertxt.Text = "";
                        customermailtxt.Text = "";
                        customervattxt.Text = "";
                        customerstatustxt.Text = "";
                        customerbalancetxt.Text = "";
                    }
                    using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
                    {
                        string str2 = "SELECT * FROM addcustomers";
                        SqlCommand cmd3 = new SqlCommand(str2, con1);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd3);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
                clearingcutomer();
            }
        }

        private bool isempty()
        {
           if(customernametxt.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Customer Name", "Customer Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           if(customernumbertxt.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Customer Number", "Customer Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           if(customeraddrtxt.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Customer Address", "Customer Address", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void clearingcutomer()
        {
            Id = 0;
       
            customernametxt.Clear();
            customeraddrtxt.Clear();
            customernumbertxt.Clear();
            customermailtxt.Clear();
            customervattxt.Clear();
            customerstatustxt.Items.Clear();
            customerbalancetxt.Clear();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
            if (Id>0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE addcustomers SET Date = @Date, Customer_Name = @Customer_Name, Customer_Address = @Customer_Address, Customer_Phone_Number = @Customer_Phone_Number, Customer_Mail= @Customer_Mail, Customer_Receipt_Number = @Customer_Receipt_Number, Status = @Status, Balance = @Balance WHERE Id = @Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Date", txtdate.Text);
                cmd.Parameters.AddWithValue("@Customer_Name", customernametxt.Text);
                cmd.Parameters.AddWithValue("@Customer_Address", customeraddrtxt.Text);
                cmd.Parameters.AddWithValue("@Customer_Phone_Number", customernumbertxt.Text);
                cmd.Parameters.AddWithValue("@Customer_Mail", customermailtxt.Text);
                cmd.Parameters.AddWithValue("@Customer_Receipt_Number", customervattxt.Text);
                cmd.Parameters.AddWithValue("@Status", customerstatustxt.Text);
                cmd.Parameters.AddWithValue("@Balance", customerbalancetxt.Text);
                cmd.Parameters.AddWithValue("@Id", this.Id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Customers are Successfully Updates", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                shownewcustomerdata();
                clearingcutomer();
            }
            else
            {
                MessageBox.Show("Please Select Customers to Update Successfully Updates", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void shownewcustomerdata()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM addcustomers", con);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void customernumbertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void customerbalancetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            shownewcustomerdata();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");

            if (Id>0)
            {
                SqlCommand cmd = new SqlCommand("DELETE addcustomers WHERE Id = @Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.Id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delivery Details are Successfully Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                shownewcustomerdata();
            }
            else
            {
                MessageBox.Show("Please Select Customers to Delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = dataGridView1.SelectedRows[0];

                if (selectedrow.Cells[0].Value != DBNull.Value && selectedrow.Cells[0].Value != null)
                {
                    Id = Convert.ToInt32(selectedrow.Cells[0].Value);
                }

                if (selectedrow.Cells[1].Value != DBNull.Value && selectedrow.Cells[1].Value != null)
                {
                    string dateStr = selectedrow.Cells[1].Value.ToString();

                    if (DateTime.TryParse(dateStr, out DateTime dateValue))
                    {
                        txtdate.Value = dateValue;
                    }
                }

                // Check for DBNull before converting to string
                if (selectedrow.Cells[2].Value != DBNull.Value && selectedrow.Cells[2].Value != null)
                {
                    customernametxt.Text = selectedrow.Cells[2].Value.ToString();
                }

                if (selectedrow.Cells[3].Value != DBNull.Value && selectedrow.Cells[3].Value != null)
                {
                    customeraddrtxt.Text = selectedrow.Cells[3].Value.ToString();
                }

                if (selectedrow.Cells[4].Value != DBNull.Value && selectedrow.Cells[4].Value != null)
                {
                    customernumbertxt.Text = selectedrow.Cells[4].Value.ToString();
                }

                if (selectedrow.Cells[5].Value != DBNull.Value && selectedrow.Cells[5].Value != null)
                {
                    customermailtxt.Text = selectedrow.Cells[5].Value.ToString();
                }

                if (selectedrow.Cells[6].Value != DBNull.Value && selectedrow.Cells[6].Value != null)
                {
                    customervattxt.Text = selectedrow.Cells[6].Value.ToString();
                }

                if (selectedrow.Cells[7].Value != DBNull.Value && selectedrow.Cells[7].Value != null)
                {
                    customerstatustxt.Text = selectedrow.Cells[7].Value.ToString();
                }

                if (selectedrow.Cells[8].Value != DBNull.Value && selectedrow.Cells[8].Value != null)
                {
                    customerbalancetxt.Text = selectedrow.Cells[8].Value.ToString();
                }
            }





        }
    }
}
