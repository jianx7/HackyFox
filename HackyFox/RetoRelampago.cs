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
    public partial class RetoRelampago : Form
    {
        private int idLeccionActual;
        private int opcionCorrecta;

        public RetoRelampago(int idLeccionActual)
        {
            InitializeComponent();
            this.idLeccionActual = Sesion.LeccionActual;

            btnRespuesta1.Click += (s, e) => VerificarRespuesta(1);
            btnRespuesta2.Click += (s, e) => VerificarRespuesta(2);
            btnRespuesta3.Click += (s, e) => VerificarRespuesta(3);

            this.Load += RetoRelampago_Load;
        }

        private void RetoRelampago_Load(object sender, EventArgs e)
        {
            CargarRetoDesdeBD();
        }

        private void CargarRetoDesdeBD()
        {
            using var conexion = ConexionBD.ObtenerConexion();
            conexion.Open();

            string query = @"SELECT leccion, pregunta, respuesta1, respuesta2, respuesta3, valida 
                             FROM reto 
                             WHERE id_leccion = @idLeccion";

            using var cmd = new MySqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@idLeccion", idLeccionActual);

            using var reader = cmd.ExecuteReader();
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

        private void VerificarRespuesta(int seleccion)
        {
            if (seleccion == opcionCorrecta)
            {
                RegistrarComponente("reto");
                NavegarAFelicitacion();
            }
            else
            {
                MessageBox.Show("❌ Esa no era. Intenta otra vez.");
            }
        }

        private void RegistrarComponente(string componente)
        {
            using var conexion = ConexionBD.ObtenerConexion();
            conexion.Open();

            int idProg = Sesion.UsuarioActual.IdProgresoGeneral;

            // Verificar si ya fue registrado
            string check = @"SELECT COUNT(*) FROM detalle_progreso 
                             WHERE id_progreso_general = @idProg 
                             AND id_leccion = @idLeccion 
                             AND componente = @componente";
            using var cmdCheck = new MySqlCommand(check, conexion);
            cmdCheck.Parameters.AddWithValue("@idProg", idProg);
            cmdCheck.Parameters.AddWithValue("@idLeccion", idLeccionActual);
            cmdCheck.Parameters.AddWithValue("@componente", componente);
            int existe = Convert.ToInt32(cmdCheck.ExecuteScalar());

            if (existe == 0)
            {
                double porcentajeComponente = 100.0 / 18;

                string insert = @"INSERT INTO detalle_progreso 
                                  (id_progreso_general, id_leccion, componente, completado, porcentaje, fecha)
                                  VALUES (@idProg, @idLeccion, @componente, 1, @porcentaje, CURRENT_TIMESTAMP)";
                using var cmdInsert = new MySqlCommand(insert, conexion);
                cmdInsert.Parameters.AddWithValue("@idProg", idProg);
                cmdInsert.Parameters.AddWithValue("@idLeccion", idLeccionActual);
                cmdInsert.Parameters.AddWithValue("@componente", componente);
                cmdInsert.Parameters.AddWithValue("@porcentaje", porcentajeComponente);
                cmdInsert.ExecuteNonQuery();
            }

            // Actualizar porcentaje global
            ProgresoManager.ActualizarProgresoGlobal(idProg, conexion);
        }

        private void NavegarAFelicitacion()
        {
            Bien siguientePantalla = new Bien(idLeccionActual);
            siguientePantalla.StartPosition = FormStartPosition.Manual;
            siguientePantalla.Location = this.Location;
            siguientePantalla.Show();
            this.Close();
        }
    }
}
