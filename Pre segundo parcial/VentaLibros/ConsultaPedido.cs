using System;
using System.Collections.Generic;
using System.Data;

namespace VentaLibros
{
    public class ConsultaPedido
    {
        public static List<Pedido> articulosStock()
        {
            var dt = Conexion.ExecuteQuery($"SELECT * FROM INVENTARIO");
            List<Pedido> pedidos = new List<Pedido>();

            foreach (DataRow n in dt.Rows)
            {
                Pedido p = new Pedido();
                p.id_pedido = Convert.ToInt32(n[0]);
                p.id_usuario = Convert.ToInt32(n[1].ToString());
                p.nombre_usuario = n[2].ToString();
                p.id_inventario = Convert.ToInt32(n[3]);
                p.fecha_pedido = Convert.ToDateTime(n[4].ToString());
                pedidos.Add(p);
            }

            return pedidos;    
        }
        
        public static void agregarPedido(Inventario nuevo, Usuario usuario, DateTime fecha, int total, int cantidad)
        {
            Conexion.ExecuteNonQuery($"INSERT INTO PEDIDO(id_usuario, nombre_usuario, id_libro, " + 
                                     $"fecha_pedido, cantidad, cliente_nombre, total) " +
                                     $"VALUES('{usuario.id_usuario}," +
                                     $" '{usuario.usuario}'," +
                                     $"{nuevo.id_libro}," +
                                     $"{fecha})," +
                                     $"{cantidad}," +
                                     $"'{usuario.nombre}'," +
                                     $"{total}");
        }
    }
}