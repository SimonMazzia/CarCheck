using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace carCheckFront
{
    partial class FrmRecuperarContrasena
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label lblEmail;
        private Label lblNueva;
        private Label lblConfirmar;
        private TextBox txtEmail;
        private TextBox txtNuevaContrasena;
        private TextBox txtConfirmarContrasena;
        private Button btnActualizar;
        private Button btnCancelar;

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
            lblEmail = new Label();
            lblNueva = new Label();
            lblConfirmar = new Label();
            txtEmail = new TextBox();
            txtNuevaContrasena = new TextBox();
            txtConfirmarContrasena = new TextBox();
            btnActualizar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 25);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Correo:";
            // 
            // lblNueva
            // 
            lblNueva.AutoSize = true;
            lblNueva.Location = new Point(20, 70);
            lblNueva.Name = "lblNueva";
            lblNueva.Size = new Size(106, 15);
            lblNueva.TabIndex = 1;
            lblNueva.Text = "Nueva contraseña:";
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Location = new Point(20, 110);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(123, 15);
            lblConfirmar.TabIndex = 2;
            lblConfirmar.Text = "Confirmar contraseña:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(170, 22);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtNuevaContrasena
            // 
            txtNuevaContrasena.Location = new Point(170, 67);
            txtNuevaContrasena.Name = "txtNuevaContrasena";
            txtNuevaContrasena.Size = new Size(220, 23);
            txtNuevaContrasena.TabIndex = 4;
            txtNuevaContrasena.UseSystemPasswordChar = true;
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Location = new Point(170, 107);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Size = new Size(220, 23);
            txtConfirmarContrasena.TabIndex = 5;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(170, 160);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 23);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += BtnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(300, 160);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += (_, _) => Close();
            // 
            // FrmRecuperarContrasena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 220);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(txtConfirmarContrasena);
            Controls.Add(txtNuevaContrasena);
            Controls.Add(txtEmail);
            Controls.Add(lblConfirmar);
            Controls.Add(lblNueva);
            Controls.Add(lblEmail);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRecuperarContrasena";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Recuperar contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}