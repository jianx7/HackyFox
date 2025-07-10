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
    public partial class RetoRelampago : Form
    {
        private int idLeccionActual;

        // Constructor que acepta un argumento
        public RetoRelampago(int idLeccionActual)
        {
            this.idLeccionActual = idLeccionActual;
            InitializeComponent();
      
        }

    }
}
