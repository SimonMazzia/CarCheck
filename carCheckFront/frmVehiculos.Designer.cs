namespace carCheckFront
{
    partial class frmVehiculos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelTop = new Panel();
            lblSubtitulo = new Label();
            label1 = new Label();

            panelFormulario = new Panel();

            lblTituloFormulario = new Label();
            lblAyuda = new Label();

            lblMarca = new Label();
            lblModelo = new Label();
            lblPatente = new Label();
            lblAño = new Label();
            lblKilometraje = new Label();

            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtPatente = new TextBox();

            numericUpDownAnio = new NumericUpDown();
            numericUpDownKm = new NumericUpDown();

            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();

            panelTabla = new Panel();

            lblTituloTabla = new Label();
            dgvVehiculos = new DataGridView();

            panelTop.SuspendLayout();
            panelFormulario.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                numericUpDownAnio).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                numericUpDownKm).BeginInit();

            panelTabla.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                dgvVehiculos).BeginInit();

            SuspendLayout();

            // =====================================================
            // PANEL TOP
            // =====================================================

            panelTop.BackColor =
                Color.FromArgb(0, 122, 204);

            panelTop.Controls.Add(
                lblSubtitulo);

            panelTop.Controls.Add(
                label1);

            panelTop.Dock =
                DockStyle.Top;

            panelTop.Location =
                new Point(0, 0);

            panelTop.Name =
                "panelTop";

            panelTop.Size =
                new Size(1200, 105);

            panelTop.TabIndex = 0;

            // =====================================================
            // TITULO
            // =====================================================

            label1.AutoSize = true;

            label1.Font =
                new Font(
                    "Segoe UI",
                    21F,
                    FontStyle.Bold,
                    GraphicsUnit.Point,
                    0);

            label1.ForeColor =
                Color.White;

            label1.Location =
                new Point(30, 20);

            label1.Name =
                "label1";

            label1.Size =
                new Size(310, 38);

            label1.TabIndex = 0;

            label1.Text =
                "Gestión de vehículos";

            // =====================================================
            // SUBTITULO
            // =====================================================

            lblSubtitulo.AutoSize = true;

            lblSubtitulo.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Regular,
                    GraphicsUnit.Point,
                    0);

            lblSubtitulo.ForeColor =
                Color.FromArgb(225, 240, 250);

            lblSubtitulo.Location =
                new Point(33, 64);

            lblSubtitulo.Name =
                "lblSubtitulo";

            lblSubtitulo.Size =
                new Size(390, 19);

            lblSubtitulo.TabIndex = 1;

            lblSubtitulo.Text =
                "Administrá los vehículos asociados a tu cuenta";

            // =====================================================
            // PANEL FORMULARIO
            // =====================================================

            panelFormulario.BackColor =
                Color.White;

            panelFormulario.Controls.Add(
                lblAyuda);

            panelFormulario.Controls.Add(
                lblTituloFormulario);

            panelFormulario.Controls.Add(
                btnLimpiar);

            panelFormulario.Controls.Add(
                btnEliminar);

            panelFormulario.Controls.Add(
                btnModificar);

            panelFormulario.Controls.Add(
                btnAgregar);

            panelFormulario.Controls.Add(
                numericUpDownKm);

            panelFormulario.Controls.Add(
                numericUpDownAnio);

            panelFormulario.Controls.Add(
                txtPatente);

            panelFormulario.Controls.Add(
                txtModelo);

            panelFormulario.Controls.Add(
                txtMarca);

            panelFormulario.Controls.Add(
                lblKilometraje);

            panelFormulario.Controls.Add(
                lblAño);

            panelFormulario.Controls.Add(
                lblPatente);

            panelFormulario.Controls.Add(
                lblModelo);

            panelFormulario.Controls.Add(
                lblMarca);

            panelFormulario.Dock =
                DockStyle.Top;

            panelFormulario.Location =
                new Point(0, 105);

            panelFormulario.Name =
                "panelFormulario";

            panelFormulario.Size =
                new Size(1200, 190);

            panelFormulario.TabIndex = 1;

            // =====================================================
            // TITULO FORMULARIO
            // =====================================================

            lblTituloFormulario.AutoSize = true;

            lblTituloFormulario.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            lblTituloFormulario.ForeColor =
                Color.FromArgb(52, 73, 94);

            lblTituloFormulario.Location =
                new Point(30, 15);

            lblTituloFormulario.Name =
                "lblTituloFormulario";

            lblTituloFormulario.Size =
                new Size(185, 21);

            lblTituloFormulario.TabIndex = 0;

            lblTituloFormulario.Text =
                "Datos del vehículo";

            // =====================================================
            // AYUDA
            // =====================================================

            lblAyuda.AutoSize = true;

            lblAyuda.Font =
                new Font(
                    "Segoe UI",
                    8.5F);

            lblAyuda.ForeColor =
                Color.FromArgb(120, 120, 120);

            lblAyuda.Location =
                new Point(30, 164);

            lblAyuda.Name =
                "lblAyuda";

            lblAyuda.Size =
                new Size(310, 15);

            lblAyuda.TabIndex = 1;

            lblAyuda.Text =
                "Seleccioná un vehículo de la tabla para modificarlo.";

            // =====================================================
            // MARCA
            // =====================================================

            lblMarca.AutoSize = true;

            lblMarca.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            lblMarca.ForeColor =
                Color.FromArgb(52, 73, 94);

            lblMarca.Location =
                new Point(30, 55);

            lblMarca.Name =
                "lblMarca";

            lblMarca.Size =
                new Size(46, 17);

            lblMarca.TabIndex = 2;

            lblMarca.Text =
                "Marca";

            // =====================================================
            // TXT MARCA
            // =====================================================

            txtMarca.Font =
                new Font(
                    "Segoe UI",
                    10F);

            txtMarca.Location =
                new Point(95, 52);

            txtMarca.Name =
                "txtMarca";

            txtMarca.Size =
                new Size(210, 25);

            txtMarca.TabIndex = 3;

            txtMarca.CharacterCasing =
                CharacterCasing.Normal;

            txtMarca.MaxLength = 50;

            txtMarca.TextChanged +=
                txtMarca_TextChanged;

            // =====================================================
            // MODELO
            // =====================================================

            lblModelo.AutoSize = true;

            lblModelo.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            lblModelo.ForeColor =
                Color.FromArgb(52, 73, 94);

            lblModelo.Location =
                new Point(330, 55);

            lblModelo.Name =
                "lblModelo";

            lblModelo.Size =
                new Size(57, 17);

            lblModelo.TabIndex = 4;

            lblModelo.Text =
                "Modelo";

            // =====================================================
            // TXT MODELO
            // =====================================================

            txtModelo.Font =
                new Font(
                    "Segoe UI",
                    10F);

            txtModelo.Location =
                new Point(400, 52);

            txtModelo.Name =
                "txtModelo";

            txtModelo.Size =
                new Size(210, 25);

            txtModelo.TabIndex = 5;

            txtModelo.MaxLength = 50;

            // =====================================================
            // PATENTE
            // =====================================================

            lblPatente.AutoSize = true;

            lblPatente.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            lblPatente.ForeColor =
                Color.FromArgb(52, 73, 94);

            lblPatente.Location =
                new Point(635, 55);

            lblPatente.Name =
                "lblPatente";

            lblPatente.Size =
                new Size(56, 17);

            lblPatente.TabIndex = 6;

            lblPatente.Text =
                "Patente";

            // =====================================================
            // TXT PATENTE
            // =====================================================

            txtPatente.Font =
                new Font(
                    "Segoe UI",
                    10F);

            txtPatente.Location =
                new Point(705, 52);

            txtPatente.Name =
                "txtPatente";

            txtPatente.Size =
                new Size(150, 25);

            txtPatente.TabIndex = 7;

            txtPatente.MaxLength = 20;

            txtPatente.CharacterCasing =
                CharacterCasing.Upper;

            // =====================================================
            // AÑO
            // =====================================================

            lblAño.AutoSize = true;

            lblAño.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            lblAño.ForeColor =
                Color.FromArgb(52, 73, 94);

            lblAño.Location =
                new Point(30, 105);

            lblAño.Name =
                "lblAño";

            lblAño.Size =
                new Size(31, 17);

            lblAño.TabIndex = 8;

            lblAño.Text =
                "Año";

            // =====================================================
            // NUMERIC AÑO
            // =====================================================

            numericUpDownAnio.Font =
                new Font(
                    "Segoe UI",
                    10F);

            numericUpDownAnio.Location =
                new Point(95, 102);

            numericUpDownAnio.Maximum =
                new decimal(
                    new int[]
                    {
                        2100,
                        0,
                        0,
                        0
                    });

            numericUpDownAnio.Minimum =
                new decimal(
                    new int[]
                    {
                        1950,
                        0,
                        0,
                        0
                    });

            numericUpDownAnio.Name =
                "numericUpDownAnio";

            numericUpDownAnio.Size =
                new Size(100, 25);

            numericUpDownAnio.TabIndex = 9;

            numericUpDownAnio.Value =
                new decimal(
                    new int[]
                    {
                        2026,
                        0,
                        0,
                        0
                    });

            // =====================================================
            // KILOMETRAJE
            // =====================================================

            lblKilometraje.AutoSize = true;

            lblKilometraje.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            lblKilometraje.ForeColor =
                Color.FromArgb(52, 73, 94);

            lblKilometraje.Location =
                new Point(230, 105);

            lblKilometraje.Name =
                "lblKilometraje";

            lblKilometraje.Size =
                new Size(82, 17);

            lblKilometraje.TabIndex = 10;

            lblKilometraje.Text =
                "Kilometraje";

            // =====================================================
            // NUMERIC KM
            // =====================================================

            numericUpDownKm.Font =
                new Font(
                    "Segoe UI",
                    10F);

            numericUpDownKm.Location =
                new Point(325, 102);

            numericUpDownKm.Maximum =
                new decimal(
                    new int[]
                    {
                        1000000,
                        0,
                        0,
                        0
                    });

            numericUpDownKm.Name =
                "numericUpDownKm";

            numericUpDownKm.Size =
                new Size(130, 25);

            numericUpDownKm.TabIndex = 11;

            numericUpDownKm.ThousandsSeparator =
                true;

            // =====================================================
            // BOTON AGREGAR
            // =====================================================

            btnAgregar.BackColor =
                Color.FromArgb(0, 122, 204);

            btnAgregar.Cursor =
                Cursors.Hand;

            btnAgregar.FlatAppearance.BorderSize =
                0;

            btnAgregar.FlatStyle =
                FlatStyle.Flat;

            btnAgregar.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            btnAgregar.ForeColor =
                Color.White;

            btnAgregar.Location =
                new Point(880, 45);

            btnAgregar.Name =
                "btnAgregar";

            btnAgregar.Size =
                new Size(125, 38);

            btnAgregar.TabIndex = 12;

            btnAgregar.Text =
                "Agregar";

            btnAgregar.UseVisualStyleBackColor =
                false;

            btnAgregar.Click +=
                btnAgregar_Click;

            // =====================================================
            // BOTON MODIFICAR
            // =====================================================

            btnModificar.BackColor =
                Color.FromArgb(52, 73, 94);

            btnModificar.Cursor =
                Cursors.Hand;

            btnModificar.FlatAppearance.BorderSize =
                0;

            btnModificar.FlatStyle =
                FlatStyle.Flat;

            btnModificar.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            btnModificar.ForeColor =
                Color.White;

            btnModificar.Location =
                new Point(1015, 45);

            btnModificar.Name =
                "btnModificar";

            btnModificar.Size =
                new Size(125, 38);

            btnModificar.TabIndex = 13;

            btnModificar.Text =
                "Modificar";

            btnModificar.UseVisualStyleBackColor =
                false;

            btnModificar.Click +=
                btnModificar_Click;

            // =====================================================
            // BOTON ELIMINAR
            // =====================================================

            btnEliminar.BackColor =
                Color.FromArgb(192, 57, 43);

            btnEliminar.Cursor =
                Cursors.Hand;

            btnEliminar.FlatAppearance.BorderSize =
                0;

            btnEliminar.FlatStyle =
                FlatStyle.Flat;

            btnEliminar.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            btnEliminar.ForeColor =
                Color.White;

            btnEliminar.Location =
                new Point(880, 95);

            btnEliminar.Name =
                "btnEliminar";

            btnEliminar.Size =
                new Size(125, 38);

            btnEliminar.TabIndex = 14;

            btnEliminar.Text =
                "Eliminar";

            btnEliminar.UseVisualStyleBackColor =
                false;

            btnEliminar.Click +=
                btnEliminar_Click;

            // =====================================================
            // BOTON LIMPIAR
            // =====================================================

            btnLimpiar.BackColor =
                Color.FromArgb(108, 117, 125);

            btnLimpiar.Cursor =
                Cursors.Hand;

            btnLimpiar.FlatAppearance.BorderSize =
                0;

            btnLimpiar.FlatStyle =
                FlatStyle.Flat;

            btnLimpiar.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            btnLimpiar.ForeColor =
                Color.White;

            btnLimpiar.Location =
                new Point(1015, 95);

            btnLimpiar.Name =
                "btnLimpiar";

            btnLimpiar.Size =
                new Size(125, 38);

            btnLimpiar.TabIndex = 15;

            btnLimpiar.Text =
                "Limpiar";

            btnLimpiar.UseVisualStyleBackColor =
                false;

            btnLimpiar.Click +=
                btnLimpiar_Click;

            // =====================================================
            // PANEL TABLA
            // =====================================================

            panelTabla.BackColor =
                Color.FromArgb(
                    239,
                    244,
                    250);

            panelTabla.Controls.Add(
                dgvVehiculos);

            panelTabla.Controls.Add(
                lblTituloTabla);

            panelTabla.Dock =
                DockStyle.Fill;

            panelTabla.Location =
                new Point(0, 295);

            panelTabla.Name =
                "panelTabla";

            panelTabla.Padding =
                new Padding(
                    30,
                    50,
                    30,
                    25);

            panelTabla.Size =
                new Size(1200, 465);

            panelTabla.TabIndex = 2;

            // =====================================================
            // TITULO TABLA
            // =====================================================

            lblTituloTabla.AutoSize = true;

            lblTituloTabla.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            lblTituloTabla.ForeColor =
                Color.FromArgb(52, 73, 94);

            lblTituloTabla.Location =
                new Point(30, 18);

            lblTituloTabla.Name =
                "lblTituloTabla";

            lblTituloTabla.Size =
                new Size(170, 21);

            lblTituloTabla.TabIndex = 0;

            lblTituloTabla.Text =
                "Vehículos registrados";

            // =====================================================
            // DATAGRIDVIEW
            // =====================================================

            dgvVehiculos.AllowUserToAddRows =
                false;

            dgvVehiculos.AllowUserToDeleteRows =
                false;

            dgvVehiculos.AllowUserToResizeRows =
                false;

            dgvVehiculos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvVehiculos.BackgroundColor =
                Color.White;

            dgvVehiculos.BorderStyle =
                BorderStyle.None;

            dgvVehiculos.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvVehiculos.ColumnHeadersHeight =
                42;

            dgvVehiculos.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvVehiculos.Dock =
                DockStyle.Fill;

            dgvVehiculos.EnableHeadersVisualStyles =
                false;

            dgvVehiculos.GridColor =
                Color.FromArgb(
                    220,
                    225,
                    232);

            dgvVehiculos.Location =
                new Point(30, 50);

            dgvVehiculos.MultiSelect =
                false;

            dgvVehiculos.Name =
                "dgvVehiculos";

            dgvVehiculos.ReadOnly =
                true;

            dgvVehiculos.RowHeadersVisible =
                false;

            dgvVehiculos.RowTemplate.Height =
                38;

            dgvVehiculos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvVehiculos.Size =
                new Size(1140, 390);

            dgvVehiculos.TabIndex = 1;

            dgvVehiculos.CellClick +=
                dgvVehiculos_CellClick;

            // =====================================================
            // FORM
            // =====================================================

            AutoScaleDimensions =
                new SizeF(
                    7F,
                    15F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.FromArgb(
                    239,
                    244,
                    250);

            ClientSize =
                new Size(
                    1200,
                    760);

            Controls.Add(
                panelTabla);

            Controls.Add(
                panelFormulario);

            Controls.Add(
                panelTop);

            MinimumSize =
                new Size(
                    1000,
                    650);

            Name =
                "frmVehiculos";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "CarCheck - Gestión de vehículos";

            WindowState =
                FormWindowState.Maximized;

            Load +=
                frmVehiculos_Load;

            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();

            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                numericUpDownAnio).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                numericUpDownKm).EndInit();

            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                dgvVehiculos).EndInit();

            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelFormulario;
        private Panel panelTabla;

        private Label label1;
        private Label lblSubtitulo;

        private Label lblTituloFormulario;
        private Label lblAyuda;

        private Label lblAño;
        private Label lblPatente;
        private Label lblModelo;
        private Label lblMarca;
        private Label lblKilometraje;

        private TextBox txtPatente;
        private TextBox txtModelo;
        private TextBox txtMarca;

        private NumericUpDown numericUpDownKm;
        private NumericUpDown numericUpDownAnio;

        private DataGridView dgvVehiculos;

        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;

        private Label lblTituloTabla;
    }
}