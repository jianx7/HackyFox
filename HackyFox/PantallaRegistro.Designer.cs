namespace HackyFox
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
            lbAliasRegistro = new Label();
            lbAdvertenciaRegistro = new Label();
            tbAliasRegistro = new TextBox();
            btnRegistroAlias = new Btn_personalizado();
            pbPastelRegistro = new PictureBox();
            btnRegistroRegresar = new Btn_personalizado();
            dTPNacimiento = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pbFondoRegistro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoRegistro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPastelRegistro).BeginInit();
            SuspendLayout();
            // 
            // pbFondoRegistro
            // 
            pbFondoRegistro.Image = (Image)resources.GetObject("pbFondoRegistro.Image");
            pbFondoRegistro.Location = new Point(186, 171);
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
            lbNacimiento.Location = new Point(400, 196);
            lbNacimiento.Name = "lbNacimiento";
            lbNacimiento.Size = new Size(293, 49);
            lbNacimiento.TabIndex = 2;
            lbNacimiento.Text = "¿Cuándo naciste?";
            // 
            // lbAliasRegistro
            // 
            lbAliasRegistro.BackColor = Color.FromArgb(242, 242, 242);
            lbAliasRegistro.Font = new Font("Comfortaa", 16F, FontStyle.Bold);
            lbAliasRegistro.ForeColor = Color.FromArgb(0, 151, 178);
            lbAliasRegistro.Location = new Point(347, 312);
            lbAliasRegistro.Name = "lbAliasRegistro";
            lbAliasRegistro.Size = new Size(411, 99);
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
            lbAdvertenciaRegistro.Location = new Point(411, 425);
            lbAdvertenciaRegistro.Name = "lbAdvertenciaRegistro";
            lbAdvertenciaRegistro.Size = new Size(281, 29);
            lbAdvertenciaRegistro.TabIndex = 5;
            lbAdvertenciaRegistro.Text = "(No uses tu nombre real)";
            // 
            // tbAliasRegistro
            // 
            tbAliasRegistro.BackColor = Color.FromArgb(196, 211, 217);
            tbAliasRegistro.Font = new Font("Comfortaa", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbAliasRegistro.ForeColor = Color.FromArgb(97, 54, 37);
            tbAliasRegistro.Location = new Point(400, 476);
            tbAliasRegistro.Multiline = true;
            tbAliasRegistro.Name = "tbAliasRegistro";
            tbAliasRegistro.Size = new Size(313, 40);
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
            btnRegistroAlias.Location = new Point(431, 539);
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
            pbPastelRegistro.Location = new Point(719, 250);
            pbPastelRegistro.Name = "pbPastelRegistro";
            pbPastelRegistro.Size = new Size(55, 59);
            pbPastelRegistro.SizeMode = PictureBoxSizeMode.Zoom;
            pbPastelRegistro.TabIndex = 8;
            pbPastelRegistro.TabStop = false;
            // 

            // dTPNacimiento
            // 
            dTPNacimiento.CalendarForeColor = Color.FromArgb(97, 54, 37);
            dTPNacimiento.Font = new Font("Comfortaa", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dTPNacimiento.Location = new Point(350, 202);
            dTPNacimiento.Margin = new Padding(3, 2, 3, 2);
            dTPNacimiento.Name = "dTPNacimiento";
            dTPNacimiento.Size = new Size(219, 21);
            dTPNacimiento.TabIndex = 9;
            // 

            // btnRegistroRegresar
            // 
            btnRegistroRegresar.BackColor = Color.FromArgb(174, 225, 235);
            btnRegistroRegresar.FlatAppearance.BorderSize = 0;
            btnRegistroRegresar.FlatStyle = FlatStyle.Flat;
            btnRegistroRegresar.Font = new Font("Comfortaa", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistroRegresar.ForeColor = Color.FromArgb(97, 54, 37);
            btnRegistroRegresar.Location = new Point(450, 649);
            btnRegistroRegresar.Name = "btnRegistroRegresar";
            btnRegistroRegresar.Size = new Size(186, 47);
            btnRegistroRegresar.TabIndex = 10;
            btnRegistroRegresar.Text = "Regresar";
            btnRegistroRegresar.UseVisualStyleBackColor = false;
            btnRegistroRegresar.Click += btnRegistroRegresar_Click;
            // 
            
            // PantallaRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 241, 62);
            ClientSize = new Size(1109, 725);
            Controls.Add(dTPNacimiento);
            Controls.Add(btnRegistroRegresar);
            Controls.Add(pbPastelRegistro);
            Controls.Add(btnRegistroAlias);
            Controls.Add(tbAliasRegistro);
            Controls.Add(lbAdvertenciaRegistro);
            Controls.Add(lbAliasRegistro);
            Controls.Add(lbNacimiento);
            Controls.Add(pbLogoRegistro);
            Controls.Add(pbFondoRegistro);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(949, 598);
            Name = "PantallaRegistro";
            Text = " ";
            WindowState = FormWindowState.Maximized;
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
        private Label lbAliasRegistro;
        private Label lbAdvertenciaRegistro;
        private TextBox tbAliasRegistro;
        private Btn_personalizado btnRegistroAlias;
        private PictureBox pbPastelRegistro;
        private Btn_personalizado btnRegistroRegresar;
        private DateTimePicker dTPNacimiento;
    }
}