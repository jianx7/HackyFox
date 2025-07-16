using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HackyFox.Clases
{
    public static class AliasDB
    {
        private static readonly string cadenaConexion = "server=localhost;username=root;password=1234;database=hackyfox";

        //Verifica si un alias ya está registrado
        public static bool ExisteAlias(string alias)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string query = "SELECT COUNT(*) FROM alias WHERE LOWER(alias) = LOWER(@alias)";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@alias", alias);
                int count = Convert.ToInt32(comando.ExecuteScalar());
                return count > 0;
            }
        }

        //Crea un nuevo alias con su fecha de nacimiento
        public static int RegistrarAlias(string alias, DateTime fechaNacimiento)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();

                string fechaActual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                string insertQuery = @"INSERT INTO alias (fecha_nacimiento, alias, created_at, updated_at) 
                                       VALUES (@fechaNacimiento, @alias, @createdAt, @updatedAt)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conexion);
                insertCmd.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento.ToString("yyyy-MM-dd"));
                insertCmd.Parameters.AddWithValue("@alias", alias);
                insertCmd.Parameters.AddWithValue("@createdAt", fechaActual);
                insertCmd.Parameters.AddWithValue("@updatedAt", fechaActual);

                insertCmd.ExecuteNonQuery();

                string idQuery = "SELECT id_alias FROM alias WHERE alias = @alias LIMIT 1;";
                MySqlCommand idCmd = new MySqlCommand(idQuery, conexion);
                idCmd.Parameters.AddWithValue("@alias", alias);
                return Convert.ToInt32(idCmd.ExecuteScalar());
            }
        }

        //Recupera el ID de un alias existente
        public static int ObtenerIdAlias(string alias)
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;username=root;password=1234;database=hackyfox"))
            {
                conexion.Open();
                string query = "SELECT id_alias FROM alias WHERE LOWER(alias) = LOWER(@alias) LIMIT 1;";
                using MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@alias", alias);
                object result = cmd.ExecuteScalar();

                return result != null ? Convert.ToInt32(result) : -1;
            }
        }
    }
}
