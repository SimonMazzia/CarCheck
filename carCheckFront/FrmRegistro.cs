using carCheckBussines;
using carCheckEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }


        private void FrmRegistro_Resize(object? sender, EventArgs e)
        {
            CentrarPanel();
        }


        private void CentrarPanel()
        {
            panel1.Left = (ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (ClientSize.Height - panel1.Height) / 2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario nuevo = new Usuario
            {
                NombreUsuario = textBox1.Text,
                Email = textBox2.Text,
                PasswordHash = textBox3.Text
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
                Close();
                MessageBox.Show("Complete los campos");
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
