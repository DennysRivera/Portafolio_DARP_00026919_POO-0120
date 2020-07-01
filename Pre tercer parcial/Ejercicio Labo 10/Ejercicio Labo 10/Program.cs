using System;

namespace Ejercicio_Labo_10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ProxyClass.ISujeto unProxy = new ProxyClass.Proxy();

            byte opc = 0;

            do
            {
                Console.Write("\nMenu\n" + Menu());
                opc = Convert.ToByte(Console.ReadLine());
                
                unProxy.Peticion(opc);
                    
            } while (opc != 5);
        }

        public static string Menu()
        {
            return "1. Agregar cuenta\n" +
                   "2. Ver cuentas almacenadas\n" +
                   "3. Ver cuentas almacenadas y total de las cuentas\n" +
                   "4. Buscar cuentas por letra\n" +
                   "5. Salir\n" +
                   "Opción: ";
        }
    }
}