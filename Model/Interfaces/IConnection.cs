using MySql.Data.MySqlClient;

namespace Model
{
    public interface IConnection
    {
        void openConnection();
        void closeConnection();
        MySqlConnection getConnection();
    }
}
