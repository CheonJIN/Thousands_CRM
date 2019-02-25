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
            this.tpEnrollCompany = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAreaSub = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSalesManager = new System.Windows.Forms.Label();
            this.btnEnrollCompany = new System.Windows.Forms.Button();
            this.lblAreaMain = new System.Windows.Forms.Label();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cbAreaMain = new System.Windows.Forms.ComboBox();
            this.cbAreaSub = new System.Windows.Forms.ComboBox();
            this.tpEnrollCompany.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpEnrollCompany
            // 
            this.tpEnrollCompany.Controls.Add(this.statusStrip1);
            this.tpEnrollCompany.Controls.Add(this.tableLayoutPanel1);
            this.tpEnrollCompany.Location = new System.Drawing.Point(4, 22);
            this.tpEnrollCompany.Name = "tpEnrollCompany";
            this.tpEnrollCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tpEnrollCompany.Size = new System.Drawing.Size(390, 208);
            this.tpEnrollCompany.TabIndex = 0;
            this.tpEnrollCompany.Text = "Company";
            this.tpEnrollCompany.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblCompanyName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbCompanyName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAreaMain, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnEnrollCompany, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblSalesManager, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblAreaSub, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbAreaMain, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbAreaSub, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(390, 182);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 8;
            // 
            // lblAreaSub
            // 
            this.lblAreaSub.AutoSize = true;
            this.lblAreaSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAreaSub.Location = new System.Drawing.Point(3, 71);
            this.lblAreaSub.Name = "lblAreaSub";
            this.lblAreaSub.Size = new System.Drawing.Size(86, 26);
            this.lblAreaSub.TabIndex = 7;
            this.lblAreaSub.Text = "Area(sub) :";
            this.lblAreaSub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Location = new System.Drawing.Point(3, 123);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(86, 26);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address :";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalesManager
            // 
            this.lblSalesManager.AutoSize = true;
            this.lblSalesManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSalesManager.Location = new System.Drawing.Point(3, 97);
            this.lblSalesManager.Name = "lblSalesManager";
            this.lblSalesManager.Size = new System.Drawing.Size(86, 26);
            this.lblSalesManager.TabIndex = 5;
            this.lblSalesManager.Text = "Sales manager :";
            this.lblSalesManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEnrollCompany
            // 
            this.btnEnrollCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnrollCompany.Location = new System.Drawing.Point(312, 158);
            this.btnEnrollCompany.Name = "btnEnrollCompany";
            this.btnEnrollCompany.Size = new System.Drawing.Size(75, 21);
            this.btnEnrollCompany.TabIndex = 4;
            this.btnEnrollCompany.Text = "Enroll";
            this.btnEnrollCompany.UseVisualStyleBackColor = true;
            this.btnEnrollCompany.Click += new System.EventHandler(this.btnEnrollCompany_Click);
            // 
            // lblAreaMain
            // 
            this.lblAreaMain.AutoSize = true;
            this.lblAreaMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAreaMain.Location = new System.Drawing.Point(26, 45);
            this.lblAreaMain.Name = "lblAreaMain";
            this.lblAreaMain.Size = new System.Drawing.Size(63, 26);
            this.lblAreaMain.TabIndex = 2;
            this.lblAreaMain.Text = "Area(main) :";
            this.lblAreaMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCompanyName.Location = new System.Drawing.Point(95, 22);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(206, 20);
            this.tbCompanyName.TabIndex = 1;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCompanyName.Location = new System.Drawing.Point(3, 19);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(86, 26);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Company name :";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusCompany});
            this.statusStrip1.Location = new System.Drawing.Point(3, 183);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(384, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusCompany
            // 
            this.lblStatusCompany.Name = "lblStatusCompany";
            this.lblStatusCompany.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpEnrollCompany);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(398, 234);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // cbAreaMain
            // 
            this.cbAreaMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAreaMain.FormattingEnabled = true;
            this.cbAreaMain.Items.AddRange(new object[] {
            "서울",
            "대전",
            "부산",
            "창원",
            "광주"});
            this.cbAreaMain.Location = new System.Drawing.Point(95, 48);
            this.cbAreaMain.Name = "cbAreaMain";
            this.cbAreaMain.Size = new System.Drawing.Size(206, 21);
            this.cbAreaMain.TabIndex = 10;
            this.cbAreaMain.Text = "서울";
            // 
            // cbAreaSub
            // 
            this.cbAreaSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbAreaSub.FormattingEnabled = true;
            this.cbAreaSub.Items.AddRange(new object[] {
            "서울",
            "대전",
            "부산",
            "창원",
            "광주"});
            this.cbAreaSub.Location = new System.Drawing.Point(95, 74);
            this.cbAreaSub.Name = "cbAreaSub";
            this.cbAreaSub.Size = new System.Drawing.Size(206, 21);
            this.cbAreaSub.TabIndex = 11;
            this.cbAreaSub.Text = "서울";
            // 
            // frmEnroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 234);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmEnroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enroll";
            this.tpEnrollCompany.ResumeLayout(false);
            this.tpEnrollCompany.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpEnrollCompany;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusCompany;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.Label lblAreaMain;
        private System.Windows.Forms.Button btnEnrollCompany;
        private System.Windows.Forms.Label lblSalesManager;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAreaSub;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbAreaMain;
        private System.Windows.Forms.ComboBox cbAreaSub;
        private System.Windows.Forms.TabControl tabControl1;

    }
}