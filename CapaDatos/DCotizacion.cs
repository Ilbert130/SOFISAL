using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCotizacion
    {
        //Variables 
        private int _IdCotizacion;
        private int _IdCliente;
        private int _IdTrabajador;
        private DateTime _Fecha;
        private decimal _IGV;
        private decimal _Total;
        private string _ComprobanteFiscal;
        private decimal _SubTotal;

        //Propiedades
        public int IdCotizacion
        {
            get { return _IdCotizacion; }
            set { _IdCotizacion = value; }
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

        public decimal IGV
        {
            get { return _IGV; }
            set { _IGV = value; }
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
            set { _SubTotal = value; }
        }

        //Constructores
        public DCotizacion()
        {

        }

        public DCotizacion(int idCotizacion, int idCliente, int idTrabajador, DateTime fecha, decimal iGV, decimal total, string comprobanteFiscal)
        {
            this.IdCotizacion = IdCotizacion;
            this.IdCliente = idCliente;
            this.IdTrabajador = idTrabajador;
            this.Fecha = fecha;
            this.IGV = iGV;
            this.Total = total;
            this.ComprobanteFiscal = comprobanteFiscal;
        }

        //Metodo insertar
        public string Insertar(DCotizacion Cotizacion, List<DDetalle_Cotizacion> Detalle)
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
                cmd.CommandText = "spinsertar_cotizacion";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCotizacion = new SqlParameter();
                ParIdCotizacion.ParameterName = "@IdCotizacion";
                ParIdCotizacion.SqlDbType = SqlDbType.Int;
                ParIdCotizacion.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ParIdCotizacion);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@IdCliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Cotizacion.IdCliente;
                cmd.Parameters.Add(ParIdCliente);

                SqlParameter ParIdTrabajador = new SqlParameter();
                ParIdTrabajador.ParameterName = "@IdTrabajador";
                ParIdTrabajador.SqlDbType = SqlDbType.Int;
                ParIdTrabajador.Value = Cotizacion.IdTrabajador;
                cmd.Parameters.Add(ParIdTrabajador);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@Fecha";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Cotizacion.Fecha;
                cmd.Parameters.Add(ParFecha);

                SqlParameter ParIGV = new SqlParameter();
                ParIGV.ParameterName = "@IGV";
                ParIGV.SqlDbType = SqlDbType.Decimal;
                ParIGV.Precision = 4;
                ParIGV.Scale = 2;
                ParIGV.Value = Cotizacion.IGV;
                cmd.Parameters.Add(ParIGV);

                //Modificacion realizada
                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@Total";
                ParTotal.SqlDbType = SqlDbType.Money;
                ParTotal.Value = Cotizacion.Total;
                cmd.Parameters.Add(ParTotal);

                SqlParameter ParComprobanteFiscal = new SqlParameter();
                ParComprobanteFiscal.ParameterName = "@ComprobanteFiscal";
                ParComprobanteFiscal.SqlDbType = SqlDbType.VarChar;
                ParComprobanteFiscal.Size = 50;
                ParComprobanteFiscal.Value = Cotizacion.ComprobanteFiscal;
                cmd.Parameters.Add(ParComprobanteFiscal);

                //Modificacion realizada
                SqlParameter ParSubTotal = new SqlParameter();
                ParSubTotal.ParameterName = "@SubTotal";
                ParSubTotal.SqlDbType = SqlDbType.Money;
                ParSubTotal.Value = Cotizacion.SubTotal;
                cmd.Parameters.Add(ParSubTotal);


                //Ejecutamo nuestro comando
                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";

                if (respuesta.Equals("OK"))
                {
                    //Obtener el codigo del ingreso generado
                    this.IdCotizacion = Convert.ToInt32(cmd.Parameters["@IdCotizacion"].Value);
                    foreach (DDetalle_Cotizacion det in Detalle)
                    {
                        det.IdCotizacion = this.IdCotizacion;
                        //Llamar al metodo insertar de la clase DDetalle_Ingreso
                        respuesta = det.Inserta(det, ref SqlCon, ref Tran);
                        if (!respuesta.Equals("OK"))
                        {
                            break;
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
        public string Elminar(DCotizacion Cotizacion)
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
                cmd.CommandText = "speliminar_cotizacion";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCotizacion = new SqlParameter();
                ParIdCotizacion.ParameterName = "@IdCotizacion";
                ParIdCotizacion.SqlDbType = SqlDbType.Int;
                ParIdCotizacion.Value = Cotizacion.IdCotizacion;
                cmd.Parameters.Add(ParIdCotizacion);

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
            DataTable DtResultado = new DataTable("Cotizacion");
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Sqlcon;
                cmd.CommandText = "spmostrar_cotizacion";
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
            DataTable DtResultado = new DataTable("Cotizacion");
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Sqlcon;
                cmd.CommandText = "spbuscar_cotizacion_fecha";
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
            DataTable DtResultado = new DataTable("Detalle_cotizacion");
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Sqlcon;
                cmd.CommandText = "spmostrar_detalle_cotizacion";
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
