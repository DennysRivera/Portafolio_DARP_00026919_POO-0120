using System;

namespace Ejercicio_práctico
{
    public class Banco
    {
        public static void RegistrarTarjeta()
        {
            bool flag;
            string numero = "";
            do
            {
                try
                {
                    Console.Write("Número de tarjeta: ");
                    numero = Console.ReadLine().Trim();
                    flag = true;
                    ////Excepción si el campo queda vacío o lleva letras///
                    if (numero.Trim().Equals(""))
                    {
                        throw new FormatException();
                    }
                    
                    foreach (var c in numero)
                    {
                        if ((Char.IsLetter(c)))
                        {
                            throw new FormatException();
                        } 
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Número de tarjeta inválido");
                    flag = false;
                }
            } while (!flag);
            //////////////////////////////

            GestorArchivos.Anexar("Tarjetas.txt", numero);
        
            Console.WriteLine("Tarjeta creada exitosamente!");
        }
    
        public static void ConsultarTarjetas(){
            Console.WriteLine(GestorArchivos.Leer("Tarjetas.txt"));
        }
    
        public static bool RealizarCompras(string tarjeta){
            return GestorArchivos.Buscar("Tarjetas.txt", tarjeta);
        }
    }
}