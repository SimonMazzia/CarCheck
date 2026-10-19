
namespace carCheckFront
{
    partial class FrmHistorial
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Button btnExportarPdf;
        private System.Windows.Forms.Button btnActualizar;

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
            lblTitulo = new System.Windows.Forms.Label();
            lblSubtitulo = new System.Windows.Forms.Label();
            dgvHistorial = new System.Windows.Forms.DataGridView();
            btnExportarPdf = new System.Windows.Forms.Button();
            btnActualizar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font(
                "Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblTitulo.Location = new System.Drawing.Point(25, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(0, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Historial de mantenimiento";

            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            lblSubtitulo.Location = new System.Drawing.Point(28, 62);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new System.Drawing.Size(0, 19);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text =
                "Consultá los servicios registrados de tus vehículos.";

            // 
            // btnExportarPdf
            // 
            btnExportarPdf.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;
            btnExportarPdf.BackColor =
                System.Drawing.Color.FromArgb(0, 122, 204);
            btnExportarPdf.FlatAppearance.BorderSize = 0;
            btnExportarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExportarPdf.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnExportarPdf.ForeColor = System.Drawing.Color.White;
            btnExportarPdf.Location = new System.Drawing.Point(630, 30);
            btnExportarPdf.Name = "btnExportarPdf";
            btnExportarPdf.Size = new System.Drawing.Size(145, 40);
            btnExportarPdf.TabIndex = 2;
            btnExportarPdf.Text = "Exportar PDF";
            btnExportarPdf.UseVisualStyleBackColor = false;
            btnExportarPdf.Click += btnExportarPdf_Click;

            // 
            // btnActualizar
            // 
            btnActualizar.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Right;
            btnActualizar.BackColor = System.Drawing.Color.White;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            btnActualizar.ForeColor =
                System.Drawing.Color.FromArgb(52, 73, 94);
            btnActualizar.Location = new System.Drawing.Point(500, 30);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(115, 40);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;

            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            dgvHistorial.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvHistorial.ColumnHeadersHeight = 38;
            dgvHistorial.Location = new System.Drawing.Point(25, 120);
            dgvHistorial.MultiSelect = false;
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.RowTemplate.Height = 32;
            dgvHistorial.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.Size = new System.Drawing.Size(750, 300);
            dgvHistorial.TabIndex = 4;

            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(239, 244, 250);
            ClientSize = new System.Drawing.Size(800, 450);

            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(btnExportarPdf);
            Controls.Add(btnActualizar);
            Controls.Add(dgvHistorial);

            Name = "FrmHistorial";
            Text = "Historial de mantenimiento";

            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
