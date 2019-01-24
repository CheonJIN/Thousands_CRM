using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Thousands_CRM
{
    public class MySql : Singleton<MySql>
    {
        MySqlConnection Connection;

        public bool Connect_Server(string server, string database_name, string u_id, string password)
        {
            string connect_info = string.Format("Server={0};Database={1};Uid={2};Pwd={3};", server, database_name, u_id, password);
            try
            {
                Connection = new MySqlConnection(connect_info);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        public void Open_Database()
        {
            if (Connection != null)
            {
                Connection.Close();
            }
        }

        public void Close_Database()
        {
            if (Connection != null)
            {
                Connection.Close();
            }
        }

        //public MySqlCommand Get_Login(string id, string pwd)
        public MySqlCommand Set_SqlQuery(string query)
        {
            if (Connection == null)
            {
                return null;
            }

            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(query, Connection);
            cmd.ExecuteNonQuery();

            return cmd;
        }

        public DataTable Get_DBTable(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, Connection);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public List<string> Data_Reader_all(MySqlDataReader dataReader)
        {
            List<string> result = new List<string>();

            MySqlDataReader reader = dataReader;

            try
            {
                while(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        result.Add(reader.GetString(0));
                    }

                    reader.NextResult();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Connection.Close();

            return result;
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

            Connection.Close();

            return result;
        }
    }
}
