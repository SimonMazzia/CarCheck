
namespace carCheckFront
{
    partial class FrmHistorial
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            lblTitulo = new System.Windows.Forms.Label();
            lblSubtitulo = new System.Windows.Forms.Label();
            lblVehiculo = new System.Windows.Forms.Label();
            cmbVehiculos = new System.Windows.Forms.ComboBox();
            dgvHistorial = new System.Windows.Forms.DataGridView();
            btnExportarPdf = new System.Windows.Forms.Button();
            btnActualizar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(dgvHistorial)).BeginInit();
            SuspendLayout();

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font(
                "Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblTitulo.Location = new System.Drawing.Point(25, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(300, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Historial de mantenimiento";

            // lblSubtitulo
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            lblSubtitulo.Location = new System.Drawing.Point(28, 62);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new System.Drawing.Size(320, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Consultá y exportá los servicios de tus vehículos.";

            // lblVehiculo
            lblVehiculo.AutoSize = true;
            lblVehiculo.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblVehiculo.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            lblVehiculo.Location = new System.Drawing.Point(28, 105);
            lblVehiculo.Name = "lblVehiculo";
            lblVehiculo.Size = new System.Drawing.Size(55, 15);
            lblVehiculo.TabIndex = 2;
            lblVehiculo.Text = "Vehículo:";

            // cmbVehiculos
            cmbVehiculos.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbVehiculos.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbVehiculos.FormattingEnabled = true;
            cmbVehiculos.Location = new System.Drawing.Point(95, 100);
            cmbVehiculos.Name = "cmbVehiculos";
            cmbVehiculos.Size = new System.Drawing.Size(300, 25);
            cmbVehiculos.TabIndex = 3;
            cmbVehiculos.SelectedIndexChanged +=
                new System.EventHandler(cmbVehiculos_SelectedIndexChanged);

            // dgvHistorial
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.Anchor =
                ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            dgvHistorial.BackgroundColor = System.Drawing.Color.White;
            dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvHistorial.ColumnHeadersHeight = 35;
            dgvHistorial.Location = new System.Drawing.Point(28, 145);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.RowTemplate.Height = 30;
            dgvHistorial.Size = new System.Drawing.Size(844, 340);
            dgvHistorial.TabIndex = 4;

            // btnActualizar
            btnActualizar.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Right;
            btnActualizar.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnActualizar.ForeColor = System.Drawing.Color.White;
            btnActualizar.Location = new System.Drawing.Point(570, 505);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(135, 38);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click +=
                new System.EventHandler(btnActualizar_Click);

            // btnExportarPdf
            btnExportarPdf.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom
                | System.Windows.Forms.AnchorStyles.Right;
            btnExportarPdf.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            btnExportarPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExportarPdf.FlatAppearance.BorderSize = 0;
            btnExportarPdf.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnExportarPdf.ForeColor = System.Drawing.Color.White;
            btnExportarPdf.Location = new System.Drawing.Point(720, 505);
            btnExportarPdf.Name = "btnExportarPdf";
            btnExportarPdf.Size = new System.Drawing.Size(152, 38);
            btnExportarPdf.TabIndex = 6;
            btnExportarPdf.Text = "Exportar PDF";
            btnExportarPdf.UseVisualStyleBackColor = false;
            btnExportarPdf.Click +=
                new System.EventHandler(btnExportarPdf_Click);

            // FrmHistorial
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(239, 244, 250);
            ClientSize = new System.Drawing.Size(900, 570);
            Controls.Add(btnExportarPdf);
            Controls.Add(btnActualizar);
            Controls.Add(dgvHistorial);
            Controls.Add(cmbVehiculos);
            Controls.Add(lblVehiculo);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Name = "FrmHistorial";
            Text = "Historial de mantenimiento";

            ((System.ComponentModel.ISupportInitialize)(dgvHistorial)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.ComboBox cmbVehiculos;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Button btnExportarPdf;
        private System.Windows.Forms.Button btnActualizar;
    }
}
