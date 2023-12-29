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
using System.Windows.Markup;
using System.Windows.Media;

namespace CurierManagementSystemCSharp
{
    public partial class StaffDetails : Form
    {
        public StaffDetails()
        {
            InitializeComponent();
           
        }
        public void LoadDataIntoDataGridView(SqlDataReader reader)
        {
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;
        }

        private async void StaffDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courierDataSet4.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.courierDataSet4.staff);
            //  string username = GetSecureUsername(); // Implement this method
            //   string password = GetSecurePassword(); // Implement this method
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            loadingdataingridview();
            // TODO: This line of code loads data into the 'courierDataSet4.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.courierDataSet4.staff);
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
            con.Open();
            string str1 = "select max(id) from staff;";

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
       


        private void loadingdataingridview()
        {
            textBox2.Focus();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM staff", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;");


            if (isvalid())
            {
                con.Open();
                try
                {
                    string str = "INSERT INTO staff(Name,Gender,Mobile_Number,Blood_Group,Date_of_Birth,Qualifications,Designation,Address) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "'); ";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();

                    //-------------------------------------------//

                    string str1 = "select max(Id) from staff;";

                    SqlCommand cmd1 = new SqlCommand(str1, con);
                    SqlDataReader dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Staff Information Saved Successfully..");
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        textBox9.Text = "";

                        using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\courier.mdf;Integrated Security=True;"))
                        {

                            string str2 = "SELECT * FROM staff";
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
                resettingtext();
            }


        }

        private bool isvalid()
        {
           if (textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty || textBox9.Text == string.Empty)
           {
                MessageBox.Show("Please Enter Important Detail ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
           }
            return true;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resettingtext();
          
        }

        private void resettingtext()
        {
            textBox2.Text = "";
            textBox3.Items.Clear();
            textBox4.Text = "";
            textBox5.Items.Clear();
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
