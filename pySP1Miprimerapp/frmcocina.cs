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
    }
}
