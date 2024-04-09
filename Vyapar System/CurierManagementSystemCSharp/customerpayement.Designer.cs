namespace CurierManagementSystemCSharp
{
    partial class customerpayement
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.customernametxt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.amountchargedtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.amountpaindtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custome_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_Charged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Holder_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bank_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerpaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_payement = new CurierManagementSystemCSharp.customer_payement();
            this.panel1 = new System.Windows.Forms.Panel();
            this.branchnametxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.banknametxt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.accnumbertxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.accholdernametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.customernumbertxt = new System.Windows.Forms.ComboBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.customer_paymentTableAdapter = new CurierManagementSystemCSharp.customer_payementTableAdapters.Customer_paymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerpaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_payement)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(497, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 27);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cash";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(575, 11);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 27);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Credit";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // customernametxt
            // 
            this.customernametxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.customernametxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customernametxt.DropDownHeight = 150;
            this.customernametxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customernametxt.FormattingEnabled = true;
            this.customernametxt.IntegralHeight = false;
            this.customernametxt.Location = new System.Drawing.Point(181, 65);
            this.customernametxt.Name = "customernametxt";
            this.customernametxt.Size = new System.Drawing.Size(229, 28);
            this.customernametxt.TabIndex = 53;
            this.customernametxt.SelectedIndexChanged += new System.EventHandler(this.customernametxt_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 52;
            this.label4.Text = "Customer Name";
            // 
            // amountchargedtxt
            // 
            this.amountchargedtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountchargedtxt.Location = new System.Drawing.Point(181, 118);
            this.amountchargedtxt.Name = "amountchargedtxt";
            this.amountchargedtxt.ReadOnly = true;
            this.amountchargedtxt.Size = new System.Drawing.Size(229, 28);
            this.amountchargedtxt.TabIndex = 55;
            this.amountchargedtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 23);
            this.label9.TabIndex = 54;
            this.label9.Text = "Amount Charged";
            // 
            // amountpaindtxt
            // 
            this.amountpaindtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountpaindtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountpaindtxt.Location = new System.Drawing.Point(920, 113);
            this.amountpaindtxt.Name = "amountpaindtxt";
            this.amountpaindtxt.Size = new System.Drawing.Size(229, 28);
            this.amountpaindtxt.TabIndex = 57;
            this.amountpaindtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(782, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 56;
            this.label1.Text = "Amount Paid";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(715, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 26);
            this.dateTimePicker1.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(782, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 23);
            this.label6.TabIndex = 59;
            this.label6.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 61;
            this.label2.Text = "Account Detail\'s";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dateDataGridViewTextBoxColumn,
            this.Customer_Name,
            this.Custome_Number,
            this.Amount_Charged,
            this.Amount_Paid,
            this.Account_Holder_Name,
            this.Account_Number,
            this.Bank_Name,
            this.branch});
            this.dataGridView1.DataSource = this.customerpaymentBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 396);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1182, 230);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 200;
            // 
            // Customer_Name
            // 
            this.Customer_Name.DataPropertyName = "Customer_Name";
            this.Customer_Name.HeaderText = "Customer Name";
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.ReadOnly = true;
            this.Customer_Name.Width = 200;
            // 
            // Custome_Number
            // 
            this.Custome_Number.DataPropertyName = "Custome_Number";
            this.Custome_Number.HeaderText = "Custome Number";
            this.Custome_Number.Name = "Custome_Number";
            this.Custome_Number.ReadOnly = true;
            this.Custome_Number.Width = 200;
            // 
            // Amount_Charged
            // 
            this.Amount_Charged.DataPropertyName = "Amount_Charged";
            this.Amount_Charged.HeaderText = "Amount Charged";
            this.Amount_Charged.Name = "Amount_Charged";
            this.Amount_Charged.ReadOnly = true;
            this.Amount_Charged.Width = 200;
            // 
            // Amount_Paid
            // 
            this.Amount_Paid.DataPropertyName = "Amount_Paid";
            this.Amount_Paid.HeaderText = "Amount Paid";
            this.Amount_Paid.Name = "Amount_Paid";
            this.Amount_Paid.ReadOnly = true;
            this.Amount_Paid.Width = 200;
            // 
            // Account_Holder_Name
            // 
            this.Account_Holder_Name.DataPropertyName = "Account_Holder_Name";
            this.Account_Holder_Name.HeaderText = "Account Holder Name";
            this.Account_Holder_Name.Name = "Account_Holder_Name";
            this.Account_Holder_Name.ReadOnly = true;
            this.Account_Holder_Name.Width = 200;
            // 
            // Account_Number
            // 
            this.Account_Number.DataPropertyName = "Account_Number";
            this.Account_Number.HeaderText = "Account Number";
            this.Account_Number.Name = "Account_Number";
            this.Account_Number.ReadOnly = true;
            this.Account_Number.Width = 200;
            // 
            // Bank_Name
            // 
            this.Bank_Name.DataPropertyName = "Bank_Name";
            this.Bank_Name.HeaderText = "Bank Name";
            this.Bank_Name.Name = "Bank_Name";
            this.Bank_Name.ReadOnly = true;
            this.Bank_Name.Width = 200;
            // 
            // branch
            // 
            this.branch.DataPropertyName = "branch";
            this.branch.HeaderText = "Branch";
            this.branch.Name = "branch";
            this.branch.ReadOnly = true;
            this.branch.Width = 200;
            // 
            // customerpaymentBindingSource
            // 
            this.customerpaymentBindingSource.DataMember = "Customer_payment";
            this.customerpaymentBindingSource.DataSource = this.customer_payement;
            // 
            // customer_payement
            // 
            this.customer_payement.DataSetName = "customer_payement";
            this.customer_payement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.branchnametxt);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.banknametxt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.accnumbertxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.accholdernametxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 177);
            this.panel1.TabIndex = 71;
            this.panel1.Visible = false;
            // 
            // branchnametxt
            // 
            this.branchnametxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.branchnametxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchnametxt.Location = new System.Drawing.Point(981, 38);
            this.branchnametxt.Name = "branchnametxt";
            this.branchnametxt.Size = new System.Drawing.Size(167, 28);
            this.branchnametxt.TabIndex = 77;
            this.branchnametxt.Text = "XXXXXXXX";
            this.branchnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.branchnametxt.Click += new System.EventHandler(this.branchnametxt_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(915, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 76;
            this.label8.Text = "Branch";
            // 
            // banknametxt
            // 
            this.banknametxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.banknametxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.banknametxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.banknametxt.DropDownHeight = 150;
            this.banknametxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banknametxt.FormattingEnabled = true;
            this.banknametxt.IntegralHeight = false;
            this.banknametxt.Items.AddRange(new object[] {
            "Agriculture Development Bank",
            "Nepal Bank",
            "Rastriya Banijya Bank",
            "Citizens Bank International",
            "Everest Bank",
            "Global IME Bank",
            "Himalayan Bank",
            "Kumari Bank",
            "Laxmi Sunrise Bank",
            "Machhapuchhre Bank",
            "Nabil Bank",
            "Nepal Investment Mega Bank",
            "Nepal SBI Bank",
            "NIC Asia Bank",
            "NMB Bank",
            "Prabhu Bank",
            "Prime Commercial Bank",
            "Sanima Bank",
            "Siddhartha Bank",
            "Standard Chartered Bank"});
            this.banknametxt.Location = new System.Drawing.Point(233, 137);
            this.banknametxt.Name = "banknametxt";
            this.banknametxt.Size = new System.Drawing.Size(282, 28);
            this.banknametxt.TabIndex = 75;
            this.banknametxt.Text = "XXXXXX";
            this.banknametxt.SelectedIndexChanged += new System.EventHandler(this.banknametxt_SelectedIndexChanged);
            this.banknametxt.Click += new System.EventHandler(this.banknametxt_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 74;
            this.label7.Text = "Bank Name";
            // 
            // accnumbertxt
            // 
            this.accnumbertxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.accnumbertxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accnumbertxt.Location = new System.Drawing.Point(233, 94);
            this.accnumbertxt.MaxLength = 20;
            this.accnumbertxt.Name = "accnumbertxt";
            this.accnumbertxt.Size = new System.Drawing.Size(389, 28);
            this.accnumbertxt.TabIndex = 73;
            this.accnumbertxt.Text = "XXXXXXXXXXXXXXXX";
            this.accnumbertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.accnumbertxt.Click += new System.EventHandler(this.accnumbertxt_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 72;
            this.label5.Text = "Account Number";
            // 
            // accholdernametxt
            // 
            this.accholdernametxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.accholdernametxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accholdernametxt.Location = new System.Drawing.Point(233, 44);
            this.accholdernametxt.Name = "accholdernametxt";
            this.accholdernametxt.Size = new System.Drawing.Size(389, 28);
            this.accholdernametxt.TabIndex = 71;
            this.accholdernametxt.Text = "XXXXXXXXXXXXXXXX";
            this.accholdernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.accholdernametxt.Click += new System.EventHandler(this.accholdernametxt_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 23);
            this.label3.TabIndex = 70;
            this.label3.Text = "Account Holder\'s Name";
            // 
            // btnadd
            // 
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(927, 345);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(108, 32);
            this.btnadd.TabIndex = 72;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // customernumbertxt
            // 
            this.customernumbertxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customernumbertxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.customernumbertxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customernumbertxt.DropDownHeight = 150;
            this.customernumbertxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.customernumbertxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customernumbertxt.FormattingEnabled = true;
            this.customernumbertxt.IntegralHeight = false;
            this.customernumbertxt.Location = new System.Drawing.Point(920, 56);
            this.customernumbertxt.Name = "customernumbertxt";
            this.customernumbertxt.Size = new System.Drawing.Size(229, 28);
            this.customernumbertxt.TabIndex = 73;
            // 
            // btnupdate
            // 
            this.btnupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnupdate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(1041, 345);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(108, 32);
            this.btnupdate.TabIndex = 74;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // customer_paymentTableAdapter
            // 
            this.customer_paymentTableAdapter.ClearBeforeFill = true;
            // 
            // customerpayement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 626);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.customernumbertxt);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.amountpaindtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountchargedtxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.customernametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "customerpayement";
            this.Load += new System.EventHandler(this.customerpayement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerpaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_payement)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox customernametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amountchargedtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox amountpaindtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox branchnametxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox banknametxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox accnumbertxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox accholdernametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox customernumbertxt;
        private System.Windows.Forms.Button btnupdate;
        private customer_payement customer_payement;
        private System.Windows.Forms.BindingSource customerpaymentBindingSource;
        private customer_payementTableAdapters.Customer_paymentTableAdapter customer_paymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Custome_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_Charged;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_Paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Holder_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bank_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn branch;
    }
}