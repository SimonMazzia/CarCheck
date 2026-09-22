namespace carCheckFront
{
    partial class FrmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        // =========================================================
        // PANELES
        // =========================================================

        private Panel panelDashboardTop;
        private Panel panelVehiculos;
        private Panel panelServicios;
        private Panel panelRecientes;
        private Panel panelAcciones;
        private Panel panelListaVehiculos;
        private Panel panelListaServicios;

        // =========================================================
        // LABELS
        // =========================================================

        private Label lblLogo;
        private Label lblSubtitulo;
        private Label lblBienvenida;

        private Label lblTituloVehiculos;
        private Label lblCantidadVehiculos;
        private Label lblDescripcionVehiculos;

        private Label lblTituloServicios;
        private Label lblCantidadServicios;
        private Label lblDescripcionServicios;

        private Label lblTituloRecientes;
        private Label lblCantidadPendientes;
        private Label lblDescripcionRecientes;

        private Label lblTituloAcciones;
        private Label lblTituloListaVehiculos;
        private Label lblTituloListaServicios;

        // =========================================================
        // BOTONES
        // =========================================================

        private Button btnActualizar;
        private Button btnVehiculos;
        private Button btnServicios;

        // =========================================================
        // DATAGRIDVIEW
        // =========================================================

        private DataGridView dgvVehiculos;
        private DataGridView dgvServicios;

        // =========================================================
        // DISPOSE
        // =========================================================

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // =========================================================
        // INITIALIZE COMPONENT
        // =========================================================

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // =====================================================
            // CREAR CONTROLES
            // =====================================================

            this.panelDashboardTop = new Panel();

            this.lblLogo = new Label();
            this.lblSubtitulo = new Label();
            this.lblBienvenida = new Label();

            this.btnActualizar = new Button();

            this.panelVehiculos = new Panel();
            this.panelServicios = new Panel();
            this.panelRecientes = new Panel();

            this.lblTituloVehiculos = new Label();
            this.lblCantidadVehiculos = new Label();
            this.lblDescripcionVehiculos = new Label();

            this.lblTituloServicios = new Label();
            this.lblCantidadServicios = new Label();
            this.lblDescripcionServicios = new Label();

            this.lblTituloRecientes = new Label();
            this.lblCantidadPendientes = new Label();
            this.lblDescripcionRecientes = new Label();

            this.panelAcciones = new Panel();
            this.lblTituloAcciones = new Label();

            this.btnVehiculos = new Button();
            this.btnServicios = new Button();

            this.panelListaVehiculos = new Panel();
            this.panelListaServicios = new Panel();

            this.lblTituloListaVehiculos = new Label();
            this.lblTituloListaServicios = new Label();

            this.dgvVehiculos = new DataGridView();
            this.dgvServicios = new DataGridView();

            // =====================================================
            // SUSPEND LAYOUT
            // =====================================================

            this.panelDashboardTop.SuspendLayout();

            this.panelVehiculos.SuspendLayout();
            this.panelServicios.SuspendLayout();
            this.panelRecientes.SuspendLayout();

            this.panelAcciones.SuspendLayout();

            this.panelListaVehiculos.SuspendLayout();
            this.panelListaServicios.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos))
                .BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios))
                .BeginInit();

            this.SuspendLayout();

            // =====================================================
            // COLORES
            // =====================================================

            Color azul =
                Color.FromArgb(0, 122, 204);

            Color azulOscuro =
                Color.FromArgb(0, 102, 170);

            Color fondo =
                Color.FromArgb(239, 244, 250);

            Color gris =
                Color.FromArgb(52, 73, 94);

            Color grisTexto =
                Color.FromArgb(90, 100, 110);

            Color borde =
                Color.FromArgb(225, 230, 235);

            Color blanco =
                Color.White;

            // =====================================================
            // PANEL SUPERIOR
            // =====================================================

            this.panelDashboardTop.BackColor = azul;

            this.panelDashboardTop.Controls.Add(
                this.btnActualizar);

            this.panelDashboardTop.Controls.Add(
                this.lblBienvenida);

            this.panelDashboardTop.Controls.Add(
                this.lblSubtitulo);

            this.panelDashboardTop.Controls.Add(
                this.lblLogo);

            this.panelDashboardTop.Dock =
                DockStyle.Top;

            this.panelDashboardTop.Location =
                new Point(0, 0);

            this.panelDashboardTop.Name =
                "panelDashboardTop";

            this.panelDashboardTop.Size =
                new Size(1180, 110);

            this.panelDashboardTop.TabIndex = 0;

            this.panelDashboardTop.Paint +=
                new PaintEventHandler(
                    this.panelDashboardTop_Paint);

            // =====================================================
            // LOGO
            // =====================================================

            this.lblLogo.AutoSize = true;

            this.lblLogo.Font =
                new Font(
                    "Segoe UI",
                    22F,
                    FontStyle.Bold);

            this.lblLogo.ForeColor =
                blanco;

            this.lblLogo.Location =
                new Point(30, 18);

            this.lblLogo.Name =
                "lblLogo";

            this.lblLogo.Size =
                new Size(125, 41);

            this.lblLogo.TabIndex = 0;

            this.lblLogo.Text =
                "CarCheck";

            // =====================================================
            // SUBTITULO
            // =====================================================

            this.lblSubtitulo.AutoSize = true;

            this.lblSubtitulo.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Regular);

            this.lblSubtitulo.ForeColor =
                Color.FromArgb(225, 240, 250);

            this.lblSubtitulo.Location =
                new Point(33, 62);

            this.lblSubtitulo.Name =
                "lblSubtitulo";

            this.lblSubtitulo.Size =
                new Size(260, 17);

            this.lblSubtitulo.TabIndex = 1;

            this.lblSubtitulo.Text =
                "Gestión y mantenimiento de vehículos";

            this.lblSubtitulo.Click +=
                new EventHandler(
                    this.lblSubtitulo_Click);

            // =====================================================
            // BIENVENIDA
            // =====================================================

            this.lblBienvenida.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            this.lblBienvenida.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            this.lblBienvenida.ForeColor =
                blanco;

            this.lblBienvenida.Location =
                new Point(690, 27);

            this.lblBienvenida.Name =
                "lblBienvenida";

            this.lblBienvenida.Size =
                new Size(270, 23);

            this.lblBienvenida.TabIndex = 2;

            this.lblBienvenida.Text =
                "Hola de nuevo";

            this.lblBienvenida.TextAlign =
                ContentAlignment.MiddleRight;

            // =====================================================
            // BOTÓN ACTUALIZAR
            // =====================================================

            this.btnActualizar.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            this.btnActualizar.BackColor =
                blanco;

            this.btnActualizar.FlatAppearance.BorderSize =
                0;

            this.btnActualizar.FlatStyle =
                FlatStyle.Flat;

            this.btnActualizar.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.btnActualizar.ForeColor =
                azul;

            this.btnActualizar.Location =
                new Point(985, 30);

            this.btnActualizar.Name =
                "btnActualizar";

            this.btnActualizar.Size =
                new Size(165, 38);

            this.btnActualizar.TabIndex = 3;

            this.btnActualizar.Text =
                "Actualizar información";

            this.btnActualizar.UseVisualStyleBackColor =
                false;

            this.btnActualizar.Click +=
                new EventHandler(
                    this.btnActualizar_Click);

            // =====================================================
            // TARJETA VEHÍCULOS
            // =====================================================

            this.panelVehiculos.BackColor =
                blanco;

            this.panelVehiculos.BorderStyle =
                BorderStyle.FixedSingle;

            this.panelVehiculos.Controls.Add(
                this.lblDescripcionVehiculos);

            this.panelVehiculos.Controls.Add(
                this.lblCantidadVehiculos);

            this.panelVehiculos.Controls.Add(
                this.lblTituloVehiculos);

            this.panelVehiculos.Location =
                new Point(30, 135);

            this.panelVehiculos.Name =
                "panelVehiculos";

            this.panelVehiculos.Size =
                new Size(350, 150);

            this.panelVehiculos.TabIndex = 1;

            // =====================================================
            // TITULO VEHÍCULOS
            // =====================================================

            this.lblTituloVehiculos.AutoSize = true;

            this.lblTituloVehiculos.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            this.lblTituloVehiculos.ForeColor =
                gris;

            this.lblTituloVehiculos.Location =
                new Point(22, 20);

            this.lblTituloVehiculos.Name =
                "lblTituloVehiculos";

            this.lblTituloVehiculos.Size =
                new Size(78, 19);

            this.lblTituloVehiculos.TabIndex = 0;

            this.lblTituloVehiculos.Text =
                "VEHÍCULOS";

            // =====================================================
            // CANTIDAD VEHÍCULOS
            // =====================================================

            this.lblCantidadVehiculos.AutoSize = true;

            this.lblCantidadVehiculos.Font =
                new Font(
                    "Segoe UI",
                    28F,
                    FontStyle.Bold);

            this.lblCantidadVehiculos.ForeColor =
                azul;

            this.lblCantidadVehiculos.Location =
                new Point(20, 45);

            this.lblCantidadVehiculos.Name =
                "lblCantidadVehiculos";

            this.lblCantidadVehiculos.Size =
                new Size(45, 51);

            this.lblCantidadVehiculos.TabIndex = 1;

            this.lblCantidadVehiculos.Text =
                "0";

            // =====================================================
            // DESCRIPCIÓN VEHÍCULOS
            // =====================================================

            this.lblDescripcionVehiculos.AutoSize = true;

            this.lblDescripcionVehiculos.Font =
                new Font(
                    "Segoe UI",
                    9F);

            this.lblDescripcionVehiculos.ForeColor =
                grisTexto;

            this.lblDescripcionVehiculos.Location =
                new Point(24, 105);

            this.lblDescripcionVehiculos.Name =
                "lblDescripcionVehiculos";

            this.lblDescripcionVehiculos.Size =
                new Size(145, 15);

            this.lblDescripcionVehiculos.TabIndex = 2;

            this.lblDescripcionVehiculos.Text =
                "Vehículos registrados";

            // =====================================================
            // TARJETA SERVICIOS
            // =====================================================

            this.panelServicios.BackColor =
                blanco;

            this.panelServicios.BorderStyle =
                BorderStyle.FixedSingle;

            this.panelServicios.Controls.Add(
                this.lblDescripcionServicios);

            this.panelServicios.Controls.Add(
                this.lblCantidadServicios);

            this.panelServicios.Controls.Add(
                this.lblTituloServicios);

            this.panelServicios.Location =
                new Point(415, 135);

            this.panelServicios.Name =
                "panelServicios";

            this.panelServicios.Size =
                new Size(350, 150);

            this.panelServicios.TabIndex = 2;

            // =====================================================
            // TITULO SERVICIOS
            // =====================================================

            this.lblTituloServicios.AutoSize = true;

            this.lblTituloServicios.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            this.lblTituloServicios.ForeColor =
                gris;

            this.lblTituloServicios.Location =
                new Point(22, 20);

            this.lblTituloServicios.Name =
                "lblTituloServicios";

            this.lblTituloServicios.Size =
                new Size(84, 19);

            this.lblTituloServicios.TabIndex = 0;

            this.lblTituloServicios.Text =
                "SERVICIOS";

            // =====================================================
            // CANTIDAD SERVICIOS
            // =====================================================

            this.lblCantidadServicios.AutoSize = true;

            this.lblCantidadServicios.Font =
                new Font(
                    "Segoe UI",
                    28F,
                    FontStyle.Bold);

            this.lblCantidadServicios.ForeColor =
                azul;

            this.lblCantidadServicios.Location =
                new Point(20, 45);

            this.lblCantidadServicios.Name =
                "lblCantidadServicios";

            this.lblCantidadServicios.Size =
                new Size(45, 51);

            this.lblCantidadServicios.TabIndex = 1;

            this.lblCantidadServicios.Text =
                "0";

            // =====================================================
            // DESCRIPCIÓN SERVICIOS
            // =====================================================

            this.lblDescripcionServicios.AutoSize = true;

            this.lblDescripcionServicios.Font =
                new Font(
                    "Segoe UI",
                    9F);

            this.lblDescripcionServicios.ForeColor =
                grisTexto;

            this.lblDescripcionServicios.Location =
                new Point(24, 105);

            this.lblDescripcionServicios.Name =
                "lblDescripcionServicios";

            this.lblDescripcionServicios.Size =
                new Size(145, 15);

            this.lblDescripcionServicios.TabIndex = 2;

            this.lblDescripcionServicios.Text =
                "Servicios registrados";

            // =====================================================
            // TARJETA ACTIVIDAD
            // =====================================================

            this.panelRecientes.BackColor =
                blanco;

            this.panelRecientes.BorderStyle =
                BorderStyle.FixedSingle;

            this.panelRecientes.Controls.Add(
                this.lblDescripcionRecientes);

            this.panelRecientes.Controls.Add(
                this.lblCantidadPendientes);

            this.panelRecientes.Controls.Add(
                this.lblTituloRecientes);

            this.panelRecientes.Location =
                new Point(800, 135);

            this.panelRecientes.Name =
                "panelRecientes";

            this.panelRecientes.Size =
                new Size(350, 150);

            this.panelRecientes.TabIndex = 3;

            // =====================================================
            // TITULO ACTIVIDAD
            // =====================================================

            this.lblTituloRecientes.AutoSize = true;

            this.lblTituloRecientes.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            this.lblTituloRecientes.ForeColor =
                gris;

            this.lblTituloRecientes.Location =
                new Point(22, 20);

            this.lblTituloRecientes.Name =
                "lblTituloRecientes";

            this.lblTituloRecientes.Size =
                new Size(151, 19);

            this.lblTituloRecientes.TabIndex = 0;

            this.lblTituloRecientes.Text =
                "ACTIVIDAD RECIENTE";

            // =====================================================
            // CANTIDAD ACTIVIDAD
            // =====================================================

            this.lblCantidadPendientes.AutoSize = true;

            this.lblCantidadPendientes.Font =
                new Font(
                    "Segoe UI",
                    28F,
                    FontStyle.Bold);

            this.lblCantidadPendientes.ForeColor =
                azul;

            this.lblCantidadPendientes.Location =
                new Point(20, 45);

            this.lblCantidadPendientes.Name =
                "lblCantidadPendientes";

            this.lblCantidadPendientes.Size =
                new Size(45, 51);

            this.lblCantidadPendientes.TabIndex = 1;

            this.lblCantidadPendientes.Text =
                "0";

            // =====================================================
            // DESCRIPCIÓN ACTIVIDAD
            // =====================================================

            this.lblDescripcionRecientes.AutoSize = true;

            this.lblDescripcionRecientes.Font =
                new Font(
                    "Segoe UI",
                    9F);

            this.lblDescripcionRecientes.ForeColor =
                grisTexto;

            this.lblDescripcionRecientes.Location =
                new Point(24, 105);

            this.lblDescripcionRecientes.Name =
                "lblDescripcionRecientes";

            this.lblDescripcionRecientes.Size =
                new Size(210, 15);

            this.lblDescripcionRecientes.TabIndex = 2;

            this.lblDescripcionRecientes.Text =
                "Servicios de los últimos 30 días";

            // =====================================================
            // PANEL ACCIONES
            // =====================================================

            this.panelAcciones.BackColor =
                fondo;

            this.panelAcciones.Controls.Add(
                this.btnServicios);

            this.panelAcciones.Controls.Add(
                this.btnVehiculos);

            this.panelAcciones.Controls.Add(
                this.lblTituloAcciones);

            this.panelAcciones.Location =
                new Point(30, 305);

            this.panelAcciones.Name =
                "panelAcciones";

            this.panelAcciones.Size =
                new Size(1120, 70);

            this.panelAcciones.TabIndex = 4;

            // =====================================================
            // TITULO ACCIONES
            // =====================================================

            this.lblTituloAcciones.AutoSize = true;

            this.lblTituloAcciones.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            this.lblTituloAcciones.ForeColor =
                gris;

            this.lblTituloAcciones.Location =
                new Point(0, 25);

            this.lblTituloAcciones.Name =
                "lblTituloAcciones";

            this.lblTituloAcciones.Size =
                new Size(105, 19);

            this.lblTituloAcciones.TabIndex = 0;

            this.lblTituloAcciones.Text =
                "Acciones rápidas";

            // =====================================================
            // BOTÓN VEHÍCULOS
            // =====================================================

            this.btnVehiculos.BackColor =
                azul;

            this.btnVehiculos.FlatAppearance.BorderSize =
                0;

            this.btnVehiculos.FlatStyle =
                FlatStyle.Flat;

            this.btnVehiculos.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.btnVehiculos.ForeColor =
                blanco;

            this.btnVehiculos.Location =
                new Point(700, 15);

            this.btnVehiculos.Name =
                "btnVehiculos";

            this.btnVehiculos.Size =
                new Size(190, 40);

            this.btnVehiculos.TabIndex = 1;

            this.btnVehiculos.Text =
                "Gestionar vehículos";

            this.btnVehiculos.UseVisualStyleBackColor =
                false;

            this.btnVehiculos.Click +=
                new EventHandler(
                    this.btnVehiculos_Click);

            // =====================================================
            // BOTÓN SERVICIOS
            // =====================================================

            this.btnServicios.BackColor =
                gris;

            this.btnServicios.FlatAppearance.BorderSize =
                0;

            this.btnServicios.FlatStyle =
                FlatStyle.Flat;

            this.btnServicios.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.btnServicios.ForeColor =
                blanco;

            this.btnServicios.Location =
                new Point(910, 15);

            this.btnServicios.Name =
                "btnServicios";

            this.btnServicios.Size =
                new Size(190, 40);

            this.btnServicios.TabIndex = 2;

            this.btnServicios.Text =
                "Gestionar servicios";

            this.btnServicios.UseVisualStyleBackColor =
                false;

            this.btnServicios.Click +=
                new EventHandler(
                    this.btnServicios_Click);

            // =====================================================
            // PANEL LISTA VEHÍCULOS
            // =====================================================

            this.panelListaVehiculos.BackColor =
                blanco;

            this.panelListaVehiculos.BorderStyle =
                BorderStyle.FixedSingle;

            this.panelListaVehiculos.Controls.Add(
                this.dgvVehiculos);

            this.panelListaVehiculos.Controls.Add(
                this.lblTituloListaVehiculos);

            this.panelListaVehiculos.Location =
                new Point(30, 395);

            this.panelListaVehiculos.Name =
                "panelListaVehiculos";

            this.panelListaVehiculos.Size =
                new Size(700, 330);

            this.panelListaVehiculos.TabIndex = 5;

            // =====================================================
            // TITULO LISTA VEHÍCULOS
            // =====================================================

            this.lblTituloListaVehiculos.AutoSize = true;

            this.lblTituloListaVehiculos.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            this.lblTituloListaVehiculos.ForeColor =
                gris;

            this.lblTituloListaVehiculos.Location =
                new Point(18, 15);

            this.lblTituloListaVehiculos.Name =
                "lblTituloListaVehiculos";

            this.lblTituloListaVehiculos.Size =
                new Size(150, 20);

            this.lblTituloListaVehiculos.TabIndex = 0;

            this.lblTituloListaVehiculos.Text =
                "Mis vehículos";

            // =====================================================
            // DGV VEHÍCULOS
            // =====================================================

            this.dgvVehiculos.AllowUserToAddRows =
                false;

            this.dgvVehiculos.AllowUserToDeleteRows =
                false;

            this.dgvVehiculos.AllowUserToResizeRows =
                false;

            this.dgvVehiculos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvVehiculos.BackgroundColor =
                blanco;

            this.dgvVehiculos.BorderStyle =
                BorderStyle.None;

            this.dgvVehiculos.ColumnHeadersHeight =
                38;

            this.dgvVehiculos.EnableHeadersVisualStyles =
                false;

            this.dgvVehiculos.Location =
                new Point(15, 50);

            this.dgvVehiculos.Name =
                "dgvVehiculos";

            this.dgvVehiculos.ReadOnly =
                true;

            this.dgvVehiculos.RowHeadersVisible =
                false;

            this.dgvVehiculos.RowTemplate.Height =
                34;

            this.dgvVehiculos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            this.dgvVehiculos.Size =
                new Size(668, 260);

            this.dgvVehiculos.TabIndex = 1;

            // =====================================================
            // PANEL LISTA SERVICIOS
            // =====================================================

            this.panelListaServicios.BackColor =
                blanco;

            this.panelListaServicios.BorderStyle =
                BorderStyle.FixedSingle;

            this.panelListaServicios.Controls.Add(
                this.dgvServicios);

            this.panelListaServicios.Controls.Add(
                this.lblTituloListaServicios);

            this.panelListaServicios.Location =
                new Point(750, 395);

            this.panelListaServicios.Name =
                "panelListaServicios";

            this.panelListaServicios.Size =
                new Size(400, 330);

            this.panelListaServicios.TabIndex = 6;

            // =====================================================
            // TITULO LISTA SERVICIOS
            // =====================================================

            this.lblTituloListaServicios.AutoSize = true;

            this.lblTituloListaServicios.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            this.lblTituloListaServicios.ForeColor =
                gris;

            this.lblTituloListaServicios.Location =
                new Point(18, 15);

            this.lblTituloListaServicios.Name =
                "lblTituloListaServicios";

            this.lblTituloListaServicios.Size =
                new Size(173, 20);

            this.lblTituloListaServicios.TabIndex = 0;

            this.lblTituloListaServicios.Text =
                "Servicios recientes";

            // =====================================================
            // DGV SERVICIOS
            // =====================================================

            this.dgvServicios.AllowUserToAddRows =
                false;

            this.dgvServicios.AllowUserToDeleteRows =
                false;

            this.dgvServicios.AllowUserToResizeRows =
                false;

            this.dgvServicios.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvServicios.BackgroundColor =
                blanco;

            this.dgvServicios.BorderStyle =
                BorderStyle.None;

            this.dgvServicios.ColumnHeadersHeight =
                38;

            this.dgvServicios.EnableHeadersVisualStyles =
                false;

            this.dgvServicios.Location =
                new Point(15, 50);

            this.dgvServicios.Name =
                "dgvServicios";

            this.dgvServicios.ReadOnly =
                true;

            this.dgvServicios.RowHeadersVisible =
                false;

            this.dgvServicios.RowTemplate.Height =
                34;

            this.dgvServicios.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            this.dgvServicios.Size =
                new Size(368, 260);

            this.dgvServicios.TabIndex = 1;

            // =====================================================
            // FORM DASHBOARD
            // =====================================================

            this.AutoScaleDimensions =
                new SizeF(7F, 15F);

            this.AutoScaleMode =
                AutoScaleMode.Font;

            this.BackColor =
                fondo;

            this.ClientSize =
                new Size(1180, 760);

            this.Controls.Add(
                this.panelListaServicios);

            this.Controls.Add(
                this.panelListaVehiculos);

            this.Controls.Add(
                this.panelAcciones);

            this.Controls.Add(
                this.panelRecientes);

            this.Controls.Add(
                this.panelServicios);

            this.Controls.Add(
                this.panelVehiculos);

            this.Controls.Add(
                this.panelDashboardTop);

            this.Font =
                new Font(
                    "Segoe UI",
                    9F);

            this.FormBorderStyle =
                FormBorderStyle.Sizable;

            this.MinimumSize =
                new Size(1000, 700);

            this.Name =
                "FrmDashboard";

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.Text =
                "CarCheck - Dashboard";

            // =====================================================
            // RESUME LAYOUT
            // =====================================================

            this.panelDashboardTop.ResumeLayout(false);
            this.panelDashboardTop.PerformLayout();

            this.panelVehiculos.ResumeLayout(false);
            this.panelVehiculos.PerformLayout();

            this.panelServicios.ResumeLayout(false);
            this.panelServicios.PerformLayout();

            this.panelRecientes.ResumeLayout(false);
            this.panelRecientes.PerformLayout();

            this.panelAcciones.ResumeLayout(false);
            this.panelAcciones.PerformLayout();

            this.panelListaVehiculos.ResumeLayout(false);
            this.panelListaVehiculos.PerformLayout();

            this.panelListaServicios.ResumeLayout(false);
            this.panelListaServicios.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos))
                .EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios))
                .EndInit();

            this.ResumeLayout(false);
        }
    }
}