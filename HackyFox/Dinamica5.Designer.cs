namespace HackyFox
{
    partial class Dinamica5
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
            pMenuD5 = new Panel();
            pNombreD5 = new Panel();
            lbNombreD5 = new Label();
            lbTituloD5 = new Label();
            lbInstruccionesD5 = new Label();
            btn_D5R1 = new Btn_personalizado();
            btn_D5R2 = new Btn_personalizado();
            pBImagenD5 = new PictureBox();
            pBMascotaD5 = new PictureBox();
            pNombreD5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBImagenD5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBMascotaD5).BeginInit();
            SuspendLayout();
            // 
            // pMenuD5
            // 
            pMenuD5.Dock = DockStyle.Left;
            pMenuD5.Location = new Point(0, 0);
            pMenuD5.Name = "pMenuD5";
            pMenuD5.Size = new Size(100, 726);
            pMenuD5.TabIndex = 0;
            // 
            // pNombreD5
            // 
            pNombreD5.BackColor = Color.FromArgb(155, 209, 219);
            pNombreD5.Controls.Add(lbNombreD5);
            pNombreD5.Dock = DockStyle.Top;
            pNombreD5.Location = new Point(100, 0);
            pNombreD5.Name = "pNombreD5";
            pNombreD5.Size = new Size(1008, 70);
            pNombreD5.TabIndex = 1;
            // 
            // lbNombreD5
            // 
            lbNombreD5.AutoSize = true;
            lbNombreD5.Font = new Font("Clear Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombreD5.ForeColor = Color.White;
            lbNombreD5.Location = new Point(6, 18);
            lbNombreD5.Name = "lbNombreD5";
            lbNombreD5.Size = new Size(376, 39);
            lbNombreD5.TabIndex = 0;
            lbNombreD5.Text = "Lección 5. El viaje de la foto";
            // 
            // lbTituloD5
            // 
            lbTituloD5.AutoSize = true;
            lbTituloD5.Font = new Font("Comfortaa", 30F, FontStyle.Bold);
            lbTituloD5.ForeColor = Color.FromArgb(0, 151, 178);
            lbTituloD5.Location = new Point(127, 105);
            lbTituloD5.Name = "lbTituloD5";
            lbTituloD5.Size = new Size(754, 78);
            lbTituloD5.TabIndex = 2;
            lbTituloD5.Text = "Pensar antes de compartir";
            // 
            // lbInstruccionesD5
            // 
            lbInstruccionesD5.Font = new Font("Comfortaa", 18F);
            lbInstruccionesD5.ForeColor = Color.FromArgb(0, 151, 178);
            lbInstruccionesD5.Location = new Point(512, 201);
            lbInstruccionesD5.Name = "lbInstruccionesD5";
            lbInstruccionesD5.Size = new Size(380, 121);
            lbInstruccionesD5.TabIndex = 3;
            lbInstruccionesD5.Text = "¿Es seguro publicar la calle de tu casa?";
            lbInstruccionesD5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_D5R1
            // 
            btn_D5R1.BackColor = Color.FromArgb(255, 206, 1);
            btn_D5R1.FlatAppearance.BorderSize = 0;
            btn_D5R1.FlatStyle = FlatStyle.Flat;
            btn_D5R1.Font = new Font("Comfortaa", 18F, FontStyle.Bold);
            btn_D5R1.ForeColor = Color.FromArgb(0, 74, 173);
            btn_D5R1.Location = new Point(597, 353);
            btn_D5R1.Name = "btn_D5R1";
            btn_D5R1.Size = new Size(205, 86);
            btn_D5R1.TabIndex = 4;
            btn_D5R1.Text = "¡Si!";
            btn_D5R1.UseVisualStyleBackColor = false;
            // 
            // btn_D5R2
            // 
            btn_D5R2.BackColor = Color.FromArgb(255, 206, 1);
            btn_D5R2.FlatAppearance.BorderSize = 0;
            btn_D5R2.FlatStyle = FlatStyle.Flat;
            btn_D5R2.Font = new Font("Comfortaa", 18F, FontStyle.Bold);
            btn_D5R2.ForeColor = Color.FromArgb(0, 74, 173);
            btn_D5R2.Location = new Point(597, 480);
            btn_D5R2.Name = "btn_D5R2";
            btn_D5R2.Size = new Size(205, 86);
            btn_D5R2.TabIndex = 5;
            btn_D5R2.Text = "¡No!";
            btn_D5R2.UseVisualStyleBackColor = false;
            // 
            // pBImagenD5
            // 
            pBImagenD5.Image = Properties.Resources.D5Imagen;
            pBImagenD5.Location = new Point(47, 291);
            pBImagenD5.Name = "pBImagenD5";
            pBImagenD5.Size = new Size(530, 546);
            pBImagenD5.SizeMode = PictureBoxSizeMode.Zoom;
            pBImagenD5.TabIndex = 6;
            pBImagenD5.TabStop = false;
            // 
            // pBMascotaD5
            // 
            pBMascotaD5.Image = Properties.Resources.D5Mascota;
            pBMascotaD5.Location = new Point(808, 427);
            pBMascotaD5.Name = "pBMascotaD5";
            pBMascotaD5.Size = new Size(377, 410);
            pBMascotaD5.SizeMode = PictureBoxSizeMode.Zoom;
            pBMascotaD5.TabIndex = 7;
            pBMascotaD5.TabStop = false;
            // 
            // Dinamica5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 726);
            Controls.Add(pBMascotaD5);
            Controls.Add(btn_D5R2);
            Controls.Add(btn_D5R1);
            Controls.Add(lbInstruccionesD5);
            Controls.Add(lbTituloD5);
            Controls.Add(pNombreD5);
            Controls.Add(pMenuD5);
            Controls.Add(pBImagenD5);
            MinimumSize = new Size(950, 600);
            Name = "Dinamica5";
            Text = "Dinamica5";
            pNombreD5.ResumeLayout(false);
            pNombreD5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBImagenD5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBMascotaD5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pMenuD5;
        private Panel pNombreD5;
        private Label lbNombreD5;
        private Label lbTituloD5;
        private Label lbInstruccionesD5;
        private Btn_personalizado btn_D5R1;
        private Btn_personalizado btn_D5R2;
        private PictureBox pBImagenD5;
        private PictureBox pBMascotaD5;
    }
}