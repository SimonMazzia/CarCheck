using carCheckBussines;

namespace carCheckFront
{
    public partial class FrmRecuperarContrasena : Form
    {
      public FrmRecuperarContrasena()
        {
            InitializeComponent();
        }

        private void BtnActualizar_Click(object? sender, EventArgs e)
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            bool ok = negocio.RecuperarContrasena(
                txtEmail.Text.Trim(),
                txtPin.Text, 
                txtNuevaContrasena.Text,
                txtConfirmarContrasena.Text,
                out string mensaje);

            if (ok)
            {
                MessageBox.Show(mensaje, "Recuperación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            MessageBox.Show(mensaje, "Recuperación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}