namespace HackyFox
{
    partial class MenuMascota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuMascota));
            panelMenu = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnMascota = new Button();
            btnLecciones = new Button();
            btnUser = new Button();
            panel1 = new Panel();
            btnMenu = new Button();
            panelMascota = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            lbAlias = new Label();
            panelDashboard = new Panel();
            lbDashboard = new Label();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panelMascota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(318, 725);
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
            btnUser.Click += btnUser_Click;
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
            btnMenu.Click += btnMenu_Click_1;
            // 
            // panelMascota
            // 
            panelMascota.BackColor = Color.FromArgb(242, 242, 242);
            panelMascota.Controls.Add(pictureBox3);
            panelMascota.Controls.Add(label3);
            panelMascota.Controls.Add(label2);
            panelMascota.Controls.Add(pictureBox2);
            panelMascota.Controls.Add(lbAlias);
            panelMascota.Controls.Add(panelDashboard);
            panelMascota.Controls.Add(pictureBox1);
            panelMascota.Dock = DockStyle.Fill;
            panelMascota.Location = new Point(318, 0);
            panelMascota.Name = "panelMascota";
            panelMascota.Size = new Size(791, 725);
            panelMascota.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.hackySombra;
            pictureBox3.Location = new Point(125, 263);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(518, 437);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Clear Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 151, 178);
            label3.Image = Properties.Resources.rectanguloMorado;
            label3.Location = new Point(546, 165);
            label3.Name = "label3";
            label3.Size = new Size(218, 78);
            label3.TabIndex = 5;
            label3.Text = "¡Se amable con \r\nlos demas!";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Clear Sans", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 151, 178);
            label2.Image = Properties.Resources.rectanguloMorado;
            label2.Location = new Point(580, 121);
            label2.Name = "label2";
            label2.Size = new Size(189, 47);
            label2.TabIndex = 4;
            label2.Text = "¡Recuerda!";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.rectanguloMorado;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(419, 113);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(360, 144);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lbAlias
            // 
            lbAlias.AutoSize = true;
            lbAlias.Font = new Font("Clear Sans", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAlias.ForeColor = Color.FromArgb(0, 151, 178);
            lbAlias.Image = Properties.Resources.rectanguloMorado;
            lbAlias.Location = new Point(41, 156);
            lbAlias.Name = "lbAlias";
            lbAlias.Size = new Size(0, 52);
            lbAlias.TabIndex = 1;
            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.FromArgb(145, 171, 217);
            panelDashboard.Controls.Add(lbDashboard);
            panelDashboard.Dock = DockStyle.Top;
            panelDashboard.Location = new Point(0, 0);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(791, 80);
            panelDashboard.TabIndex = 0;
            // 
            // lbDashboard
            // 
            lbDashboard.AutoSize = true;
            lbDashboard.Font = new Font("Comfortaa", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDashboard.ForeColor = Color.FromArgb(242, 242, 242);
            lbDashboard.Location = new Point(6, 19);
            lbDashboard.Name = "lbDashboard";
            lbDashboard.Size = new Size(146, 44);
            lbDashboard.TabIndex = 1;
            lbDashboard.Tag = "Lecciones";
            lbDashboard.Text = "Mascota";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.rectanguloMorado;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(15, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 144);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MenuMascota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 725);
            Controls.Add(panelMascota);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuMascota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuMascota";
            Load += MenuMascota_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelMascota.ResumeLayout(false);
            panelMascota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelMascota;
        private Panel panelDashboard;
        private Label lbDashboard;
        private Panel panel1;
        private Button btnMenu;
        private Button btnUser;
        private Button btnLecciones;
        private Button btnMascota;
        private FontAwesome.Sharp.IconButton btnSalir;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private Label lbAlias;
    }
}