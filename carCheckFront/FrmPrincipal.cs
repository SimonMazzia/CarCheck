using carCheckEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace carCheckFront
{
    public partial class FrmPrincipal : Form
    {
        private Usuario _usuario;

        public FrmPrincipal(Usuario usuario)

        {
            InitializeComponent();
            _usuario = usuario;
            this.Load += FrmPrincipal_Load;

        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormulario(
            new FrmDashboard());

        }

        private void FrmPrincipal_Load_1(object sender, EventArgs e)
        {

        }

        private void btnVehiculos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(
            new frmVehiculos());


        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormulario(Form formulario)
        {
            panelContenedor.Controls.Clear();

            formulario.TopLevel = false;

            formulario.FormBorderStyle =
                FormBorderStyle.None;

            formulario.Dock = DockStyle.Fill;   

            panelContenedor.Controls.Add(formulario);

            formulario.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

