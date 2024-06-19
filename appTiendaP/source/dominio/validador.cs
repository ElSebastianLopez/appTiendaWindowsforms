using appTiendaP.source.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appTiendaP.source.dominio
{
    internal class validador
    {
        //validador cliente
        public static bool esCliente(string nCliente)
        {
            Regex re = new Regex(@"\A[0-9]{7,10}\Z");
            return re.IsMatch(nCliente);
        }
        public static bool es_nombre(string nNombre)
        {
            Regex re = new Regex(@"[a-zA-Z]+$");
            return re.IsMatch(nNombre);
        }
        public static bool es_apellido(string nApellidos)
        {
            Regex re = new Regex(@"[a-zA-Z]+$");
            return re.IsMatch((string)nApellidos);
        }

        public static bool es_Telefono(string nTelefono)
        {
            Regex re = new Regex(@"\A[0-9]{10}\Z");
            return re.IsMatch(nTelefono);
        }

        public static bool es_email(string nEmail)
        {
            Regex re = new Regex(@"\A[a-zA-ZñÑ0-9._\-]+@[a-zA-ZñÑ0-9]+.(com|edu|es|gov)\Z");
            return re.IsMatch(nEmail);
        }


        // validador ventas
        public static bool esCliente_Id(string cliente)
        {
            Regex re = new Regex(@"\A[0-9]{0,10}\Z");
            return re.IsMatch(cliente);
        }
        public static bool esfecha(string fecha)

        {
            Regex re = new Regex(@"\A(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}\Z");
            return re.IsMatch(fecha);
        }
        public static bool esHora(string hora)
        {
            Regex re = new Regex(@"[a-zA-Z]+$");
            return re.IsMatch((string)hora);
        }
        public static bool esValorT(string valor_total)
        {
            Regex re = new Regex(@"\A[0-9]{10}\Z");
            return re.IsMatch(valor_total);
        }

        public static bool esImp(string impuesto)
        {
            Regex re = new Regex(@"\A[0-9]{10}\Z");
            return re.IsMatch(impuesto);
        }
        public static bool esPago(string pago)
        {
            Regex re = new Regex(@"\A[0-9]{10}\Z");
            return re.IsMatch(pago);
        }

        //validador producto
        public static bool esProducto(string nNombre)
        {
            Regex re = new Regex(@"[a-zA-Z]+$");
            return re.IsMatch(nNombre);
        }
        public static bool esPrecioC(string nPrecio_compra)
        {
            Regex re = new Regex(@"\A[0-9]{0-9}\Z");
            return re.IsMatch(nPrecio_compra);
        }
        public static bool esPrecioV(string nPrecio_venta)
        {
            Regex re = new Regex(@"\A[0-9]{0-9}\Z");
            return re.IsMatch(nPrecio_venta);
        }
        public static bool esCategoria(string nCategoria)
        {
            Regex re = new Regex(@"\A[0-9]{0,10}\Z");
            return re.IsMatch(nCategoria);
        }



    }
}
