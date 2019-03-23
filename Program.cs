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
            new InitializeDatabase();
        }
    }
}
