using HackyFox.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HackyFox.MenuLecciones;

namespace HackyFox
{

    public partial class FinalDinamica : Form
    {
        private readonly int idLeccionActual;

        public FinalDinamica(int idLeccionActual)
        {
            InitializeComponent();
            this.idLeccionActual = idLeccionActual;
        }

        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            var menu = new MenuLecciones();
            menu.StartPosition = FormStartPosition.Manual;
            menu.Location = this.Location;
            menu.Show();
            menu.RefrescarSiguienteLeccion();
            this.Close();
        }

        private void btnSiguienteLeccion_Click(object sender, EventArgs e)
        {
            // Obtener la siguiente lección
            int siguienteLeccion = idLeccionActual + 1;

            // Verificar si existe la lección antes de continuar
            if (LeccionExiste(siguienteLeccion))
            {
                Sesion.LeccionActual++;

                var leccion = new Leccion();
                leccion.StartPosition = FormStartPosition.Manual;
                leccion.Location = this.Location;
                leccion.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("¡Has completado todas las lecciones!");
                var menu = new MenuLecciones();
                menu.StartPosition = FormStartPosition.Manual;
                menu.Location = this.Location;
                menu.Show();
            }
            this.Close();
        }

        private bool LeccionExiste(int idLeccion)
        {
            using var conexion = ConexionBD.ObtenerConexion();
            conexion.Open();
            string query = "SELECT COUNT(*) FROM lecciones WHERE id_leccion = @idLeccion";

            using var cmd = new MySqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@idLeccion", idLeccion);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }
    }
}
