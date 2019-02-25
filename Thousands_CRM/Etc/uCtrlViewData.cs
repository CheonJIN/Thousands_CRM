using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Thousands_CRM.Etc
{
    public partial class uCtrlViewData : UserControl
    {
        //string[] defaultList = {"Manager name", "Company name", "Tel", "Mobile", "License count", "Lum target", "Dsls target", "Mac address", "ip", "host", "lan_card", "Explaration date", "Memo"};
        public static Dictionary<string, string> defaultList = new Dictionary<string,string>{{"Manager name", "l.manager_name"}, {"Company name", "c.name"}, {"Tel", "c.phone_number"}, {"Mobile", "c.mobile_number"}
        , {"License count", "l.lic_count"}, {"Lum target", "l.lum_target"}, {"Dsls target", "l.dsls_target"}, {"Mac address", "l.mac"}, {"IP", "l.ip"}, {"Host", "l.host"}, {"Lan card", "l.lan_card"}
        , {"Explaration date", "l.explaration_date"}, {"Memo", "l.memo"}};

        public uCtrlViewData()
        {
            InitializeComponent();
        }

        private void uCtrlViewData_Load(object sender, EventArgs e)
        {
            MySql mysql = MySql.Instance;
            string query = string.Format(@"SELECT view_data_check, view_data_delete FROM t_user WHERE id = '{0}'", User.userName);
            string viewDataCheck = mysql.Get_SqlQueryCol(query, "view_data_check");
            string viewDataDelete = mysql.Get_SqlQueryCol(query, "view_data_delete");

            if (string.IsNullOrEmpty(viewDataCheck))
            {
                btnReset_Click(null, null);
                return;
            }

            foreach(string s in viewDataCheck.Split(';'))
            {
                if (string.IsNullOrEmpty(s))
                {
                    continue;
                }

                lstCheckList.Items.Add(s);
            }

            foreach(string s in viewDataDelete.Split(';'))
            {
                if (string.IsNullOrEmpty(s))
                {
                    continue;
                }

                lstDeleteList.Items.Add(s);
            }
        }

        public object[] GetCheckListData()
        {
            object[] items = new object[lstCheckList.Items.Count];
            lstCheckList.Items.CopyTo(items, 0);

            return items;
        }

        public object[] GetDeleteListData()
        {
            object[] items = new object[lstCheckList.Items.Count];
            lstDeleteList.Items.CopyTo(items, 0);

            return items;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstCheckList.Items.Clear();
            lstDeleteList.Items.Clear();

            foreach(string s in defaultList.Keys)
            {
                lstCheckList.Items.Add(s);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstDeleteList.SelectedItem == null)
            {
                return;
            }

            lstCheckList.Items.Add(lstDeleteList.SelectedItem);
            lstDeleteList.Items.RemoveAt(lstDeleteList.SelectedIndex);

            try
            {
                lstCheckList.SelectedIndex = lstCheckList.Items.Count - 1;
                lstDeleteList.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lstCheckList.SelectedItem == null)
            {
                return;
            }

            lstDeleteList.Items.Add(lstCheckList.SelectedItem);
            lstCheckList.Items.RemoveAt(lstCheckList.SelectedIndex);

            try
            {
                lstDeleteList.SelectedIndex = lstDeleteList.Items.Count - 1;
                lstCheckList.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            MoveListItem(0);

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveListItem(1);
        }


        private void MoveListItem(int upDown)
        {
            if (lstCheckList.SelectedItem == null)
            {
                return;
            }

            int moveIndex = 1;
            int selListIndex = lstCheckList.SelectedIndex;
            object selListItem = lstCheckList.SelectedItem;

            if (upDown == 0)
            {
                moveIndex *= -1;
            }

            if (upDown == 0 && selListIndex == 0)
            {
                return;
            }

            if (upDown == 1 && selListIndex == lstCheckList.Items.Count - 1)
            {
                return;
            }

            lstCheckList.Items.RemoveAt(selListIndex);
            lstCheckList.Items.Insert(selListIndex + moveIndex, selListItem);
            lstCheckList.SelectedIndex = selListIndex + moveIndex;
        }
    }
}
