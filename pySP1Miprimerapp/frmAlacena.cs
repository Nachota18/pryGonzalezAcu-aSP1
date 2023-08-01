using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pySP1Miprimerapp
{
    public partial class frmAlacena : Form
    {
        string varNombreDelProducto;
        string varCategoria;
        int varCantidad;

        public frmAlacena()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAlacena_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            varNombreDelProducto = txtNombreDeProducto.Text;
            varCantidad = Convert.ToInt32(lstCantidad.Text);
            varCategoria = lstCatProductos.Text;
            lstAlacena.Items.Add(varNombreDelProducto + " " + varCategoria + " " + varCantidad);
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {

        }

        private void lstCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreDeProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstAlacena_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
