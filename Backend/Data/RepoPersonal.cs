using Backend.Models;
using MySql.Data.MySqlClient;

namespace Backend.Data
{
    public class RepoPersonal : DB_Conexion
    {
        public List<Personal> Mostrar()
        {
            List<Personal> personal = new List<Personal>();
            using (var connection = AbrirConexion())
            {
                using (var command = new MySqlCommand("SELECT * FROM personal", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            personal.Add(new Personal
                            {
                                _idPersonal = reader.GetInt32("id_personal"),
                                _idGrado = reader.GetInt32("id_grado"),
                                _nombre = reader.GetString("nombre"),
                                _segundoNombre = reader.GetString("segundo_nombre"),
                                _apellido = reader.GetString("apellido"),
                                _tipoDoc = reader.GetString("tipo_doc"),
                                _nroDoc = reader.GetInt32("nro_doc")
                            });
                        }
                    }
                }
            }
            return personal;
        }

        public bool Modificar(int idPersonal, int idGrado, string nombre, string segundoNombre, string apellido, string tipoDoc, int nroDoc)
        {
            using (var connection = AbrirConexion())
            {
                using (var command = new MySqlCommand("UPDATE personal SET id_grado = @idGrado, nombre = @nombre, segundo_nombre = @segundoNombre, apellido = @apellido, tipo_doc = @tipoDoc, nro_doc = @nroDoc", connection))
                {
                    command.Parameters.AddWithValue("@idGrado", idGrado);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@segundoNombre", segundoNombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@tipoDoc", tipoDoc);
                    command.Parameters.AddWithValue("@nroDoc", nroDoc);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (MySqlException ex)
                    {
                        Console.WriteLine($"Error al  modificar el personal: {ex.Message}");
                        return false;
                    }
                }
            }
            
        }


        public bool Eliminar(int idPersonal)
        {
            using (var connection = AbrirConexion())
            {
                using (var command = new MySqlCommand("DELETE FROM personal WHERE id_personal = @idPersonal", connection))
                {
                    command.Parameters.AddWithValue("@idPersonal", idPersonal);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch(MySqlException ex)
                    {
                        Console.WriteLine($"Error al Eliminar el personal: {ex.Message}");
                        return false;
                    }
                }
            }
        }
    }
}