namespace carCheckFront
{
    partial class FrmRecuperarContrasena
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Panel panel1;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblEmail;
        private Label lblNueva;
        private Label lblConfirmar;
        private TextBox txtEmail;
        private TextBox txtNuevaContrasena;
        private TextBox txtConfirmarContrasena;
        private Button btnActualizar;
        private Button btnCancelar;
        private Label lblPin;
        private TextBox txtPin;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            lblEmail = new Label();
            lblNueva = new Label();
            lblConfirmar = new Label();
            txtEmail = new TextBox();
            txtPin = new TextBox();
            txtNuevaContrasena = new TextBox();
            lblPin = new Label();
            txtConfirmarContrasena = new TextBox();
            btnActualizar = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 34, 46);
            panel1.Controls.Add(lblSubtitulo);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblNueva);
            panel1.Controls.Add(lblConfirmar);
            panel1.Controls.Add(txtPin);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblPin);
            panel1.Controls.Add(txtNuevaContrasena);
            panel1.Controls.Add(txtConfirmarContrasena);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnCancelar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(460, 290);
            panel1.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(181, 195, 211);
            lblSubtitulo.Location = new Point(24, 50);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(250, 15);
            lblSubtitulo.TabIndex = 9;
            lblSubtitulo.Text = "Actualizá tu contraseña de forma segura";
            // 
            // 
            // lblPin
            // 
            
            lblPin.AutoSize = true;
            lblPin.Font = new Font("Segoe UI", 10F);
            lblPin.ForeColor = Color.White;
            lblPin.Location = new Point(24, 140); // ajustá según tu layout
            lblPin.Name = "labelPin";
            lblPin.Size = new Size(110, 19);
            lblPin.TabIndex = 3;
            lblPin.Text = "PIN de seguridad:";
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(24, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(237, 30);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Recuperar contraseña";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(24, 95);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 19);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Correo:";
            // 
            // lblNueva
            // 
            lblNueva.AutoSize = true;
            lblNueva.Font = new Font("Segoe UI", 10F);
            lblNueva.ForeColor = Color.White;
            lblNueva.Location = new Point(24, 136);
            lblNueva.Name = "lblNueva";
            lblNueva.Size = new Size(116, 19);
            lblNueva.TabIndex = 1;
            lblNueva.Text = "Nueva contraseña:";
            // 
            // 
            // textBoxPin
            // 
            txtPin = new TextBox();
            txtPin.BackColor = Color.FromArgb(239, 244, 250);
            txtPin.Location = new Point(159, 140);
            txtPin.Name = "textBoxPin";
            txtPin.Size = new Size(180, 23);
            txtPin.TabIndex = 4;
            txtPin.UseSystemPasswordChar = true;
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Font = new Font("Segoe UI", 10F);
            lblConfirmar.ForeColor = Color.White;
            lblConfirmar.Location = new Point(24, 177);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(135, 19);
            lblConfirmar.TabIndex = 2;
            lblConfirmar.Text = "Confirmar contraseña:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(239, 244, 250);
            txtEmail.Location = new Point(174, 94);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtNuevaContrasena
            // 
            txtNuevaContrasena.BackColor = Color.FromArgb(239, 244, 250);
            txtNuevaContrasena.Location = new Point(174, 135);
            txtNuevaContrasena.Name = "txtNuevaContrasena";
            txtNuevaContrasena.Size = new Size(260, 23);
            txtNuevaContrasena.TabIndex = 4;
            txtNuevaContrasena.UseSystemPasswordChar = true;
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.BackColor = Color.FromArgb(239, 244, 250);
            txtConfirmarContrasena.Location = new Point(174, 176);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Size = new Size(260, 23);
            txtConfirmarContrasena.TabIndex = 5;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(0, 122, 204);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(230, 226);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(98, 32);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += BtnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(52, 73, 94);
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(106, 125, 143);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(336, 226);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 32);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += (_, _) => Close();
            // 
            // FrmRecuperarContrasena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 232, 241);
            ClientSize = new Size(460, 290);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRecuperarContrasena";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CarCheck - Recuperar contraseña";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}