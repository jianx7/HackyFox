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
    public partial class MenuMascota : Form
    {
        public MenuMascota()
        {
            InitializeComponent();
        }

        private void lbDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            //Colapsar el menu llamando al método colapseMenu
            colapseMenu();
        }

        private void colapseMenu()
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
                btnMenu.Text = "HackyFox";
                btnMenu.ImageAlign = ContentAlignment.MiddleLeft;

                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    if (menuButton.Tag != null) // Verificación para evitar referencias nulas
                    {
                        menuButton.Text = "   " + menuButton.Tag.ToString();
                    }
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
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

        private void btnLecciones_Click(object sender, EventArgs e)
        {
            MenuLecciones menuLecciones = new MenuLecciones();
            menuLecciones.Show();
            this.Close(); // Cierra el formulario actual
        }

        //Redimensionar tomaño de los botones del menu
        private void MenuMascota_Load(object sender, EventArgs e)
        {
            //Panel de menú
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
            {
                menuButton.Image = new Bitmap(menuButton.Image, new Size(52, 52));
            }
            //Menu
            btnMenu.Image = Properties.Resources.menu;
            btnMenu.Image = new Bitmap(Properties.Resources.menu, new Size(52, 52));
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            MenuProgreso menuProgreso = new MenuProgreso();
            menuProgreso.Show();
            this.Close(); // Cierra el formulario actual
        }
    }
}
