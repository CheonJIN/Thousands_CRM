using System;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Thousands_CRM
{
    public class MySql : Singleton<MySql>
    {
        MySqlConnection Connection;

        public MySql()
        {
            
        }

        public bool Connect_Server(string server, string database_name, string u_id, string password)
        {
            string connect_info = string.Format("Server={0};Database={1};Uid={2};Pwd={3};", server, database_name, u_id, password);
            try
            {
                Connection = new MySqlConnection(connect_info);
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                }
                else
                {
                    Connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        //public MySqlCommand Get_Login(string id, string pwd)
        public MySqlCommand Set_SqlQuery(string query)
        {
            if (Connection == null)
            {
                return null;
            }

            MySqlCommand cmd = new MySqlCommand(query, Connection);

            return cmd;
        }

        public string Data_Reader(MySqlDataReader dataReader, string column_name)
        {
            string result = "";

            MySqlDataReader reader = dataReader;

            try
            {
                while(reader.Read())
                {
                    result = (string)reader[column_name];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }
    }
}
