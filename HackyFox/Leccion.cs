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


            
            using (MySqlConnection conexion = new MySqlConnection(LeccionConexion))
            {
                conexion.Open();
                string query = "SELECT nombre, titulo, subtitulo, informacion, consejo FROM lecciones WHERE id_lecciones = 1";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    LbTituloLeccion.Text = "Leccion " + reader["nombre"].ToString();
                    LbTituloContenido.Text = reader["titulo"].ToString();
                    LbSubtitulo.Text = reader["subtitulo"].ToString();
                    Lbconsejo.Text = reader["consejo"].ToString();

                    TbContenido.Text = reader["informacion"].ToString();
                }
                conexion.Close();

            }
        }



        private void LbTituloLeccion_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LbTituloContenido_Click(object sender, EventArgs e)
        {

        }

        private void LbTituloContenido_Click_1(object sender, EventArgs e)
        {

        }

        private void LbSubtitulo_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

