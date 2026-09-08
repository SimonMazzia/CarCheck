namespace carCheckFront
{
    partial class FrmServicios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            cbmVehiculo = new ComboBox();
            label2 = new Label();
            cbmTipoServicio = new ComboBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            label4 = new Label();
            txtKilometraje = new TextBox();
            label5 = new Label();
            txtCosto = new TextBox();
            label6 = new Label();
            txtDescripcion = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtCosto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtKilometraje);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbmTipoServicio);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbmVehiculo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(35, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(736, 426);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 25);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Vehiculo (patente) *";
            // 
            // cbmVehiculo
            // 
            cbmVehiculo.FormattingEnabled = true;
            cbmVehiculo.Location = new Point(49, 43);
            cbmVehiculo.Name = "cbmVehiculo";
            cbmVehiculo.Size = new Size(249, 23);
            cbmVehiculo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 69);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo de servicio *";
            // 
            // cbmTipoServicio
            // 
            cbmTipoServicio.FormattingEnabled = true;
            cbmTipoServicio.Location = new Point(49, 87);
            cbmTipoServicio.Name = "cbmTipoServicio";
            cbmTipoServicio.Size = new Size(249, 23);
            cbmTipoServicio.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 113);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha de realizacion *";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(49, 131);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 157);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 6;
            label4.Text = "Kilometraje *";
            // 
            // txtKilometraje
            // 
            txtKilometraje.Location = new Point(49, 175);
            txtKilometraje.Name = "txtKilometraje";
            txtKilometraje.Size = new Size(121, 23);
            txtKilometraje.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 201);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 8;
            label5.Text = "Costo";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(49, 219);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(121, 23);
            txtCosto.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 245);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 10;
            label6.Text = "Observaciones";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(49, 263);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(236, 73);
            txtDescripcion.TabIndex = 11;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(130, 374);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(49, 374);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmServicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmServicios";
            Text = "FrmServicios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private ComboBox cbmTipoServicio;
        private Label label2;
        private ComboBox cbmVehiculo;
        private Label label1;
        private TextBox txtDescripcion;
        private Label label6;
        private TextBox txtCosto;
        private Label label5;
        private TextBox txtKilometraje;
        private Label label4;
        private DateTimePicker dtpFecha;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}