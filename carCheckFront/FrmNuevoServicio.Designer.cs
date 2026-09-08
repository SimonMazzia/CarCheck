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
            btnNuevoServicio.Location = new Point(12, 6);
            btnNuevoServicio.Name = "btnNuevoServicio";
            btnNuevoServicio.Size = new Size(132, 33);
            btnNuevoServicio.TabIndex = 1;
            btnNuevoServicio.Text = "Nuevo Servicio ";
            btnNuevoServicio.UseVisualStyleBackColor = true;
            btnNuevoServicio.Click += btnNuevoServicio_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Controls.Add(labelService);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 60);
            panel1.TabIndex = 2;
            // 
            // labelService
            // 
            labelService.AutoSize = true;
            labelService.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelService.ForeColor = Color.White;
            labelService.Location = new Point(20, 18);
            labelService.Name = "labelService";
            labelService.Size = new Size(220, 32);
            labelService.TabIndex = 0;
            labelService.Text = "Servicios Tecnicos";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnNuevoServicio);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 120);
            panel2.TabIndex = 3;
            // 
            // dgvServicios
            // 
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Dock = DockStyle.Fill;
            dgvServicios.Location = new Point(0, 180);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.Size = new Size(800, 270);
            dgvServicios.TabIndex = 4;
            // 
            // FrmNuevoServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvServicios);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmNuevoServicio";
            Text = "FrmNuevoServicio";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnNuevoServicio;
        private Panel panel1;
        private Label labelService;
        private Panel panel2;
        private DataGridView dgvServicios;
    }
}