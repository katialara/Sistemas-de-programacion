using SistemasProgramacionRFC.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasProgramacionRFC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void genrarRFCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarRFC formulario = new GenerarRFC();
            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}
