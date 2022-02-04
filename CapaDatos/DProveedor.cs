using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DProveedor
    {
        //variable por cada campo de la tabla  en la base de datos
        private int _IdProveedor;
        private string _Razon_social;
        private string _Sector_comercial;
        private string _Tipo_documento;
        private string _Num_documento;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _Url;
        private string _TextoBuscar;

        //Propiedades de las variables
        public int IdProveedor
        {
            get { return _IdProveedor; }
            set { _IdProveedor = value; }
        }

        public string Razon_social
        {
            get { return _Razon_social; }
            set { _Razon_social = value; }
        }

        public string Sector_comercial
        {
            get { return _Sector_comercial; }
            set { _Sector_comercial = value; }
        }

        public string Tipo_documento
        {
            get { return _Tipo_documento; }
            set { _Tipo_documento = value; }
        }

        public string Num_documento
        {
            get { return _Num_documento; }
            set { _Num_documento = value; }
        }

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public string Url
        {
            get { return _Url; }
            set { _Url = value; }
        }

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        //Constructores
        public DProveedor()
        {

        }

        public DProveedor(int idProveedor, string razon_social, string sector_comercial,string tipo_documento, string num_documento,string direccion,string telefono, string email, string url, string textobuscar)
        {
            this.IdProveedor = idProveedor;
            this.Razon_social = razon_social;
            this.Sector_comercial = sector_comercial;
            this.Tipo_documento = tipo_documento;
            this.Num_documento = num_documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.Url = url;
            this.TextoBuscar = textobuscar;
        }

        //Metodos
        //Metodo insertar
        //Le pasamos como paramatro una instancia de la clase para utilizar un objeto y acceder a las variables 
        public string Inserta(DProveedor Proveedor)
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
                cmd.CommandText = "spinsertar_proveedor";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@IdProveedor";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ParIdProveedor);

                SqlParameter ParRazon_social = new SqlParameter();
                ParRazon_social.ParameterName = "@Razon_social";
                ParRazon_social.SqlDbType = SqlDbType.VarChar;
                ParRazon_social.Size = 150;
                ParRazon_social.Value = Proveedor.Razon_social;
                cmd.Parameters.Add(ParRazon_social);

                SqlParameter ParSector_comercial = new SqlParameter();
                ParSector_comercial.ParameterName = "@Sector_comercial";
                ParSector_comercial.SqlDbType = SqlDbType.VarChar;
                ParSector_comercial.Size = 50;
                ParSector_comercial.Value = Proveedor.Sector_comercial;
                cmd.Parameters.Add(ParSector_comercial);

                SqlParameter ParTipo_documento = new SqlParameter();
                ParTipo_documento.ParameterName = "@Tipo_documento";
                ParTipo_documento.SqlDbType = SqlDbType.VarChar;
                ParTipo_documento.Size = 20;
                ParTipo_documento.Value = Proveedor.Tipo_documento;
                cmd.Parameters.Add(ParTipo_documento);

                SqlParameter ParNum_documento = new SqlParameter();
                ParNum_documento.ParameterName = "@Num_documento";
                ParNum_documento.SqlDbType = SqlDbType.VarChar;
                ParNum_documento.Size = 11;
                ParNum_documento.Value = Proveedor.Num_documento;
                cmd.Parameters.Add(ParNum_documento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Proveedor.Direccion;
                cmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 11;
                ParTelefono.Value = Proveedor.Telefono;
                cmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Proveedor.Email;
                cmd.Parameters.Add(ParEmail);

                SqlParameter ParUrl = new SqlParameter();
                ParUrl.ParameterName = "@URL";
                ParUrl.SqlDbType = SqlDbType.VarChar;
                ParUrl.Size = 100;
                ParUrl.Value = Proveedor.Url;
                cmd.Parameters.Add(ParUrl);


                //Ejecutamo nuestro comando
                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";
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

        //Metodo Editar
        //Le pasamos como paramatro una instancia de la clase para utilizar un objeto y acceder a las variables 
        public string Editar(DProveedor Proveedor)
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
                cmd.CommandText = "speditar_proveedor";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@IdProveedor";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Value = Proveedor.IdProveedor;
                cmd.Parameters.Add(ParIdProveedor);

                SqlParameter ParRazon_social = new SqlParameter();
                ParRazon_social.ParameterName = "@Razon_social";
                ParRazon_social.SqlDbType = SqlDbType.VarChar;
                ParRazon_social.Size = 150;
                ParRazon_social.Value = Proveedor.Razon_social;
                cmd.Parameters.Add(ParRazon_social);

                SqlParameter ParSector_comercial = new SqlParameter();
                ParSector_comercial.ParameterName = "@Sector_comercial";
                ParSector_comercial.SqlDbType = SqlDbType.VarChar;
                ParSector_comercial.Size = 50;
                ParSector_comercial.Value = Proveedor.Sector_comercial;
                cmd.Parameters.Add(ParSector_comercial);

                SqlParameter ParTipo_documento = new SqlParameter();
                ParTipo_documento.ParameterName = "@Tipo_documento";
                ParTipo_documento.SqlDbType = SqlDbType.VarChar;
                ParTipo_documento.Size = 20;
                ParTipo_documento.Value = Proveedor.Tipo_documento;
                cmd.Parameters.Add(ParTipo_documento);

                SqlParameter ParNum_documento = new SqlParameter();
                ParNum_documento.ParameterName = "@Num_documento";
                ParNum_documento.SqlDbType = SqlDbType.VarChar;
                ParNum_documento.Size = 11;
                ParNum_documento.Value = Proveedor.Num_documento;
                cmd.Parameters.Add(ParNum_documento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Proveedor.Direccion;
                cmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 11;
                ParTelefono.Value = Proveedor.Telefono;
                cmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Proveedor.Email;
                cmd.Parameters.Add(ParEmail);

                SqlParameter ParUrl = new SqlParameter();
                ParUrl.ParameterName = "@URL";
                ParUrl.SqlDbType = SqlDbType.VarChar;
                ParUrl.Size = 100;
                ParUrl.Value = Proveedor.Url;
                cmd.Parameters.Add(ParUrl);

                //Ejecutamo nuestro comando
                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el registro";
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
        public string Eliminar(DProveedor Proveedor)
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
                cmd.CommandText = "speliminar_proveedor";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@IdProveedor";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Value = Proveedor.IdProveedor;
                cmd.Parameters.Add(ParIdProveedor);

                //Ejecutamo nuestro comando
                respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el registro";
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
            DataTable DtResultado = new DataTable("Proveedor");
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Sqlcon;
                cmd.CommandText = "spmostrar_proveedor";
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

        //Metodo Buscar
        //Le pasamos como paramatro una instancia de la clase para utilizar un objeto y acceder a las variables 
        //Es de tipo DataTable 
        public DataTable BuscarRazon_social(DProveedor Proveedor)
        {
            DataTable DtResultado = new DataTable("Proveedor");
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Sqlcon;
                cmd.CommandText = "spbuscar_proveedor_razon_social";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Proveedor.TextoBuscar;
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

        //Metodo Buscar
        //Le pasamos como paramatro una instancia de la clase para utilizar un objeto y acceder a las variables 
        //Es de tipo DataTable 
        public DataTable BuscarNum_Documento(DProveedor Proveedor)
        {
            DataTable DtResultado = new DataTable("Proveedor");
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Sqlcon;
                cmd.CommandText = "spbuscar_proveedor_num_documento";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Proveedor.TextoBuscar;
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
