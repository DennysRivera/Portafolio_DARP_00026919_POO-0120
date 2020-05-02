using System;

namespace Ejercicio_práctico
{
    public class ConsolaJuegos
    {
        public static void ComprarJuego(){
            Console.Write("Número de tarjeta: ");
            string numero = Console.ReadLine();
        
            if(Banco.RealizarCompras(numero)){
                Console.Write("Nombre del juego: ");
                string juego = Console.ReadLine();
            
                GestorArchivos.Anexar("Juegos.txt", juego);
            
                Console.WriteLine("Juego comprado exitosamente!");
            }
        }
    
        public static void Jugar(){
            Console.Write("Nombre del juego: ");
            string juego = Console.ReadLine().Trim();
        
            if(GestorArchivos.Buscar("Juegos.txt", juego))
                Console.WriteLine("Listo para jugar!");
            else
                Console.WriteLine("Primero debe comprar el juego :(");
        }
    }
}