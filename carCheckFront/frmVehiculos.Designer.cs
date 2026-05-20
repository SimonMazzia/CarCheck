namespace carCheckFront
{
    partial class frmVehiculos
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
            panelTop = new Panel();
            label1 = new Label();
            panelFormulario = new Panel();
            lblKilometraje = new Label();
            lblAño = new Label();
            lblPatente = new Label();
            lblModelo = new Label();
            lblMarca = new Label();
            panelTabla = new Panel();
            panelTop.SuspendLayout();
            panelFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(0, 122, 204);
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1403, 60);
            panelTop.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(251, 32);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Vehículos";
            // 
            // panelFormulario
            // 
            panelFormulario.BackColor = Color.White;
            panelFormulario.Controls.Add(lblKilometraje);
            panelFormulario.Controls.Add(lblAño);
            panelFormulario.Controls.Add(lblPatente);
            panelFormulario.Controls.Add(lblModelo);
            panelFormulario.Controls.Add(lblMarca);
            panelFormulario.Dock = DockStyle.Top;
            panelFormulario.Location = new Point(0, 60);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(1403, 180);
            panelFormulario.TabIndex = 3;
            panelFormulario.Paint += panelFormulario_Paint;
            // 
            // lblKilometraje
            // 
            lblKilometraje.AutoSize = true;
            lblKilometraje.Font = new Font("Segoe UI", 10F);
            lblKilometraje.Location = new Point(725, 61);
            lblKilometraje.Name = "lblKilometraje";
            lblKilometraje.Size = new Size(77, 19);
            lblKilometraje.TabIndex = 4;
            lblKilometraje.Text = "Kilometraje";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Segoe UI", 10F);
            lblAño.Location = new Point(350, 75);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(38, 19);
            lblAño.TabIndex = 3;
            lblAño.Text = " Año";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Font = new Font("Segoe UI", 10F);
            lblPatente.Location = new Point(350, 30);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(56, 19);
            lblPatente.TabIndex = 2;
            lblPatente.Text = "Patente";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 10F);
            lblModelo.Location = new Point(30, 75);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(56, 19);
            lblModelo.TabIndex = 1;
            lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 10F);
            lblMarca.Location = new Point(30, 30);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(47, 19);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            lblMarca.Click += label2_Click;
            // 
            // panelTabla
            // 
            panelTabla.Dock = DockStyle.Fill;
            panelTabla.Location = new Point(0, 240);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(1403, 401);
            panelTabla.TabIndex = 4;
            // 
            // frmVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 232, 241);
            ClientSize = new Size(1403, 641);
            Controls.Add(panelTabla);
            Controls.Add(panelFormulario);
            Controls.Add(panelTop);
            Name = "frmVehiculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarCheck - Vehiculos";
            WindowState = FormWindowState.Maximized;
            Load += frmVehiculos_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            ResumeLayout(false);
            // 
        }

        #endregion

        private Panel panelTop;
        private Panel panelFormulario;
        private Panel panelTabla;
        private Label label1;
        private Label lblAño;
        private Label lblPatente;
        private Label lblModelo;
        private Label lblMarca;
        private Label lblKilometraje;
    }
}