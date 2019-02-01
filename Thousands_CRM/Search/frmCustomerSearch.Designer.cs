namespace Thousands_CRM.Search
{
    partial class frmCustomerSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbMobileNumber = new System.Windows.Forms.TextBox();
            this.lblCusMobileNum = new System.Windows.Forms.Label();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.lblCusArea = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lblCusCustomerName = new System.Windows.Forms.Label();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.lblCusCompany = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbMobileNumber);
            this.groupBox1.Controls.Add(this.lblCusMobileNum);
            this.groupBox1.Controls.Add(this.tbArea);
            this.groupBox1.Controls.Add(this.lblCusArea);
            this.groupBox1.Controls.Add(this.tbCustomerName);
            this.groupBox1.Controls.Add(this.lblCusCustomerName);
            this.groupBox1.Controls.Add(this.tbCompany);
            this.groupBox1.Controls.Add(this.lblCusCompany);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(613, 130);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbMobileNumber
            // 
            this.tbMobileNumber.Location = new System.Drawing.Point(499, 29);
            this.tbMobileNumber.Name = "tbMobileNumber";
            this.tbMobileNumber.Size = new System.Drawing.Size(100, 20);
            this.tbMobileNumber.TabIndex = 10;
            // 
            // lblCusMobileNum
            // 
            this.lblCusMobileNum.AutoSize = true;
            this.lblCusMobileNum.Location = new System.Drawing.Point(413, 32);
            this.lblCusMobileNum.Name = "lblCusMobileNum";
            this.lblCusMobileNum.Size = new System.Drawing.Size(76, 13);
            this.lblCusMobileNum.TabIndex = 9;
            this.lblCusMobileNum.Text = "Mobile number";
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(92, 55);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(100, 20);
            this.tbArea.TabIndex = 8;
            // 
            // lblCusArea
            // 
            this.lblCusArea.AutoSize = true;
            this.lblCusArea.Location = new System.Drawing.Point(6, 58);
            this.lblCusArea.Name = "lblCusArea";
            this.lblCusArea.Size = new System.Drawing.Size(29, 13);
            this.lblCusArea.TabIndex = 7;
            this.lblCusArea.Text = "Area";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(294, 29);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(100, 20);
            this.tbCustomerName.TabIndex = 6;
            // 
            // lblCusCustomerName
            // 
            this.lblCusCustomerName.AutoSize = true;
            this.lblCusCustomerName.Location = new System.Drawing.Point(208, 32);
            this.lblCusCustomerName.Name = "lblCusCustomerName";
            this.lblCusCustomerName.Size = new System.Drawing.Size(80, 13);
            this.lblCusCustomerName.TabIndex = 5;
            this.lblCusCustomerName.Text = "Customer name";
            // 
            // tbCompany
            // 
            this.tbCompany.Location = new System.Drawing.Point(92, 29);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(100, 20);
            this.tbCompany.TabIndex = 4;
            // 
            // lblCusCompany
            // 
            this.lblCusCompany.AutoSize = true;
            this.lblCusCompany.Location = new System.Drawing.Point(6, 32);
            this.lblCusCompany.Name = "lblCusCompany";
            this.lblCusCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCusCompany.TabIndex = 3;
            this.lblCusCompany.Text = "Company";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 177);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(694, 243);
            this.dgvCustomers.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(631, 426);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmCustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 455);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "frmCustomerSearch";
            this.Text = "frmCustomerSearch";
            this.Load += new System.EventHandler(this.frmCustomerSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbMobileNumber;
        private System.Windows.Forms.Label lblCusMobileNum;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.Label lblCusArea;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label lblCusCustomerName;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.Label lblCusCompany;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnOK;


    }
}