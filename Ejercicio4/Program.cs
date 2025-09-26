//Gestión de notas de estudiantes
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionNotas
{
    class Program
    {
        // Lista global que almacena todas las notas
        static List<double> notas = new List<double>();

        static void Main()
        {
            int opcion;

            do
            {
                // Menú principal
                Console.WriteLine("\nGESTIÓN DE NOTAS DE ESTUDIANTES");
                Console.WriteLine("1. Agregar nota");
                Console.WriteLine("2. Calcular promedio");
                Console.WriteLine("3. Mostrar nota más alta y más baja");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                // Validamos que el usuario ingrese un número entero
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            AgregarNota();
                            break;
                        case 2:
                            CalcularPromedio();
                            break;
                        case 3:
                            MostrarMayorYMenor();
                            break;
                        case 4:
                            Console.WriteLine("¡Hasta pronto!");
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Ingrese un número.");
                    opcion = 0; // para que el menú vuelva a mostrarse
                }

            } while (opcion != 4);
        }

        // Método para agregar una nota validando que sea correcta
        static void AgregarNota()
        {
            Console.Write("Ingrese la nota (0 a 100): ");
            if (double.TryParse(Console.ReadLine(), out double nota) && nota >= 0 && nota <= 100)
            {
                notas.Add(nota);
                Console.WriteLine("Nota agregada correctamente.");
            }
            else
            {
                Console.WriteLine("Nota inválida. Debe estar entre 0 y 100.");
            }
        }

        // Método para calcular el promedio (usa solo variables locales)
        static void CalcularPromedio()
        {
            if (notas.Count > 0) //Count: elementos que tiene guardados la lista
            {
                double suma = 0;
                foreach (double n in notas)
                {
                    suma += n;
                }
                double promedio = suma / notas.Count;
                Console.WriteLine($"El promedio de las notas es: {promedio:F2}");
            }
            else
            {
                Console.WriteLine("No hay notas registradas.");
            }
        }

        // Método para mostrar la nota más alta y más baja
        static void MostrarMayorYMenor()
        {
            if (notas.Count > 0)
            {
                double max = notas.Max(); // mayor
                double min = notas.Min(); // menor
                Console.WriteLine($"Nota más alta: {max}");
                Console.WriteLine($"Nota más baja: {min}");
            }
            else
            {
                Console.WriteLine("No hay notas registradas.");
            }
        }
    }
}
