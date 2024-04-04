using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurierManagementSystemCSharp
{
    public partial class Showitemspurchase : Form
    {
        public Showitemspurchase()
        {
            InitializeComponent();
        }

        private void Showitemssale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Purchases_Real_._Purchase_real_' table. You can move, or remove it, as needed.
            gotoproductspage(new productdetails());

        }
       

      
        
     
        private void btncategories_Click(object sender, EventArgs e)
        {
            gotocategroiesdetails(new categoriesdetailes());
        }

        private void gotocategroiesdetails(categoriesdetailes ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(ChildForm);
            panel2.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnproducts_Click(object sender, EventArgs e)
        {
            gotoproductspage(new productdetails());
        }
        private Form activeForm = null;

        private void gotoproductspage(productdetails ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(ChildForm);
            panel2.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gotounitspage(new unitsdetails());
        }

        private void gotounitspage(unitsdetails ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(ChildForm);
            panel2.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }
    }
}
