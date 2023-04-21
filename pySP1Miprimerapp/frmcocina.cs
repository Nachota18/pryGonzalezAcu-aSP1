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
    public partial class frmcocina : Form
    {
        public frmcocina()
        {
            InitializeComponent();
        }

        private void cmdAlacena_Click(object sender, EventArgs e)
        {
            frmAlacena frmAlacena = new frmAlacena();
            frmAlacena.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
