using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackyFox.Clases
{
    // Clase estática que representa la sesión activa del usuario
    public static class Sesion
    {
        public static Usuario UsuarioActual { get; private set; }
        public static int LeccionActual { get; set; } // Nueva propiedad

        public static void IniciarSesion(int idAlias, int idProgreso)
        {
            UsuarioActual = new Usuario(idAlias, idProgreso);
            LeccionActual = ObtenerLeccionActual(idProgreso); // Implementar este método
        }

        private static int ObtenerLeccionActual(int idProgreso)
        {
            using var conexion = ConexionBD.ObtenerConexion();
            conexion.Open();

            string query = @"SELECT COALESCE(MAX(id_leccion), 0) + 1 
                         FROM detalle_progreso 
                         WHERE id_progreso_general = @idProgreso";

            using var cmd = new MySqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@idProgreso", idProgreso);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}

