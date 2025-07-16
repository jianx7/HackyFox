using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackyFox.Clases
{
    public static class ConexionBD
    {
        public static MySqlConnection ObtenerConexion()
        {
            string cadena = "server=localhost;username=root;password=1234;database=hackyfox";
            return new MySqlConnection(cadena);
        }
    }
}
