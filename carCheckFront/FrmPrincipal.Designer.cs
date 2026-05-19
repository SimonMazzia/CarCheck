namespace carCheckFront
{
    partial class FrmPrincipal
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
            lblBienvenida = new Label();
            panelMenu = new Panel();
            panelTop = new Panel();
            panelContenido = new Panel();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Dock = DockStyle.Top;
            lblBienvenida.Location = new Point(0, 0);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(0, 15);
            lblBienvenida.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(24, 34, 46);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 15);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 435);
            panelMenu.TabIndex = 1;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(0, 122, 204);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(220, 15);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(580, 60);
            panelTop.TabIndex = 2;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(225, 232, 241);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(220, 75);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(580, 375);
            panelContenido.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenido);
            Controls.Add(panelTop);
            Controls.Add(panelMenu);
            Controls.Add(lblBienvenida);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Panel panelMenu;
        private Panel panelTop;
        private Panel panelContenido;
    }
}