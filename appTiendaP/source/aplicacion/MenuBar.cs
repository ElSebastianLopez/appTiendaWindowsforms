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
    public partial class MenuBar : Form
    {
        public MenuBar()
        {
            InitializeComponent();
        }

        public virtual void btnmNuevo_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnmGuardar_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnmEliminar_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnmConsultar_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnModificar_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        public void activarDesactivarMenu(bool valor)
        {
            btnmNuevo.Enabled = valor;
            btnmConsultar.Enabled = valor;
            btnCerrar.Enabled = valor;
            btnModificar.Enabled = valor;
            btnmEliminar.Enabled = valor;
            btnCancelar.Enabled = !valor;
            btnmGuardar.Enabled= !valor;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
