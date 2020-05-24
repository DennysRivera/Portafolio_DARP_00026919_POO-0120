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

        public Pedido(int idPedido, int idUsuario, string nombreUsuario, int idInventario, DateTime fechaPedido)
        {
            id_pedido = idPedido;
            id_usuario = idUsuario;
            nombre_usuario = nombreUsuario;
            id_inventario = idInventario;
            fecha_pedido = fechaPedido;
        }
    }
}