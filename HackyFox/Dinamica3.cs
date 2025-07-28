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
    public partial class Dinamica3 : Form
    {
        private readonly int idLeccionActual;

        // Variable para almacenar la contraseeña del usuario
        string palabraFavorita = "";
        string numFavorito = "";
        string letraMayuscula = "";
        string simbolo = "";

        int pasoActual = 0;


        public Dinamica3(int idLeccionActual)
        {
            InitializeComponent();
            this.idLeccionActual = Sesion.LeccionActual;
        }

        //Redimensionar imagen de botones
        private void Dinamica3_Load(object sender, EventArgs e)
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


        //Evento para el botón "Siguiente"
        private void btnNext_Click(object sender, EventArgs e)
        {
            string contraseña = tbContraseña.Text.Trim();

            //Validar que el campo de contraseña no esté vacío
            if (string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingresa una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Guardar la contraseña según el paso actual
            switch (pasoActual)
            {
                case 0:
                    palabraFavorita = contraseña;
                    lbCambiante.Text = "número favorito";
                    break;
                case 1:
                    numFavorito = contraseña;
                    lbCambiante.Text = "letra mayúscula";
                    break;
                case 2:
                    letraMayuscula = contraseña;
                    lbCambiante.Text = "simbolo (*, _)";
                    break;
                case 3:
                    simbolo = contraseña;
                    // Ya que terminó todo, generamos y mostramos la contraseña
                    string contraseñaGenerada = palabraFavorita + numFavorito + letraMayuscula + simbolo;
                    DialogResult resultado = MessageBox.Show($"🔐 ¡Tu llave secreta está lista! 🔐 \n\n Contraseña generada: \n" +
                        $"{contraseñaGenerada} \n\n Recuerda no compartirla con nadie");

                    var final = new FinalDinamica(idLeccionActual);
                    final.StartPosition = FormStartPosition.Manual;
                    final.Location = this.Location;
                    final.Show();
                    this.Close();

                    break;
            }
            pasoActual++;
            tbContraseña.Clear();
            tbContraseña.Focus();
        }
    }
}
