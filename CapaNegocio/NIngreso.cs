using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;


namespace CapaNegocio
{
    public class NIngreso
    {
        //Metodo Insertar que llama al metodo insertar de la clase DIngreso de la CapaDatos
        public static string Insertar(int idTrabajador,int idProveedor, DateTime fecha, string tipo_comprobante, string serie, string correlativo,
            decimal iGV,string estado,DataTable dtDetalles)
        {
            DIngreso Obj = new DIngreso();
            Obj.IdTrabajador = idTrabajador;
            Obj.IdProveedor = idProveedor;
            Obj.Fecha = fecha;
            Obj.Tipo_comprobante = tipo_comprobante;
            Obj.Serie = serie;
            Obj.Correlativo = correlativo;
            Obj.IGV = iGV;
            Obj.Estado = estado;
            List<DDetalle_Ingreso> detalles = new List<DDetalle_Ingreso>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                DDetalle_Ingreso detalle = new DDetalle_Ingreso();
                detalle.IdArticulo = Convert.ToInt32(row["IdArticulo"].ToString());
                detalle.Precio_compra = Convert.ToDecimal(row["Precio_compra"].ToString());
                detalle.Precio_venta = Convert.ToDecimal(row["Precio_venta"].ToString());
                detalle.Stock_inicial = Convert.ToInt32(row["Stock_inicial"].ToString());
                detalle.Stock_final = Convert.ToInt32(row["Stock_inicial"].ToString());
                detalle.Fecha_produccion = Convert.ToDateTime(row["Fecha_produccion"].ToString());
                detalle.Fecha_vencimiento = Convert.ToDateTime(row["Fecha_vencimiento"].ToString());
                detalles.Add(detalle);

            }
            return Obj.Insertar(Obj, detalles);
        }

        //Metodo Eliminar que llama al metodo Eliminar de la clase DIngreso de la CapaDatos
        public static string Anular(int idIngreso)
        {
            DIngreso Obj = new DIngreso();
            Obj.IdIngreso = idIngreso;
            return Obj.Anular(Obj);
        }

        //Metodo Mostrar que llama al metodo Mostrar de la clase DIngreso de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DIngreso().Mostrar();
        }

        //Metodo BuscarNombre que llama al metodo BuscarNombre de la clase DIngreso de la CapaDatos
        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DIngreso Obj = new DIngreso();
            return Obj.BuscarFechas(textobuscar,textobuscar2);
        }

        //Metodo MostrarDetalle que llama al metodo BuscarNombre de la clase DIngreso de la CapaDatos
        public static DataTable MostrarDetalle(string textobuscar)
        {
            DIngreso Obj = new DIngreso();
            return Obj.MostrarDetalle(textobuscar);
        }
    }
}
