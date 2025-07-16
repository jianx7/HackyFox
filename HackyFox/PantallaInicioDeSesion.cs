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
    public partial class PantallaInicioDeSesion : Form
    {
        // Diccionario para almacenar las posiciones y tamaños originales de los controles
        Dictionary<Control, Rectangle> controlesOriginales = new Dictionary<Control, Rectangle>();
        // Variables para almacenar el tamaño original del formulario y la fuente de un label
        Size tamañoFormularioOriginal;
        float fuenteOriginal;

        // Constructor 
        public PantallaInicioDeSesion()
        {
            InitializeComponent();
            this.Resize += PantallaInicioDeSesion_Resize;
        }

        private void PantallaInicioDeSesion_Load(object sender, EventArgs e)
        {
            // Guardar tamaños originales del formularrio y el tammo de fuente de un label
            tamañoFormularioOriginal = this.ClientSize;
            fuenteOriginal = lbInicioDeSesion.Font.Size;
            // Guardar tamaños y posiciones originales de los controles
            controlesOriginales[pbLogoInicioDeSesion] = pbLogoInicioDeSesion.Bounds;
            controlesOriginales[lbInicioDeSesion] = lbInicioDeSesion.Bounds;
            controlesOriginales[lbAliasInicioDeSesion] = lbAliasInicioDeSesion.Bounds;
            controlesOriginales[tbAliasInicioDeSesion] = tbAliasInicioDeSesion.Bounds;
            controlesOriginales[btnCorroborarAlias] = btnCorroborarAlias.Bounds;
            controlesOriginales[pbMascotaInicioDeSesion] = pbMascotaInicioDeSesion.Bounds;
            controlesOriginales[pbFondoInicioDeSesion] = pbFondoInicioDeSesion.Bounds;
            controlesOriginales[btnIniciarSesionRegresar] = btnIniciarSesionRegresar.Bounds;
        }

        // Evento que ajusta automáticamente los controles cuando se cambia el tamaño del formulario
        private void PantallaInicioDeSesion_Resize(object sender, EventArgs e)
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
                //Cambiar fuente si es control con texto
                if (ctrl is Label || ctrl is Button || ctrl is TextBox)
                {
                    ctrl.Font = new Font(ctrl.Font.FontFamily, fuenteOriginal * Math.Min(escalaX, escalaY));
                }
            }
        }
        //Evento que se ejecuta cuando se hace clic en el botón
        private void btnCorroborarAlias_Click(object sender, EventArgs e)
        {
            string aliasIngresado = tbAliasInicioDeSesion.Text.Trim();

            // Validar que el alias no esté vacío
            if (string.IsNullOrWhiteSpace(aliasIngresado))
            {
                MessageBox.Show("Por favor, ingresa tu alias.");
                return;
            }

            try
            {
                //Buscar el id de alias en la base de datos
                int idAlias = AliasDB.ObtenerIdAlias(aliasIngresado);

                if (idAlias == -1)
                {
                    MessageBox.Show("Alias no encontrado. ¿Estás seguro de que ya te registraste?");
                    return;
                }

                MessageBox.Show("¡Bienvenido de nuevo, " + aliasIngresado + "!");

                //Busca el progreso general del usuario y si no existe lo crea
                int idProgreso = ProgresoDB.ObtenerOCrearProgreso(idAlias);
                // Inicia la sesión del usuario
                Sesion.IniciarSesion(idAlias, idProgreso);

                MenuLecciones f = new MenuLecciones();
                f.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //Evento para regresar a la pantalla de bienvenida
        private void btnIniciarSesionRegresar_Click(object sender, EventArgs e)
        {
            PantallaBienvenida volver = new PantallaBienvenida();
            volver.StartPosition = FormStartPosition.Manual;
            volver.Location = this.Location;
            volver.Show();
            this.Close();// Cierra la pantalla de inicio de sesión
        }
    }
}
