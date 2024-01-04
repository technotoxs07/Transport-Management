using CurierManagementSystemCSharp.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace CurierManagementSystemCSharp
{
    public partial class Home : Form
    {
        //https://www.dropbox.com/scl/fi/fl33219u2f0pq4wfwr6hh/Transportation-Setup.zip?rlkey=n5n44nvk05xm906lg1k3kgj3a&dl=0
        
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int conn, int val);

        int mov;
        int movX;
        int movY;
        public Home()
        {
            InitializeComponent();
        }

        private void AddStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //StaffDetails obj = new CurierManagementSystemCSharp.StaffDetails();
            //obj.ShowDialog();

            
        }
        private Form activeForm = null;
        private FormWindowState previousWindowState;

        private void gotoaddstaff(StaffDetails ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void ModifyStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UpdateStaff obj1 = new CurierManagementSystemCSharp.UpdateStaff();
            //obj1.ShowDialog();
          
        }

        private void gotoupdatestaff(UpdateStaff ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void DeliveryDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotodeliverypage(new DeliveryDetails())
;            
        }

        private void gotodeliverypage(DeliveryDetails ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void ConsignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotoconsignment(new Consignment());
           
        }

        private void gotoconsignment(Consignment ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void SearchDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gotoadditem(ViewAllCouriers ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void billingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gotoaddcustomer(ADD_CUSTOMER ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void customerPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotocustomerpayment(new customerpayement());

        }

        private void gotocustomerpayment(customerpayement ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void updateStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotoaddstaff(new StaffDetails());
            
        }

        private void addBusinessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotoaddcustomer(new ADD_CUSTOMER());
        }

        private void gotoaddbusiness(Internalcompanydetails ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purchaseAndSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           gotoslaes(new Purchase1());
        }

      private void gotoslaes(Purchase1 ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void customerPaymeentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotocustomerpayments(new customerpayment());
        }

        private void gotocustomerpayments(customerpayment ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }

        private void consignmentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotoslaes(new Sale());
        }

        private void gotoslaes(Sale ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        /* private void gotoconsignmentreport(Purchases ChildForm)
         {
             if (activeForm != null)
                 activeForm.Close();
             activeForm = ChildForm;
             ChildForm.TopLevel = false;
             ChildForm.FormBorderStyle = FormBorderStyle.None;
             ChildForm.Dock = DockStyle.Fill;
             panel1.Controls.Add(ChildForm);
             panel1.Tag = ChildForm;
             ChildForm.BringToFront();
             ChildForm.Show();
         }*/

        private void updateStaffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gotoupdatestaff(new UpdateStaff());
        }
       

        private void addBusinessToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gotoaddbusiness(new Internalcompanydetails());

        }

        private void Home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Restore to the previous window state
                this.WindowState = previousWindowState;
            }
            else
            {
                // Maximize the window
                previousWindowState = this.WindowState; // Store the current window state
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void maxmbtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Restore to the previous window state
                this.WindowState = previousWindowState;
            }
            else
            {
                // Maximize the window
                previousWindowState = this.WindowState; // Store the current window state
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void crossbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotohomeway(new Homeway());
        }

        private void gotohomeway(Homeway ChildForm)
        {

            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            gotohomeway(new Homeway());
            
          
        }
     
        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotopurchase(new Purchasesss());
        }

        private void gotopurchase(Purchasesss ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotoadditem(new ViewAllCouriers());
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consignmentReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gotoconsign(new consignreport());
        }

        private void gotoconsign(consignreport ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gotcustomer(new custmerdetails());
        }

        private void gotcustomer(custmerdetails ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(ChildForm);
            panel1.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void staffReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

       

    }
}
