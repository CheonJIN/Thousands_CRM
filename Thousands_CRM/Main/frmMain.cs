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
                    break;

                case DialogResult.Cancel:
                    Dispose();
                    break;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tpRegisterWork)
            {
                Init_RegisterWorkTab();
                Init_RegWorkListView();
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

        private void btnOpenCalendar_Click(object sender, EventArgs e)
        {
            using (Etc.frmCalendar frm = new Etc.frmCalendar(tbRegWorkDate))
            {
                frm.ShowDialog();
            }
        }

        private void btnRegEnroll_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbRegWorkDate.Text) && string.IsNullOrEmpty(tbRegName.Text) && string.IsNullOrEmpty(cbRegCompany.SelectedText))
            {
                return;
            }

            Insert_Work();
        }

        private void cbRegCompany_SelectedValueChanged(object sender, EventArgs e)
        {
            string query = string.Format(@"SELECT area FROM t_company WHERE name = '{0}'", cbRegCompany.SelectedItem);

            tbRegArea.Text = SqlServer.Get_ListString(query)[0];
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
            View_WorkData();
        }

        public void Set_Data(DataGridViewRow dataRow)
        {
            cbRegCompany.Text = dataRow.Cells[0].Value.ToString();
            tbRegArea.Text = dataRow.Cells[1].Value.ToString();
            tbRegName.Text = dataRow.Cells[2].Value.ToString();
            tbRegDepartment.Text = dataRow.Cells[3].Value.ToString();
            tbRegMobile.Text = dataRow.Cells[4].Value.ToString();
        }

        public void Init_RegWorkListView()
        {
            string query = @"SELECT guid as No, company_name as Cor, division as Division, customer_name as Name FROM t_register_work;";
            dgvRegWorkData.DataSource = SqlServer.Get_DBTable(query);

            double colsSize = 0;
            foreach (DataGridViewColumn c in dgvRegWorkData.Columns)
            {
                colsSize += c.Width;
            }

            splitContainer1.SplitterDistance = Convert.ToInt16(colsSize);
        }

        private void Init_RegisterWorkTab()
        {
            string query = @"SELECT * FROM t_company;";
            List<string> results = SqlServer.Get_ListString(query);

            foreach (string s in results)
            {
                cbRegCompany.Items.Add(s);
            }
            cbRegCompany.SelectedIndex = 0;

            tbRegWorkDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            cbRegDivision.Items.Add(DIVISION.SUPPORT.ToString());
            cbRegDivision.Items.Add(DIVISION.LICENSE.ToString());
            cbRegDivision.Items.Add(DIVISION.QUESTION.ToString());
            cbRegDivision.SelectedIndex = 0;

            tbRegWorkDate.Focus();
        }

        private void View_WorkData()
        {
            if (dgvRegWorkData.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvRegWorkData.SelectedRows)
            {
                string query = string.Format(@"SELECT r.company_name, r.customer_name, r.memo, r.request, r.response, r.work_date, r.division, c.department, c.mobile_number, c.phone_number FROM t_register_work as r
                                            INNER JOIN t_customer as c
                                            WHERE guid = {0} and r.customer_name = '{1}';"
                                            , row.Cells[0].Value.ToString(), row.Cells[3].Value.ToString());
                //DataTable dt = SqlServer.Get_DBTable(query);
                //List<string> workData = SqlServer.Get_ListString(query);
                //DataSet ds = SqlServer.Get_DataSet(query);
                MySqlCommand mycmd = SqlServer.Set_SqlQuery(query);
                cbRegCompany.Text = SqlServer.Data_Reader(mycmd.ExecuteReader(), "company_name");
                SqlServer.Open_Database();
                tbRegName.Text = SqlServer.Data_Reader(mycmd.ExecuteReader(), "customer_name");
                SqlServer.Open_Database();
                tbRegMemo.Text = SqlServer.Data_Reader(mycmd.ExecuteReader(), "memo");
                SqlServer.Open_Database();
                tbRegRequest.Text = SqlServer.Data_Reader(mycmd.ExecuteReader(), "request");
                SqlServer.Open_Database();
                tbRegRespense.Text = SqlServer.Data_Reader(mycmd.ExecuteReader(), "response");
                SqlServer.Open_Database();
                tbRegMobile.Text = SqlServer.Data_Reader(mycmd.ExecuteReader(), "mobile_number");
                SqlServer.Open_Database();
                tbRegTel.Text = SqlServer.Data_Reader(mycmd.ExecuteReader(), "phone_number");
                SqlServer.Open_Database();
                tbRegWorkDate.Text = SqlServer.Data_Reader(mycmd.ExecuteReader(), "work_date");
            }
        }

        private void Insert_Work()
        {
            string query = string.Format(@"INSERT INTO t_register_work VALUE('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
                0, cbRegCompany.SelectedItem, tbRegName.Text, tbRegMemo.Text, tbRegRequest.Text, tbRegRespense.Text, tbRegWorkDate.Text, cbRegDivision.SelectedItem);

            if (SqlServer.Set_SqlQuery(query) == null)
            {
                return;
            }

            query = string.Format(@"INSERT INTO t_customer VALUE('{0}', '{1}', '{2}', '{3}', '{4}');",
                cbRegCompany.Text, tbRegName.Text, tbRegMobile.Text, tbRegTel.Text, tbRegDepartment.Text);

            if (SqlServer.Set_SqlQuery(query) == null)
            {
                return;
            }
        }

        private void Get_Customer()
        {
            //string query = string.Format(@"SELECT * FROM t_customer");
            string query = @"SELECT c1.name as company, c1.area, c2.name, c2.department, c2.mobile_number, c2.phone_number FROM t_company as c1 INNER JOIN t_customer as c2 ON c1.name = c2.company_name";
            DataTable dt = SqlServer.Get_DBTable(query);
            dgvCustomers.DataSource = dt;
        }

        private void Search_Customer()
        {
            string whereSQL = "";

            if (!string.IsNullOrEmpty(tbArea.Text))
            {
                whereSQL = string.Format("c1.area = '{0}'", tbArea.Text);
            }

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
                query = @"SELECT c1.name as Company, c1.area, c2.name, c2.department, c2.mobile_number, c2.phone_number FROM t_company as c1 INNER JOIN t_customer as c2 ON c1.name = c2.company_name";
            }
            else
            {
                query = string.Format("SELECT c1.name as Company, c1.area, c2.name, c2.department, c2.mobile_number, c2.phone_number FROM t_company as c1 INNER JOIN t_customer as c2 ON c1.name = c2.company_name WHERE {0}", whereSQL);
            }

            DataTable dt = SqlServer.Get_DBTable(query);
            dgvCustomers.DataSource = dt;
        }




    }
}
