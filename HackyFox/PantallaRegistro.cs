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
using static HackyFox.PantallaInicioDeSesion;

namespace HackyFox
{
    public partial class PantallaRegistro : Form
    {
        string cadenaConexion = "server=localhost;username=root;password=rute;database=hackyfox";

        Dictionary<Control, Rectangle> controlesOriginales = new Dictionary<Control, Rectangle>();
        Size tama�oFormularioOriginal;
        float fuenteOriginal;
        public PantallaRegistro()
        {
            InitializeComponent();
            this.Resize += PantallaRegistro_Resize;
        }



        private void PantallaRegistro_Load(object sender, EventArgs e)
        {
            tama�oFormularioOriginal = this.ClientSize;

            // Fuente base (puedes usar cualquier label como referencia)
            fuenteOriginal = lbNacimiento.Font.Size;

            // Guardar ubicaci�n y tama�o de cada control
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
            float escalaX = (float)this.ClientSize.Width / tama�oFormularioOriginal.Width;
            float escalaY = (float)this.ClientSize.Height / tama�oFormularioOriginal.Height;

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
                MessageBox.Show("�Oops! A�n hay casillas vac�as. �Puedes completarlas?");
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
                        MessageBox.Show("�Ups! Ese nombre ya est� ocupado. Elige uno �nico para ti.");
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

                    MessageBox.Show("�Buen trabajo! �Tu nombre qued� registrado con �xito!");



                    // Obtener el ID del alias reci�n registrado
                    string idQuery = "SELECT id_alias FROM alias WHERE alias = @alias LIMIT 1;";
                    MySqlCommand idCmd = new MySqlCommand(idQuery, conexion);
                    idCmd.Parameters.AddWithValue("@alias", aliasIngresado);
                    int idAlias = Convert.ToInt32(idCmd.ExecuteScalar());

                    // Insertar registro en progreso_general
                    string progresoQuery = @"INSERT INTO progreso_general 
                   (id_alias, total_lecciones, lecciones_completadas, porcentaje_global, fecha_creacion, fecha_actualizacion)
                    VALUES (@idAlias, 0, 0, 0.00, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);";
                    MySqlCommand progresoCmd = new MySqlCommand(progresoQuery, conexion);
                    progresoCmd.Parameters.AddWithValue("@idAlias", idAlias);
                    progresoCmd.ExecuteNonQuery();

                   

                    // Redirigir al formulario principal
                    MenuLecciones menu = new MenuLecciones();
                    menu.StartPosition = FormStartPosition.Manual;
                    menu.Location = this.Location;
                    menu.Show();
                    this.Close(); // Cierra PantallaRegistro
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("�Uy! Algo sali� mal al guardar. Int�ntalo otra vez." + ex.Message);
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