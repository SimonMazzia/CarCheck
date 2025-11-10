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
            String email = textBox1.Text.Trim();
            String password = textBox2.Text.Trim();
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            Usuario user = usuarioNegocio.Login(email, password);


            if (user != null)
            {
                MessageBox.Show($"Bienvenido {user.NombreUsuario}");
                //new frmPrincipal(user).Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
        }
    }
}