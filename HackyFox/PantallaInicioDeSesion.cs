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
    public partial class PantallaInicioDeSesion : Form
    {
        Dictionary<Control, Rectangle> controlesOriginales = new Dictionary<Control, Rectangle>();
        Size tamañoFormularioOriginal;
        float fuenteOriginal;
        public PantallaInicioDeSesion()
        {
            InitializeComponent();
            this.Resize += PantallaInicioDeSesion_Resize;
        }
        int idProgresoGeneral = -1; // Solo una vez, justo después de obtener idAlias

        public static class LoginData
        {
            public static int idUsuarioActual;
            public static int idProgresoActual; 
        }

        private void tbAliasInicioDeSesion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCorroborarAlias_Click(object sender, EventArgs e)
        {
            string aliasIngresado = tbAliasInicioDeSesion.Text.Trim();

            if (string.IsNullOrWhiteSpace(aliasIngresado))
            {
                MessageBox.Show("Por favor, ingresa tu alias.");
                return;
            }

            try
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;username=root;password=rute;database=hackyfox"))
                {
                    conexion.Open();

                    string query = "SELECT * FROM alias WHERE alias = @alias";
                    MySqlCommand comando = new MySqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@alias", aliasIngresado);

                    MySqlDataReader lector = comando.ExecuteReader();

                    if (lector.HasRows)
                    {
                        // Si se encontró el alias
                        MessageBox.Show("¡Bienvenido de nuevo, " + aliasIngresado + "!");

                        lector.Read(); // Leer la fila del usuario
                        int idAlias = Convert.ToInt32(lector["id_alias"]);

                        lector.Close(); // Cerrar antes de abrir nueva conexión

                        // Guardar el alias en clase accesible para otros formularios
                        LoginData.idUsuarioActual = idAlias;

                        // Verificar si ya existe progreso_general
                        using (MySqlConnection connProgreso = new MySqlConnection("server=localhost;username=root;password=rute;database=hackyfox"))
                        {
                            connProgreso.Open();

                            string verificarProgreso = "SELECT COUNT(*) FROM progreso_general WHERE id_alias = @idAlias;";
                            MySqlCommand cmdVerificar = new MySqlCommand(verificarProgreso, connProgreso);
                            cmdVerificar.Parameters.AddWithValue("@idAlias", idAlias);
                            int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                            if (existe == 0)
                            {
                                // Crear progreso si no existe para ese alias
                                string crearProgreso = @"INSERT INTO progreso_general  
                                 (id_alias, total_lecciones, lecciones_completadas, porcentaje_global, fecha_creacion, fecha_actualizacion)
                                 VALUES (@idAlias, 0, 0, 0.00, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);";

                                MySqlCommand cmdCrear = new MySqlCommand(crearProgreso, connProgreso);
                                cmdCrear.Parameters.AddWithValue("@idAlias", idAlias);
                                cmdCrear.ExecuteNonQuery();



                                using (MySqlConnection connIdProgreso = new MySqlConnection("server=localhost;username=root;password=rute;database=hackyfox"))
                                {
                                    connIdProgreso.Open();

                                    string queryIdProgreso = "SELECT id_progreso_general FROM progreso_general WHERE id_alias = @idAlias LIMIT 1;";
                                    MySqlCommand cmdIdProgreso = new MySqlCommand(queryIdProgreso, connIdProgreso);
                                    cmdIdProgreso.Parameters.AddWithValue("@idAlias", idAlias);

                                    object resultado = cmdIdProgreso.ExecuteScalar();
                                    if (resultado != null)
                                    {
                                        idProgresoGeneral = Convert.ToInt32(resultado);
                                        // guardado en LoginData para uso global
                                        LoginData.idProgresoActual = idProgresoGeneral;
                                    }
                                }

                            }


                           

                            using (MySqlConnection connIdProgreso = new MySqlConnection("server=localhost;username=root;password=rute;database=hackyfox"))
                            {
                                connIdProgreso.Open();

                                string queryIdProgreso = "SELECT id_progreso_general FROM progreso_general WHERE id_alias = @idAlias LIMIT 1;";
                                MySqlCommand cmdIdProgreso = new MySqlCommand(queryIdProgreso, connIdProgreso);
                                cmdIdProgreso.Parameters.AddWithValue("@idAlias", idAlias);

                                object resultado = cmdIdProgreso.ExecuteScalar();
                                if (resultado != null)
                                {
                                    idProgresoGeneral = Convert.ToInt32(resultado);
                                    LoginData.idProgresoActual = idProgresoGeneral;
                                }
                            }


                            // Redirigir al formulario de lecciones
                            MenuLecciones f = new MenuLecciones();
                            f.Show();
                            this.Hide();

                        }



                    }

                    else
                    {
                        MessageBox.Show("Alias no encontrado. ¿Estás seguro de que ya te registraste?");
                    }

                    lector.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el alias: " + ex.Message);
            }
        }


        private void PantallaInicioDeSesion_Load(object sender, EventArgs e)
        {
            tamañoFormularioOriginal = this.ClientSize;

            // Escoge una fuente de referencia (por ejemplo, el título)
            fuenteOriginal = lbInicioDeSesion.Font.Size;

            // Guarda posición y tamaño de cada control
            controlesOriginales[pbLogoInicioDeSesion] = pbLogoInicioDeSesion.Bounds;
            controlesOriginales[lbInicioDeSesion] = lbInicioDeSesion.Bounds;
            controlesOriginales[lbAliasInicioDeSesion] = lbAliasInicioDeSesion.Bounds;
            controlesOriginales[tbAliasInicioDeSesion] = tbAliasInicioDeSesion.Bounds;
            controlesOriginales[btnCorroborarAlias] = btnCorroborarAlias.Bounds;
            controlesOriginales[pbMascotaInicioDeSesion] = pbMascotaInicioDeSesion.Bounds;
            controlesOriginales[pbFondoInicioDeSesion] = pbFondoInicioDeSesion.Bounds;
            controlesOriginales[btnIniciarSesionRegresar] = btnIniciarSesionRegresar.Bounds;
        }

        private void PantallaInicioDeSesion_Resize(object? sender, EventArgs e)
        {
            float escalaX = (float)this.ClientSize.Width / tamañoFormularioOriginal.Width;
            float escalaY = (float)this.ClientSize.Height / tamañoFormularioOriginal.Height;

            foreach (var item in controlesOriginales)
            {
                Control ctrl = item.Key;
                Rectangle rect = item.Value;

                ctrl.Left = (int)(rect.Left * escalaX);
                ctrl.Top = (int)(rect.Top * escalaY);
                ctrl.Width = (int)(rect.Width * escalaX);
                ctrl.Height = (int)(rect.Height * escalaY);

                // Cambiar fuente si es control con texto
                if (ctrl is Label || ctrl is Button || ctrl is TextBox)
                {
                    ctrl.Font = new Font(ctrl.Font.FontFamily, fuenteOriginal * Math.Min(escalaX, escalaY));
                }

            }
        }

        private void btnIniciarSesionRegresar_Click(object sender, EventArgs e)
        {
            PantallaBienvenida volver = new PantallaBienvenida();
            volver.StartPosition = FormStartPosition.Manual;
            volver.Location = this.Location;
            volver.Show();
            this.Close(); // Cierra PantallaInicioDeSesion
        }
    }
}
