using System;

namespace VentaLibros
{
    public class Pedido
    {
        public int id_pedido { get; set; }
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public int id_inventario { get; set; }
        public DateTime fecha_pedido { get; set; }
        
        public Pedido(){ }
    }
}