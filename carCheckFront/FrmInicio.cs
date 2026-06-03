using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carCheckFront
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            Load += FrmInicio_Load;
        }

        private void FrmInicio_Load(object? sender, EventArgs e) => CentrarPanelPrincipal();

        private void FrmInicio_Resize(object? sender, EventArgs e) => CentrarPanelPrincipal();
        private void CentrarPanelPrincipal()
        {
            panel1.Left = (ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (ClientSize.Height - panel1.Height) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton iniciar sesion
            FrmLogin login = new FrmLogin();
            login.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //boton registrarse
            FrmRegistro registro = new FrmRegistro();
            registro.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
