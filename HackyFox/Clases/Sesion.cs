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
        // Usuario actualmente logueado
        public static Usuario UsuarioActual { get; private set; }

        // Inicia sesión cargando el usuario
        public static void IniciarSesion(int idAlias, int idProgreso)
        {
            UsuarioActual = new Usuario(idAlias, idProgreso);
        }

        // Cierra la sesión
        public static void CerrarSesion()
        {
            UsuarioActual = null;
        }
    }
}

