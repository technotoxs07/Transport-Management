using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurierManagementSystemCSharp
{
    public partial class Expensesdetails : Form
    {
        public Expensesdetails()
        {
            InitializeComponent();
        }
        private Form activeForm = null;

        private void btnproducts_Click(object sender, EventArgs e)
        {
            gotoexpensescategory(new expensescategory());
        }

        private void gotoexpensescategory(expensescategory ChildForm)
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

        private void btncategories_Click(object sender, EventArgs e)
        {
            gotoexpensesitem(new Itemsexpenses());
        }

        private void gotoexpensesitem(Itemsexpenses ChildForm)
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

        private void Expensesdetails_Load(object sender, EventArgs e)
        {
            gotoexpensescategory(new expensescategory());
        }
    }
}
