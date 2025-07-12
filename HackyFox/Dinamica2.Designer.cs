namespace HackyFox
{
    partial class Dinamica2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dinamica2));
            pMenuD2 = new Panel();
            pNombreD2 = new Panel();
            lbTituloD2 = new Label();
            lbIntruccionesD2 = new Label();
            btnD2R1 = new Button();
            btnD2R2 = new Button();
            btnD2R3 = new Button();
            lbNombreD2 = new Label();
            pNombreD2.SuspendLayout();
            SuspendLayout();
            // 
            // pMenuD2
            // 
            pMenuD2.Dock = DockStyle.Left;
            pMenuD2.Location = new Point(0, 0);
            pMenuD2.Name = "pMenuD2";
            pMenuD2.Size = new Size(100, 726);
            pMenuD2.TabIndex = 0;
            // 
            // pNombreD2
            // 
            pNombreD2.BackColor = Color.FromArgb(155, 209, 219);
            pNombreD2.Controls.Add(lbNombreD2);
            pNombreD2.Dock = DockStyle.Top;
            pNombreD2.Location = new Point(100, 0);
            pNombreD2.Name = "pNombreD2";
            pNombreD2.Size = new Size(1008, 70);
            pNombreD2.TabIndex = 1;
            // 
            // lbTituloD2
            // 
            lbTituloD2.AutoSize = true;
            lbTituloD2.Font = new Font("Clear Sans", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTituloD2.ForeColor = Color.FromArgb(242, 139, 12);
            lbTituloD2.Location = new Point(284, 110);
            lbTituloD2.Name = "lbTituloD2";
            lbTituloD2.Size = new Size(628, 66);
            lbTituloD2.TabIndex = 2;
            lbTituloD2.Text = "¿Compartir o no compartir?";
            // 
            // lbIntruccionesD2
            // 
            lbIntruccionesD2.AutoSize = true;
            lbIntruccionesD2.Font = new Font("Comfortaa", 15F);
            lbIntruccionesD2.ForeColor = Color.FromArgb(0, 74, 173);
            lbIntruccionesD2.Location = new Point(250, 186);
            lbIntruccionesD2.Name = "lbIntruccionesD2";
            lbIntruccionesD2.Size = new Size(703, 39);
            lbIntruccionesD2.TabIndex = 3;
            lbIntruccionesD2.Text = "Haz clic en la opción que SÍ compartirías en internet.";
            // 
            // btnD2R1
            // 
            btnD2R1.Image = Properties.Resources.btn_Dinamica2;
            btnD2R1.Location = new Point(200, 279);
            btnD2R1.Name = "btnD2R1";
            btnD2R1.Size = new Size(255, 388);
            btnD2R1.TabIndex = 4;
            btnD2R1.UseVisualStyleBackColor = true;
            // 
            // btnD2R2
            // 
            btnD2R2.Image = Properties.Resources.btn1_Dinamica2;
            btnD2R2.Location = new Point(500, 279);
            btnD2R2.Name = "btnD2R2";
            btnD2R2.Size = new Size(255, 388);
            btnD2R2.TabIndex = 5;
            btnD2R2.UseVisualStyleBackColor = true;
            // 
            // btnD2R3
            // 
            btnD2R3.Image = Properties.Resources.btn2_Dinamica2;
            btnD2R3.Location = new Point(800, 279);
            btnD2R3.Name = "btnD2R3";
            btnD2R3.Size = new Size(255, 388);
            btnD2R3.TabIndex = 6;
            btnD2R3.UseVisualStyleBackColor = true;
            // 
            // lbNombreD2
            // 
            lbNombreD2.AutoSize = true;
            lbNombreD2.Font = new Font("Clear Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNombreD2.ForeColor = Color.White;
            lbNombreD2.Location = new Point(6, 18);
            lbNombreD2.Name = "lbNombreD2";
            lbNombreD2.Size = new Size(314, 39);
            lbNombreD2.TabIndex = 0;
            lbNombreD2.Text = "Lección 2. Mi Yo Digital";
            // 
            // Dinamica2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 726);
            Controls.Add(btnD2R3);
            Controls.Add(btnD2R2);
            Controls.Add(btnD2R1);
            Controls.Add(lbIntruccionesD2);
            Controls.Add(lbTituloD2);
            Controls.Add(pNombreD2);
            Controls.Add(pMenuD2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(950, 600);
            Name = "Dinamica2";
            Text = "Dinamica2";
            pNombreD2.ResumeLayout(false);
            pNombreD2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pMenuD2;
        private Panel pNombreD2;
        private Label lbTituloD2;
        private Label lbIntruccionesD2;
        private Button btnD2R1;
        private Button btnD2R2;
        private Button btnD2R3;
        private Label lbNombreD2;
    }
}