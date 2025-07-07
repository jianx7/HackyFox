using MySql.Data.MySqlClient;
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
    public partial class MenuLecciones : Form
    {

        public MenuLecciones()
        {
            InitializeComponent();
        } 

        //Redimensionar imagen de botones
        private void MenuLecciones_Load(object sender, EventArgs e)
        {
            //Panel de menú

            //Menu
            btnMenu.Image = Properties.Resources.menu;
            btnMenu.Image = new Bitmap(Properties.Resources.menu, new Size(52, 52));
            //Usuario
            btnUser.Image = Properties.Resources.user;
            btnUser.Image = new Bitmap(Properties.Resources.user, new Size(52, 52));
            //Lecciones
            btnLecciones.Image = Properties.Resources.book;
            btnLecciones.Image = new Bitmap(Properties.Resources.book, new Size(52, 52));
            //Mascota
            btnMascota.Image = Properties.Resources.mascota;
            btnMascota.Image = new Bitmap(Properties.Resources.mascota, new Size(52, 52));

            //Botones de lecciones

            //Info
            btnInfo.Image = Properties.Resources.flecha;
            btnInfo.Image = new Bitmap(Properties.Resources.flecha, new Size(52, 52));
            //Reto
            btnReto.Image = Properties.Resources._lock;
            btnReto.Image = new Bitmap(Properties.Resources._lock, new Size(52, 52));
            //Dinamica
            btnDinamic.Image = Properties.Resources._lock;
            btnDinamic.Image = new Bitmap(Properties.Resources._lock, new Size(52, 52));

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //Colapsar el menu llamando al método ColapseMenu
            ColapseMenu();
        }

        private void ColapseMenu()
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
            MenuLecciones menuLecciones = new MenuLecciones();
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Leccion leccion = new Leccion();
            leccion.ShowDialog();
            this.Close();
        }
    }
}
