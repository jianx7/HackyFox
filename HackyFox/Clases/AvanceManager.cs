using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HackyFox.Clases
{
    public static class AvanceManager
    {
        public static void AvanzarLeccion(int idAlias)
        {
            using var conexion = new MySqlConnection("server=localhost;username=root;password=1234;database=hackyfox");
            conexion.Open();

            int idProgresoGeneral = ProgresoDB.ObtenerOCrearProgreso(idAlias);

            string queryUpdate = @"UPDATE progreso_general 
                                   SET lecciones_completadas = lecciones_completadas + 1,
                                       fecha_actualizacion = CURRENT_TIMESTAMP 
                                   WHERE id_progreso_general = @idProg";

            using var cmdUpdate = new MySqlCommand(queryUpdate, conexion);
            cmdUpdate.Parameters.AddWithValue("@idProg", idProgresoGeneral);
            cmdUpdate.ExecuteNonQuery();

            // También actualiza porcentaje global
            ProgresoManager.ActualizarProgresoGlobal(idProgresoGeneral, conexion);
        }
    }
}
