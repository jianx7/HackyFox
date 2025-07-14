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
    public partial class RetoRelampago : Form
    {
        private int idLeccionActual;
        private int opcionCorrecta;
        private int idProgresoGeneral = 1;

        public RetoRelampago(int idLeccionActual)
        {
            this.idLeccionActual = idLeccionActual;
            InitializeComponent();

            btnRespuesta1.Click += new EventHandler(btnRespuesta1_Click);
            btnRespuesta2.Click += new EventHandler(btnRespuesta2_Click);
            btnRespuesta3.Click += new EventHandler(btnRespuesta3_Click);

            this.Load += new EventHandler(RetoRelampago_Load);
        }

        private void RetoRelampago_Load(object sender, EventArgs e)
        {
            CargarRetoDesdeBD();
        }

        private void CargarRetoDesdeBD()
        {
            using (MySqlConnection conexion = new MySqlConnection("server=localhost;username=root;password=rubi2006;database=hackyfox"))
            {
                conexion.Open();
                string query = @"SELECT leccion, pregunta, respuesta1, respuesta2, respuesta3, valida 
                                 FROM reto WHERE id_leccion = @idLeccion";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@idLeccion", idLeccionActual);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        LbTituloLeccionR.Text = reader["leccion"].ToString();
                        lbRetoPregunta.Text = reader["pregunta"].ToString();
                        btnRespuesta1.Text = reader["respuesta1"].ToString();
                        btnRespuesta2.Text = reader["respuesta2"].ToString();
                        btnRespuesta3.Text = reader["respuesta3"].ToString();
                        opcionCorrecta = Convert.ToInt32(reader["valida"]);
                    }
                }
            }
        }

        private void btnRespuesta1_Click(object sender, EventArgs e) => VerificarRespuesta(1);
        private void btnRespuesta2_Click(object sender, EventArgs e) => VerificarRespuesta(2);
        private void btnRespuesta3_Click(object sender, EventArgs e) => VerificarRespuesta(3);

        private void VerificarRespuesta(int seleccion)
        {
            if (seleccion == opcionCorrecta)
            {
                using (MySqlConnection conexion = new MySqlConnection("server=localhost;username=root;password=rubi2006;database=hackyfox"))
                {
                    conexion.Open();

                    int idAlias = 1;
                    int idProgresoGeneral = 0;

                    // Obtener el id_progreso_general válido del alias 1
                    string queryId = @"SELECT id_progreso_general 
                               FROM progreso_general 
                               WHERE id_alias = @alias 
                               ORDER BY fecha_actualizacion DESC 
                               LIMIT 1";
                    MySqlCommand cmdId = new MySqlCommand(queryId, conexion);
                    cmdId.Parameters.AddWithValue("@alias", idAlias);
                    object result = cmdId.ExecuteScalar();

                    if (result != null)
                        idProgresoGeneral = Convert.ToInt32(result);
                    else
                        throw new Exception("❌ No se encontró progreso para el alias 1.");

                    // 🔎 Verificar si ya se registró 'reto' para esta lección
                    string check = @"SELECT COUNT(*) FROM detalle_progreso 
                             WHERE id_progreso_general = @idProg 
                             AND id_leccion = @idLeccion AND componente = 'reto'";
                    MySqlCommand cmdCheck = new MySqlCommand(check, conexion);
                    cmdCheck.Parameters.AddWithValue("@idProg", idProgresoGeneral);
                    cmdCheck.Parameters.AddWithValue("@idLeccion", idLeccionActual);
                    int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (existe == 0)
                    {
                        double porcentajeComponente = 100.0 / 18; // 5.55%

                        string insertarDetalle = @"INSERT INTO detalle_progreso 
                                           (id_progreso_general, id_leccion, componente, completado, porcentaje, fecha) 
                                           VALUES (@idProg, @idLeccion, 'reto', 1, @porcentaje, CURRENT_TIMESTAMP)";
                        MySqlCommand cmdInsertarDetalle = new MySqlCommand(insertarDetalle, conexion);
                        cmdInsertarDetalle.Parameters.AddWithValue("@idProg", idProgresoGeneral);
                        cmdInsertarDetalle.Parameters.AddWithValue("@idLeccion", idLeccionActual);
                        cmdInsertarDetalle.Parameters.AddWithValue("@porcentaje", porcentajeComponente);

                        cmdInsertarDetalle.ExecuteNonQuery();
                    }

                    // Actualiza progreso global parcial
                    ActualizarPorcentajeGlobal(idProgresoGeneral, conexion);
                }

                // Navega a la siguiente pantalla
                Bien siguienteVentana = new Bien();
                siguienteVentana.StartPosition = FormStartPosition.Manual;
                siguienteVentana.Location = this.Location;
                siguienteVentana.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("❌ Esa no era. Intenta otra vez.");
            }
        }

        private void ActualizarPorcentajeGlobal(int idProgresoGeneral, MySqlConnection conexion)
        {
            // Total de lecciones existentes
            string queryLecciones = "SELECT COUNT(*) FROM lecciones";
            MySqlCommand cmdLecciones = new MySqlCommand(queryLecciones, conexion);
            int totalLecciones = Convert.ToInt32(cmdLecciones.ExecuteScalar());

            // Contar componentes completados del progreso específico
            string queryComponentes = @"SELECT COUNT(*) FROM detalle_progreso 
                                WHERE id_progreso_general = @idProg AND completado = 1";
            MySqlCommand cmdComp = new MySqlCommand(queryComponentes, conexion);
            cmdComp.Parameters.AddWithValue("@idProg", idProgresoGeneral);
            int componentesCompletados = Convert.ToInt32(cmdComp.ExecuteScalar());

            int totalComponentes = totalLecciones * 18;
            double porcentaje = ((double)componentesCompletados / totalComponentes) * 100;

            string queryUpdate = @"UPDATE progreso_general 
                           SET porcentaje_global = ROUND(@porcentaje, 2),
                               fecha_actualizacion = CURRENT_TIMESTAMP 
                           WHERE id_progreso_general = @idProg";
            MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, conexion);
            cmdUpdate.Parameters.AddWithValue("@porcentaje", porcentaje);
            cmdUpdate.Parameters.AddWithValue("@idProg", idProgresoGeneral);
            cmdUpdate.ExecuteNonQuery();
        }
    }
}