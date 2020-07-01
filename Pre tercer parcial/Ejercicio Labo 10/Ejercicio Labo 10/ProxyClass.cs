using System;
using System.Collections.Generic;

namespace Ejercicio_Labo_10
{
    public class ProxyClass
    {
        public interface ISujeto
        {
            void Peticion(int opc);
        }

        public class Proxy : ISujeto
        {
            private List<CuentaBancaria> cuentas = new List<CuentaBancaria>();
            private delegate void unDelegate();
            private static unDelegate ud;
            public void Peticion(int opc)
            {
                Action<List<CuentaBancaria>> anAction;
                
                anAction = MostrarCuentas;
                anAction += MostralTotal;
                anAction += NombresVocal;
                
                switch (opc)
                {
                    case 1:
                        string nombre = "";
                        double saldo = 0;
                        do
                        {
                            Console.Write("Nombre del propietario de la cuenta: ");
                            nombre = Console.ReadLine();
                            Console.Write("Saldo con la que se abre la cuenta: $");
                            saldo = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

                            if (nombre.Equals("") || saldo < 10)
                                Console.WriteLine("Nombre inválido o cantidad debajo de la permitida(10)");

                        } while (nombre.Equals("") || saldo < 10);

                        cuentas.Add(new CuentaBancaria(nombre, saldo));
                        Console.WriteLine("Cuenta agregada");
                        break;
                    
                    case 2:
                        if (cuentas.Count == 0)
                            Console.WriteLine("\nNo hay cuentas que ver");
                        else
                            MostrarCuentas(cuentas);
                        break;

                    case 3:
                        if (cuentas.Count == 0)
                            Console.WriteLine("\nNo hay cuentas que ver");
                        else
                        {
                            ud = () =>
                            {
                                cuentas.ForEach(cu =>
                                {
                                    Console.WriteLine(
                                        $"Propietario: {cu.propietario} | Saldo actual: ${cu.saldoActual}");
                                });
                            };
                            ud += () =>
                            {
                                double total = 0;
                                cuentas.ForEach(cu => { total += cu.saldoActual; });
                                Console.WriteLine("Total de las cuentas: $" + total);
                            };

                            ud.Invoke();
                        }

                        break;

                    case 4:
                        if (cuentas.Count == 0)
                            Console.WriteLine("\nNo hay cuentas que ver");
                        else
                            anAction.Invoke(cuentas);
                        break;

                    case 5:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }
            
            private void MostrarCuentas(List<CuentaBancaria> cuentas)
            {
                cuentas.ForEach(cu =>
                {
                    Console.WriteLine(
                        $"Propietario: {cu.propietario} | Saldo actual: ${cu.saldoActual}");
                });
            }

            private void MostralTotal(List<CuentaBancaria> cuentas)
            {
                double total = 0;
                cuentas.ForEach(cu => { total += cu.saldoActual; });
                Console.WriteLine("Total de las cuentas: $" + total);
            }

            private void NombresVocal(List<CuentaBancaria> cuentas)
            {
                Console.WriteLine("\nCuentas de personas cuyo nombre inicia con vocal");
                cuentas.ForEach(cu =>
                {
                    switch (cu.propietario[0])
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            Console.WriteLine(
                                $"Propietario: {cu.propietario} | Saldo actual: ${cu.saldoActual}");

                            break;
                    }
                });
            }
        }
        
        private class CuentaBancaria
        {
            public String propietario;
            public double saldoActual;

            public CuentaBancaria(String nombre = "Sin nombre", double saldoA = 0)
            {
                propietario = nombre;
                saldoActual = saldoA;
            }
        }
    }
}