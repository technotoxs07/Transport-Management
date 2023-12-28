namespace CurierManagementSystemCSharp.Reports
{
    partial class Purchase1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.purchaserealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Purchases_Real_ = new CurierManagementSystemCSharp._Purchases_Real_();
            this.addbusinessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_business = new CurierManagementSystemCSharp.add_business();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.add_businessTableAdapter = new CurierManagementSystemCSharp.add_businessTableAdapters.add_businessTableAdapter();
            this.purchase_real_TableAdapter = new CurierManagementSystemCSharp._Purchases_Real_TableAdapters.Purchase_real_TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.purchaserealBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Purchases_Real_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addbusinessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_business)).BeginInit();
            this.SuspendLayout();
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
            // addbusinessBindingSource
            // 
            this.addbusinessBindingSource.DataMember = "add_business";
            this.addbusinessBindingSource.DataSource = this.add_business;
            // 
            // add_business
            // 
            this.add_business.DataSetName = "add_business";
            this.add_business.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoSize = true;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.purchaserealBindingSource;
            reportDataSource6.Name = "add_business";
            reportDataSource6.Value = this.addbusinessBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CurierManagementSystemCSharp.bin.Release.purchase.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 54);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1182, 571);
            this.reportViewer1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(691, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(414, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // add_businessTableAdapter
            // 
            this.add_businessTableAdapter.ClearBeforeFill = true;
            // 
            // purchase_real_TableAdapter
            // 
            this.purchase_real_TableAdapter.ClearBeforeFill = true;
            // 
            // Purchase1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Purchase1";
            this.Text = "Purchase1";
            this.Load += new System.EventHandler(this.Purchase1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaserealBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Purchases_Real_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addbusinessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_business)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private add_business add_business;
        private System.Windows.Forms.BindingSource addbusinessBindingSource;
        private add_businessTableAdapters.add_businessTableAdapter add_businessTableAdapter;
        private _Purchases_Real_ _Purchases_Real_;
        private System.Windows.Forms.BindingSource purchaserealBindingSource;
        private _Purchases_Real_TableAdapters.Purchase_real_TableAdapter purchase_real_TableAdapter;
    }
}