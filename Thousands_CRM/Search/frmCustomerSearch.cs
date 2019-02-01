using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Thousands_CRM.Search
{
    public partial class frmCustomerSearch : Form
    {
        Main.frmMain frmMain;

        public frmCustomerSearch(Main.frmMain main)
        {
            InitializeComponent();

            frmMain = main;
        }

        private void frmCustomerSearch_Load(object sender, EventArgs e)
        {
            Get_Customer();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search_Customer();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow selRow = dgvCustomers.SelectedRows[0];
            frmMain.Set_Data(selRow);
            frmMain.Init_RegWorkListView();
            this.Close();
        }

        private void Get_Customer()
        {
            //string query = string.Format(@"SELECT * FROM t_customer");
            string query = @"SELECT c1.name as company, c1.area, c2.name, c2.department, c2.mobile_number, c2.phone_number FROM t_company as c1 INNER JOIN t_customer as c2 ON c1.name = c2.company_name";
            MySql mysql = MySql.Instance;
            DataTable dt = mysql.Get_DBTable(query);
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

            MySql mysql = MySql.Instance;
            DataTable dt = mysql.Get_DBTable(query);
            dgvCustomers.DataSource = dt;
        }
    }
}
