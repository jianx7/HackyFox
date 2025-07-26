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
        // Diccionario para almacenar la ubicaci�n y tama�o original de los controles
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
            controlesOriginales[nUDNacimiento] = nUDNacimiento.Bounds;

            // Configuraci�n NumericUpDown para edad
            nUDNacimiento.Minimum = 7;
            nUDNacimiento.Maximum = 12;
            nUDNacimiento.Value = 7;
            nUDNacimiento.Increment = 1;
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

                if (ctrl is Label || ctrl is Button || ctrl is TextBox)
                {
                    ctrl.Font = new Font(ctrl.Font.FontFamily, fuenteOriginal * Math.Min(escalaX, escalaY));
                }
            }
        }

        private void btnRegistroAlias_Click(object sender, EventArgs e)
        {
            string aliasIngresado = tbAliasRegistro.Text.Trim();
            int edadIngresada = (int)nUDNacimiento.Value;

            if (string.IsNullOrEmpty(aliasIngresado))
            {
                MessageBox.Show("Por favor, escribe un alias.");
                return;
            }

            try
            {
                if (AliasDB.ExisteAlias(aliasIngresado))
                {
                    MessageBox.Show("�Ups! Ese nombre ya est� ocupado. Elige uno �nico para ti.");
                    return;
                }

                int idAlias = AliasDB.RegistrarAlias(aliasIngresado, edadIngresada);

                int idProgreso = ProgresoDB.ObtenerOCrearProgreso(idAlias);

                Sesion.IniciarSesion(idAlias, idProgreso);

                MessageBox.Show("�Buen trabajo! �Tu nombre qued� registrado con �xito!");

                MenuLecciones menu = new MenuLecciones();
                menu.StartPosition = FormStartPosition.Manual;
                menu.Location = this.Location;
                menu.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("�Uy! Algo sali� mal al guardar. Int�ntalo otra vez.\n" + ex.Message);
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

        private void nUDNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
