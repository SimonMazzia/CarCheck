using carCheckBussines;
using carCheckEntities;
using carCheckServicios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace carCheckFront
{
    public partial class FrmDashboard : Form
    {
        private readonly VehiculoNegocio vehiculoNegocio =
            new VehiculoNegocio();

        private readonly ServicioNegocio servicioNegocio =
            new ServicioNegocio();

        private List<Vehiculo> vehiculos =
            new List<Vehiculo>();

        private List<Servicio> servicios =
            new List<Servicio>();

        public FrmDashboard()
        {
            InitializeComponent();

            Load += FrmDashboard_Load;
        }

        private void FrmDashboard_Load(
            object sender,
            EventArgs e)
        {
            CargarDatos();
            ConfigurarGrillas();
        }

        // =========================================================
        // CARGAR DATOS
        // =========================================================

        private void CargarDatos()
        {
            int usuarioId =
                Sesion.UsuarioActual.Id;

            // Bienvenida
            lblBienvenida.Text =
                $"Hola de nuevo, {Sesion.UsuarioActual.NombreUsuario}";

            // VEHÍCULOS
            vehiculos =
                vehiculoNegocio
                .ObtenerVehiculosPorUsuario(usuarioId);

            lblCantidadVehiculos.Text =
                vehiculos.Count.ToString();

            // SERVICIOS
            servicios =
                servicioNegocio
                .ObtenerServiciosPorUsuario(usuarioId);

            lblCantidadServicios.Text =
                servicios.Count.ToString();

            // ACTIVIDAD RECIENTE
            int serviciosRecientes =
                servicios.Count(s =>
                    s.Fecha.Date >=
                    DateTime.Today.AddDays(-30));

            lblCantidadPendientes.Text =
                serviciosRecientes.ToString();

            CargarVehiculos();
            CargarServicios();
        }

        // =========================================================
        // VEHÍCULOS
        // =========================================================

        private void CargarVehiculos()
        {
            var datos =
                vehiculos
                .Select(v => new
                {
                    Patente = v.Patente,
                    Marca = v.Marca,
                    Modelo = v.Modelo,
                    Año = v.Anio,
                    Kilometraje = v.Kilometraje
                })
                .ToList();

            dgvVehiculos.DataSource = null;
            dgvVehiculos.DataSource = datos;

            if (dgvVehiculos.Columns["Patente"] != null)
                dgvVehiculos.Columns["Patente"].HeaderText =
                    "Patente";

            if (dgvVehiculos.Columns["Marca"] != null)
                dgvVehiculos.Columns["Marca"].HeaderText =
                    "Marca";

            if (dgvVehiculos.Columns["Modelo"] != null)
                dgvVehiculos.Columns["Modelo"].HeaderText =
                    "Modelo";

            if (dgvVehiculos.Columns["Año"] != null)
                dgvVehiculos.Columns["Año"].HeaderText =
                    "Año";

            if (dgvVehiculos.Columns["Kilometraje"] != null)
            {
                dgvVehiculos.Columns["Kilometraje"].HeaderText =
                    "Kilometraje";

                dgvVehiculos.Columns["Kilometraje"]
                    .DefaultCellStyle.Format = "N0";
            }
        }

        // =========================================================
        // SERVICIOS
        // =========================================================

        private void CargarServicios()
        {
            var datos =
                servicios
                .OrderByDescending(s => s.Fecha)
                .Take(8)
                .Select(s => new
                {
                    Fecha = s.Fecha,

                    Patente =
                        s.Vehiculo != null
                            ? s.Vehiculo.Patente
                            : "",

                    TipoServicio =
                        s.TipoServicio != null
                            ? s.TipoServicio.Nombre
                            : "",

                    Kilometraje = s.Kilometraje,

                    Costo = s.Costo
                })
                .ToList();

            dgvServicios.DataSource = null;
            dgvServicios.DataSource = datos;

            if (dgvServicios.Columns["Fecha"] != null)
            {
                dgvServicios.Columns["Fecha"].HeaderText =
                    "Fecha";

                dgvServicios.Columns["Fecha"]
                    .DefaultCellStyle.Format =
                    "dd/MM/yyyy";
            }

            if (dgvServicios.Columns["Patente"] != null)
                dgvServicios.Columns["Patente"].HeaderText =
                    "Patente";

            if (dgvServicios.Columns["TipoServicio"] != null)
                dgvServicios.Columns["TipoServicio"].HeaderText =
                    "Tipo de servicio";

            if (dgvServicios.Columns["Kilometraje"] != null)
            {
                dgvServicios.Columns["Kilometraje"].HeaderText =
                    "Kilometraje";

                dgvServicios.Columns["Kilometraje"]
                    .DefaultCellStyle.Format = "N0";
            }

            if (dgvServicios.Columns["Costo"] != null)
            {
                dgvServicios.Columns["Costo"].HeaderText =
                    "Costo";

                dgvServicios.Columns["Costo"]
                    .DefaultCellStyle.Format = "N0";
            }
        }

        // =========================================================
        // CONFIGURACIÓN DE GRILLAS
        // =========================================================

        private void ConfigurarGrillas()
        {
            ConfigurarGrilla(dgvVehiculos);
            ConfigurarGrilla(dgvServicios);
        }

        private void ConfigurarGrilla(
            DataGridView dgv)
        {
            dgv.AutoGenerateColumns = true;

            dgv.ReadOnly = true;

            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;

            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv.MultiSelect = false;

            dgv.RowHeadersVisible = false;

            dgv.BackgroundColor =
                Color.White;

            dgv.BorderStyle =
                BorderStyle.None;

            dgv.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgv.GridColor =
                Color.FromArgb(230, 234, 239);

            dgv.EnableHeadersVisualStyles = false;

            // Encabezado
            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(52, 73, 94);

            dgv.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Bold);

            dgv.ColumnHeadersHeight = 38;

            // Celdas
            dgv.DefaultCellStyle.Font =
                new Font(
                    "Segoe UI",
                    9);

            dgv.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 235, 248);

            dgv.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(40, 40, 40);

            // Filas alternadas
            dgv.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);

            dgv.RowTemplate.Height = 34;

            dgv.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        // =========================================================
        // BOTÓN VEHÍCULOS
        // =========================================================

        private void btnVehiculos_Click(
            object sender,
            EventArgs e)
        {
            frmVehiculos formulario =
                new frmVehiculos();

            formulario.ShowDialog();

            CargarDatos();
        }

        // =========================================================
        // BOTÓN SERVICIOS
        // =========================================================

        private void btnServicios_Click(
            object sender,
            EventArgs e)
        {
            FrmNuevoServicio formulario =
                new FrmNuevoServicio();

            formulario.ShowDialog();

            CargarDatos();
        }

        // =========================================================
        // ACTUALIZAR
        // =========================================================

        private void btnActualizar_Click(
            object sender,
            EventArgs e)
        {
            CargarDatos();

            MessageBox.Show(
                "La información fue actualizada.",
                "CarCheck",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================================================
        // EVENTOS VACÍOS DEL DISEÑADOR
        // =========================================================

        private void panelDashboardTop_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void lblSubtitulo_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}