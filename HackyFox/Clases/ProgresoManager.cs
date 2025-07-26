using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HackyFox.Clases
{
    public static class ProgresoManager
    {
        // Recalcula y guarda el porcentaje global en progreso_general.
        public static void ActualizarProgresoGlobal(int idProgresoGeneral, MySqlConnection conexion)
        {
            string queryLecciones = "SELECT COUNT(*) FROM lecciones";
            using var cmdLecciones = new MySqlCommand(queryLecciones, conexion);
            int totalLecciones = Convert.ToInt32(cmdLecciones.ExecuteScalar());

            string queryComponentes = @"
                SELECT COUNT(*) 
                  FROM detalle_progreso 
                 WHERE id_progreso_general = @idProg 
                   AND completado = 1";
            using var cmdComponentes = new MySqlCommand(queryComponentes, conexion);
            cmdComponentes.Parameters.AddWithValue("@idProg", idProgresoGeneral);
            int componentesCompletados = Convert.ToInt32(cmdComponentes.ExecuteScalar());

            int totalComponentes = totalLecciones * 18;
            double porcentaje = totalComponentes > 0
                ? ((double)componentesCompletados / totalComponentes) * 100
                : 0;

            string queryUpdate = @"
                UPDATE progreso_general 
                   SET porcentaje_global = ROUND(@porcentaje, 2),
                       fecha_actualizacion = CURRENT_TIMESTAMP
                 WHERE id_progreso_general = @idProg";
            using var cmdUpdate = new MySqlCommand(queryUpdate, conexion);
            cmdUpdate.Parameters.AddWithValue("@porcentaje", porcentaje);
            cmdUpdate.Parameters.AddWithValue("@idProg", idProgresoGeneral);
            cmdUpdate.ExecuteNonQuery();
        }


        /// Registra un componente en detalle_progreso y actualiza progreso_general.  
        public static void RegistrarComponente(
            MySqlConnection conexion,
            int idProgresoGeneral,
            int idLeccion,
            string componente)
        {
            if (idLeccion <= 0)
                throw new ArgumentException("El id de lección debe ser mayor que 0.", nameof(idLeccion));

            //Verificar que la lección exista
            const string sqlCheckLeccion = @"
                SELECT COUNT(*) 
                  FROM lecciones 
                 WHERE id_leccion = @idLeccion";
            using (var cmdCheckLec = new MySqlCommand(sqlCheckLeccion, conexion))
            {
                cmdCheckLec.Parameters.AddWithValue("@idLeccion", idLeccion);
                int existeLec = Convert.ToInt32(cmdCheckLec.ExecuteScalar());
                if (existeLec == 0)
                    throw new InvalidOperationException(
                        $"No existe la lección con id {idLeccion} en la tabla 'lecciones'.");
            }

            //Verificar si ya existe ese registro en detalle_progreso
            const string sqlCheck = @"
                SELECT COUNT(*) 
                  FROM detalle_progreso
                 WHERE id_progreso_general = @idProg
                   AND id_leccion          = @idLeccion
                   AND componente          = @comp";
            using var cmdCheck = new MySqlCommand(sqlCheck, conexion);
            cmdCheck.Parameters.AddWithValue("@idProg", idProgresoGeneral);
            cmdCheck.Parameters.AddWithValue("@idLeccion", idLeccion);
            cmdCheck.Parameters.AddWithValue("@comp", componente);
            int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

            if (existe == 0)
            {
                // Insertar el nuevo componente
                double porcentaje = 100.0 / 3   ; 

                const string sqlInsert = @"
                    INSERT INTO detalle_progreso
                        (id_progreso_general, id_leccion, componente, completado, porcentaje, fecha)
                    VALUES
                        (@idProg, @idLeccion, @comp, 1, @porcentaje, CURRENT_TIMESTAMP)";
                using var cmdInsert = new MySqlCommand(sqlInsert, conexion);
                cmdInsert.Parameters.AddWithValue("@idProg", idProgresoGeneral);
                cmdInsert.Parameters.AddWithValue("@idLeccion", idLeccion);
                cmdInsert.Parameters.AddWithValue("@comp", componente);
                cmdInsert.Parameters.AddWithValue("@porcentaje", porcentaje);
                cmdInsert.ExecuteNonQuery();
            }

            //Recalcular porcentaje global
            ActualizarProgresoGlobal(idProgresoGeneral, conexion);

            //Si con esto alcanzó 100% en esta lección, incrementar lecciones_completadas
            const string sqlSum = @"
                SELECT SUM(porcentaje) 
                  FROM detalle_progreso 
                 WHERE id_progreso_general = @idProg 
                   AND id_leccion          = @idLeccion";
            using (var cmdSum = new MySqlCommand(sqlSum, conexion))
            {
                cmdSum.Parameters.AddWithValue("@idProg", idProgresoGeneral);
                cmdSum.Parameters.AddWithValue("@idLeccion", idLeccion);
                object result = cmdSum.ExecuteScalar();
                double total = result != DBNull.Value
                    ? Convert.ToDouble(result)
                    : 0;

                if (total >= 100)
                {
                    const string sqlUpd = @"
                        UPDATE progreso_general
                           SET lecciones_completadas = lecciones_completadas + 1,
                               fecha_actualizacion    = CURRENT_TIMESTAMP
                         WHERE id_progreso_general = @idProg";
                    using var cmdUpd = new MySqlCommand(sqlUpd, conexion);
                    cmdUpd.Parameters.AddWithValue("@idProg", idProgresoGeneral);
                    cmdUpd.ExecuteNonQuery();
                }
            }
        }
    }
}