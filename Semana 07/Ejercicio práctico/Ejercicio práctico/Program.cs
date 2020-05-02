using System;

namespace Ejercicio_práctico
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool continuar = true;
            do{
                try////Excepción para campo vacío
                   ////Segunda excepción en Banco
                {
                    Console.Write(Menu());
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1: Banco.RegistrarTarjeta(); break;
                        case 2: Banco.ConsultarTarjetas(); break;
                        case 3: ConsolaJuegos.ComprarJuego(); break;
                        case 4: ConsolaJuegos.Jugar(); break;
                        case 5: continuar = false; break;
                        default: Console.WriteLine("Opcion errónea!"); break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("No se reconoció la opción");
                }
            }while(continuar);
            Console.WriteLine("\nTenga un buen día!");
        }
    
        static string Menu(){
            return "\nBienvenido:\n" +
                   "1) Registrar tarjeta (banco).\n" +
                   "2) Consultar tarjetas (banco).\n" +
                   "3) Comprar videojuego (consola).\n" +
                   "4) Jugar videojuego (consola).\n" +
                   "5) Salir.\n" +
                   "Opción elegida: ";
        }
    }
}