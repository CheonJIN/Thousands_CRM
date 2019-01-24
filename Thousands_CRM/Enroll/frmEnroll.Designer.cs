namespace Thousands_CRM.Enroll
{
    partial class frmEnroll
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpEnrollCompany = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.tpEnrollCustomer = new System.Windows.Forms.TabPage();
            this.btnEnrollCompany = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMobileNumber = new System.Windows.Forms.TextBox();
            this.btnEnrollCustomer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tpEnrollCompany.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpEnrollCustomer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpEnrollCompany);
            this.tabControl1.Controls.Add(this.tpEnrollCustomer);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 279);
            this.tabControl1.TabIndex = 0;
            // 
            // tpEnrollCompany
            // 
            this.tpEnrollCompany.Controls.Add(this.tableLayoutPanel1);
            this.tpEnrollCompany.Location = new System.Drawing.Point(4, 22);
            this.tpEnrollCompany.Name = "tpEnrollCompany";
            this.tpEnrollCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tpEnrollCompany.Size = new System.Drawing.Size(442, 253);
            this.tpEnrollCompany.TabIndex = 0;
            this.tpEnrollCompany.Text = "Company";
            this.tpEnrollCompany.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblCompanyName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbCompanyName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblArea, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbArea, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnEnrollCompany, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(436, 247);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCompanyName.Location = new System.Drawing.Point(48, 19);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(41, 26);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Name :";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCompanyName.Location = new System.Drawing.Point(95, 22);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(206, 20);
            this.tbCompanyName.TabIndex = 1;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblArea.Location = new System.Drawing.Point(54, 45);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 26);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area :";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbArea
            // 
            this.tbArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbArea.Location = new System.Drawing.Point(95, 48);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(206, 20);
            this.tbArea.TabIndex = 3;
            // 
            // tpEnrollCustomer
            // 
            this.tpEnrollCustomer.Controls.Add(this.tableLayoutPanel2);
            this.tpEnrollCustomer.Location = new System.Drawing.Point(4, 22);
            this.tpEnrollCustomer.Name = "tpEnrollCustomer";
            this.tpEnrollCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tpEnrollCustomer.Size = new System.Drawing.Size(442, 253);
            this.tpEnrollCustomer.TabIndex = 1;
            this.tpEnrollCustomer.Text = "Customer";
            this.tpEnrollCustomer.UseVisualStyleBackColor = true;
            // 
            // btnEnrollCompany
            // 
            this.btnEnrollCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnrollCompany.Location = new System.Drawing.Point(358, 221);
            this.btnEnrollCompany.Name = "btnEnrollCompany";
            this.btnEnrollCompany.Size = new System.Drawing.Size(75, 23);
            this.btnEnrollCompany.TabIndex = 4;
            this.btnEnrollCompany.Text = "Enroll";
            this.btnEnrollCompany.UseVisualStyleBackColor = true;
            this.btnEnrollCompany.Click += new System.EventHandler(this.btnEnrollCompany_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbCustomerName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbMobileNumber, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnEnrollCustomer, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbPhoneNumber, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbCompany, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(436, 247);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(48, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCustomerName.Location = new System.Drawing.Point(95, 22);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(206, 20);
            this.tbCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mobile number :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMobileNumber
            // 
            this.tbMobileNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMobileNumber.Location = new System.Drawing.Point(95, 48);
            this.tbMobileNumber.Name = "tbMobileNumber";
            this.tbMobileNumber.Size = new System.Drawing.Size(206, 20);
            this.tbMobileNumber.TabIndex = 3;
            // 
            // btnEnrollCustomer
            // 
            this.btnEnrollCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnrollCustomer.Location = new System.Drawing.Point(358, 221);
            this.btnEnrollCustomer.Name = "btnEnrollCustomer";
            this.btnEnrollCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnEnrollCustomer.TabIndex = 4;
            this.btnEnrollCustomer.Text = "Enroll";
            this.btnEnrollCustomer.UseVisualStyleBackColor = true;
            this.btnEnrollCustomer.Click += new System.EventHandler(this.btnEnrollCustomer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone number :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(32, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Company :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPhoneNumber.Location = new System.Drawing.Point(95, 74);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(206, 20);
            this.tbPhoneNumber.TabIndex = 7;
            // 
            // cbCompany
            // 
            this.cbCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(95, 100);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(206, 21);
            this.cbCompany.TabIndex = 8;
            // 
            // frmEnroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 279);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmEnroll";
            this.Text = "Enroll";
            this.tabControl1.ResumeLayout(false);
            this.tpEnrollCompany.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tpEnrollCustomer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpEnrollCompany;
        private System.Windows.Forms.TabPage tpEnrollCustomer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.Button btnEnrollCompany;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMobileNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnrollCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.ComboBox cbCompany;
    }
}