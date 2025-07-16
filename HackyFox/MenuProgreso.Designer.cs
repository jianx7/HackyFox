namespace HackyFox
{
    partial class MenuProgreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuProgreso));
            panelMenu = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnMascota = new Button();
            btnLecciones = new Button();
            btnUser = new Button();
            panel1 = new Panel();
            btnMenu = new Button();
            panelProgreso = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ProgresoGeneral = new HackyFox.Controls.RJProgressBar();
            PicProgress = new PictureBox();
            panelDashboard = new Panel();
            lbDashboard = new Label();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panelProgreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicProgress).BeginInit();
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
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(318, 725);
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
            btnSalir.Location = new Point(0, 656);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(10, 0, 0, 0);
            btnSalir.Size = new Size(318, 69);
            btnSalir.TabIndex = 10;
            btnSalir.Tag = "Salir";
            btnSalir.Text = "Salir";
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
            btnMascota.Size = new Size(318, 75);
            btnMascota.TabIndex = 9;
            btnMascota.Tag = "Mascota";
            btnMascota.Text = "Mascota";
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
            btnLecciones.Size = new Size(318, 75);
            btnLecciones.TabIndex = 8;
            btnLecciones.Tag = "Lecciones";
            btnLecciones.Text = "Lecciones";
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
            btnUser.Size = new Size(318, 75);
            btnUser.TabIndex = 7;
            btnUser.Tag = "Usuario";
            btnUser.Text = "Usuario";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUser.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 93);
            panel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Fill;
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
            btnMenu.Size = new Size(318, 93);
            btnMenu.TabIndex = 1;
            btnMenu.Tag = "HackyFox";
            btnMenu.Text = "HackyFox";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelProgreso
            // 
            panelProgreso.Controls.Add(label1);
            panelProgreso.Controls.Add(pictureBox1);
            panelProgreso.Controls.Add(panel2);
            panelProgreso.Controls.Add(panelDashboard);
            panelProgreso.Dock = DockStyle.Fill;
            panelProgreso.Location = new Point(318, 0);
            panelProgreso.Name = "panelProgreso";
            panelProgreso.Size = new Size(791, 725);
            panelProgreso.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comfortaa", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(356, 351);
            label1.Name = "label1";
            label1.Size = new Size(110, 47);
            label1.TabIndex = 4;
            label1.Text = "Locky";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.cabeza;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(291, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 216);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(ProgresoGeneral);
            panel2.Controls.Add(PicProgress);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 402);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(791, 323);
            panel2.TabIndex = 2;
            // 
            // ProgresoGeneral
            // 
            ProgresoGeneral.BackColor = Color.FromArgb(255, 241, 62);
            ProgresoGeneral.ChannelColor = Color.LightSteelBlue;
            ProgresoGeneral.ChannelHeight = 60;
            ProgresoGeneral.ForeBackColor = Color.RoyalBlue;
            ProgresoGeneral.ForeColor = Color.FromArgb(255, 241, 62);
            ProgresoGeneral.Location = new Point(279, 147);
            ProgresoGeneral.Margin = new Padding(3, 4, 3, 4);
            ProgresoGeneral.Name = "ProgresoGeneral";
            ProgresoGeneral.ShowMaximun = false;
            ProgresoGeneral.ShowValue = HackyFox.Controls.RJProgressBar.TextPosition.Right;
            ProgresoGeneral.Size = new Size(258, 51);
            ProgresoGeneral.SliderColor = Color.RoyalBlue;
            ProgresoGeneral.SliderHeight = 6;
            ProgresoGeneral.SymbolAfter = "";
            ProgresoGeneral.SymbolBefore = "";
            ProgresoGeneral.TabIndex = 0;
            ProgresoGeneral.Click += ProgresoGeneral_Click;
            // 
            // PicProgress
            // 
            PicProgress.Image = Properties.Resources.AprendizajeProgresBG;
            PicProgress.Location = new Point(153, 19);
            PicProgress.Margin = new Padding(3, 4, 3, 4);
            PicProgress.Name = "PicProgress";
            PicProgress.Size = new Size(566, 229);
            PicProgress.SizeMode = PictureBoxSizeMode.Zoom;
            PicProgress.TabIndex = 2;
            PicProgress.TabStop = false;
            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.FromArgb(155, 209, 219);
            panelDashboard.Controls.Add(lbDashboard);
            panelDashboard.Dock = DockStyle.Top;
            panelDashboard.Location = new Point(0, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(791, 72);
            panelDashboard.TabIndex = 0;
            // 
            // lbDashboard
            // 
            lbDashboard.AutoSize = true;
            lbDashboard.Font = new Font("Comfortaa", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDashboard.ForeColor = Color.Black;
            lbDashboard.Location = new Point(7, 12);
            lbDashboard.Name = "lbDashboard";
            lbDashboard.Size = new Size(151, 44);
            lbDashboard.TabIndex = 2;
            lbDashboard.Tag = "Lecciones";
            lbDashboard.Text = "Progreso";
            // 
            // MenuProgreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 725);
            Controls.Add(panelProgreso);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuProgreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuProgreso";
            Load += MenuProgreso_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelProgreso.ResumeLayout(false);
            panelProgreso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicProgress).EndInit();
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Button btnMascota;
        private Button btnLecciones;
        private Button btnUser;
        private Panel panel1;
        private Button btnMenu;
        private Panel panelProgreso;
        private Panel panelDashboard;
        private Label lbDashboard;
        private Controls.RJProgressBar ProgresoGeneral;
        private Panel panel2;
        private PictureBox PicProgress;
        private PictureBox pictureBox1;
        private Label label1;
    }
}