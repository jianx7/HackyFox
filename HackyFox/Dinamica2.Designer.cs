namespace HackyFox
{
    partial class Dinamica2
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
            panelDashboard = new Panel();
            btnNextD2 = new Button();
            lbNombreD2 = new Label();
            lbTituloD2 = new Label();
            lbInstruccionesD2 = new Label();
            btn_D2R1 = new Button();
            btn_D2R2 = new Button();
            btn_D2R3 = new Button();
            btn_D2R4 = new Button();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.FromArgb(155, 209, 219);
            panelDashboard.Controls.Add(btnNextD2);
            panelDashboard.Controls.Add(lbNombreD2);
            panelDashboard.Dock = DockStyle.Top;
            panelDashboard.Location = new Point(100, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(1008, 70);
            panelDashboard.TabIndex = 1;
            // 
            // btnNextD2
            // 
            btnNextD2.BackgroundImage = Properties.Resources.flecha;
            btnNextD2.BackgroundImageLayout = ImageLayout.Stretch;
            btnNextD2.FlatAppearance.BorderSize = 0;
            btnNextD2.FlatStyle = FlatStyle.Flat;
            btnNextD2.Location = new Point(939, 3);
            btnNextD2.Name = "btnNextD2";
            btnNextD2.Size = new Size(66, 61);
            btnNextD2.TabIndex = 9;
            btnNextD2.UseVisualStyleBackColor = true;
            // 
            // lbNombreD2
            // 
            lbNombreD2.AutoSize = true;
            lbNombreD2.Font = new Font("Clear Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombreD2.ForeColor = Color.White;
            lbNombreD2.Location = new Point(6, 18);
            lbNombreD2.Name = "lbNombreD2";
            lbNombreD2.Size = new Size(314, 39);
            lbNombreD2.TabIndex = 0;
            lbNombreD2.Text = "Lección 2. Mi Yo Digital";
            // 
            // lbTituloD2
            // 
            lbTituloD2.AutoSize = true;
            lbTituloD2.Font = new Font("Clear Sans", 36F, FontStyle.Bold);
            lbTituloD2.ForeColor = Color.FromArgb(242, 139, 12);
            lbTituloD2.Location = new Point(121, 85);
            lbTituloD2.Name = "lbTituloD2";
            lbTituloD2.Size = new Size(803, 84);
            lbTituloD2.TabIndex = 2;
            lbTituloD2.Text = "¿Compartir o no compartir?";
            // 
            // lbInstruccionesD2
            // 
            lbInstruccionesD2.AutoSize = true;
            lbInstruccionesD2.Font = new Font("Comfortaa", 14F);
            lbInstruccionesD2.ForeColor = Color.FromArgb(0, 74, 173);
            lbInstruccionesD2.Location = new Point(177, 169);
            lbInstruccionesD2.Name = "lbInstruccionesD2";
            lbInstruccionesD2.Size = new Size(679, 38);
            lbInstruccionesD2.TabIndex = 3;
            lbInstruccionesD2.Text = "Haz clic en la opción que SÍ compartirías en internet.";
            // 
            // btn_D2R1
            // 
            btn_D2R1.Image = Properties.Resources.btn_Dinamica2;
            btn_D2R1.Location = new Point(156, 257);
            btn_D2R1.Name = "btn_D2R1";
            btn_D2R1.Size = new Size(264, 406);
            btn_D2R1.TabIndex = 4;
            btn_D2R1.UseVisualStyleBackColor = true;
            btn_D2R1.Click += btn_D2R1_Click;
            // 
            // btn_D2R2
            // 
            btn_D2R2.Image = Properties.Resources.btn1_Dinamica2;
            btn_D2R2.Location = new Point(473, 257);
            btn_D2R2.Name = "btn_D2R2";
            btn_D2R2.Size = new Size(264, 406);
            btn_D2R2.TabIndex = 5;
            btn_D2R2.UseVisualStyleBackColor = true;
            btn_D2R2.Click += btn_D2R2_Click;
            // 
            // btn_D2R3
            // 
            btn_D2R3.Image = Properties.Resources.btn2_Dinamica2;
            btn_D2R3.Location = new Point(798, 240);
            btn_D2R3.Name = "btn_D2R3";
            btn_D2R3.Size = new Size(0, 0);
            btn_D2R3.TabIndex = 6;
            btn_D2R3.UseVisualStyleBackColor = true;
            // 
            // btn_D2R4
            // 
            btn_D2R4.Image = Properties.Resources.btn2_Dinamica2;
            btn_D2R4.Location = new Point(784, 257);
            btn_D2R4.Name = "btn_D2R4";
            btn_D2R4.Size = new Size(264, 406);
            btn_D2R4.TabIndex = 7;
            btn_D2R4.UseVisualStyleBackColor = true;
            btn_D2R4.Click += btn_D2R4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.edit_cuidado;
            pictureBox1.Location = new Point(851, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Dinamica2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 726);
            Controls.Add(btn_D2R4);
            Controls.Add(btn_D2R3);
            Controls.Add(btn_D2R2);
            Controls.Add(btn_D2R1);
            Controls.Add(lbInstruccionesD2);
            Controls.Add(lbTituloD2);
            Controls.Add(panelDashboard);
            Controls.Add(panelMenu);
            Controls.Add(pictureBox1);
            MinimumSize = new Size(950, 600);
            Name = "Dinamica2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dinamica2";
            Load += Dinamica2_Load;
            panelMenu.ResumeLayout(false);
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Panel panelDashboard;
        private Label lbNombreD2;
        private Label lbTituloD2;
        private Label lbInstruccionesD2;
        private Button btn_D2R1;
        private Button btn_D2R2;
        private Button btn_D2R3;
        private Button btn_D2R4;
        private PictureBox pictureBox1;
        private Button btnMenu;
        private Button btnUser;
        private Button btnLecciones;
        private Button btnMascota;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Button btnNextD2;
    }
}