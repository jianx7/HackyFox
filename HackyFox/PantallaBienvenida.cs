namespace HackyFox
{
    public partial class PantallaBienvenida : Form
    {
        public PantallaBienvenida()
        {
            InitializeComponent();

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

        private void pbFondoBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void lbBienvenida_Click(object sender, EventArgs e)
        {

        }
    }
}
