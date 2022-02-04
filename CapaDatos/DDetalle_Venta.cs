using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DDetalle_Venta
    {
        //Variables 
        private int _IdDetalle_venta;
        private int _IdVenta;
        private int _IdDetall_ingreso;
        private int _Cantidad;
        private decimal _Precio_venta;
        private decimal _Descuento;


        //Propiedades
        public int IdDetalle_venta
        {
            get { return _IdDetalle_venta; }
            set { _IdDetalle_venta = value; }
        }

        public int IdVenta
        {
            get { return _IdVenta; }
            set { _IdVenta = value; }
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
        public DDetalle_Venta()
        {

        }
        public DDetalle_Venta(int idDetalle_venta,int idVenta, int idDetalle_ingreso,int cantidad,decimal precio_venta,decimal descuento)
        {
            this.IdDetalle_venta = idDetalle_venta;
            this.IdVenta = IdVenta;
            this.IdDetall_ingreso = idDetalle_ingreso;
            this.Cantidad = cantidad;
            this.Precio_venta = precio_venta;
            this.Descuento = descuento;
        }

        //Metodo Insertar
        //Le pasamos como paramatro una instancia de la clase para utilizar un objeto y acceder a las variables 
        public string Inserta(DDetalle_Venta Detalle_venta, ref SqlConnection Con, ref SqlTransaction Tran)
        {
            string respuesta = "";
            try
            {
                //Establecer el comando
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.Transaction = Tran;
                cmd.CommandText = "spinsertar_detalle_venta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDetalle_venta = new SqlParameter();
                ParIdDetalle_venta.ParameterName = "@IdDetalle_venta";
                ParIdDetalle_venta.SqlDbType = SqlDbType.Int;
                ParIdDetalle_venta.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ParIdDetalle_venta);

                SqlParameter ParIdVenta = new SqlParameter();
                ParIdVenta.ParameterName = "@IdVenta";
                ParIdVenta.SqlDbType = SqlDbType.Int;
                ParIdVenta.Value = Detalle_venta.IdVenta;
                cmd.Parameters.Add(ParIdVenta);

                SqlParameter ParIdDetalle_ingreso = new SqlParameter();
                ParIdDetalle_ingreso.ParameterName = "@IdDetalle_ingreso";
                ParIdDetalle_ingreso.SqlDbType = SqlDbType.Int;
                ParIdDetalle_ingreso.Value = Detalle_venta.IdDetall_ingreso;
                cmd.Parameters.Add(ParIdDetalle_ingreso);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@Cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = Detalle_venta.Cantidad;
                cmd.Parameters.Add(ParCantidad);

                SqlParameter ParPrecio_venta = new SqlParameter();
                ParPrecio_venta.ParameterName = "@Precio_venta";
                ParPrecio_venta.SqlDbType = SqlDbType.Money;
                ParPrecio_venta.Value = Detalle_venta.Precio_venta;
                cmd.Parameters.Add(ParPrecio_venta);

                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@Descuento";
                ParDescuento.SqlDbType = SqlDbType.Money;
                ParDescuento.Value = Detalle_venta.Descuento;
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
