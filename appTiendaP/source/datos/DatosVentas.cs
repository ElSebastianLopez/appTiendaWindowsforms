using appTiendaP.source.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTiendaP.source.datos
{
    public class DatosVentas
    {
        //metodo para agregar un producto
        public int agregarProducto(venta unaVenta)
        {
            int id = -1;
            using (var contexto = new tienda_dbEntities2())
            {
                contexto.ventas.Add(unaVenta);
                contexto.SaveChanges();
                id = unaVenta.id;
            }
            return id;
        }
        //metodo para consultar producto
        public venta consultarProducto(int id)
        {
            venta nVen = null;
            using (var contexto = new tienda_dbEntities2())
            {
                nVen = contexto.ventas
                    .Where(s => s.id ==id)
                    .FirstOrDefault<venta>();
            }
            return nVen;
        }
        //metodo para modificar los datos de un producto
        public void modificarProducto(venta unaVenta)
        {
            venta actual = null;
            using (var contexto = new tienda_dbEntities2())
            {
                actual = contexto.ventas.Find(unaVenta.id);
                actual.cliente_id = unaVenta.cliente_id;
                actual.fecha = unaVenta.fecha;
                actual.hora = unaVenta.hora;
                actual.valor_total = unaVenta.valor_total;
                actual.impuesto = unaVenta.impuesto;
                actual.pago_total = unaVenta.pago_total;
                contexto.SaveChanges();
            }
        }
        //metodo para eliminar los datos de un producto
        public void eliminaDatosProduto(int id)
        {
            using (var contexto = new tienda_dbEntities2())
            {
                venta unaVenta = contexto.ventas.Find(id);
                contexto.ventas.Remove(unaVenta);
                contexto.SaveChanges();
            }
        }
        //Método para dar todos los productos

        public List<venta> darProducto()
        {
            var contexto = new tienda_dbEntities2();
            return contexto.ventas.ToList();
        }
    }
}
