using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Model
{
    public class DataAccess
    {
        Connection connection = new Connection();

        DataTable table = new DataTable();

        MySqlDataAdapter adapter = new MySqlDataAdapter();

        MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `patients`");
    }
}
