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
    public partial class Showitemssale : Form
    {
        public Showitemssale()
        {
            InitializeComponent();
        }

        private void Showitemssale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itemsdata.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.itemsdata.Items);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
