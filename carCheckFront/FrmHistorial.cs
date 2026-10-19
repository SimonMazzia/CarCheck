
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
        }

        // Carga inicial
        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        // Consultar servicios del usuario actual
        private void CargarHistorial()
        {
            try
            {
                var servicios =
                    servicioNegocio.ObtenerServiciosPorUsuario(
                        Sesion.UsuarioActual.Id);

                var historial = servicios
                    .Select(s => new
                    {
                        s.Id,

                        Vehiculo = s.Vehiculo == null
                            ? "Sin vehículo"
                            : $"{s.Vehiculo.Marca} {s.Vehiculo.Modelo}",

                        Patente = s.Vehiculo == null
                            ? ""
                            : s.Vehiculo.Patente,

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

                // Ocultar el identificador interno
                if (dgvHistorial.Columns.Contains("Id"))
                {
                    dgvHistorial.Columns["Id"].Visible = false;
                }

                // Encabezados y formatos
                if (dgvHistorial.Columns.Contains("Vehiculo"))
                    dgvHistorial.Columns["Vehiculo"].HeaderText = "Vehículo";

                if (dgvHistorial.Columns.Contains("Patente"))
                    dgvHistorial.Columns["Patente"].HeaderText = "Patente";

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

                if (servicios.Count == 0)
                {
                    MessageBox.Show(
                        "Todavía no hay servicios registrados.",
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

        // Botón Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        // Exportar el historial del vehículo seleccionado
        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            if (dgvHistorial.CurrentRow == null ||
                dgvHistorial.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccioná un servicio de la tabla para exportar " +
                    "el historial de su vehículo.",
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            try
            {
                int servicioId = Convert.ToInt32(
                    dgvHistorial.CurrentRow.Cells["Id"].Value);

                var servicios =
                    servicioNegocio.ObtenerServiciosPorUsuario(
                        Sesion.UsuarioActual.Id);

                var servicioSeleccionado = servicios
                    .FirstOrDefault(s => s.Id == servicioId);

                if (servicioSeleccionado?.Vehiculo == null)
                {
                    MessageBox.Show(
                        "No se encontró el vehículo asociado al servicio.",
                        "CarCheck",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                var vehiculo = servicioSeleccionado.Vehiculo;

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
