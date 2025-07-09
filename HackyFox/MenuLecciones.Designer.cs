namespace HackyFox
{
    partial class MenuLecciones
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
            components = new System.ComponentModel.Container();
            panelMenu = new Panel();
            btnMascota = new Button();
            btnLecciones = new Button();
            btnUser = new Button();
            btnSalir = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnMenu = new Button();
            panelDashboard = new Panel();
            lbDashboard = new Label();
            panel4 = new Panel();
            panelActLeccion = new Panel();
            btnDinamic = new Button();
            btnReto = new Button();
            btnInfo = new Button();
            lbTema = new Label();
            lbLeccion = new Label();
            bindingSource1 = new BindingSource(components);
            notifyIcon1 = new NotifyIcon(components);
            bindingSource2 = new BindingSource(components);
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelDashboard.SuspendLayout();
            panel4.SuspendLayout();
            panelActLeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(155, 209, 219);
            panelMenu.Controls.Add(btnMascota);
            panelMenu.Controls.Add(btnLecciones);
            panelMenu.Controls.Add(btnUser);
            panelMenu.Controls.Add(btnSalir);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(278, 544);
            panelMenu.TabIndex = 0;
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
            btnMascota.TabIndex = 8;
            btnMascota.Tag = "Mascota";
            btnMascota.Text = "Mascota";
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
            btnLecciones.Location = new Point(0, 126);
            btnLecciones.Margin = new Padding(3, 2, 3, 2);
            btnLecciones.Name = "btnLecciones";
            btnLecciones.Padding = new Padding(9, 0, 0, 0);
            btnLecciones.RightToLeft = RightToLeft.No;
            btnLecciones.Size = new Size(278, 56);
            btnLecciones.TabIndex = 7;
            btnLecciones.Tag = "Lecciones";
            btnLecciones.Text = "Lecciones";
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
            btnUser.Location = new Point(0, 70);
            btnUser.Margin = new Padding(3, 2, 3, 2);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(9, 0, 0, 0);
            btnUser.RightToLeft = RightToLeft.No;
            btnUser.Size = new Size(278, 56);
            btnUser.TabIndex = 6;
            btnUser.Tag = "Usuario";
            btnUser.Text = "Usuario";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUser.UseVisualStyleBackColor = true;
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
            btnSalir.TabIndex = 5;
            btnSalir.Tag = "Salir";
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnMenu);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(278, 70);
            panelLogo.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Fill;
            btnMenu.FlatAppearance.BorderSize = 0;
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
            btnMenu.TabIndex = 0;
            btnMenu.Tag = "HackyFox";
            btnMenu.Text = "HackyFox";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelDashboard
            // 
            panelDashboard.BackColor = Color.FromArgb(244, 185, 112);
            panelDashboard.Controls.Add(lbDashboard);
            panelDashboard.Dock = DockStyle.Top;
            panelDashboard.Font = new Font("Comfortaa", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelDashboard.Location = new Point(278, 0);
            panelDashboard.Margin = new Padding(3, 2, 3, 2);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(692, 52);
            panelDashboard.TabIndex = 1;
            // 
            // lbDashboard
            // 
            lbDashboard.AutoSize = true;
            lbDashboard.Font = new Font("Comfortaa", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDashboard.Location = new Point(5, 7);
            lbDashboard.Name = "lbDashboard";
            lbDashboard.Size = new Size(132, 34);
            lbDashboard.TabIndex = 0;
            lbDashboard.Tag = "Lecciones";
            lbDashboard.Text = "Lecciones";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(242, 242, 242);
            panel4.Controls.Add(panelActLeccion);
            panel4.Controls.Add(lbTema);
            panel4.Controls.Add(lbLeccion);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(278, 52);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(692, 492);
            panel4.TabIndex = 2;
            // 
            // panelActLeccion
            // 
            panelActLeccion.Controls.Add(btnDinamic);
            panelActLeccion.Controls.Add(btnReto);
            panelActLeccion.Controls.Add(btnInfo);
            panelActLeccion.Location = new Point(74, 130);
            panelActLeccion.Margin = new Padding(3, 2, 3, 2);
            panelActLeccion.Name = "panelActLeccion";
            panelActLeccion.Size = new Size(549, 289);
            panelActLeccion.TabIndex = 2;
            // 
            // btnDinamic
            // 
            btnDinamic.Dock = DockStyle.Top;
            btnDinamic.FlatAppearance.BorderSize = 0;
            btnDinamic.FlatStyle = FlatStyle.Flat;
            btnDinamic.Font = new Font("Comfortaa", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDinamic.ForeColor = Color.FromArgb(0, 74, 173);
            btnDinamic.Image = Properties.Resources._lock;
            btnDinamic.ImageAlign = ContentAlignment.MiddleRight;
            btnDinamic.Location = new Point(0, 124);
            btnDinamic.Margin = new Padding(3, 2, 3, 2);
            btnDinamic.Name = "btnDinamic";
            btnDinamic.Padding = new Padding(9, 0, 0, 0);
            btnDinamic.Size = new Size(549, 62);
            btnDinamic.TabIndex = 2;
            btnDinamic.Text = "¡Cuidado!";
            btnDinamic.TextAlign = ContentAlignment.MiddleLeft;
            btnDinamic.UseVisualStyleBackColor = true;
            // 
            // btnReto
            // 
            btnReto.Dock = DockStyle.Top;
            btnReto.FlatAppearance.BorderSize = 0;
            btnReto.FlatStyle = FlatStyle.Flat;
            btnReto.Font = new Font("Comfortaa", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReto.ForeColor = Color.FromArgb(0, 74, 173);
            btnReto.Image = Properties.Resources._lock;
            btnReto.ImageAlign = ContentAlignment.MiddleRight;
            btnReto.Location = new Point(0, 62);
            btnReto.Margin = new Padding(3, 2, 3, 2);
            btnReto.Name = "btnReto";
            btnReto.Padding = new Padding(9, 0, 0, 0);
            btnReto.Size = new Size(549, 62);
            btnReto.TabIndex = 1;
            btnReto.Text = "¡Reto Relampago!";
            btnReto.TextAlign = ContentAlignment.MiddleLeft;
            btnReto.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            btnInfo.Dock = DockStyle.Top;
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Comfortaa", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInfo.ForeColor = Color.FromArgb(0, 74, 173);
            btnInfo.Image = Properties.Resources.flecha;
            btnInfo.ImageAlign = ContentAlignment.MiddleRight;
            btnInfo.Location = new Point(0, 0);
            btnInfo.Margin = new Padding(3, 2, 3, 2);
            btnInfo.Name = "btnInfo";
            btnInfo.Padding = new Padding(9, 0, 0, 0);
            btnInfo.Size = new Size(549, 62);
            btnInfo.TabIndex = 0;
            btnInfo.Text = "¿Qué es la ciberseguridad?";
            btnInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // lbTema
            // 
            lbTema.AutoSize = true;
            lbTema.Font = new Font("Clear Sans", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTema.ForeColor = Color.FromArgb(0, 151, 178);
            lbTema.Location = new Point(98, 72);
            lbTema.Name = "lbTema";
            lbTema.Size = new Size(203, 38);
            lbTema.TabIndex = 1;
            lbTema.Text = "Escudo Seguro";
            // 
            // lbLeccion
            // 
            lbLeccion.AutoSize = true;
            lbLeccion.Font = new Font("Clear Sans", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLeccion.ForeColor = Color.FromArgb(0, 74, 173);
            lbLeccion.Location = new Point(74, 29);
            lbLeccion.Name = "lbLeccion";
            lbLeccion.Size = new Size(176, 49);
            lbLeccion.TabIndex = 0;
            lbLeccion.Text = "Lección 1";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // MenuLecciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 544);
            Controls.Add(panel4);
            Controls.Add(panelDashboard);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(833, 460);
            Name = "MenuLecciones";
            Text = " HackyFox";
            Load += MenuLecciones_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelActLeccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelDashboard;
        private Panel panel4;
        private BindingSource bindingSource1;

        private NotifyIcon notifyIcon1;
        private BindingSource bindingSource2;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Button btnUser;
        private Button btnMascota;
        private Button btnLecciones;
        private Button btnMenu;
        private Panel panelLogo;
        private Label lbDashboard;
        private Label lbTema;
        private Label lbLeccion;
        private Panel panelActLeccion;
        private Button btnDinamic;
        private Button btnReto;
        private Button btnInfo;
    }
}