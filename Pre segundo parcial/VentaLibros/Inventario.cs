using System;

namespace VentaLibros
{
    public class Inventario
    {
        public int id_libro { get; set; }
        public string nombre_libro { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }
        
        public Inventario(){ }

        public Inventario(int idLibro, string nombreLibro, string desc, double price, int disponibles)
        {
            id_libro = idLibro;
            nombre_libro = nombreLibro;
            descripcion = desc;
            precio = price;
            stock = disponibles;
        }
    }
}