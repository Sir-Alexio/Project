using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Model
{
    public  class Connection
    {
        private static MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=mysql;database=mydata ");
        public static  void  openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public static void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public static MySqlConnection genConnection()
        {
            return connection;
        }

    }
}
