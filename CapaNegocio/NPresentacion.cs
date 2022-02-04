using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NPresentacion
    {
        //Metodo Insertar que llama al metodo insertar de la clase DPresentacion de la CapaDatos
        public static string Insertar(string nombre, string descripcion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Inserta(Obj);
        }

        //Metodo Editar que llama al metodo Editar de la clase DPresentacion de la CapaDatos
        public static string Editar(int idPresentacion, string nombre, string descripcion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.IdPresentacion = idPresentacion;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            return Obj.Editar(Obj);
        }

        //Metodo Eliminar que llama al metodo Eliminar de la clase DPresentacion de la CapaDatos
        public static string Eliminar(int idPresentacion)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.IdPresentacion = idPresentacion;
            return Obj.Eliminar(Obj);
        }

        //Metodo Mostrar que llama al metodo Mostrar de la clase DPresentacion de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DPresentacion().Mostrar();
        }

        //Metodo BuscarNombre que llama al metodo BuscarNombre de la clase DPresentacion de la CapaDatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            DPresentacion Obj = new DPresentacion();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
    }
}
