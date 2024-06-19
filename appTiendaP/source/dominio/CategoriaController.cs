using appTiendaP.source.datos;
using appTiendaP.source.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTiendaP.source.dominio
{
    public class CategoriaController
    {
        DatosCategoria datCategoria;

        //metodo constructor
        public CategoriaController()
        {
            datCategoria = new DatosCategoria();
        }
        //metodo para agregar un nuevo producto
        public string[] agregarCategoria(string nNombre)
        {
            string[] respuesta = new string[2];
            try
            {
                //Producto pro = new Producto();
                categoria Categoria = new categoria();
                {
                    Categoria.nombre = nNombre;

                    int lid = datCategoria.agregarCategoria(Categoria);
                    respuesta[0] = lid.ToString();
                    respuesta[1] = ";Se agrego la categoria correctamente!!";
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

        public string modificarCategoria(string id, string nNombre)
        {
            try
            {
                categoria Categoria = new categoria();
                {
                    Categoria.id = int.Parse(id);
                    Categoria.nombre = nNombre;
                    
                    datCategoria.modificarCategoria(Categoria);
                    return "se han modificado los datos de la categoria correctamente";
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        //metodo para consultar los datos de un paciente
        public categoria consultarCategoria(string Nombre)
        {
            return datCategoria.consultarCategoria(Nombre);
        }

        //metodo para eliminar producto
        public string eliminarCategoria(string id)
        {
            datCategoria.eliminarCategoria(int.Parse(id));
            return "Se eliminaron los datos de la categoria  correcxtamente!!";
        }

        //método para obtener la lista de pacientes

        public List<categoria> darCategoria()
        {
            var contexto = new tienda_dbEntities2();
            return contexto.categorias.ToList();
        }

    }
}

