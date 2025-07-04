﻿namespace HackyFox
{
    partial class PantallaRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistro));
            pbFondoRegistro = new PictureBox();
            pbLogoRegistro = new PictureBox();
            lbNacimiento = new Label();
            tbNacimiento = new TextBox();
            lbAliasRegistro = new Label();
            lbAdvertenciaRegistro = new Label();
            tbAliasRegistro = new TextBox();
            btnRegistroAlias = new Btn_personalizado();
            pbPastelRegistro = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbFondoRegistro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoRegistro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPastelRegistro).BeginInit();
            SuspendLayout();
            // 
            // pbFondoRegistro
            // 
            pbFondoRegistro.Image = (Image)resources.GetObject("pbFondoRegistro.Image");
            pbFondoRegistro.Location = new Point(186, 170);
            pbFondoRegistro.Name = "pbFondoRegistro";
            pbFondoRegistro.Size = new Size(736, 636);
            pbFondoRegistro.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFondoRegistro.TabIndex = 0;
            pbFondoRegistro.TabStop = false;
            // 
            // pbLogoRegistro
            // 
            pbLogoRegistro.Image = (Image)resources.GetObject("pbLogoRegistro.Image");
            pbLogoRegistro.Location = new Point(313, 25);
            pbLogoRegistro.Name = "pbLogoRegistro";
            pbLogoRegistro.Size = new Size(479, 129);
            pbLogoRegistro.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoRegistro.TabIndex = 1;
            pbLogoRegistro.TabStop = false;
            // 
            // lbNacimiento
            // 
            lbNacimiento.BackColor = Color.FromArgb(242, 242, 242);
            lbNacimiento.Font = new Font("Comfortaa", 16F, FontStyle.Bold);
            lbNacimiento.ForeColor = Color.FromArgb(0, 151, 178);
            lbNacimiento.Location = new Point(400, 222);
            lbNacimiento.Name = "lbNacimiento";
            lbNacimiento.Size = new Size(292, 49);
            lbNacimiento.TabIndex = 2;
            lbNacimiento.Text = "¿Cuándo naciste?";
            // 
            // tbNacimiento
            // 
            tbNacimiento.BackColor = Color.FromArgb(196, 211, 217);
            tbNacimiento.Location = new Point(391, 298);
            tbNacimiento.Multiline = true;
            tbNacimiento.Name = "tbNacimiento";
            tbNacimiento.Size = new Size(312, 40);
            tbNacimiento.TabIndex = 3;
            tbNacimiento.TextAlign = HorizontalAlignment.Center;
            // 
            // lbAliasRegistro
            // 
            lbAliasRegistro.BackColor = Color.FromArgb(242, 242, 242);
            lbAliasRegistro.Font = new Font("Comfortaa", 16F, FontStyle.Bold);
            lbAliasRegistro.ForeColor = Color.FromArgb(0, 151, 178);
            lbAliasRegistro.Location = new Point(350, 351);
            lbAliasRegistro.Name = "lbAliasRegistro";
            lbAliasRegistro.Size = new Size(411, 98);
            lbAliasRegistro.TabIndex = 4;
            lbAliasRegistro.Text = "¡Elige un alias a tu compañero!";
            lbAliasRegistro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbAdvertenciaRegistro
            // 
            lbAdvertenciaRegistro.AutoSize = true;
            lbAdvertenciaRegistro.BackColor = Color.FromArgb(242, 242, 242);
            lbAdvertenciaRegistro.Font = new Font("Comfortaa", 11F, FontStyle.Bold);
            lbAdvertenciaRegistro.ForeColor = Color.FromArgb(97, 54, 37);
            lbAdvertenciaRegistro.Location = new Point(411, 462);
            lbAdvertenciaRegistro.Name = "lbAdvertenciaRegistro";
            lbAdvertenciaRegistro.Size = new Size(281, 29);
            lbAdvertenciaRegistro.TabIndex = 5;
            lbAdvertenciaRegistro.Text = "(No uses tu nombre real)";
            // 
            // tbAliasRegistro
            // 
            tbAliasRegistro.BackColor = Color.FromArgb(196, 211, 217);
            tbAliasRegistro.Location = new Point(391, 525);
            tbAliasRegistro.Multiline = true;
            tbAliasRegistro.Name = "tbAliasRegistro";
            tbAliasRegistro.Size = new Size(312, 40);
            tbAliasRegistro.TabIndex = 6;
            tbAliasRegistro.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRegistroAlias
            // 
            btnRegistroAlias.BackColor = Color.FromArgb(174, 225, 235);
            btnRegistroAlias.FlatAppearance.BorderSize = 0;
            btnRegistroAlias.FlatStyle = FlatStyle.Flat;
            btnRegistroAlias.Font = new Font("Comfortaa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistroAlias.ForeColor = Color.FromArgb(97, 54, 37);
            btnRegistroAlias.Location = new Point(427, 602);
            btnRegistroAlias.Name = "btnRegistroAlias";
            btnRegistroAlias.Size = new Size(239, 91);
            btnRegistroAlias.TabIndex = 7;
            btnRegistroAlias.Text = "¡﻿ Me gusta ese nombre ! ";
            btnRegistroAlias.UseVisualStyleBackColor = false;
            btnRegistroAlias.Click += btnRegistroAlias_Click;
            // 
            // pbPastelRegistro
            // 
            pbPastelRegistro.BackColor = Color.FromArgb(242, 242, 242);
            pbPastelRegistro.Image = (Image)resources.GetObject("pbPastelRegistro.Image");
            pbPastelRegistro.Location = new Point(718, 290);
            pbPastelRegistro.Name = "pbPastelRegistro";
            pbPastelRegistro.Size = new Size(55, 58);
            pbPastelRegistro.SizeMode = PictureBoxSizeMode.Zoom;
            pbPastelRegistro.TabIndex = 8;
            pbPastelRegistro.TabStop = false;
            // 
            // PantallaRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 241, 62);
            ClientSize = new Size(1108, 726);
            Controls.Add(pbPastelRegistro);
            Controls.Add(btnRegistroAlias);
            Controls.Add(tbAliasRegistro);
            Controls.Add(lbAdvertenciaRegistro);
            Controls.Add(lbAliasRegistro);
            Controls.Add(tbNacimiento);
            Controls.Add(lbNacimiento);
            Controls.Add(pbLogoRegistro);
            Controls.Add(pbFondoRegistro);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(950, 600);
            Name = "PantallaRegistro";
            Text = " ";
            Load += PantallaRegistro_Load;
            ((System.ComponentModel.ISupportInitialize)pbFondoRegistro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoRegistro).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPastelRegistro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFondoRegistro;
        private PictureBox pbLogoRegistro;
        private Label lbNacimiento;
        private TextBox tbNacimiento;
        private Label lbAliasRegistro;
        private Label lbAdvertenciaRegistro;
        private TextBox tbAliasRegistro;
        private Btn_personalizado btnRegistroAlias;
        private PictureBox pbPastelRegistro;
    }
}