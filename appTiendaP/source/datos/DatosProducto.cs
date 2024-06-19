using appTiendaP.source.entidades;
using appTiendaP.source.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace appTiendaP.source.datos
{
    public class DatosProducto
    {
        //metodo para agregar un producto
        public int agregarProducto(producto unProducto)
        {
            Random random = new Random();
            int randomId = random.Next(10, 1000000);
            int id = randomId;
            using (var contexto = new tienda_dbEntities2())
            {
                unProducto.id = id;
                contexto.productos.Add(unProducto);
                contexto.SaveChanges();
                
            }
            return id;
        }
        //metodo para consultar producto
        public producto consultarProducto(int id)
        {
            producto nProducto = null;
            using (var contexto = new tienda_dbEntities2())
            {
                nProducto = contexto.productos
                    .Where(s =>s.id== id)
                    .FirstOrDefault<producto>();
            }
            return nProducto;
        }
        //metodo para modificar los datos de un producto
        public void modificarProducto(producto unProducto)
        {
            producto actual = null;
            using (var contexto = new tienda_dbEntities2())
            {
                actual = contexto.productos.Find(unProducto.id);
                actual.nombre = unProducto.nombre;
                actual.precio_compra = unProducto.precio_compra;
                actual.precio_venta = unProducto.precio_venta;
                actual.cantidad_actual = unProducto.cantidad_actual;
                actual.categoria_id = unProducto.categoria_id;
                contexto.SaveChanges();
            }
        }
        //metodo para eliminar los datos de un producto
        public void eliminarProducto(int id)
        {
            using (var contexto = new tienda_dbEntities2())
            {
                producto unProducto = contexto.productos.Find(id);
                contexto.productos.Remove(unProducto);
                contexto.SaveChanges();
            }
        }
        //Método para dar todos los productos

        public List<producto> darProductos()
        {
            var contexto = new tienda_dbEntities2();
            return contexto.productos.ToList();
        }
    }
}
