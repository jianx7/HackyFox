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
using HackyFox.Clases;

namespace HackyFox
{

    public partial class MenuLecciones : Form
    {
        //Indicar la siguiente lección
        public int LeccionSiguienteId { get; private set; } = 1;
        // Cadena de conexión a la base de datos
        private readonly string cadenaConexion = "server=localhost;username=root;password=1234;database=hackyfox";

        // Constructor
        public MenuLecciones()
        {
            InitializeComponent();
            RefrescarSiguienteLeccion();
        }

        private void MenuLecciones_Load(object sender, EventArgs e)
        {
            // Redimensionar íconos del menú
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
            {
                menuButton.Image = new Bitmap(menuButton.Image, new Size(52, 52));
            }

            // Ícono hamburguesa
            btnMenu.Image = new Bitmap(Properties.Resources.menu, new Size(52, 52));

            // Cargar la siguiente lección
            RefrescarSiguienteLeccion();
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            //Colapsar el menu llamando al método colapseMenu
            colapseMenu();
        }

        private void colapseMenu()
        {
            //Cambiar el ancho del panel si es mayor a 300px
            if (this.panelMenu.Width > 300)
            {
                panelMenu.Width = 100;
                btnMenu.Text = string.Empty;
                btnMenu.ImageAlign = ContentAlignment.MiddleCenter;

                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = string.Empty;
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                //Cambiar el ancho del panel si es menor a 300px
                panelMenu.Width = 318;
                btnMenu.Text = "HackyFox";
                btnMenu.ImageAlign = ContentAlignment.MiddleLeft;

                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    if (menuButton.Tag != null) // Verificación para evitar referencias nulas
                    {
                        menuButton.Text = "   " + menuButton.Tag.ToString();
                    }
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        // Evento para salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que quieres salir del juego?",
                                "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            // Abre la pantalla de información de lección
            var ventanaLeccion = new Leccion();
            ventanaLeccion.Show();
            this.Close();
        }

        //Consulta la bd para obtener la siguiente lección y actualizar los labels
        public void RefrescarSiguienteLeccion()
        {
            //Obtener el ID del progreso del usuario actual
            int idProgreso = Sesion.UsuarioActual.IdProgresoGeneral;
            //Consulta SQL
            using (var conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string sql = @"SELECT l.id_leccion, l.nombre, l.titulo, l.dinamica 
                      FROM lecciones l
                      WHERE l.id_leccion > (
                          SELECT COALESCE(MAX(id_leccion), 0)
                          FROM detalle_progreso
                          WHERE id_progreso_general = @idProg
                          AND componente = 'dinamica'
                          AND completado = 1
                      )
                      ORDER BY l.id_leccion
                      LIMIT 1;";

                using (var cmd = new MySqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@idProg", idProgreso);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //Extraer datos de la lección siguiente
                            LeccionSiguienteId = Convert.ToInt32(reader["id_leccion"]);
                            lbLeccion.Text = $"Lección {LeccionSiguienteId}";
                            lbTema.Text = reader["nombre"].ToString();
                            btnInfo.Text = reader["titulo"].ToString();
                            btnDinamic.Text = reader["dinamica"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("🎉 ¡Has completado todas las lecciones!");
                            btnInfo.Enabled = false;
                            btnDinamic.Enabled = false;
                        }
                    }
                }
            }
        }

        private void btnLecciones_Click(object sender, EventArgs e)
        {

        }
        // Eventos para ir a los menus
        private void btnMascota_Click(object sender, EventArgs e)
        {
            MenuMascota menuMascota = new MenuMascota();
            menuMascota.Show();
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            MenuProgreso menuProgreso = new MenuProgreso();
            menuProgreso.Show();
            this.Close();
        }
    }
}