using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DCliente
    {
        //variables
        private int _IdCliente;
        private string _Nombre;
        private string _Apellido;
        private string _Sexo;
        private DateTime _Fecha_nacimiento;
        private string _Tipo_documento;
        private string _Num_documento;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _TextoBuscar;


        //Propiedades metodos Setter and Getter
        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public string Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value; }
        }

        public DateTime Fecha_nacimiento
        {
            get { return _Fecha_nacimiento; }
            set { _Fecha_nacimiento = value; }
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

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        //Constructores
        public DCliente()
        {

        }

        public DCliente(int idCliente,string nombre, string apellido, string sexo,
            DateTime fecha_nacimiento,string tipo_documento,string num_documento,string direccion, string telefono,string email, string textobuscar)
        {
            this.IdCliente = idCliente;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sexo = sexo;
            this.Fecha_nacimiento = fecha_nacimiento;
            this.Tipo_documento = tipo_documento;
            this.Num_documento = num_documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.TextoBuscar = textobuscar;
        }

        //Metodos
        //Metodos
        //Metodo insertar
        //Le pasamos como paramatro una instancia de la clase para utilizar un objeto y acceder a las variables 
        public string Inserta(DCliente Cliente)
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
                cmd.CommandText = "spinsertar_cliente";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@IdCliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ParIdCliente);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Cliente.Nombre;
                cmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@Apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 40;
                ParApellidos.Value = Cliente.Apellido;
                cmd.Parameters.Add(ParApellidos);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@Sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Cliente.Sexo;
                cmd.Parameters.Add(ParSexo);

                SqlParameter ParFecha_nacimiento= new SqlParameter();
                ParFecha_nacimiento.ParameterName = "@Fecha_nacimiento";
                ParFecha_nacimiento.SqlDbType = SqlDbType.DateTime;
                ParFecha_nacimiento.Size = 50;
                ParFecha_nacimiento.Value = Cliente.Fecha_nacimiento;
                cmd.Parameters.Add(ParFecha_nacimiento);

                SqlParameter ParTipo_documento = new SqlParameter();
                ParTipo_documento.ParameterName = "@Tipo_documento";
                ParTipo_documento.SqlDbType = SqlDbType.VarChar;
                ParTipo_documento.Size = 20;
                ParTipo_documento.Value = Cliente.Tipo_documento;
                cmd.Parameters.Add(ParTipo_documento);

                SqlParameter ParNum_documento = new SqlParameter();
                ParNum_documento.ParameterName = "@Num_documento";
                ParNum_documento.SqlDbType = SqlDbType.VarChar;
                ParNum_documento.Size = 11;
                ParNum_documento.Value = Cliente.Num_documento;
                cmd.Parameters.Add(ParNum_documento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Cliente.Direccion;
                cmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 10;
                ParTelefono.Value = Cliente.Telefono;
                cmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Cliente.Email;
                cmd.Parameters.Add(ParEmail);


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
        public string Editar(DCliente Cliente)
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
                cmd.CommandText = "speditar_cliente";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@IdCliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Cliente.IdCliente;
                cmd.Parameters.Add(ParIdCliente);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Cliente.Nombre;
                cmd.Parameters.Add(ParNombre);

                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@Apellidos";
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 40;
                ParApellidos.Value = Cliente.Apellido;
                cmd.Parameters.Add(ParApellidos);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@Sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Cliente.Sexo;
                cmd.Parameters.Add(ParSexo);

                SqlParameter ParFecha_nacimiento = new SqlParameter();
                ParFecha_nacimiento.ParameterName = "@Fecha_nacimiento";
                ParFecha_nacimiento.SqlDbType = SqlDbType.DateTime;
                ParFecha_nacimiento.Size = 50;
                ParFecha_nacimiento.Value = Cliente.Fecha_nacimiento;
                cmd.Parameters.Add(ParFecha_nacimiento);

                SqlParameter ParTipo_documento = new SqlParameter();
                ParTipo_documento.ParameterName = "@Tipo_documento";
                ParTipo_documento.SqlDbType = SqlDbType.VarChar;
                ParTipo_documento.Size = 20;
                ParTipo_documento.Value = Cliente.Tipo_documento;
                cmd.Parameters.Add(ParTipo_documento);

                SqlParameter ParNum_documento = new SqlParameter();
                ParNum_documento.ParameterName = "@Num_documento";
                ParNum_documento.SqlDbType = SqlDbType.VarChar;
                ParNum_documento.Size = 11;
                ParNum_documento.Value = Cliente.Num_documento;
                cmd.Parameters.Add(ParNum_documento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Cliente.Direccion;
                cmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 10;
                ParTelefono.Value = Cliente.Telefono;
                cmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Cliente.Email;
                cmd.Parameters.Add(ParEmail);

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
        public string Eliminar(DCliente Cliente)
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
                cmd.CommandText = "spelimiar_cliente";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@IdCliente";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Value = Cliente.IdCliente;
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
            DataTable DtResultado = new DataTable("Cliente");
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Sqlcon;
                cmd.CommandText = "spmostrar_cliente";
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
        public DataTable BuscarApellidos(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("Cliente");
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Sqlcon;
                cmd.CommandText = "spbuscar_cliente_apellidos";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.TextoBuscar;
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
        public DataTable BuscarNum_Documento(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("Cliente");
            SqlConnection Sqlcon = new SqlConnection();
            try
            {
                Sqlcon.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Sqlcon;
                cmd.CommandText = "spbuscar_cliente_num_documento";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.TextoBuscar;
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
