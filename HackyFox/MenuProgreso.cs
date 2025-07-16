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
    public partial class MenuProgreso : Form
    {
        public MenuProgreso()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
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

        //Redimensionar tamaño de los botones del menu
        private void MenuProgreso_Load(object sender, EventArgs e)
        {
            //Panel de menú
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
            {
                menuButton.Image = new Bitmap(menuButton.Image, new Size(52, 52));
            }
            //Menu
            btnMenu.Image = Properties.Resources.menu;
            btnMenu.Image = new Bitmap(Properties.Resources.menu, new Size(52, 52));

            using (MySqlConnection conexion = new MySqlConnection("server=localhost;username=root;password=1234;database=hackyfox"))
            {
                conexion.Open();
                string query = "SELECT porcentaje FROM tu_tabla WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", 1); // Cambia el ID según necesites

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal porcentajeDecimal = Convert.ToDecimal(reader["porcentaje"]);
                            int porcentajeEntero = (int)Math.Round(porcentajeDecimal);

                            ProgresoGeneral.Minimum = 0;
                            ProgresoGeneral.Maximum = 100;
                            ProgresoGeneral.Value = Math.Min(100, Math.Max(0, porcentajeEntero));
                        }
                    }
                }
            }
        }

        private void btnLecciones_Click(object sender, EventArgs e)
        {
            MenuLecciones menuLecciones = new MenuLecciones();
            menuLecciones.Show();
            this.Close(); // Cierra el formulario actual
        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            MenuMascota menuMascota = new MenuMascota();
            menuMascota.Show();
            this.Close(); // Cierra el formulario actual
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

        private void ProgresoGeneral_Click(object sender, EventArgs e)
        {

        }
    }
}
