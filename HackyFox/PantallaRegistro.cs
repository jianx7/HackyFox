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
        // Diccionario para almacenar la ubicación y tamaño original de los controles
        Dictionary<Control, Rectangle> controlesOriginales = new Dictionary<Control, Rectangle>();
        Size tamañoFormularioOriginal;
        float fuenteOriginal;

        //Constructor
        public PantallaRegistro()
        {
            InitializeComponent();
            this.Resize += PantallaRegistro_Resize;
        }

        private void PantallaRegistro_Load(object sender, EventArgs e)
        {
            // Guardamos el tamaño actual del formulario y el tamaño de fuente base
            tamañoFormularioOriginal = this.ClientSize;
            fuenteOriginal = lbNacimiento.Font.Size; 
            //Guardar ubicacion u tamaño de cada control
            controlesOriginales[pbLogoRegistro] = pbLogoRegistro.Bounds;
            controlesOriginales[lbNacimiento] = lbNacimiento.Bounds;
            controlesOriginales[pbPastelRegistro] = pbPastelRegistro.Bounds;
            controlesOriginales[lbAliasRegistro] = lbAliasRegistro.Bounds;
            controlesOriginales[lbAdvertenciaRegistro] = lbAdvertenciaRegistro.Bounds;
            controlesOriginales[tbAliasRegistro] = tbAliasRegistro.Bounds;
            controlesOriginales[btnRegistroAlias] = btnRegistroAlias.Bounds;
            controlesOriginales[pbFondoRegistro] = pbFondoRegistro.Bounds;
            controlesOriginales[btnRegistroRegresar] = btnRegistroRegresar.Bounds;
            controlesOriginales[dTPNacimiento] = dTPNacimiento.Bounds;

        }

        //Evento de redimensionamiento del formulario
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

        // Evento para el botón de registro
        private void btnRegistroAlias_Click(object sender, EventArgs e)
        {
            //Se obtiene el alias y la fecha de nacimiento ingresados
            string aliasIngresado = tbAliasRegistro.Text.Trim();
            DateTime fechaNacimiento = dTPNacimiento.Value;
            //Valida si esta vacio
            if (string.IsNullOrEmpty(aliasIngresado))
            {
                MessageBox.Show("Por favor, escribe un alias.");
                return;
            }
            //vlida que la fecha de nacimiento no sea en el futuro
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
                    MessageBox.Show("¡Ups! Ese nombre ya está ocupado. Elige uno único para ti.");
                    return;
                }

                // Registrar el alias y obtener el ID
                int idAlias = AliasDB.RegistrarAlias(aliasIngresado, fechaNacimiento);

                // Crear u obtener progreso
                int idProgreso = ProgresoDB.ObtenerOCrearProgreso(idAlias);

                // Guardar en sesión 
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
        // Evento para el botón de regresar
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