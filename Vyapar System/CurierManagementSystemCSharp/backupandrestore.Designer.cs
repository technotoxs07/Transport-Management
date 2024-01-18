namespace CurierManagementSystemCSharp
{
    partial class backupandrestore
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnrestore = new System.Windows.Forms.Button();
            this.btnbrowser2 = new System.Windows.Forms.Button();
            this.txtrestorelocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnbackup = new System.Windows.Forms.Button();
            this.btnbrowser = new System.Windows.Forms.Button();
            this.txtlocationbckup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnrestore);
            this.panel2.Controls.Add(this.btnbrowser2);
            this.panel2.Controls.Add(this.txtrestorelocation);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(17, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 122);
            this.panel2.TabIndex = 13;
            // 
            // btnrestore
            // 
            this.btnrestore.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestore.Location = new System.Drawing.Point(387, 59);
            this.btnrestore.Name = "btnrestore";
            this.btnrestore.Size = new System.Drawing.Size(83, 38);
            this.btnrestore.TabIndex = 3;
            this.btnrestore.Text = "Restore";
            this.btnrestore.UseVisualStyleBackColor = true;
            this.btnrestore.Click += new System.EventHandler(this.btnrestore_Click);
            // 
            // btnbrowser2
            // 
            this.btnbrowser2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowser2.Location = new System.Drawing.Point(387, 22);
            this.btnbrowser2.Name = "btnbrowser2";
            this.btnbrowser2.Size = new System.Drawing.Size(83, 31);
            this.btnbrowser2.TabIndex = 2;
            this.btnbrowser2.Text = "Browse";
            this.btnbrowser2.UseVisualStyleBackColor = true;
            this.btnbrowser2.Click += new System.EventHandler(this.btnbrowser2_Click_1);
            // 
            // txtrestorelocation
            // 
            this.txtrestorelocation.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrestorelocation.Location = new System.Drawing.Point(98, 21);
            this.txtrestorelocation.Name = "txtrestorelocation";
            this.txtrestorelocation.Size = new System.Drawing.Size(267, 28);
            this.txtrestorelocation.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Restore Database";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnbackup);
            this.panel1.Controls.Add(this.btnbrowser);
            this.panel1.Controls.Add(this.txtlocationbckup);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 122);
            this.panel1.TabIndex = 11;
            // 
            // btnbackup
            // 
            this.btnbackup.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackup.Location = new System.Drawing.Point(387, 50);
            this.btnbackup.Name = "btnbackup";
            this.btnbackup.Size = new System.Drawing.Size(83, 38);
            this.btnbackup.TabIndex = 3;
            this.btnbackup.Text = "Backup";
            this.btnbackup.UseVisualStyleBackColor = true;
            this.btnbackup.Click += new System.EventHandler(this.btnbackup_Click_1);
            // 
            // btnbrowser
            // 
            this.btnbrowser.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowser.Location = new System.Drawing.Point(387, 13);
            this.btnbrowser.Name = "btnbrowser";
            this.btnbrowser.Size = new System.Drawing.Size(83, 31);
            this.btnbrowser.TabIndex = 2;
            this.btnbrowser.Text = "Browse";
            this.btnbrowser.UseVisualStyleBackColor = true;
            this.btnbrowser.Click += new System.EventHandler(this.btnbrowser_Click_1);
            // 
            // txtlocationbckup
            // 
            this.txtlocationbckup.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocationbckup.Location = new System.Drawing.Point(98, 15);
            this.txtlocationbckup.Name = "txtlocationbckup";
            this.txtlocationbckup.Size = new System.Drawing.Size(283, 28);
            this.txtlocationbckup.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Backup Database";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backupandrestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 444);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "backupandrestore";
            this.Text = "backupandrestore";
            this.Load += new System.EventHandler(this.backupandrestore_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnrestore;
        private System.Windows.Forms.Button btnbrowser2;
        private System.Windows.Forms.TextBox txtrestorelocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnbackup;
        private System.Windows.Forms.Button btnbrowser;
        private System.Windows.Forms.TextBox txtlocationbckup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}