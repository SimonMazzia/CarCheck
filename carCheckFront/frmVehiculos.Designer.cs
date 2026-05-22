namespace carCheckFront
{
    partial class frmVehiculos
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
            panelTop = new Panel();
            label1 = new Label();
            panelFormulario = new Panel();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            numericUpDownKm = new NumericUpDown();
            numericUpDownAnio = new NumericUpDown();
            txtPatente = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            lblKilometraje = new Label();
            lblAño = new Label();
            lblPatente = new Label();
            lblModelo = new Label();
            lblMarca = new Label();
            panelTabla = new Panel();
            dgvVehiculos = new DataGridView();
            panelTop.SuspendLayout();
            panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnio).BeginInit();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(0, 122, 204);
            panelTop.Controls.Add(label1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1403, 60);
            panelTop.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(251, 32);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Vehículos";
            // 
            // panelFormulario
            // 
            panelFormulario.BackColor = Color.White;
            panelFormulario.Controls.Add(btnLimpiar);
            panelFormulario.Controls.Add(btnEliminar);
            panelFormulario.Controls.Add(btnModificar);
            panelFormulario.Controls.Add(btnAgregar);
            panelFormulario.Controls.Add(numericUpDownKm);
            panelFormulario.Controls.Add(numericUpDownAnio);
            panelFormulario.Controls.Add(txtPatente);
            panelFormulario.Controls.Add(txtModelo);
            panelFormulario.Controls.Add(txtMarca);
            panelFormulario.Controls.Add(lblKilometraje);
            panelFormulario.Controls.Add(lblAño);
            panelFormulario.Controls.Add(lblPatente);
            panelFormulario.Controls.Add(lblModelo);
            panelFormulario.Controls.Add(lblMarca);
            panelFormulario.Dock = DockStyle.Top;
            panelFormulario.Location = new Point(0, 60);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(1403, 180);
            panelFormulario.TabIndex = 3;
            panelFormulario.Paint += panelFormulario_Paint;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Silver;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(840, 75);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 38);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(840, 25);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 38);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(64, 64, 64);
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(700, 75);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 38);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 122, 204);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(700, 25);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 38);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // numericUpDownKm
            // 
            numericUpDownKm.Location = new Point(120, 126);
            numericUpDownKm.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownKm.Name = "numericUpDownKm";
            numericUpDownKm.Size = new Size(120, 23);
            numericUpDownKm.TabIndex = 11;
            numericUpDownKm.ThousandsSeparator = true;
            // 
            // numericUpDownAnio
            // 
            numericUpDownAnio.Location = new Point(430, 73);
            numericUpDownAnio.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numericUpDownAnio.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            numericUpDownAnio.Name = "numericUpDownAnio";
            numericUpDownAnio.Size = new Size(120, 23);
            numericUpDownAnio.TabIndex = 10;
            numericUpDownAnio.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(430, 28);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(180, 23);
            txtPatente.TabIndex = 7;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(120, 73);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(180, 23);
            txtModelo.TabIndex = 6;
            
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(120, 28);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(180, 23);
            txtMarca.TabIndex = 5;
            // 
            // lblKilometraje
            // 
            lblKilometraje.AutoSize = true;
            lblKilometraje.Font = new Font("Segoe UI", 10F);
            lblKilometraje.Location = new Point(30, 126);
            lblKilometraje.Name = "lblKilometraje";
            lblKilometraje.Size = new Size(77, 19);
            lblKilometraje.TabIndex = 4;
            lblKilometraje.Text = "Kilometraje";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Segoe UI", 10F);
            lblAño.Location = new Point(350, 75);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(38, 19);
            lblAño.TabIndex = 3;
            lblAño.Text = " Año";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Font = new Font("Segoe UI", 10F);
            lblPatente.Location = new Point(350, 30);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(56, 19);
            lblPatente.TabIndex = 2;
            lblPatente.Text = "Patente";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 10F);
            lblModelo.Location = new Point(30, 75);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(56, 19);
            lblModelo.TabIndex = 1;
            lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 10F);
            lblMarca.Location = new Point(30, 30);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(47, 19);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            lblMarca.Click += label2_Click;
            // 
            // panelTabla
            // 
            panelTabla.Controls.Add(dgvVehiculos);
            panelTabla.Dock = DockStyle.Fill;
            panelTabla.Location = new Point(0, 240);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(1403, 401);
            panelTabla.TabIndex = 4;
            // 
            // dgvVehiculos
            // 
            dgvVehiculos.AllowUserToAddRows = false;
            dgvVehiculos.BackgroundColor = Color.White;
            dgvVehiculos.BorderStyle = BorderStyle.None;
            dgvVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculos.Dock = DockStyle.Fill;
            dgvVehiculos.Location = new Point(0, 0);
            dgvVehiculos.MultiSelect = false;
            dgvVehiculos.Name = "dgvVehiculos";
            dgvVehiculos.ReadOnly = true;
            dgvVehiculos.RowHeadersVisible = false;
            dgvVehiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehiculos.Size = new Size(1403, 401);
            dgvVehiculos.TabIndex = 0;
            dgvVehiculos.CellClick += dgvVehiculos_CellClick;
            // 
            // frmVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 232, 241);
            ClientSize = new Size(1403, 641);
            Controls.Add(panelTabla);
            Controls.Add(panelFormulario);
            Controls.Add(panelTop);
            Name = "frmVehiculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarCheck - Vehiculos";
            WindowState = FormWindowState.Maximized;
            Load += frmVehiculos_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKm).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnio).EndInit();
            panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVehiculos).EndInit();
            ResumeLayout(false);
            // 
        }

        private void panelFormulario_Paint(object sender, PaintEventArgs e) { }

        private void label2_Click(object sender, EventArgs e) => throw new NotImplementedException();

        #endregion

        private Panel panelTop;
        private Panel panelFormulario;
        private Panel panelTabla;
        private Label label1;
        private Label lblAño;
        private Label lblPatente;
        private Label lblModelo;
        private Label lblMarca;
        private Label lblKilometraje;
        private TextBox txtPatente;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private NumericUpDown numericUpDownKm;
        private NumericUpDown numericUpDownAnio;
        private DataGridView dgvVehiculos;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
    }
}