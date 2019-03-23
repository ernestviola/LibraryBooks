using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;
namespace Library
{
    public class InitializeTable
    {
        public InitializeTable()
        {
            string connStr = "database=library_books;server=localhost;" +
            	"user=root;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);

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
