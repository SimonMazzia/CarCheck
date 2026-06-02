namespace carCheckFront
{
    partial class FrmPrincipal
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
            panelMenu = new Panel();
            panelSeparador = new Panel();
            btnCerrar = new Button();
            btnConfiguracion = new Button();
            btnHistorial = new Button();
            btnServicios = new Button();
            btnVehiculos = new Button();
            btnInicio = new Button();
            lblSubtitulo = new Label();
            lblLogo = new Label();
            panelTop = new Panel();
            panelContenido = new Panel();
            panelContenedor = new Panel();
            panelMenu.SuspendLayout();
            panelContenido.SuspendLayout();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Dock = DockStyle.Top;
            lblBienvenida.Location = new Point(0, 0);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(0, 15);
            lblBienvenida.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(24, 34, 46);
            panelMenu.Controls.Add(panelSeparador);
            panelMenu.Controls.Add(btnCerrar);
            panelMenu.Controls.Add(btnConfiguracion);
            panelMenu.Controls.Add(btnHistorial);
            panelMenu.Controls.Add(btnServicios);
            panelMenu.Controls.Add(btnVehiculos);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Controls.Add(lblSubtitulo);
            panelMenu.Controls.Add(lblLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 15);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 629);
            panelMenu.TabIndex = 1;
            // 
            // panelSeparador
            // 
            panelSeparador.BackColor = Color.Gray;
            panelSeparador.Dock = DockStyle.Bottom;
            panelSeparador.Location = new Point(0, 583);
            panelSeparador.Name = "panelSeparador";
            panelSeparador.Size = new Size(220, 1);
            panelSeparador.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(52, 73, 94);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Dock = DockStyle.Bottom;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(0, 584);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(220, 45);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar Sesion";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.BackColor = Color.FromArgb(52, 73, 94);
            btnConfiguracion.Cursor = Cursors.Hand;
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Segoe UI", 10F);
            btnConfiguracion.ForeColor = Color.White;
            btnConfiguracion.Location = new Point(20, 305);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(180, 45);
            btnConfiguracion.TabIndex = 3;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(52, 73, 94);
            btnHistorial.Cursor = Cursors.Hand;
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Font = new Font("Segoe UI", 10F);
            btnHistorial.ForeColor = Color.White;
            btnHistorial.Location = new Point(20, 254);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(180, 45);
            btnHistorial.TabIndex = 2;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = true;
            // 
            // btnServicios
            // 
            btnServicios.BackColor = Color.FromArgb(52, 73, 94);
            btnServicios.Cursor = Cursors.Hand;
            btnServicios.FlatAppearance.BorderSize = 0;
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Font = new Font("Segoe UI", 10F);
            btnServicios.ForeColor = Color.White;
            btnServicios.Location = new Point(20, 203);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(180, 45);
            btnServicios.TabIndex = 2;
            btnServicios.Text = "Servicios";
            btnServicios.UseVisualStyleBackColor = true;
            // 
            // btnVehiculos
            // 
            btnVehiculos.BackColor = Color.FromArgb(52, 73, 94);
            btnVehiculos.Cursor = Cursors.Hand;
            btnVehiculos.FlatAppearance.BorderSize = 0;
            btnVehiculos.FlatStyle = FlatStyle.Flat;
            btnVehiculos.Font = new Font("Segoe UI", 10F);
            btnVehiculos.ForeColor = Color.White;
            btnVehiculos.Location = new Point(20, 152);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(180, 45);
            btnVehiculos.TabIndex = 2;
            btnVehiculos.Text = "Vehículos";
            btnVehiculos.UseVisualStyleBackColor = true;
            btnVehiculos.Click += btnVehiculos_Click_1;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(52, 73, 94);
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 10F);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(20, 101);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(180, 45);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSubtitulo.ForeColor = Color.FromArgb(181, 195, 211);
            lblSubtitulo.Location = new Point(30, 68);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(98, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gestión vehicular";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(20, 23);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(132, 37);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "CarCheck";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(0, 122, 204);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(220, 15);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1038, 60);
            panelTop.TabIndex = 2;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(225, 232, 241);
            panelContenido.Controls.Add(panelContenedor);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(220, 75);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1038, 569);
            panelContenido.TabIndex = 3;
            panelContenido.Paint += panelContenido_Paint;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1038, 569);
            panelContenedor.TabIndex = 0;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 644);
            Controls.Add(panelContenido);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            Controls.Add(lblBienvenida);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load_1;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelContenido.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Panel panelMenu;
        private Panel panelTop;
        private Panel panelContenido;
        private Label lblLogo;
        private Label lblSubtitulo;
        private Button btnInicio;
        private Button btnVehiculos;
        private Button btnServicios;
        private Button btnHistorial;
        private Button btnConfiguracion;
        private Button btnCerrar;
        private Panel panelSeparador;
        private Panel panelContenedor;
    }
}