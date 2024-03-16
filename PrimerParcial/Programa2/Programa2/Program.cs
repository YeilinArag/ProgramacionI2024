using System;
namespace Programa2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero, suma = 0, promedio;
            int cantidad = 0;

            Console.Write("Ingrese un número (0 para terminar): ");
            numero = double.Parse(Console.ReadLine());

            while (numero != 0) {
                suma += numero;
                cantidad++;

                Console.Write("Ingrese otro número (0 para terminar): ");
                numero = double.Parse (Console.ReadLine());

            }

            if (cantidad > 0)
            {
                promedio = suma / cantidad;
                Console.WriteLine("\nLa suma de todos los números es: " + suma);
                Console.WriteLine("El promedio es: " + promedio);
            }
            else
            {
                Console.WriteLine("No ingresó ningún número");
            }
        }
    }
}
