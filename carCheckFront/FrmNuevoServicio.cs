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
    public partial class FrmNuevoServicio : Form
    {
        private readonly ServicioNegocio servicioNegocio =
            new ServicioNegocio();

        // Colores utilizados en CarCheck
        private readonly Color colorAzul =
            Color.FromArgb(0, 122, 204);

        private readonly Color colorFondo =
            Color.FromArgb(239, 244, 250);

        private readonly Color colorGris =
            Color.FromArgb(52, 73, 94);

        public FrmNuevoServicio()
        {
            InitializeComponent();

            Load += FrmNuevoServicio_Load;

            ConfigurarFormulario();
            ConfigurarBotones();
            ConfigurarDgv();
        }

        // =========================================================
        // FORMULARIO
        // =========================================================
        private void ConfigurarFormulario()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            this.BackColor = colorFondo;

            this.FormBorderStyle = FormBorderStyle.Sizable;

            this.Padding = new Padding(0);
        }

        // =========================================================
        // BOTONES
        // =========================================================

        private void ConfigurarBotones()
        {
            // -------------------------
            // NUEVO
            // -------------------------

            btnNuevoServicio.Text = "＋  Nuevo servicio";

            btnNuevoServicio.BackColor = colorAzul;
            btnNuevoServicio.ForeColor = Color.White;

            btnNuevoServicio.FlatStyle = FlatStyle.Flat;
            btnNuevoServicio.FlatAppearance.BorderSize = 0;

            btnNuevoServicio.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            btnNuevoServicio.Cursor = Cursors.Hand;


            // -------------------------
            // MODIFICAR
            // -------------------------

            btnModificar.Text = "✎  Modificar";

            btnModificar.BackColor =
                Color.FromArgb(52, 73, 94);

            btnModificar.ForeColor = Color.White;

            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.FlatAppearance.BorderSize = 0;

            btnModificar.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            btnModificar.Cursor = Cursors.Hand;


            // -------------------------
            // ELIMINAR
            // -------------------------

            btnEliminar.Text = "🗑  Eliminar";

            btnEliminar.BackColor =
                Color.FromArgb(192, 57, 43);

            btnEliminar.ForeColor = Color.White;

            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderSize = 0;

            btnEliminar.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            btnEliminar.Cursor = Cursors.Hand;


            // -------------------------
            // VOLVER
            // -------------------------

            btnVolver.Text = "←  Volver";

            btnVolver.BackColor =
                Color.White;

            btnVolver.ForeColor =
                colorGris;

            btnVolver.FlatStyle =
                FlatStyle.Flat;

            btnVolver.FlatAppearance.BorderSize = 1;

            btnVolver.FlatAppearance.BorderColor =
                Color.FromArgb(210, 215, 220);

            btnVolver.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            btnVolver.Cursor = Cursors.Hand;
        }

        // =========================================================
        // DATAGRIDVIEW
        // =========================================================

        private void ConfigurarDgv()
        {
            dgvServicios.AutoGenerateColumns = true;

            dgvServicios.ReadOnly = true;

            dgvServicios.AllowUserToAddRows = false;
            dgvServicios.AllowUserToDeleteRows = false;

            dgvServicios.AllowUserToResizeRows = false;

            dgvServicios.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvServicios.MultiSelect = false;

            dgvServicios.RowHeadersVisible = false;

            dgvServicios.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvServicios.BackgroundColor =
                Color.White;

            dgvServicios.BorderStyle =
                BorderStyle.None;

            dgvServicios.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvServicios.GridColor =
                Color.FromArgb(225, 230, 235);

            // Encabezados

            dgvServicios.EnableHeadersVisualStyles = false;

            dgvServicios.ColumnHeadersDefaultCellStyle.BackColor =
                colorGris;

            dgvServicios.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvServicios.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvServicios.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvServicios.ColumnHeadersHeight = 40;

            // Filas

            dgvServicios.DefaultCellStyle.Font =
                new Font("Segoe UI", 9F);

            dgvServicios.DefaultCellStyle.ForeColor =
                Color.FromArgb(52, 73, 94);

            dgvServicios.DefaultCellStyle.BackColor =
                Color.White;

            dgvServicios.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 235, 248);

            dgvServicios.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(40, 60, 80);

            dgvServicios.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 250, 252);

            dgvServicios.RowTemplate.Height = 36;
        }

        // =========================================================
        // LOAD
        // =========================================================

        private void FrmNuevoServicio_Load(object sender, EventArgs e)
        {
            CargarServicios();
        }

        // =========================================================
        // CARGAR SERVICIOS
        // =========================================================

        private void CargarServicios()
        {
            int usuarioId =
                Sesion.UsuarioActual.Id;

            var servicios =
                servicioNegocio.ObtenerServiciosPorUsuario(usuarioId);

            // Creamos una vista específica para el DGV.
            // De esta manera NO mostramos las propiedades
            // de navegación de EF como:
            // carCheckEntities.TipoServicio
            // carCheckEntities.Vehiculo

            var datos =
                servicios.Select(s => new
                {
                    s.Id,

                    Fecha = s.Fecha,

                    Patente =
                        s.Vehiculo != null
                            ? s.Vehiculo.Patente
                            : "",

                    TipoServicio =
                        s.TipoServicio != null
                            ? s.TipoServicio.Nombre
                            : "",

                    Kilometraje =
                        s.Kilometraje,

                    Descripcion =
                        s.Descripcion,

                    Costo =
                        s.Costo

                }).ToList();

            dgvServicios.DataSource = null;

            dgvServicios.DataSource = datos;

            ConfigurarColumnas();
        }

        // =========================================================
        // CONFIGURAR COLUMNAS
        // =========================================================

        private void ConfigurarColumnas()
        {
            if (dgvServicios.Columns.Count == 0)
                return;

            // ID
            if (dgvServicios.Columns["Id"] != null)
            {
                dgvServicios.Columns["Id"].Visible = false;
            }

            // FECHA
            if (dgvServicios.Columns["Fecha"] != null)
            {
                dgvServicios.Columns["Fecha"].HeaderText =
                    "Fecha";

                dgvServicios.Columns["Fecha"]
                    .DefaultCellStyle.Format =
                    "dd/MM/yyyy";
            }

            // PATENTE
            if (dgvServicios.Columns["Patente"] != null)
            {
                dgvServicios.Columns["Patente"].HeaderText =
                    "Patente";

                dgvServicios.Columns["Patente"]
                    .DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }

            // TIPO DE SERVICIO
            if (dgvServicios.Columns["TipoServicio"] != null)
            {
                dgvServicios.Columns["TipoServicio"].HeaderText =
                    "Tipo de servicio";
            }

            // KILOMETRAJE
            if (dgvServicios.Columns["Kilometraje"] != null)
            {
                dgvServicios.Columns["Kilometraje"].HeaderText =
                    "Kilometraje";

                dgvServicios.Columns["Kilometraje"]
                    .DefaultCellStyle.Format =
                    "N0";

                dgvServicios.Columns["Kilometraje"]
                    .DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }

            // DESCRIPCIÓN
            if (dgvServicios.Columns["Descripcion"] != null)
            {
                dgvServicios.Columns["Descripcion"].HeaderText =
                    "Descripción";
            }

            // COSTO
            if (dgvServicios.Columns["Costo"] != null)
            {
                dgvServicios.Columns["Costo"].HeaderText =
                    "Costo";

                dgvServicios.Columns["Costo"]
                    .DefaultCellStyle.Format =
                    "N0";

                dgvServicios.Columns["Costo"]
                    .DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }
        }

        // =========================================================
        // NUEVO SERVICIO
        // =========================================================

        private void btnNuevoServicio_Click(
            object sender,
            EventArgs e)
        {
            FrmServicios frmservicio =
                new FrmServicios();

            frmservicio.ShowDialog();

            // Actualizamos el listado después de cerrar
            // el formulario de alta.

            CargarServicios();
        }

        // =========================================================
        // MODIFICAR SERVICIO
        // =========================================================

        private void btnModificar_Click(
            object sender,
            EventArgs e)
        {
            if (dgvServicios.CurrentRow == null)
            {
                MessageBox.Show(
                    "Debe seleccionar un servicio.",
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int servicioId =
                Convert.ToInt32(
                    dgvServicios.CurrentRow
                        .Cells["Id"]
                        .Value);

            MessageBox.Show(
                "Servicio seleccionado: " +
                servicioId +
                "\n\nLa modificación se implementará en HU02.",
                "CarCheck",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================================================
        // ELIMINAR SERVICIO
        // =========================================================

        private void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            if (dgvServicios.CurrentRow == null)
            {
                MessageBox.Show(
                    "Debe seleccionar un servicio.",
                    "CarCheck",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int servicioId =
                Convert.ToInt32(
                    dgvServicios.CurrentRow
                        .Cells["Id"]
                        .Value);

            DialogResult resultado =
                MessageBox.Show(
                    "¿Está seguro de que desea eliminar este servicio?",
                    "CarCheck",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes)
                return;

            // La eliminación lógica se implementará
            // cuando trabajemos HU04.

            MessageBox.Show(
                "Servicio seleccionado: " +
                servicioId +
                "\n\nLa eliminación lógica se implementará en HU04.",
                "CarCheck",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================================================
        // VOLVER
        // =========================================================

        private void btnVolver_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        // =========================================================
        // EVENTOS DEL DISEÑADOR
        // =========================================================

        private void label2_Click(
            object sender,
            EventArgs e)
        {
        }

        private void dgvServicios_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}