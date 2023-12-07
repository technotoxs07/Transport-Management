namespace CurierManagementSystemCSharp
{
    partial class consignmentreport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.consignBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courierDataSet = new CurierManagementSystemCSharp.courierDataSet();
            this.addbusinessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_business = new CurierManagementSystemCSharp.add_business();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.consignTableAdapter = new CurierManagementSystemCSharp.courierDataSetTableAdapters.consignTableAdapter();
            this.add_businessTableAdapter = new CurierManagementSystemCSharp.add_businessTableAdapters.add_businessTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.consignBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addbusinessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_business)).BeginInit();
            this.SuspendLayout();
            // 
            // consignBindingSource
            // 
            this.consignBindingSource.DataMember = "consign";
            this.consignBindingSource.DataSource = this.courierDataSet;
            // 
            // courierDataSet
            // 
            this.courierDataSet.DataSetName = "courierDataSet";
            this.courierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.consignBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.addbusinessBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CurierManagementSystemCSharp.bin.Release.consignment.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 58);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1182, 568);
            this.reportViewer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1095, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.Location = new System.Drawing.Point(828, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // consignTableAdapter
            // 
            this.consignTableAdapter.ClearBeforeFill = true;
            // 
            // add_businessTableAdapter
            // 
            this.add_businessTableAdapter.ClearBeforeFill = true;
            // 
            // consignmentreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "consignmentreport";
            this.Text = "consignmentreport";
            this.Load += new System.EventHandler(this.consignmentreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consignBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addbusinessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_business)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private courierDataSet courierDataSet;
        private System.Windows.Forms.BindingSource consignBindingSource;
        private courierDataSetTableAdapters.consignTableAdapter consignTableAdapter;
        private add_business add_business;
        private System.Windows.Forms.BindingSource addbusinessBindingSource;
        private add_businessTableAdapters.add_businessTableAdapter add_businessTableAdapter;
    }
}