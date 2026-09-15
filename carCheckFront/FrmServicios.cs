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

        // ID del servicio que estamos modificando.
        // Si es null, estamos creando uno nuevo.
        private int? servicioId;

        public FrmServicios(int? servicioId = null)
        {
            InitializeComponent();

            this.servicioId = servicioId;

            Load += FrmServicios_Load;
        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {
            CargarVehiculos();
            CargarTiposServicio();

            if (servicioId.HasValue)
            {
                CargarServicioParaModificar();
            }
        }

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

        private void CargarTiposServicio()
        {
            cbmTipoServicio.DataSource = null;

            cbmTipoServicio.DataSource =
                tipoServicioNegocio.ObtenerTodos();

            cbmTipoServicio.DisplayMember = "Nombre";
            cbmTipoServicio.ValueMember = "Id";
            cbmTipoServicio.SelectedIndex = -1;
        }

        private void CargarServicioParaModificar()
        {
            Servicio servicio =
                servicioNegocio.ObtenerPorId(servicioId.Value);

            if (servicio == null)
            {
                MessageBox.Show(
                    "No se encontró el servicio seleccionado.",
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.Close();
                return;
            }

            // Cargamos los datos en los controles.

            cbmVehiculo.SelectedValue =
                servicio.VehiculoId;

            cbmTipoServicio.SelectedValue =
                servicio.TipoServicioId;

            dtpFecha.Value =
                servicio.Fecha;

            txtKilometraje.Text =
                servicio.Kilometraje.ToString();

            txtCosto.Text =
                servicio.Costo.ToString("N0");

            txtDescripcion.Text =
                servicio.Descripcion;

            // Cambiamos el título del formulario.
            labelTitulo.Text = "Modificar servicio técnico";

            // Cambiamos el texto del botón.
            btnGuardar.Text = "Guardar cambios";
        }

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

        private void txtCosto_Leave(
            object sender,
            EventArgs e)
        {
            if (decimal.TryParse(txtCosto.Text, out decimal costo))
            {
                txtCosto.Text = costo.ToString("N0");
            }
        }

        private void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            // -----------------------------
            // VALIDAR VEHÍCULO
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
            // VALIDAR TIPO DE SERVICIO
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
            // VALIDAR KILOMETRAJE
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
            // VALIDAR COSTO
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
            // CREAR OBJETO SERVICIO
            // -----------------------------

            Servicio servicio = new Servicio
            {
                VehiculoId =
                    Convert.ToInt32(cbmVehiculo.SelectedValue),

                TipoServicioId =
                    Convert.ToInt32(cbmTipoServicio.SelectedValue),

                Fecha =
                    dtpFecha.Value,

                Kilometraje =
                    kilometraje,

                Costo =
                    costo,

                Descripcion =
                    txtDescripcion.Text.Trim()
            };

            // -----------------------------
            // MODIFICAR
            // -----------------------------

            if (servicioId.HasValue)
            {
                servicio.Id = servicioId.Value;

                if (servicioNegocio.ModificarServicio(
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

                return;
            }

            // -----------------------------
            // REGISTRAR NUEVO
            // -----------------------------

            if (servicioNegocio.RegistrarServicio(
                servicio,
                out string mensajeRegistro))
            {
                MessageBox.Show(
                    mensajeRegistro,
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show(
                    mensajeRegistro,
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }
    }
}