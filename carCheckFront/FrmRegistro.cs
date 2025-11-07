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
        }

        private void button1_Click(object sender, EventArgs e) { }


        private void button2_Click(object sender, EventArgs e)
            {
            this.Close();
            FrmInicio inicio = new FrmInicio();
            inicio.Show();
            }
    }
}
