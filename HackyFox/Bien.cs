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
        //Alamacenar el id de la lección actual
        private readonly int _idLeccionActual;

        // Constructor
        public Bien(int idLeccionActual)
        {
            InitializeComponent();
            _idLeccionActual = idLeccionActual;
        }

        private void btnRetoADinamica_Click(object sender, EventArgs e)
        {
            //Se decide que form abrir según el id de la lección actual
            Form dinamica = _idLeccionActual switch
            {
                1 => new Dinamica1(_idLeccionActual),//Polimorfismo
                2 => new Dinamica2(_idLeccionActual),
                3 => new Dinamica3(_idLeccionActual),
                4 => new Dinamica4(_idLeccionActual),
                5 => new Dinamica5(_idLeccionActual),
                6 => new Dinamica6(_idLeccionActual),
                _ => new Dinamica1(_idLeccionActual) // Valor por defecto
            };

            dinamica.StartPosition = FormStartPosition.CenterScreen;
            dinamica.Location = this.Location; //Abrir la dinámica correspondiente
            dinamica.Show();
            this.Close();
        }
    }
}
