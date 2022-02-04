using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DDetalle_Cotizacion
    {
        //Variables 
        private int _IdDetalle_cotizacion;
        private int _IdCotizacion;
        private int _IdDetall_ingreso;
        private int _Cantidad;
        private decimal _Precio_venta;
        private decimal _Descuento;

        //Propiedades
        public int IdDetalle_cotizacion
        {
            get { return _IdDetalle_cotizacion; }
            set { _IdDetalle_cotizacion = value; }
        }

        public int IdCotizacion
        {
            get { return _IdCotizacion; }
            set { _IdCotizacion = value; }
        }

        public int IdDetall_ingreso
        {
            get { return _IdDetall_ingreso; }
            set { _IdDetall_ingreso = value; }
        }

        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public decimal Precio_venta
        {
            get { return _Precio_venta; }
            set { _Precio_venta = value; }
        }

        public decimal Descuento
        {
            get { return _Descuento; }
            set { _Descuento = value; }
        }

        //Constructores
        public DDetalle_Cotizacion()
        {

        }

        public DDetalle_Cotizacion(int idDetalle_cotizacion, int idCotizacion, int idDetalle_ingreso, int cantidad, decimal precio_venta, decimal descuento)
        {
            this.IdDetalle_cotizacion = idDetalle_cotizacion;
            this.IdCotizacion = idCotizacion;
            this.IdDetall_ingreso = idDetalle_ingreso;
            this.Cantidad = cantidad;
            this.Precio_venta = precio_venta;
            this.Descuento = descuento;
        }

        //Metodo Insertar
        //Le pasamos como paramatro una instancia de la clase para utilizar un objeto y acceder a las variables 
        public string Inserta(DDetalle_Cotizacion Detalle_cotizacion, ref SqlConnection Con, ref SqlTransaction Tran)
        {
            string respuesta = "";
            try
            {
                //Establecer el comando
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.Transaction = Tran;
                cmd.CommandText = "spinsertar_detalle_cotizacion";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDetalle_cotizacion = new SqlParameter();
                ParIdDetalle_cotizacion.ParameterName = "@IdDetalle_cotizacion";
                ParIdDetalle_cotizacion.SqlDbType = SqlDbType.Int;
                ParIdDetalle_cotizacion.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ParIdDetalle_cotizacion);

                SqlParameter ParIdCotizacion = new SqlParameter();
                ParIdCotizacion.ParameterName = "@IdCotizacion";
                ParIdCotizacion.SqlDbType = SqlDbType.Int;
                ParIdCotizacion.Value = Detalle_cotizacion.IdCotizacion;
                cmd.Parameters.Add(ParIdCotizacion);

                SqlParameter ParIdDetalle_ingreso = new SqlParameter();
                ParIdDetalle_ingreso.ParameterName = "@IdDetalle_ingreso";
                ParIdDetalle_ingreso.SqlDbType = SqlDbType.Int;
                ParIdDetalle_ingreso.Value = Detalle_cotizacion.IdDetall_ingreso;
                cmd.Parameters.Add(ParIdDetalle_ingreso);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@Cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = Detalle_cotizacion.Cantidad;
                cmd.Parameters.Add(ParCantidad);

                SqlParameter ParPrecio_venta = new SqlParameter();
                ParPrecio_venta.ParameterName = "@Precio_venta";
                ParPrecio_venta.SqlDbType = SqlDbType.Money;
                ParPrecio_venta.Value = Detalle_cotizacion.Precio_venta;
                cmd.Parameters.Add(ParPrecio_venta);

                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@Descuento";
                ParDescuento.SqlDbType = SqlDbType.Money;
                ParDescuento.Value = Detalle_cotizacion.Descuento;
                cmd.Parameters.Add(ParDescuento);

                //Ejecutamo nuestro comando
                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            return respuesta;
        }
    }
}
