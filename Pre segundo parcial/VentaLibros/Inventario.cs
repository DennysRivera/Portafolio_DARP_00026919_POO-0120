using System;
using System.Security.Permissions;

namespace VentaLibros
{
    public class Inventario
    {
        public int id_libro { get; set; }
        public string nombre_libro { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }

        public Inventario()
        {
            nombre_libro = "";
            descripcion = "";
            precio = 0;
            stock = 0;
        }
        
    }
}