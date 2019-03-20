using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace Library
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            string connStr = "server=localhost;user=root;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string s0 = "CREATE DATABASE IF NOT EXISTS `public_library`";
                MySqlCommand cmd = new MySqlCommand(s0,conn);
                cmd.ExecuteNonQuery();
                // Perform database operations

                Console.WriteLine("Disconnecting MySQL...");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
    }
}
