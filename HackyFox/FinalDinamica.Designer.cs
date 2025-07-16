namespace HackyFox
{
    partial class FinalDinamica
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
            panel1 = new Panel();
            btnVolverAlMenu = new Btn_personalizado();
            btnSiguienteLeccion = new Btn_personalizado();
            pbBien = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(btnVolverAlMenu);
            panel1.Controls.Add(btnSiguienteLeccion);
            panel1.Controls.Add(pbBien);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1269, 979);
            panel1.TabIndex = 3;
            // 
            // btnVolverAlMenu
            // 
            btnVolverAlMenu.BackColor = Color.FromArgb(155, 209, 219);
            btnVolverAlMenu.FlatAppearance.BorderSize = 0;
            btnVolverAlMenu.FlatStyle = FlatStyle.Flat;
            btnVolverAlMenu.Font = new Font("Comfortaa", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverAlMenu.ForeColor = Color.FromArgb(24, 76, 172);
            btnVolverAlMenu.Location = new Point(454, 543);
            btnVolverAlMenu.Margin = new Padding(3, 4, 3, 4);
            btnVolverAlMenu.Name = "btnVolverAlMenu";
            btnVolverAlMenu.Size = new Size(331, 99);
            btnVolverAlMenu.TabIndex = 3;
            btnVolverAlMenu.Text = "Volver al menú";
            btnVolverAlMenu.UseVisualStyleBackColor = false;
            btnVolverAlMenu.Click += btnVolverAlMenu_Click;
            // 
            // btnSiguienteLeccion
            // 
            btnSiguienteLeccion.BackColor = Color.FromArgb(255, 206, 1);
            btnSiguienteLeccion.FlatAppearance.BorderSize = 0;
            btnSiguienteLeccion.FlatStyle = FlatStyle.Flat;
            btnSiguienteLeccion.Font = new Font("Comfortaa", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguienteLeccion.ForeColor = Color.FromArgb(24, 76, 172);
            btnSiguienteLeccion.Location = new Point(86, 543);
            btnSiguienteLeccion.Margin = new Padding(3, 4, 3, 4);
            btnSiguienteLeccion.Name = "btnSiguienteLeccion";
            btnSiguienteLeccion.Size = new Size(331, 99);
            btnSiguienteLeccion.TabIndex = 1;
            btnSiguienteLeccion.Text = "¡Sigamos!";
            btnSiguienteLeccion.UseVisualStyleBackColor = false;
            btnSiguienteLeccion.Click += btnSiguienteLeccion_Click;
            // 
            // pbBien
            // 
            pbBien.BackColor = Color.FromArgb(249, 249, 249);
            pbBien.Dock = DockStyle.Fill;
            pbBien.Image = Properties.Resources.pet;
            pbBien.Location = new Point(0, 0);
            pbBien.Name = "pbBien";
            pbBien.Size = new Size(1269, 979);
            pbBien.TabIndex = 2;
            pbBien.TabStop = false;
            // 
            // FinalDinamica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 979);
            Controls.Add(panel1);
            Name = "FinalDinamica";
            Text = "FinalDinamica";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Btn_personalizado btnSiguienteLeccion;
        private PictureBox pbBien;
        private Btn_personalizado btnVolverAlMenu;
    }
}