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
    public partial class showitemsofsales : Form
    {
        public showitemsofsales()
        {
            InitializeComponent();
        }

        private void showitemsofsales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'purchase._Purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.purchase._Purchase);
            // TODO: This line of code loads data into the 'purchase._Purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.purchase._Purchase);
            // TODO: This line of code loads data into the 'itemsdata.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.itemsdata.Items);
            gotosalesproductdetails(new salesproductdetails());

        }

        private Form activeForm = null;


        private void button1_Click(object sender, EventArgs e)
        {
            gotosalesproductdetails(new salesproductdetails());
        }

        private void gotosalesproductdetails(salesproductdetails ChildForm)
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

        private void button3_Click(object sender, EventArgs e)
        {
            gotocategorydetils(new categoriesdetailes());
        }

        private void gotocategorydetils(categoriesdetailes ChildForm)
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
            gotounits(new unitsdetails());
        }

        private void gotounits(unitsdetails ChildForm)
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
