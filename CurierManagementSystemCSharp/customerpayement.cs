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
    public partial class customerpayement : Form
    {
        public customerpayement()
        {
            InitializeComponent();
        }

        public int Id;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                panel1.Visible = true;
            }
            else if(radioButton2.Checked == false)
            {
                panel1.Visible = false;
            }
        }

        private void customerpayement_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // TODO: This line of code loads data into the 'customer_payement.Customer_payment' table. You can move, or remove it, as needed.
            this.customer_paymentTableAdapter.Fill(this.customer_payement.Customer_payment);
            //gettotalamount();
            BindData();
        }

       
        private void BindData()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select Customer_Name from consign", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                customernametxt.Items.Add(sdr[0].ToString());
                //customernumbertxt.Items.Add(sdr[0].ToString());
               // string customerpayment = sdr["Amount_Charged"].ToString();
                //amountchargedtxt.Text = customerpayment;
            }
            con.Close();
        }

        private void customernametxt_SelectedIndexChanged(object sender, EventArgs e)
        {
           // takedatafromconsign();

            getnumberandamount();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from consign where Customer_Name like '" + customernametxt.Text + "%' AND Customer_Phone_Number like '" + customernumbertxt.Text+ "%' AND Amount_Charged like '" + amountchargedtxt.Text+"%' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dataGridView1;
            con.Close();

        }

       

        private void getnumberandamount()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True");
            if(customernametxt.SelectedIndex != -1)
            {
                string selecteditem = customernametxt.SelectedItem.ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Customer_Phone_Number, Amount_Charged FROM consign where Customer_Name = @Customer_Name", con);
                cmd.Parameters.AddWithValue("@Customer_Name", selecteditem);
                SqlDataReader sdr = cmd.ExecuteReader(); 
                if (sdr.Read())
                {
                    string amountcharged = sdr["Amount_Charged"].ToString();
                    amountchargedtxt.Text = amountcharged;
                    string phonenumber = sdr["Customer_Phone_Number"].ToString();
                    customernumbertxt.Text = phonenumber;
                }
                sdr.Close();
                con.Close();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True");
            con.Open();
            try
            {
                string str = "INSERT INTO Customer_payment(Date, Customer_Name, Custome_Number, Amount_Charged, Amount_Paid, Account_Holder_Name, Account_Number, Bank_Name, branch)VALUES('" + dateTimePicker1.Text + "', '" + customernametxt.Text + "', '" + customernumbertxt.Text + "', '" + amountchargedtxt.Text + "', '" + amountpaindtxt.Text + "', '" + accholdernametxt.Text + "', '" + accnumbertxt.Text + "', '" + banknametxt.Text + "', '" + branchnametxt.Text + "');";
                SqlCommand cmd = new SqlCommand(str,con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(Id) from Customer_payment;";
                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if(dr.Read())
                {
                    MessageBox.Show("Customer Payement Are saved Successfully");
                    dateTimePicker1.Text = "";
                    customernametxt.Text = "";
                    customernumbertxt.Text = "";
                    amountchargedtxt.Text = "";
                    amountpaindtxt.Text = "";
                    accholdernametxt.Text = "";
                    accnumbertxt.Text = "";
                    banknametxt.Text = "";
                    branchnametxt.Text = "";
                }
                using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
                {

                    string str2 = "SELECT * FROM Customer_payment";
                    SqlCommand cmd2 = new SqlCommand(str2, con1);
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void accholdernametxt_Click(object sender, EventArgs e)
        {
            accholdernametxt.Text = "";
        }

        private void accnumbertxt_Click(object sender, EventArgs e)
        {
            accnumbertxt.Text = "";
        }

        private void banknametxt_Click(object sender, EventArgs e)
        {
            banknametxt.Text = "";
        }

        private void branchnametxt_Click(object sender, EventArgs e)
        {
            branchnametxt.Text = "";
        }

        private void banknametxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            customernametxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            customernumbertxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            amountchargedtxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            amountpaindtxt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            accholdernametxt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            accnumbertxt.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            banknametxt.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            branchnametxt.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True");
            if(Id>0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Customer_payment SET Date = @Date, Customer_Name = @Customer_Name, Custome_Number = @Custome_Number, Amount_Charged = @Amount_Charged, Amount_Paid = @Amount_Paid, Account_Holder_Name = @Account_Holder_Name, Account_Number = @Account_Number, Bank_Name = @Bank_Name, branch = @branch WHERE Id = @Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@Customer_Name", customernametxt.Text);
                cmd.Parameters.AddWithValue("@Custome_Number", customernumbertxt.Text);
                cmd.Parameters.AddWithValue("@Amount_Charged", amountchargedtxt.Text);
                cmd.Parameters.AddWithValue("@Amount_Paid", amountpaindtxt.Text);
                cmd.Parameters.AddWithValue("@Account_Holder_Name", accholdernametxt.Text);
                cmd.Parameters.AddWithValue("@Account_Number", accnumbertxt.Text);
                cmd.Parameters.AddWithValue("@Bank_Name", banknametxt.Text);
                cmd.Parameters.AddWithValue("@branch", branchnametxt.Text);
                cmd.Parameters.AddWithValue("@Id", this.Id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Payements Are Successfully Updated", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getcusttomerpayment();
            }
            else
            {
                MessageBox.Show("Please Select Payements to Update Successfully", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void getcusttomerpayment()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True");
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customer_payment", con);
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
    }
}
