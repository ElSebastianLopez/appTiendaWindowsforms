using appTiendaP.source.datos;
using appTiendaP.source.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTiendaP.source.dominio
{
    public class ClienteController
    {
        DatosCliente datCliente;

        //metodo constructor
        public ClienteController()
        {
            datCliente = new DatosCliente();
        }
        private void validarDatos(string nDocumento, string nNombre, string nApellidos, string nTelefono, string nEmail)
        {



            if (string.IsNullOrEmpty(nDocumento))
            {
                throw new Exception("Debe ingresar el documento del cliente");

            }
            if (!validador.esCliente(nDocumento))
            {
                throw new Exception("El documento no tiene el formato correcto");
            }
            if (string.IsNullOrEmpty(nNombre))
            {
                throw new Exception("El campo nombre no debe estar vacío");
            }
            if (!validador.es_apellido(nApellidos))
            {
                throw new Exception("El campo apellido no debe estar vacío");
            }
            if (string.IsNullOrEmpty(nTelefono))
            {
                throw new Exception("El campo telefono no debe estar vacío");
            }
            if (!validador.es_Telefono(nTelefono))
            {
                throw new Exception("El telefono no tiene el formato correcto");
            }

            if (!validador.es_email(nEmail))
            {
                throw new Exception("El email es requerido y debe tener el formato correcto");
            }
        }
        //metodo para agregar un nuevo producto
        public string[] agregarCliente(string nDocumento, string nNombre, string nApellidos, string nTelefono, string nEmail)
        {
            string[] respuesta = new string[2];
            try
            {
                validarDatos(nDocumento,nNombre,nApellidos,nTelefono,nEmail);
                cliente Cliente = new cliente();
                {
                    Cliente.documento = nDocumento;
                    Cliente.nombres = nNombre;
                    Cliente.apellidos = nApellidos;
                    Cliente.telefono = nTelefono;
                    Cliente.email = nEmail;
                    int lid = datCliente.agregarCliente(Cliente);
                    respuesta[0] = lid.ToString();
                    respuesta[1] = "Se agrego el cliente correctamente!!";
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

        public string modificarCliente(string id, string nDocumento, string nNombre, string nApellidos, string nTelefono, string nEmail)
        {
            try
            {
                validarDatos(nDocumento, nNombre, nApellidos, nTelefono, nEmail);
                cliente Cliente = new cliente();
                {
                    Cliente.id = int.Parse(id);
                    Cliente.documento = nDocumento;
                    Cliente.nombres = nNombre;
                    Cliente.apellidos = nApellidos;
                    Cliente.telefono = nTelefono;
                    Cliente.email = nEmail;
                    datCliente.modificarCategoria(Cliente);
                    return "se han modificado los datos del cliente correctamente";
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        //metodo para consultar los datos de un paciente
        public cliente consultarCliente(string Doc)
        {
            return datCliente.consultarCliente(Doc);
        }

        //metodo para eliminar producto
        public string eliminarCliente(string id)
        {
            datCliente.eliminarCliente(int.Parse(id));
            return "Se eliminaron los datos del cliente  correcxtamente!!";
        }

        //método para obtener la lista de pacientes

        public List<cliente> darCliente()
        {
            var contexto = new tienda_dbEntities2();
            return contexto.clientes.ToList();
        }

    }
}
