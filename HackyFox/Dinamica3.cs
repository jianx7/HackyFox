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
        // Variable para almacenar la contraseeña del usuario
        string palabraFavorita = "";
        string numFavorito = "";
        string letraMayuscula = "";
        string simbolo = "";

        int pasoActual = 0;


        public Dinamica3()
        {
            InitializeComponent();
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            string contraseña = tbContraseña.Text.Trim();

            //Validar que el campo de contraseña no esté vacío
            if (string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingresa una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                    Dinamica3Contraseña dinamica3Contraseña = new Dinamica3Contraseña(contraseñaGenerada);
                    dinamica3Contraseña.ShowDialog();

                    break;
            }
            pasoActual++;
            tbContraseña.Clear();
            tbContraseña.Focus();
        }

        private void Dinamica3_Load(object sender, EventArgs e)
        {
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
            {
                menuButton.Image = new Bitmap(menuButton.Image, new Size(52, 52));
            }
        }
    }
}
