using carCheckBussines;
using carCheckEntities;
using carCheckServicios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace carCheckFront
{
    public partial class frmVehiculos : Form
    {
        private readonly VehiculoNegocio vehiculoNegocio =
            new VehiculoNegocio();

        private int vehiculosSeleccionadoId = 0;

        // Colores generales de CarCheck
        private readonly Color colorAzul =
            Color.FromArgb(0, 122, 204);

        private readonly Color colorAzulOscuro =
            Color.FromArgb(52, 73, 94);

        private readonly Color colorFondo =
            Color.FromArgb(239, 244, 250);

        private readonly Color colorBorde =
            Color.FromArgb(220, 225, 232);

        public frmVehiculos()
        {
            InitializeComponent();

            Load += frmVehiculos_Load;
        }

        private void frmVehiculos_Load(
            object sender,
            EventArgs e)
        {
            EstilizarFormulario();
            EstilizarTabla();
            ConfigurarAutoComplete();
            CargarVehiculos();
        }

        // =========================================================
        // ESTILO GENERAL
        // =========================================================

        private void EstilizarFormulario()
        {
            BackColor = colorFondo;

            // Panel superior
            panelTop.BackColor = colorAzul;

            label1.ForeColor = Color.White;
            label1.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Bold);

            // Panel del formulario
            panelFormulario.BackColor = Color.White;

            // Etiquetas
            EstilizarLabel(lblMarca);
            EstilizarLabel(lblModelo);
            EstilizarLabel(lblPatente);
            EstilizarLabel(lblAño);
            EstilizarLabel(lblKilometraje);

            // TextBox
            EstilizarTextBox(txtMarca);
            EstilizarTextBox(txtModelo);
            EstilizarTextBox(txtPatente);

            // NumericUpDown
            EstilizarNumericUpDown(numericUpDownAnio);
            EstilizarNumericUpDown(numericUpDownKm);

            // Botones
            EstilizarBotonPrincipal(btnAgregar);
            EstilizarBotonSecundario(btnModificar);
            EstilizarBotonEliminar(btnEliminar);
            EstilizarBotonLimpiar(btnLimpiar);
        }

        private void EstilizarLabel(Label label)
        {
            label.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            label.ForeColor = colorAzulOscuro;
        }

        private void EstilizarTextBox(TextBox textBox)
        {
            textBox.Font =
                new Font(
                    "Segoe UI",
                    10F);

            textBox.BackColor = Color.White;
            textBox.ForeColor =
                Color.FromArgb(40, 40, 40);

            textBox.BorderStyle =
                BorderStyle.FixedSingle;
        }

        private void EstilizarNumericUpDown(
            NumericUpDown numeric)
        {
            numeric.Font =
                new Font(
                    "Segoe UI",
                    10F);

            numeric.BackColor = Color.White;
            numeric.ForeColor =
                Color.FromArgb(40, 40, 40);
        }

        private void EstilizarBotonPrincipal(
            Button boton)
        {
            boton.BackColor = colorAzul;
            boton.ForeColor = Color.White;

            boton.FlatStyle =
                FlatStyle.Flat;

            boton.FlatAppearance.BorderSize = 0;

            boton.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            boton.Cursor = Cursors.Hand;
        }

        private void EstilizarBotonSecundario(
            Button boton)
        {
            boton.BackColor = colorAzulOscuro;
            boton.ForeColor = Color.White;

            boton.FlatStyle =
                FlatStyle.Flat;

            boton.FlatAppearance.BorderSize = 0;

            boton.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            boton.Cursor = Cursors.Hand;
        }

        private void EstilizarBotonEliminar(
            Button boton)
        {
            boton.BackColor =
                Color.FromArgb(192, 57, 43);

            boton.ForeColor = Color.White;

            boton.FlatStyle =
                FlatStyle.Flat;

            boton.FlatAppearance.BorderSize = 0;

            boton.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            boton.Cursor = Cursors.Hand;
        }

        private void EstilizarBotonLimpiar(
            Button boton)
        {
            boton.BackColor =
                Color.FromArgb(108, 117, 125);

            boton.ForeColor = Color.White;

            boton.FlatStyle =
                FlatStyle.Flat;

            boton.FlatAppearance.BorderSize = 0;

            boton.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            boton.Cursor = Cursors.Hand;
        }

        // =========================================================
        // VEHICULOS
        // =========================================================

        private void CargarVehiculos()
        {
            int usuarioId =
                Sesion.UsuarioActual.Id;

            dgvVehiculos.DataSource = null;

            dgvVehiculos.DataSource =
                vehiculoNegocio
                    .ObtenerVehiculosPorUsuario(usuarioId);

            if (dgvVehiculos.Columns["Id"] != null)
                dgvVehiculos.Columns["Id"].Visible = false;

            if (dgvVehiculos.Columns["UsuarioId"] != null)
                dgvVehiculos.Columns["UsuarioId"].Visible = false;

            if (dgvVehiculos.Columns["Usuario"] != null)
                dgvVehiculos.Columns["Usuario"].Visible = false;

            ConfigurarColumnas();
        }

        private void ConfigurarColumnas()
        {
            if (dgvVehiculos.Columns["Marca"] != null)
                dgvVehiculos.Columns["Marca"].HeaderText =
                    "Marca";

            if (dgvVehiculos.Columns["Modelo"] != null)
                dgvVehiculos.Columns["Modelo"].HeaderText =
                    "Modelo";

            if (dgvVehiculos.Columns["Anio"] != null)
                dgvVehiculos.Columns["Anio"].HeaderText =
                    "Año";

            if (dgvVehiculos.Columns["Patente"] != null)
                dgvVehiculos.Columns["Patente"].HeaderText =
                    "Patente";

            if (dgvVehiculos.Columns["Kilometraje"] != null)
            {
                dgvVehiculos.Columns["Kilometraje"].HeaderText =
                    "Kilometraje";

                dgvVehiculos.Columns["Kilometraje"]
                    .DefaultCellStyle
                    .Format = "N0";
            }
        }

        // =========================================================
        // AGREGAR
        // =========================================================

        private void btnAgregar_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidarCampos())
                return;

            Vehiculo vehiculo =
                new Vehiculo()
                {
                    Marca =
                        txtMarca.Text.Trim(),

                    Modelo =
                        txtModelo.Text.Trim(),

                    Patente =
                        txtPatente.Text
                            .Trim()
                            .ToUpper(),

                    Anio =
                        (int)numericUpDownAnio.Value,

                    Kilometraje =
                        (int)numericUpDownKm.Value,

                    UsuarioId =
                        Sesion.UsuarioActual.Id
                };

            bool ok =
                vehiculoNegocio.RegistrarVehiculo(
                    vehiculo,
                    out string mensaje);

            MessageBox.Show(
                mensaje,
                "CarCheck",
                MessageBoxButtons.OK,
                ok
                    ? MessageBoxIcon.Information
                    : MessageBoxIcon.Warning);

            if (ok)
            {
                CargarVehiculos();

                LimpiarCampos();
            }
        }

        // =========================================================
        // MODIFICAR
        // =========================================================

        private void btnModificar_Click(
            object sender,
            EventArgs e)
        {
            if (vehiculosSeleccionadoId == 0)
            {
                MessageBox.Show(
                    "Seleccioná un vehículo para modificar.",
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidarCampos())
                return;

            Vehiculo vehiculo =
                new Vehiculo()
                {
                    Id =
                        vehiculosSeleccionadoId,

                    Marca =
                        txtMarca.Text.Trim(),

                    Modelo =
                        txtModelo.Text.Trim(),

                    Patente =
                        txtPatente.Text
                            .Trim()
                            .ToUpper(),

                    Anio =
                        (int)numericUpDownAnio.Value,

                    Kilometraje =
                        (int)numericUpDownKm.Value,

                    UsuarioId =
                        Sesion.UsuarioActual.Id
                };

            bool ok =
                vehiculoNegocio.ModificarVehiculo(
                    vehiculo,
                    out string mensaje);

            MessageBox.Show(
                mensaje,
                "CarCheck",
                MessageBoxButtons.OK,
                ok
                    ? MessageBoxIcon.Information
                    : MessageBoxIcon.Warning);

            if (ok)
            {
                CargarVehiculos();

                LimpiarCampos();

                vehiculosSeleccionadoId = 0;
            }
        }

        // =========================================================
        // ELIMINAR
        // =========================================================

        private void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (vehiculosSeleccionadoId == 0)
            {
                MessageBox.Show(
                    "Seleccioná un vehículo para eliminar.",
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult resultado =
                MessageBox.Show(
                    "¿Estás seguro de que querés eliminar este vehículo?",
                    "Eliminar vehículo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

            if (resultado != DialogResult.Yes)
                return;

            bool ok =
                vehiculoNegocio.EliminarVehiculo(
                    vehiculosSeleccionadoId,
                    out string mensaje);

            MessageBox.Show(
                mensaje,
                "CarCheck",
                MessageBoxButtons.OK,
                ok
                    ? MessageBoxIcon.Information
                    : MessageBoxIcon.Warning);

            if (ok)
            {
                CargarVehiculos();

                LimpiarCampos();

                vehiculosSeleccionadoId = 0;
            }
        }

        // =========================================================
        // SELECCIONAR VEHICULO
        // =========================================================

        private void dgvVehiculos_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvVehiculos.Rows[e.RowIndex];

            vehiculosSeleccionadoId =
                Convert.ToInt32(
                    fila.Cells["Id"].Value);

            txtMarca.Text =
                fila.Cells["Marca"]
                    .Value?
                    .ToString() ?? "";

            txtModelo.Text =
                fila.Cells["Modelo"]
                    .Value?
                    .ToString() ?? "";

            txtPatente.Text =
                fila.Cells["Patente"]
                    .Value?
                    .ToString() ?? "";

            numericUpDownAnio.Value =
                Convert.ToDecimal(
                    fila.Cells["Anio"].Value);

            numericUpDownKm.Value =
                Convert.ToDecimal(
                    fila.Cells["Kilometraje"].Value);
        }

        // =========================================================
        // LIMPIAR
        // =========================================================

        private void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            LimpiarCampos();

            vehiculosSeleccionadoId = 0;

            dgvVehiculos.ClearSelection();

            txtMarca.Focus();
        }

        private void LimpiarCampos()
        {
            txtMarca.Clear();

            txtModelo.Clear();

            txtPatente.Clear();

            numericUpDownAnio.Value =
                DateTime.Now.Year;

            numericUpDownKm.Value =
                numericUpDownKm.Minimum;
        }

        // =========================================================
        // VALIDACIONES
        // =========================================================

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(
                txtMarca.Text))
            {
                MessageBox.Show(
                    "Ingresá la marca del vehículo.",
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMarca.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(
                txtModelo.Text))
            {
                MessageBox.Show(
                    "Ingresá el modelo del vehículo.",
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtModelo.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(
                txtPatente.Text))
            {
                MessageBox.Show(
                    "Ingresá la patente del vehículo.",
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPatente.Focus();

                return false;
            }

            if (numericUpDownAnio.Value <= 0)
            {
                MessageBox.Show(
                    "Ingresá un año válido.",
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                numericUpDownAnio.Focus();

                return false;
            }

            return true;
        }

        // =========================================================
        // AUTOCOMPLETE MARCAS
        // =========================================================

        private void ConfigurarAutoComplete()
        {
            AutoCompleteStringCollection marcas =
                new AutoCompleteStringCollection();

            marcas.AddRange(
                new string[]
                {
                    "Audi",
                    "Alfa Romeo",
                    "Aston Martin",
                    "BMW",
                    "Bentley",
                    "Bugatti",
                    "Chevrolet",
                    "Citroen",
                    "Dodge",
                    "Ferrari",
                    "Fiat",
                    "Ford",
                    "Honda",
                    "Hyundai",
                    "Jeep",
                    "Kia",
                    "Lamborghini",
                    "Mazda",
                    "Mercedes-Benz",
                    "Nissan",
                    "Peugeot",
                    "Porsche",
                    "Renault",
                    "Toyota",
                    "Volkswagen",
                    "Volvo"
                });

            txtMarca.AutoCompleteMode =
                AutoCompleteMode.SuggestAppend;

            txtMarca.AutoCompleteSource =
                AutoCompleteSource.CustomSource;

            txtMarca.AutoCompleteCustomSource =
                marcas;
        }

        // =========================================================
        // ESTILO TABLA
        // =========================================================

        private void EstilizarTabla()
        {
            dgvVehiculos.BorderStyle =
                BorderStyle.None;

            dgvVehiculos.EnableHeadersVisualStyles =
                false;

            dgvVehiculos.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvVehiculos.ColumnHeadersDefaultCellStyle.BackColor =
                colorAzulOscuro;

            dgvVehiculos.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvVehiculos.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            dgvVehiculos.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dgvVehiculos.ColumnHeadersHeight = 42;

            dgvVehiculos.DefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    9.5F);

            dgvVehiculos.DefaultCellStyle.ForeColor =
                Color.FromArgb(45, 45, 45);

            dgvVehiculos.DefaultCellStyle.BackColor =
                Color.White;

            dgvVehiculos.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 235, 248);

            dgvVehiculos.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(40, 40, 40);

            dgvVehiculos.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);

            dgvVehiculos.GridColor =
                colorBorde;

            dgvVehiculos.BackgroundColor =
                Color.White;

            dgvVehiculos.RowHeadersVisible =
                false;

            dgvVehiculos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvVehiculos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvVehiculos.MultiSelect =
                false;

            dgvVehiculos.ReadOnly =
                true;

            dgvVehiculos.AllowUserToAddRows =
                false;

            dgvVehiculos.AllowUserToDeleteRows =
                false;

            dgvVehiculos.AllowUserToResizeRows =
                false;

            dgvVehiculos.RowTemplate.Height =
                38;

            dgvVehiculos.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;
        }

        private void txtMarca_TextChanged(
            object sender,
            EventArgs e)
        {
        }
    }
}