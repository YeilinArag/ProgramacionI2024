using System;
namespace Numeros_Primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.Write("Ingrese un numero entero positivo: ");
            } while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 1);

            bool esPrimo = true;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            if (esPrimo)
            {
                Console.WriteLine($"El número {numero} es primo.");
            }
            else
            {
                Console.WriteLine($"El número {numero} no es primo.");
            }
            Console.ReadLine();
        }
    }
}
