using appTiendaP.source.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTiendaP.source.datos
{
    public class DatosCategoria
    {
        //método para agregar una categoria
        public int agregarCategoria(categoria Categoria)
        {
            int id = -1;
            using (var contexto = new tienda_dbEntities2())
            {
                contexto.categorias.Add(Categoria);
                contexto.SaveChanges();
                id = Categoria.id;
            }
            return id;
        }
        //método para consultar categoria
        public categoria consultarCategoria(string Nombre)
        {
            categoria nCategoria = null;
            using (var contexto = new tienda_dbEntities2())
            {
                nCategoria = contexto.categorias
                    .Where(s => s.nombre == Nombre)
                    .FirstOrDefault<categoria>();
            }
            return nCategoria;
        }
        //método para modificar los datos de una categoria
        public void modificarCategoria(categoria Categoria)
        {
            categoria actual = null;
            using (var contexto = new tienda_dbEntities2())
            {
                actual = contexto.categorias.Find(Categoria.id);
                actual.nombre = Categoria.nombre;
                contexto.SaveChanges();
            }
        }
        //método para eliminar los datos de una categoria
        public void eliminarCategoria(int id)
        {
            using (var contexto = new tienda_dbEntities2())
            {
                categoria Categoria = contexto.categorias.Find(id);
                contexto.categorias.Remove(Categoria);
                contexto.SaveChanges();
            }
        }
        //Método para dar todos los categorias

        public List<categoria> darCategoria()
        {
            var contexto = new tienda_dbEntities2();
            return contexto.categorias.ToList();
        }
    }
}

