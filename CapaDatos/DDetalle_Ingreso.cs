using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DDetalle_Ingreso
    {
        //Variables
        private int _IdDetalle_ingreso;
        private int _IdIngreso;
        private int _IdArticulo;
        private decimal _Precio_compra;
        private decimal _Precio_venta;
        private int _Stock_inicial;
        private int _Stock_final;
        private DateTime _Fecha_produccion;
        private DateTime _Fecha_vencimiento;

        //Propiedades
        public int IdDetalle_ingreso
        {
            get { return _IdDetalle_ingreso; }
            set { _IdDetalle_ingreso = value; }
        }

        public int IdIngreso
        {
            get { return _IdIngreso; }
            set { _IdIngreso = value; }
        }

        public int IdArticulo
        {
            get { return _IdArticulo; }
            set { _IdArticulo = value; }
        }

        public decimal Precio_compra
        {
            get { return _Precio_compra; }
            set { _Precio_compra = value; }
        }

        public decimal Precio_venta
        {
            get { return _Precio_venta; }
            set { _Precio_venta = value; }
        }

        public int Stock_inicial
        {
            get { return _Stock_inicial; }
            set { _Stock_inicial = value; }
        }

        public int Stock_final
        {
            get { return _Stock_final; }
            set { _Stock_final = value; }
        }

        public DateTime Fecha_produccion
        {
            get { return _Fecha_produccion; }
            set { _Fecha_produccion = value; }
        }

        public DateTime Fecha_vencimiento
        {
            get { return _Fecha_vencimiento; }
            set { _Fecha_vencimiento = value; }
        }

        //Constructores
        public DDetalle_Ingreso()
        {

        }
        public DDetalle_Ingreso(int idDetalle_ingreso,int idIngreso,int idArticulo,decimal precio_compra,decimal precio_venta,int stock_inicial,
            int stock_final,DateTime fecha_produccion,DateTime fecha_vencimiento)
        {
            this.IdDetalle_ingreso = idDetalle_ingreso;
            this.IdIngreso = idIngreso;
            this.IdArticulo = idArticulo;
            this.Precio_compra = precio_compra;
            this.Precio_venta = precio_venta;
            this.Stock_inicial = stock_inicial;
            this.Stock_final = stock_final;
            this.Fecha_produccion = fecha_produccion;
            this.Fecha_vencimiento = fecha_vencimiento;
        }

        //Metodo Insertar
        //Le pasamos como paramatro una instancia de la clase para utilizar un objeto y acceder a las variables 
        public string Inserta(DDetalle_Ingreso Detalle_Ingreso, ref SqlConnection Con,ref SqlTransaction Tran)
        {
            string respuesta = "";
            try
            {
                //Establecer el comando
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.Transaction = Tran;
                cmd.CommandText = "spinsertar_detalle_ingreso";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDetalle_ingreso = new SqlParameter();
                ParIdDetalle_ingreso.ParameterName = "@IdDetalle_ingreso";
                ParIdDetalle_ingreso.SqlDbType = SqlDbType.Int;
                ParIdDetalle_ingreso.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ParIdDetalle_ingreso);

                SqlParameter ParIdIngreso = new SqlParameter();
                ParIdIngreso.ParameterName = "@IdIngreso";
                ParIdIngreso.SqlDbType = SqlDbType.Int;
                ParIdIngreso.Value = Detalle_Ingreso.IdIngreso;
                cmd.Parameters.Add(ParIdIngreso);

                SqlParameter ParIdArticulo = new SqlParameter();
                ParIdArticulo.ParameterName = "@IdArticulo";
                ParIdArticulo.SqlDbType = SqlDbType.Int;
                ParIdArticulo.Value = Detalle_Ingreso.IdArticulo;
                cmd.Parameters.Add(ParIdArticulo);

                SqlParameter ParPrecio_compra = new SqlParameter();
                ParPrecio_compra.ParameterName = "@Precio_compra";
                ParPrecio_compra.SqlDbType = SqlDbType.Money;
                ParPrecio_compra.Value = Detalle_Ingreso.Precio_compra;
                cmd.Parameters.Add(ParPrecio_compra);

                SqlParameter ParPrecio_venta = new SqlParameter();
                ParPrecio_venta.ParameterName = "@Precio_venta";
                ParPrecio_venta.SqlDbType = SqlDbType.Money;
                ParPrecio_venta.Value = Detalle_Ingreso.Precio_venta;
                cmd.Parameters.Add(ParPrecio_venta);

                SqlParameter ParStock_final = new SqlParameter();
                ParStock_final.ParameterName = "@Stock_final";
                ParStock_final.SqlDbType = SqlDbType.Int;
                ParStock_final.Value = Detalle_Ingreso.Stock_final;
                cmd.Parameters.Add(ParStock_final);

                SqlParameter ParStock_inicial = new SqlParameter();
                ParStock_inicial.ParameterName = "@Stock_inicial";
                ParStock_inicial.SqlDbType = SqlDbType.Int;
                ParStock_inicial.Value = Detalle_Ingreso.Stock_inicial;
                cmd.Parameters.Add(ParStock_inicial);

                SqlParameter ParFecha_produccion = new SqlParameter();
                ParFecha_produccion.ParameterName = "@Fecha_produccion";
                ParFecha_produccion.SqlDbType = SqlDbType.Date;
                ParFecha_produccion.Value = Detalle_Ingreso.Fecha_produccion;
                cmd.Parameters.Add(ParFecha_produccion);

                SqlParameter ParFecha_vencimiento = new SqlParameter();
                ParFecha_vencimiento.ParameterName = "@Fecha_vencimiento";
                ParFecha_vencimiento.SqlDbType = SqlDbType.Date;
                ParFecha_vencimiento.Value = Detalle_Ingreso.Fecha_vencimiento;
                cmd.Parameters.Add(ParFecha_vencimiento);

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
