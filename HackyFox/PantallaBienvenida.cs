namespace HackyFox
{
    public partial class PantallaBienvenida : Form
    {
        // Diccionario para almacenar las posiciones y tamaños originales de los controles
        Dictionary<Control, Rectangle> controlesOriginales = new Dictionary<Control, Rectangle>();
        float fuenteOriginal;
        Size tamañoFormularioOriginal;

        // Constructor
        public PantallaBienvenida()
        {
            InitializeComponent();
            this.Resize += PantallaBienvenida_Resize;
        }


        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            PantallaInicioDeSesion newForm = new PantallaInicioDeSesion();
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = this.Location; // Mantener la misma ubicación
            newForm.Show();
            this.Hide(); // Ocultar la pantalla actual

        }


        private void PantallaBienvenida_Load(object sender, EventArgs e)
        {
            // Guardar tamaños originales
            foreach (Control ctrl in this.Controls)
                controlesOriginales[ctrl] = ctrl.Bounds;

            fuenteOriginal = lbBienvenida.Font.Size;
            tamañoFormularioOriginal = this.ClientSize;

            this.Resize += PantallaBienvenida_Resize;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            PantallaRegistro newForm = new PantallaRegistro();
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = this.Location; // Mantener la misma ubicación
            newForm.Show();
            this.Hide(); // Ocultar la pantalla actual
        }

        private void pbLogoBienvenida_Click(object sender, EventArgs e)
        {

        }


        private void lbBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void PantallaBienvenida_Resize(object? sender, EventArgs e)
        {

            float escalaX = (float)this.ClientSize.Width / tamañoFormularioOriginal.Width;
            float escalaY = (float)this.ClientSize.Height / tamañoFormularioOriginal.Height;

            foreach (Control ctrl in this.Controls)
            {
                if (controlesOriginales.ContainsKey(ctrl))
                {
                    Rectangle rect = controlesOriginales[ctrl];

                    ctrl.Left = (int)(rect.Left * escalaX);
                    ctrl.Top = (int)(rect.Top * escalaY);
                    ctrl.Width = (int)(rect.Width * escalaX);
                    ctrl.Height = (int)(rect.Height * escalaY);

                    // Escalar fuente 
                    ctrl.Font = new Font(ctrl.Font.FontFamily, fuenteOriginal * Math.Min(escalaX, escalaY));
                }
            }
        }

        private void pbFondoBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void btnBienvenidaCerrar_Click(object sender, EventArgs e)
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
    }
}