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
    public partial class frmMiPrimerApp : Form
    {
        decimal varDeposito = 0;
        decimal varAlquiler = 0;
        decimal varComida = 0;
        decimal varImpuesto = 0;
        decimal varMonto = 0;


        public frmMiPrimerApp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            varAlquiler = Convert.ToDecimal(txtAlqiuler.Text);
            varComida = Convert.ToDecimal(txtComida.Text);  
            varDeposito=Convert.ToDecimal(txtDeposito.Text);
            varImpuesto = Convert.ToDecimal(txtImpuestos.Text);
            varMonto = Convert.ToDecimal(txtDeposito.Text);

            varMonto = varDeposito - (varAlquiler + varComida + varImpuesto);

            txtMonto.Text = varMonto.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDeposito_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
