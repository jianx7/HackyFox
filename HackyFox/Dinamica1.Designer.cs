namespace HackyFox
{
    partial class Dinamica1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dinamica1));
            panelMenu = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnMascota = new Button();
            btnLecciones = new Button();
            btnUser = new Button();
            btnMenu = new Button();
            panelDinamica = new Panel();
            btnNo = new Btn_personalizado();
            btnYes = new Btn_personalizado();
            lbPregunta = new Label();
            pbPhone = new PictureBox();
            pbHacky = new PictureBox();
            pbTitulo = new PictureBox();
            label1 = new Label();
            panelDashoard = new Panel();
            lbLeccion = new Label();
            panelMenu.SuspendLayout();
            panelDinamica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHacky).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTitulo).BeginInit();
            panelDashoard.SuspendLayout();
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
            btnSalir.TabIndex = 11;
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
            btnMascota.TabIndex = 10;
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
            btnLecciones.TabIndex = 9;
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
            btnUser.TabIndex = 8;
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
            btnMenu.TabIndex = 2;
            btnMenu.Tag = "HackyFox";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelDinamica
            // 
            panelDinamica.BackColor = Color.FromArgb(249, 249, 249);
            panelDinamica.Controls.Add(btnNo);
            panelDinamica.Controls.Add(btnYes);
            panelDinamica.Controls.Add(lbPregunta);
            panelDinamica.Controls.Add(pbPhone);
            panelDinamica.Controls.Add(pbHacky);
            panelDinamica.Controls.Add(pbTitulo);
            panelDinamica.Controls.Add(label1);
            panelDinamica.Controls.Add(panelDashoard);
            panelDinamica.Dock = DockStyle.Fill;
            panelDinamica.Location = new Point(100, 0);
            panelDinamica.Name = "panelDinamica";
            panelDinamica.Size = new Size(1009, 725);
            panelDinamica.TabIndex = 1;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.FromArgb(255, 206, 1);
            btnNo.FlatAppearance.BorderSize = 0;
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Comfortaa", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNo.ForeColor = Color.FromArgb(0, 74, 173);
            btnNo.Location = new Point(347, 536);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(200, 65);
            btnNo.TabIndex = 7;
            btnNo.Text = "¡No!";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.FromArgb(255, 206, 1);
            btnYes.FlatAppearance.BorderSize = 0;
            btnYes.FlatStyle = FlatStyle.Flat;
            btnYes.Font = new Font("Comfortaa", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYes.ForeColor = Color.FromArgb(0, 74, 173);
            btnYes.Location = new Point(347, 444);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(200, 65);
            btnYes.TabIndex = 6;
            btnYes.Text = "¡Si!";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += btnYes_Click;
            // 
            // lbPregunta
            // 
            lbPregunta.AutoSize = true;
            lbPregunta.FlatStyle = FlatStyle.Flat;
            lbPregunta.Font = new Font("Comfortaa", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPregunta.ForeColor = Color.FromArgb(0, 151, 178);
            lbPregunta.Location = new Point(322, 300);
            lbPregunta.Name = "lbPregunta";
            lbPregunta.Size = new Size(262, 116);
            lbPregunta.TabIndex = 5;
            lbPregunta.Text = "¿Le das tu \r\ninfomación?";
            // 
            // pbPhone
            // 
            pbPhone.BackgroundImage = Properties.Resources.phone;
            pbPhone.BackgroundImageLayout = ImageLayout.Stretch;
            pbPhone.Location = new Point(580, 149);
            pbPhone.Name = "pbPhone";
            pbPhone.Size = new Size(429, 573);
            pbPhone.TabIndex = 4;
            pbPhone.TabStop = false;
            // 
            // pbHacky
            // 
            pbHacky.BackgroundImage = Properties.Resources.hackyPreocupado;
            pbHacky.BackgroundImageLayout = ImageLayout.Stretch;
            pbHacky.Location = new Point(0, 333);
            pbHacky.Name = "pbHacky";
            pbHacky.Size = new Size(313, 392);
            pbHacky.TabIndex = 3;
            pbHacky.TabStop = false;
            // 
            // pbTitulo
            // 
            pbTitulo.BackgroundImage = (Image)resources.GetObject("pbTitulo.BackgroundImage");
            pbTitulo.BackgroundImageLayout = ImageLayout.Stretch;
            pbTitulo.Location = new Point(62, 133);
            pbTitulo.Name = "pbTitulo";
            pbTitulo.Size = new Size(356, 94);
            pbTitulo.TabIndex = 2;
            pbTitulo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Comfortaa", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 151, 178);
            label1.Location = new Point(71, 133);
            label1.Name = "label1";
            label1.Size = new Size(0, 73);
            label1.TabIndex = 1;
            // 
            // panelDashoard
            // 
            panelDashoard.BackColor = Color.FromArgb(155, 209, 219);
            panelDashoard.Controls.Add(lbLeccion);
            panelDashoard.Dock = DockStyle.Top;
            panelDashoard.Location = new Point(0, 0);
            panelDashoard.Name = "panelDashoard";
            panelDashoard.Size = new Size(1009, 80);
            panelDashoard.TabIndex = 0;
            // 
            // lbLeccion
            // 
            lbLeccion.AutoSize = true;
            lbLeccion.Font = new Font("Clear Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLeccion.ForeColor = Color.FromArgb(249, 249, 249);
            lbLeccion.Location = new Point(24, 19);
            lbLeccion.Name = "lbLeccion";
            lbLeccion.Size = new Size(350, 39);
            lbLeccion.TabIndex = 0;
            lbLeccion.Text = "Lección 1. Escudo Seguro";
            // 
            // Dinamica1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 725);
            Controls.Add(panelDinamica);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dinamica1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dinamica1";
            Load += Dinamica1_Load;
            panelMenu.ResumeLayout(false);
            panelDinamica.ResumeLayout(false);
            panelDinamica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHacky).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTitulo).EndInit();
            panelDashoard.ResumeLayout(false);
            panelDashoard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelDinamica;
        private Panel panelDashoard;
        private Label lbLeccion;
        private Label label1;
        private Button btnMenu;
        private Button btnUser;
        private Button btnLecciones;
        private Button btnMascota;
        private FontAwesome.Sharp.IconButton btnSalir;
        private PictureBox pbTitulo;
        private PictureBox pbHacky;
        private PictureBox pbPhone;
        private Label lbPregunta;
        private Btn_personalizado btnNo;
        private Btn_personalizado btnYes;
    }
}