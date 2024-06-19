using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appTiendaP.source.datos;
using appTiendaP.source.entidades;

namespace appTiendaP.source.dominio
{
    internal class ProductoController
    {
        //atributos
        DatosProducto datPro;

        //metodo constructor
        public ProductoController()
        {
            datPro = new DatosProducto();
        }
        private void validarDatos(string nNombre, string nPrecio_compra, string nPrecio_venta,
            string nCantidad_actual, string nCategoria_id)
        {



            if (string.IsNullOrEmpty(nNombre))
            {
                throw new Exception("Debe ingresar el nombre del producto");

            }
            if (!validador.esProducto(nNombre))
            {
                throw new Exception("El nombre no tiene el formato correcto");
            }
            if (string.IsNullOrEmpty(nPrecio_compra))
            {
                throw new Exception("El campo precio_compra no debe estar vacío");
            }
            if (string.IsNullOrEmpty(nPrecio_venta))
            {
                throw new Exception("El campo precio_vetna no debe estar vacío");
            }
            if (string.IsNullOrEmpty(nCantidad_actual))
            {
                throw new Exception("El campo cantidad_atual no debe estar vacío");
            }
            if (string.IsNullOrEmpty(nCategoria_id))
            {
                throw new Exception("El campo categoria_Id no debe estar vacío");
            }
           
            

        }
        //metodo para agregar un nuevo producto
        public string[] agregarProducto(string nNombre, string nPrecio_compra, string nPrecio_venta,
            string nCantidad_actual, string nCategoria_id)
        {
            string[] respuesta = new string[2];
            try
            {
                validarDatos(nNombre, nPrecio_compra, nPrecio_venta, nCantidad_actual,nCategoria_id);
                producto Pro = new producto();
                {
                    Pro.nombre = nNombre;
                    Pro.precio_compra = float.Parse(nPrecio_compra);
                    Pro.precio_venta = float.Parse(nPrecio_venta);
                    Pro.cantidad_actual = int.Parse(nCantidad_actual);
                    Pro.categoria_id=int.Parse(nCategoria_id);
                    int lid = datPro.agregarProducto(Pro);
                    respuesta[0] = lid.ToString();
                    respuesta[1] = "Se agrego el producto correctamente!!";
                }

                
            }
            catch (Exception ex)
            {
                respuesta[0] = "0";
                respuesta[1] = ex.Message;
            }

            return respuesta;
        }
        //metodo para modificar datos de un producto

        public string modificarProducto(string idProducto, string nNombre, string nPrecio_compra, string nPrecio_venta,
            string nCantidad_actual, string nCategoria_id)
        {
            try
            {
                validarDatos(nNombre, nPrecio_compra, nPrecio_venta, nCantidad_actual, nCategoria_id);
                producto Pro = new producto();
                {
                    Pro.id = int.Parse(idProducto);
                    Pro.nombre = nNombre;
                    Pro.precio_compra = float.Parse(nPrecio_compra);
                    Pro.precio_venta = float.Parse(nPrecio_venta);
                    Pro.cantidad_actual = int.Parse(nCantidad_actual);
                    Pro.categoria_id = int.Parse(nCategoria_id);
                    datPro.modificarProducto(Pro);
                    return  "se han modificado los datos del producto correctamente";
                }
                
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }
        //metodo para consultar los datos de un paciente
        public producto consultarProducto(string Nombre)
        {
      
   
            {
                producto nProducto = null;
                using (var contexto = new tienda_dbEntities2())
                {
                    nProducto = contexto.productos
                        .Where(s => s.nombre == Nombre)
                        .FirstOrDefault<producto>();
                }
                return nProducto;
            }

        }

        //metodo para eliminar producto
        public string eliminarProducto(string id)
        {
            datPro.eliminarProducto(int.Parse(id));
            return "Se eliminaron los datos del produtos correcxtamente!!";
        }

        //método para obtener la lista de pacientes

        public List<producto> darProductos()
        {
            var contexto = new tienda_dbEntities2 ();
            return contexto.productos.ToList();
        }

    }
}
