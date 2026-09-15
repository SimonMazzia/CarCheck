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
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            labelTitulo = new Label();
            btnVolver = new Button();

            panel2 = new Panel();

            labelVehiculo = new Label();
            cbmVehiculo = new ComboBox();

            labelTipoServicio = new Label();
            cbmTipoServicio = new ComboBox();

            labelFecha = new Label();
            dtpFecha = new DateTimePicker();

            labelKilometraje = new Label();
            txtKilometraje = new TextBox();

            labelCosto = new Label();
            txtCosto = new TextBox();

            labelDescripcion = new Label();
            txtDescripcion = new TextBox();

            btnGuardar = new Button();
            btnCancelar = new Button();

            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();

            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(labelTitulo);
            panel1.Controls.Add(btnVolver);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 70);
            panel1.TabIndex = 0;

            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font(
                "Segoe UI",
                18F,
                FontStyle.Bold,
                GraphicsUnit.Point,
                0);

            labelTitulo.ForeColor = Color.White;

            labelTitulo.Location = new Point(20, 18);

            labelTitulo.Name = "labelTitulo";

            labelTitulo.Size = new Size(300, 32);

            labelTitulo.TabIndex = 0;

            labelTitulo.Text = "Nuevo servicio técnico";

            // 
            // btnVolver
            // 
            btnVolver.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Right;

            btnVolver.BackColor = Color.White;

            btnVolver.FlatAppearance.BorderSize = 0;

            btnVolver.FlatStyle = FlatStyle.Flat;

            btnVolver.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            btnVolver.ForeColor =
                Color.FromArgb(52, 73, 94);

            btnVolver.Location =
                new Point(730, 16);

            btnVolver.Name =
                "btnVolver";

            btnVolver.Size =
                new Size(100, 38);

            btnVolver.TabIndex =
                1;

            btnVolver.Text =
                "←  Volver";

            btnVolver.UseVisualStyleBackColor =
                false;

            btnVolver.Click +=
                btnCancelar_Click;

            // 
            // panel2
            // 
            panel2.BackColor =
                Color.White;

            panel2.Controls.Add(labelVehiculo);
            panel2.Controls.Add(cbmVehiculo);

            panel2.Controls.Add(labelTipoServicio);
            panel2.Controls.Add(cbmTipoServicio);

            panel2.Controls.Add(labelFecha);
            panel2.Controls.Add(dtpFecha);

            panel2.Controls.Add(labelKilometraje);
            panel2.Controls.Add(txtKilometraje);

            panel2.Controls.Add(labelCosto);
            panel2.Controls.Add(txtCosto);

            panel2.Controls.Add(labelDescripcion);
            panel2.Controls.Add(txtDescripcion);

            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnCancelar);

            panel2.Location =
                new Point(40, 95);

            panel2.Name =
                "panel2";

            panel2.Size =
                new Size(770, 480);

            panel2.TabIndex =
                1;

            // 
            // labelVehiculo
            // 
            labelVehiculo.AutoSize = true;

            labelVehiculo.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            labelVehiculo.ForeColor =
                Color.FromArgb(52, 73, 94);

            labelVehiculo.Location =
                new Point(35, 30);

            labelVehiculo.Name =
                "labelVehiculo";

            labelVehiculo.Size =
                new Size(58, 15);

            labelVehiculo.Text =
                "Vehículo";

            // 
            // cbmVehiculo
            // 
            cbmVehiculo.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cbmVehiculo.Font =
                new Font(
                    "Segoe UI",
                    10F);

            cbmVehiculo.FormattingEnabled = true;

            cbmVehiculo.Location =
                new Point(35, 50);

            cbmVehiculo.Name =
                "cbmVehiculo";

            cbmVehiculo.Size =
                new Size(300, 25);

            cbmVehiculo.TabIndex =
                2;

            cbmVehiculo.SelectedIndexChanged +=
                cbmVehiculo_SelectedIndexChanged;

            // 
            // labelTipoServicio
            // 
            labelTipoServicio.AutoSize = true;

            labelTipoServicio.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            labelTipoServicio.ForeColor =
                Color.FromArgb(52, 73, 94);

            labelTipoServicio.Location =
                new Point(390, 30);

            labelTipoServicio.Name =
                "labelTipoServicio";

            labelTipoServicio.Size =
                new Size(101, 15);

            labelTipoServicio.Text =
                "Tipo de servicio";

            // 
            // cbmTipoServicio
            // 
            cbmTipoServicio.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cbmTipoServicio.Font =
                new Font(
                    "Segoe UI",
                    10F);

            cbmTipoServicio.FormattingEnabled = true;

            cbmTipoServicio.Location =
                new Point(390, 50);

            cbmTipoServicio.Name =
                "cbmTipoServicio";

            cbmTipoServicio.Size =
                new Size(335, 25);

            cbmTipoServicio.TabIndex =
                3;

            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;

            labelFecha.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            labelFecha.ForeColor =
                Color.FromArgb(52, 73, 94);

            labelFecha.Location =
                new Point(35, 105);

            labelFecha.Name =
                "labelFecha";

            labelFecha.Size =
                new Size(37, 15);

            labelFecha.Text =
                "Fecha";

            // 
            // dtpFecha
            // 
            dtpFecha.Font =
                new Font(
                    "Segoe UI",
                    10F);

            dtpFecha.Format =
                DateTimePickerFormat.Short;

            dtpFecha.Location =
                new Point(35, 125);

            dtpFecha.Name =
                "dtpFecha";

            dtpFecha.Size =
                new Size(180, 25);

            dtpFecha.TabIndex =
                4;

            // 
            // labelKilometraje
            // 
            labelKilometraje.AutoSize = true;

            labelKilometraje.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            labelKilometraje.ForeColor =
                Color.FromArgb(52, 73, 94);

            labelKilometraje.Location =
                new Point(250, 105);

            labelKilometraje.Name =
                "labelKilometraje";

            labelKilometraje.Size =
                new Size(79, 15);

            labelKilometraje.Text =
                "Kilometraje";

            // 
            // txtKilometraje
            // 
            txtKilometraje.Font =
                new Font(
                    "Segoe UI",
                    10F);

            txtKilometraje.Location =
                new Point(250, 125);

            txtKilometraje.Name =
                "txtKilometraje";

            txtKilometraje.Size =
                new Size(180, 25);

            txtKilometraje.TabIndex =
                5;

            txtKilometraje.TextChanged +=
                txtKilometraje_TextChanged;

            // 
            // labelCosto
            // 
            labelCosto.AutoSize = true;

            labelCosto.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            labelCosto.ForeColor =
                Color.FromArgb(52, 73, 94);

            labelCosto.Location =
                new Point(465, 105);

            labelCosto.Name =
                "labelCosto";

            labelCosto.Size =
                new Size(39, 15);

            labelCosto.Text =
                "Costo";

            // 
            // txtCosto
            // 
            txtCosto.Font =
                new Font(
                    "Segoe UI",
                    10F);

            txtCosto.Location =
                new Point(465, 125);

            txtCosto.Name =
                "txtCosto";

            txtCosto.Size =
                new Size(260, 25);

            txtCosto.TabIndex =
                6;

            txtCosto.Leave +=
                txtCosto_Leave;

            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;

            labelDescripcion.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            labelDescripcion.ForeColor =
                Color.FromArgb(52, 73, 94);

            labelDescripcion.Location =
                new Point(35, 180);

            labelDescripcion.Name =
                "labelDescripcion";

            labelDescripcion.Size =
                new Size(76, 15);

            labelDescripcion.Text =
                "Descripción";

            // 
            // txtDescripcion
            // 
            txtDescripcion.Font =
                new Font(
                    "Segoe UI",
                    10F);

            txtDescripcion.Location =
                new Point(35, 202);

            txtDescripcion.Multiline = true;

            txtDescripcion.Name =
                "txtDescripcion";

            txtDescripcion.ScrollBars =
                ScrollBars.Vertical;

            txtDescripcion.Size =
                new Size(690, 120);

            txtDescripcion.TabIndex =
                7;

            // 
            // btnGuardar
            // 
            btnGuardar.BackColor =
                Color.FromArgb(0, 122, 204);

            btnGuardar.FlatAppearance.BorderSize =
                0;

            btnGuardar.FlatStyle =
                FlatStyle.Flat;

            btnGuardar.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            btnGuardar.ForeColor =
                Color.White;

            btnGuardar.Location =
                new Point(435, 375);

            btnGuardar.Name =
                "btnGuardar";

            btnGuardar.Size =
                new Size(130, 40);

            btnGuardar.TabIndex =
                8;

            btnGuardar.Text =
                "✓  Guardar";

            btnGuardar.UseVisualStyleBackColor =
                false;

            btnGuardar.Click +=
                btnGuardar_Click;

            // 
            // btnCancelar
            // 
            btnCancelar.BackColor =
                Color.White;

            btnCancelar.FlatAppearance.BorderColor =
                Color.FromArgb(210, 215, 220);

            btnCancelar.FlatAppearance.BorderSize =
                1;

            btnCancelar.FlatStyle =
                FlatStyle.Flat;

            btnCancelar.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            btnCancelar.ForeColor =
                Color.FromArgb(52, 73, 94);

            btnCancelar.Location =
                new Point(585, 375);

            btnCancelar.Name =
                "btnCancelar";

            btnCancelar.Size =
                new Size(140, 40);

            btnCancelar.TabIndex =
                9;

            btnCancelar.Text =
                "Cancelar";

            btnCancelar.UseVisualStyleBackColor =
                false;

            btnCancelar.Click +=
                btnCancelar_Click;

            // 
            // FrmServicios
            // 
            AutoScaleDimensions =
                new SizeF(7F, 15F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.FromArgb(239, 244, 250);

            ClientSize =
                new Size(850, 620);

            Controls.Add(panel2);
            Controls.Add(panel1);

            MinimumSize =
                new Size(850, 620);

            Name =
                "FrmServicios";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "CarCheck - Nuevo servicio";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();

            panel2.ResumeLayout(false);
            panel2.PerformLayout();

            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelTitulo;
        private Button btnVolver;

        private Panel panel2;

        private Label labelVehiculo;
        private ComboBox cbmVehiculo;

        private Label labelTipoServicio;
        private ComboBox cbmTipoServicio;

        private Label labelFecha;
        private DateTimePicker dtpFecha;

        private Label labelKilometraje;
        private TextBox txtKilometraje;

        private Label labelCosto;
        private TextBox txtCosto;

        private Label labelDescripcion;
        private TextBox txtDescripcion;

        private Button btnGuardar;
        private Button btnCancelar;
    }
}