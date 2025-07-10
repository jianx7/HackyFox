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


namespace HackyFox
{
    public partial class Leccion : Form
    {
        string LeccionConexion = "server = 127.0.0.1; user id = root; password = rute; database = hackyfox";

        public Leccion()
        {
            InitializeComponent();
            CargarLeccionDesdeProgreso();

        }

        private void CargarLeccionDesdeProgreso()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;username=root;password=rute;database=hackyfox"))
                {
                    conexion.Open();

                    // 1. Obtener cantidad de lecciones completadas
                    string queryProgreso = @"SELECT lecciones_completadas 
                                 FROM progreso_general 
                                 WHERE id_alias = @idAlias";

                    MySqlCommand cmdProgreso = new MySqlCommand(queryProgreso, conexion);
                    cmdProgreso.Parameters.AddWithValue("@idAlias", LoginData.idUsuarioActual);
                    object resultado = cmdProgreso.ExecuteScalar();

                    int leccionesCompletadas = 0;
                    if (resultado != null)
                    {
                        leccionesCompletadas = Convert.ToInt32(resultado);
                    }

                    // 2. Calcular siguiente lección que debe mostrarse
                    int idLeccionActual = leccionesCompletadas + 1;

                    // 3. Obtener datos de esa lección
                    string queryLeccion = @"SELECT nombre, titulo, subtitulo, informacion, consejo 
                                FROM lecciones 
                                WHERE id_leccion = @id";

                    MySqlCommand cmdLeccion = new MySqlCommand(queryLeccion, conexion);
                    cmdLeccion.Parameters.AddWithValue("@id", idLeccionActual);

                    using (MySqlDataReader reader = cmdLeccion.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            LbTituloLeccion.Text = reader["nombre"].ToString();
                            LbTituloContenido.Text = reader["titulo"].ToString();
                            LbSubtitulo.Text = reader["subtitulo"].ToString();
                            TbContenido.Text = reader["informacion"].ToString();
                            Lbconsejo.Text = reader["consejo"].ToString();
                        }
                        else
                        {
                            LbTituloLeccion.Text = " ";
                            LbTituloContenido.Text = "¡No hay más lecciones disponibles!";
                            LbSubtitulo.Text = " ";
                            TbContenido.Text = " ";
                            Lbconsejo.Text = " ";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LbTituloLeccion.Text = " ";
                LbTituloContenido.Text = "Error al cargar lección";
                LbSubtitulo.Text = " ";
                TbContenido.Text = " ";
                Lbconsejo.Text = " ";

                MessageBox.Show("Error: " + ex.Message); // te muestra el error real
            }
        }
        public Leccion(int idLeccionActual)
        {
            InitializeComponent();
            // inicializar cualquier lógica relacionada con el idLeccionActual
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

        public static class LoginData
        {
            public static int idUsuarioActual;
            public static int idProgresoActual;
        }

        private void btnLeccionAReto_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;username=root;password=rute;database=hackyfox"))
                {
                    conexion.Open();

                    int idProgresoGeneral = 0;
                    int idLeccionActual = 1;

                    // 1. Obtener el progreso general del usuario
                    string queryProgreso = @"SELECT id_progreso_general, lecciones_completadas 
                                     FROM progreso_general 
                                     WHERE id_alias = @idAlias";

                    MySqlCommand cmdProgreso = new MySqlCommand(queryProgreso, conexion);
                    cmdProgreso.Parameters.AddWithValue("@idAlias", 1);

                    using (MySqlDataReader reader = cmdProgreso.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idProgresoGeneral = Convert.ToInt32(reader["id_progreso_general"]);
                            idLeccionActual = Convert.ToInt32(reader["lecciones_completadas"]) + 1;
                        }
                    }

                    // 2. Si no existe progreso, crearlo
                    if (idProgresoGeneral == 0)
                    {
                        string insertProgreso = @"INSERT INTO progreso_general 
                                          (id_alias, lecciones_completadas, fecha_actualizacion) 
                                          VALUES (@idAlias, 0, CURRENT_TIMESTAMP)";


                        MySqlCommand cmdInsert = new MySqlCommand(insertProgreso, conexion);
                        cmdInsert.Parameters.AddWithValue("@idAlias", 1);
                        //System.Windows.MessageBox.Show(LoginData.idUsuarioActual.ToString());
                        cmdInsert.ExecuteNonQuery();

                        // Obtener el ID recién creado
                        string obtenerId = @"SELECT id_progreso_general 
                                     FROM progreso_general 
                                     WHERE id_alias = @idAlias";
                        MySqlCommand cmdGetId = new MySqlCommand(obtenerId, conexion);
                        cmdGetId.Parameters.AddWithValue("@idAlias", LoginData.idUsuarioActual);
                        idProgresoGeneral = Convert.ToInt32(cmdGetId.ExecuteScalar());

                        idLeccionActual = 1; // Primera lección
                    }

                    // 3. Insertar componente 'leccion' si no se ha registrado aún
                    string queryDetalle = @"SELECT COUNT(*) FROM detalle_progreso 
                                    WHERE id_progreso_general = @idProg AND id_leccion = @idLeccion AND componente = 'leccion'";

                    MySqlCommand cmdCheckDetalle = new MySqlCommand(queryDetalle, conexion);
                    cmdCheckDetalle.Parameters.AddWithValue("@idProg", idProgresoGeneral);
                    cmdCheckDetalle.Parameters.AddWithValue("@idLeccion", idLeccionActual);

                    int existe = Convert.ToInt32(cmdCheckDetalle.ExecuteScalar());

                    if (existe == 0)
                    {
                        string insertarDetalle = @"INSERT INTO detalle_progreso 
                                           (id_progreso_general, id_leccion, componente, completado, porcentaje, fecha) 
                                           VALUES (@idProg, @idLeccion, 'leccion', 1, 33.33, CURRENT_TIMESTAMP)";
                        MySqlCommand cmdInsertDetalle = new MySqlCommand(insertarDetalle, conexion);
                        cmdInsertDetalle.Parameters.AddWithValue("@idProg", idProgresoGeneral);
                        cmdInsertDetalle.Parameters.AddWithValue("@idLeccion", idLeccionActual);
                        cmdInsertDetalle.ExecuteNonQuery();
                    }

                    // 4. Lanzar ventana de reto con lección actual
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
    }
}

