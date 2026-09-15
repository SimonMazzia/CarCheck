using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using carCheckBussines;
using carCheckEntities;
using carCheckServicios;

namespace carCheckFront
{
    public partial class FrmServicios : Form
    {
        private readonly VehiculoNegocio vehiculoNegocio =
            new VehiculoNegocio();

        private readonly ServicioNegocio servicioNegocio =
            new ServicioNegocio();

        private readonly TipoServicioNegocio tipoServicioNegocio =
            new TipoServicioNegocio();

        public FrmServicios()
        {   
            InitializeComponent();

            Load += FrmServicios_Load;
        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {
            CargarVehiculos();
            CargarTiposServicio();
        }

        // ==========================================
        // VEHÍCULOS
        // ==========================================

        private void CargarVehiculos()
        {
            int usuarioId = Sesion.UsuarioActual.Id;

            cbmVehiculo.DataSource = null;

            cbmVehiculo.DataSource =
                vehiculoNegocio.ObtenerVehiculosPorUsuario(usuarioId);

            cbmVehiculo.DisplayMember = "Patente";
            cbmVehiculo.ValueMember = "Id";

            cbmVehiculo.SelectedIndex = -1;
        }

        // ==========================================
        // TIPOS DE SERVICIO
        // ==========================================

        private void CargarTiposServicio()
        {
            cbmTipoServicio.DataSource = null;

            cbmTipoServicio.DataSource =
                tipoServicioNegocio.ObtenerTodos();

            cbmTipoServicio.DisplayMember = "Nombre";
            cbmTipoServicio.ValueMember = "Id";

            cbmTipoServicio.SelectedIndex = -1;
        }

        // ==========================================
        // EVENTOS
        // ==========================================

        private void cbmVehiculo_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {

        }

        private void panel1_Paint(
            object sender,
            PaintEventArgs e)
        {

        }

        private void txtKilometraje_TextChanged(
            object sender,
            EventArgs e)
        {

        }

        // ==========================================
        // FORMATO DEL COSTO
        // ==========================================

        private void txtCosto_Leave(
            object sender,
            EventArgs e)
        {
            if (decimal.TryParse(
                txtCosto.Text,
                out decimal costo))
            {
                txtCosto.Text = costo.ToString("N0");
            }
        }

        // ==========================================
        // GUARDAR
        // ==========================================

        private void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            // -----------------------------
            // Vehículo
            // -----------------------------

            if (cbmVehiculo.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un vehículo.",
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // -----------------------------
            // Tipo de servicio
            // -----------------------------

            if (cbmTipoServicio.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un tipo de servicio.",
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // -----------------------------
            // Kilometraje
            // -----------------------------

            if (!int.TryParse(
                txtKilometraje.Text,
                out int kilometraje))
            {
                MessageBox.Show(
                    "Debe ingresar un kilometraje válido.",
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (kilometraje < 0)
            {
                MessageBox.Show(
                    "El kilometraje no puede ser negativo.",
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // -----------------------------
            // Costo
            // -----------------------------

            string textoCosto = txtCosto.Text
                .Replace(".", "")
                .Replace(",", ".");

            if (!decimal.TryParse(
                textoCosto,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out decimal costo))
            {
                MessageBox.Show(
                    "Ingrese un costo válido.",
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (costo < 0)
            {
                MessageBox.Show(
                    "El costo no puede ser negativo.",
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // -----------------------------
            // Crear servicio
            // -----------------------------

            Servicio servicio = new Servicio
            {
                VehiculoId =
                    Convert.ToInt32(cbmVehiculo.SelectedValue),

                TipoServicioId =
                    Convert.ToInt32(cbmTipoServicio.SelectedValue),

                Fecha = dtpFecha.Value,

                Kilometraje = kilometraje,

                Costo = costo,

                Descripcion =
                    txtDescripcion.Text.Trim()
            };

            // -----------------------------
            // Registrar
            // -----------------------------

            if (servicioNegocio.RegistrarServicio(
                servicio,
                out string mensaje))
            {
                MessageBox.Show(
                    mensaje,
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show(
                    mensaje,
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // ==========================================
        // CANCELAR
        // ==========================================

        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}