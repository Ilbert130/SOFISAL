using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NArticulo
    {
        //Metodo Insertar que llama al metodo insertar de la clase DPresentacion de la CapaDatos
        public static string Insertar(string codigo ,string nombre, string descripcion, byte[] imagen, int idCategoria, int idPresentacion)
        {
            DArticulo Obj = new DArticulo();
            Obj.Codigo = codigo;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Imagen = imagen;
            Obj.IdCategoria = idCategoria;
            Obj.IdPresentacion = idPresentacion;
            return Obj.Inserta(Obj);
        }

        //Metodo Editar que llama al metodo Editar de la clase DPresentacion de la CapaDatos
        public static string Editar(int idArticulo, string codigo, string nombre, string descripcion, byte[] imagen, int idCategoria, int idPresentacion)
        {
            DArticulo Obj = new DArticulo();
            Obj.IdArticulo = idArticulo;
            Obj.Codigo = codigo;
            Obj.Nombre = nombre;
            Obj.Descripcion = descripcion;
            Obj.Imagen = imagen;
            Obj.IdCategoria = idCategoria;
            Obj.IdPresentacion = idPresentacion;
            return Obj.Editar(Obj);
        }

        //Metodo Eliminar que llama al metodo Eliminar de la clase DPresentacion de la CapaDatos
        public static string Eliminar(int idArticulo)
        {
            DArticulo Obj = new DArticulo();
            Obj.IdArticulo = idArticulo;
            return Obj.Eliminar(Obj);
        }

        //Metodo Mostrar que llama al metodo Mostrar de la clase DPresentacion de la CapaDatos
        public static DataTable Mostrar()
        {
            return new DArticulo().Mostrar();
        }

        //Metodo BuscarNombre que llama al metodo BuscarNombre de la clase DPresentacion de la CapaDatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            DArticulo Obj = new DArticulo();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }

        //Metodo BuscarNombre que llama al metodo BuscarNombre de la clase DPresentacion de la CapaDatos
        public static DataTable BuscarCodgio(string textobuscar)
        {
            DArticulo Obj = new DArticulo();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCodgio(Obj);
        }

        //Metodo de la consulta del Stock de los articulos que llama al metodo Stock_Articulos de la clase DArticulo de la CapaDatos
        public static DataTable Stock_Articulos()
        {
            return new DArticulo().Stock_Articulos();
        }

        //Metodo BuscarStockArticuloNombre que llama al metodo BuscarStockArticuloNombre de la clase DPresentacion de la CapaDatos
        public static DataTable BuscarStockArticuloNombre(string textobuscar)
        {
            DArticulo Obj = new DArticulo();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarStockArticuloNombre(Obj);
        }

        //Metodo BuscarStockArticuloCodigo que llama al metodo BuscarStockArticuloNombre de la clase DPresentacion de la CapaDatos
        public static DataTable BuscarStockArticuloCodigo(string textobuscar)
        {
            DArticulo Obj = new DArticulo();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarStockArticuloCodigo(Obj);
        }
    }
}
