namespace HackyFox
{
    partial class Dinamica6
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
            pbMochila = new PictureBox();
            btnGuia = new Button();
            btnDesconocido = new Button();
            btnInseguro = new Button();
            btnConfianza = new Button();
            btnSeguro = new Button();
            btnLupa = new Button();
            label2 = new Label();
            label1 = new Label();
            btnDulces = new Button();
            panelDashboard = new Panel();
            lbLeccion = new Label();
            panelMenu.SuspendLayout();
            panelDinamica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMochila).BeginInit();
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
            btnSalir.TabIndex = 13;
            btnSalir.Tag = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
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
            btnMascota.TabIndex = 12;
            btnMascota.Tag = "Mascota";
            btnMascota.TextAlign = ContentAlignment.MiddleLeft;
            btnMascota.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMascota.UseVisualStyleBackColor = true;
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
            btnLecciones.TabIndex = 11;
            btnLecciones.Tag = "Lecciones";
            btnLecciones.TextAlign = ContentAlignment.MiddleLeft;
            btnLecciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLecciones.UseVisualStyleBackColor = true;
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
            btnUser.TabIndex = 10;
            btnUser.Tag = "Usuario";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUser.UseVisualStyleBackColor = true;
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
            btnMenu.TabIndex = 4;
            btnMenu.Tag = "HackyFox";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelDinamica
            // 
            panelDinamica.BackColor = Color.FromArgb(242, 242, 242);
            panelDinamica.Controls.Add(pbMochila);
            panelDinamica.Controls.Add(btnGuia);
            panelDinamica.Controls.Add(btnDesconocido);
            panelDinamica.Controls.Add(btnInseguro);
            panelDinamica.Controls.Add(btnConfianza);
            panelDinamica.Controls.Add(btnSeguro);
            panelDinamica.Controls.Add(btnLupa);
            panelDinamica.Controls.Add(label2);
            panelDinamica.Controls.Add(label1);
            panelDinamica.Controls.Add(btnDulces);
            panelDinamica.Controls.Add(panelDashboard);
            panelDinamica.Dock = DockStyle.Fill;
            panelDinamica.Location = new Point(100, 0);
            panelDinamica.Name = "panelDinamica";
            panelDinamica.Size = new Size(1009, 725);
            panelDinamica.TabIndex = 1;
            // 
            // pbMochila
            // 
            pbMochila.BackgroundImage = Properties.Resources.mochila;
            pbMochila.BackgroundImageLayout = ImageLayout.Stretch;
            pbMochila.Location = new Point(399, 296);
            pbMochila.Name = "pbMochila";
            pbMochila.Size = new Size(218, 246);
            pbMochila.TabIndex = 12;
            pbMochila.TabStop = false;
            // 
            // btnGuia
            // 
            btnGuia.FlatAppearance.BorderSize = 0;
            btnGuia.FlatAppearance.MouseDownBackColor = Color.FromArgb(188, 223, 204);
            btnGuia.FlatStyle = FlatStyle.Flat;
            btnGuia.Font = new Font("Comfortaa", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuia.ForeColor = Color.FromArgb(97, 54, 37);
            btnGuia.Image = Properties.Resources.cabeza;
            btnGuia.Location = new Point(41, 283);
            btnGuia.Name = "btnGuia";
            btnGuia.Size = new Size(151, 136);
            btnGuia.TabIndex = 11;
            btnGuia.Text = "Guía HackyFox";
            btnGuia.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGuia.UseVisualStyleBackColor = true;
            btnGuia.Click += btnGuia_Click;
            // 
            // btnDesconocido
            // 
            btnDesconocido.FlatAppearance.BorderSize = 0;
            btnDesconocido.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 86, 61);
            btnDesconocido.FlatStyle = FlatStyle.Flat;
            btnDesconocido.Font = new Font("Comfortaa", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDesconocido.ForeColor = Color.FromArgb(97, 54, 37);
            btnDesconocido.Image = Properties.Resources.desconocido;
            btnDesconocido.Location = new Point(213, 400);
            btnDesconocido.Name = "btnDesconocido";
            btnDesconocido.Size = new Size(151, 136);
            btnDesconocido.TabIndex = 10;
            btnDesconocido.Text = "Desconocido en línea";
            btnDesconocido.TextImageRelation = TextImageRelation.TextAboveImage;
            btnDesconocido.UseVisualStyleBackColor = true;
            btnDesconocido.Click += btnDesconocido_Click;
            // 
            // btnInseguro
            // 
            btnInseguro.FlatAppearance.BorderSize = 0;
            btnInseguro.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 86, 61);
            btnInseguro.FlatStyle = FlatStyle.Flat;
            btnInseguro.Font = new Font("Comfortaa", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInseguro.ForeColor = Color.FromArgb(97, 54, 37);
            btnInseguro.Image = Properties.Resources.inseguro;
            btnInseguro.Location = new Point(698, 542);
            btnInseguro.Name = "btnInseguro";
            btnInseguro.Size = new Size(151, 136);
            btnInseguro.TabIndex = 9;
            btnInseguro.Text = "Contraseña simple";
            btnInseguro.TextImageRelation = TextImageRelation.TextAboveImage;
            btnInseguro.UseVisualStyleBackColor = true;
            btnInseguro.Click += btnInseguro_Click;
            // 
            // btnConfianza
            // 
            btnConfianza.FlatAppearance.BorderSize = 0;
            btnConfianza.FlatAppearance.MouseDownBackColor = Color.FromArgb(188, 223, 204);
            btnConfianza.FlatStyle = FlatStyle.Flat;
            btnConfianza.Font = new Font("Comfortaa", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfianza.ForeColor = Color.FromArgb(97, 54, 37);
            btnConfianza.Image = Properties.Resources.familia;
            btnConfianza.Location = new Point(646, 283);
            btnConfianza.Name = "btnConfianza";
            btnConfianza.Size = new Size(151, 136);
            btnConfianza.TabIndex = 8;
            btnConfianza.Text = "Adulto de confianza";
            btnConfianza.TextImageRelation = TextImageRelation.TextAboveImage;
            btnConfianza.UseVisualStyleBackColor = true;
            btnConfianza.Click += btnConfianza_Click;
            // 
            // btnSeguro
            // 
            btnSeguro.FlatAppearance.BorderSize = 0;
            btnSeguro.FlatAppearance.MouseDownBackColor = Color.FromArgb(188, 223, 204);
            btnSeguro.FlatStyle = FlatStyle.Flat;
            btnSeguro.Font = new Font("Comfortaa", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeguro.ForeColor = Color.FromArgb(97, 54, 37);
            btnSeguro.Image = Properties.Resources.seguro;
            btnSeguro.Location = new Point(74, 542);
            btnSeguro.Name = "btnSeguro";
            btnSeguro.Size = new Size(151, 136);
            btnSeguro.TabIndex = 7;
            btnSeguro.Text = "Contraseña segura";
            btnSeguro.TextImageRelation = TextImageRelation.TextAboveImage;
            btnSeguro.UseVisualStyleBackColor = true;
            btnSeguro.Click += btnSeguro_Click;
            // 
            // btnLupa
            // 
            btnLupa.FlatAppearance.BorderSize = 0;
            btnLupa.FlatAppearance.MouseDownBackColor = Color.FromArgb(188, 223, 204);
            btnLupa.FlatStyle = FlatStyle.Flat;
            btnLupa.Font = new Font("Comfortaa", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLupa.ForeColor = Color.FromArgb(97, 54, 37);
            btnLupa.Image = Properties.Resources.lupa;
            btnLupa.Location = new Point(440, 577);
            btnLupa.Name = "btnLupa";
            btnLupa.Size = new Size(151, 136);
            btnLupa.TabIndex = 6;
            btnLupa.Text = "Lupa para sospechosos";
            btnLupa.TextImageRelation = TextImageRelation.TextAboveImage;
            btnLupa.UseVisualStyleBackColor = true;
            btnLupa.Click += btnLupa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comfortaa", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 74, 173);
            label2.Location = new Point(81, 149);
            label2.Name = "label2";
            label2.Size = new Size(839, 72);
            label2.TabIndex = 3;
            label2.Text = "Haz clic en los objetos que SÍ deben ir en tu Mochila Ciberdefensor. \r\n¡Cuidado! Algunos objetos no te protegen en internet.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Clear Sans", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(249, 150, 11);
            label1.Location = new Point(166, 83);
            label1.Name = "label1";
            label1.Size = new Size(666, 66);
            label1.TabIndex = 2;
            label1.Text = "¡Crea tu mochila cibersegura!";
            // 
            // btnDulces
            // 
            btnDulces.FlatAppearance.BorderSize = 0;
            btnDulces.FlatAppearance.MouseDownBackColor = Color.FromArgb(228, 86, 61);
            btnDulces.FlatStyle = FlatStyle.Flat;
            btnDulces.Font = new Font("Comfortaa", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDulces.ForeColor = Color.FromArgb(97, 54, 37);
            btnDulces.Image = Properties.Resources.candy;
            btnDulces.Location = new Point(822, 371);
            btnDulces.Name = "btnDulces";
            btnDulces.Size = new Size(151, 136);
            btnDulces.TabIndex = 1;
            btnDulces.Text = "Dulces";
            btnDulces.TextImageRelation = TextImageRelation.TextAboveImage;
            btnDulces.UseVisualStyleBackColor = true;
            btnDulces.Click += btnDulces_Click;
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
            lbLeccion.Location = new Point(18, 20);
            lbLeccion.Name = "lbLeccion";
            lbLeccion.Size = new Size(448, 39);
            lbLeccion.TabIndex = 2;
            lbLeccion.Text = "Lección 6. Mochila Ciberdefensor";
            // 
            // Dinamica6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 725);
            Controls.Add(panelDinamica);
            Controls.Add(panelMenu);
            Name = "Dinamica6";
            Text = "Dinamica6";
            Load += Dinamica6_Load;
            panelMenu.ResumeLayout(false);
            panelDinamica.ResumeLayout(false);
            panelDinamica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMochila).EndInit();
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelDinamica;
        private Panel panelDashboard;
        private Label lbLeccion;
        private Label label1;
        private Button btnDulces;
        private Label label2;
        private Button btnGuia;
        private Button btnDesconocido;
        private Button btnInseguro;
        private Button btnConfianza;
        private Button btnSeguro;
        private Button btnLupa;
        private PictureBox pbMochila;
        private Button btnMenu;
        private Button btnUser;
        private Button btnLecciones;
        private Button btnMascota;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}