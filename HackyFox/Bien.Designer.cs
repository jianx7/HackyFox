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
            btnRetoADinamica = new Btn_personalizado();
            panel1 = new Panel();
            pbBien = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbBien).BeginInit();
            SuspendLayout();
            // 
            // btnRetoADinamica
            // 
            btnRetoADinamica.BackColor = Color.FromArgb(255, 206, 1);
            btnRetoADinamica.FlatAppearance.BorderSize = 0;
            btnRetoADinamica.FlatStyle = FlatStyle.Flat;
            btnRetoADinamica.Font = new Font("Comfortaa", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetoADinamica.ForeColor = Color.FromArgb(24, 76, 172);
            btnRetoADinamica.Location = new Point(232, 529);
            btnRetoADinamica.Margin = new Padding(3, 4, 3, 4);
            btnRetoADinamica.Name = "btnRetoADinamica";
            btnRetoADinamica.Size = new Size(331, 99);
            btnRetoADinamica.TabIndex = 1;
            btnRetoADinamica.Text = "¡Sigamos!";
            btnRetoADinamica.UseVisualStyleBackColor = false;
            btnRetoADinamica.Click += btnRetoADinamica_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(btnRetoADinamica);
            panel1.Controls.Add(pbBien);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 725);
            panel1.TabIndex = 2;
            // 
            // pbBien
            // 
            pbBien.BackColor = Color.FromArgb(249, 249, 249);
            pbBien.BackgroundImage = Properties.Resources.pet;
            pbBien.BackgroundImageLayout = ImageLayout.Stretch;
            pbBien.Dock = DockStyle.Fill;
            pbBien.Location = new Point(0, 0);
            pbBien.Name = "pbBien";
            pbBien.Size = new Size(1109, 725);
            pbBien.TabIndex = 2;
            pbBien.TabStop = false;
            // 
            // Bien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pet;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1109, 725);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Bien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bien";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbBien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Btn_personalizado btnRetoADinamica;
        private Panel panel1;
        private PictureBox pbBien;
    }
}