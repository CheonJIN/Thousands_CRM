using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Thousands_CRM.Etc
{
    public partial class frmOption : Form
    {
        MySql mysql;

        public frmOption()
        {
            InitializeComponent();
        }

        private void frmOption_Load(object sender, EventArgs e)
        {
            mysql = MySql.Instance;

            string[] optionList = { "View data" };

            foreach (string s in optionList)
            {
                lstOptionList.Items.Add(s);
            }

            lstOptionList.SelectedIndex = 0;
        }

        private void frmOption_FormClosing(object sender, FormClosingEventArgs e)
        {
            uCtrlViewData uView = null;
            object[] ob1 = null;
            object[] ob2 = null;

            try
            {
                uView = (uCtrlViewData)panelUserCtrl.Controls["uCtrlViewData"];
                ob1 = uView.GetCheckListData();
                ob2 = uView.GetDeleteListData();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string checkData = Set_DataString(ob1);
            string deleteData = Set_DataString(ob2);

            string query = string.Format(@"UPDATE t_user SET view_data_check = '{0}' WHERE id = '{1}'", checkData, User.userName);
            mysql.Set_SqlQuery(query);

            query = string.Format(@"UPDATE t_user SET view_data_delete = '{0}' WHERE id = '{1}'", deleteData, User.userName);
            mysql.Set_SqlQuery(query);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panelUserCtrl.HasChildren)
            {
                panelUserCtrl.Controls.RemoveAt(0);
            }

            if (lstOptionList.SelectedItem == "View data")
            {
                Set_ViewdataPage();
            }
            else
            {
                
            }
        }

        private string Set_DataString(object[] ob)
        {
            string result = "";
            if (ob != null)
            {
                foreach(string s in ob)
                {
                    result += s + ";";
                }
            }

            return result;
        }

        private void Set_ViewdataPage()
        {
            uCtrlViewData uctrlViewData = new uCtrlViewData();
            panelUserCtrl.Controls.Add(uctrlViewData);
        }
    }
}
