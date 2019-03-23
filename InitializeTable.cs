using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;
namespace Library
{
    public class InitializeTable
    {
        public InitializeTable(MySqlConnection conn)
        {
            try
            {
                string s0 = "CREATE TABLE IF NOT EXIST books(" +
                "books_id int auto_increment," +
                "title varchar(255) not null," +
                "author varchar(255) not null" +
                "PRIMARY KEY(books_id);";
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }



        }
    }
}
