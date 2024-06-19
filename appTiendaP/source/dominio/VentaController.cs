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
    public class VentaController
    {
        //atributos
        DatosVentas datVentas;

        //metodo constructor
        public VentaController()
        {
            datVentas = new DatosVentas();
        }
        private void validarDatos(string Fecha, string Hora, string Cliente_Id, string Valor_T, string Impuesto, string Pago_T)
        {

            if (string.IsNullOrEmpty(Cliente_Id))
            {
                throw new Exception("Debe ingresar el documento del cliente");

            }
            if (!validador.esCliente_Id(Cliente_Id))
            {
                throw new Exception("El cliente no tiene el formato correcto");
            }
            if (string.IsNullOrEmpty(Fecha))
            {
                throw new Exception("El campo fecha no debe estar vacío");
            }
            if (!validador.esfecha(Fecha))
            {
                throw new Exception(" formato fecha invalido");
            }
            if (string.IsNullOrEmpty(Hora))
            {
                throw new Exception("El campo hora no debe estar vacío");
            }
            if (string.IsNullOrEmpty(Valor_T))
            {
                throw new Exception("El campo valor_total no debe estar vacío");
            }
            
            if (string.IsNullOrEmpty(Impuesto))
            {
                throw new Exception("El campo impuesto no debe estar vacío");
            }
            if (string.IsNullOrEmpty(Pago_T))
            {
                throw new Exception("El campo pago_total no debe estar vacío");
            }
            

        }




            //metodo para agregar una venta
         public string[] agregarVenta(string nCliente_Id, string nFecha, string nHora,  string nValor_Total, string Impuesto, string nPago_Total)
         {
            string[] respuesta = new string[2];
            try
            {
                validarDatos(nFecha, nHora, nCliente_Id, nValor_Total, Impuesto, nPago_Total);
                venta Venta = new venta();
                {
                    Venta.cliente_id = int.Parse(nCliente_Id);
                    Venta.fecha = DateTime.Parse(nFecha);
                    Venta.hora = TimeSpan.Parse(nHora);
                    Venta.valor_total = float.Parse(nValor_Total);
                    Venta.impuesto = float.Parse(Impuesto);
                    int lid = datVentas.agregarProducto(Venta);
                    respuesta[0] = lid.ToString();
                    respuesta[1] = ";Se agrego la venta correctamente!!";
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

        public string modificarVenta(string nCliente_Id, string idVenta, string nFecha, string nHora, string nValor_Total, string Impuesto, string nPago_Total)
        {
            try
            {
                validarDatos(nCliente_Id, nFecha, nHora, nValor_Total, Impuesto, nPago_Total);
                venta venta = new venta();
                {
                    venta.id = int.Parse(idVenta);
                    venta.cliente_id = int.Parse(nCliente_Id);
                    venta.fecha = DateTime.Parse(nFecha);
                    venta.hora = TimeSpan.Parse(nHora);
                    venta.valor_total = float.Parse(nValor_Total);
                    venta.impuesto = float.Parse(Impuesto);
                    int lid = datVentas.agregarProducto(venta); return "se ha modificado los datos de la venta correctamente";
                }

            }
            catch (Exception ex)
            
            {
                return ex.Message;
                
            }
        }
            //metodo para consultar los datos de un paciente
        public venta consultarVenta(string id)
        {
            return datVentas.consultarProducto(int.Parse(id));
        }

            //metodo para eliminar producto
        public string eliminarVenta(string id)
        {
            datVentas.eliminaDatosProduto(int.Parse(id));
            return "Se eliminaron los datos del produtos correcxtamente!!";
        }

            //método para obtener la lista de pacientes

        public List<venta> darVenta()
        {
            var contexto = new tienda_dbEntities2();
            return contexto.ventas.ToList();
        }    
    }
}
