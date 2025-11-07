namespace carCheckFront
{
    partial class FrmRegistro
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
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(24, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 300);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(218, 198);
            button2.Name = "button2";
            button2.Size = new Size(91, 23);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(107, 198);
            button1.Name = "button1";
            button1.Size = new Size(94, 23);
            button1.TabIndex = 7;
            button1.Text = "Registrar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(184, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(116, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(116, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 23);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(16, 122);
            label3.Name = "label3";
            label3.Size = new Size(82, 19);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(16, 78);
            label2.Name = "label2";
            label2.Size = new Size(124, 19);
            label2.TabIndex = 1;
            label2.Text = "Correo electronico:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(16, 36);
            label1.Name = "label1";
            label1.Size = new Size(130, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombre de usuario:";
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 386);
            Controls.Add(panel1);
            Name = "FrmRegistro";
            Text = "FrmRegistro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
    }
}