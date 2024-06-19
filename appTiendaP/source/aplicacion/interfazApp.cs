using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTiendaP.source.aplicacion
{
    public partial class interfazApp : Form
    {
        public interfazApp()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {
            
        }

        private void gestionProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            interfazProducto iPro = new interfazProducto();
            iPro.Show();
            iPro.MdiParent = this;
        }

        private void InterfazApp_Load(object sender, EventArgs e)
        {

        }

        private void gestionCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            interfazCategoria iCat = new interfazCategoria();
            iCat.Show();
            iCat.MdiParent = this;
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazVentas_detallada iVen = new InterfazVentas_detallada();
            iVen.Show();
            iVen.MdiParent = this;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            interfazCliente iCli = new interfazCliente();
            iCli.Show();
            iCli.MdiParent = this;
        }
    }
}
