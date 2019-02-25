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

                        query = string.Format("INSERT INTO t_company(name, area_main, area_sub) VALUES('{0}', '{1}', '{2}');", tbCompanyName.Text, cbAreaMain.Text, cbAreaSub.Text);
                        mysql.Set_SqlQuery(query);
                        lblStatusCompany.Text = string.Format("Finished enroll the '{0}'...", tbCompanyName.Text);
                        tbCompanyName.Text = "";

                        Console.WriteLine("Insert a data in t_company");
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
                    
                    break;
            }

            return true;
        }

        private void tpEnrollCustomer_Click(object sender, EventArgs e)
        {

        }


    }
}
