namespace HackyFox
{
    partial class Dinamica3Contraseña
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
            lbContraseña = new Label();
            btnNext = new Btn_personalizado();
            SuspendLayout();
            // 
            // lbContraseña
            // 
            lbContraseña.AutoSize = true;
            lbContraseña.Font = new Font("Comfortaa", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbContraseña.ForeColor = Color.FromArgb(97, 54, 37);
            lbContraseña.Location = new Point(119, 352);
            lbContraseña.Name = "lbContraseña";
            lbContraseña.Size = new Size(312, 69);
            lbContraseña.TabIndex = 0;
            lbContraseña.Text = "Manzana15_";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(255, 206, 1);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Comfortaa", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.FromArgb(97, 54, 37);
            btnNext.Location = new Point(238, 568);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(254, 77);
            btnNext.TabIndex = 5;
            btnNext.Text = "Siguiente";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // Dinamica3Contraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 249, 249);
            BackgroundImage = Properties.Resources.photoKey;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1109, 725);
            Controls.Add(btnNext);
            Controls.Add(lbContraseña);
            Name = "Dinamica3Contraseña";
            Text = "HackyFox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbContraseña;
        private Btn_personalizado btnNext;
    }
}