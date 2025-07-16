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
    public partial class Dinamica3Contraseña : Form
    {
        public Dinamica3Contraseña(string contraseñaGenerada)
        {
            InitializeComponent();
            lbContraseña.Text = contraseñaGenerada;
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Bien bien = new Bien(Sesion.LeccionActual);
            bien.Show();
            this.Close();
        }
    }
}
