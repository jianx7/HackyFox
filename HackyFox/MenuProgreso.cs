using HackyFox.Clases;
using HackyFox.Controls;
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

namespace HackyFox
{
    public partial class MenuProgreso : Form
    {
        public MenuProgreso()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //Colapsar el menu llamando al método colapseMenu
            colapseMenu();
        }

        //Cargas desde la bd la informcacion de la leccion actual
        private void CargarAlias()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string queryLeccion = @"SELECT alias FROM alias WHERE id_alias = @idAlias";

                    using (MySqlCommand cmd = new MySqlCommand(queryLeccion, conexion))
                    {
                        // 👇 Aquí usamos el ID que está dentro del objeto Usuario
                        cmd.Parameters.AddWithValue("@idAlias", Sesion.UsuarioActual.IdAlias);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lbAlias.Text = reader["alias"].ToString();
                            }
                            else
                            {
                                lbAlias.Text = "";
                                MessageBox.Show("Alias no encontrado para id_alias = " + Sesion.UsuarioActual.IdAlias);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lbAlias.Text = "";
                MessageBox.Show("Error al cargar el alias: " + ex.Message);
            }
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

        //Redimensionar tamaño de los botones del menu
        private void MenuProgreso_Load(object sender, EventArgs e)
        {
            //Panel de menú
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
            {
                menuButton.Image = new Bitmap(menuButton.Image, new Size(52, 52));
            }
            //Menu
            btnMenu.Image = Properties.Resources.menu;
            btnMenu.Image = new Bitmap(Properties.Resources.menu, new Size(52, 52));

            // Cargar progreso del usuario actual
            CargarProgresoUsuario();
            CargarAlias();
        }

        private void btnLecciones_Click(object sender, EventArgs e)
        {
            MenuLecciones menuLecciones = new MenuLecciones();
            menuLecciones.Show();
            this.Close(); // Cierra el formulario actual
        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            MenuMascota menuMascota = new MenuMascota();
            menuMascota.Show();
            this.Close(); // Cierra el formulario actual
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show
          (
            "¿Estás seguro que quieres salir del juego?",
            "Salir",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
          );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); // Cierra toda la aplicación
            }
        }



        private void ProgresoGeneral_Click(object sender, EventArgs e)
        {

        }

        private void CargarProgresoUsuario()
        {
            // Verificar si hay un usuario logueado
            if (Sesion.UsuarioActual == null)
            {
                MessageBox.Show("No hay usuario logueado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;username=root;password=1234;database=hackyfox"))
                {
                    conexion.Open();
                    string query = @"SELECT pg.porcentaje_global, pg.lecciones_completadas, 
                           (SELECT COUNT(*) FROM lecciones) as total_lecciones
                           FROM progreso_general pg
                           WHERE pg.id_progreso_general = @idProgreso";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idProgreso", Sesion.UsuarioActual.IdProgresoGeneral);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Obtener porcentaje y redondear
                                decimal porcentaje = reader["porcentaje_global"] != DBNull.Value ?
                                                   Convert.ToDecimal(reader["porcentaje_global"]) : 0;

                                int leccionesCompletadas = Convert.ToInt32(reader["lecciones_completadas"]);
                                int totalLecciones = Convert.ToInt32(reader["total_lecciones"]);

                                // Configurar progress bar
                                ProgresoGeneral.Minimum = 0;
                                ProgresoGeneral.Maximum = 100;
                                ProgresoGeneral.Value = (int)Math.Round(porcentaje);

                                // Opcional: Mostrar texto descriptivo
                                ProgresoGeneral.SymbolBefore = "Progreso: ";
                                ProgresoGeneral.SymbolAfter = "%";
                                ProgresoGeneral.ShowValue = RJProgressBar.TextPosition.Center;
                                ProgresoGeneral.ShowMaximun = true;

                                // Actualizar otros controles si los tienes
                                // lblLecciones.Text = $"{leccionesCompletadas}/{totalLecciones} lecciones";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar progreso: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                CargarProgresoUsuario();
            }
        }
    }
}
