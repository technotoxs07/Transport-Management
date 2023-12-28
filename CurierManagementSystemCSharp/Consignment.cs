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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace CurierManagementSystemCSharp
{
    public partial class Consignment : Form
    {

        //private Rectangle formOriginalSize;
        //private Rectangle CNNumber;
        //private Rectangle PinCode;
        //private Rectangle ConsignmentType;
        //private Rectangle weight;
        //private Rectangle shipment;
        //private Rectangle quantity;
       //private Rectangle unit;
        //private Rectangle PriceUnit;
        //private Rectangle tax;
        //private Rectangle AmountCharged;
        public Consignment()
        {
            InitializeComponent();
        }

        public int consignId;

        SqlConnection con;
        public void LoadDataIntoDataGridView(SqlDataReader reader)
        {
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Consignment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courierDataSet.consign' table. You can move, or remove it, as needed.
            this.consignTableAdapter.Fill(this.courierDataSet.consign);
            Showdataofcustomerpayement();
            // TODO: This line of code loads data into the 'courierDataSet.consign' table. You can move, or remove it, as needed.
            this.consignTableAdapter.Fill(this.courierDataSet.consign);
            // TODO: This line of code loads data into the 'courierDataSet.consign' table. You can move, or remove it, as needed.
            this.consignTableAdapter.Fill(this.courierDataSet.consign);
            // TODO: This line of code loads data into the 'courierDataSet.consign' table. You can move, or remove it, as needed.
            this.consignTableAdapter.Fill(this.courierDataSet.consign);
            /*formOriginalSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
             CNNumber = new Rectangle(cnnumbertxt.Location.X, cnnumbertxt.Location.Y, cnnumbertxt.Width, cnnumbertxt.Height);
             PinCode = new Rectangle(destinationpincodetxt.Location.X, destinationpincodetxt.Location.Y, destinationpincodetxt.Width, destinationpincodetxt.Height);
             ConsignmentType = new Rectangle(consignmenttypetxt.Location.X, consignmenttypetxt.Location.Y, consignmenttypetxt.Width, consignmenttypetxt.Height);
             weight = new Rectangle(weighttxt.Location.X, weighttxt.Location.Y, weighttxt.Width, weighttxt.Height);
             shipment = new Rectangle(shipmenttxt.Location.X, shipmenttxt.Location.Y, shipmenttxt.Width, shipmenttxt.Height);
             quantity = new Rectangle(qtytxt.Location.X, qtytxt.Location.Y, qtytxt.Width, qtytxt.Height);
             unit = new Rectangle(unittxt.Location.X, unittxt.Location.Y, unittxt.Width, unittxt.Height);
             PriceUnit = new Rectangle(pricetxt.Location.X, pricetxt.Location.Y, pricetxt.Width, pricetxt.Height);
             tax = new Rectangle(servicetaxtxt.Location.X, servicetaxtxt.Location.Y, servicetaxtxt.Width, servicetaxtxt.Height);
             AmountCharged = new Rectangle(amountchargedtxt.Location.X, amountchargedtxt.Location.Y, amountchargedtxt.Width, amountchargedtxt.Height); */

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // TODO: This line of code loads data into the 'courierDataSet.consign' table. You can move, or remove it, as needed.
            this.consignTableAdapter.Fill(this.courierDataSet.consign);
            // TODO: This line of code loads data into the 'courierDataSet.consign' table. You can move, or remove it, as needed.
            this.consignTableAdapter.Fill(this.courierDataSet.consign);
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
            con.Open();
            
            string str1 = "select max(consignId) from consign;";

            SqlCommand cmd1 = new SqlCommand(str1, con);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    textBox1.Text = "1";
                }
                else
                {
                    int a;
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    textBox1.Text = a.ToString();
                }
            }
            con.Close();
           
        }
           

        

        private void Button1_Click(object sender, EventArgs e)
        {
            if(isvalid())
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
                con.Open();

                try
                {
                    string str = "INSERT INTO consign(Date,Customer_Name,Customer_Phone_Number, Customer_Address,Consignee_Name,Consignee_address,Consignee_number,Item_Name,CN_Number,Pin_Code,Consignment_Type,Weight,Shipment,Quantity,Unit,Price_Unit,Tax,Amount_Charged) VALUES('" + datetxt.Text + "','" + customernametxt.Text + "','" + txtphonenumber.Text + "','" + customeraddrtxt.Text + "','" + consigneename.Text + "','" + consigneeaddress.Text + "','" + consigneenumber.Text + "','" + itemnametxt.Text + "','" + cnnumbertxt.Text + "','" + destinationpincodetxt.Text + "','" + consignmenttypetxt.Text + "','" + weighttxt.Text + "','" + shipmenttxt.Text + "', '" + qtytxt.Text + "', '" + unittxt.Text + "', '" + pricetxt.Text + "', '" + servicetaxtxt.Text + "', '" + amountchargedtxt.Text + "'); ";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();

                    //-------------------------------------------//

                    string str1 = "select max(consignId) from consign;";

                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Consignment Information Saved Successfully..");
                        datetxt.Text = "";
                        customernametxt.Text = "";
                        txtphonenumber.Text = "";
                        customeraddrtxt.Text = "";
                        consigneename.Text = "";
                        consigneeaddress.Text = "";
                        consigneenumber.Text = "";
                        itemnametxt.Text = "";
                        cnnumbertxt.Text = "";
                        destinationpincodetxt.Text = "";
                        consignmenttypetxt.Text = "";
                        weighttxt.Text = "";
                        shipmenttxt.Text = "";
                        qtytxt.Text = "";
                        unittxt.Text = "";
                        pricetxt.Text = "";
                        servicetaxtxt.Text = "";
                        amountchargedtxt.Text = "";

                        using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
                        {

                            string str2 = "SELECT * FROM consign";
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
                cleartextbox();
            }
           
           
        }

        private bool isvalid()
        {
          if(customernametxt.Text == string.Empty)
          {
                MessageBox.Show("Please Enter Consignor Details");
                return false;
          }
            if (customeraddrtxt.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Consignor Details");
                return false;
            }
            if (txtphonenumber.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Consignor Details");
                return false;
            }
            if (consigneename.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Consignor Details");
                return false;
            }
            if (consigneeaddress.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Consignor Details");
                return false;
            }
            if (consigneenumber.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Consignor Details");
                return false;
            }
            return true;
        }

        private void cleartextbox()
        {
            consignId = 0;
            datetxt.Text = "";
            customernametxt.Text = "";
            txtphonenumber.Text = "";
            customeraddrtxt.Text = "";
            consigneename.Text = "";
            consigneeaddress.Text = "";
            consigneenumber.Text = "";
            itemnametxt.Text = "";
            cnnumbertxt.Text = "";
            destinationpincodetxt.Text = "";
            consignmenttypetxt.Text = "";
            weighttxt.Text = "";
            shipmenttxt.Text = "";
            qtytxt.Text = "";
            unittxt.Text = "";
            pricetxt.Text = "";
            servicetaxtxt.Text = "";
            amountchargedtxt.Text = "";
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

       
        private void pricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Consignment_Resize(object sender, EventArgs e)
        {
           /* resizeControl(cnnumbertxt, CNNumber);
            resizeControl(destinationpincodetxt, PinCode);
            resizeControl(consignmenttypetxt, ConsignmentType);
            resizeControl(weighttxt, weight);

            resizeControl(shipmenttxt, shipment);
            resizeControl(qtytxt, quantity);
            resizeControl(unittxt, unit);
            resizeControl(pricetxt, PriceUnit);
            resizeControl(servicetaxtxt,tax);
            resizeControl(amountchargedtxt,AmountCharged);
           */
        }

        //private void resizeControl(Control c, Rectangle r)
       // {
            //float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            //float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);

           // int newX = (int)(r.Width * xRatio);
           // int newY = (int)(r.Height * yRatio);

            // int newWidth = (int)(r.Width * xRatio);
           // int newHeight = (int)(r.Height * yRatio);

            // c.Location = new Point(newX, newY);
            // c.Size = new Size(newWidth, newHeight);
       // }

        private void qtytxt_TextChanged(object sender, EventArgs e)
        {
            //int a = Convert.ToInt32(qtytxt.Text);

            
        }

        private void pricetxt_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int a = Convert.ToInt32(qtytxt.Text);

                int b = Convert.ToInt32(pricetxt.Text);
               // int c = Convert.ToInt32(servicetaxtxt.Text);
                double totalprice = a * b;

                double totalvatwithamount = totalprice * 1.13;

                //double vatandamount = totalvatwithamount + c;
                amountchargedtxt.Text = totalvatwithamount.ToString();
            }
            catch (Exception)
            {
                amountchargedtxt.Text = ""; // Handle invalid input with a meaningful message.

            }
        }

        private void servicetaxtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(qtytxt.Text);

                int b = Convert.ToInt32(pricetxt.Text);
                int c = Convert.ToInt32(servicetaxtxt.Text);
                double totalprice = a * b;

                double totalvatwithamount = totalprice * 1.13;

                double vatandamount = totalvatwithamount + c;
                amountchargedtxt.Text = vatandamount.ToString();
            }
            catch (Exception)
            {
                amountchargedtxt.Text = "Invalid input"; // Handle invalid input with a meaningful message.

            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            Showdataofcustomerpayement();
        }

        private void Showdataofcustomerpayement()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM consign", con);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
            if (consignId > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE consign SET Date = @Date, Customer_Name = @Customer_Name, Customer_Phone_Number = @Customer_Phone_Number, Customer_Address = @Customer_Address,Consignee_Name = @Consignee_Name,Consignee_address = @Consignee_address,Consignee_number = @Consignee_number ,Item_Name = @Item_Name, CN_Number = @CN_Number, Pin_Code = @Pin_Code, Consignment_Type = @Consignment_Type, Weight = @Weight, Shipment = @Shipment, Quantity = @Quantity, Unit = @Unit, Price_Unit = @Price_Unit, Tax = @Tax, Amount_Charged = @Amount_Charged WHERE consignId = @consignId", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Date", datetxt.Text);
                cmd.Parameters.AddWithValue("@Customer_Name", customernametxt.Text);
                cmd.Parameters.AddWithValue("@Customer_Phone_Number", txtphonenumber.Text);
                cmd.Parameters.AddWithValue("@Customer_Address", customeraddrtxt.Text);
                cmd.Parameters.AddWithValue("@Consignee_Name", consigneename.Text);
                cmd.Parameters.AddWithValue("@Consignee_address", consigneeaddress.Text);
                cmd.Parameters.AddWithValue("@Consignee_number", consigneenumber.Text);
                cmd.Parameters.AddWithValue("@Item_Name", itemnametxt.Text);
                cmd.Parameters.AddWithValue("@CN_Number", cnnumbertxt.Text);
                cmd.Parameters.AddWithValue("@Pin_Code", destinationpincodetxt.Text);
                cmd.Parameters.AddWithValue("@Consignment_Type", consignmenttypetxt.Text);
                cmd.Parameters.AddWithValue("@Weight", weighttxt.Text);
                cmd.Parameters.AddWithValue("@Shipment", shipmenttxt.Text);
                cmd.Parameters.AddWithValue("@Quantity", qtytxt.Text);
                cmd.Parameters.AddWithValue("@Unit", unittxt.Text);
                cmd.Parameters.AddWithValue("@Price_Unit", pricetxt.Text);
                cmd.Parameters.AddWithValue("@Tax", servicetaxtxt.Text);
                cmd.Parameters.AddWithValue("@Amount_Charged", amountchargedtxt.Text);
                cmd.Parameters.AddWithValue("@consignId", this.consignId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Customers are Successfully Updates", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Showdataofcustomerpayement();
            }
            else
            {
                MessageBox.Show("Please Select Customers to Update Successfully Updates", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                DataGridViewRow seletedrow = dataGridView1.SelectedRows[0];

                if (seletedrow.Cells[0].Value != null && seletedrow.Cells[0].Value != DBNull.Value)
                {
                    consignId = Convert.ToInt32(seletedrow.Cells[0].Value);
                }

                if (seletedrow.Cells[1].Value != null && seletedrow.Cells[1].Value != DBNull.Value)
                {
                    datetxt.Text = seletedrow.Cells[1].Value.ToString();
                }
                if (seletedrow.Cells[2].Value != null && seletedrow.Cells[2].Value != DBNull.Value)
                {
                    customernametxt.Text = seletedrow.Cells[2].Value.ToString();
                }
                if (seletedrow.Cells[3].Value != null && seletedrow.Cells[3].Value != DBNull.Value)
                {
                    txtphonenumber.Text = seletedrow.Cells[3].Value.ToString();
                }
                if (seletedrow.Cells[4].Value != null && seletedrow.Cells[4].Value != DBNull.Value)
                {
                    customeraddrtxt.Text = seletedrow.Cells[4].Value.ToString();
                }
                if (seletedrow.Cells[5].Value != null && seletedrow.Cells[5].Value != DBNull.Value)
                {
                    consigneename.Text = seletedrow.Cells[5].Value.ToString();
                }
                if (seletedrow.Cells[6].Value != null && seletedrow.Cells[6].Value != DBNull.Value)
                {
                    consigneeaddress.Text = seletedrow.Cells[6].Value.ToString();
                }
                if (seletedrow.Cells[7].Value != null && seletedrow.Cells[7].Value != DBNull.Value)
                {
                    consigneenumber.Text = seletedrow.Cells[7].Value.ToString();
                }
                if (seletedrow.Cells[8].Value != null && seletedrow.Cells[8].Value != DBNull.Value)
                {
                    itemnametxt.Text = seletedrow.Cells[8].Value.ToString();
                }
                if (seletedrow.Cells[9].Value != null && seletedrow.Cells[9].Value != DBNull.Value)
                {
                    cnnumbertxt.Text = seletedrow.Cells[9].Value.ToString();
                }
                if (seletedrow.Cells[10].Value != null && seletedrow.Cells[10].Value != DBNull.Value)
                {
                    destinationpincodetxt.Text = seletedrow.Cells[10].Value.ToString();
                }
                if (seletedrow.Cells[11].Value != null && seletedrow.Cells[11].Value != DBNull.Value)
                {
                    consignmenttypetxt.Text = seletedrow.Cells[11].Value.ToString();
                }
                if (seletedrow.Cells[12].Value != null && seletedrow.Cells[12].Value != DBNull.Value)
                {
                    weighttxt.Text = seletedrow.Cells[12].Value.ToString();
                }
                if (seletedrow.Cells[13].Value != null && seletedrow.Cells[13].Value != DBNull.Value)
                {
                    shipmenttxt.Text = seletedrow.Cells[13].Value.ToString();
                }
                if (seletedrow.Cells[14].Value != null && seletedrow.Cells[14].Value != DBNull.Value)
                {
                    qtytxt.Text = seletedrow.Cells[14].Value.ToString();
                }
                if (seletedrow.Cells[15].Value != null && seletedrow.Cells[15].Value != DBNull.Value)
                {
                    unittxt.Text = seletedrow.Cells[15].Value.ToString();
                }
                if (seletedrow.Cells[16].Value != null && seletedrow.Cells[16].Value != DBNull.Value)
                {
                    pricetxt.Text = seletedrow.Cells[16].Value.ToString();
                }
                if (seletedrow.Cells[17].Value != null && seletedrow.Cells[17].Value != DBNull.Value)
                {
                    servicetaxtxt.Text = seletedrow.Cells[17].Value.ToString();
                }
                if (seletedrow.Cells[18].Value != null && seletedrow.Cells[18].Value != DBNull.Value)
                {
                    amountchargedtxt.Text = seletedrow.Cells[18].Value.ToString();
                }

            }


            

        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            if(consignId>0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM consign WHERE consignId = @consignId", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@consignId", this.consignId);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delivery Details are Successfully Deleted", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleartextbox();
            }
            else
            {
                MessageBox.Show("Please Select An Data to Delete", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void itemnametxt_TextChanged(object sender, EventArgs e)
        {
            itemnametxt.ForeColor = Color.Black;
        }

        private void itemnametxt_Click(object sender, EventArgs e)
        {
            itemnametxt.Text = "";
            itemnametxt.ForeColor = Color.Black;
        }

        private void weighttxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
