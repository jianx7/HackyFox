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
            ((System.ComponentModel.ISupportInitialize)picRespuestaCorrecta).BeginInit();
            SuspendLayout();
            // 
            // picRespuestaCorrecta
            // 
            picRespuestaCorrecta.Image = Properties.Resources.pet;
            picRespuestaCorrecta.Location = new Point(-4, -1);
            picRespuestaCorrecta.Name = "picRespuestaCorrecta";
            picRespuestaCorrecta.Size = new Size(1113, 734);
            picRespuestaCorrecta.SizeMode = PictureBoxSizeMode.Zoom;
            picRespuestaCorrecta.TabIndex = 0;
            picRespuestaCorrecta.TabStop = false;
            // 
            // Bien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 734);
            Controls.Add(picRespuestaCorrecta);
            Name = "Bien";
            Text = "Bien";
            ((System.ComponentModel.ISupportInitialize)picRespuestaCorrecta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picRespuestaCorrecta;
    }
}