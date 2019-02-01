using System;
using System.Linq;
using System.Windows.Forms;

namespace Thousands_CRM.Etc
{
    public partial class frmCalendar : Form
    {
        private TextBox _tbDate;

        public frmCalendar(TextBox tbDate)
        {
            InitializeComponent();

            _tbDate = tbDate;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _tbDate.Text = string.Concat(this.monthCalendar1.SelectionStart.ToShortDateString(), DateTime.Now.ToString(" HH:mm"));
            this.Close();
        }
    }
}
