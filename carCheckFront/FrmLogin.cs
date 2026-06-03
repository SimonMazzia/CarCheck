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

namespace carCheckFront
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            Load += FrmLogin_Load;
            Resize+= FrmLogin_Resize;


        }

        private void FrmLogin_Load(object? sender, EventArgs e) => CentrarPanel();
        private void FrmLogin_Resize(object? sender, EventArgs e) => CentrarPanel();
        private void CentrarPanel()
        {
            panel1.Left = (ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (ClientSize.Height - panel1.Height) / 2;

        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            Usuario user = usuarioNegocio.Login(email, password);
            Sesion.UsuarioActual = user;


            if (user != null)
            {
                FrmBienvenida frm1 = new FrmBienvenida();
                frm1.ShowDialog();
                FrmPrincipal frm = new FrmPrincipal(user);
                Hide();
                frm.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   

        private void btnCancelarVolverInicio_Click(object sender, EventArgs e)
        {
            Close();
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

            using (FrmRecuperarContrasena recuperar = new FrmRecuperarContrasena())
            {
                recuperar.ShowDialog(this);
            }

        }
    }
}
