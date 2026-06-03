using carCheckBussines;
using carCheckServicios;
using System.Windows.Forms;

namespace carCheckFront
{
    public partial class FrmDashboard : Form
    {
        private readonly VehiculoNegocio vehiculoNegocio =
            new VehiculoNegocio();

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
            pictureBox1.Image =
                Image.FromFile(
                    @"C:\Users\simon\OneDrive\Desktop\carchekImg1.jpg");
        }

        private void CargarDatos()
        {
            lblBienvenida.Text =
                $"Hola de nuevo! , {Sesion.UsuarioActual.NombreUsuario}";

            int cantidadVehiculos =
                vehiculoNegocio
                .ObtenerVehiculosPorUsuario(
                    Sesion.UsuarioActual.Id)
                .Count;

            lblCantidadVehiculos.Text =
                $"{cantidadVehiculos}";

            lblCantidadServicios.Text =
                "🔧3";

            lblCantidadPendientes.Text =
                "⚠2";
        }

        private void lblSubtitulo_Click(object sender, EventArgs e)
        {

        }

        private void panelDashboardTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}