namespace HackyFox
{
    partial class Leccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leccion));
            panelMenu = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnMascota = new Button();
            btnLecciones = new Button();
            btnUser = new Button();
            btnMenu = new Button();
            panel2 = new Panel();
            LbTituloLeccion = new Label();
            LbSubtitulo = new Label();
            LbTituloContenido = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            Lbconsejo = new Label();
            TbContenidoDeco = new TextBox();
            pictureBox1 = new PictureBox();
            TbContenido = new TextBox();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(100, 999);
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
            btnSalir.Location = new Point(0, 930);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(10, 0, 0, 0);
            btnSalir.Size = new Size(100, 69);
            btnSalir.TabIndex = 10;
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
            btnMascota.TabIndex = 9;
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
            btnLecciones.TabIndex = 8;
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
            btnUser.TabIndex = 7;
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
            btnMenu.TabIndex = 1;
            btnMenu.Tag = "HackyFox";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(155, 209, 219);
            panel2.Controls.Add(LbTituloLeccion);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(100, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1466, 83);
            panel2.TabIndex = 1;
            // 
            // LbTituloLeccion
            // 
            LbTituloLeccion.AutoSize = true;
            LbTituloLeccion.Font = new Font("Comfortaa", 23F);
            LbTituloLeccion.ForeColor = SystemColors.Control;
            LbTituloLeccion.Location = new Point(7, 13);
            LbTituloLeccion.Name = "LbTituloLeccion";
            LbTituloLeccion.Size = new Size(141, 61);
            LbTituloLeccion.TabIndex = 0;
            LbTituloLeccion.Text = "label1";
            // 
            // LbSubtitulo
            // 
            LbSubtitulo.FlatStyle = FlatStyle.Flat;
            LbSubtitulo.Font = new Font("Comfortaa", 19F);
            LbSubtitulo.ForeColor = Color.FromArgb(1, 149, 177);
            LbSubtitulo.Location = new Point(30, 220);
            LbSubtitulo.Name = "LbSubtitulo";
            LbSubtitulo.Size = new Size(555, 171);
            LbSubtitulo.TabIndex = 1;
            LbSubtitulo.Text = "label3";
            LbSubtitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LbTituloContenido
            // 
            LbTituloContenido.FlatStyle = FlatStyle.Flat;
            LbTituloContenido.Font = new Font("Comfortaa", 23F);
            LbTituloContenido.ForeColor = Color.FromArgb(1, 149, 177);
            LbTituloContenido.Location = new Point(18, 36);
            LbTituloContenido.Name = "LbTituloContenido";
            LbTituloContenido.Size = new Size(567, 135);
            LbTituloContenido.TabIndex = 1;
            LbTituloContenido.Text = "label2";
            LbTituloContenido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 241, 62);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(TbContenido);
            panel3.Controls.Add(LbSubtitulo);
            panel3.Controls.Add(LbTituloContenido);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(100, 83);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1466, 916);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(Lbconsejo);
            panel4.Controls.Add(TbContenidoDeco);
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(669, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(797, 916);
            panel4.TabIndex = 3;
            // 
            // Lbconsejo
            // 
            Lbconsejo.BackColor = Color.White;
            Lbconsejo.Font = new Font("Comfortaa", 20F);
            Lbconsejo.ForeColor = Color.FromArgb(1, 149, 177);
            Lbconsejo.Location = new Point(341, 77);
            Lbconsejo.Name = "Lbconsejo";
            Lbconsejo.Size = new Size(359, 159);
            Lbconsejo.TabIndex = 4;
            Lbconsejo.Text = "label1";
            // 
            // TbContenidoDeco
            // 
            TbContenidoDeco.BorderStyle = BorderStyle.None;
            TbContenidoDeco.Enabled = false;
            TbContenidoDeco.Font = new Font("Comfortaa", 18F);
            TbContenidoDeco.ForeColor = Color.FromArgb(1, 149, 177);
            TbContenidoDeco.Location = new Point(98, 395);
            TbContenidoDeco.Margin = new Padding(3, 4, 3, 4);
            TbContenidoDeco.Multiline = true;
            TbContenidoDeco.Name = "TbContenidoDeco";
            TbContenidoDeco.ReadOnly = true;
            TbContenidoDeco.Size = new Size(625, 427);
            TbContenidoDeco.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.consejopic;
            pictureBox1.Location = new Point(88, 8);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(650, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TbContenido
            // 
            TbContenido.BorderStyle = BorderStyle.None;
            TbContenido.Enabled = false;
            TbContenido.Font = new Font("Comfortaa", 18F);
            TbContenido.ForeColor = Color.FromArgb(1, 149, 177);
            TbContenido.Location = new Point(30, 395);
            TbContenido.Margin = new Padding(3, 4, 3, 4);
            TbContenido.Multiline = true;
            TbContenido.Name = "TbContenido";
            TbContenido.ReadOnly = true;
            TbContenido.Size = new Size(619, 427);
            TbContenido.TabIndex = 2;
            TbContenido.TextAlign = HorizontalAlignment.Center;
            // 
            // Leccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1566, 999);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Leccion";
            Text = "Leccion";
            Load += Leccion_Load;
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel2;
        private Label LbTituloLeccion;
        private Label LbSubtitulo;
        private Label LbTituloContenido;
        private Panel panel3;
        private TextBox TbContenido;
        private Panel panel4;
        private PictureBox pictureBox1;
        private TextBox TbContenidoDeco;
        private Label Lbconsejo;
        private Button btnMenu;
        private Button btnUser;
        private Button btnLecciones;
        private Button btnMascota;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}