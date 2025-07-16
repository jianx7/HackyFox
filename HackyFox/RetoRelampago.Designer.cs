namespace HackyFox
{
    partial class RetoRelampago
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
            panel2 = new Panel();
            LbTituloLeccionR = new Label();
            PicRetoRelampagoT = new PictureBox();
            PicRetoFondo = new PictureBox();
            btnRespuesta1 = new Btn_personalizado();
            lbRetoPregunta = new Label();
            btnRespuesta2 = new Btn_personalizado();
            btnRespuesta3 = new Btn_personalizado();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicRetoRelampagoT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicRetoFondo).BeginInit();
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
            panelMenu.Size = new Size(100, 979);
            panelMenu.TabIndex = 1;
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
            btnSalir.Location = new Point(0, 910);
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(155, 209, 219);
            panel2.Controls.Add(LbTituloLeccionR);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(100, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1169, 83);
            panel2.TabIndex = 2;
            // 
            // LbTituloLeccionR
            // 
            LbTituloLeccionR.AutoSize = true;
            LbTituloLeccionR.Font = new Font("Comfortaa", 23F);
            LbTituloLeccionR.ForeColor = SystemColors.Control;
            LbTituloLeccionR.Location = new Point(7, 13);
            LbTituloLeccionR.Name = "LbTituloLeccionR";
            LbTituloLeccionR.Size = new Size(141, 61);
            LbTituloLeccionR.TabIndex = 0;
            LbTituloLeccionR.Text = "label1";
            // 
            // PicRetoRelampagoT
            // 
            PicRetoRelampagoT.Image = Properties.Resources.Pantallas_HackyFox_2;
            PicRetoRelampagoT.Location = new Point(314, 91);
            PicRetoRelampagoT.Margin = new Padding(3, 4, 3, 4);
            PicRetoRelampagoT.Name = "PicRetoRelampagoT";
            PicRetoRelampagoT.Size = new Size(775, 132);
            PicRetoRelampagoT.SizeMode = PictureBoxSizeMode.Zoom;
            PicRetoRelampagoT.TabIndex = 3;
            PicRetoRelampagoT.TabStop = false;
            // 
            // PicRetoFondo
            // 
            PicRetoFondo.Image = Properties.Resources.Pantallas_HackyFox_3;
            PicRetoFondo.Location = new Point(105, 133);
            PicRetoFondo.Margin = new Padding(3, 4, 3, 4);
            PicRetoFondo.Name = "PicRetoFondo";
            PicRetoFondo.Size = new Size(1119, 748);
            PicRetoFondo.SizeMode = PictureBoxSizeMode.Zoom;
            PicRetoFondo.TabIndex = 4;
            PicRetoFondo.TabStop = false;
            // 
            // btnRespuesta1
            // 
            btnRespuesta1.BackColor = Color.FromArgb(255, 206, 1);
            btnRespuesta1.FlatAppearance.BorderSize = 0;
            btnRespuesta1.FlatStyle = FlatStyle.Flat;
            btnRespuesta1.Font = new Font("Comfortaa", 13F);
            btnRespuesta1.ForeColor = Color.FromArgb(24, 76, 172);
            btnRespuesta1.Location = new Point(266, 449);
            btnRespuesta1.Margin = new Padding(3, 4, 3, 4);
            btnRespuesta1.Name = "btnRespuesta1";
            btnRespuesta1.Size = new Size(288, 135);
            btnRespuesta1.TabIndex = 5;
            btnRespuesta1.Text = "respuesta1";
            btnRespuesta1.UseVisualStyleBackColor = false;
            // 
            // lbRetoPregunta
            // 
            lbRetoPregunta.BackColor = Color.FromArgb(137, 171, 217);
            lbRetoPregunta.Font = new Font("Comfortaa", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRetoPregunta.ForeColor = Color.FromArgb(24, 76, 172);
            lbRetoPregunta.Location = new Point(314, 273);
            lbRetoPregunta.Name = "lbRetoPregunta";
            lbRetoPregunta.Size = new Size(784, 95);
            lbRetoPregunta.TabIndex = 8;
            lbRetoPregunta.Text = "pregunta";
            lbRetoPregunta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRespuesta2
            // 
            btnRespuesta2.BackColor = Color.FromArgb(255, 206, 1);
            btnRespuesta2.FlatAppearance.BorderSize = 0;
            btnRespuesta2.FlatStyle = FlatStyle.Flat;
            btnRespuesta2.Font = new Font("Comfortaa", 13F);
            btnRespuesta2.ForeColor = Color.FromArgb(24, 76, 172);
            btnRespuesta2.Location = new Point(849, 449);
            btnRespuesta2.Margin = new Padding(3, 4, 3, 4);
            btnRespuesta2.Name = "btnRespuesta2";
            btnRespuesta2.Size = new Size(288, 135);
            btnRespuesta2.TabIndex = 9;
            btnRespuesta2.Text = "respuesta2";
            btnRespuesta2.UseVisualStyleBackColor = false;
            // 
            // btnRespuesta3
            // 
            btnRespuesta3.BackColor = Color.FromArgb(255, 206, 1);
            btnRespuesta3.FlatAppearance.BorderSize = 0;
            btnRespuesta3.FlatStyle = FlatStyle.Flat;
            btnRespuesta3.Font = new Font("Comfortaa", 13F);
            btnRespuesta3.ForeColor = Color.FromArgb(24, 76, 172);
            btnRespuesta3.Location = new Point(568, 647);
            btnRespuesta3.Margin = new Padding(3, 4, 3, 4);
            btnRespuesta3.Name = "btnRespuesta3";
            btnRespuesta3.Size = new Size(288, 135);
            btnRespuesta3.TabIndex = 10;
            btnRespuesta3.Text = "respuesta1";
            btnRespuesta3.UseVisualStyleBackColor = false;
            // 
            // RetoRelampago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 979);
            Controls.Add(btnRespuesta3);
            Controls.Add(btnRespuesta2);
            Controls.Add(lbRetoPregunta);
            Controls.Add(btnRespuesta1);
            Controls.Add(PicRetoRelampagoT);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            Controls.Add(PicRetoFondo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RetoRelampago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RetoRelampago";
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicRetoRelampagoT).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicRetoFondo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel2;
        private Label LbTituloLeccionR;
        private PictureBox PicRetoRelampagoT;
        private PictureBox PicRetoFondo;
        private Btn_personalizado btnRespuesta1;
        private Label lbRetoPregunta;
        private Btn_personalizado btnRespuesta2;
        private Btn_personalizado btnRespuesta3;
        private Button btnMenu;
        private Button btnUser;
        private Button btnLecciones;
        private Button btnMascota;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}