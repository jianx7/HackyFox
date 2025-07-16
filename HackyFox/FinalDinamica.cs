using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HackyFox.MenuLecciones;
using HackyFox.Clases;

namespace HackyFox
{

    public partial class FinalDinamica : Form
    {
        private readonly int idLeccionActual;

        public FinalDinamica(int idLeccionActual)
        {
            InitializeComponent();
            this.idLeccionActual = idLeccionActual;
        }

        private void btnVolverAlMenu_Click(object sender, EventArgs e)
        {
            var menu = new MenuLecciones();
            menu.StartPosition = FormStartPosition.Manual;
            menu.Location = this.Location;
            menu.Show();
            menu.RefrescarSiguienteLeccion();
            this.Close();
        }

        private void btnSiguienteLeccion_Click(object sender, EventArgs e)
        {
            // (Si quieres volver a asegurarte de registrar, puedes repetir el insert aquí)

            var menu = new MenuLecciones();
            menu.StartPosition = FormStartPosition.Manual;
            menu.Location = this.Location;
            menu.Show();
            menu.RefrescarSiguienteLeccion();
            this.Close();
        }
    }
}
