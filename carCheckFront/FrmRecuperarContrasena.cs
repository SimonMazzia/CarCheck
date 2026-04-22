using carCheckBussines;

namespace carCheckFront
{
    public class FrmRecuperarContrasena : Form
    {
        private readonly TextBox txtEmail = new TextBox();
        private readonly TextBox txtNuevaContrasena = new TextBox();
        private readonly TextBox txtConfirmarContrasena = new TextBox();
        private readonly Button btnActualizar = new Button();
        private readonly Button btnCancelar = new Button();

        public FrmRecuperarContrasena()
        {
            Text = "Recuperar contraseña";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(420, 220);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            Label lblEmail = new Label { Text = "Correo:", AutoSize = true, Location = new Point(20, 25) };
            txtEmail.Location = new Point(170, 22);
            txtEmail.Size = new Size(220, 23);

            Label lblNueva = new Label { Text = "Nueva contraseña:", AutoSize = true, Location = new Point(20, 70) };
            txtNuevaContrasena.Location = new Point(170, 67);
            txtNuevaContrasena.Size = new Size(220, 23);
            txtNuevaContrasena.UseSystemPasswordChar = true;

            Label lblConfirmar = new Label { Text = "Confirmar contraseña:", AutoSize = true, Location = new Point(20, 110) };
            txtConfirmarContrasena.Location = new Point(170, 107);
            txtConfirmarContrasena.Size = new Size(220, 23);
            txtConfirmarContrasena.UseSystemPasswordChar = true;

            btnActualizar.Text = "Actualizar";
            btnActualizar.Location = new Point(170, 160);
            btnActualizar.Click += BtnActualizar_Click;

            btnCancelar.Text = "Cancelar";
            btnCancelar.Location = new Point(270, 160);
            btnCancelar.Click += (_, _) => Close();

            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblNueva);
            Controls.Add(txtNuevaContrasena);
            Controls.Add(lblConfirmar);
            Controls.Add(txtConfirmarContrasena);
            Controls.Add(btnActualizar);
            Controls.Add(btnCancelar);
        }

        private void BtnActualizar_Click(object? sender, EventArgs e)
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            bool ok = negocio.RecuperarContrasena(
                txtEmail.Text.Trim(),
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
    }
}
