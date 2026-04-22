using carCheckBussines;
using carCheckEntities;

namespace carCheckFront
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
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

            if (user != null)
            {
                MessageBox.Show($"Bienvenido {user.NombreUsuario}");
                FrmPrincipal frm = new FrmPrincipal(user);
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using FrmRecuperarContrasena formRecuperar = new FrmRecuperarContrasena();
            formRecuperar.ShowDialog(this);
        }
    }
}
