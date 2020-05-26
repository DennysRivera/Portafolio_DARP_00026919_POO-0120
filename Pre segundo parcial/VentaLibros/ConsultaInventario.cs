using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace VentaLibros
{
    public class ConsultaInventario
    {
        public static List<Inventario> articulosStock()
        {
            var dt = Conexion.ExecuteQuery($"SELECT * FROM INVENTARIO");
            List<Inventario> stock = new List<Inventario>();

            foreach (DataRow n in dt.Rows)
            {
                Inventario i = new Inventario();
                i.nombre_libro = n[1].ToString();
                i.descripcion = n[2].ToString();
                i.precio = (decimal)(n[3]);
                i.stock = Convert.ToInt32(n[4].ToString());
                stock.Add(i);
            }

            return stock;    
        }
        
        public static void agregarArticulo(Inventario nuevo)
        {
            Conexion.ExecuteNonQuery($"INSERT INTO INVENTARIO(nombre_libro, descripcion, precio, stock) " +
                                     $"VALUES('{nuevo.nombre_libro}'," +
                                     $" '{nuevo.descripcion}'," +
                                     $"{nuevo.precio}," +
                                     $"'{nuevo.stock}')");
        }
        
        public static void actualizarArticulo(Inventario libro, int extras)
        {
            Conexion.ExecuteNonQuery($"UPDATE INVENTARIO SET libro_nombre = '{libro.nombre_libro}," +
                                     $"descripcion = '{libro.descripcion}'," +
                                     $"precio = {libro.precio}," +
                                     $"stock = {(libro.stock + extras)}" +
                                     $"WHERE nombre_lirbo = '{libro.nombre_libro}'");
        }
    }
    
}