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
                $"Bienvenido, {Sesion.UsuarioActual.NombreUsuario}";

            int cantidadVehiculos =
                vehiculoNegocio
                .ObtenerVehiculosPorUsuario(
                    Sesion.UsuarioActual.Id)
                .Count;

            lblVehiculos.Text =
                $"🚗 Vehículos registrados: {cantidadVehiculos}";

            lblServicios.Text =
                "🔧 Servicios realizados: Próximamente";

            lblPendientes.Text =
                "⚠ Servicios pendientes: Próximamente";
        }

   //    private void frmDashboard_Load(object sender, EventArgs e)
     //   {
       //     pictureBox.Image= Image.FromFile(@"Assets\images\carchekImg1.jpg");
        //}
    }
}