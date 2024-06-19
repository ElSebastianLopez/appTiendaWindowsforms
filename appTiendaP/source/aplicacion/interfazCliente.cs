using appTiendaP.source.dominio;
using appTiendaP.source.entidades;
using Microsoft.VisualBasic;
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
    public partial class interfazCliente : MenuBar
    {
        ClienteController ClienteController;
        //string accion = "";
        cliente actual = null;
        String accion = "";
        public interfazCliente()
        {
            InitializeComponent();
            inicializar();
        }
        void inicializar()
        {
            ClienteController = new ClienteController();
            mostrarListaClientes();
            activarDesactivarMenu(true);
            activarDesactivarEntradas(false);
            //activarBotones(true);
            //activarEntradas(true);
        }

        //Metodo para agregar un producto
        void agregarCliente()
        {
            string[] respuesta = ClienteController.agregarCliente(txtDocumento.Text,txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtEmail.Text);
            txtId.Text = respuesta[0];
            MessageBox.Show(respuesta[1]);
            if (respuesta[0] !="0")
            {
                activarDesactivarMenu(true);
                activarDesactivarEntradas(false);
                actual = ClienteController.consultarCliente(txtDocumento.Text);
                mostrarListaClientes();
            }
           
        }
        //metodo para limpiar el formulario
        void limpiar()
        {
            txtId.Clear();
            txtDocumento.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            
        }

        void activarDesactivarEntradas(bool valor)
        {
            
            txtDocumento.Enabled=valor;
            txtNombre.Enabled=valor;
            txtApellido.Enabled=valor;
            txtTelefono.Enabled=valor;
            txtEmail.Enabled=valor;
            txtDocumento.Focus();
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
        void mostrarCliente(cliente unCliente)
        {
            txtId.Text = unCliente.id.ToString();
            txtDocumento.Text = unCliente.documento.ToString();
            txtNombre.Text = unCliente.nombres;
            txtApellido.Text = unCliente.apellidos;
            txtTelefono.Text = unCliente.telefono;
            txtEmail.Text = unCliente.email;

        }
        //metodo para consultar los datos de un producto
        void consultarCliente()
        {
            string Documento = Interaction.InputBox("ingrese el documento");
            if (!string.IsNullOrEmpty(Documento))
            {
                cliente unCliente = ClienteController.consultarCliente(Documento);
                actual = unCliente;
                if (unCliente != null)
                {
                    mostrarCliente(unCliente);
                }
                else
                {
                    limpiar();
                    MessageBox.Show("No se encontro el cliente" + Documento);
                }
            }
        }

        //metodo para modificar un producto
        void modificarCliente()
        {
            string msg = ClienteController.modificarCliente(txtId.Text,txtDocumento.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtEmail.Text);
            mostrarListaClientes();
            MessageBox.Show(msg);
        }

        void eliminarCliente()
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                string mensaje = "esta seguro que quiere eliminar el cliente?";
                string title = "eliminar cliente";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show(mensaje, title, buttons);
                if (dr == DialogResult.Yes)
                {
                    string respuesta = ClienteController.eliminarCliente(txtId.Text);
                    MessageBox.Show(respuesta);
                    limpiar();
                    mostrarListaClientes();
                }
            }
        }
        void mostrarListaClientes()
        {
            dgvCliente.DataSource = null;

            List<cliente> listaClientes = ClienteController.darCliente();
            if (listaClientes != null && listaClientes.Count > 0)
            {
                dgvCliente.DataSource = listaClientes;
                if (dgvCliente.Columns.Contains("ventas"))
                {
                    dgvCliente.Columns["ventas"].Visible = false;
                }
                dgvCliente.Refresh();
            }
           
        }

        public override void btnmNuevo_Click(object sender, EventArgs e)
        {
            accion = "nuevo";
            limpiar();
            activarDesactivarMenu(false);
            activarDesactivarEntradas(true);
            txtDocumento.Focus();
        }


        public override void btnmGuardar_Click(object sender, EventArgs e)
        {
            if(accion =="nuevo")
            {
                agregarCliente();
            }
            if(accion =="modificar")
            {
                modificarCliente();
            }
        }

        public override void btnCancelar_Click(object sender, EventArgs e)
        {
            if(accion=="nuevo")
            {
                limpiar();

            }

            if(accion=="modificar")
            {
                mostrarCliente(actual);
            }
            accion = "";
            activarDesactivarEntradas(false);
            activarDesactivarMenu(true);
        }

        public override void btnmEliminar_Click(object sender, EventArgs e)
        {
            if(actual != null) 
            {
                eliminarCliente();
            }
        }

        public override void btnmConsultar_Click(object sender, EventArgs e)
        {
            consultarCliente();
        }

        public override void btnModificar_Click(object sender, EventArgs e)
        {
            if(actual != null) 
            {

            
            accion = "modificar";
            activarDesactivarMenu(false);
            activarDesactivarEntradas(true);
            txtDocumento.Focus();
            }

        }

        public override void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void interfazCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
