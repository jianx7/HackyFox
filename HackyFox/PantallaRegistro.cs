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
        string cadenaConexion = "server=localhost;username=root;password=rubi2006;database=hackyfox";

        Dictionary<Control, Rectangle> controlesOriginales = new Dictionary<Control, Rectangle>();
        Size tamañoFormularioOriginal;
        float fuenteOriginal;
        public PantallaRegistro()
        {
            InitializeComponent();
            this.Resize += PantallaRegistro_Resize;
        }

        private void PantallaRegistro_Load(object sender, EventArgs e)
        {
            tamañoFormularioOriginal = this.ClientSize;

            // Fuente base (puedes usar cualquier label como referencia)
            fuenteOriginal = lbNacimiento.Font.Size;

            // Guardar ubicación y tamaño de cada control
            controlesOriginales[pbLogoRegistro] = pbLogoRegistro.Bounds;
            controlesOriginales[lbNacimiento] = lbNacimiento.Bounds;
            controlesOriginales[dTPNacimiento] = dTPNacimiento.Bounds;
            controlesOriginales[pbPastelRegistro] = pbPastelRegistro.Bounds;
            controlesOriginales[lbAliasRegistro] = lbAliasRegistro.Bounds;
            controlesOriginales[lbAdvertenciaRegistro] = lbAdvertenciaRegistro.Bounds;
            controlesOriginales[tbAliasRegistro] = tbAliasRegistro.Bounds;
            controlesOriginales[btnRegistroAlias] = btnRegistroAlias.Bounds;
            controlesOriginales[pbFondoRegistro] = pbFondoRegistro.Bounds;
            controlesOriginales[btnRegistroRegresar] = btnRegistroRegresar.Bounds;

        }

        private void PantallaRegistro_Resize(object? sender, EventArgs e)
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

                // Ajustar fuente solo en controles con texto
                if (ctrl is Label || ctrl is Button || ctrl is TextBox)
                {
                    ctrl.Font = new Font(ctrl.Font.FontFamily, fuenteOriginal * Math.Min(escalaX, escalaY));
                }
            }
        }


        private void btnRegistroAlias_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(dTPNacimiento.Text) || string.IsNullOrWhiteSpace(tbAliasRegistro.Text))
            {
                MessageBox.Show("¡Oops! Aún hay casillas vacías. ¿Puedes completarlas?");
                return;
            }

            string aliasIngresado = tbAliasRegistro.Text.Trim();

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    // 1. Verificar si el alias ya existe
                    string verificarAlias = "SELECT COUNT(*) FROM alias WHERE LOWER(alias) = LOWER(@alias)";
                    MySqlCommand verificarCmd = new MySqlCommand(verificarAlias, conexion);
                    verificarCmd.Parameters.AddWithValue("@alias", aliasIngresado);

                    int existe = Convert.ToInt32(verificarCmd.ExecuteScalar());

                    if (existe > 0)
                    {
                        MessageBox.Show("¡Ups! Ese nombre ya está ocupado. Elige uno único para ti.");
                        return;
                    }

                    // 2. Si no existe, insertar
                    string fechaNacimiento = dTPNacimiento.Value.ToString("yyyy-MM-dd");
                    string fechaActual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    string insertQuery = @"INSERT INTO alias (fecha_nacimiento, alias, created_at, updated_at) 
                                   VALUES (@fecha_nacimiento, @alias, @created_at, @updated_at)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conexion);
                    insertCmd.Parameters.AddWithValue("@fecha_nacimiento", fechaNacimiento);
                    insertCmd.Parameters.AddWithValue("@alias", aliasIngresado);
                    insertCmd.Parameters.AddWithValue("@created_at", fechaActual);
                    insertCmd.Parameters.AddWithValue("@updated_at", fechaActual);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("¡Buen trabajo! ¡Tu nombre quedó registrado con éxito!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Uy! Algo salió mal al guardar. Inténtalo otra vez." + ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistroRegresar_Click(object sender, EventArgs e)
        {
            PantallaBienvenida volver = new PantallaBienvenida();
            volver.StartPosition = FormStartPosition.Manual;
            volver.Location = this.Location;
            volver.Show();
            this.Close(); // Cierra PantallaRegistro
        }
    }
}