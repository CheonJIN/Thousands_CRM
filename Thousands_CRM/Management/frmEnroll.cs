using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Thousands_CRM.Enroll
{
    enum ENROLL_TYPE
    {
        COMPANY,
        CUSTOMER
    }

    public partial class frmEnroll : Form
    {
        public frmEnroll()
        {
            InitializeComponent();
        }

        private void btnEnrollCompany_Click(object sender, EventArgs e)
        {
            Enroll_Data(ENROLL_TYPE.COMPANY);
        }

        private void btnEnrollCustomer_Click(object sender, EventArgs e)
        {
            Enroll_Data(ENROLL_TYPE.CUSTOMER);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tpEnrollCustomer)
            {
                if (cbCompany.Items.Count != 0)
                {
                    return;
                }

                lblStatusCompany.Text = "";
                lblStatusCustomer.Text = "";

                List<string> results = Set_ComboItemsByCompany();

                foreach(string s in results)
                {
                    cbCompany.Items.Add(s);
                }
                cbCompany.SelectedIndex = 0;
            }
        }

        public List<string> Set_ComboItemsByCompany()
        {
            MySql mysql = MySql.Instance;
            string query = string.Format("SELECT name FROM t_company");
            MySqlCommand cmd = mysql.Set_SqlQuery(query);
            List<string> results = mysql.Data_Reader_all(cmd.ExecuteReader());

            return results;
        }

        private void Enroll_Data(ENROLL_TYPE etype)
        {
            MySql mysql = MySql.Instance;
            string query = "";

            try
            {
                switch (etype)
                {
                    case ENROLL_TYPE.COMPANY:
                        if (!Check_Control(ENROLL_TYPE.COMPANY))
                        {
                            return;
                        }
                        query = string.Format("INSERT INTO t_company(name, area) VALUES('{0}', '{1}');", tbCompanyName.Text, tbArea.Text);
                        mysql.Set_SqlQuery(query);
                        lblStatusCompany.Text = string.Format("Finished enroll the '{0}'...", tbCompanyName.Text);
                        tbCompanyName.Text = "";
                        tbArea.Text = "";
                        Console.WriteLine("Insert a data in t_company");
                        break;

                    case ENROLL_TYPE.CUSTOMER:
                        if (!Check_Control(ENROLL_TYPE.CUSTOMER))
                        {
                            return;
                        }
                        query = string.Format("INSERT INTO t_customer VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');", cbCompany.SelectedItem, tbCustomerName.Text, tbMobileNumber.Text, tbPhoneNumber.Text, tbDepartment.Text);
                        mysql.Set_SqlQuery(query);
                        lblStatusCustomer.Text = string.Format("Finished enroll the '{0}'...", tbCustomerName.Text);
                        tbCustomerName.Text = "";
                        tbMobileNumber.Text = "";
                        Console.WriteLine("insert a data in t_customer");
                        break;
                }
            }
            catch (MySqlException)
            {
                if (etype == ENROLL_TYPE.COMPANY)
                {
                    MessageBox.Show(string.Format("'{0}'은(는) 이미 등록 되어있습니다.", tbCompanyName.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool Check_Control(ENROLL_TYPE type)
        {
            switch (type)
            {
                case ENROLL_TYPE.COMPANY:
                    if (string.IsNullOrEmpty(tbCompanyName.Text))
                    {
                        tbCompanyName.Focus();
                        return false;
                    }
                    else if (string.IsNullOrEmpty(tbArea.Text))
                    {
                        tbArea.Focus();
                        return false;
                    }
                    break;

                case ENROLL_TYPE.CUSTOMER:
                    if (string.IsNullOrEmpty(tbCustomerName.Text))
                    {
                        tbCustomerName.Focus();
                        return false;
                    }
                    else if (string.IsNullOrEmpty(tbMobileNumber.Text))
                    {
                        tbMobileNumber.Focus();
                        return false;
                    }
                    break;
            }

            return true;
        }

        private void tpEnrollCustomer_Click(object sender, EventArgs e)
        {

        }


    }
}
