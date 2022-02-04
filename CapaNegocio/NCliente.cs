using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NCliente
    {
        //Metodos para comunicarno con la capa datos
        //Metodo Insertar que llama al metodo insertar de la clase DCliente de la CapaDatos
        public static string Insertar(string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string tipo_documento, string num_documento, string direccion, string telefono, string email)
        {
            DCliente Obj = new DCliente();
            Obj.Nombre = nombre;
            Obj.Apellido = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_nacimiento = fecha_nacimiento;
            Obj.Tipo_documento = tipo_documento;
            Obj.Num_documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            return Obj.Inserta(Obj);
        }

        //Metodo Editar que llama al metodo Editar de la clase DCliente de la CapaDatos
        public static string Editar(int idCliente, string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string tipo_documento, string num_documento, string direccion, string telefono, string email)
        {
            DCliente Obj = new DCliente();
            Obj.IdCliente = idCliente;
            Obj.Nombre = nombre;
            Obj.Apellido = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_nacimiento = fecha_nacimiento;
            Obj.Tipo_documento = tipo_documento;
            Obj.Num_documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            return Obj.Editar(Obj);
        }

        //Metodo Eliminar que llama al metodo Eliminar de la clase DCliente de la CapaDatos
        public static string Eliminar(int idCliente)
        {
            DCliente Obj = new DCliente();
            Obj.IdCliente=idCliente;
            return Obj.Eliminar(Obj);
        }

        //Metodo Mostrar que llama al metodo Mostrar de la clase DCliente de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DCliente().Mostrar();
        }

        //Metodo BuscarApellidos que llama al metodo BuscarApellidos de la clase DCliente de la CapaDatos
        public static DataTable BuscarApellidos(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarApellidos(Obj);
        }

        //Metodo BuscarNum_Documento que llama al metodo BuscarNum_Documento de la clase DCliente de la CapaDatos
        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }
    }
}
