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
    public partial class PantallaRegistro : Form
    {
<<<<<<< HEAD
=======
        string cadenaConexion = "server=localhost;username=root;password=rubi2006;database=hackyfox";

>>>>>>> fc98b296748f4597c8c97a9a9f6582c13e323af4
        Dictionary<Control, Rectangle> controlesOriginales = new Dictionary<Control, Rectangle>();
        Size tamañoFormularioOriginal;
        float fuenteOriginal;

<<<<<<< HEAD
=======

>>>>>>> fc98b296748f4597c8c97a9a9f6582c13e323af4
        public PantallaRegistro()
        {
            InitializeComponent();
            this.Resize += PantallaRegistro_Resize;
        }

        private void PantallaRegistro_Load(object sender, EventArgs e)
        {
            tamañoFormularioOriginal = this.ClientSize;
            fuenteOriginal = lbNacimiento.Font.Size;

            controlesOriginales[pbLogoRegistro] = pbLogoRegistro.Bounds;
            controlesOriginales[lbNacimiento] = lbNacimiento.Bounds;
            controlesOriginales[pbPastelRegistro] = pbPastelRegistro.Bounds;
            controlesOriginales[lbAliasRegistro] = lbAliasRegistro.Bounds;
            controlesOriginales[lbAdvertenciaRegistro] = lbAdvertenciaRegistro.Bounds;
            controlesOriginales[tbAliasRegistro] = tbAliasRegistro.Bounds;
            controlesOriginales[btnRegistroAlias] = btnRegistroAlias.Bounds;
            controlesOriginales[pbFondoRegistro] = pbFondoRegistro.Bounds;
            controlesOriginales[btnRegistroRegresar] = btnRegistroRegresar.Bounds;
<<<<<<< HEAD
=======
            controlesOriginales[dTPNacimiento] = dTPNacimiento.Bounds;

>>>>>>> fc98b296748f4597c8c97a9a9f6582c13e323af4
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

                if (ctrl is Label || ctrl is Button || ctrl is TextBox)
                {
                    ctrl.Font = new Font(ctrl.Font.FontFamily, fuenteOriginal * Math.Min(escalaX, escalaY));
                }
            }
        }

        private void btnRegistroAlias_Click(object sender, EventArgs e)
        {
            string aliasIngresado = tbAliasRegistro.Text.Trim();
            DateTime fechaNacimiento = dTPNacimiento.Value;

            if (string.IsNullOrEmpty(aliasIngresado))
            {
                MessageBox.Show("Por favor, escribe un alias.");
                return;
            }

            if (fechaNacimiento > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser en el futuro.");
                return;
            }

            try
            {
                // Verificar si el alias ya existe
                if (AliasDB.ExisteAlias(aliasIngresado))
                {
<<<<<<< HEAD
                    MessageBox.Show("¡Ups! Ese nombre ya está ocupado. Elige uno único para ti.");
                    return;
=======
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



                    // Obtener el ID del alias recién registrado
                    string idQuery = "SELECT id_alias FROM alias WHERE alias = @alias LIMIT 1;";
                    MySqlCommand idCmd = new MySqlCommand(idQuery, conexion);
                    idCmd.Parameters.AddWithValue("@alias", aliasIngresado);
                    int idAlias = Convert.ToInt32(idCmd.ExecuteScalar());

                   

                    // Redirigir al formulario principal
                    MenuLecciones menu = new MenuLecciones();
                    menu.StartPosition = FormStartPosition.Manual;
                    menu.Location = this.Location;
                    menu.Show();
                    this.Close(); // Cierra PantallaRegistro
>>>>>>> fc98b296748f4597c8c97a9a9f6582c13e323af4
                }

                // Registrar el alias y obtener el ID
                int idAlias = AliasDB.RegistrarAlias(aliasIngresado, fechaNacimiento);

                // Crear u obtener progreso
                int idProgreso = ProgresoDB.ObtenerOCrearProgreso(idAlias);

                // Guardar en sesión global
                Sesion.IniciarSesion(idAlias, idProgreso);

                MessageBox.Show("¡Buen trabajo! ¡Tu nombre quedó registrado con éxito!");

                // Redirigir al menú de lecciones
                MenuLecciones menu = new MenuLecciones();
                menu.StartPosition = FormStartPosition.Manual;
                menu.Location = this.Location;
                menu.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Uy! Algo salió mal al guardar. Inténtalo otra vez.\n" + ex.Message);
            }
        }

        private void btnRegistroRegresar_Click(object sender, EventArgs e)
        {
            PantallaBienvenida volver = new PantallaBienvenida();
            volver.StartPosition = FormStartPosition.Manual;
            volver.Location = this.Location;
            volver.Show();
            this.Close();
        }
    }
}