using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thousands_CRM.Main
{
    public partial class frmMain : Form
    {
        frmLogin loginForm;

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
                    break;
                case DialogResult.Cancel:
                    Dispose();
                    break;
            }

            Get_Customer();
        }

        private void enrollToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (Enroll.frmEnroll frm = new Enroll.frmEnroll())
            {
                frm.ShowDialog();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tpCustomers)
            {
                Get_Customer();
            }
        }

        private void Get_Customer()
        {
            string query = string.Format("SELECT * FROM t_customer");
            MySql mysql = MySql.Instance;
            DataTable dt = mysql.Get_DBTable(query);
            dgvCustomers.DataSource = dt;
        }
    }
}
