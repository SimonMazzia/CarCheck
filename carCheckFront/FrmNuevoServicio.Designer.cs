namespace carCheckFront
{
    partial class FrmNuevoServicio
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
            btnNuevoServicio = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();

            panel1 = new Panel();
            labelService = new Label();

            panel2 = new Panel();

            dgvServicios = new DataGridView();

            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();

            SuspendLayout();

            // 
            // btnNuevoServicio
            // 
            btnNuevoServicio.Location = new Point(20, 20);
            btnNuevoServicio.Name = "btnNuevoServicio";
            btnNuevoServicio.Size = new Size(145, 38);
            btnNuevoServicio.TabIndex = 0;
            btnNuevoServicio.Text = "＋  Nuevo servicio";
            btnNuevoServicio.UseVisualStyleBackColor = false;
            btnNuevoServicio.Click += btnNuevoServicio_Click;

            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(180, 20);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(120, 38);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "✎  Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;

            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(315, 20);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 38);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "🗑  Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;

            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVolver.Location = new Point(680, 20);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 38);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "←  Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;

            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(labelService);
            panel1.Controls.Add(btnVolver);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 70);
            panel1.TabIndex = 4;

            // 
            // labelService
            // 
            labelService.AutoSize = true;
            labelService.Font = new Font(
                "Segoe UI",
                18F,
                FontStyle.Bold,
                GraphicsUnit.Point,
                0);

            labelService.ForeColor = Color.White;

            labelService.Location = new Point(20, 18);

            labelService.Name = "labelService";

            labelService.Size = new Size(220, 32);

            labelService.TabIndex = 0;

            labelService.Text = "Servicios técnicos";

            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(239, 244, 250);

            panel2.Controls.Add(btnNuevoServicio);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnEliminar);

            panel2.Dock = DockStyle.Top;

            panel2.Location = new Point(0, 70);

            panel2.Name = "panel2";

            panel2.Size = new Size(800, 80);

            panel2.TabIndex = 5;

            // 
            // dgvServicios
            // 
            dgvServicios.AllowUserToAddRows = false;
            dgvServicios.AllowUserToDeleteRows = false;
            dgvServicios.AllowUserToResizeRows = false;

            dgvServicios.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            dgvServicios.Dock = DockStyle.Fill;

            dgvServicios.Location = new Point(0, 150);

            dgvServicios.MultiSelect = false;

            dgvServicios.Name = "dgvServicios";

            dgvServicios.ReadOnly = true;

            dgvServicios.RowHeadersVisible = false;

            dgvServicios.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvServicios.Size = new Size(800, 300);

            dgvServicios.TabIndex = 6;

            dgvServicios.CellContentClick +=
                dgvServicios_CellContentClick;

            // 
            // FrmNuevoServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.FromArgb(239, 244, 250);

            ClientSize =
                new Size(800, 450);

            Controls.Add(dgvServicios);

            Controls.Add(panel2);

            Controls.Add(panel1);

            MinimumSize =
                new Size(800, 450);

            Name =
                "FrmNuevoServicio";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "CarCheck - Servicios técnicos";

            panel1.ResumeLayout(false);
            panel1.PerformLayout();

            panel2.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();

            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevoServicio;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnVolver;

        private Panel panel1;
        private Label labelService;

        private Panel panel2;

        private DataGridView dgvServicios;
    }
}