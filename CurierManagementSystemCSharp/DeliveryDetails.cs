using System;
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
    public partial class DeliveryDetails : Form
    {
        public DeliveryDetails()
        {
            InitializeComponent();
        }

        public int Id;

        private void DeliveryDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // TODO: This line of code loads data into the 'courierDataSet1.delivery' table. You can move, or remove it, as needed.
            this.deliveryTableAdapter.Fill(this.courierDataSet1.delivery);
            loaddatagridview();
        }

        private void loaddatagridview()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True");
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from delivery", con);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isempty())
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True");
                con.Open();

                try
                {
                    string str = "INSERT INTO delivery(Date,Sender_Name,Sender_Address,Sender_Phone_Number,Email,Sender_Receipt,Customer_Name,Customer_Address,Customer_Phone_Number,Customer_Mail,Customer_Receipt_Number,Status,Courier_Type,Rate,Delivery_Man,Delivery_Phone_Number) VALUES('" + textBox2.Value + "','" + textBox11.Text + "','" + textBox10.Text + "','" + textBox12.Text + "','" + textBox9.Text + "','" + textBox13.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox15.Text + "','" + textBox14.Text + "','" + comboBox2.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox16.Text + "'); ";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();

                    //-------------------------------------------//

                    string str1 = "select max(Id) from delivery;";

                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Delivery Information Saved Successfully..");
                        textBox2.Text = "";
                        textBox11.Text = "";
                        textBox10.Text = "";
                        textBox12.Text = "";
                        textBox9.Text = "";
                        textBox13.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox15.Text = "";
                        textBox14.Text = "";
                        comboBox2.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox16.Text = "";


                        using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
                        {

                            string str2 = "SELECT * FROM delivery";
                            SqlCommand cmd2 = new SqlCommand(str2, con1);
                            SqlDataAdapter da = new SqlDataAdapter(cmd2);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dataGridView1.DataSource = new BindingSource(dt, null);
                        }
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
                clearit();
            }
        }

        private bool isempty()
        {
           if(textBox11.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Sender Name", "Sender Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           if(textBox10.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Sender Address", "Sender Address", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           if(textBox12.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Sender Number", "Sender Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           if(textBox3.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Customer Name", "Customer Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           if(textBox4.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Customer Address", "Customer Address", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           if(textBox5.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Customer Number", "Customer Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void clearit()
        {
            Id = 0;
           
            textBox11.Text = "";
            textBox10.Text = "";
            textBox12.Text = "";
            textBox9.Text = "";
            textBox13.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
            comboBox2.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox16.Text = "";
        }

       
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True");

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //conn.Open();
           /* try
            {
                string str = "UPDATE delivery set Date='" + textBox2.Text + "',Sender_Name='" + textBox11.Text + "',Sender_Address = '" + textBox10.Text + "',Sender_Phone_Number='" + textBox12.Text + "',Email='" + textBox9.Text + "',Sender_Receipt='" + textBox13.Text + "',Customer_Name='" + textBox3.Text + "',Customer_Address='" + textBox4.Text + "',Customer_Phone_Number='" + textBox5.Text + "',Customer_Mail='" + textBox15.Text + "',Customer_Receipt_Number='" + textBox14.Text + "',Status='" + comboBox2.Text + "',Courier_Type= '" + textBox6.Text + "',Rate='" + textBox7.Text + "',Delivery_Man='" + textBox8.Text + "',Delivery_Phone_Number='" + textBox16.Text + "' WHERE Id = @Id  ";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                string str1 = "select max(Id) from delivery;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("" + textBox2.Text + "'s Details is Updated Successfully.. ", "Important Message");
                    textBox2.Text = "";
                    textBox11.Text = "";
                    textBox10.Text = "";
                    textBox12.Text = "";
                    textBox9.Text = "";
                    textBox13.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox15.Text = "";
                    textBox14.Text = "";
                    comboBox2.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox16.Text = "";
                    cmd.Parameters.AddWithValue("@Id", this.Id);               
                }
                using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
                {
                    string str2 = "SELECT * FROM delivery";
                    SqlCommand cmd2 = new SqlCommand(str2, con1);
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = new BindingSource(dt, null);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
           */
           if(Id>0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE delivery SET Date = @Date, Sender_Name = @SenderName, Sender_Address = @SenderAddress, Sender_Phone_Number = @SenderPhoneNumber, Email = @Email, Sender_Receipt = @SenderReceipt, Customer_Name = @CustomerName, Customer_Address = @CustomerAddress, Customer_Phone_Number = @CustomerPhoneNumber, Customer_Mail = @CustomerMail, Customer_Receipt_Number = @CustomerReceiptNumber, Status = @Status, Courier_Type = @CourierType, Rate = @Rate, Delivery_Man = @DeliveryMan, Delivery_Phone_Number = @DeliveryPhoneNumber WHERE Id = @Id", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Date", textBox2.Value);
                cmd.Parameters.AddWithValue("@SenderName", textBox11.Text);
                cmd.Parameters.AddWithValue("@SenderAddress", textBox10.Text);
                cmd.Parameters.AddWithValue("@SenderPhoneNumber", textBox12.Text);
                cmd.Parameters.AddWithValue("@Email", textBox9.Text);
                cmd.Parameters.AddWithValue("@SenderReceipt", textBox13.Text);
                cmd.Parameters.AddWithValue("@CustomerName", textBox3.Text);
                cmd.Parameters.AddWithValue("@CustomerAddress", textBox4.Text);
                cmd.Parameters.AddWithValue("@CustomerPhoneNumber", textBox5.Text);
                cmd.Parameters.AddWithValue("@CustomerMail", textBox15.Text);
                cmd.Parameters.AddWithValue("@CustomerReceiptNumber", textBox14.Text);
                cmd.Parameters.AddWithValue("@Status", comboBox2.Text);
                cmd.Parameters.AddWithValue("@CourierType", textBox6.Text);
                cmd.Parameters.AddWithValue("@Rate", textBox7.Text);
                cmd.Parameters.AddWithValue("@DeliveryMan", textBox8.Text);
                cmd.Parameters.AddWithValue("@DeliveryPhoneNumber", textBox16.Text);
                cmd.Parameters.AddWithValue("@Id", this.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Delivery Details are Successfully Updates","Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddatagridview();
            }
            clearit();
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {

            loaddatagridview();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if(Id>0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM delivery WHERE Id = @Id", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", this.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Delivery Details are Successfully Deleted", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddatagridview();
            }
            else
            {
                MessageBox.Show("Please Select An Student to Delete", "SELECT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                DataGridViewRow selectedrow = dataGridView1.SelectedRows[0];

                if (selectedrow.Cells[0].Value != null && selectedrow.Cells[0].Value != DBNull.Value)
                {
                    Id = Convert.ToInt32(selectedrow.Cells[0].Value);
                }
                if (selectedrow.Cells[1].Value != null && selectedrow.Cells[1].Value != DBNull.Value)
                {
                    textBox2.Text = selectedrow.Cells[1].Value.ToString();
                }
                if (selectedrow.Cells[2].Value != null && selectedrow.Cells[2].Value != DBNull.Value)
                {
                    textBox11.Text = selectedrow.Cells[2].Value.ToString();
                }
                if (selectedrow.Cells[3].Value != null && selectedrow.Cells[3].Value != DBNull.Value)
                {
                    textBox10.Text = selectedrow.Cells[3].Value.ToString();
                }
                if (selectedrow.Cells[4].Value != null && selectedrow.Cells[4].Value != DBNull.Value)
                {
                    textBox12.Text = selectedrow.Cells[4].Value.ToString();
                }
                if (selectedrow.Cells[5].Value != null && selectedrow.Cells[5].Value != DBNull.Value)
                {
                    textBox9.Text = selectedrow.Cells[5].Value.ToString();
                }
                if (selectedrow.Cells[6].Value != null && selectedrow.Cells[6].Value != DBNull.Value)
                {
                    textBox13.Text = selectedrow.Cells[6].Value.ToString();
                }
                if (selectedrow.Cells[7].Value != null && selectedrow.Cells[7].Value != DBNull.Value)
                {
                    textBox3.Text = selectedrow.Cells[7].Value.ToString();
                }
                if (selectedrow.Cells[8].Value != null && selectedrow.Cells[8].Value != DBNull.Value)
                {
                    textBox4.Text = selectedrow.Cells[8].Value.ToString();
                }
                if (selectedrow.Cells[9].Value != null && selectedrow.Cells[9].Value != DBNull.Value)
                {
                    textBox5.Text = selectedrow.Cells[9].Value.ToString();
                }
                if (selectedrow.Cells[10].Value != null && selectedrow.Cells[10].Value != DBNull.Value)
                {
                    textBox15.Text = selectedrow.Cells[10].Value.ToString();
                }
                if (selectedrow.Cells[11].Value != null && selectedrow.Cells[11].Value != DBNull.Value)
                {
                    textBox14.Text = selectedrow.Cells[11].Value.ToString();
                }
                if (selectedrow.Cells[12].Value != null && selectedrow.Cells[12].Value != DBNull.Value)
                {
                    comboBox2.Text = selectedrow.Cells[12].Value.ToString();
                }
                if (selectedrow.Cells[13].Value != null && selectedrow.Cells[13].Value != DBNull.Value)
                {
                    textBox6.Text = selectedrow.Cells[13].Value.ToString();
                }
                if (selectedrow.Cells[14].Value != null && selectedrow.Cells[14].Value != DBNull.Value)
                {
                    textBox7.Text = selectedrow.Cells[14].Value.ToString();
                }
                if (selectedrow.Cells[15].Value != null && selectedrow.Cells[15].Value != DBNull.Value)
                {
                    textBox8.Text = selectedrow.Cells[15].Value.ToString();
                }
                if (selectedrow.Cells[16].Value != null && selectedrow.Cells[16].Value != DBNull.Value)
                {
                    textBox16.Text = selectedrow.Cells[16].Value.ToString();
                }
            }


         
           
        }
    }
}
