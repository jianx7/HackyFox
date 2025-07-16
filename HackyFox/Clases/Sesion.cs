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
        public static int LeccionActual { get; set; }

        public static void IniciarSesion(int idAlias, int idProgreso)
        {
            UsuarioActual = new Usuario(idAlias, idProgreso);
            LeccionActual = 1; // O determinar según progreso
        }
    }
}

