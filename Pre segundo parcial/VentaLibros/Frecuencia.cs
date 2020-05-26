using System;

namespace VentaLibros
{
    public class Frecuencia
    {
        public string usuario { get; set; }
        public int cantidad { get; set; }
        public string ultimoIngreso { get; set; }

        public Frecuencia()
        {
            usuario = "";
            cantidad = 0;
            ultimoIngreso = "";
        }
    }
}