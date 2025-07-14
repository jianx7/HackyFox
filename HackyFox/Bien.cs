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
    public partial class Bien : Form
    {
        public Bien()
        {
            InitializeComponent();
        }

        private void btnRetoADinamica_Click(object sender, EventArgs e)
        {
            Dinamica3 siguienteVentana = new Dinamica3();
            siguienteVentana.StartPosition = FormStartPosition.Manual;
            siguienteVentana.Location = this.Location;
            siguienteVentana.Show();
            this.Close();
        }
    }
}
