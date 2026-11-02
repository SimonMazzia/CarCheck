
using carCheckBussines;
using carCheckEntities;
using carCheckServicios;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace carCheckFront
{
    public partial class FrmHistorial : Form
    {
        private readonly ServicioNegocio servicioNegocio =
            new ServicioNegocio();

        private readonly VehiculoNegocio vehiculoNegocio =
            new VehiculoNegocio();

        public FrmHistorial()
        {
            InitializeComponent();

            ConfigurarTabla();

            Load += FrmHistorial_Load;
        }

        // Configuración visual de la tabla
        private void ConfigurarTabla()
        {
            dgvHistorial.EnableHeadersVisualStyles = false;

            dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(0, 122, 204);

            dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvHistorial.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            dgvHistorial.DefaultCellStyle.Font =
                new Font("Segoe UI", 9);

            dgvHistorial.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(214, 234, 248);

            dgvHistorial.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(52, 73, 94);

            dgvHistorial.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);

            dgvHistorial.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvHistorial.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvHistorial.MultiSelect = false;
            dgvHistorial.ReadOnly = true;
            dgvHistorial.AllowUserToAddRows = false;
        }

        // Carga inicial
        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            CargarVehiculos();
        }

        // Cargar vehículos del usuario actual
        private void CargarVehiculos()
        {
            try
            {
                int usuarioId = Sesion.UsuarioActual.Id;

                var vehiculos =
                    vehiculoNegocio.ObtenerVehiculosPorUsuario(usuarioId);

                cmbVehiculos.DataSource = null;

                cmbVehiculos.DisplayMember = "Descripcion";
                cmbVehiculos.ValueMember = "Id";

                var opciones = vehiculos.Select(v => new
                {
                    v.Id,
                    Descripcion = $"{v.Marca} {v.Modelo} - {v.Patente}"
                }).ToList();

                cmbVehiculos.DataSource = opciones;

                if (opciones.Count == 0)
                {
                    dgvHistorial.DataSource = null;

                    MessageBox.Show(
                        "Todavía no tenés vehículos registrados.",
                        "CarCheck",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                CargarHistorial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los vehículos.\n\n" + ex.Message,
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Consultar historial del vehículo seleccionado
        private void CargarHistorial()
        {
            try
            {
                if (cmbVehiculos.SelectedValue == null)
                    return;

                int usuarioId = Sesion.UsuarioActual.Id;
                int vehiculoId = Convert.ToInt32(
                    cmbVehiculos.SelectedValue);

                // Verificar que el vehículo pertenezca al usuario
                var vehiculo =
                    vehiculoNegocio.ObtenerVehiculoPorUsuario(
                        vehiculoId,
                        usuarioId);

                if (vehiculo == null)
                {
                    dgvHistorial.DataSource = null;

                    MessageBox.Show(
                        "No tenés autorización para acceder a este vehículo.",
                        "CarCheck",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Obtener los servicios del usuario
                var servicios =
                    servicioNegocio.ObtenerServiciosPorUsuario(usuarioId);

                // Filtrar los servicios del vehículo seleccionado
                var historial = servicios
                    .Where(s => s.VehiculoId == vehiculo.Id)
                    .Select(s => new
                    {
                        s.Id,
                        Fecha = s.Fecha,
                        TipoServicio = s.TipoServicio == null
                            ? "Sin especificar"
                            : s.TipoServicio.Nombre,
                        Kilometraje = s.Kilometraje,
                        Descripcion = string.IsNullOrWhiteSpace(
                            s.Descripcion)
                            ? "Sin descripción"
                            : s.Descripcion,
                        Costo = s.Costo
                    })
                    .OrderByDescending(s => s.Fecha)
                    .ToList();

                dgvHistorial.DataSource = historial;

                if (dgvHistorial.Columns.Contains("Id"))
                    dgvHistorial.Columns["Id"].Visible = false;

                if (dgvHistorial.Columns.Contains("Fecha"))
                {
                    dgvHistorial.Columns["Fecha"].HeaderText = "Fecha";
                    dgvHistorial.Columns["Fecha"].DefaultCellStyle.Format =
                        "dd/MM/yyyy";
                }

                if (dgvHistorial.Columns.Contains("TipoServicio"))
                {
                    dgvHistorial.Columns["TipoServicio"].HeaderText =
                        "Tipo de servicio";
                }

                if (dgvHistorial.Columns.Contains("Kilometraje"))
                {
                    dgvHistorial.Columns["Kilometraje"].HeaderText = "Km";
                    dgvHistorial.Columns["Kilometraje"]
                        .DefaultCellStyle.Format = "N0";
                }

                if (dgvHistorial.Columns.Contains("Descripcion"))
                {
                    dgvHistorial.Columns["Descripcion"].HeaderText =
                        "Descripción";
                }

                if (dgvHistorial.Columns.Contains("Costo"))
                {
                    dgvHistorial.Columns["Costo"].HeaderText = "Costo";
                    dgvHistorial.Columns["Costo"].DefaultCellStyle.Format =
                        "C2";

                    dgvHistorial.Columns["Costo"].DefaultCellStyle
                        .FormatProvider =
                        CultureInfo.GetCultureInfo("es-AR");
                }

                if (historial.Count == 0)
                {
                    MessageBox.Show(
                        "Este vehículo todavía no tiene servicios registrados. " +
                        "Podés exportar igualmente su informe en PDF.",
                        "Historial de mantenimiento",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo cargar el historial.\n\n" + ex.Message,
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Cambiar vehículo seleccionado
        private void cmbVehiculos_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cmbVehiculos.SelectedValue != null &&
                cmbVehiculos.SelectedValue is int)
            {
                CargarHistorial();
            }
        }

        // Botón Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        // Exportar historial del vehículo seleccionado
        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbVehiculos.SelectedValue == null)
                {
                    MessageBox.Show(
                        "Seleccioná un vehículo para exportar su historial.",
                        "CarCheck",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                int usuarioId = Sesion.UsuarioActual.Id;
                int vehiculoId = Convert.ToInt32(
                    cmbVehiculos.SelectedValue);

                // Validar propiedad del vehículo
                var vehiculo =
                    vehiculoNegocio.ObtenerVehiculoPorUsuario(
                        vehiculoId,
                        usuarioId);

                if (vehiculo == null)
                {
                    MessageBox.Show(
                        "No tenés autorización para acceder a este vehículo.",
                        "CarCheck",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Obtener todos los servicios del usuario
                var servicios =
                    servicioNegocio.ObtenerServiciosPorUsuario(usuarioId);

                // Filtrar el historial del vehículo
                var historialVehiculo = servicios
                    .Where(s => s.VehiculoId == vehiculo.Id)
                    .OrderByDescending(s => s.Fecha)
                    .ToList();

                using SaveFileDialog dialogo = new SaveFileDialog
                {
                    Title = "Exportar historial de mantenimiento",
                    Filter = "Archivo PDF (*.pdf)|*.pdf",
                    FileName = $"Historial_{vehiculo.Patente}.pdf",
                    DefaultExt = "pdf",
                    AddExtension = true,
                    OverwritePrompt = true
                };

                if (dialogo.ShowDialog() != DialogResult.OK)
                    return;

                // Generar el PDF
                ReporteHistorialPdf.Generar(
                    vehiculo,
                    historialVehiculo,
                    dialogo.FileName);

                MessageBox.Show(
                    "El historial se exportó correctamente.",
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo exportar el PDF.\n\n" + ex.Message,
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

