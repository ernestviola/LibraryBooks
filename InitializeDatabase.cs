using System;

using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Library
{
    public class InitializeDatabase
    {
        public InitializeDatabase()
        {
            string connStr = "server=localhost;user=root;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                string s0 = "CREATE DATABASE IF NOT EXIST `public_library`";
                MySqlCommand cmd = new MySqlCommand(s0);
                cmd.BeginExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
