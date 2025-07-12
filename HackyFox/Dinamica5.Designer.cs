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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dinamica5));
            pMenuD5 = new Panel();
            pNombreD5 = new Panel();
            lbTituloD5 = new Label();
            lbInstruccionesD5 = new Label();
            btnD5R1 = new Btn_personalizado();
            btnD5R2 = new Btn_personalizado();
            pBImagenD5 = new PictureBox();
            pBMascotaD5 = new PictureBox();
            lbNombreD1 = new Label();
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
            pNombreD5.Controls.Add(lbNombreD1);
            pNombreD5.Dock = DockStyle.Top;
            pNombreD5.Location = new Point(100, 0);
            pNombreD5.Name = "pNombreD5";
            pNombreD5.Size = new Size(1008, 70);
            pNombreD5.TabIndex = 1;
            // 
            // lbTituloD5
            // 
            lbTituloD5.AutoSize = true;
            lbTituloD5.Font = new Font("Comfortaa", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloD5.ForeColor = Color.FromArgb(0, 151, 178);
            lbTituloD5.Location = new Point(122, 88);
            lbTituloD5.Name = "lbTituloD5";
            lbTituloD5.Size = new Size(713, 73);
            lbTituloD5.TabIndex = 2;
            lbTituloD5.Text = "Pensar antes de compartir";
            // 
            // lbInstruccionesD5
            // 
            lbInstruccionesD5.Font = new Font("Comfortaa", 18F);
            lbInstruccionesD5.ForeColor = Color.FromArgb(0, 151, 178);
            lbInstruccionesD5.Location = new Point(517, 183);
            lbInstruccionesD5.Name = "lbInstruccionesD5";
            lbInstruccionesD5.Size = new Size(454, 114);
            lbInstruccionesD5.TabIndex = 3;
            lbInstruccionesD5.Text = "¿Es seguro publicar la calle de tu casa?";
            lbInstruccionesD5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnD5R1
            // 
            btnD5R1.BackColor = Color.FromArgb(255, 206, 1);
            btnD5R1.FlatAppearance.BorderSize = 0;
            btnD5R1.FlatStyle = FlatStyle.Flat;
            btnD5R1.Font = new Font("Comfortaa", 18F);
            btnD5R1.ForeColor = Color.FromArgb(0, 74, 173);
            btnD5R1.Location = new Point(602, 334);
            btnD5R1.Name = "btnD5R1";
            btnD5R1.Size = new Size(179, 82);
            btnD5R1.TabIndex = 4;
            btnD5R1.Text = "¡Si!";
            btnD5R1.UseVisualStyleBackColor = false;
            // 
            // btnD5R2
            // 
            btnD5R2.BackColor = Color.FromArgb(255, 206, 1);
            btnD5R2.FlatAppearance.BorderSize = 0;
            btnD5R2.FlatStyle = FlatStyle.Flat;
            btnD5R2.Font = new Font("Comfortaa", 18F);
            btnD5R2.ForeColor = Color.FromArgb(0, 74, 173);
            btnD5R2.Location = new Point(602, 443);
            btnD5R2.Name = "btnD5R2";
            btnD5R2.Size = new Size(179, 82);
            btnD5R2.TabIndex = 5;
            btnD5R2.Text = "¡No!";
            btnD5R2.UseVisualStyleBackColor = false;
            // 
            // pBImagenD5
            // 
            pBImagenD5.Image = Properties.Resources.D5Imagen;
            pBImagenD5.Location = new Point(31, 270);
            pBImagenD5.Name = "pBImagenD5";
            pBImagenD5.Size = new Size(480, 598);
            pBImagenD5.SizeMode = PictureBoxSizeMode.Zoom;
            pBImagenD5.TabIndex = 6;
            pBImagenD5.TabStop = false;
            // 
            // pBMascotaD5
            // 
            pBMascotaD5.Image = Properties.Resources.D5Mascota;
            pBMascotaD5.Location = new Point(766, 422);
            pBMascotaD5.Name = "pBMascotaD5";
            pBMascotaD5.Size = new Size(422, 424);
            pBMascotaD5.SizeMode = PictureBoxSizeMode.Zoom;
            pBMascotaD5.TabIndex = 7;
            pBMascotaD5.TabStop = false;
            // 
            // lbNombreD1
            // 
            lbNombreD1.AutoSize = true;
            lbNombreD1.Font = new Font("Clear Sans", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombreD1.ForeColor = Color.White;
            lbNombreD1.Location = new Point(6, 19);
            lbNombreD1.Name = "lbNombreD1";
            lbNombreD1.Size = new Size(336, 35);
            lbNombreD1.TabIndex = 0;
            lbNombreD1.Text = "Lección 5. El viaje de la foto";
            // 
            // Dinamica5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 726);
            Controls.Add(btnD5R2);
            Controls.Add(btnD5R1);
            Controls.Add(lbInstruccionesD5);
            Controls.Add(lbTituloD5);
            Controls.Add(pNombreD5);
            Controls.Add(pMenuD5);
            Controls.Add(pBImagenD5);
            Controls.Add(pBMascotaD5);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label lbTituloD5;
        private Label lbInstruccionesD5;
        private Btn_personalizado btnD5R1;
        private Btn_personalizado btnD5R2;
        private PictureBox pBImagenD5;
        private PictureBox pBMascotaD5;
        private Label lbNombreD1;
    }
}