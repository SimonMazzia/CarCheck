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
            lblBienvenida.Text = $"Bienvenido/a a CarCheck.. Nos emociona tu llegada, {_usuario.NombreUsuario}";
            lblBienvenida.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            lblBienvenida.Visible = true;
            Timer timer = new Timer();
            timer.Interval = 5000; // 5 segundos
            timer.Tick += (s, ev) =>
            {
                lblBienvenida.Visible = false;
                timer.Stop();
            };
            timer.Start();
        }
    }
}

