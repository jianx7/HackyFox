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
using HackyFox.Clases;

namespace HackyFox
{
    public partial class Bien : Form
    {
        private readonly int _idLeccionActual;

        public Bien(int idLeccionActual)
        {
            InitializeComponent();
            _idLeccionActual = idLeccionActual;
        }

        private void btnRetoADinamica_Click(object sender, EventArgs e)
        {
            Form dinamica = _idLeccionActual switch
            {
                1 => new Dinamica1(_idLeccionActual),
                2 => new Dinamica2(_idLeccionActual),
                3 => new Dinamica3(_idLeccionActual),
                4 => new Dinamica4(_idLeccionActual),
                5 => new Dinamica5(_idLeccionActual),
                6 => new Dinamica6(_idLeccionActual),
                _ => new Dinamica1(_idLeccionActual) // Valor por defecto
            };

            dinamica.StartPosition = FormStartPosition.Manual;
            dinamica.Location = this.Location;
            dinamica.Show();
            this.Close();
        }
    }
}
