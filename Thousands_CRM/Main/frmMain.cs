using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Thousands_CRM.Main
{
    public partial class frmMain : Form
    {
        frmLogin loginForm;
        MySql SqlServer = MySql.Instance;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loginForm = new frmLogin();

            switch (loginForm.ShowDialog())
            {
                case DialogResult.OK:
                    loginForm.Close();
                    Get_Customer();
                    Init_RegWorkListView();
                    Init_RegisterWorkTab();
                    break;

                case DialogResult.Cancel:
                    Dispose();
                    break;
            }
        }

        private void enrollToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (Enroll.frmEnroll frm = new Enroll.frmEnroll())
            {
                frm.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search_Customer();
        }

        private void btnUserEnroll_Click(object sender, EventArgs e)
        {
            Insert_UserInfo();
        }

        private void btnRegModify_Click(object sender, EventArgs e)
        {
            Update_Work();
        }

        private void btnUserModify_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to modify it?", "Modify", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                Console.WriteLine("Cancel the modify");
                return;
            }

            Update_UserInfo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Insert_RegWork();
            reset_RegWork();
        }

        private void cbRegCompany_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegCusSearch_Click(object sender, EventArgs e)
        {
            using (Search.frmCustomerSearch frm = new Search.frmCustomerSearch(this))
            {
                frm.ShowDialog();
            }
        }

        private void dgvRegWorkData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;    
            }

            DataGridViewRow row = dgvRegWorkData.SelectedRows[0];
            View_LicenseData(row);
            View_WorkData(row);
        }

        private void dgvSupport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow row = dgvSupport.SelectedRows[0];

            View_WorkData(row);
        }

        private void btnUserExpDate_Click(object sender, EventArgs e)
        {
            using (Etc.frmCalendar frm = new Etc.frmCalendar(tbUserExpDate))
            {
                frm.ShowDialog();
            }
        }

        private void btnRegWorkDate_Click(object sender, EventArgs e)
        {
            using (Etc.frmCalendar frm = new Etc.frmCalendar(tbRegWorkDate))
            {
                frm.ShowDialog();
            }
        }

        private void btnTotalSearch_Click(object sender, EventArgs e)
        {
            using (Search.frmCustomerSearch frm = new Search.frmCustomerSearch(this))
            {
                frm.ShowDialog();
            }
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            string query = string.Format(@"SELECT R.guid as No, U.id as User, R.company_name as Company, R.support_type as Support_type, R.customer_name as Name FROM t_register_work as R INNER JOIN t_user as U WHERE R.company_name LIKE '%{0}%';", tbLookup.Text);

            dgvRegWorkData.DataSource = SqlServer.Get_DBTable(query);
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Etc.frmOption frm = new Etc.frmOption())
            {
                frm.ShowDialog();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tpLicenseList)
            {
                Set_LicenseData();
            }
            else if (tabControl1.SelectedTab == tpSupportList)
            {
                Set_SupportData();
            }
        }

        public void Set_Data(DataGridViewRow dataRow)
        {

        }

        public void Init_RegWorkListView(object dt = null)
        {
            if (dt != null)
            {
                dgvRegWorkData.DataSource = dt;
                return;
            }

            string query = @"SELECT R.guid as No, U.id as User, R.company_name as Company, R.support_type as Support_type, R.customer_name as Name FROM t_register_work as R INNER JOIN t_user as U;";
            dgvRegWorkData.DataSource = SqlServer.Get_DBTable(query);

            double colsSize = 0;
            foreach (DataGridViewColumn c in dgvRegWorkData.Columns)
            {
                colsSize += c.Width;
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void Init_RegisterWorkTab()
        {
            string query = @"SELECT * FROM t_company;";
            List<string> results = SqlServer.Get_ListString(query);

            foreach (string s in results)
            {
                cbRegCompany.Items.Add(s);
                cbUserCompany.Items.Add(s);
            }
            cbRegCompany.SelectedIndex = 0;

            tbRegWorkDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            tbUserExpDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        }

        private void reset_RegWork()
        {
            tbRegDepartment.Text = "";
            tbRegName.Text = "";
            tbRegRequest.Text = "";
            tbRegResponse.Text = "";
        }

        private void View_LicenseData(DataGridViewRow row)
        {
            string query = string.Format(@"SELECT l.ip, l.host, l.lum_target, l.dsls_target, l.mac, l.lic_count, l.explaration_date, l.lic_t, l.dsls_release, l.lan_card, l.solution, l.module, l.memo FROM t_lic_info as l WHERE l.manager_name = '{0}';"
                    , row.Cells[4].Value.ToString());

            tbUserIP.Text = SqlServer.Get_SqlQueryCol(query, "ip");
            tbUserHost.Text = SqlServer.Get_SqlQueryCol(query, "host");
            tbUserLumTarget.Text = SqlServer.Get_SqlQueryCol(query, "lum_target");
            tbUserDslsTarget.Text = SqlServer.Get_SqlQueryCol(query, "dsls_target");
            tbUserMac.Text = SqlServer.Get_SqlQueryCol(query, "mac");
            tbUserLicCount.Text = SqlServer.Get_SqlQueryCol(query, "lic_count");

            string date = SqlServer.Get_SqlQueryCol(query, "explaration_date");
            if (!string.IsNullOrEmpty(date))
            {
                DateTime d = Convert.ToDateTime(date);
                tbUserExpDate.Text = d.ToString("yyyy-MM-dd HH:mm");
            }
            else
            {
                tbUserExpDate.Text = date;
            }

            tbUserDslsRelease.Text = SqlServer.Get_SqlQueryCol(query, "dsls_release");
            tbUserMemo.Text = SqlServer.Get_SqlQueryCol(query, "memo");
            cbLanCard.Text = SqlServer.Get_SqlQueryCol(query, "lan_card");
            Set_SolutionData(SqlServer.Get_SqlQueryCol(query, "solution"));
            string lict = SqlServer.Get_SqlQueryCol(query, "lic_t");

            query = string.Format(@"SELECT name, company_name, mobile_number, phone_number, department, remote, tos, email FROM t_customer WHERE name = '{0}';"
                , row.Cells[4].Value.ToString());

            tbUserManager.Text = SqlServer.Get_SqlQueryCol(query, "name");
            tbUserMobile.Text = SqlServer.Get_SqlQueryCol(query, "mobile_number");
            tbUserTel.Text = SqlServer.Get_SqlQueryCol(query, "phone_number");
            tbUserDepartment.Text = SqlServer.Get_SqlQueryCol(query, "department");
            tbUserEmail.Text = SqlServer.Get_SqlQueryCol(query, "email");

            Set_radioValue(SqlServer.Get_SqlQueryCol(query, "remote"), SqlServer.Get_SqlQueryCol(query, "tos"), lict);
        }

        private void View_WorkData(DataGridViewRow row)
        {
            //string query = string.Format(@"SELECT * FROM t_register_work WHERE customer_name = '{0}' and work_date = '{1}'"
            //    , row.Cells[4].Value.ToString(), row.Cells[0].Value.ToString());
            string query = string.Format(@"SELECT r.company_name, r.customer_name, r.request, r.response, r.work_date, r.support_type, c.department FROM t_register_work as r INNER JOIN t_customer as c WHERE r.guid = '{0}';"
                , row.Cells[0].Value.ToString());

            tbRegName.Text = SqlServer.Get_SqlQueryCol(query, "customer_name");
            tbRegDepartment.Text = SqlServer.Get_SqlQueryCol(query, "department");
            tbRegRequest.Text = SqlServer.Get_SqlQueryCol(query, "department");
            tbRegResponse.Text = SqlServer.Get_SqlQueryCol(query, "response");
            tbRegWorkDate.Text = SqlServer.Get_SqlQueryCol(query, "work_date");
            cbRegCompany.Text = SqlServer.Get_SqlQueryCol(query, "company_name");
            cbRegSupportType.Text = SqlServer.Get_SqlQueryCol(query, "support_type");
        }

        private void Insert_RegWork()
        {
            string query = string.Format(@"INSERT INTO t_register_work VALUE('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');"
                , 0, cbRegCompany.SelectedItem, tbRegName.Text, tbRegRequest.Text, tbRegResponse.Text, tbRegWorkDate.Text, cbRegSupportType.Text, User.userName);

            if (SqlServer.Set_SqlQuery(query) == null)
            {
                return;
            }
        }

        private void Insert_UserInfo()
        {
            string[] radioValue = Get_radioValue();
            string checkValues = Get_SolutionData();

            string query = string.Format(@"INSERT INTO t_lic_info VALUE ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}');"
            , tbUserManager.Text, tbUserIP.Text, tbUserHost.Text, tbUserLumTarget.Text, tbUserDslsTarget.Text, tbUserMac.Text, tbUserLicCount.Text, tbUserExpDate.Text, radioValue[2], tbUserDslsRelease.Text
            , cbLanCard.SelectedItem, checkValues, tbUserModule.Text, tbUserMemo.Text);

            if (SqlServer.Set_SqlQuery(query) == null)
            {
                return;
            }
            
            query = string.Format(@"INSERT INTO t_customer VALUE('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');"
            , cbUserCompany.Text, tbUserManager.Text, tbUserMobile.Text, tbUserTel.Text, tbUserDepartment.Text, radioValue[0], radioValue[1], tbUserEmail.Text);

            if (SqlServer.Set_SqlQuery(query) == null)
            {
                return;
            }

            lblState.Text = "Success a Enroll";
        }

        private void Update_UserInfo()
        {
            string[] radioValues = Get_radioValue();
            string solution = Get_SolutionData();

            string query = string.Format(@"UPDATE t_lic_info SET ip = '{0}', host = '{1}', lum_target = '{2}', dsls_target = '{3}', mac = '{4}', lic_count = '{5}', explaration_date = '{6}', lic_t = '{7}', dsls_release = '{8}', lan_card = '{9}', solution = '{10}', module = '{11}', memo = '{12}' WHERE manager_name = '{13}';"
                , tbUserIP.Text, tbUserHost.Text, tbUserLumTarget.Text, tbUserDslsTarget.Text, tbUserMac.Text, tbUserLicCount.Text, tbUserExpDate.Text, radioValues[2], tbUserDslsRelease.Text
                , cbLanCard.Text, solution, tbUserMobile.Text, tbUserMemo.Text, tbUserManager.Text);

            if (SqlServer.Set_SqlQuery(query) == null)
            {
                return;
            }

            query = string.Format(@"UPDATE t_customer SET mobile_number = '{0}', phone_number = '{1}', department = '{2}', remote = '{3}', tos = '{4}', email = '{5}', company_name = '{6}' WHERE name = '{7}';"
                , tbUserMobile.Text, tbUserTel.Text, tbUserDepartment.Text, radioValues[0], radioValues[1], tbUserEmail.Text, cbUserCompany.Text, tbUserManager.Text);

            if (SqlServer.Set_SqlQuery(query) == null)
            {
                return;
            }
        }

        private void Update_Work()
        {
            
        }

        private void Set_LicenseData()
        {
            string query = string.Format(@"SELECT view_data_check, view_data_delete FROM t_user WHERE id = '{0}'", User.userName);
            string viewDataCheck = SqlServer.Get_SqlQueryCol(query, "view_data_check");
            string value = "";
            string tempSql = "";

            string[] spViewDataCheck = viewDataCheck.Split(';');

            for (int i = 0; i < spViewDataCheck.Length; i++)
            {
                if (string.IsNullOrEmpty(spViewDataCheck[i]))
                {
                    continue;
                }

                value = Etc.uCtrlViewData.defaultList[spViewDataCheck[i]];
                tempSql += value;

                if (spViewDataCheck.Length - 2 > i)
                {
                    tempSql += ", ";
                }
            }

            query = string.Format(@"SELECT {0} FROM t_lic_info as l INNER JOIN t_customer as c WHERE l.manager_name = c.name;", tempSql);

            DataTable dt = SqlServer.Get_DBTable(query);
            dgvLicense.DataSource = dt;
        }

        private void Set_SupportData()
        {
            string query = string.Format(@"SELECT guid, work_date, support_type, user, company_name, customer_name, request, response FROM t_register_work");
            DataTable dt = SqlServer.Get_DBTable(query);
            dgvSupport.DataSource = dt;

            dgvSupport.AutoResizeColumns();
        }

        private string[] Get_radioValue()
        {
            string[] result = new string[3];
            if      (rbRemoteYes.Checked)   {result[0] = "Yes";}
            else if (rbRemoteYesR.Checked)  {result[0] = "YseR";}
            else                            {result[0] = "No";}

            if (rbUserTosYes.Checked)   { result[1] = "Yes"; }
            else                    { result[1] = "No"; }

            if (rbLicN.Checked)   { result[2] = "N"; }
            else                  { result[2] = "S"; }

            return result;
        }

        private string Get_SolutionData()
        {
            string result = "";

            foreach(CheckBox c in gbSolution.Controls)
            {
                if (c.Checked)
                {
                    result += c.Text + ";";
                }
            }

            return result;
        }

        private void Set_radioValue(string remote, string tos, string licN)
        {
            if (!string.IsNullOrEmpty(remote))
            {
                if (remote == "Yes") { rbRemoteYes.Checked = true; }
                else if (remote == "YesR") { rbRemoteYesR.Checked = true; }
                else { rbRemoteNo.Checked = true; }
            }

            if (!string.IsNullOrEmpty(tos))
            {
                if (tos == "Yes") { rbUserTosYes.Checked = true; }
                else { rbUserTosNo.Checked = true; }
            }

            if (!string.IsNullOrEmpty(licN))
            {
                if (licN == "N") { rbLicN.Checked = true; }
                else { rbLicS.Checked = true; }
            }
        }

        private void Set_SolutionData(string solution)
        {
            foreach(CheckBox c in gbSolution.Controls)
            {
                if (solution.Contains(c.Text))
                {
                    c.Checked = true;
                }
                else
                {
                    c.Checked = false;
                }
            }
        }

        private void Get_Customer()
        {
            string query = @"SELECT c1.name as company, c2.name, c2.department, c2.mobile_number, c2.phone_number FROM t_company as c1 INNER JOIN t_customer as c2 ON c1.name = c2.company_name";
            DataTable dt = SqlServer.Get_DBTable(query);
            dgvCustomers.DataSource = dt;
        }

        private void Search_Customer()
        {
            string whereSQL = "";

            if (!string.IsNullOrEmpty(tbCompany.Text))
            {
                if (!string.IsNullOrEmpty(whereSQL))
                {
                    whereSQL += string.Format(@" and c1.name LIKE '%{0}%'", tbCompany.Text);
                }
                else
                {
                    whereSQL = string.Format(@"c1.name LIKE '%{0}%'", tbCompany.Text);
                }
            }

            if (!string.IsNullOrEmpty(tbCustomerName.Text))
            {
                if (!string.IsNullOrEmpty(whereSQL))
                {
                    whereSQL += string.Format(@" and c2.name LIKE '%{0}%'", tbCustomerName.Text);
                }
                else
                {
                    whereSQL = string.Format(@"c2.name LIKE '%{0}%'", tbCustomerName.Text);
                }
            }

            if (!string.IsNullOrEmpty(tbMobileNumber.Text))
            {
                if (!string.IsNullOrEmpty(whereSQL))
                {
                    whereSQL += string.Format(@" and c2.mobile_number = '{0}'", tbMobileNumber.Text);
                }
                else
                {
                    whereSQL = string.Format(@"c2.mobile_number = '{0}'", tbMobileNumber.Text);
                }
            }

            string query = "";
            if (string.IsNullOrEmpty(whereSQL))
            {
                query = @"SELECT c1.name as Company, c2.name, c2.department, c2.mobile_number, c2.phone_number FROM t_company as c1 INNER JOIN t_customer as c2 ON c1.name = c2.company_name";
            }
            else
            {
                query = string.Format("SELECT c1.name as Company, c2.name, c2.department, c2.mobile_number, c2.phone_number FROM t_company as c1 INNER JOIN t_customer as c2 ON c1.name = c2.company_name WHERE {0}", whereSQL);
            }

            DataTable dt = SqlServer.Get_DBTable(query);
            dgvCustomers.DataSource = dt;
        }

        private void tpCustomers_Click(object sender, EventArgs e)
        {

        }
    }
}
