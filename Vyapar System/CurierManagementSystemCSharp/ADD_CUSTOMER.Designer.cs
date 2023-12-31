﻿namespace CurierManagementSystemCSharp
{
    partial class ADD_CUSTOMER
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customervattxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.customermailtxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.customernumbertxt = new System.Windows.Forms.TextBox();
            this.customeraddrtxt = new System.Windows.Forms.TextBox();
            this.customernametxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerstatustxt = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addcustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addcustomer = new CurierManagementSystemCSharp.addcustomer();
            this.btnaddcustomer = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.customerbalancetxt = new System.Windows.Forms.TextBox();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.addcustomersTableAdapter = new CurierManagementSystemCSharp.addcustomerTableAdapters.addcustomersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Phone_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Receipt_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addcustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // customervattxt
            // 
            this.customervattxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customervattxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customervattxt.Location = new System.Drawing.Point(965, 44);
            this.customervattxt.Name = "customervattxt";
            this.customervattxt.Size = new System.Drawing.Size(196, 30);
            this.customervattxt.TabIndex = 60;
            this.customervattxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(813, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 23);
            this.label16.TabIndex = 59;
            this.label16.Text = "Receipt Number";
            // 
            // customermailtxt
            // 
            this.customermailtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customermailtxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customermailtxt.Location = new System.Drawing.Point(553, 183);
            this.customermailtxt.Name = "customermailtxt";
            this.customermailtxt.Size = new System.Drawing.Size(275, 30);
            this.customermailtxt.TabIndex = 58;
            this.customermailtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(427, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 23);
            this.label17.TabIndex = 57;
            this.label17.Text = "Email";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // customernumbertxt
            // 
            this.customernumbertxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customernumbertxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customernumbertxt.Location = new System.Drawing.Point(553, 118);
            this.customernumbertxt.Name = "customernumbertxt";
            this.customernumbertxt.Size = new System.Drawing.Size(225, 30);
            this.customernumbertxt.TabIndex = 56;
            this.customernumbertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customernumbertxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customernumbertxt_KeyPress);
            // 
            // customeraddrtxt
            // 
            this.customeraddrtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customeraddrtxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customeraddrtxt.Location = new System.Drawing.Point(572, 32);
            this.customeraddrtxt.Multiline = true;
            this.customeraddrtxt.Name = "customeraddrtxt";
            this.customeraddrtxt.Size = new System.Drawing.Size(196, 62);
            this.customeraddrtxt.TabIndex = 55;
            this.customeraddrtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customernametxt
            // 
            this.customernametxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customernametxt.ForeColor = System.Drawing.Color.Black;
            this.customernametxt.Location = new System.Drawing.Point(151, 187);
            this.customernametxt.Name = "customernametxt";
            this.customernametxt.Size = new System.Drawing.Size(255, 30);
            this.customernametxt.TabIndex = 54;
            this.customernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customernametxt.Click += new System.EventHandler(this.textBox3_Click);
            this.customernametxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 23);
            this.label6.TabIndex = 52;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(417, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "Customer Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 50;
            this.label4.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Date";
            // 
            // customerstatustxt
            // 
            this.customerstatustxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerstatustxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerstatustxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerstatustxt.FormattingEnabled = true;
            this.customerstatustxt.Items.AddRange(new object[] {
            "Booked",
            "Received",
            "Dispatched",
            "Assigned to Courier",
            "Pending",
            "Delivered",
            "Returned",
            "Cancelled/Not Received"});
            this.customerstatustxt.Location = new System.Drawing.Point(965, 118);
            this.customerstatustxt.Name = "customerstatustxt";
            this.customerstatustxt.Size = new System.Drawing.Size(193, 31);
            this.customerstatustxt.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(838, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 23);
            this.label11.TabIndex = 61;
            this.label11.Text = "Status";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(166, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 30);
            this.textBox1.TabIndex = 64;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 63;
            this.label1.Text = "Customer Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Date,
            this.Customer_Name,
            this.Customer_Address,
            this.Customer_Phone_Number,
            this.Customer_Mail,
            this.Customer_Receipt_Number,
            this.Status,
            this.Balance});
            this.dataGridView1.DataSource = this.addcustomersBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1182, 337);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // addcustomersBindingSource
            // 
            this.addcustomersBindingSource.DataMember = "addcustomers";
            this.addcustomersBindingSource.DataSource = this.addcustomer;
            // 
            // addcustomer
            // 
            this.addcustomer.DataSetName = "addcustomer";
            this.addcustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnaddcustomer
            // 
            this.btnaddcustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddcustomer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnaddcustomer.FlatAppearance.BorderSize = 0;
            this.btnaddcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddcustomer.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcustomer.Location = new System.Drawing.Point(724, 247);
            this.btnaddcustomer.Name = "btnaddcustomer";
            this.btnaddcustomer.Size = new System.Drawing.Size(140, 36);
            this.btnaddcustomer.TabIndex = 66;
            this.btnaddcustomer.Text = "Add Customer";
            this.btnaddcustomer.UseVisualStyleBackColor = false;
            this.btnaddcustomer.Click += new System.EventHandler(this.btnaddcustomer_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnupdate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(878, 247);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(96, 36);
            this.btnupdate.TabIndex = 67;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(847, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 68;
            this.label3.Text = "Balance";
            // 
            // customerbalancetxt
            // 
            this.customerbalancetxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerbalancetxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerbalancetxt.Location = new System.Drawing.Point(962, 183);
            this.customerbalancetxt.Name = "customerbalancetxt";
            this.customerbalancetxt.Size = new System.Drawing.Size(196, 30);
            this.customerbalancetxt.TabIndex = 69;
            this.customerbalancetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customerbalancetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customerbalancetxt_KeyPress);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.refreshbtn.FlatAppearance.BorderSize = 0;
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbtn.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.Location = new System.Drawing.Point(980, 247);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(96, 36);
            this.refreshbtn.TabIndex = 70;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndelete.AutoSize = true;
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(1091, 247);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(80, 33);
            this.btndelete.TabIndex = 71;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtdate
            // 
            this.txtdate.CalendarFont = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(151, 116);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(255, 26);
            this.txtdate.TabIndex = 72;
            // 
            // addcustomersTableAdapter
            // 
            this.addcustomersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Customer Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Customer_Name
            // 
            this.Customer_Name.DataPropertyName = "Customer_Name";
            this.Customer_Name.HeaderText = "Customer Name";
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.ReadOnly = true;
            // 
            // Customer_Address
            // 
            this.Customer_Address.DataPropertyName = "Customer_Address";
            this.Customer_Address.HeaderText = "Customer Address";
            this.Customer_Address.Name = "Customer_Address";
            this.Customer_Address.ReadOnly = true;
            // 
            // Customer_Phone_Number
            // 
            this.Customer_Phone_Number.DataPropertyName = "Customer_Phone_Number";
            this.Customer_Phone_Number.HeaderText = "Customer Phone Number";
            this.Customer_Phone_Number.Name = "Customer_Phone_Number";
            this.Customer_Phone_Number.ReadOnly = true;
            // 
            // Customer_Mail
            // 
            this.Customer_Mail.DataPropertyName = "Customer_Mail";
            this.Customer_Mail.HeaderText = "Customer Mail";
            this.Customer_Mail.Name = "Customer_Mail";
            this.Customer_Mail.ReadOnly = true;
            // 
            // Customer_Receipt_Number
            // 
            this.Customer_Receipt_Number.DataPropertyName = "Customer_Receipt_Number";
            this.Customer_Receipt_Number.HeaderText = "Customer Receipt Number";
            this.Customer_Receipt_Number.Name = "Customer_Receipt_Number";
            this.Customer_Receipt_Number.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "Balance";
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // ADD_CUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 626);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.customerbalancetxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnaddcustomer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerstatustxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.customervattxt);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.customermailtxt);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.customernumbertxt);
            this.Controls.Add(this.customeraddrtxt);
            this.Controls.Add(this.customernametxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "ADD_CUSTOMER";
            this.Text = "ADD_CUSTOMER";
            this.Load += new System.EventHandler(this.ADD_CUSTOMER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addcustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addcustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customervattxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox customermailtxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox customernumbertxt;
        private System.Windows.Forms.TextBox customeraddrtxt;
        private System.Windows.Forms.TextBox customernametxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox customerstatustxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnaddcustomer;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerbalancetxt;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DateTimePicker txtdate;
        private addcustomer addcustomer;
        private System.Windows.Forms.BindingSource addcustomersBindingSource;
        private addcustomerTableAdapters.addcustomersTableAdapter addcustomersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Phone_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Receipt_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
    }
}