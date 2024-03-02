using System;
using System.Collections;
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
    public partial class Unitconversion : UserControl
    {
        public List<string> GetListBoxItems()
        {
            List<string> items = new List<string>();

            foreach (object item in listBox2.Items)
            {
                items.Add(item.ToString());
            }

            return items;
        }

        public void ClearListBoxItems()
        {
            listBox2.Items.Clear();
        }

        public string ItemData { get;  set; }

        public Unitconversion()
        {
            InitializeComponent();
            LoadListBoxItems();
        }

        private void LoadListBoxItems()
        {
            if (Properties.Settings.Default.listboxtxt != null)
            {
                listBox1.Items.AddRange(Properties.Settings.Default.listboxtxt.Cast<string>().ToArray());
            }
            if(Properties.Settings.Default.listbox2 != null)
            {
                listBox2.Items.AddRange(Properties.Settings.Default.listbox2.Cast<string>().ToArray());
            }
        }

        public string GetSelectedItemData()
        {
            if(listBox1.SelectedItem != null)
            {
                return ((Unitconversion)listBox1.SelectedItem).ItemData;
            }
            return null;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButton1.Text = comboBox1.SelectedItem.ToString();
        }

        private void Unitconversion_Load(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            checkbutton();
            SaveListBoxItems();
            listBox2.Items.Clear();
            // checkbuttonenable();
        }

        private void SaveListBoxItems()
        {
            Properties.Settings.Default.listboxtxt = new System.Collections.Specialized.StringCollection();
            Properties.Settings.Default.listbox2 = new System.Collections.Specialized.StringCollection();
            Properties.Settings.Default.listboxtxt.AddRange(listBox1.Items.Cast<string>().ToArray());
            Properties.Settings.Default.listbox2.AddRange(listBox2.Items.Cast<string>().ToArray());
            Properties.Settings.Default.Save();
        }

       

        private void checkbutton()
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("1"+" "+radioButton1.Text +" = " + textBox1.Text +" " + label6.Text);
            listBox2.Items.Add("1" + " " + radioButton1.Text + " = " + textBox1.Text + " " + label6.Text);

            // Save the updated items to settings
            SaveListBoxItems();
            
            //  return false;
         //   Savesettings();

        }

      

        private void label2_Click(object sender, EventArgs e)
        {
           // Savesettings();
            this.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label6.Text = comboBox2.SelectedItem.ToString();
            
            if (comboBox1.SelectedItem == comboBox2.SelectedItem)
            {
                MessageBox.Show("Base Unit And Secondary Unit Cannot Be Same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Enabled = false;
            }
            else if(comboBox1.SelectedItem != comboBox2.SelectedItem)
            {
                textBox1.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                button1.Enabled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }
    }
}
