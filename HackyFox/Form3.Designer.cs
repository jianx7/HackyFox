﻿namespace HackyFox
{
    partial class PantallaInicioDeSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicioDeSesion));
            pbFondoInicioDeSesion = new PictureBox();
            pbLogoInicioDeSesion = new PictureBox();
            lbInicioDeSesion = new Label();
            lbAliasInicioDeSesion = new Label();
            tbAliasInicioDeSesion = new TextBox();
            pbMascotaInicioDeSesion = new PictureBox();
            btnCorroborarAlias = new Btn_personalizado();
            ((System.ComponentModel.ISupportInitialize)pbFondoInicioDeSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoInicioDeSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMascotaInicioDeSesion).BeginInit();
            SuspendLayout();
            // 
            // pbFondoInicioDeSesion
            // 
            pbFondoInicioDeSesion.Image = (Image)resources.GetObject("pbFondoInicioDeSesion.Image");
            pbFondoInicioDeSesion.Location = new Point(191, 175);
            pbFondoInicioDeSesion.Name = "pbFondoInicioDeSesion";
            pbFondoInicioDeSesion.Size = new Size(736, 636);
            pbFondoInicioDeSesion.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFondoInicioDeSesion.TabIndex = 1;
            pbFondoInicioDeSesion.TabStop = false;
            // 
            // pbLogoInicioDeSesion
            // 
            pbLogoInicioDeSesion.Image = (Image)resources.GetObject("pbLogoInicioDeSesion.Image");
            pbLogoInicioDeSesion.Location = new Point(306, 27);
            pbLogoInicioDeSesion.Name = "pbLogoInicioDeSesion";
            pbLogoInicioDeSesion.Size = new Size(479, 129);
            pbLogoInicioDeSesion.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoInicioDeSesion.TabIndex = 2;
            pbLogoInicioDeSesion.TabStop = false;
            // 
            // lbInicioDeSesion
            // 
            lbInicioDeSesion.BackColor = Color.FromArgb(242, 242, 242);
            lbInicioDeSesion.Font = new Font("Comfortaa", 18F, FontStyle.Bold);
            lbInicioDeSesion.ForeColor = Color.FromArgb(0, 151, 178);
            lbInicioDeSesion.Location = new Point(360, 257);
            lbInicioDeSesion.Name = "lbInicioDeSesion";
            lbInicioDeSesion.Size = new Size(409, 116);
            lbInicioDeSesion.TabIndex = 3;
            lbInicioDeSesion.Text = "¿Recuerdas el nombre de tu mascota?";
            lbInicioDeSesion.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbAliasInicioDeSesion
            // 
            lbAliasInicioDeSesion.AutoSize = true;
            lbAliasInicioDeSesion.BackColor = Color.FromArgb(242, 242, 242);
            lbAliasInicioDeSesion.Font = new Font("Comfortaa", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAliasInicioDeSesion.ForeColor = Color.FromArgb(97, 54, 37);
            lbAliasInicioDeSesion.Location = new Point(393, 411);
            lbAliasInicioDeSesion.Name = "lbAliasInicioDeSesion";
            lbAliasInicioDeSesion.Size = new Size(333, 28);
            lbAliasInicioDeSesion.TabIndex = 4;
            lbAliasInicioDeSesion.Text = "(Escribelo aquí para comenzar)";
            // 
            // tbAliasInicioDeSesion
            // 
            tbAliasInicioDeSesion.BackColor = Color.FromArgb(196, 211, 217);
            tbAliasInicioDeSesion.Location = new Point(403, 502);
            tbAliasInicioDeSesion.Multiline = true;
            tbAliasInicioDeSesion.Name = "tbAliasInicioDeSesion";
            tbAliasInicioDeSesion.Size = new Size(312, 40);
            tbAliasInicioDeSesion.TabIndex = 5;
            tbAliasInicioDeSesion.TextAlign = HorizontalAlignment.Center;
            tbAliasInicioDeSesion.TextChanged += tbAliasInicioDeSesion_TextChanged;
            // 
            // pbMascotaInicioDeSesion
            // 
            pbMascotaInicioDeSesion.BackColor = Color.FromArgb(242, 242, 242);
            pbMascotaInicioDeSesion.Image = (Image)resources.GetObject("pbMascotaInicioDeSesion.Image");
            pbMascotaInicioDeSesion.Location = new Point(745, 464);
            pbMascotaInicioDeSesion.Name = "pbMascotaInicioDeSesion";
            pbMascotaInicioDeSesion.Size = new Size(82, 87);
            pbMascotaInicioDeSesion.SizeMode = PictureBoxSizeMode.Zoom;
            pbMascotaInicioDeSesion.TabIndex = 8;
            pbMascotaInicioDeSesion.TabStop = false;
            // 
            // btnCorroborarAlias
            // 
            btnCorroborarAlias.BackColor = Color.FromArgb(174, 225, 235);
            btnCorroborarAlias.FlatAppearance.BorderSize = 0;
            btnCorroborarAlias.FlatStyle = FlatStyle.Flat;
            btnCorroborarAlias.Font = new Font("Comfortaa", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCorroborarAlias.ForeColor = Color.FromArgb(97, 54, 37);
            btnCorroborarAlias.Location = new Point(418, 591);
            btnCorroborarAlias.Name = "btnCorroborarAlias";
            btnCorroborarAlias.Size = new Size(266, 89);
            btnCorroborarAlias.TabIndex = 9;
            btnCorroborarAlias.Text = "¡Justo como lo recordaba!";
            btnCorroborarAlias.UseVisualStyleBackColor = false;
            btnCorroborarAlias.Click += btnCorroborarAlias_Click;
            // 
            // PantallaInicioDeSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 241, 62);
            ClientSize = new Size(1108, 726);
            Controls.Add(btnCorroborarAlias);
            Controls.Add(pbMascotaInicioDeSesion);
            Controls.Add(tbAliasInicioDeSesion);
            Controls.Add(lbAliasInicioDeSesion);
            Controls.Add(lbInicioDeSesion);
            Controls.Add(pbLogoInicioDeSesion);
            Controls.Add(pbFondoInicioDeSesion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(950, 600);
            Name = "PantallaInicioDeSesion";
            Text = "HackyFox-Inicio de sesión";
            ((System.ComponentModel.ISupportInitialize)pbFondoInicioDeSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoInicioDeSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMascotaInicioDeSesion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFondoInicioDeSesion;
        private PictureBox pbLogoInicioDeSesion;
        private Label lbInicioDeSesion;
        private Label lbAliasInicioDeSesion;
        private TextBox tbAliasInicioDeSesion;
        private PictureBox pbMascotaInicioDeSesion;
        private Btn_personalizado btnCorroborarAlias;
    }
}