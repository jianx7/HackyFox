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
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;username=root;password=rubi2006;database=hackyfox"))
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
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;username=root;password=rubi2006;database=hackyfox"))
                {
                    conexion.Open();

                    int idAlias = 1; // ← ID fijo para alias en pruebas
                    int idProgresoGeneral = 0;
                    int idLeccionActual = 1;

                    // 1. Buscar progreso_general para alias 1
                    string queryBuscarProgreso = @"SELECT id_progreso_general, lecciones_completadas 
                                           FROM progreso_general WHERE id_alias = @idAlias";
                    MySqlCommand cmdBuscar = new MySqlCommand(queryBuscarProgreso, conexion);
                    cmdBuscar.Parameters.AddWithValue("@idAlias", idAlias);

                    using (MySqlDataReader reader = cmdBuscar.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idProgresoGeneral = Convert.ToInt32(reader["id_progreso_general"]);
                            idLeccionActual = Convert.ToInt32(reader["lecciones_completadas"]) + 1;
                        }
                    }

                    // 2. Si no hay progreso aún, crearlo
                    if (idProgresoGeneral == 0)
                    {
                        string insertarProgreso = @"INSERT INTO progreso_general 
                                            (id_alias, lecciones_completadas, fecha_actualizacion) 
                                            VALUES (@idAlias, 0, CURRENT_TIMESTAMP)";
                        MySqlCommand cmdInsertar = new MySqlCommand(insertarProgreso, conexion);
                        cmdInsertar.Parameters.AddWithValue("@idAlias", idAlias);
                        cmdInsertar.ExecuteNonQuery();

                        idProgresoGeneral = (int)cmdInsertar.LastInsertedId;
                        idLeccionActual = 1;
                    }

                    // 3. Insertar componente 'leccion' si no existe
                    string verificarComponente = @"SELECT COUNT(*) FROM detalle_progreso 
                                           WHERE id_progreso_general = @idProg 
                                           AND id_leccion = @idLeccion 
                                           AND componente = 'leccion'";
                    MySqlCommand cmdVerificar = new MySqlCommand(verificarComponente, conexion);
                    cmdVerificar.Parameters.AddWithValue("@idProg", idProgresoGeneral);
                    cmdVerificar.Parameters.AddWithValue("@idLeccion", idLeccionActual);
                    int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                    if (existe == 0)
                    {
                        double porcentajeComponente = 100.0 / 18; // 5.55%

                        string insertarDetalle = @"INSERT INTO detalle_progreso 
                                           (id_progreso_general, id_leccion, componente, completado, porcentaje, fecha) 
                                           VALUES (@idProg, @idLeccion, 'leccion', 1, @porcentaje, CURRENT_TIMESTAMP)";
                        MySqlCommand cmdInsertarDetalle = new MySqlCommand(insertarDetalle, conexion);
                        cmdInsertarDetalle.Parameters.AddWithValue("@idProg", idProgresoGeneral);
                        cmdInsertarDetalle.Parameters.AddWithValue("@idLeccion", idLeccionActual);
                        cmdInsertarDetalle.Parameters.AddWithValue("@porcentaje", porcentajeComponente);

                        cmdInsertarDetalle.ExecuteNonQuery();
                    }

                    // 4. Calcular progreso global parcial
                    string totalLeccionesSql = "SELECT COUNT(*) FROM lecciones";
                    MySqlCommand cmdTotal = new MySqlCommand(totalLeccionesSql, conexion);
                    int totalLecciones = Convert.ToInt32(cmdTotal.ExecuteScalar());

                    string contarComponentesSql = @"SELECT COUNT(*) FROM detalle_progreso 
                                            WHERE id_progreso_general = @idProg AND completado = 1";
                    MySqlCommand cmdContar = new MySqlCommand(contarComponentesSql, conexion);
                    cmdContar.Parameters.AddWithValue("@idProg", idProgresoGeneral);
                    int componentesCompletados = Convert.ToInt32(cmdContar.ExecuteScalar());

                    int totalComponentes = totalLecciones * 18;
                    double porcentajeGlobal = ((double)componentesCompletados / totalComponentes) * 100;

                    string actualizarGlobalSql = @"UPDATE progreso_general 
                                           SET porcentaje_global = ROUND(@porcentaje, 2), 
                                               fecha_actualizacion = CURRENT_TIMESTAMP 
                                           WHERE id_progreso_general = @idProg";
                    MySqlCommand cmdActualizar = new MySqlCommand(actualizarGlobalSql, conexion);
                    cmdActualizar.Parameters.AddWithValue("@porcentaje", porcentajeGlobal);
                    cmdActualizar.Parameters.AddWithValue("@idProg", idProgresoGeneral);
                    cmdActualizar.ExecuteNonQuery();

                    // 5. Lanzar el reto
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


        private void ActualizarPorcentajeGlobal()
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;username=root;password=rubi2006;database=hackyfox"))
            {
                conexion.Open();

                string queryLecciones = "SELECT COUNT(*) FROM lecciones";
                MySqlCommand cmdLecciones = new MySqlCommand(queryLecciones, conexion);
                int totalLecciones = Convert.ToInt32(cmdLecciones.ExecuteScalar());

                string queryComponentes = @"SELECT COUNT(*) FROM detalle_progreso 
                                            WHERE id_progreso_general = 1 AND completado = 1";
                MySqlCommand cmdComp = new MySqlCommand(queryComponentes, conexion);
                int componentesCompletados = Convert.ToInt32(cmdComp.ExecuteScalar());

                int totalComponentes = totalLecciones * 18;
                double porcentaje = ((double)componentesCompletados / totalComponentes) * 100;

                string queryUpdate = @"UPDATE progreso_general 
                                       SET porcentaje_global = ROUND(@porcentaje, 2),
                                           fecha_actualizacion = CURRENT_TIMESTAMP
                                       WHERE id_alias = 1";
                MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, conexion);
                cmdUpdate.Parameters.AddWithValue("@porcentaje", porcentaje);
                cmdUpdate.ExecuteNonQuery();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

