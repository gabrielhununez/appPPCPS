using Backend.Models;
using MySql.Data.MySqlClient;

namespace Backend.Data
{
    public class RepoGrado : DB_Conexion
    {
        public List<Grado> Mostrar()
        {
            List<Grado> grados = new List<Grado>();
            using (var connection = AbrirConexion())
            {
                using (var command = new MySqlCommand("SELECT * FROM grado", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            grados.Add(new Grado
                            {
                                _IdGrado = reader.GetInt32("id_grado"),
                                _Abreviatura = reader.GetString("abreviatura"),
                                _GradoCompleto = reader.GetString("grado_completo")
                            });
                        }
                    }
                }
            }
            return grados;
        }

        public bool Eliminar(int idGrado)
        {
            using (var connection = AbrirConexion())
            {
                using (var command = new MySqlCommand("DELETE FROM grado WHERE id_grado = @idGrado", connection))
                {
                    command.Parameters.AddWithValue("@idGrado", idGrado);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Error al eliminar grado: {ex.Message}");
                        return false;
                    }
                }
            }
        }
    }
}