using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Enroll_Data(ENROLL_TYPE etype)
        {
            MySql mysql = MySql.Instance;
            string query = "";

            try
            {
                switch (etype)
                {
                    case ENROLL_TYPE.COMPANY:
                        query = string.Format("INSERT INTO t_company(name, area) VALUES('{0}', '{1}');", tbCompanyName.Text, tbArea.Text);
                        mysql.Set_SqlQuery(query);
                        Console.WriteLine("Insert a data in t_company");
                        break;

                    case ENROLL_TYPE.CUSTOMER:
                        query = string.Format("INSERT INTO t_customer VALUES ('{0}', '{1}', '{2}');", tbCustomerName.Text, tbMobileNumber.Text, tbPhoneNumber.Text);
                        mysql.Set_SqlQuery(query);
                        Console.WriteLine("insert a data in t_customer");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
