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
    public partial class frmAplicaciones : Form
    {
        public frmAplicaciones()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAlacena ventanaAlacena = new frmAlacena();  

            ventanaAlacena.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMiPrimerApp ventanaMiprimerApp = new frmMiPrimerApp();
            ventanaMiprimerApp.ShowDialog();
        }

        private void frmAplicaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
