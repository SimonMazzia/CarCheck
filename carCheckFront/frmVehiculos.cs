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
        public frmVehiculos()
        {
            InitializeComponent();

            Load += frmVehiculos_Load;
        }

        private void frmVehiculos_Load(
            object sender,
            EventArgs e)
        {

            EstilizarTabla();
            ConfigurarAutoComplete();
            CargarVehiculos();
        }

        private void CargarVehiculos()
        {
            int usuarioId = Sesion.UsuarioActual.Id;

            dgvVehiculos.DataSource = null;

            dgvVehiculos.DataSource =
                vehiculoNegocio
                .ObtenerVehiculosPorUsuario(usuarioId);

            dgvVehiculos.Columns["Id"].Visible = false;

            dgvVehiculos.Columns["UsuarioId"].Visible = false;

            dgvVehiculos.Columns["Usuario"].Visible = false;
        }

        private void btnAgregar_Click(
            object sender,
            EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo()
            {
                Marca = txtMarca.Text.Trim(),

                Modelo = txtModelo.Text.Trim(),

                Patente = txtPatente.Text
                    .Trim()
                    .ToUpper(),

                Anio = (int)numericUpDownAnio.Value,

                Kilometraje =
                    (int)numericUpDownKm.Value,

                UsuarioId =
                    Sesion.UsuarioActual.Id
            };

            bool ok =
                vehiculoNegocio.RegistrarVehiculo(
                    vehiculo,
                    out string mensaje);

            MessageBox.Show(mensaje);

            if (ok)
            {
                CargarVehiculos();

                LimpiarCampos();
            }
        }

        private void btnModificar_Click(
            object sender,
            EventArgs e)
        {
            if (vehiculosSeleccionadoId == 0)
            {
                MessageBox.Show(
                    "Seleccioná un vehículo.");

                return;
            }

            Vehiculo vehiculo = new Vehiculo()
            {
                Id = vehiculosSeleccionadoId,

                Marca = txtMarca.Text.Trim(),

                Modelo = txtModelo.Text.Trim(),

                Patente = txtPatente.Text
                    .Trim()
                    .ToUpper(),

                Anio = (int)numericUpDownAnio.Value,

                Kilometraje =
                    (int)numericUpDownKm.Value,

                UsuarioId =
                    Sesion.UsuarioActual.Id
            };

            bool ok =
                vehiculoNegocio.ModificarVehiculo(
                    vehiculo,
                    out string mensaje);

            MessageBox.Show(mensaje);

            if (ok)
            {
                CargarVehiculos();

                LimpiarCampos();

                vehiculosSeleccionadoId = 0;
            }
        }

        private void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (vehiculosSeleccionadoId == 0)
            {
                MessageBox.Show(
                    "Seleccioná un vehículo.");

                return;
            }

            DialogResult resultado =
                MessageBox.Show(
                    "¿Eliminar vehículo?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            bool ok =
                vehiculoNegocio.EliminarVehiculo(
                    vehiculosSeleccionadoId,
                    out string mensaje);

            MessageBox.Show(mensaje);

            if (ok)
            {
                CargarVehiculos();

                LimpiarCampos();

                vehiculosSeleccionadoId = 0;
            }
        }


        private void dgvVehiculos_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila =
                dgvVehiculos.Rows[e.RowIndex];

            vehiculosSeleccionadoId =
                Convert.ToInt32(
                    fila.Cells["Id"].Value);

            txtMarca.Text =
                fila.Cells["Marca"].Value.ToString();

            txtModelo.Text =
                fila.Cells["Modelo"].Value.ToString();

            txtPatente.Text =
                fila.Cells["Patente"].Value.ToString();

            numericUpDownAnio.Value =
                Convert.ToDecimal(
                    fila.Cells["Anio"].Value);

            numericUpDownKm.Value =
                Convert.ToDecimal(
                    fila.Cells["Kilometraje"].Value);
        }

        private void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            LimpiarCampos();

            vehiculosSeleccionadoId = 0;
        }

        private void LimpiarCampos()
        {
            txtMarca.Clear();

            txtModelo.Clear();

            txtPatente.Clear();

            numericUpDownAnio.Value =
                numericUpDownAnio.Minimum;

            numericUpDownKm.Value =
                numericUpDownKm.Minimum;
        }

        private void ConfigurarAutoComplete()
        {
            AutoCompleteStringCollection marcas =
                new AutoCompleteStringCollection();

            marcas.AddRange(new string[]
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



        private void EstilizarTabla()
        {
            dgvVehiculos.BorderStyle =
                BorderStyle.None;

            dgvVehiculos.EnableHeadersVisualStyles =
                false;

            dgvVehiculos.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            dgvVehiculos.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 122, 204);

            dgvVehiculos.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvVehiculos.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold);

            dgvVehiculos.ColumnHeadersHeight = 40;

            dgvVehiculos.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvVehiculos.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(52, 73, 94);

            dgvVehiculos.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgvVehiculos.RowTemplate.Height = 35;

            dgvVehiculos.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 247, 250);

            dgvVehiculos.GridColor =
                Color.LightGray;

            dgvVehiculos.BackgroundColor =
                Color.White;

            dgvVehiculos.RowHeadersVisible =
                false;

            dgvVehiculos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvVehiculos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvVehiculos.MultiSelect = false;
        }


    }
}