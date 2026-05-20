using carCheckBussines;
using carCheckEntities;
using carCheckServicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace carCheckFront
{
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();
            Load += frmVehiculos_Load;
        }
        private readonly VehiculoNegocio vehiculoNegocio = new VehiculoNegocio();

        private int vehiculosSeleccionadoId = 0;

        private void frmVehiculos_Load(object sender, EventArgs e)
        {

        }

        private void panelFormulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow fila = dgvVehiculos.Rows[e.RowIndex];
            vehiculosSeleccionadoId = Convert.ToInt32(fila.Cells["Id"].Value);
            txtMarca.Text = fila.Cells["Marca"].Value.ToString();
            txtModelo.Text = fila.Cells["Modelo"].Value.ToString();
            txtPatente.Text = fila.Cells["Patente"].Value.ToString();
            numericUpDownAnio.Value = Convert.ToDecimal(fila.Cells["Anio"].Value);
            numericUpDownKm.Value = Convert.ToDecimal(fila.Cells["Kilometraje"].Value);

        }
        private void LimpiarCampos()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtPatente.Clear();
            numericUpDownAnio.Value = numericUpDownAnio.Minimum;
            numericUpDownKm.Value = numericUpDownKm.Minimum;
        }
        private void CargarVehiculos()
        {
            int usuarioId = Sesion.UsuarioActual.Id;

            dgvVehiculos.DataSource = null;

            dgvVehiculos.DataSource =
                vehiculoNegocio
                .ObtenerVehiculosPorUsuario(usuarioId);

            dgvVehiculos.Columns["Usuario"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo = new Vehiculo()
            {
                Marca = txtMarca.Text.Trim(),
                Modelo = txtModelo.Text.Trim(),
                Patente = txtPatente.Text.Trim(),
                Anio = (int)numericUpDownAnio.Value,
                Kilometraje = (int)numericUpDownKm.Value,

                UsuarioId = Sesion.UsuarioActual.Id
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

        private void btnModificar_Click(object sender, EventArgs e)
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

                Patente = txtPatente.Text.Trim(),

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

        private void btnEliminar_Click(object sender, EventArgs e)
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
    }
}
