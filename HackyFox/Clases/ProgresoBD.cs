using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HackyFox.Clases
{
    public static class ProgresoDB
    {
        // Crea o recupera el progreso general del usuario
        public static int ObtenerOCrearProgreso(int idAlias)
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;username=root;password=1234;database=hackyfox"))
            {
                conexion.Open();

                // Verifica si ya existe un progreso para ese alias
                string verificar = "SELECT id_progreso_general FROM progreso_general WHERE id_alias = @idAlias LIMIT 1;";
                MySqlCommand cmdVerificar = new MySqlCommand(verificar, conexion);
                cmdVerificar.Parameters.AddWithValue("@idAlias", idAlias);
                object resultado = cmdVerificar.ExecuteScalar();

                // Si ya existe, retorna el ID
                if (resultado != null)
                {
                    return Convert.ToInt32(resultado);
                }

                // Si no existe, lo crea
                string crear = @"INSERT INTO progreso_general  
                                 (id_alias, total_lecciones, lecciones_completadas, porcentaje_global, fecha_creacion, fecha_actualizacion)
                                 VALUES (@idAlias, 0, 0, 0.00, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);";
                MySqlCommand cmdCrear = new MySqlCommand(crear, conexion);
                cmdCrear.Parameters.AddWithValue("@idAlias", idAlias);
                cmdCrear.ExecuteNonQuery();

                // Vuelve a obtener el ID del nuevo progreso
                cmdVerificar = new MySqlCommand(verificar, conexion);
                cmdVerificar.Parameters.AddWithValue("@idAlias", idAlias);
                resultado = cmdVerificar.ExecuteScalar();

                return Convert.ToInt32(resultado);
            }
        }
    }
}