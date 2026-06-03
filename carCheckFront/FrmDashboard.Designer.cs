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
            pictureBox1 = new PictureBox();
            panelDashboardTop = new Panel();
            panelPendientes = new Panel();
            label1 = new Label();
            lblCantidadPendientes = new Label();
            panelServicios = new Panel();
            label2 = new Label();
            lblCantidadServicios = new Label();
            panelVehiculos = new Panel();
            lblTextoVehiculos = new Label();
            lblCantidadVehiculos = new Label();
            lblSubtitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelDashboardTop.SuspendLayout();
            panelPendientes.SuspendLayout();
            panelServicios.SuspendLayout();
            panelVehiculos.SuspendLayout();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(24, 34, 46);
            lblBienvenida.Location = new Point(30, 9);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(181, 45);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(240, 243, 248);
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
            panelDashboardTop.Controls.Add(panelPendientes);
            panelDashboardTop.Controls.Add(panelServicios);
            panelDashboardTop.Controls.Add(panelVehiculos);
            panelDashboardTop.Controls.Add(lblSubtitulo);
            panelDashboardTop.Controls.Add(lblBienvenida);
            panelDashboardTop.Dock = DockStyle.Top;
            panelDashboardTop.Location = new Point(0, 0);
            panelDashboardTop.Name = "panelDashboardTop";
            panelDashboardTop.Size = new Size(800, 216);
            panelDashboardTop.TabIndex = 5;
            panelDashboardTop.Paint += panelDashboardTop_Paint;
            // 
            // panelPendientes
            // 
            panelPendientes.BorderStyle = BorderStyle.FixedSingle;
            panelPendientes.Controls.Add(label1);
            panelPendientes.Controls.Add(lblCantidadPendientes);
            panelPendientes.Location = new Point(260, 97);
            panelPendientes.Name = "panelPendientes";
            panelPendientes.Size = new Size(200, 100);
            panelPendientes.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(90, 90, 90);
            label1.Location = new Point(57, 50);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 2;
            label1.Text = "Pendientes";
            // 
            // lblCantidadPendientes
            // 
            lblCantidadPendientes.AutoSize = true;
            lblCantidadPendientes.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidadPendientes.ForeColor = Color.DarkOrange;
            lblCantidadPendientes.Location = new Point(76, 10);
            lblCantidadPendientes.Name = "lblCantidadPendientes";
            lblCantidadPendientes.Size = new Size(33, 40);
            lblCantidadPendientes.TabIndex = 1;
            lblCantidadPendientes.Text = "2";
            // 
            // panelServicios
            // 
            panelServicios.BorderStyle = BorderStyle.FixedSingle;
            panelServicios.Controls.Add(label2);
            panelServicios.Controls.Add(lblCantidadServicios);
            panelServicios.Location = new Point(486, 97);
            panelServicios.Name = "panelServicios";
            panelServicios.Size = new Size(200, 100);
            panelServicios.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(90, 90, 90);
            label2.Location = new Point(58, 50);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 3;
            label2.Text = "Servicios";
            // 
            // lblCantidadServicios
            // 
            lblCantidadServicios.AutoSize = true;
            lblCantidadServicios.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidadServicios.ForeColor = Color.FromArgb(39, 174, 96);
            lblCantidadServicios.Location = new Point(76, 10);
            lblCantidadServicios.Name = "lblCantidadServicios";
            lblCantidadServicios.Size = new Size(33, 40);
            lblCantidadServicios.TabIndex = 2;
            lblCantidadServicios.Text = "2";
            // 
            // panelVehiculos
            // 
            panelVehiculos.BorderStyle = BorderStyle.FixedSingle;
            panelVehiculos.Controls.Add(lblTextoVehiculos);
            panelVehiculos.Controls.Add(lblCantidadVehiculos);
            panelVehiculos.Location = new Point(30, 97);
            panelVehiculos.Name = "panelVehiculos";
            panelVehiculos.Size = new Size(200, 100);
            panelVehiculos.TabIndex = 5;
            // 
            // lblTextoVehiculos
            // 
            lblTextoVehiculos.AutoSize = true;
            lblTextoVehiculos.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTextoVehiculos.ForeColor = Color.FromArgb(90, 90, 90);
            lblTextoVehiculos.Location = new Point(59, 50);
            lblTextoVehiculos.Name = "lblTextoVehiculos";
            lblTextoVehiculos.Size = new Size(69, 19);
            lblTextoVehiculos.TabIndex = 1;
            lblTextoVehiculos.Text = "Vehículos";
            // 
            // lblCantidadVehiculos
            // 
            lblCantidadVehiculos.AutoSize = true;
            lblCantidadVehiculos.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidadVehiculos.ForeColor = Color.FromArgb(0, 122, 204);
            lblCantidadVehiculos.Location = new Point(78, 10);
            lblCantidadVehiculos.Name = "lblCantidadVehiculos";
            lblCantidadVehiculos.Size = new Size(33, 40);
            lblCantidadVehiculos.TabIndex = 0;
            lblCantidadVehiculos.Text = "0";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(120, 130, 140);
            lblSubtitulo.Location = new Point(39, 54);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(298, 19);
            lblSubtitulo.TabIndex = 4;
            lblSubtitulo.Text = "Sistema de gestión de mantenimiento vehicular";
            lblSubtitulo.Click += lblSubtitulo_Click;
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
            panelPendientes.ResumeLayout(false);
            panelPendientes.PerformLayout();
            panelServicios.ResumeLayout(false);
            panelServicios.PerformLayout();
            panelVehiculos.ResumeLayout(false);
            panelVehiculos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblBienvenida;
        private PictureBox pictureBox1;
        private Panel panelDashboardTop;
        private Label lblSubtitulo;
        private Panel panelPendientes;
        private Panel panelServicios;
        private Panel panelVehiculos;
        private Label lblCantidadVehiculos;
        private Label lblTextoVehiculos;
        private Label label1;
        private Label lblCantidadPendientes;
        private Label label2;
        private Label lblCantidadServicios;
    }
}