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
    public partial class Internalcompanydetails : Form
    {
        public int Id;
        public Internalcompanydetails()
        {
            InitializeComponent();
        }
        
        private void Internalcompanydetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'add_business._add_business' table. You can move, or remove it, as needed.
            this.add_businessTableAdapter.Fill(this.add_business._add_business);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            getdata();
        }

        private void getdata()
        {
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True"))
            {
                string str2 = "SELECT * FROM add_business";
                SqlCommand cmd3 = new SqlCommand(str2, con1);
                SqlDataAdapter sda = new SqlDataAdapter(cmd3);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void btnaddbusiness_Click(object sender, EventArgs e)
        {
           
        }

     

        private void btnaddbusiness_Click_1(object sender, EventArgs e)
        {
            if (isempty())
            {


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True");
                con.Open();
                try
                {
                    string query = "INSERT INTO add_business(Business_Name, Business_Address, telephone, email, authorized_dealer, pan) VALUES ('" + businessnametxt.Text + "','" + businessaddrtxt.Text + "','" + teltxt.Text + "','" + emailtxt.Text + "','" + authorizedtxt.Text + "','" + pantxt.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    string query2 = "select max(Business_id) from add_business";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    SqlDataReader sdr = cmd2.ExecuteReader();
                    if (sdr.Read())
                    {
                        MessageBox.Show("Business Information Saved Successfully..");
                        businessnametxt.Text = "";
                        businessaddrtxt.Text = "";
                        teltxt.Text = "";
                        emailtxt.Text = "";
                        authorizedtxt.Text = "";
                        pantxt.Text = "";
                        btnaddbusiness.Visible = false;
                        // cmd.CommandType = CommandType.Text;

                    }

                    getdata();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
               
            }
        }

        private bool isempty()
        {
           if(businessnametxt.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Business Name", "Business Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           if(businessaddrtxt.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Business Address", "Business Address", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           if(teltxt.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Telephone or Mobile Number", "Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           if(emailtxt.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Email", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           if(authorizedtxt.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Authorized Name", "Authorized", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
           if(pantxt.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Pan Number", "PAN No.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void teltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=3758F1E19464CE898E5B8A3A0AC6E1F8_URIERMANAGEMENTSYSTEMCSHA\CURIERMANAGEMENTSYSTEMCSHARP\CURIERMANAGEMENTSYSTEMCSHARP\COURIER.MDF;Integrated Security=True");

            if (Id > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM add_business WHERE Business_id = @Business_id", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Business_id", this.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Business Details are Successfully Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnaddbusiness.Visible = true;
            }
           
            else
            {
                MessageBox.Show("Please Select An Business Details to Delete", "SELECT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            getdata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                if (selectedRow.Cells[0].Value != null)
                {
                    Id = Convert.ToInt32(selectedRow.Cells[0].Value);
                }

                businessnametxt.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                businessaddrtxt.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                teltxt.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                emailtxt.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                authorizedtxt.Text = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;
                pantxt.Text = selectedRow.Cells[6].Value?.ToString() ?? string.Empty;
            }


        }
    }
}
