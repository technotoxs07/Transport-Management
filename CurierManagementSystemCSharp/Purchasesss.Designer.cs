namespace CurierManagementSystemCSharp
{
    partial class Purchasesss
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
            this.btnclear = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtamountwithvat = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtvat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.discouttxt = new System.Windows.Forms.TextBox();
            this.unittxt = new System.Windows.Forms.ComboBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.qtytxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.amountchargedtxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.itemnametxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datetxt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.customermailtxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.customernumbertxt = new System.Windows.Forms.TextBox();
            this.customeraddrtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.customernametxt = new System.Windows.Forms.TextBox();
            this.updtxt = new System.Windows.Forms.Button();
            this.itemcalculation = new CurierManagementSystemCSharp.itemcalculation();
            this.itmcalculationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itmcalculationTableAdapter = new CurierManagementSystemCSharp.itemcalculationTableAdapters.ItmcalculationTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemcalculation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itmcalculationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(899, 570);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(93, 44);
            this.btnclear.TabIndex = 138;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(682, 459);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 23);
            this.label19.TabIndex = 137;
            this.label19.Text = "VAT Amount";
            // 
            // txtamountwithvat
            // 
            this.txtamountwithvat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtamountwithvat.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamountwithvat.Location = new System.Drawing.Point(829, 454);
            this.txtamountwithvat.Name = "txtamountwithvat";
            this.txtamountwithvat.Size = new System.Drawing.Size(278, 28);
            this.txtamountwithvat.TabIndex = 136;
            this.txtamountwithvat.Text = "0";
            this.txtamountwithvat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(687, 570);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 44);
            this.button2.TabIndex = 134;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(683, 514);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 23);
            this.label11.TabIndex = 133;
            this.label11.Text = "Grand Total";
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtgrandtotal.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrandtotal.Location = new System.Drawing.Point(829, 513);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.Size = new System.Drawing.Size(278, 28);
            this.txtgrandtotal.TabIndex = 132;
            this.txtgrandtotal.Text = "0.00";
            this.txtgrandtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(683, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 23);
            this.label8.TabIndex = 131;
            this.label8.Text = "VAT (%)";
            // 
            // txtvat
            // 
            this.txtvat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtvat.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvat.Location = new System.Drawing.Point(829, 397);
            this.txtvat.Name = "txtvat";
            this.txtvat.Size = new System.Drawing.Size(278, 28);
            this.txtvat.TabIndex = 130;
            this.txtvat.Text = "13";
            this.txtvat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(683, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 129;
            this.label7.Text = "Discount(%)";
            // 
            // discouttxt
            // 
            this.discouttxt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.discouttxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discouttxt.Location = new System.Drawing.Point(829, 347);
            this.discouttxt.Name = "discouttxt";
            this.discouttxt.Size = new System.Drawing.Size(278, 28);
            this.discouttxt.TabIndex = 128;
            this.discouttxt.Text = "0";
            this.discouttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unittxt
            // 
            this.unittxt.AllowDrop = true;
            this.unittxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.unittxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.unittxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.unittxt.BackColor = System.Drawing.Color.White;
            this.unittxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unittxt.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unittxt.FormattingEnabled = true;
            this.unittxt.Items.AddRange(new object[] {
            "NONE",
            "BAGS (BAG)",
            "BOTTLES (BTL)",
            "BOX (BOX)",
            "BUNDLES (BDL)",
            "CANS (CAN)",
            "CARTONS (CTN)",
            "DOZENS (DZN)",
            "GRAMMES (GM)",
            "KILOGRAMS (KG)",
            "LITRE (LTR)",
            "METERS (MTR)",
            "MILILITRE (ML)",
            "NUMBERS (NOS)",
            "PACKS (PAC)",
            "PAIRS (PRS)",
            "PIECES (PCS)",
            "QUINTAL (QTL)",
            "ROLLS (ROL)",
            "SQUARE FEET (SQF)",
            "SQUARE METERS (SQM)",
            "TABLETS (TBS)"});
            this.unittxt.Location = new System.Drawing.Point(610, 204);
            this.unittxt.Name = "unittxt";
            this.unittxt.Size = new System.Drawing.Size(166, 25);
            this.unittxt.TabIndex = 127;
            // 
            // pricetxt
            // 
            this.pricetxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pricetxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxt.Location = new System.Drawing.Point(876, 201);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(95, 28);
            this.pricetxt.TabIndex = 126;
            this.pricetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(782, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 23);
            this.label15.TabIndex = 125;
            this.label15.Text = "Price/Unit";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(549, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 23);
            this.label14.TabIndex = 124;
            this.label14.Text = "UNIT";
            // 
            // qtytxt
            // 
            this.qtytxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.qtytxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtytxt.Location = new System.Drawing.Point(449, 201);
            this.qtytxt.Name = "qtytxt";
            this.qtytxt.Size = new System.Drawing.Size(84, 28);
            this.qtytxt.TabIndex = 123;
            this.qtytxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(393, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 23);
            this.label12.TabIndex = 122;
            this.label12.Text = "QTY.";
            // 
            // amountchargedtxt
            // 
            this.amountchargedtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.amountchargedtxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountchargedtxt.Location = new System.Drawing.Point(1052, 200);
            this.amountchargedtxt.Name = "amountchargedtxt";
            this.amountchargedtxt.Size = new System.Drawing.Size(118, 28);
            this.amountchargedtxt.TabIndex = 121;
            this.amountchargedtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(683, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 23);
            this.label10.TabIndex = 120;
            this.label10.Text = "Sub Total";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtsubtotal.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(829, 302);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(278, 28);
            this.txtsubtotal.TabIndex = 119;
            this.txtsubtotal.Text = "0.00";
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(977, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 46);
            this.label9.TabIndex = 118;
            this.label9.Text = "Amount\r\nCharged";
            // 
            // itemnametxt
            // 
            this.itemnametxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.itemnametxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.itemnametxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.itemnametxt.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemnametxt.ForeColor = System.Drawing.Color.Black;
            this.itemnametxt.Location = new System.Drawing.Point(125, 201);
            this.itemnametxt.Multiline = true;
            this.itemnametxt.Name = "itemnametxt";
            this.itemnametxt.Size = new System.Drawing.Size(262, 36);
            this.itemnametxt.TabIndex = 117;
            this.itemnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 206);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 23);
            this.label16.TabIndex = 116;
            this.label16.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(36, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 26);
            this.label1.TabIndex = 115;
            this.label1.Text = "Product Details";
            // 
            // datetxt
            // 
            this.datetxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datetxt.CustomFormat = "dd-mm-yyyy";
            this.datetxt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetxt.Location = new System.Drawing.Point(521, 109);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(245, 26);
            this.datetxt.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 113;
            this.label2.Text = "Date";
            // 
            // customermailtxt
            // 
            this.customermailtxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customermailtxt.Location = new System.Drawing.Point(140, 111);
            this.customermailtxt.Name = "customermailtxt";
            this.customermailtxt.Size = new System.Drawing.Size(237, 30);
            this.customermailtxt.TabIndex = 112;
            this.customermailtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(26, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 23);
            this.label17.TabIndex = 111;
            this.label17.Text = "Email";
            // 
            // customernumbertxt
            // 
            this.customernumbertxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customernumbertxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customernumbertxt.Location = new System.Drawing.Point(537, 51);
            this.customernumbertxt.Name = "customernumbertxt";
            this.customernumbertxt.Size = new System.Drawing.Size(219, 30);
            this.customernumbertxt.TabIndex = 110;
            this.customernumbertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // customeraddrtxt
            // 
            this.customeraddrtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customeraddrtxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customeraddrtxt.Location = new System.Drawing.Point(944, 64);
            this.customeraddrtxt.Multiline = true;
            this.customeraddrtxt.Name = "customeraddrtxt";
            this.customeraddrtxt.Size = new System.Drawing.Size(196, 69);
            this.customeraddrtxt.TabIndex = 109;
            this.customeraddrtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(393, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 23);
            this.label6.TabIndex = 108;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(811, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 107;
            this.label5.Text = "Party Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 106;
            this.label4.Text = "Party Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Item_Name,
            this.Quantity,
            this.Unit,
            this.Price,
            this.Discount,
            this.Total_Amount});
            this.dataGridView1.DataSource = this.itmcalculationBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(2, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(661, 373);
            this.dataGridView1.TabIndex = 105;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(971, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 41);
            this.button1.TabIndex = 104;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(25, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 26);
            this.label3.TabIndex = 103;
            this.label3.Text = "Dealer Details";
            // 
            // customernametxt
            // 
            this.customernametxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customernametxt.Location = new System.Drawing.Point(140, 50);
            this.customernametxt.Name = "customernametxt";
            this.customernametxt.Size = new System.Drawing.Size(237, 30);
            this.customernametxt.TabIndex = 139;
            this.customernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updtxt
            // 
            this.updtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updtxt.BackColor = System.Drawing.Color.LimeGreen;
            this.updtxt.FlatAppearance.BorderSize = 0;
            this.updtxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updtxt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updtxt.Location = new System.Drawing.Point(790, 570);
            this.updtxt.Name = "updtxt";
            this.updtxt.Size = new System.Drawing.Size(103, 44);
            this.updtxt.TabIndex = 140;
            this.updtxt.Text = "Update";
            this.updtxt.UseVisualStyleBackColor = false;
            this.updtxt.Click += new System.EventHandler(this.updtxt_Click);
            // 
            // itemcalculation
            // 
            this.itemcalculation.DataSetName = "itemcalculation";
            this.itemcalculation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itmcalculationBindingSource
            // 
            this.itmcalculationBindingSource.DataMember = "Itmcalculation";
            this.itmcalculationBindingSource.DataSource = this.itemcalculation;
            // 
            // itmcalculationTableAdapter
            // 
            this.itmcalculationTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Item_Name
            // 
            this.Item_Name.DataPropertyName = "Item_Name";
            this.Item_Name.HeaderText = "Item_Name";
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Total_Amount
            // 
            this.Total_Amount.DataPropertyName = "Total_Amount";
            this.Total_Amount.HeaderText = "Total_Amount";
            this.Total_Amount.Name = "Total_Amount";
            this.Total_Amount.ReadOnly = true;
            // 
            // Purchasesss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 626);
            this.Controls.Add(this.updtxt);
            this.Controls.Add(this.customernametxt);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtamountwithvat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtgrandtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtvat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.discouttxt);
            this.Controls.Add(this.unittxt);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.qtytxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.amountchargedtxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.itemnametxt);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customermailtxt);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.customernumbertxt);
            this.Controls.Add(this.customeraddrtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Name = "Purchasesss";
            this.Text = "Purchasesss";
            this.Load += new System.EventHandler(this.Purchasesss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemcalculation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itmcalculationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtamountwithvat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtgrandtotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtvat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox discouttxt;
        private System.Windows.Forms.ComboBox unittxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox qtytxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox amountchargedtxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox itemnametxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customermailtxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox customernumbertxt;
        private System.Windows.Forms.TextBox customeraddrtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customernametxt;
        private System.Windows.Forms.Button updtxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private itemcalculation itemcalculation;
        private System.Windows.Forms.BindingSource itmcalculationBindingSource;
        private itemcalculationTableAdapters.ItmcalculationTableAdapter itmcalculationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Amount;
    }
}