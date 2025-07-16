namespace HackyFox
{
    partial class PantallaBienvenida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaBienvenida));
            pbLogoBienvenida = new PictureBox();
            pbFondoBienvenida = new PictureBox();
            lbBienvenida = new Label();
            btnIniciarSesion = new Btn_personalizado();
            btnRegistrarse = new Btn_personalizado();
            btnBienvenidaCerrar = new Btn_personalizado();
            ((System.ComponentModel.ISupportInitialize)pbLogoBienvenida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFondoBienvenida).BeginInit();
            SuspendLayout();
            // 
            // pbLogoBienvenida
            // 
            pbLogoBienvenida.BackColor = Color.FromArgb(242, 242, 242);
            pbLogoBienvenida.Image = (Image)resources.GetObject("pbLogoBienvenida.Image");
            pbLogoBienvenida.Location = new Point(335, 141);
            pbLogoBienvenida.Name = "pbLogoBienvenida";
            pbLogoBienvenida.Size = new Size(487, 135);
            pbLogoBienvenida.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoBienvenida.TabIndex = 0;
            pbLogoBienvenida.TabStop = false;
            pbLogoBienvenida.Click += pbLogoBienvenida_Click;
            // 
            // pbFondoBienvenida
            // 
            pbFondoBienvenida.Image = (Image)resources.GetObject("pbFondoBienvenida.Image");
            pbFondoBienvenida.Location = new Point(85, 69);
            pbFondoBienvenida.Name = "pbFondoBienvenida";
            pbFondoBienvenida.Size = new Size(949, 599);
            pbFondoBienvenida.SizeMode = PictureBoxSizeMode.Zoom;
            pbFondoBienvenida.TabIndex = 1;
            pbFondoBienvenida.TabStop = false;
            pbFondoBienvenida.Click += pbFondoBienvenida_Click;
            // 
            // lbBienvenida
            // 
            lbBienvenida.BackColor = Color.FromArgb(242, 242, 242);
            lbBienvenida.Font = new Font("Clear Sans", 15F, FontStyle.Bold);
            lbBienvenida.Location = new Point(469, 311);
            lbBienvenida.Name = "lbBienvenida";
            lbBienvenida.Size = new Size(181, 39);
            lbBienvenida.TabIndex = 2;
            lbBienvenida.Text = "¡Bienvenido!";
            lbBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            lbBienvenida.Click += lbBienvenida_Click;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.FromArgb(174, 225, 235);
            btnIniciarSesion.FlatAppearance.BorderSize = 0;
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Comfortaa", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciarSesion.ForeColor = Color.FromArgb(97, 54, 37);
            btnIniciarSesion.Location = new Point(469, 373);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(195, 63);
            btnIniciarSesion.TabIndex = 3;
            btnIniciarSesion.Text = "Inciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.FromArgb(174, 225, 235);
            btnRegistrarse.FlatAppearance.BorderSize = 0;
            btnRegistrarse.FlatStyle = FlatStyle.Flat;
            btnRegistrarse.Font = new Font("Comfortaa", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarse.ForeColor = Color.FromArgb(97, 54, 37);
            btnRegistrarse.Location = new Point(469, 465);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(195, 63);
            btnRegistrarse.TabIndex = 4;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // btnBienvenidaCerrar
            // 
            btnBienvenidaCerrar.BackColor = Color.FromArgb(174, 225, 235);
            btnBienvenidaCerrar.FlatAppearance.BorderSize = 0;
            btnBienvenidaCerrar.FlatStyle = FlatStyle.Flat;
            btnBienvenidaCerrar.Font = new Font("Comfortaa", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBienvenidaCerrar.ForeColor = Color.FromArgb(97, 54, 37);
            btnBienvenidaCerrar.Location = new Point(469, 555);
            btnBienvenidaCerrar.Name = "btnBienvenidaCerrar";
            btnBienvenidaCerrar.Size = new Size(195, 63);
            btnBienvenidaCerrar.TabIndex = 5;
            btnBienvenidaCerrar.Text = "Cerrar";
            btnBienvenidaCerrar.UseVisualStyleBackColor = false;
            btnBienvenidaCerrar.Click += btnBienvenidaCerrar_Click;
            // 
            // PantallaBienvenida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 241, 62);
            ClientSize = new Size(1109, 725);
            Controls.Add(btnBienvenidaCerrar);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnIniciarSesion);
            Controls.Add(lbBienvenida);
            Controls.Add(pbLogoBienvenida);
            Controls.Add(pbFondoBienvenida);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            MinimumSize = new Size(949, 598);
            Name = "PantallaBienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HackyFox-Bienvenida";
            Load += PantallaBienvenida_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogoBienvenida).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFondoBienvenida).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogoBienvenida;
        private PictureBox pbFondoBienvenida;
        private Label lbBienvenida;
        private Btn_personalizado btnIniciarSesion;
        private Btn_personalizado btnRegistrarse;
        private Btn_personalizado btnBienvenidaCerrar;
    }
}
