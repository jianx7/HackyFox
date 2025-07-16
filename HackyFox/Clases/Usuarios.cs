using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackyFox.Clases
{
    // Clase que representa al usuario actual
    public class Usuario
    {
        public int IdAlias { get; set; }
        public int IdProgresoGeneral { get; set; }

        public Usuario(int idAlias, int idProgreso)
        {
            IdAlias = idAlias;
            IdProgresoGeneral = idProgreso;
        }
    }
}
