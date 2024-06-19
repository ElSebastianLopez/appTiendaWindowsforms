using appTiendaP.source.dominio;
using appTiendaP.source.entidades;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTiendaP.source.aplicacion
{
    public partial class interfazCategoria : MenuBar
    {
        CategoriaController catcon;
        categoria actual = null;
        string accion = "";
        public interfazCategoria()
        {
            InitializeComponent();
            inicializar();
        }
        void inicializar()
        {
            catcon = new CategoriaController();
            mostrarListaCategoria();
            activarDesactivarMenu(true);
            activarDesactivarEntradas(false);
            //activarBotones(true);
            //activarEntradas(true);
        }

        //Metodo para agregar un producto
        void agregarCategoria()
        {
            string[] respuesta = catcon.agregarCategoria(txtNombre.Text);
            txtId.Text = respuesta[0];
            MessageBox.Show(respuesta[1]);
            if (respuesta[0] != "0")
            {
                activarDesactivarMenu(true);
                activarDesactivarEntradas(false);
                actual = catcon.consultarCategoria(txtNombre.Text);
                mostrarListaCategoria();
            }
                
        }
        //metodo para limpiar el formulario
        void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            

        }
        void activarDesactivarEntradas(bool valor)
        {
            txtId.Enabled = valor;
            txtNombre.Enabled = valor;
            txtNombre.Focus();
        }
        //void activarEntradas(bool valor)
        //{
        //    txtId.ReadOnly = valor;
        //    txtNombre.ReadOnly = valor;
        //    txtPrecio_c.ReadOnly = valor;
        //    txtPrecio_v.ReadOnly = valor;
        //    txtCantidad.ReadOnly = valor;
        //    txtCategoria.Enabled = !valor;

        //}
        //metodo para mostrar los datos de un producto
        void mostrarCategoria(categoria unaCategoria)
        {
            txtId.Text = unaCategoria.id.ToString();
            txtNombre.Text = unaCategoria.nombre;
            
        }
        //metodo para consultar los datos de un producto
        void consultarCategoria()
        {
            string Nombre = Interaction.InputBox("ingrese la categoria");
            if (!string.IsNullOrEmpty(Nombre))
            {
                categoria unaCategoria = catcon.consultarCategoria(Nombre);
                actual = unaCategoria;
                if (unaCategoria != null)
                {
                    mostrarCategoria(unaCategoria);
                }
                else
                {
                    limpiar();
                    MessageBox.Show("No se encontro la categoriia" + Nombre);
                }
            }
        }

        //metodo para modificar un producto
        void modificarCategoria()
        {
            string msg = catcon.modificarCategoria(txtId.Text, txtNombre.Text);
            mostrarListaCategoria();
            MessageBox.Show(msg);
        }

        void eliminarCategoria()
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                string mensaje = "esta seguro que quiere eliminar la categoria?";
                string title = "eliminar categoria";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show(mensaje, title, buttons);
                if (dr == DialogResult.Yes)
                {
                    string res = catcon.eliminarCategoria(txtId.Text);
                    MessageBox.Show(res);
                    limpiar();
                    mostrarListaCategoria();
                }
            }
        }
        void mostrarListaCategoria()
        {
            dgvCategoria.DataSource = null;

            List<categoria> listaCategorias = catcon.darCategoria();
            if (listaCategorias != null && listaCategorias.Count > 0)
            {
                dgvCategoria.DataSource = listaCategorias;
                if (dgvCategoria.Columns.Contains("categorias"))
                {
                    dgvCategoria.Columns["categorias"].Visible = false;
                }
                dgvCategoria.Refresh();
            }
            else
            {
                MessageBox.Show("No hay producto para mostrar");
            }
        }
        public override void btnmNuevo_Click(object sender, EventArgs e)
        {
            accion = "nuevo";
            activarDesactivarMenu(false);
            activarDesactivarEntradas(true);
        }


        public override void btnmGuardar_Click(object sender, EventArgs e)
        {
            if (accion == "nuevo")
            {
                agregarCategoria();
            }
            if (accion == "modificar")
            {
                modificarCategoria();
            }
        }

        public override void btnCancelar_Click(object sender, EventArgs e)
        {
            if (accion == "nuevo")
            {
                limpiar();

            }

            if (accion == "modificar")
            {
                mostrarCategoria(actual);
            }
            accion = "";
            activarDesactivarEntradas(false);
            activarDesactivarMenu(true);
        }

        public override void btnmEliminar_Click(object sender, EventArgs e)
        {
            if (actual != null)
            {
                eliminarCategoria();
            }
        }

        public override void btnmConsultar_Click(object sender, EventArgs e)
        {
            consultarCategoria();
        }

        public override void btnModificar_Click(object sender, EventArgs e)
        {
            if (actual != null)
            {


                accion = "modificar";
                activarDesactivarMenu(false);
                activarDesactivarEntradas(true);
                txtNombre.Focus();
            }

        }

        public override void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            agregarCategoria();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultarCategoria();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modificarCategoria();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarCategoria();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void interfazCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
