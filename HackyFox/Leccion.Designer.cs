namespace HackyFox
{
    partial class Leccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leccion));
            panel1 = new Panel();
            panel2 = new Panel();
            LbTituloLeccion = new Label();
            LbSubtitulo = new Label();
            LbTituloContenido = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            Lbconsejo = new Label();
            TbContenidoDeco = new TextBox();
            pictureBox1 = new PictureBox();
            TbContenido = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(67, 749);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(155, 209, 219);
            panel2.Controls.Add(LbTituloLeccion);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(67, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1303, 62);
            panel2.TabIndex = 1;
            // 
            // LbTituloLeccion
            // 
            LbTituloLeccion.AutoSize = true;
            LbTituloLeccion.Font = new Font("Comfortaa", 23F);
            LbTituloLeccion.ForeColor = SystemColors.Control;
            LbTituloLeccion.Location = new Point(6, 10);
            LbTituloLeccion.Name = "LbTituloLeccion";
            LbTituloLeccion.Size = new Size(113, 49);
            LbTituloLeccion.TabIndex = 0;
            LbTituloLeccion.Text = "label1";
            LbTituloLeccion.Click += LbTituloLeccion_Click;
            // 
            // LbSubtitulo
            // 
            LbSubtitulo.FlatStyle = FlatStyle.Flat;
            LbSubtitulo.Font = new Font("Comfortaa", 19F);
            LbSubtitulo.ForeColor = Color.FromArgb(1, 149, 177);
            LbSubtitulo.Location = new Point(26, 165);
            LbSubtitulo.Name = "LbSubtitulo";
            LbSubtitulo.Size = new Size(486, 128);
            LbSubtitulo.TabIndex = 1;
            LbSubtitulo.Text = "label3";
            LbSubtitulo.TextAlign = ContentAlignment.MiddleRight;
            LbSubtitulo.Click += LbSubtitulo_Click;
            // 
            // LbTituloContenido
            // 
            LbTituloContenido.FlatStyle = FlatStyle.Flat;
            LbTituloContenido.Font = new Font("Comfortaa", 23F);
            LbTituloContenido.ForeColor = Color.FromArgb(1, 149, 177);
            LbTituloContenido.Location = new Point(16, 27);
            LbTituloContenido.Name = "LbTituloContenido";
            LbTituloContenido.Size = new Size(496, 101);
            LbTituloContenido.TabIndex = 1;
            LbTituloContenido.Text = "label2";
            LbTituloContenido.TextAlign = ContentAlignment.MiddleLeft;
            LbTituloContenido.Click += LbTituloContenido_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 241, 62);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(TbContenido);
            panel3.Controls.Add(LbSubtitulo);
            panel3.Controls.Add(LbTituloContenido);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(67, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(1303, 687);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(Lbconsejo);
            panel4.Controls.Add(TbContenidoDeco);
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(606, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(697, 687);
            panel4.TabIndex = 3;
            // 
            // Lbconsejo
            // 
            Lbconsejo.BackColor = Color.White;
            Lbconsejo.Font = new Font("Comfortaa", 20F);
            Lbconsejo.ForeColor = Color.FromArgb(1, 149, 177);
            Lbconsejo.Location = new Point(298, 58);
            Lbconsejo.Name = "Lbconsejo";
            Lbconsejo.Size = new Size(314, 119);
            Lbconsejo.TabIndex = 4;
            Lbconsejo.Text = "label1";
            // 
            // TbContenidoDeco
            // 
            TbContenidoDeco.BorderStyle = BorderStyle.None;
            TbContenidoDeco.Enabled = false;
            TbContenidoDeco.Font = new Font("Comfortaa", 18F);
            TbContenidoDeco.ForeColor = Color.FromArgb(1, 149, 177);
            TbContenidoDeco.Location = new Point(86, 296);
            TbContenidoDeco.Multiline = true;
            TbContenidoDeco.Name = "TbContenidoDeco";
            TbContenidoDeco.ReadOnly = true;
            TbContenidoDeco.Size = new Size(547, 320);
            TbContenidoDeco.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.consejopic;
            pictureBox1.Location = new Point(77, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(569, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TbContenido
            // 
            TbContenido.BorderStyle = BorderStyle.None;
            TbContenido.Enabled = false;
            TbContenido.Font = new Font("Comfortaa", 18F);
            TbContenido.ForeColor = Color.FromArgb(1, 149, 177);
            TbContenido.Location = new Point(26, 296);
            TbContenido.Multiline = true;
            TbContenido.Name = "TbContenido";
            TbContenido.ReadOnly = true;
            TbContenido.Size = new Size(542, 320);
            TbContenido.TabIndex = 2;
            TbContenido.TextAlign = HorizontalAlignment.Center;
            // 
            // Leccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Leccion";
            Text = "Leccion";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label LbTituloLeccion;
        private Label LbSubtitulo;
        private Label LbTituloContenido;
        private Panel panel3;
        private TextBox TbContenido;
        private Panel panel4;
        private PictureBox pictureBox1;
        private TextBox TbContenidoDeco;
        private Label Lbconsejo;
    }
}