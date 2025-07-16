namespace HackyFox
{
    partial class Dinamica5
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
            pNombreD5 = new Panel();
            btnNextD5 = new Button();
            lbNombreD5 = new Label();
            lbTituloD5 = new Label();
            lbInstruccionesD5 = new Label();
            btn_D5R1 = new Btn_personalizado();
            btn_D5R2 = new Btn_personalizado();
            pBImagenD5 = new PictureBox();
            pBMascotaD5 = new PictureBox();
            panelMenu.SuspendLayout();
            pNombreD5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBImagenD5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBMascotaD5).BeginInit();
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
            panelMenu.Size = new Size(100, 726);
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
            btnSalir.Location = new Point(0, 657);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(10, 0, 0, 0);
            btnSalir.Size = new Size(100, 69);
            btnSalir.TabIndex = 14;
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
            btnMascota.TabIndex = 13;
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
            btnLecciones.TabIndex = 12;
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
            btnUser.TabIndex = 11;
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
            btnMenu.TabIndex = 5;
            btnMenu.Tag = "HackyFox";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // pNombreD5
            // 
            pNombreD5.BackColor = Color.FromArgb(155, 209, 219);
            pNombreD5.Controls.Add(btnNextD5);
            pNombreD5.Controls.Add(lbNombreD5);
            pNombreD5.Dock = DockStyle.Top;
            pNombreD5.Location = new Point(100, 0);
            pNombreD5.Name = "pNombreD5";
            pNombreD5.Size = new Size(1008, 70);
            pNombreD5.TabIndex = 1;
            // 
            // btnNextD5
            // 
            btnNextD5.BackgroundImage = Properties.Resources.flecha;
            btnNextD5.BackgroundImageLayout = ImageLayout.Stretch;
            btnNextD5.FlatAppearance.BorderSize = 0;
            btnNextD5.FlatStyle = FlatStyle.Flat;
            btnNextD5.Location = new Point(939, 3);
            btnNextD5.Name = "btnNextD5";
            btnNextD5.Size = new Size(66, 61);
            btnNextD5.TabIndex = 8;
            btnNextD5.UseVisualStyleBackColor = true;
            // 
            // lbNombreD5
            // 
            lbNombreD5.AutoSize = true;
            lbNombreD5.Font = new Font("Clear Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombreD5.ForeColor = Color.White;
            lbNombreD5.Location = new Point(6, 18);
            lbNombreD5.Name = "lbNombreD5";
            lbNombreD5.Size = new Size(376, 39);
            lbNombreD5.TabIndex = 0;
            lbNombreD5.Text = "Lección 5. El viaje de la foto";
            // 
            // lbTituloD5
            // 
            lbTituloD5.AutoSize = true;
            lbTituloD5.Font = new Font("Comfortaa", 30F, FontStyle.Bold);
            lbTituloD5.ForeColor = Color.FromArgb(0, 151, 178);
            lbTituloD5.Location = new Point(127, 105);
            lbTituloD5.Name = "lbTituloD5";
            lbTituloD5.Size = new Size(733, 78);
            lbTituloD5.TabIndex = 2;
            lbTituloD5.Text = "Pensar antes de compartir";
            // 
            // lbInstruccionesD5
            // 
            lbInstruccionesD5.Font = new Font("Comfortaa", 18F);
            lbInstruccionesD5.ForeColor = Color.FromArgb(0, 151, 178);
            lbInstruccionesD5.Location = new Point(523, 197);
            lbInstruccionesD5.Name = "lbInstruccionesD5";
            lbInstruccionesD5.Size = new Size(380, 121);
            lbInstruccionesD5.TabIndex = 3;
            lbInstruccionesD5.Text = "¿Es seguro publicar la calle de tu casa?";
            lbInstruccionesD5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_D5R1
            // 
            btn_D5R1.BackColor = Color.FromArgb(255, 206, 1);
            btn_D5R1.FlatAppearance.BorderSize = 0;
            btn_D5R1.FlatStyle = FlatStyle.Flat;
            btn_D5R1.Font = new Font("Comfortaa", 18F, FontStyle.Bold);
            btn_D5R1.ForeColor = Color.FromArgb(0, 74, 173);
            btn_D5R1.Location = new Point(597, 353);
            btn_D5R1.Name = "btn_D5R1";
            btn_D5R1.Size = new Size(205, 86);
            btn_D5R1.TabIndex = 4;
            btn_D5R1.Text = "¡Si!";
            btn_D5R1.UseVisualStyleBackColor = false;
            btn_D5R1.Click += btn_D5R1_Click;
            // 
            // btn_D5R2
            // 
            btn_D5R2.BackColor = Color.FromArgb(255, 206, 1);
            btn_D5R2.FlatAppearance.BorderSize = 0;
            btn_D5R2.FlatStyle = FlatStyle.Flat;
            btn_D5R2.Font = new Font("Comfortaa", 18F, FontStyle.Bold);
            btn_D5R2.ForeColor = Color.FromArgb(0, 74, 173);
            btn_D5R2.Location = new Point(597, 480);
            btn_D5R2.Name = "btn_D5R2";
            btn_D5R2.Size = new Size(205, 86);
            btn_D5R2.TabIndex = 5;
            btn_D5R2.Text = "¡No!";
            btn_D5R2.UseVisualStyleBackColor = false;
            btn_D5R2.Click += btn_D5R2_Click;
            // 
            // pBImagenD5
            // 
            pBImagenD5.Image = Properties.Resources.D5Imagen;
            pBImagenD5.Location = new Point(47, 291);
            pBImagenD5.Name = "pBImagenD5";
            pBImagenD5.Size = new Size(530, 546);
            pBImagenD5.SizeMode = PictureBoxSizeMode.Zoom;
            pBImagenD5.TabIndex = 6;
            pBImagenD5.TabStop = false;
            // 
            // pBMascotaD5
            // 
            pBMascotaD5.Image = Properties.Resources.D5Mascota;
            pBMascotaD5.Location = new Point(808, 427);
            pBMascotaD5.Name = "pBMascotaD5";
            pBMascotaD5.Size = new Size(377, 410);
            pBMascotaD5.SizeMode = PictureBoxSizeMode.Zoom;
            pBMascotaD5.TabIndex = 7;
            pBMascotaD5.TabStop = false;
            // 
            // Dinamica5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 726);
            Controls.Add(pBMascotaD5);
            Controls.Add(btn_D5R2);
            Controls.Add(btn_D5R1);
            Controls.Add(lbInstruccionesD5);
            Controls.Add(lbTituloD5);
            Controls.Add(pNombreD5);
            Controls.Add(panelMenu);
            Controls.Add(pBImagenD5);
            MinimumSize = new Size(950, 600);
            Name = "Dinamica5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dinamica5";
            Load += Dinamica5_Load;
            panelMenu.ResumeLayout(false);
            pNombreD5.ResumeLayout(false);
            pNombreD5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBImagenD5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBMascotaD5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Panel pNombreD5;
        private Label lbNombreD5;
        private Label lbTituloD5;
        private Label lbInstruccionesD5;
        private Btn_personalizado btn_D5R1;
        private Btn_personalizado btn_D5R2;
        private PictureBox pBImagenD5;
        private PictureBox pBMascotaD5;
        private Button btnMenu;
        private Button btnUser;
        private Button btnLecciones;
        private Button btnMascota;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Button btnNextD5;
    }
}