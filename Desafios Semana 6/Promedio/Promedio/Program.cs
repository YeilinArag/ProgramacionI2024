using System;
namespace Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double suma = 0;
            int contador = 0;
            string entrada;


            Console.WriteLine("Ingrese los puntajes del estudiante (1-10) o escriba 'fin' para terminar: ");

            do
            {
                entrada = Console.ReadLine();

                if (double.TryParse(entrada, out double puntaje))
                {
                    if (puntaje >= 1 && puntaje <= 10)
                    {
                        suma += puntaje;
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("El puntaje debe estar entre 1 y 10. Ingrese un valor válido.");
                    }
                }
                else if (entrada.ToLower() != "fin")
                {
                    Console.WriteLine("Entrada inválida. Ingrese un número o escriba 'fin' para terminar.");
                }

            } while (entrada.ToLower() != "fin");

            if (contador > 0)
            {
                double promedio = suma / contador;
                Console.WriteLine($"El puntaje promedio del estudiante es: {promedio}");
            }
            else
            {
                Console.WriteLine("No se ingresaron puntajes válidos.");
            }

            Console.ReadLine();
        }
    }
}

