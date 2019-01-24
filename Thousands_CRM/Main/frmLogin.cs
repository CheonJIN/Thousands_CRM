using System;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Thousands_CRM
{
    public delegate void EventHandeler(string userName);

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginHandler loginHandler = new LoginHandler();
            if (Check_Control())
            {
                if (loginHandler.LoginCheck(tbUserID.Text, tbPassword.Text))
                {
                    string userName = tbUserID.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("로그인 정보가 정확하지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbPassword.Clear();
                }
            }

            Console.WriteLine(string.Format("ID : {0} , 접속", tbUserID.Text));
        }

        private bool Check_Control()
        {
            if (string.IsNullOrEmpty(tbUserID.Text))
            {
                tbUserID.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(tbPassword.Text))
            {
                tbPassword.Focus();
                return false;
            }

            return true;
        }
    }
}
