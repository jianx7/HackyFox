namespace HackyFox
{
    partial class Dinamica3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnMascota = new Button();
            btnLecciones = new Button();
            btnUser = new Button();
            btnMenu = new Button();
            panelDinamica = new Panel();
            pbDetective = new PictureBox();
            btnNext = new Btn_personalizado();
            lbElige = new Label();
            lbCambiante = new Label();
            tbContraseña = new TextBox();
            pbTitulo = new PictureBox();
            panelDashboard = new Panel();
            lbLeccion = new Label();
            panelMenu.SuspendLayout();
            panelDinamica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDetective).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTitulo).BeginInit();
            panelDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(155, 209, 219);
            panelMenu.Controls.Add(btnSalir);
            panelMenu.Controls.Add(btnMascota);
            panelMenu.Controls.Add(btnLecciones);
            panelMenu.Controls.Add(btnUser);
            panelMenu.Controls.Add(btnMenu);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(100, 725);
            panelMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 202, 96);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Clear Sans", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.FromArgb(0, 151, 178);
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.LongArrowLeft;
            btnSalir.IconColor = Color.FromArgb(0, 151, 178);
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 656);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(10, 0, 0, 0);
            btnSalir.Size = new Size(100, 69);
            btnSalir.TabIndex = 12;
            btnSalir.Tag = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMascota
            // 
            btnMascota.Dock = DockStyle.Top;
            btnMascota.FlatAppearance.BorderSize = 0;
            btnMascota.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 241, 62);
            btnMascota.FlatStyle = FlatStyle.Flat;
            btnMascota.Font = new Font("Clear Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMascota.ForeColor = Color.FromArgb(0, 151, 178);
            btnMascota.Image = Properties.Resources.mascota;
            btnMascota.ImageAlign = ContentAlignment.MiddleLeft;
            btnMascota.Location = new Point(0, 243);
            btnMascota.Name = "btnMascota";
            btnMascota.Padding = new Padding(10, 0, 0, 0);
            btnMascota.RightToLeft = RightToLeft.No;
            btnMascota.Size = new Size(100, 75);
            btnMascota.TabIndex = 11;
            btnMascota.Tag = "Mascota";
            btnMascota.TextAlign = ContentAlignment.MiddleLeft;
            btnMascota.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMascota.UseVisualStyleBackColor = true;
            btnMascota.Click += btnMascota_Click;
            // 
            // btnLecciones
            // 
            btnLecciones.Dock = DockStyle.Top;
            btnLecciones.FlatAppearance.BorderSize = 0;
            btnLecciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 241, 62);
            btnLecciones.FlatStyle = FlatStyle.Flat;
            btnLecciones.Font = new Font("Clear Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLecciones.ForeColor = Color.FromArgb(0, 151, 178);
            btnLecciones.Image = Properties.Resources.book;
            btnLecciones.ImageAlign = ContentAlignment.MiddleLeft;
            btnLecciones.Location = new Point(0, 168);
            btnLecciones.Name = "btnLecciones";
            btnLecciones.Padding = new Padding(10, 0, 0, 0);
            btnLecciones.RightToLeft = RightToLeft.No;
            btnLecciones.Size = new Size(100, 75);
            btnLecciones.TabIndex = 10;
            btnLecciones.Tag = "Lecciones";
            btnLecciones.TextAlign = ContentAlignment.MiddleLeft;
            btnLecciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLecciones.UseVisualStyleBackColor = true;
            btnLecciones.Click += btnLecciones_Click;
            // 
            // btnUser
            // 
            btnUser.Dock = DockStyle.Top;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 241, 62);
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Clear Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.ForeColor = Color.FromArgb(0, 151, 178);
            btnUser.Image = Properties.Resources.user;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(0, 93);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(10, 0, 0, 0);
            btnUser.RightToLeft = RightToLeft.No;
            btnUser.Size = new Size(100, 75);
            btnUser.TabIndex = 9;
            btnUser.Tag = "Usuario";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 202, 96);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("04b_19", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.FromArgb(0, 151, 178);
            btnMenu.Image = Properties.Resources.menu;
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(10, 0, 0, 0);
            btnMenu.Size = new Size(100, 93);
            btnMenu.TabIndex = 3;
            btnMenu.Tag = "HackyFox";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelDinamica
            // 
            panelDinamica.BackColor = Color.FromArgb(242, 242, 242);
            panelDinamica.Controls.Add(pbDetective);
            panelDinamica.Controls.Add(btnNext);
            panelDinamica.Controls.Add(lbElige);
            panelDinamica.Controls.Add(lbCambiante);
            panelDinamica.Controls.Add(tbContraseña);
            panelDinamica.Controls.Add(pbTitulo);
            panelDinamica.Controls.Add(panelDashboard);
            panelDinamica.Dock = DockStyle.Fill;
            panelDinamica.Location = new Point(100, 0);
            panelDinamica.Name = "panelDinamica";
            panelDinamica.Size = new Size(1009, 725);
            panelDinamica.TabIndex = 1;
            // 
            // pbDetective
            // 
            pbDetective.BackgroundImage = Properties.Resources.detective;
            pbDetective.BackgroundImageLayout = ImageLayout.Stretch;
            pbDetective.Location = new Point(664, 361);
            pbDetective.Name = "pbDetective";
            pbDetective.Size = new Size(333, 361);
            pbDetective.TabIndex = 5;
            pbDetective.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(255, 206, 1);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Comfortaa", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.FromArgb(0, 74, 173);
            btnNext.Location = new Point(208, 406);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(254, 77);
            btnNext.TabIndex = 4;
            btnNext.Text = "Siguiente";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lbElige
            // 
            lbElige.AutoSize = true;
            lbElige.BackColor = Color.Transparent;
            lbElige.FlatStyle = FlatStyle.Flat;
            lbElige.Font = new Font("Comfortaa", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbElige.ForeColor = Color.FromArgb(0, 74, 173);
            lbElige.Location = new Point(117, 243);
            lbElige.Name = "lbElige";
            lbElige.Size = new Size(158, 53);
            lbElige.TabIndex = 0;
            lbElige.Text = "Elige tu";
            // 
            // lbCambiante
            // 
            lbCambiante.AutoSize = true;
            lbCambiante.FlatStyle = FlatStyle.Flat;
            lbCambiante.Font = new Font("Comfortaa", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCambiante.ForeColor = Color.FromArgb(249, 150, 11);
            lbCambiante.ImageAlign = ContentAlignment.MiddleLeft;
            lbCambiante.Location = new Point(264, 242);
            lbCambiante.Margin = new Padding(0);
            lbCambiante.Name = "lbCambiante";
            lbCambiante.RightToLeft = RightToLeft.No;
            lbCambiante.Size = new Size(330, 53);
            lbCambiante.TabIndex = 1;
            lbCambiante.Text = " palabra favorita:";
            lbCambiante.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbContraseña
            // 
            tbContraseña.BackColor = Color.AliceBlue;
            tbContraseña.Font = new Font("Comfortaa", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbContraseña.ForeColor = Color.FromArgb(97, 54, 37);
            tbContraseña.Location = new Point(129, 315);
            tbContraseña.Multiline = true;
            tbContraseña.Name = "tbContraseña";
            tbContraseña.PlaceholderText = "¡Escribelo aqui!";
            tbContraseña.Size = new Size(443, 55);
            tbContraseña.TabIndex = 3;
            // 
            // pbTitulo
            // 
            pbTitulo.BackgroundImage = Properties.Resources.TiuloD3;
            pbTitulo.BackgroundImageLayout = ImageLayout.Stretch;
            pbTitulo.Location = new Point(117, 114);
            pbTitulo.Name = "pbTitulo";
            pbTitulo.Size = new Size(793, 73);
            pbTitulo.TabIndex = 1;
            pbTitulo.TabStop = false;
            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.FromArgb(155, 209, 219);
            panelDashboard.Controls.Add(lbLeccion);
            panelDashboard.Dock = DockStyle.Top;
            panelDashboard.Location = new Point(0, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(1009, 80);
            panelDashboard.TabIndex = 0;
            // 
            // lbLeccion
            // 
            lbLeccion.AutoSize = true;
            lbLeccion.Font = new Font("Clear Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLeccion.ForeColor = Color.FromArgb(249, 249, 249);
            lbLeccion.Location = new Point(16, 19);
            lbLeccion.Name = "lbLeccion";
            lbLeccion.Size = new Size(356, 39);
            lbLeccion.TabIndex = 1;
            lbLeccion.Text = "Lección 3. La llave secreta";
            // 
            // Dinamica3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 725);
            Controls.Add(panelDinamica);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dinamica3";
            Text = "Dinamica3";
            Load += Dinamica3_Load;
            panelMenu.ResumeLayout(false);
            panelDinamica.ResumeLayout(false);
            panelDinamica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDetective).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTitulo).EndInit();
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelDinamica;
        private Panel panelDashboard;
        private Button btnMenu;
        private Button btnUser;
        private Button btnLecciones;
        private Button btnMascota;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Label lbLeccion;
        private PictureBox pbTitulo;
        private Label lbElige;
        private Label lbCambiante;
        private TextBox tbContraseña;
        private Btn_personalizado btnNext;
        private PictureBox pbDetective;
    }
}