using HackyFox.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackyFox
{
    public partial class Dinamica5 : Form
    {
        private readonly int idLeccionActual;
        public Dinamica5(int idLeccionActual)
        {
            InitializeComponent();
            this.idLeccionActual = idLeccionActual;
        }

        //Redimensionar imagen de botones

        private void Dinamica5_Load(object sender, EventArgs e)
        {
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
            {
                menuButton.Image = new Bitmap(menuButton.Image, new Size(52, 52));
            }
        }
        //Menu despegable
        private void btnMenu_Click(object sender, EventArgs e)
        {
            openMenu();
            
        }

        private void openMenu()
        {
            //Cambiar el ancho del panel si es mayor a 300px
            if (this.panelMenu.Width > 300)
            {
                panelMenu.Width = 100;
                btnMenu.Text = string.Empty;
                btnMenu.ImageAlign = ContentAlignment.MiddleCenter;

                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = string.Empty;
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                //Cambiar el ancho del panel si es menor a 300px
                panelMenu.Width = 318;


                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    if (menuButton == btnMenu)
                        continue;

                    if (menuButton.Tag != null)
                    {
                        menuButton.Text = "   " + menuButton.Tag.ToString();
                    }
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
                btnMenu.Text = "HackyFox";
                btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
                btnMenu.Padding = new Padding(10, 0, 0, 0);
            }
        }


        //Método para cambiar de pantalla
        private void SalirYMostrarFormulario(Form formularioDestino)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro que quieres salir del juego?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                formularioDestino.Show();
                this.Close();
            }
        }
        //Llamar al método para cada boton
        private void btnUser_Click(object sender, EventArgs e)
        {
            SalirYMostrarFormulario(new MenuProgreso());
        }

        private void btnLecciones_Click(object sender, EventArgs e)
        {
            SalirYMostrarFormulario(new MenuLecciones());
        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            SalirYMostrarFormulario(new MenuMascota());
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show
           (
             "¿Estás seguro que quieres salir del juego?",
             "Salir",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
           );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); // Cierra toda la aplicación
            }
        }

        private void btn_D5R1_Click(object sender, EventArgs e)
        {
            MostrarError();
        }

        private void btn_D5R2_Click(object sender, EventArgs e)
        {
            MostrarCorrecto();
        }

        // Método para mostrar advertencia
        private void MostrarError()
        {
            DialogResult resultado = MessageBox.Show("Compartir tu dirección puede poner en riesgo tu seguridad.\n\n¿Quieres intentarlo de nuevo?",
                "¡Piénsalo bien!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Método para mostrar pantalla correcta
        private void MostrarCorrecto()
        {
            // 1) Registrar la dinámica como completada
            using var conexion = ConexionBD.ObtenerConexion();
            conexion.Open();
            ProgresoManager.RegistrarComponente(
                conexion,
                Sesion.UsuarioActual.IdProgresoGeneral,
                idLeccionActual,
                "dinamica");

            var final = new FinalDinamica(idLeccionActual);
            final.StartPosition = FormStartPosition.Manual;
            final.Location = this.Location;
            final.Show();
            this.Close();  
        }
    }
}
