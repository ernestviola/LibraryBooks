using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

using System.Collections.Generic;

namespace Library
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string database = "library_books";
            MySqlConnection conn = new InitializeDatabase(database).GetConnection();
            conn.ChangeDatabase(database);
            Console.WriteLine("Disconnecting Database & Mysql...{0}",database);
            conn.Close();
            Console.WriteLine("Done.");

        }


        static DateTime GetTomorrow()
        {
            DateTime dt = DateTime.Now;
            return dt.AddDays(20);

        }

        static bool TT<T>(T t)
        {
            return typeof(T) != t.GetType();
        }
    }
}
