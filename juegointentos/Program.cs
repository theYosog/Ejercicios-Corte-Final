//Crea un programa que use una variable global para almacenar el
//número de intentos de adivinar un número secreto. Cada intento se
//registra y se muestra.

using System;

namespace AdivinarNumero
{
    class Program
    {
        // Variable global para contar intentos
        static int intentos = 0;

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int numeroSecreto = rnd.Next(1, 11); // Número secreto entre 1 y 10
            int numeroUsuario;

            Console.WriteLine(" ADIVINA EL NÚMERO SECRETO (entre 1 y 10)");

            do
            {
                // Validación de entrada
                while (true)
                {
                    Console.Write(" Ingresa un número (1-10): ");

                    // Comprobar si es un número entero
                    if (!int.TryParse(Console.ReadLine(), out numeroUsuario))
                    {
                        Console.WriteLine(" Error: Ingresa un número válido.");
                        continue; // vuelve a pedir
                    }

                    // Comprobar si está dentro del rango
                    if (numeroUsuario < 1 || numeroUsuario > 10)
                    {
                        Console.WriteLine(" Error: El número debe estar entre 1 y 10.");
                        continue; // vuelve a pedir
                    }

                    // Si pasa ambas validaciones, salimos del bucle
                    break;
                }

                intentos++; // cada intento válido se cuenta

                if (numeroUsuario < numeroSecreto)
                {
                    Console.WriteLine(" El número secreto es MAYOR.");
                }
                else if (numeroUsuario > numeroSecreto)
                {
                    Console.WriteLine(" El número secreto es MENOR.");
                }
                else
                {
                    Console.WriteLine($" ¡Correcto! El número secreto era {numeroSecreto}.");
                }

                Console.WriteLine($" Intentos realizados: {intentos}\n");

            } while (numeroUsuario != numeroSecreto);

            Console.WriteLine(" Juego terminado.");
        }
    }
}
