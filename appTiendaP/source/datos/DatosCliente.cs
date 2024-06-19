using appTiendaP.source.entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appTiendaP;

namespace appTiendaP.source.datos
{
    public class DatosCliente
    {
        //atributo para la conexión de la base de datos
        private SqlConnection conn;

        //método constructor
        public DatosCliente()
        {
            string strConn = @"data source = localhost\sqlexpress;
            initial catalog = Tienda_db;
integrated security = true";
            conn = new SqlConnection(strConn);
            conn.Open();
        }
        //metodo para agregar una categoria
        public int agregarCliente(cliente unCliente)
        {
            int id = -1;
            using (var contexto = new tienda_dbEntities2())
            {
                contexto.clientes.Add(unCliente);
                contexto.SaveChanges();
                id = unCliente.id;
            }
            return id;
        }
        //metodo para consultar un cliente
        public cliente consultarCliente(string Documento)
        {
            cliente nCliente = null;
            using (var contexto = new tienda_dbEntities2())
            {
                nCliente = contexto.clientes
                    .Where(s => s.documento == Documento)
                    .FirstOrDefault<cliente>();
            }
            return nCliente;
        }
        //metodo para modificar los datos de una categoria
        public void modificarCategoria(cliente unCliente)
        {
            cliente actual = null;
            using (var contexto = new tienda_dbEntities2())
            {
                actual = contexto.clientes.Find(unCliente.id);
                actual.documento = unCliente.documento; 
                actual.nombres = unCliente.nombres;
                actual.apellidos = unCliente.apellidos;
                actual.telefono = unCliente.telefono;
                actual.email = unCliente.email;
                contexto.SaveChanges();
            }
        }
        //metodo para eliminar los datos de una categoria
        public void eliminarCliente(int id)
        {
            using (var contexto = new tienda_dbEntities2())
            {
                cliente unCliente = contexto.clientes.Find(id);
                contexto.clientes.Remove(unCliente);
                contexto.SaveChanges();
            }
        }
        //Método para dar todos los categorias

        public List<cliente> darCliente()
        {
            var contexto = new tienda_dbEntities2();
            return contexto.clientes.ToList();
        }
    }
}
