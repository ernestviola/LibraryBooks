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
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string s0 = "CREATE DATABASE IF NOT EXIST `public_library`";
                MySqlCommand cmd = new MySqlCommand(s0,conn);
                cmd.BeginExecuteNonQuery();
                conn.Close();


            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("Disconnecting MySQL...");
            conn.Close();
            Console.WriteLine("Done.");


        }
    }
}
