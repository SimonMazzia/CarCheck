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
            label2 = new Label();
            panel1 = new Panel();
            labelService = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevoServicio
            // 
            btnNuevoServicio.Location = new Point(20, 87);
            btnNuevoServicio.Name = "btnNuevoServicio";
            btnNuevoServicio.Size = new Size(132, 33);
            btnNuevoServicio.TabIndex = 1;
            btnNuevoServicio.Text = "Nuevo Servicio ";
            btnNuevoServicio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 145);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 2;
            label2.Text = "Historial de servicios ";
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
            // FrmNuevoServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(btnNuevoServicio);
            Name = "FrmNuevoServicio";
            Text = "FrmNuevoServicio";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNuevoServicio;
        private Label label2;
        private Panel panel1;
        private Label labelService;
    }
}