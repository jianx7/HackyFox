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
        List<string> mochilaCiberdefensor = new List<string>();
        int objetosCorrectos = 0;

        public Dinamica6()
        {
            InitializeComponent();
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
                dinamicaButton.Image = new Bitmap(dinamicaButton.Image, new Size(110, 108));
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

        //Verifica si el objeto ya está en la mochila y lo agrega si no lo está
        private void AgregarObjetoCorrecto(string nombre, Button boton)
        {
            // Evita que el usuario lo presione dos veces
            if (!mochilaCiberdefensor.Contains(nombre))
            {
                mochilaCiberdefensor.Add(nombre);
                objetosCorrectos++;
                boton.Enabled = false; // Desactiva el botón ya presionado

                // Aquí puedes poner una animación o cambiar la imagen de la mochila

                if (objetosCorrectos == 4)
                {
                    // Mostrar la ventana de felicitación
                    Dinamica6Final ventanaFinal = new Dinamica6Final();
                    ventanaFinal.ShowDialog();
                }
            }
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
        //Mensaje de error, el usuario puede intentarlo de nuevo
        private void MostrarError()
        {
            DialogResult resultado = MessageBox.Show("⚠️ Ese objeto no te protege en internet.\n\n¿Quieres intentarlo de nuevo?",
                "¡Piénsalo mejor!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
