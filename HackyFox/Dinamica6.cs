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
    public partial class Dinamica6 : Form
    {
        //Guarda el id de la lección actual
        private readonly int idLeccionActual;

        // Lista para almacenar los objetos correctos
        List<string> mochilaCiberdefensor = new List<string>();
        int objetosCorrectos = 0;

        // Constructor 
        public Dinamica6(int idLeccionActual)
        {
            InitializeComponent();
            this.idLeccionActual = Sesion.LeccionActual;
        }

        //Redimensionar imagen de botones
        private void Dinamica6_Load(object sender, EventArgs e)
        {
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
            {
                menuButton.Image = new Bitmap(menuButton.Image, new Size(52, 52));
            }

            foreach (Button dinamicaButton in panelDinamica.Controls.OfType<Button>())
            {
                dinamicaButton.Image = new Bitmap(dinamicaButton.Image, new Size(100, 98));
                
            }
        }

        //Desplegar el menú
        private void btnMenu_Click(object sender, EventArgs e)
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


        private void btnUser_Click(object sender, EventArgs e)
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
                MenuProgreso menuProgreso = new MenuProgreso();
                menuProgreso.Show();
                this.Close();
            }
        }

        private void btnLecciones_Click(object sender, EventArgs e)
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
                MenuLecciones menuLecciones = new MenuLecciones();
                menuLecciones.Show();
                this.Close();
            }
        }

        private void btnMascota_Click(object sender, EventArgs e)
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
                MenuMascota menuMascota = new MenuMascota();
                menuMascota.Show();
                this.Close();
            }
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



        //Verifica si el objeto ya está en la mochila y lo agrega si no lo está
        private void AgregarObjetoCorrecto(string nombre, Button boton)
        {
            // Evita que el usuario lo presione dos veces
            if (!mochilaCiberdefensor.Contains(nombre))
            {
                mochilaCiberdefensor.Add(nombre);
                objetosCorrectos++;
                boton.Enabled = false; // Desactiva el botón ya presionado

                if (objetosCorrectos == 4)
                {
                    // Mostrar la ventana de felicitación
                    //Registrar la dinámica como completada
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
        //Botones de opción correcta
        private void btnGuia_Click(object sender, EventArgs e)
        {
            AgregarObjetoCorrecto("Guía HackyFox", btnGuia);
        }
        private void btnSeguro_Click(object sender, EventArgs e)
        {
            AgregarObjetoCorrecto("Contraseña segura", btnSeguro);
        }
        private void btnLupa_Click(object sender, EventArgs e)
        {
            AgregarObjetoCorrecto("Lupa para detectar sospechosos", btnLupa);
        }
        private void btnConfianza_Click(object sender, EventArgs e)
        {
            AgregarObjetoCorrecto("Adulto de Confianza", btnConfianza);
        }


        //Mensaje de error, el usuario puede intentarlo de nuevo
        private void MostrarError()
        {
            DialogResult resultado = MessageBox.Show("⚠️ Ese objeto no te protege en internet.\n\n¿Quieres intentarlo de nuevo?",
                "¡Piénsalo mejor!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Botones de opción incorrecta
        private void btnDesconocido_Click(object sender, EventArgs e)
        {
            MostrarError();
        }
        private void btnDulces_Click(object sender, EventArgs e)
        {
            MostrarError();
        }
        private void btnInseguro_Click(object sender, EventArgs e)
        {
            MostrarError();
        }
    }
}
