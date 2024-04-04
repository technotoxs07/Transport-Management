namespace CurierManagementSystemCSharp
{
    partial class Showitemspurchase
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
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsdata = new CurierManagementSystemCSharp.Itemsdata();
            this.itemsTableAdapter = new CurierManagementSystemCSharp.ItemsdataTableAdapters.ItemsTableAdapter();
            this.purchaserealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Purchases_Real_ = new CurierManagementSystemCSharp._Purchases_Real_();
            this.purchase_real_TableAdapter = new CurierManagementSystemCSharp._Purchases_Real_TableAdapters.Purchase_real_TableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btncategories = new System.Windows.Forms.Button();
            this.btnproducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaserealBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Purchases_Real_)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.itemsdata;
            // 
            // itemsdata
            // 
            this.itemsdata.DataSetName = "Itemsdata";
            this.itemsdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // purchaserealBindingSource
            // 
            this.purchaserealBindingSource.DataMember = "Purchase(real)";
            this.purchaserealBindingSource.DataSource = this._Purchases_Real_;
            // 
            // _Purchases_Real_
            // 
            this._Purchases_Real_.DataSetName = "Purchases(Real)";
            this._Purchases_Real_.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchase_real_TableAdapter
            // 
            this.purchase_real_TableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 521);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Purchase\'s Stock";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(814, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(344, 31);
            this.button4.TabIndex = 18;
            this.button4.Text = "UNITS";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btncategories
            // 
            this.btncategories.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btncategories.FlatAppearance.BorderSize = 0;
            this.btncategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategories.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategories.Location = new System.Drawing.Point(423, 57);
            this.btncategories.Name = "btncategories";
            this.btncategories.Size = new System.Drawing.Size(385, 31);
            this.btncategories.TabIndex = 17;
            this.btncategories.Text = "CATEGORY";
            this.btncategories.UseVisualStyleBackColor = false;
            this.btncategories.Click += new System.EventHandler(this.btncategories_Click);
            // 
            // btnproducts
            // 
            this.btnproducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnproducts.FlatAppearance.BorderSize = 0;
            this.btnproducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproducts.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducts.Location = new System.Drawing.Point(6, 57);
            this.btnproducts.Name = "btnproducts";
            this.btnproducts.Size = new System.Drawing.Size(401, 31);
            this.btnproducts.TabIndex = 15;
            this.btnproducts.Text = "PRODUCTS";
            this.btnproducts.UseVisualStyleBackColor = false;
            this.btnproducts.Click += new System.EventHandler(this.btnproducts_Click);
            // 
            // Showitemspurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 626);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btncategories);
            this.Controls.Add(this.btnproducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "Showitemspurchase";
            this.Text = "Showitemssale";
            this.Load += new System.EventHandler(this.Showitemssale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaserealBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Purchases_Real_)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Itemsdata itemsdata;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private ItemsdataTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private _Purchases_Real_ _Purchases_Real_;
        private System.Windows.Forms.BindingSource purchaserealBindingSource;
        private _Purchases_Real_TableAdapters.Purchase_real_TableAdapter purchase_real_TableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btncategories;
        private System.Windows.Forms.Button btnproducts;
    }
}