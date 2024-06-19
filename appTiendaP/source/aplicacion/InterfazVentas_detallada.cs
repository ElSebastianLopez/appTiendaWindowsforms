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
    public partial class InterfazVentas_detallada : MenuBar
    {
        VentaController proVen;
        //string accion  = "";
        venta actual = null;
        String accion = "";
        public InterfazVentas_detallada()
        {
            InitializeComponent();
            inicializar();
        }
        void inicializar()
        {
            proVen = new VentaController();
            mostrarListaVentas();
            activarDesactivarMenu(true);
            activarDesactivarEntradas(false);
            //activarBotones(true);
            //activarEntradas(true);
        }


        //Metodo para agregar un producto
        void agregarVenta()
        {
            string[] respuesta = proVen.agregarVenta(txtCliente.Text, txtFecha.Text, txtHora.Text, txtValor.Text, txtImpuesto.Text, txtPago.Text);
            txtId.Text = respuesta[0];
            MessageBox.Show(respuesta[1]);
            if (respuesta[0] != "0")
            {
                activarDesactivarMenu(true);
                activarDesactivarEntradas(false);
                actual = proVen.consultarVenta(txtCliente.Text);
                mostrarListaVentas();
            }

        }
        //metodo para limpiar el formulario
        void limpiar()
        {
            txtCliente.Clear();
            txtId.Clear();
            txtFecha.Clear();
            txtHora.Clear();
            txtValor.Clear();
            txtImpuesto.Clear();
            txtPago.Clear();

        }

        void activarDesactivarEntradas(bool valor)
        {
            txtCliente.Clear();
            txtFecha.Clear();
            txtHora.Clear();
            txtValor.Clear();
            txtImpuesto.Clear();
            txtPago.Clear();
            txtCliente.Focus();
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
        void mostrarVenta(venta unaVenta)
        {
            txtId.Text = unaVenta.id.ToString();
            txtCliente.Text = unaVenta.cliente_id.ToString();
            txtFecha.Text = unaVenta.fecha.ToString();
            txtHora.Text = unaVenta.hora.ToString();
            txtValor.Text = unaVenta.valor_total.ToString();
            txtImpuesto.Text = unaVenta.impuesto.ToString();
            txtPago.Text = unaVenta.pago_total.ToString();
        }
        //metodo para consultar los datos de un producto
        void consultarVenta()
        {
            string Venta = Interaction.InputBox("ingrese el cliente");
            if (!string.IsNullOrEmpty(Venta))
            {
                venta unaVenta = proVen.consultarVenta(Venta);
                actual = unaVenta;
                if (unaVenta != null)
                {
                    mostrarVenta(unaVenta);
                }
                else
                {
                    limpiar();
                    MessageBox.Show("No se encontro la venta de:" + Venta);
                }
            }
        }

        //metodo para modificar un producto
        void modificarVenta()
        {
            string msg = proVen.modificarVenta(txtId.Text, txtCliente.Text, txtFecha.Text, txtHora.Text, txtValor.Text, txtImpuesto.Text, txtPago.Text);
            mostrarListaVentas();
            MessageBox.Show(msg);
        }

        void eliminarCliente()
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                string mensaje = "esta seguro que quiere eliminar la venta?";
                string title = "eliminar venta";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show(mensaje, title, buttons);
                if (dr == DialogResult.Yes)
                {
                    string res = proVen.eliminarVenta(txtId.Text);
                    MessageBox.Show(res);
                    limpiar();
                    mostrarListaVentas();
                }
            }
        }
        void mostrarListaVentas()
        {
            dgvVenta.DataSource = null;

            List<venta> listaVentas = proVen.darVenta();
            if (listaVentas != null && listaVentas.Count > 0)
            {
                dgvVenta.DataSource = listaVentas;
                if (dgvVenta.Columns.Contains(""))
                {
                    dgvVenta.Columns[""].Visible = false;
                }
                dgvVenta.Refresh();
            }

        }

        public override void btnmNuevo_Click(object sender, EventArgs e)
        {
            accion = "nuevo";
            limpiar();
            activarDesactivarMenu(false);
            activarDesactivarEntradas(true);
            txtCliente.Focus();
        }


        public override void btnmGuardar_Click(object sender, EventArgs e)
        {

        }

        public override void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        public override void btnmEliminar_Click(object sender, EventArgs e)
        {

        }

        public override void btnmConsultar_Click(object sender, EventArgs e)
        {
            consultarVenta();
        }

        public override void btnModificar_Click(object sender, EventArgs e)
        {

        }
        public override void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
