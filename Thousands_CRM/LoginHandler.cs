using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Thousands_CRM
{
    class LoginHandler
    {
        public bool LoginCheck(string id, string password)
        {
            string server = "localhost";
            string database = "thousands_crm_db";
            string userID = "root";
            string pwd = "akwldrkz!23";

            MySql mysql = MySql.Instance;
            if(!mysql.Connect_Server(server, database, userID, pwd))
            {
                return false;
            }

            string query = string.Format("SELECT id, password FROM t_user WHERE id = '{0}'", id);
            MySqlCommand cmd = mysql.Set_SqlQuery(query);
            string result = mysql.Data_Reader(cmd.ExecuteReader(), "password");

            if (result != password)
            {
                return false;
            }

            return true;
        }
    }
}
