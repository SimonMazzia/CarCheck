using carCheckBussines;
using carCheckEntities;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace carCheckFront
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
            Load += FrmRegistro_Load;
            Resize += FrmRegistro_Resize;
        }

        private void FrmRegistro_Load(object? sender, EventArgs e)
        {
            CentrarPanel();

            // 🔐 ocultar PIN
            textBox4.PasswordChar = '*';
            textBox3.PasswordChar = '*'; // contraseña
        }

        private void FrmRegistro_Resize(object? sender, EventArgs e) => CentrarPanel();

        private void CentrarPanel()
        {
            panel1.Left = (ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (ClientSize.Height - panel1.Height) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 🔍 Validación básica
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (textBox4.Text.Length < 4)
            {
                MessageBox.Show("El PIN debe tener al menos 4 dígitos");
                return;
            }

            Usuario nuevo = new Usuario
            {
                NombreUsuario = textBox1.Text,
                Email = textBox2.Text,
                PasswordHash = textBox3.Text,
                PinHash = textBox4.Text // 👈 PIN
            };

            UsuarioNegocio negocio = new UsuarioNegocio();

            if (negocio.Registrar(nuevo))
            {
                MessageBox.Show("Usuario registrado con éxito");
                Close();

                FrmLogin login = new FrmLogin();
                login.Show();
            }
            else
            {
                MessageBox.Show("Error al registrar usuario");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
        }
    }
}