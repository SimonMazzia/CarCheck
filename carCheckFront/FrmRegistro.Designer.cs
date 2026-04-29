using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Font = System.Drawing.Font;


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
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(24, 34, 46);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(31, 26);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(370, 326);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.ForeColor = Color.FromArgb(181, 195, 211);
            label4.Location = new Point(24, 54);
            label4.Name = "label4";
            label4.Size = new Size(198, 15);
            label4.TabIndex = 9;
            label4.Text = "Creá tu cuenta y empezá a gestionar";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(52, 73, 94);
            button2.FlatAppearance.BorderColor = Color.FromArgb(106, 125, 143);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(248, 271);
            button2.Name = "button2";
            button2.Size = new Size(108, 32);
            button2.TabIndex = 8;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 122, 204);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(134, 271);
            button1.Name = "button1";
            button1.Size = new Size(108, 32);
            button1.TabIndex = 7;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(24, 221);
            label6.Name = "label6";
            label6.Size = new Size(127, 19);
            label6.TabIndex = 3;
            label6.Text = "PIN de seguridad *:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(239, 244, 250);
            textBox3.Location = new Point(167, 181);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 23);
            textBox3.TabIndex = 6;
            textBox3.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(239, 244, 250);
            textBox2.Location = new Point(167, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(239, 244, 250);
            textBox1.Location = new Point(167, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 181);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 2;
            label3.Text = "Contraseña *:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 139);
            label2.Name = "label2";
            label2.Size = new Size(134, 19);
            label2.TabIndex = 1;
            label2.Text = "Correo electrónico *:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(239, 244, 250);
            textBox4.Location = new Point(167, 221);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 23);
            textBox4.TabIndex = 7;
            textBox4.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 98);
            label5.Name = "label5";
            label5.Size = new Size(140, 19);
            label5.TabIndex = 2;
            label5.Text = "Nombre de usuario *:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(95, 30);
            label1.TabIndex = 0;
            label1.Text = "Registro";
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 232, 241);
            ClientSize = new Size(432, 382);
            Controls.Add(panel1);
            MinimumSize = new Size(448, 421);
            Name = "FrmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CarCheck - Registro";
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
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
    }
}
