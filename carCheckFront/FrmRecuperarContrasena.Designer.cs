using System.Drawing;
using System.Windows.Forms;

namespace carCheckFront
{
    partial class FrmRecuperarContrasena
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panel1;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblEmail;
        private Label lblPin;
        private Label lblNueva;
        private Label lblConfirmar;
        private TextBox txtEmail;
        private TextBox txtPin;
        private TextBox txtNuevaContrasena;
        private TextBox txtConfirmarContrasena;
        private Button btnActualizar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            lblEmail = new Label();
            lblPin = new Label();
            lblNueva = new Label();
            lblConfirmar = new Label();
            txtEmail = new TextBox();
            txtPin = new TextBox();
            txtNuevaContrasena = new TextBox();
            txtConfirmarContrasena = new TextBox();
            btnActualizar = new Button();
            btnCancelar = new Button();

            panel1.SuspendLayout();
            SuspendLayout();

            // panel1
            panel1.BackColor = Color.FromArgb(24, 34, 46);
            panel1.Dock = DockStyle.Fill;
            panel1.Padding = new Padding(20);

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 20);
            lblTitulo.Text = "Recuperar contraseña";

            // lblSubtitulo
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(181, 195, 211);
            lblSubtitulo.Location = new Point(24, 55);
            lblSubtitulo.Text = "Actualizá tu contraseña de forma segura";

            // lblEmail
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(24, 95);
            lblEmail.Text = "Correo:";

            // txtEmail
            txtEmail.BackColor = Color.FromArgb(239, 244, 250);
            txtEmail.Location = new Point(174, 94);
            txtEmail.Size = new Size(260, 23);

            // lblPin
            lblPin.AutoSize = true;
            lblPin.Font = new Font("Segoe UI", 10F);
            lblPin.ForeColor = Color.White;
            lblPin.Location = new Point(24, 136);
            lblPin.Text = "PIN de seguridad:";

            // txtPin
            txtPin.BackColor = Color.FromArgb(239, 244, 250);
            txtPin.Location = new Point(174, 135);
            txtPin.Size = new Size(260, 23);
            txtPin.UseSystemPasswordChar = true;

            // lblNueva
            lblNueva.AutoSize = true;
            lblNueva.Font = new Font("Segoe UI", 10F);
            lblNueva.ForeColor = Color.White;
            lblNueva.Location = new Point(24, 176);
            lblNueva.Text = "Nueva contraseña:";

            // txtNuevaContrasena
            txtNuevaContrasena.BackColor = Color.FromArgb(239, 244, 250);
            txtNuevaContrasena.Location = new Point(174, 175);
            txtNuevaContrasena.Size = new Size(260, 23);
            txtNuevaContrasena.UseSystemPasswordChar = true;

            // lblConfirmar
            lblConfirmar.AutoSize = true;
            lblConfirmar.Font = new Font("Segoe UI", 10F);
            lblConfirmar.ForeColor = Color.White;
            lblConfirmar.Location = new Point(24, 216);
            lblConfirmar.Text = "Confirmar contraseña:";

            // txtConfirmarContrasena
            txtConfirmarContrasena.BackColor = Color.FromArgb(239, 244, 250);
            txtConfirmarContrasena.Location = new Point(174, 215);
            txtConfirmarContrasena.Size = new Size(260, 23);
            txtConfirmarContrasena.UseSystemPasswordChar = true;

            // btnActualizar
            btnActualizar.BackColor = Color.FromArgb(0, 122, 204);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(230, 250);
            btnActualizar.Size = new Size(98, 32);
            btnActualizar.Text = "Actualizar";
            btnActualizar.Click += BtnActualizar_Click;

            // btnCancelar
            btnCancelar.BackColor = Color.FromArgb(52, 73, 94);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(336, 250);
            btnCancelar.Size = new Size(98, 32);
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;

            // agregar controles
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(lblSubtitulo);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblPin);
            panel1.Controls.Add(txtPin);
            panel1.Controls.Add(lblNueva);
            panel1.Controls.Add(txtNuevaContrasena);
            panel1.Controls.Add(lblConfirmar);
            panel1.Controls.Add(txtConfirmarContrasena);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnCancelar);

            // form
            ClientSize = new Size(460, 320);
            Controls.Add(panel1);
            Text = "CarCheck - Recuperar contraseña";
            StartPosition = FormStartPosition.CenterScreen;

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }
    }
}