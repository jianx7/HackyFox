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
            panelDashboard = new Panel();
            lbDashboard = new Label();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panelProgreso.SuspendLayout();
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
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(278, 544);
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
            btnSalir.Location = new Point(0, 492);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(9, 0, 0, 0);
            btnSalir.Size = new Size(278, 52);
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
            btnMascota.Location = new Point(0, 182);
            btnMascota.Margin = new Padding(3, 2, 3, 2);
            btnMascota.Name = "btnMascota";
            btnMascota.Padding = new Padding(9, 0, 0, 0);
            btnMascota.RightToLeft = RightToLeft.No;
            btnMascota.Size = new Size(278, 56);
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
            btnLecciones.Location = new Point(0, 126);
            btnLecciones.Margin = new Padding(3, 2, 3, 2);
            btnLecciones.Name = "btnLecciones";
            btnLecciones.Padding = new Padding(9, 0, 0, 0);
            btnLecciones.RightToLeft = RightToLeft.No;
            btnLecciones.Size = new Size(278, 56);
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
            btnUser.Location = new Point(0, 70);
            btnUser.Margin = new Padding(3, 2, 3, 2);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(9, 0, 0, 0);
            btnUser.RightToLeft = RightToLeft.No;
            btnUser.Size = new Size(278, 56);
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 70);
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
            btnMenu.Margin = new Padding(3, 2, 3, 2);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(9, 0, 0, 0);
            btnMenu.Size = new Size(278, 70);
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
            panelProgreso.Controls.Add(panelDashboard);
            panelProgreso.Dock = DockStyle.Fill;
            panelProgreso.Location = new Point(278, 0);
            panelProgreso.Margin = new Padding(3, 2, 3, 2);
            panelProgreso.Name = "panelProgreso";
            panelProgreso.Size = new Size(692, 544);
            panelProgreso.TabIndex = 2;
            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.FromArgb(155, 209, 219);
            panelDashboard.Controls.Add(lbDashboard);
            panelDashboard.Dock = DockStyle.Top;
            panelDashboard.Location = new Point(0, 0);
            panelDashboard.Margin = new Padding(3, 2, 3, 2);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(692, 54);
            panelDashboard.TabIndex = 0;
            // 
            // lbDashboard
            // 
            lbDashboard.AutoSize = true;
            lbDashboard.Font = new Font("Comfortaa", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDashboard.ForeColor = Color.Black;
            lbDashboard.Location = new Point(6, 9);
            lbDashboard.Name = "lbDashboard";
            lbDashboard.Size = new Size(120, 34);
            lbDashboard.TabIndex = 2;
            lbDashboard.Tag = "Lecciones";
            lbDashboard.Text = "Progreso";
            // 
            // MenuProgreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 544);
            Controls.Add(panelProgreso);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuProgreso";
            Text = "MenuProgreso";
            Load += MenuProgreso_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelProgreso.ResumeLayout(false);
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
    }
}