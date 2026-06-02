namespace carCheckFront
{
    partial class FrmDashboard
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
            lblBienvenida = new Label();
            lblVehiculos = new Label();
            lblServicios = new Label();
            lblPendientes = new Label();
            pictureBox1 = new PictureBox();
            panelDashboardTop = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelDashboardTop.SuspendLayout();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(24, 34, 46);
            lblBienvenida.Location = new Point(12, 9);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(153, 37);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido";
            // 
            // lblVehiculos
            // 
            lblVehiculos.AutoSize = true;
            lblVehiculos.Font = new Font("Segoe UI", 10F);
            lblVehiculos.ForeColor = Color.FromArgb(90, 90, 90);
            lblVehiculos.Location = new Point(20, 46);
            lblVehiculos.Name = "lblVehiculos";
            lblVehiculos.Size = new Size(176, 19);
            lblVehiculos.TabIndex = 1;
            lblVehiculos.Text = "🚗 Vehículos registrados: 0";
            // 
            // lblServicios
            // 
            lblServicios.AutoSize = true;
            lblServicios.Font = new Font("Segoe UI", 10F);
            lblServicios.ForeColor = Color.FromArgb(90, 90, 90);
            lblServicios.Location = new Point(20, 95);
            lblServicios.Name = "lblServicios";
            lblServicios.Size = new Size(163, 19);
            lblServicios.TabIndex = 2;
            lblServicios.Text = "🔧 Servicios realizados: 0";
            // 
            // lblPendientes
            // 
            lblPendientes.AutoSize = true;
            lblPendientes.Font = new Font("Segoe UI", 10F);
            lblPendientes.ForeColor = Color.FromArgb(90, 90, 90);
            lblPendientes.Location = new Point(20, 70);
            lblPendientes.Name = "lblPendientes";
            lblPendientes.Size = new Size(170, 19);
            lblPendientes.TabIndex = 3;
            lblPendientes.Text = "⚠ Servicios pendientes: 0";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panelDashboardTop
            // 
            panelDashboardTop.BackColor = Color.White;
            panelDashboardTop.Controls.Add(lblPendientes);
            panelDashboardTop.Controls.Add(lblServicios);
            panelDashboardTop.Controls.Add(lblBienvenida);
            panelDashboardTop.Controls.Add(lblVehiculos);
            panelDashboardTop.Dock = DockStyle.Top;
            panelDashboardTop.Location = new Point(0, 0);
            panelDashboardTop.Name = "panelDashboardTop";
            panelDashboardTop.Size = new Size(800, 180);
            panelDashboardTop.TabIndex = 5;
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDashboardTop);
            Controls.Add(pictureBox1);
            Name = "FrmDashboard";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelDashboardTop.ResumeLayout(false);
            panelDashboardTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblBienvenida;
        private Label lblVehiculos;
        private Label lblServicios;
        private Label lblPendientes;
        private PictureBox pictureBox1;
        private Panel panelDashboardTop;
    }
}