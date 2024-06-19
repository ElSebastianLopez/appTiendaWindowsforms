using appTiendaP.source.dominio;
using appTiendaP.source.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace appTiendaP.source.aplicacion
{
    public partial class interfazProducto : MenuBar
    {
        ProductoController proCon;
        CategoriaController cateCon;
        producto actual = null;
        string accion = "";
        public interfazProducto()
        {
            InitializeComponent();
            inicializar();
        }
        void inicializar()
        {
            proCon = new ProductoController();
            cateCon = new CategoriaController();
            activarDesactivarMenu(true);
            activarDesactivarEntradas(false);
            mostrarListaProductos();
            CargarCategories();
            Listcategories.SelectedIndexChanged += ComboBoxCategories_SelectedIndexChanged;
        }

        void CargarCategories()
        {
            List<categoria> listaCategorias = cateCon.darCategoria();

            if (listaCategorias != null && listaCategorias.Count > 0)
            {
                Listcategories.DataSource = listaCategorias;
                Listcategories.DisplayMember = "nombre"; // Asegúrate de que esta propiedad exista en la clase categoria
                Listcategories.ValueMember = "id"; // Asegúrate de que esta propiedad exista en la clase categoria
            }
            else
            {
                Listcategories.DataSource = null; // Usa null en lugar de una cadena vacía
            }
        }

        void ComboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Listcategories.SelectedItem != null)
            {
                txtCategoria_id.Text = ((int)Listcategories.SelectedValue).ToString();
            }
        }

        //Metodo para agregar un producto
        void agregarProducto()
        {
            string[] respuesta = proCon.agregarProducto(txtNombre.Text,
                txtPrecio_compra.Text, txtPrecio_venta.Text, txtCantidad_actual.Text,
                txtCategoria_id.Text);
            txtId.Text = respuesta[0];
            MessageBox.Show(respuesta[1]);
            if (respuesta[0] != "0")
            {
                activarDesactivarMenu(true);
                activarDesactivarEntradas(false);
                actual = proCon.consultarProducto(txtNombre.Text);
                mostrarListaProductos();
            }
        }
        //metodo para limpiar el formulario
        void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPrecio_compra.Clear();
            txtPrecio_venta.Clear();
            txtCantidad_actual.Clear();
            txtCategoria_id.Clear();

        }
        void activarDesactivarEntradas(bool valor)
        {
            txtNombre.Enabled = valor;
            txtPrecio_compra.Enabled = valor;
            txtPrecio_venta.Enabled = valor;
            txtCantidad_actual.Enabled = valor;
            txtCategoria_id.Enabled = false;
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
        void mostrarProducto(producto unProducto)
        {
            txtId.Text = unProducto.id.ToString();
            txtNombre.Text = unProducto.nombre;
            txtPrecio_compra.Text = unProducto.precio_compra.ToString();
            txtPrecio_venta.Text = unProducto.precio_venta.ToString();
            txtCantidad_actual.Text = unProducto.cantidad_actual.ToString();
            txtCategoria_id.Text = unProducto.categoria_id.ToString();
        }
        //metodo para consultar los datos de un producto
        void consultarProducto()
        {
            string Nombre = Interaction.InputBox("ingrese el producto");
            if (!string.IsNullOrEmpty(Nombre))
            {
                producto unProducto =proCon.consultarProducto(Nombre);
                actual = unProducto;
                if(unProducto != null) 
                {
                    mostrarProducto(unProducto);
                }
                else
                {
                    limpiar();
                    MessageBox.Show("No se encontro el producto" + Nombre);
                }
            }
        }

        //metodo para modificar un producto
        void modificarProducto()
        {
            string msg = proCon.modificarProducto(txtId.Text, txtNombre.Text,
                txtPrecio_compra.Text,
                txtPrecio_venta.Text,
                txtCantidad_actual.Text,
                txtCategoria_id.Text);
            mostrarListaProductos();
            MessageBox.Show(msg);
        }

        void eliminarProducto()
        {
            if(!string.IsNullOrEmpty(txtId.Text))
            {
                string mensaje = "esta seguro que quiere eliminar el producto?";
                string title = "eliminar producto";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show(mensaje, title, buttons);
                if (dr == DialogResult.Yes)
                {
                    string respuesta = proCon.eliminarProducto(txtId.Text);
                    MessageBox.Show(respuesta);
                    mostrarListaProductos();
                    limpiar();
                }
            }
        }
        void mostrarListaProductos()
        {
            dgvProducto.DataSource = null;

            List<producto> listaProductos = proCon.darProductos();
            if (listaProductos != null && listaProductos.Count > 0)
            {
                dgvProducto.DataSource = listaProductos;
                //if(dgvProducto.Columns.Contains("productos"))
                //{
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("ID", typeof(int));
                    dataTable.Columns.Add("Nombre", typeof(string));
                    dataTable.Columns.Add("Precio Compra", typeof(double));
                    dataTable.Columns.Add("Precio venta", typeof(double));
                    dataTable.Columns.Add("Cantidad Actual", typeof(int));
                    dataTable.Columns.Add("Categoria", typeof(string));
                    dataTable.Columns.Add("Categoria id", typeof(int));
                    dataTable.Columns.Add("Detalle Venta", typeof(object));


                    foreach (var producto in listaProductos)
                    {
                        dataTable.Rows.Add(producto.id ,producto.nombre, producto.precio_compra,
                            producto.precio_venta,producto.cantidad_actual,producto.categoria.nombre,
                            producto.categoria_id,producto.detalle_venta);
                        // Agrega aquí más columnas según sea necesario
                    }
                    // Asignar el DataTable como origen de datos del DataGridView
                    dgvProducto.DataSource = dataTable;

                    // Personalizar las columnas del DataGridView
                    if (dgvProducto.Columns.Contains("ID"))
                    {
                        dgvProducto.Columns["ID"].Visible = false; // Ejemplo de cómo ocultar una columna
                    }
                //}
                dgvProducto.Refresh();
            }
            else
            {
                MessageBox.Show("No hay producto para mostrar");
            }
        }
        public override void btnmNuevo_Click(object sender, EventArgs e)
        {
            accion = "nuevo";
            limpiar();
            activarDesactivarMenu(false);
            activarDesactivarEntradas(true);
        }


        public override void btnmGuardar_Click(object sender, EventArgs e)
        {
            if (accion == "nuevo")
            {
                agregarProducto();
            }
            if (accion == "modificar")
            {
                modificarProducto();
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
                mostrarProducto(actual);
            }
            accion = "";
            activarDesactivarEntradas(false);
            activarDesactivarMenu(true);
        }

        public override void btnmEliminar_Click(object sender, EventArgs e)
        {
            if (actual != null)
            {
                eliminarProducto();
            }
        }

        public override void btnmConsultar_Click(object sender, EventArgs e)
        {
            consultarProducto();
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



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            agregarProducto();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultarProducto();
        }

        //public override  void btnModificar_Click(object sender, EventArgs e)
        //{
        //    modificarProducto();
        //}

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarProducto();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
