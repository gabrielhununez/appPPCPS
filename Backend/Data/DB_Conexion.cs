using MySql.Data.MySqlClient;

namespace Backend.Data
{
    public class DB_Conexion
    {
        private string connectionString = "server=localhost; database=db_app_cps; user=root; password=;";

        public MySqlConnection AbrirConexion()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}