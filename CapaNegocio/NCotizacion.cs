using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class NCotizacion
    {
        //Metodo Insertar que llama al metodo insertar de la clase DVenta de la CapaDatos
        public static string Insertar(int idCliente, int idTrabajador, DateTime fecha, decimal iGV, 
            DataTable dtDetalles, bool estadoNCF, string comprobanteFiscal)
        {
            DCotizacion Obj = new DCotizacion();
            decimal total = 0;
            Obj.IdCliente = idCliente;
            Obj.IdTrabajador = idTrabajador;
            Obj.Fecha = fecha;
            Obj.IGV = iGV;
            Obj.ComprobanteFiscal = comprobanteFiscal;

            List<DDetalle_Cotizacion> detalles = new List<DDetalle_Cotizacion>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                DDetalle_Cotizacion detalle = new DDetalle_Cotizacion();
                detalle.IdDetall_ingreso = Convert.ToInt32(row["IdDetalle_ingreso"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["Cantidad"].ToString());
                detalle.Precio_venta = Convert.ToDecimal(row["Precio_venta"].ToString());
                detalle.Descuento = Convert.ToDecimal(row["Descuento"].ToString());
                total += Convert.ToDecimal(row["Subtotal"].ToString());
                detalles.Add(detalle);

            }

            if (estadoNCF)
            {
                Obj.SubTotal = total;
                Obj.Total = total + (total * 18 / 100);
            }
            else
            {
                Obj.SubTotal = total;
                Obj.Total = total;
            }

            return Obj.Insertar(Obj, detalles);
        }

        //Metodo Eliminar que llama al metodo Anular de la clase DVenta de la CapaDatos
        public static string Eliminar(int idCotizacion)
        {
            DCotizacion Obj = new DCotizacion();
            Obj.IdCotizacion = idCotizacion;
            return Obj.Elminar(Obj);
        }

        //Metodo Mostrar que llama al metodo Mostrar de la clase DVenta de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DCotizacion().Mostrar();
        }

        //Metodo BuscarNombre que llama al metodo BuscarFechas de la clase DVenta de la CapaDatos
        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DCotizacion Obj = new DCotizacion();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }

        //Metodo MostrarDetalle que llama al metodo BuscarNombre de la clase DVenta de la CapaDatos
        public static DataTable MostrarDetalle(string textobuscar)
        {
            DCotizacion Obj = new DCotizacion();
            return Obj.MostrarDetalle(textobuscar);
        }
    }
}
