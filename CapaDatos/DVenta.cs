using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class DVenta
    {
        //Variables 
        private int _IdVenta;
        private int _IdCliente;
        private int _IdTrabajador;
        private DateTime _Fecha;
        private string _Tipo_comprobante;
        private string _Serie;
        private string _Correlativo;
        private decimal _IGV;
        private decimal _Pago;
        private decimal _Total;
        private string _ComprobanteFiscal;
        private decimal _SubTotal;

        
        //Propiedades
        public int IdVenta
        {
            get { return _IdVenta; }
            set { _IdVenta = value; }
        }

        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        public int IdTrabajador
        {
            get { return _IdTrabajador; }
            set { _IdTrabajador = value; }
        }

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        public string Tipo_comprobante
        {
            get { return _Tipo_comprobante; }
            set { _Tipo_comprobante = value; }
        }

        public string Serie
        {
            get { return _Serie; }
            set { _Serie = value; }
        }

        public string Correlativo
        {
            get { return _Correlativo; }
            set { _Correlativo = value; }
        }

        public decimal IGV
        {
            get { return _IGV; }
            set { _IGV = value; }
        }
        public decimal Pago
        {
            get { return _Pago; }
            set { _Pago = value; }
        }

        public decimal Total 
        { 
            get { return _Total; } 
            set { _Total = value; } 
        }

        public string ComprobanteFiscal 
        {
            get { return _ComprobanteFiscal; }
            set { _ComprobanteFiscal = value; }
        }

        public decimal SubTotal 
        { 
            get { return _SubTotal; } 
            set{ _SubTotal = value; } 
        }

        //Constructores
        public DVenta()
        {

        }

        public DVenta(int idVenta,int idCliente,int idTrabajador, DateTime fecha, string tipo_comprobante,string serie,string correlativo,decimal iGV,decimal pago, decimal total,string comprobanteFiscal)
        {
            this.IdVenta = idVenta;
            this.IdCliente = idCliente;
            this.IdTrabajador = idTrabajador;
            this.Fecha = fecha;
            this.Tipo_comprobante = tipo_comprobante;
            this.Serie = serie;
            this.Correlativo = correlativo;
            this.IGV = iGV;
            this.Pago = pago;
            this.Total = total;
            this.ComprobanteFiscal = comprobanteFiscal;
        }

        //Metodos
        //Metodo anular
        //Le pasamos como paramatro una instancia de la clase para utilizar un objeto y acceder a las variables 
        public string DisminuirStock(int idDetalle_ingreso,int cantidad)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Codigo
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el comando
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SqlCon;
                cmd.CommandText = "spdisminuir_stock";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdDetalle_ingreso = new SqlParameter();
                ParIdDetalle_ingreso.ParameterName = "@IdDetalle_ingreso";
                ParIdDetalle_ingreso.SqlDbType = SqlDbType.Int;
                ParIdDetalle_ingreso.Value = idDetalle_ingreso;
                cmd.Parameters.Add(ParIdDetalle_ingreso);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@Cantidad";
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = cantidad;
                cmd.Parameters.Add(ParCantidad);

                //Ejecutamo nuestro comando
                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el stock";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return respuesta;
        }

        //Metodo insertar
        //Le pasamos como paramatro una instancia de la clase para utilizar un objeto y acceder a las variables 
        //public string Inserta(DIngreso Ingreso, List<DDetalle_Ingreso> Detalle)
        //{

        //}

        public string Insertar(DVenta Venta, List<DDetalle_Venta> Detalle)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Codigo
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer transaccion
                SqlTransaction Tran = SqlCon.BeginTransaction();
                //Establecer el comando
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SqlCon;
                cmd.Transaction = Tran;
                cmd.CommandText = "spinsertar_venta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdVenta= new SqlParameter();
                ParIdVenta.ParameterName = "@IdVenta";
                ParIdVenta.SqlDbType = SqlDbType.Int;
                ParIdVenta.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ParIdVenta);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@IdCliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Venta.IdCliente;
                cmd.Parameters.Add(ParIdCliente);

                SqlParameter ParIdTrabajador = new SqlParameter();
                ParIdTrabajador.ParameterName = "@IdTrabajador";
                ParIdTrabajador.SqlDbType = SqlDbType.Int;
                ParIdTrabajador.Value = Venta.IdTrabajador;
                cmd.Parameters.Add(ParIdTrabajador);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@Fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Venta.Fecha;
                cmd.Parameters.Add(ParFecha);

                SqlParameter ParTipo_comprobante = new SqlParameter();
                ParTipo_comprobante.ParameterName = "@Tipo_comprobante";
                ParTipo_comprobante.SqlDbType = SqlDbType.VarChar;
                ParTipo_comprobante.Size = 20;
                ParTipo_comprobante.Value = Venta.Tipo_comprobante;
                cmd.Parameters.Add(ParTipo_comprobante);

                SqlParameter ParSerie = new SqlParameter();
                ParSerie.ParameterName = "@Serie";
                ParSerie.SqlDbType = SqlDbType.VarChar;
                ParSerie.Size = 4;
                ParSerie.Value = Venta.Serie;
                cmd.Parameters.Add(ParSerie);

                SqlParameter ParCorrelativo = new SqlParameter();
                ParCorrelativo.ParameterName = "@Correlativo";
                ParCorrelativo.SqlDbType = SqlDbType.VarChar;
                ParCorrelativo.Size = 7;
                ParCorrelativo.Value = Venta.Correlativo;
                cmd.Parameters.Add(ParCorrelativo);

                SqlParameter ParIGV = new SqlParameter();
                ParIGV.ParameterName = "@IGV";
                ParIGV.SqlDbType = SqlDbType.Decimal;
                ParIGV.Precision = 4;
                ParIGV.Scale = 2;
                ParIGV.Value = Venta.IGV;
                cmd.Parameters.Add(ParIGV);

                SqlParameter ParPago = new SqlParameter();
                ParPago.ParameterName = "@Pago";
                ParPago.SqlDbType = SqlDbType.Money;
                ParPago.Value = Venta.Pago;
                cmd.Parameters.Add(ParPago);

                //Modificacion realizada
                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@Total";
                ParTotal.SqlDbType = SqlDbType.Money;
                ParTotal.Value = Venta.Total;
                cmd.Parameters.Add(ParTotal);

                SqlParameter ParComprobanteFiscal= new SqlParameter();
                ParComprobanteFiscal.ParameterName = "@ComprobanteFiscal";
                ParComprobanteFiscal.SqlDbType = SqlDbType.VarChar;
                ParComprobanteFiscal.Size = 50;
                ParComprobanteFiscal.Value = Venta.ComprobanteFiscal;
                cmd.Parameters.Add(ParComprobanteFiscal);

                //Modificacion realizada
                SqlParameter ParSubTotal = new SqlParameter();
                ParSubTotal.ParameterName = "@SubTotal";
                ParSubTotal.SqlDbType = SqlDbType.Money;
                ParSubTotal.Value = Venta.SubTotal;
                cmd.Parameters.Add(ParSubTotal);


                //Ejecutamo nuestro comando
                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";

                if (respuesta.Equals("OK"))
                {
                    //Obtener el codigo del ingreso generado
                    this.IdVenta = Convert.ToInt32(cmd.Parameters["@IdVenta"].Value);
                    foreach (DDetalle_Venta det in Detalle)
                    {
                        det.IdVenta = this.IdVenta;
                        //Llamar al metodo insertar de la clase DDetalle_Ingreso
                        respuesta = det.Inserta(det, ref SqlCon, ref Tran);
                        if (!respuesta.Equals("OK"))
                        {
                            break;
                        }
                        else
                        {
                            //si se ensertan los detalles de ventas vamos actualizar el stock
                            respuesta = DisminuirStock(det.IdDetall_ingreso,det.Cantidad);
                            if (!respuesta.Equals("OK"))
                            {
                                break;
                            }
                        }
                    }
                }
                if (respuesta.Equals("OK"))
                {
                    Tran.Commit();
                }
                else
                {
                    Tran.Rollback();
                }
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return respuesta;
        }

        //Metodo Eliminar
        //Le pasamos como paramatro una instancia de la clase para utilizar un objeto y acceder a las variables 
        public string Elminar(DVenta Venta)
        {
            string respuesta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Codigo
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el comando
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SqlCon;
                cmd.CommandText = "speliminar_venta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdVenta = new SqlParameter();
                ParIdVenta.ParameterName = "@IdVenta";
                ParIdVenta.SqlDbType = SqlDbType.Int;
                ParIdVenta.Value = Venta.IdVenta;
                cmd.Parameters.Add(ParIdVenta);

                //Ejecutamo nuestro comando
                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "OK";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return respuesta;

        }

        //Metodo Mostrar
        //Es de tipo DataTable por que va a devolver todas las filas de la tabla categoria 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Venta");
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Sqlcon;
                cmd.CommandText = "spmostrar_venta";
                cmd.CommandType = CommandType.StoredProcedure;

                //El sqlDataAdapter es para llenar el datatable y este procedure no esta resiviendo ningun parametro
                SqlDataAdapter sqlDat = new SqlDataAdapter(cmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //Metodo Buscar entre fechas
        //Le pasamos como paramatro una instancia de la clase para utilizar un objeto y acceder a las variables 
        //Es de tipo DataTable 
        public DataTable BuscarFechas(string TextoBuscar, string TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("Venta");
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Sqlcon;
                cmd.CommandText = "spbuscar_venta_fecha";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                cmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 50;
                ParTextoBuscar2.Value = TextoBuscar2;
                cmd.Parameters.Add(ParTextoBuscar2);

                //El sqlDataAdapter es para llenar el datatable y este procedure no esta resiviendo ningun parametro
                SqlDataAdapter sqlDat = new SqlDataAdapter(cmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        //Metodo Mostrar Detalles
        //Le pasamos como paramatro una instancia de la clase para utilizar un objeto y acceder a las variables 
        //Es de tipo DataTable 
        public DataTable MostrarDetalle(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("Detalle_venta");
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Sqlcon;
                cmd.CommandText = "spmostrar_detalle_venta";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                cmd.Parameters.Add(ParTextoBuscar);

                //El sqlDataAdapter es para llenar el datatable y este procedure no esta resiviendo ningun parametro
                SqlDataAdapter sqlDat = new SqlDataAdapter(cmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //Metodo para buscar y mostrar los Articulos por su nombre
        public DataTable MostrarArticulo_Venta_Nombre(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("Articulo");
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Sqlcon;
                cmd.CommandText = "spbuscararticulo_venta_nombre";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                cmd.Parameters.Add(ParTextoBuscar);

                //El sqlDataAdapter es para llenar el datatable y este procedure no esta resiviendo ningun parametro
                SqlDataAdapter sqlDat = new SqlDataAdapter(cmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //
        public DataTable MostrarArticulo_Venta_codigo(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("Articulo");
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Sqlcon;
                cmd.CommandText = "spbuscararticulo_venta_codigo";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                cmd.Parameters.Add(ParTextoBuscar);

                //El sqlDataAdapter es para llenar el datatable y este procedure no esta resiviendo ningun parametro
                SqlDataAdapter sqlDat = new SqlDataAdapter(cmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

    }
}
