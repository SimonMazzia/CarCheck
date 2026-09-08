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
        private readonly ServicioNegocio servicioNegocio = new ServicioNegocio();
        public FrmNuevoServicio()
        {
            InitializeComponent();
            Load += FrmNuevoServicio_Load;
        }

        private void CargarServicios() 
        {
            int usuarioId = Sesion.UsuarioActual.Id;
            dgvServicios.DataSource = null;
            dgvServicios.DataSource = servicioNegocio.ObtenerServiciosPorUsuario(usuarioId);

        }
        private void FrmNuevoServicio_Load(object sender, EventArgs e)
        {
            CargarServicios();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoServicio_Click(object sender, EventArgs e)
        {
            FrmServicios frmservicio= new FrmServicios();
            frmservicio.ShowDialog();
            CargarServicios();
        }
    }
}
