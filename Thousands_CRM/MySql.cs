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
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        public void Close_Database()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        public MySqlCommand Set_SqlQuery(string query)
        {
            if (Connection == null)
            {
                return null;
            }

            Open_Database();
            MySqlCommand cmd = null;
            try
            {
                cmd = new MySqlCommand(query, Connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Close_Database();

            return cmd;
        }

        public string Get_SqlQueryCol(string query, string colName)
        {
            string result = "";

            try
            {
                //MySqlCommand cmd = Set_SqlQuery(query);
                Open_Database();
                MySqlCommand cmd = new MySqlCommand(query, Connection);
                // result = Data_Reader(cmd.ExecuteReader(), colName);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result = reader[colName].ToString();
                }
                Close_Database();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }

        public DataSet Get_DataSet(string query)
        {
            return MySqlHelper.ExecuteDataset(Connection, query);
        }

        public DataTable Get_DBTable(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, Connection);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public List<string> Get_ListString(string query)
        {
            MySqlCommand cmd = Set_SqlQuery(query);

            Open_Database();
            List<string> results = Data_Reader_all(cmd.ExecuteReader());
            Close_Database();

            return results;
        }

        public List<string> Data_Reader_all(MySqlDataReader dataReader)
        {
            List<string> result = new List<string>();

            MySqlDataReader reader = dataReader;
            Open_Database();
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

            Close_Database();

            return result;
        }

        public string Data_Reader(MySqlDataReader dataReader, string column_name)
        {
            string result = "";

            MySqlDataReader reader = dataReader;
            //Open_Database();
            try
            {
                while (reader.Read())
                {
                    result = reader[column_name].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Close_Database();

            return result;
        }
    }
}
