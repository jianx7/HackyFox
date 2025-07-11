namespace HackyFox
{
    partial class Bien
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
            picRespuestaCorrecta = new PictureBox();
            btnRetoADinamica = new Btn_personalizado();
            ((System.ComponentModel.ISupportInitialize)picRespuestaCorrecta).BeginInit();
            SuspendLayout();
            // 
            // picRespuestaCorrecta
            // 
            picRespuestaCorrecta.Image = Properties.Resources.pet;
            picRespuestaCorrecta.Location = new Point(-5, -3);
            picRespuestaCorrecta.Name = "picRespuestaCorrecta";
            picRespuestaCorrecta.Size = new Size(1113, 734);
            picRespuestaCorrecta.SizeMode = PictureBoxSizeMode.Zoom;
            picRespuestaCorrecta.TabIndex = 0;
            picRespuestaCorrecta.TabStop = false;
            // 
            // btnRetoADinamica
            // 
            btnRetoADinamica.BackColor = Color.FromArgb(255, 206, 1);
            btnRetoADinamica.FlatAppearance.BorderSize = 0;
            btnRetoADinamica.FlatStyle = FlatStyle.Flat;
            btnRetoADinamica.Font = new Font("Comfortaa", 18F);
            btnRetoADinamica.ForeColor = Color.FromArgb(24, 76, 172);
            btnRetoADinamica.Location = new Point(173, 509);
            btnRetoADinamica.Name = "btnRetoADinamica";
            btnRetoADinamica.Size = new Size(290, 74);
            btnRetoADinamica.TabIndex = 1;
            btnRetoADinamica.Text = "¡Sigamos!";
            btnRetoADinamica.UseVisualStyleBackColor = false;
            btnRetoADinamica.Click += btnRetoADinamica_Click;
            // 
            // Bien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 734);
            Controls.Add(btnRetoADinamica);
            Controls.Add(picRespuestaCorrecta);
            Name = "Bien";
            Text = "Bien";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)picRespuestaCorrecta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picRespuestaCorrecta;
        private Btn_personalizado btnRetoADinamica;
    }
}