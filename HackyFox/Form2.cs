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
    public partial class PantallaRegistro : Form
    {
         string cadenaConexion = "server = localhost; username = root; password = rubi2006; database = hackyfox";
        public PantallaRegistro()
        {
            InitializeComponent();
        }

        private void PantallaRegistro_Load(object sender, EventArgs e)
        {
          
        }

        private void btnRegistroAlias_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNacimiento.Text) ||
    string.IsNullOrWhiteSpace(tbAliasRegistro.Text))
    

{
    MessageBox.Show("Por favor, llena todos los campos.");
    return;
}

try
{
    using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
    {
        conexion.Open();


        string query = "INSERT INTO alias (fecha_nacimiento, alias) " +
                       "VALUES (@fecha_nacimiento, @alias)";
        MySqlCommand comando = new MySqlCommand(query, conexion);

        comando.Parameters.AddWithValue("@fecha_nacimiento", tbAliasRegistro.Text);
        comando.Parameters.AddWithValue("@alias", tbNacimiento.Text);
        
        


        comando.ExecuteNonQuery();

        MessageBox.Show("¡Muy bien hecho, acabas de terminar tu registro!");
    }
}
catch (Exception ex)
{
    MessageBox.Show("Error al guardar: " + ex.Message);
}
           
        }
    }
}
