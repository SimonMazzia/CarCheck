namespace carCheckFront
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            label1 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(364, 46);
            label1.Name = "label1";
            label1.Size = new Size(438, 74);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a CarCheck";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(376, 171);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 69);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(52, 73, 94);
            button2.FlatAppearance.BorderColor = Color.FromArgb(106, 125, 143);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(199, 19);
            button2.Name = "button2";
            button2.Size = new Size(136, 34);
            button2.TabIndex = 2;
            button2.Text = "Registrarse";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 122, 204);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(36, 19);
            button1.Name = "button1";
            button1.Size = new Size(136, 34);
            button1.TabIndex = 1;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(376, 120);
            label2.Name = "label2";
            label2.Size = new Size(283, 29);
            label2.TabIndex = 4;
            label2.Text = "Gestión inteligente para vehículos y servicios";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 34, 46);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(24);
            panel1.Size = new Size(965, 431);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(313, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 171);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(313, 259);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 232, 241);
            ClientSize = new Size(965, 431);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MinimumSize = new Size(840, 470);
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarCheck - Inicio";
            Resize += FrmInicio_Resize;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}