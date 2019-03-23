using System;

using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Library
{
    public class InitializeDatabase
    {
        private MySqlConnection conn = null;


        public InitializeDatabase(string database)
        {
            string connStr = "server=localhost;user=root;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                
                string s0 = string.Format("CREATE DATABASE IF NOT EXIST `{0}`",database);
                MySqlCommand cmd = new MySqlCommand(s0,conn);
                cmd.BeginExecuteNonQuery();
                conn.ChangeDatabase(database);


            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }


        }


        public MySqlConnection GetConnection()
        {
            return conn;
        }


    }
}
