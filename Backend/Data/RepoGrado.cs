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
                                _idGrado = reader.GetInt32("id_grado"),
                                _abreviatura = reader.GetString("abreviatura"),
                                _gradoCompleto = reader.GetString("grado_completo")
                            });
                        }
                    }
                }
            }
            return grados;
        }

        public bool Insertar(int idGrado, string abreviatura, string gradoCompleto)
        {
            using (var connection = AbrirConexion())
            {
                using (var command = new MySqlCommand("INSERT INTO grado (abreviatura, grado_completo) VALUES (@abreviatura, '@gradoCompleto') WHERE id_grado = @idGrado", connection))
                {
                    command.Parameters.AddWithValue("@idGrado", idGrado);
                    command.Parameters.AddWithValue("@abreviatura", abreviatura);
                    command.Parameters.AddWithValue("@gradoCompleto", gradoCompleto);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Error al modificar grado: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        public bool Modificar(int idGrado, string abreviatura, string gradoCompleto)
        {
            using (var connection = AbrirConexion())
            {
                using (var command = new MySqlCommand("UPDATE grado SET abreviatura = @abreviatura, grado_completo = @grado_completo WHERE id_grado = @idGrado", connection))
                {
                    command.Parameters.AddWithValue("@idGrado", idGrado);
                    command.Parameters.AddWithValue("@abreviatura", abreviatura);
                    command.Parameters.AddWithValue("@gradoCompleto", gradoCompleto);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Error al modificar grado: {ex.Message}");
                        return false;
                    }
                }
            }
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