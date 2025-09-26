//Simulación de cjero automatico

using System;

namespace CajeroAutomatico
{
    class Program
    {
        // Variable global que representa el saldo de la cuenta bancaria
        static double saldo = 0.0;

        static void Main()
        {
            int opcion;

            do
            {
                // Menú principal
                Console.WriteLine("\nSIMULACIÓN DE CAJERO AUTOMÁTICO");
                Console.WriteLine("1. Depositar dinero");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("3. Consultar saldo");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                // Validación de la opción ingresada
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Depositar();
                            break;
                        case 2:
                            Retirar();
                            break;
                        case 3:
                            ConsultarSaldo();
                            break;
                        case 4:
                            Console.WriteLine("Gracias por usar el cajero. ¡Hasta pronto!");
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Intente nuevamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor ingrese un número.");
                    opcion = 0; // para que continúe el bucle
                }

            } while (opcion != 4);
        }

        // Método para depositar dinero
        static void Depositar()
        {
            Console.Write("Ingrese la cantidad a depositar: ");
            if (double.TryParse(Console.ReadLine(), out double cantidad) && cantidad > 0)
            {
                saldo += cantidad;
                Console.WriteLine($"Depósito exitoso. Su nuevo saldo es: {saldo:C2}");
            }
            else
            {
                Console.WriteLine("Cantidad inválida. Intente nuevamente.");
            }
        }

        // Método para retirar dinero (valida que no exceda el saldo disponible)
        static void Retirar()
        {
            Console.Write("Ingrese la cantidad a retirar: ");
            if (double.TryParse(Console.ReadLine(), out double cantidad) && cantidad > 0)
            {
                if (cantidad <= saldo)
                {
                    saldo -= cantidad;
                    Console.WriteLine($"Retiro exitoso. Su nuevo saldo es: {saldo:C2}");
                }
                else
                {
                    Console.WriteLine("Fondos insuficientes. No se pudo realizar el retiro.");
                }
            }
            else
            {
                Console.WriteLine("Cantidad inválida. Intente nuevamente.");
            }
        }

        // Método para consultar el saldo actual
        static void ConsultarSaldo()
        {
            Console.WriteLine($"Su saldo actual es: {saldo:C2}");
        }
    }
}
