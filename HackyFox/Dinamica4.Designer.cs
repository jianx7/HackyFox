namespace HackyFox
{
    partial class Dinamica4
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
            pNombreD4 = new Panel();
            btnNextD4 = new Button();
            lbNombreD4 = new Label();
            lbTituloD4 = new Label();
            lbInstruccionesD4 = new Label();
            btn_D4R1 = new Button();
            btn_D4R2 = new Button();
            btn_D4R3 = new Button();
            btn_D4R4 = new Button();
            btn_D4R5 = new Button();
            btn_D4R6 = new Button();
            pBMascotaD4 = new PictureBox();
            panelMenu.SuspendLayout();
            pNombreD4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBMascotaD4).BeginInit();
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
            btnSalir.TabIndex = 13;
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
            btnMascota.TabIndex = 12;
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
            btnLecciones.TabIndex = 11;
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
            btnUser.TabIndex = 10;
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
            btnMenu.TabIndex = 4;
            btnMenu.Tag = "HackyFox";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // pNombreD4
            // 
            pNombreD4.BackColor = Color.FromArgb(155, 209, 219);
            pNombreD4.Controls.Add(btnNextD4);
            pNombreD4.Controls.Add(lbNombreD4);
            pNombreD4.Dock = DockStyle.Top;
            pNombreD4.Location = new Point(100, 0);
            pNombreD4.Name = "pNombreD4";
            pNombreD4.Size = new Size(1008, 70);
            pNombreD4.TabIndex = 1;
            // 
            // btnNextD4
            // 
            btnNextD4.BackgroundImage = Properties.Resources.flecha;
            btnNextD4.BackgroundImageLayout = ImageLayout.Stretch;
            btnNextD4.FlatAppearance.BorderSize = 0;
            btnNextD4.FlatStyle = FlatStyle.Flat;
            btnNextD4.Location = new Point(939, 3);
            btnNextD4.Name = "btnNextD4";
            btnNextD4.Size = new Size(66, 61);
            btnNextD4.TabIndex = 11;
            btnNextD4.UseVisualStyleBackColor = true;
            // 
            // lbNombreD4
            // 
            lbNombreD4.AutoSize = true;
            lbNombreD4.Font = new Font("Clear Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombreD4.ForeColor = Color.White;
            lbNombreD4.Location = new Point(3, 19);
            lbNombreD4.Name = "lbNombreD4";
            lbNombreD4.Size = new Size(386, 39);
            lbNombreD4.TabIndex = 0;
            lbNombreD4.Text = "Lección 4. Protege tu Correo";
            // 
            // lbTituloD4
            // 
            lbTituloD4.AutoSize = true;
            lbTituloD4.Font = new Font("Clear Sans", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloD4.ForeColor = Color.FromArgb(242, 139, 12);
            lbTituloD4.Location = new Point(284, 92);
            lbTituloD4.Name = "lbTituloD4";
            lbTituloD4.Size = new Size(618, 84);
            lbTituloD4.TabIndex = 2;
            lbTituloD4.Text = "Detectives del buzón ";
            // 
            // lbInstruccionesD4
            // 
            lbInstruccionesD4.AutoSize = true;
            lbInstruccionesD4.Font = new Font("Comfortaa", 14F);
            lbInstruccionesD4.ForeColor = Color.FromArgb(0, 74, 173);
            lbInstruccionesD4.Location = new Point(373, 185);
            lbInstruccionesD4.Name = "lbInstruccionesD4";
            lbInstruccionesD4.Size = new Size(379, 38);
            lbInstruccionesD4.TabIndex = 3;
            lbInstruccionesD4.Text = "Reconoce el correo confiable";
            // 
            // btn_D4R1
            // 
            btn_D4R1.Image = Properties.Resources.D2R3;
            btn_D4R1.Location = new Point(382, 295);
            btn_D4R1.Name = "btn_D4R1";
            btn_D4R1.Size = new Size(141, 104);
            btn_D4R1.TabIndex = 4;
            btn_D4R1.UseVisualStyleBackColor = true;
            btn_D4R1.Click += btn_D4R1_Click;
            // 
            // btn_D4R2
            // 
            btn_D4R2.Image = Properties.Resources.D2R2;
            btn_D4R2.Location = new Point(611, 295);
            btn_D4R2.Name = "btn_D4R2";
            btn_D4R2.Size = new Size(141, 104);
            btn_D4R2.TabIndex = 5;
            btn_D4R2.UseVisualStyleBackColor = true;
            btn_D4R2.Click += btn_D4R2_Click;
            // 
            // btn_D4R3
            // 
            btn_D4R3.Image = Properties.Resources.D2R4;
            btn_D4R3.Location = new Point(849, 295);
            btn_D4R3.Name = "btn_D4R3";
            btn_D4R3.Size = new Size(141, 104);
            btn_D4R3.TabIndex = 6;
            btn_D4R3.UseVisualStyleBackColor = true;
            btn_D4R3.Click += btn_D4R3_Click;
            // 
            // btn_D4R4
            // 
            btn_D4R4.Image = Properties.Resources.D2R5;
            btn_D4R4.Location = new Point(382, 521);
            btn_D4R4.Name = "btn_D4R4";
            btn_D4R4.Size = new Size(141, 104);
            btn_D4R4.TabIndex = 7;
            btn_D4R4.UseVisualStyleBackColor = true;
            btn_D4R4.Click += btn_D4R4_Click;
            // 
            // btn_D4R5
            // 
            btn_D4R5.Image = Properties.Resources.D2R6;
            btn_D4R5.Location = new Point(611, 521);
            btn_D4R5.Name = "btn_D4R5";
            btn_D4R5.Size = new Size(141, 104);
            btn_D4R5.TabIndex = 8;
            btn_D4R5.UseVisualStyleBackColor = true;
            btn_D4R5.Click += btn_D4R5_Click;
            // 
            // btn_D4R6
            // 
            btn_D4R6.Image = Properties.Resources.D2R7;
            btn_D4R6.Location = new Point(849, 521);
            btn_D4R6.Name = "btn_D4R6";
            btn_D4R6.Size = new Size(141, 104);
            btn_D4R6.TabIndex = 9;
            btn_D4R6.UseVisualStyleBackColor = true;
            btn_D4R6.Click += btn_D4R6_Click;
            // 
            // pBMascotaD4
            // 
            pBMascotaD4.Image = Properties.Resources.D4Mascota;
            pBMascotaD4.Location = new Point(-18, 318);
            pBMascotaD4.Name = "pBMascotaD4";
            pBMascotaD4.Size = new Size(378, 480);
            pBMascotaD4.SizeMode = PictureBoxSizeMode.Zoom;
            pBMascotaD4.TabIndex = 10;
            pBMascotaD4.TabStop = false;
            // 
            // Dinamica4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 726);
            Controls.Add(btn_D4R6);
            Controls.Add(btn_D4R5);
            Controls.Add(btn_D4R4);
            Controls.Add(btn_D4R3);
            Controls.Add(btn_D4R2);
            Controls.Add(btn_D4R1);
            Controls.Add(lbInstruccionesD4);
            Controls.Add(lbTituloD4);
            Controls.Add(pNombreD4);
            Controls.Add(panelMenu);
            Controls.Add(pBMascotaD4);
            MinimumSize = new Size(950, 600);
            Name = "Dinamica4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dinamica4";
            Load += Dinamica4_Load;
            panelMenu.ResumeLayout(false);
            pNombreD4.ResumeLayout(false);
            pNombreD4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBMascotaD4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private Panel pNombreD4;
        private Label lbNombreD4;
        private Label lbTituloD4;
        private Label lbInstruccionesD4;
        private Button btn_D4R1;
        private Button btn_D4R2;
        private Button btn_D4R3;
        private Button btn_D4R4;
        private Button btn_D4R5;
        private Button btn_D4R6;
        private PictureBox pBMascotaD4;
        private Button btnMenu;
        private Button btnUser;
        private Button btnLecciones;
        private Button btnMascota;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Button btnNextD4;
    }
}