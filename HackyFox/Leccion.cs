using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HackyFox.Clases;

namespace HackyFox
{
    public partial class Leccion : Form
    {
        public Leccion()
        {
            InitializeComponent();
            CargarLeccionDesdeProgreso();
        }

        private void CargarLeccionDesdeProgreso()
        {
            try
            {
                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();
                    string queryLeccion = @"SELECT nombre, titulo, subtitulo, informacion, consejo, imagen 
                                   FROM lecciones 
                                   WHERE id_leccion = @idLeccion";

                    using (MySqlCommand cmd = new MySqlCommand(queryLeccion, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idLeccion", Sesion.LeccionActual); // Usa la sesión

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Cargar datos de texto
                                LbTituloLeccion.Text = reader["nombre"].ToString();
                                LbTituloContenido.Text = reader["titulo"].ToString();
                                LbSubtitulo.Text = reader["subtitulo"].ToString();
                                TbContenido.Text = reader["informacion"].ToString();
                                Lbconsejo.Text = reader["consejo"].ToString();

                                // Cargar imagen desde BLOB
                                if (!(reader["imagen"] is DBNull))
                                {
                                    byte[] imagenBytes = (byte[])reader["imagen"];
                                    using var ms = new System.IO.MemoryStream(imagenBytes);
                                    pbLeccion.Image = Image.FromStream(ms);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LbTituloLeccion.Text = "";
                LbTituloContenido.Text = "Error al cargar lección";
                LbSubtitulo.Text = "";
                TbContenido.Text = "";
                Lbconsejo.Text = "";

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int ObtenerLeccionesCompletadas(MySqlConnection conexion, int idProgresoGeneral)
        {
            string query = @"SELECT lecciones_completadas 
                             FROM progreso_general 
                             WHERE id_progreso_general = @idProgreso";

            using (MySqlCommand cmd = new MySqlCommand(query, conexion))
            {
                cmd.Parameters.AddWithValue("@idProgreso", idProgresoGeneral);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private void btnLeccionAReto_Click(object sender, EventArgs e)
        {
            try
            {
                int idAlias = Sesion.UsuarioActual.IdAlias;

                using (MySqlConnection conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    // Obtener o crear progreso
                    int idProgresoGeneral = ProgresoDB.ObtenerOCrearProgreso(idAlias);

                    // Obtener lecciones completadas
                    int leccionesCompletadas = ObtenerLeccionesCompletadas(conexion, idProgresoGeneral);
                    int idLeccionActual = leccionesCompletadas + 1;

                    // Insertar componente lección si no existe
                    InsertarComponenteLeccionSiNoExiste(conexion, idProgresoGeneral, idLeccionActual);

                    // Actualizar porcentaje global
                    ProgresoManager.ActualizarProgresoGlobal(idProgresoGeneral, conexion);

                    // Lanzar reto
                    RetoRelampago reto = new RetoRelampago(idLeccionActual);
                    reto.StartPosition = FormStartPosition.Manual;
                    reto.Location = this.Location;
                    reto.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al avanzar al reto: " + ex.Message);
            }
        }

        private void InsertarComponenteLeccionSiNoExiste(MySqlConnection conexion, int idProgresoGeneral, int idLeccion)
        {
            string queryCheck = @"SELECT COUNT(*) FROM detalle_progreso
                                  WHERE id_progreso_general = @idProg 
                                  AND id_leccion = @idLeccion 
                                  AND componente = 'leccion'";

            using (MySqlCommand cmdCheck = new MySqlCommand(queryCheck, conexion))
            {
                cmdCheck.Parameters.AddWithValue("@idProg", idProgresoGeneral);
                cmdCheck.Parameters.AddWithValue("@idLeccion", idLeccion);

                int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                if (count == 0)
                {
                    // Insertar componente 'leccion'
                    double porcentajeComponente = 100.0 / 18; // Ajustar si el total de componentes es distinto

                    string queryInsert = @"INSERT INTO detalle_progreso 
                                           (id_progreso_general, id_leccion, componente, completado, porcentaje, fecha) 
                                           VALUES (@idProg, @idLeccion, 'leccion', 1, @porcentaje, CURRENT_TIMESTAMP)";

                    using (MySqlCommand cmdInsert = new MySqlCommand(queryInsert, conexion))
                    {
                        cmdInsert.Parameters.AddWithValue("@idProg", idProgresoGeneral);
                        cmdInsert.Parameters.AddWithValue("@idLeccion", idLeccion);
                        cmdInsert.Parameters.AddWithValue("@porcentaje", porcentajeComponente);

                        cmdInsert.ExecuteNonQuery();
                    }
                }
            }
        }

        //Redimensionar imagen de botones
        private void Leccion_Load(object sender, EventArgs e)
        {
            //Panel de menú
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
            {
                menuButton.Image = new Bitmap(menuButton.Image, new Size(52, 52));
            }

            btnLeccionAReto.Image = Properties.Resources.flecha;
            btnLeccionAReto.Image = new Bitmap(Properties.Resources.flecha, new Size(52, 52));
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            openMenu();
        }

        private void openMenu()
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


                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    if (menuButton == btnMenu)
                        continue;

                    if (menuButton.Tag != null)
                    {
                        menuButton.Text = "   " + menuButton.Tag.ToString();
                    }
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
                btnMenu.Text = "HackyFox";
                btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
                btnMenu.Padding = new Padding(10, 0, 0, 0);
            }
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

    }
}