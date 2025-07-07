namespace HackyFox
{
    partial class RetoRelampago
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
            panel2 = new Panel();
            LbTituloLeccionR = new Label();
            PicRetoRelampagoT = new PictureBox();
            PicRetoFondo = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicRetoRelampagoT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicRetoFondo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(67, 734);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(155, 209, 219);
            panel2.Controls.Add(LbTituloLeccionR);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(67, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1043, 62);
            panel2.TabIndex = 2;
            // 
            // LbTituloLeccionR
            // 
            LbTituloLeccionR.AutoSize = true;
            LbTituloLeccionR.Font = new Font("Comfortaa", 23F);
            LbTituloLeccionR.ForeColor = SystemColors.Control;
            LbTituloLeccionR.Location = new Point(6, 10);
            LbTituloLeccionR.Name = "LbTituloLeccionR";
            LbTituloLeccionR.Size = new Size(113, 49);
            LbTituloLeccionR.TabIndex = 0;
            LbTituloLeccionR.Text = "label1";
            // 
            // PicRetoRelampagoT
            // 
            PicRetoRelampagoT.Image = Properties.Resources.Pantallas_HackyFox_2;
            PicRetoRelampagoT.Location = new Point(275, 68);
            PicRetoRelampagoT.Name = "PicRetoRelampagoT";
            PicRetoRelampagoT.Size = new Size(678, 99);
            PicRetoRelampagoT.SizeMode = PictureBoxSizeMode.Zoom;
            PicRetoRelampagoT.TabIndex = 3;
            PicRetoRelampagoT.TabStop = false;
            // 
            // PicRetoFondo
            // 
            PicRetoFondo.Image = Properties.Resources.Pantallas_HackyFox_3;
            PicRetoFondo.Location = new Point(92, 100);
            PicRetoFondo.Name = "PicRetoFondo";
            PicRetoFondo.Size = new Size(979, 561);
            PicRetoFondo.SizeMode = PictureBoxSizeMode.Zoom;
            PicRetoFondo.TabIndex = 4;
            PicRetoFondo.TabStop = false;
            // 
            // RetoRelampago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 734);
            Controls.Add(PicRetoRelampagoT);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PicRetoFondo);
            Name = "RetoRelampago";
            Text = "RetoRelampago";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PicRetoRelampagoT).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicRetoFondo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label LbTituloLeccionR;
        private PictureBox PicRetoRelampagoT;
        private PictureBox PicRetoFondo;
    }
}